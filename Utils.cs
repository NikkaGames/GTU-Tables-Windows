using System.IO;
using System;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace GTU_Tables_Windows
{
    public static class Utils
    {
        public static bool IsInternetAvailable()
        {
            try
            {
                var ping = new Ping();
                var reply = ping.Send("8.8.8.8", 1000);
                return reply.Status == IPStatus.Success;
            }
            catch
            {
                return false;
            }
        }

        public static string Encrypt(string input, string key)
        {
            if (string.IsNullOrEmpty(key)) return input;

            var sb = new StringBuilder(input.Length);
            for (int i = 0; i < input.Length; i++)
            {
                int shift = key[i % key.Length] & 0xFFFF;
                char encryptedChar = (char)((input[i] + shift) & 0xFFFF);
                sb.Append(encryptedChar);
            }
            return sb.ToString();
        }

        public static string Decrypt(string input, string key)
        {
            if (string.IsNullOrEmpty(key)) return input;

            var sb = new StringBuilder(input.Length);
            for (int i = 0; i < input.Length; i++)
            {
                int shift = key[i % key.Length] & 0xFFFF;
                char decryptedChar = (char)((input[i] - shift) & 0xFFFF);
                sb.Append(decryptedChar);
            }
            return sb.ToString();
        }

        public static async Task<string> SendAndReceiveAsync(string messageToSend)
        {
            TcpClient client = null;
            try
            {
                client = new TcpClient();
                await client.ConnectAsync("gtu.localto.net", 5000);

                NetworkStream stream = client.GetStream();
                var writer = new BinaryWriter(stream, Encoding.UTF8, leaveOpen: true);
                var reader = new BinaryReader(stream, Encoding.UTF8, leaveOpen: true);

                byte[] messageBytes = Encoding.UTF8.GetBytes(Encrypt(messageToSend, "table"));
                byte[] sizeBytes = Encoding.UTF8.GetBytes(messageBytes.Length.ToString());

                writer.Write(sizeBytes);
                writer.Write(Encoding.UTF8.GetBytes("L"));
                writer.Write(messageBytes);
                writer.Flush();

                string dsize = "";
                while (true)
                {
                    char c = (char)reader.ReadByte();
                    if (c == 'L') break;
                    dsize += c;
                }

                if (!int.TryParse(dsize, out int messageSize)) return null;

                byte[] responseBytes = reader.ReadBytes(messageSize);
                return Decrypt(Encoding.UTF8.GetString(responseBytes), "table");
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
            finally
            {
                client?.Close();
            }
        }
    }
}

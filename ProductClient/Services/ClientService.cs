using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ProductClient.Services
{
    public class ClientService
    {
        public async Task<string> SendRequestAsync(string serverAddress, int port, string request)
        {
            using TcpClient client = new TcpClient();
            await client.ConnectAsync(serverAddress, port);

            using NetworkStream stream = client.GetStream();

            byte[] requestBytes = Encoding.UTF8.GetBytes(request);
            await stream.WriteAsync(requestBytes, 0, requestBytes.Length);

            byte[] buffer = new byte[4096];
            int bytesRead = await stream.ReadAsync(buffer, 0, buffer.Length);

            return Encoding.UTF8.GetString(buffer, 0, bytesRead);
        }
    }
}

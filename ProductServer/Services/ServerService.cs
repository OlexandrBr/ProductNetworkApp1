using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ProductServer.Services
{
    public class ServerService
    {
        private TcpListener? listener;
        private bool isRunning;

        public async Task StartAsync(int port, Func<string, string> handleRequest, Action<string> logAction)
        {
            listener = new TcpListener(IPAddress.Any, port);
            listener.Start();
            isRunning = true;

            logAction($"Сервер запущено на порту {port}");

            while (isRunning)
            {
                try
                {
                    TcpClient client = await listener.AcceptTcpClientAsync();
                    _ = Task.Run(() => HandleClientAsync(client, handleRequest, logAction));
                }
                catch
                {
                    if (!isRunning)
                        break;
                }
            }
        }

        public void Stop(Action<string> logAction)
        {
            isRunning = false;
            listener?.Stop();
            logAction("Сервер зупинено");
        }

        private async Task HandleClientAsync(TcpClient client, Func<string, string> handleRequest, Action<string> logAction)
        {
            try
            {
                using (client)
                using (NetworkStream stream = client.GetStream())
                {
                    byte[] buffer = new byte[4096];
                    int bytesRead = await stream.ReadAsync(buffer, 0, buffer.Length);

                    string request = Encoding.UTF8.GetString(buffer, 0, bytesRead).Trim();
                    logAction($"Отримано запит: {request}");

                    string response = handleRequest(request);

                    byte[] responseBytes = Encoding.UTF8.GetBytes(response);
                    await stream.WriteAsync(responseBytes, 0, responseBytes.Length);

                    logAction("Відповідь відправлено клієнту");
                }
            }
            catch (Exception ex)
            {
                if (isRunning) logAction("Помилка при обробці клієнта: " + ex.Message);
            }
        }
    }
}

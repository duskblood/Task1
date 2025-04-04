using System;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.IO.Pipes;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Services
{
    public class CommunicationService
    {
        private const string MMF_NAME = "WarehouseNotifications";
        private const string PIPE_NAME = "WarehouseChat";
        private const int BUFFER_SIZE = 4096;

        private MemoryMappedFile _mmf;
        private NamedPipeServerStream _pipeServer;
        private NamedPipeClientStream _pipeClient;

        public event EventHandler<string> NotificationReceived;
        public event EventHandler<string> ChatMessageReceived;

        public CommunicationService()
        {
            InitializeMemoryMappedFile();
            InitializeNamedPipe();
        }

        private void InitializeMemoryMappedFile()
        {
            _mmf = MemoryMappedFile.CreateOrOpen(MMF_NAME, BUFFER_SIZE);
            StartNotificationListener();
        }

        private void InitializeNamedPipe()
        {
            _pipeServer = new NamedPipeServerStream(PIPE_NAME, PipeDirection.InOut, 1, PipeTransmissionMode.Message);
            _pipeClient = new NamedPipeClientStream(".", PIPE_NAME, PipeDirection.InOut);
            StartChatListener();
        }

        public void SendNotification(string message)
        {
            using (var writer = _mmf.CreateViewStream())
            {
                var bytes = Encoding.UTF8.GetBytes(message);
                writer.Write(bytes, 0, bytes.Length);
            }
        }

        public async Task SendChatMessage(string message)
        {
            try
            {
                if (!_pipeClient.IsConnected)
                    await _pipeClient.ConnectAsync();

                var bytes = Encoding.UTF8.GetBytes(message);
                await _pipeClient.WriteAsync(bytes, 0, bytes.Length);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error sending chat message: {ex.Message}");
            }
        }

        private void StartNotificationListener()
        {
            Task.Run(() =>
            {
                using (var reader = _mmf.CreateViewStream())
                {
                    var buffer = new byte[BUFFER_SIZE];
                    while (true)
                    {
                        var count = reader.Read(buffer, 0, buffer.Length);
                        if (count > 0)
                        {
                            var message = Encoding.UTF8.GetString(buffer, 0, count).Trim('\0');
                            NotificationReceived?.Invoke(this, message);
                        }
                    }
                }
            });
        }

        private void StartChatListener()
        {
            Task.Run(async () =>
            {
                await _pipeServer.WaitForConnectionAsync();
                var buffer = new byte[BUFFER_SIZE];

                while (true)
                {
                    var count = await _pipeServer.ReadAsync(buffer, 0, buffer.Length);
                    if (count > 0)
                    {
                        var message = Encoding.UTF8.GetString(buffer, 0, count);
                        ChatMessageReceived?.Invoke(this, message);
                    }
                }
            });
        }

        public void Dispose()
        {
            _mmf?.Dispose();
            _pipeServer?.Dispose();
            _pipeClient?.Dispose();
        }
    }
} 
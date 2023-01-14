namespace SampleWebsocketServer
{
    using EmbedIO.WebSockets;

    /// <summary>
    /// Defines a very simple chat server.
    /// </summary>
    public class WebSocketChatServer : WebSocketModule
    {
        public WebSocketChatServer(string urlPath)
            : base(urlPath, true)
        {
            // placeholder
        }

        /// <inheritdoc />
        protected override Task OnMessageReceivedAsync(
            IWebSocketContext context,
            byte[] rxBuffer,
            IWebSocketReceiveResult rxResult)
        {
            Console.WriteLine($"RECEIVED DATA OK - {Encoding.GetString(rxBuffer)}");
            return Task.CompletedTask;
        }
    }
}

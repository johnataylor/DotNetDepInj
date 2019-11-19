using System.Net.Http;
using System.Threading.Tasks;

namespace DotNetDepInj
{
    public class BotFrameworkClient : IBotFrameworkClient
    {
        private HttpClient _client;
        private IProvider _provider;

        public BotFrameworkClient(HttpClient client, IProvider provider)
        {
            _client = client;
            _provider = provider;
        }

        public Task<string> PostAsync(string stringAllTheThings)
        {
            return Task.FromResult($"{ stringAllTheThings } { _provider.Value }");
        }
    }
}

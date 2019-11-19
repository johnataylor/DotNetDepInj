using Microsoft.Extensions.Configuration;

namespace DotNetDepInj
{
    public class Provider : IProvider
    {
        public Provider(IConfiguration configuration)
        {
            Value = configuration["value"];
        }

        public string Value { get; private set; }
    }
}

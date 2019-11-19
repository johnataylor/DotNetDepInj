using System.Threading.Tasks;

namespace DotNetDepInj
{
    public interface IBotFrameworkClient
    {
        Task<string> PostAsync(string stringAllTheThings);
    }
}

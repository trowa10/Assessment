using System.Threading.Tasks;

namespace ProjectHRCommon.Client
{
    public interface IClientCall
    {
        Task<string> CallRestMethod(string url, string apikey);
        Task<bool> CallRestPostMethod(string url, string token);
    }
}

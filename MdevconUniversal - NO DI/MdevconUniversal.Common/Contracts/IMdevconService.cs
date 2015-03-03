using System.Threading.Tasks;
using MdevconUniversal.Common.Domain;

namespace MdevconUniversal.Common.MdevconService
{
    public interface IMdevconService
    {
        Task<RootObject> GetConferenceInfoAsync();
    }
}
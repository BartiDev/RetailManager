using RMDesctopUI.Models;
using System.Threading.Tasks;

namespace RMDesctopUI.Helpers
{
    public interface IAPIHelper
    {
        Task<AuthenticatedUser> Authenticate(string userName, string password);
    }
}
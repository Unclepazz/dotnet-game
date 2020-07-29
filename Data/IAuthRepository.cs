  
using System.Threading.Tasks;
using dotnet_game.Dtos.User;
using dotnet_game.Models;

namespace dotnet_game.Data
{
    public interface IAuthRepository
    {
        Task<ServiceResponse<int>> Register(User user, string password);
        Task<ServiceResponse<string>> Login(string username, string password);
        Task<bool> UserExists(string username);
    }
}
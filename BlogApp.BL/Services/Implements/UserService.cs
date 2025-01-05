using BlogApp.BL.DTOs.UserDtos;
using BlogApp.BL.Services.Interfaces;

namespace BlogApp.BL.Services.Implements;
public class UserService : IAuthService
{
 

    public Task<string> CreateAsync()
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(string username)
    {
        throw new NotImplementedException();
    }

    public Task LoginDto(LoginDto dto)
    {
        throw new NotImplementedException();
    }

    public Task RegisterAsync(RegisterDto dto)
    {
        throw new NotImplementedException();
    }
}

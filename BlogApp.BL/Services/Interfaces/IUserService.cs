namespace BlogApp.BL.Services.Interfaces;
public interface IAuthService
{
    Task<string> CreateAsync();
    Task DeleteAsync(string username);

}

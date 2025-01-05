using BlogApp.Core.Entities;
using BlogApp.Core.Repositories;
using BlogApp.DAL.Context;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace BlogApp.DAL.Repositories;
public class UserRepository : GenericRepository<User>, IUserRepository
{
    readonly HttpContext _httpContext;
    readonly BlogDbContext _context;
    public UserRepository(BlogDbContext context, IHttpContextAccessor httpContext) : base(context)
    {
        _context = context;
        _httpContext = httpContext.HttpContext;
    }

    public async Task<User?> GetByUserNameAsync(string userName)
    {
        return await _context.Users.Where(x => x.Username == userName).FirstOrDefaultAsync();
    }

    public User GetCurrentUser()
    {
        return new();
    }

    public int GetCurrentUserId()
    {
        return 0;
    }
}

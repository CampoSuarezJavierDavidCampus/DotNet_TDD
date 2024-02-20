using API.Context;
using API.Models;

namespace Tests.APITests.Context;

public static class DbContextDataExtensions
{
    public static ApiDbContext AddUsers(this ApiDbContext dbContext)
    {
        List<User> users =
        [
            new User { Name = "User 1", LastName = "LastName 1", IsActived= true },
            new User { Name = "User 2", LastName = "LastName 2", IsActived= true },
            new User { Name = "User 3", LastName = "LastName 3", IsActived= true },
        ];
        dbContext.Users.AddRange(users);
        dbContext.SaveChanges();
        return dbContext;
    }
}

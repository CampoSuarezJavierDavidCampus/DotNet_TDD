using API.Context;
using Microsoft.EntityFrameworkCore;

namespace Tests.APITests.Context;

public class ApiContextTest {       
    public static ApiDbContext GetContext()
    {
        var options = new DbContextOptionsBuilder<ApiDbContext>()
            .UseInMemoryDatabase(databaseName: "AppDB").Options;
        var dbContext = new ApiDbContext(options);
        dbContext.Database.EnsureDeleted();
        dbContext.Database.EnsureCreated();
        return dbContext;
    }   
}
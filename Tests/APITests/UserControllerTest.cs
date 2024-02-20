using API.Controllers;
using API.Models;
using Tests.APITests.Context;

namespace Tests.APITests;

public class UserControllerTest
{
    [Fact]
    public void Get()
    {
        //Arrange
        using var dbContext = ApiContextTest.GetContext().AddUsers();
        var userController = new UserController(dbContext);
        //Act
        var res = userController.Get();
        //Assert
        Assert.Equal(3,res.Count());
    }

    [Fact]
    public async void Post()
    {
        //Arrange
        using var dbContext = ApiContextTest.GetContext().AddUsers();
        var userController = new UserController(dbContext);
        var fixture = new Fixture();
        var user = fixture.Build<User>()
            .With(u => u.IsActived, true)
            .Create();
        //Act
        await userController.Post(user);
        var res = userController.Get();
        //Assert
        Assert.Equal(4, res.Count());
        Assert.Equal(user, res.ToList()[3]);
    }

    [Fact]  
    public async void Put()
    {
        //Arrange
        using var dbContext = ApiContextTest.GetContext().AddUsers();
        var userController = new UserController(dbContext);
        var fixture = new Fixture();
        var newUser = fixture.Build<User>()
            .With(u => u.Name, "User Update Successfully!!")
            .With(u => u.IsActived, true)
            .Create();
        //Act
        var user = userController.Get().ToList()[0];        
        await userController.Put(user.UserId.ToString(),newUser);
        var res = userController.Get();
        //Assert
        Assert.Equal(3, res.Count());
        Assert.Equal("User Update Successfully!!", res.ToList()[0].Name);
    }

    [Fact]
    public async void Delete()
    {
        //Arrange
        using var dbContext = ApiContextTest.GetContext().AddUsers();
        var userController = new UserController(dbContext);
        //Act
        var user = userController.Get().ToList()[0];
        await userController.Delete(user.UserId.ToString());
        var res = userController.Get();
        //Assert
        Assert.Equal(2, res.Count());
        Assert.Equal("User 2", res.ToList()[0].Name);
    }
}

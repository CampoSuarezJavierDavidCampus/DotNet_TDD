using API.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace Tests.APITests;
public class HelloWorldControllerTest
{
    [Fact]
    public void GetTModels()
    {
        //Arrange
        var controller = new HelloWorldController();
        //Act
        var res = controller.GetTModels();
        //Assert
        Assert.NotNull(res.Value);
        Assert.Equal(2, res?.Value?.Count());
    }

    [Fact]
    public void GetById()
    {
        //Arrange
        var controller = new HelloWorldController();
        //Act
        var res = controller.GetById(10);
        //Assert
        Assert.Equal("Hello World",res.Value);
    }

    [Fact]
    public void GetById_BadRequest()
    {
        //Arrange
        var controller = new HelloWorldController();        
        //Act
        var res = controller.GetById(-2);
        //Assert        
        Assert.IsType<BadRequestResult>(res.Result);
    }
    [Fact]
    public void GetById_NotFound()
    {
        //Arrange
        var controller = new HelloWorldController();

        //Act
        var res = controller.GetById(0);
        //Assert        
        Assert.IsType<NotFoundResult>(res.Result);
    }

    [Fact]
    public void PostTModel()
    {
        //Arrange
        var controller = new HelloWorldController();
        //Act
        var res = controller.PostTModel("");
        //Assert
        Assert.IsType<OkResult>(res);
    }

    [Fact]
    public void PutTModel()
    {
        //Arrange
        var controller = new HelloWorldController();
        //Act
        var res = controller.PutTModel("");
        //Assert
        Assert.IsType<NoContentResult>(res);
    }

    [Fact]
    public void DeleteTModelById()
    {
        //Arrange
        var controller = new HelloWorldController();
        //Act
        var res = controller.DeleteTModelById("1234");
        //Assert
        Assert.IsType<OkObjectResult>(res.Result);
    }

    [Fact]
    public void DeleteTModelById_NotFound()
    {
        //Arrange
        var controller = new HelloWorldController();
        //Act
        var res = controller.DeleteTModelById("12345");
        //Assert        
        Assert.IsType<NotFoundResult>(res.Result);
    }

}

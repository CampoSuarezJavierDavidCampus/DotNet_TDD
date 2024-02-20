using Library;
namespace Tests.LibraryTests;

public class ProductTest
{
    [Fact]
    public void Product()
    {
        //Arrange
        var product = new Product()
        {
            Name = "Nevera",
            Description = "No-Frost de 365lt LG",
            Price = 500
        };
        var tax = 500 * (decimal)0.19;
        var fullDescription = "Nevera - No-Frost de 365lt LG";
        //Assert
        Assert.Equal(fullDescription, product.FullDescription);
        Assert.Equal(tax, product.Tax);

    }

    [Fact]
    public void Product_WithAutoFixture()
    {
        //Arrange
        Fixture fixture = new();
        var product = fixture.Create<Product>();
        var tax = product.Price * (decimal)0.19;
        var fullDescription = $"{product.Name} - {product.Description}";
        //Assert
        Assert.Equal(fullDescription, product.FullDescription);
        Assert.Equal(tax, product.Tax);
    }

    [Fact]
    public void Product_WithAutoFixtureBuild()
    {
        //Arrange
        Fixture fixture = new();
        var product = fixture.Build<Product>()
            .With(p => p.Name, "Nevera")
            .Without(p => p.Description).Create();

        var tax = product.Price * (decimal)0.19;
        var fullDescription = $"{product.Name} - {product.Description}";
        //Assert
        Assert.Equal(fullDescription, product.FullDescription);
        Assert.Equal(tax, product.Tax);
    }
}

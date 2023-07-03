using ChowHound.API.Controllers;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using Moq;

namespace ChowHound.UnitTests.System.Controllers;

public class TestMenuController
{
    [Fact]
    public async Task Get_OnSuccess_Returns_Code200()
    {
        // Arrange
        var systemUnderTest = new MenuController();
        // Act
        var result = (OkObjectResult)await systemUnderTest.Get();
        // Assert 
        result.StatusCode.Should().Be(200);
        result.Value.Should().Be("All Good");
    }

    [Fact]
    public async Task Get_OnSuccess_InvokeUserService()
    {
        // Arrange
        //var mockMenuService = Mock<IMenuService>();
        //var systemUnderTest = new MenuController(mockMenuService.Object);
        // Act
        //var result = (OkObjectResult)await systemUnderTest.Get();
        // Assert 
        
    }
    
     [Theory]
     [InlineData("string")] // Allows us to pass in args.
     [InlineData("string2")] // Allows us to pass in args.
     public void Test2(string input)
     {
     }
}
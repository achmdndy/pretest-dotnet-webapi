using LockerFloorFinder.Controllers;
using LockerFloorFinder.Service;
using Microsoft.AspNetCore.Mvc;

namespace LockerFloorFinder.Tests
{
  public class LockerControllerTest
  {
    [Theory]
    [InlineData(1, 1)]
    [InlineData(5, 1)]
    [InlineData(6, 2)]
    [InlineData(10, 2)]
    [InlineData(16, 3)]
    [InlineData(25, 5)]

    public void GetFloor_ValidLockerNumber_ReturnsOk(int lockerNumber, int expectedFloor)
    {
      // Arrange
      var controller = new LockerController();

      // Act
      var actionResult = controller.GetFloor(lockerNumber);
      var objectResult = actionResult as OkObjectResult;

      // Assert
      Assert.NotNull(objectResult);
      Assert.Equal(200, objectResult.StatusCode);
      var response = objectResult.Value as ApiResponseService<int>;
      Assert.NotNull(response);
      Assert.Equal("Success", response.Status);
      Assert.Equal("Nomor lantai berhasil ditemukan.", response.Message);
      Assert.Equal(expectedFloor, response.Data);
      Assert.Null(response.Error);
    }

    [Theory]
    [InlineData(0)]
    [InlineData(-1)]
    public void GetFloor_InvalidLockerNumber_ReturnsBadRequest(int lockerNumber)
    {
      // Arrange
      var controller = new LockerController();

      // Act
      var actionResult = controller.GetFloor(lockerNumber);
      var objectResult = actionResult as BadRequestObjectResult;

      // Assert
      Assert.NotNull(objectResult);
      Assert.Equal(400, objectResult.StatusCode);
      var response = objectResult.Value as ApiResponseService<int?>;
      Assert.NotNull(response);
      Assert.Equal("Error", response.Status);
      Assert.Equal("Nomor loker harus lebih besar dari 0.", response.Message);
      Assert.Equal("InvalidLockerNumber", response.Error);
      Assert.Null(response.Data);
    }
  }
}
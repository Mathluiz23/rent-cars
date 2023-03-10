using FluentAssertions;
using RentCars.Types;

namespace RentCars.Test;

public class TestEnums
{
  [Theory]
  [InlineData(1, "Chamber")]
  [InlineData(2, "Disc")]
  [InlineData(3, "Drum")]
  public void BreakeTypeShouldHaveCorrectValues(int valueEntry, string expected)
  {
    var enumValue = (BrakeType)valueEntry;
    enumValue.ToString().Should().Be(expected);
  }

  [Theory]
  [InlineData(0, "FrontWheelDrive")]
  [InlineData(1, "RearWheelDrive")]
  [InlineData(2, "AllWheelDrive")]
  public void TractionTypeShouldHaveCorrectValues(int valueEntry, string expected)
  {
    var enumValue = (TractionType)valueEntry;
    enumValue.ToString().Should().Be(expected);
  }

  [Theory]
  [InlineData(10, "Alcohol")]
  [InlineData(20, "Gasoline")]
  [InlineData(30, "Flex")]
  [InlineData(40, "Diesel")]
  [InlineData(50, "Electric")]
  [InlineData(60, "Hybrid")]
  public void FuelTypeShouldHaveCorrectValues(int valueEntry, string expected)
  {
    var enumValue = (FuelType)valueEntry;
    enumValue.ToString().Should().Be(expected);
  }

  [Theory]
  [InlineData(0, "Confirmed")]
  [InlineData(1, "Finished")]
  public void RentStatusShouldHaveCorrectValues(int valueEntry, string expected)
  {
    var enumValue = (RentStatus)valueEntry;
    enumValue.ToString().Should().Be(expected);
  }

  [Fact]
  public void RentStatusFinishedShouldBeTheSameValueAsCancelled()
  {
    var finished = (int)RentStatus.Finished;
    var cancelled = (int)RentStatus.Cancelled;
    finished.Should().Be(cancelled);
  }
}

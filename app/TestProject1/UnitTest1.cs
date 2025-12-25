using Xunit;

public class SumPositiveTests
{
    [Fact]
    public void SumPositive_ReturnsCorrectSum()
    {
        int[] data = { 1, -3, 5, 0, -2 };

        int result = Program.SumPositive(data);

        Assert.Equal(6, result);
    }
}

//dotnet add reference ..\ConsoleApp1\ConsoleApp1.csproj

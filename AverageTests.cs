using Xunit;

public class AverageTests
{
    [Fact]
    public void GetAverage_SingleValue_ReturnsThatValue()
    {
        var average = new Average();
        average.AddNumber(5.0);

        Assert.Equal(5.0, average.GetAverage());
    }

    [Fact]
    public void GetAverage_MultipleValues_ReturnsCorrectAverage()
    {
        var average = new Average();
        average.AddNumber(10.0);
        average.AddNumber(20.0);
        average.AddNumber(30.0);

        Assert.Equal(20.0, average.GetAverage());
    }

    [Fact]
    public void GetAverage_NoValues_ThrowsInvalidOperationException()
    {
        var average = new Average();

        Assert.Throws<InvalidOperationException>(() => average.GetAverage());
    }

    [Fact]
    public void GetAverage_NegativeValues_ReturnsCorrectAverage()
    {
        var average = new Average();
        average.AddNumber(-10.0);
        average.AddNumber(-20.0);

        Assert.Equal(-15.0, average.GetAverage());
    }

    [Fact]
    public void GetAverage_MixedPositiveAndNegative_ReturnsCorrectAverage()
    {
        var average = new Average();
        average.AddNumber(10.0);
        average.AddNumber(-10.0);

        Assert.Equal(0.0, average.GetAverage());
    }

    [Fact]
    public void AddNumbers_MultipleValuesAtOnce_ReturnsCorrectAverage()
    {
        var average = new Average();
        average.AddNumbers([2.0, 4.0, 6.0]);

        Assert.Equal(4.0, average.GetAverage());
    }

    [Fact]
    public void GetAverage_FractionalValues_ReturnsCorrectAverage()
    {
        var average = new Average();
        average.AddNumber(1.5);
        average.AddNumber(2.5);

        Assert.Equal(2.0, average.GetAverage());
    }

    [Fact]
    public void GetAverage_CalledMultipleTimes_ReturnsSameResult()
    {
        var average = new Average();
        average.AddNumber(10.0);
        average.AddNumber(20.0);

        var first = average.GetAverage();
        var second = average.GetAverage();

        Assert.Equal(first, second);
    }
}

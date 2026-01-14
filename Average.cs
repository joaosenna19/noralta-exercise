public class Average
{
    private double sum;
    private int count;

    public void AddNumber(double num)
    {
        sum += num;
        count++;
    }

    public void AddNumbers(IEnumerable<double> nums)
    {
        foreach (var num in nums)
        {
            AddNumber(num);
        }
    }

    public double GetAverage()
    {
        if (count == 0)
        {
            throw new InvalidOperationException("No numbers added to calculate average.");
        }

        return sum / count;
    }
}

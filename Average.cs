public class Average
{
    private readonly List<double> numbers;

    public Average()
    {
        numbers = [];
    }

    public void AddNumber(double num)
    {

        numbers.Add(num);
    }

    public void AddNumbers(IEnumerable<double> nums)
    {
        numbers.AddRange(nums);
    }

    public double GetAverage()
    {
        if (numbers.Count == 0)
        {
            throw new InvalidOperationException("No numbers added to calculate average.");
        }

        return numbers.Average();
    }

}
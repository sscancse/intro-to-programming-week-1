
namespace StringCalculator;

public class StringCalculator
{
    private List<char> delimiters = new List<char>() { ',', '\n' };

    public int Add(string numbers)
    {
        int sum = 0;

        if (!string.IsNullOrEmpty(numbers))
        {
            if (numbers.StartsWith("//"))
            {
                delimiters.Add(numbers[2]);
                numbers = numbers.Substring(4);
            }

            string[] nums = numbers.Split(delimiters.ToArray());

            foreach (string num in nums)
            {
                sum += int.Parse(num);
            }
        }

        return sum;
    }
}

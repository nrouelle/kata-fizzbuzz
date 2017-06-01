using System.Text;

namespace KataFizzBuzz
{
    public class FizzBuzz
    {
        public string GetString(int number)
        {
            var reste3 = number % 3;
            var reste5 = number % 5;

            var result = new StringBuilder();

            if (reste3 == 0 || reste5 == 0)
            {
                if (reste3 == 0)
                {
                    result.Append("Fizz");
                }
                if (reste5 == 0)
                {
                    result.Append("Buzz");
                }
                return result.ToString();
            }

            return number.ToString();
        }
    }
}

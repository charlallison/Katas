namespace FizzBuzz {
    public class FizzBuzzContainsStrategy : IRunnerStrategy {
        public string Run(int number) {
            if (number.ToString().Contains("3") && number.ToString().Contains("5")) return "FizzBuzz";

            if (number.ToString().Contains("3")) return "Fizz";

            if (number.ToString().Contains("5")) return "Buzz";

            return number.ToString();
        }
    }
}

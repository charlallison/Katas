
using System;

namespace FizzBuzz {
    public class FizzBuzzGenerator {

        public string Generate(int max) {
            if ((max % 5) == 0 && (max % 3) == 0) return "FizzBuzz";

            if(max.ToString().Contains("3") && max.ToString().Contains("5")) return "FizzBuzz";

            if(max.ToString().Contains("3")) return "Fizz";

            if(max.ToString().Contains("5")) return "Buzz";

            if ((max % 3) == 0) return "Fizz";
            if ((max % 5) == 0) return "Buzz";

            
            return max.ToString();
        }

    }
}

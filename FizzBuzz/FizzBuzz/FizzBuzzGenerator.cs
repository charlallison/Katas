
using System;

namespace FizzBuzz {
    public class FizzBuzzGenerator {

        public FizzBuzzGenerator(IRunnerStrategy runnerStrategy) {
            runner = runnerStrategy;
        }

        public string Generate(int max) {
            return runner.Run(max);
        }

        private IRunnerStrategy runner;

    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzz.Tests {
    [TestClass()]
    public class FizzBuzzGeneratorShould {

        [TestMethod()]
        public void ReturnNumber() {
            var buzzGenerator = new FizzBuzzGenerator(new FizzBuzzMultiplesStrategy());
             var actual = buzzGenerator.Generate(1);
            Assert.AreEqual("1", actual);
        }

        [TestMethod]
        public void ReturnFizzForMultipleOf3() {
            var buzzGenerator = new FizzBuzzGenerator(new FizzBuzzMultiplesStrategy());
            var actual = buzzGenerator.Generate(9);
            Assert.AreEqual("Fizz", actual);
        }

        [TestMethod]
        public void ReturnBuzzForMultipleOf5() {
            var buzzGenerator = new FizzBuzzGenerator(new FizzBuzzMultiplesStrategy());
            var actual = buzzGenerator.Generate(55);
            Assert.AreEqual("Buzz", actual);
        }

        [TestMethod]
        public void ReturnFizzForNumbersThatContain3() {
            var buzzGenerator = new FizzBuzzGenerator(new FizzBuzzContainsStrategy());
            var actual = buzzGenerator.Generate(137);
            Assert.AreEqual("Fizz", actual);
        }

        [TestMethod]
        public void ReturnBuzzForNumberThatContain5() {
            var buzzGenerator = new FizzBuzzGenerator(new FizzBuzzContainsStrategy());
            var actual = buzzGenerator.Generate(51);
            Assert.AreEqual("Buzz", actual);
        }

    }
}
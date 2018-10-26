using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzz.Tests {
    [TestClass()]
    public class FizzBuzzGeneratorShould {

        FizzBuzzGenerator buzzGenerator;

        [TestInitialize]
        public void initTest() {
            buzzGenerator = new FizzBuzzGenerator();
        }

        [TestMethod()]
        public void ReturnNumber() {
            var actual = buzzGenerator.Generate(1);
            Assert.AreEqual("1", actual);
        }

        [TestMethod]
        public void ReturnFizzForMultipleOf3() {
            var actual = buzzGenerator.Generate(9);
            Assert.AreEqual("Fizz", actual);
        }

        [TestMethod]
        public void ReturnBuzzForMultipleOf5() {
            var actual = buzzGenerator.Generate(55);
            Assert.AreEqual("Buzz", actual);
        }

        [TestMethod]
        public void ReturnFizzForNumbersThatContain3() {
            var actual = buzzGenerator.Generate(137);
            Assert.AreEqual("Fizz", actual);
        }

        [TestMethod]
        public void ReturnBuzzForNumberThatContain5() {
            var actual = buzzGenerator.Generate(51);
            Assert.AreEqual("Buzz", actual);
        }

    }
}
using System;
using NFluent;
using NUnit.Framework;

namespace KataFizzBuzz.Test
{
    [TestFixture]
    public class FizzBuzzShould
    {
        [Test]
        public void ReturnFizzWhenMultipleOf3()
        {
            var fizzbuzz = new FizzBuzz();

            Check.That(fizzbuzz.GetString(9)).Equals("Fizz");
            Check.That(fizzbuzz.GetString(3)).Equals("Fizz");
            Check.That(fizzbuzz.GetString(18)).Equals("Fizz");
        }

        [Test]
        public void ReturBuzzWhenMultipleOf5()
        {
            var fizzbuzz = new FizzBuzz();

            Check.That(fizzbuzz.GetString(25)).Equals("Buzz");
            Check.That(fizzbuzz.GetString(5)).Equals("Buzz");
        }
        
        [Test]
        public void ReturnFizzBuzzWhenMultipleOf3And5()
        {
            var fizzbuzz = new FizzBuzz();

            Check.That(fizzbuzz.GetString(15)).Equals("FizzBuzz");
            Check.That(fizzbuzz.GetString(30)).Equals("FizzBuzz");
        }

        [Test]
        public void ReturnNumberWhenNotMultipleOf3Or5()
        {
            var fizzbuzz = new FizzBuzz();

            Check.That(fizzbuzz.GetString(2)).Equals("2");
            Check.That(fizzbuzz.GetString(4)).Equals("4");
            Check.That(fizzbuzz.GetString(7)).Equals("7");
            Check.That(fizzbuzz.GetString(8)).Equals("8");
        }
    }
}
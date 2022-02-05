using ConsoleApp1;
using FluentAssertions;
using NUnit.Framework;
using System;

namespace NowyUnitTest
{
    public class Tests
    {

        [Test]
        public void Test1()
        {
            Assert.Throws<ArgumentException>(() => Program.CzyJest(-5));
        }
        [TestCase(-33, false)]
        [TestCase(0, false)]
        [TestCase(2, true)]
        [TestCase(4, false)]
        [TestCase(6, false)]
        [TestCase(7, true)]
        [TestCase(69, false)]
        [TestCase(113, true)]
        [TestCase(333, false)]
        public void Zwracane(int wartosc, bool wyjatkiL)
        {
            bool Aktualna = Program.CzyJest(wartosc);
            Aktualna.Should().Be(wyjatkiL);
        }

    }
}
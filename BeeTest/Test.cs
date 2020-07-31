using System;
using BeesExercise.Logic;
using NUnit.Framework;

namespace BeeTest
{
    
    public class Test
    {
        private Bee _beeW;
        private Bee _beeQ;
        private Bee _beeD;

        [SetUp]
        public void Setup()
        {
            _beeW = new Worker();
            _beeQ = new Queen();
            _beeD = new Drone();
        }

        [TestCase(3)]
        [TestCase(27)]
        [TestCase(68)]
        [TestCase(87)]
        [TestCase(98)]
        public void ValidHealthTest(int newHealth)
        {
            _beeW.Health = newHealth;
            Assert.AreEqual(newHealth, _beeW.Health);
        }

        [TestCase(-1)]
        [TestCase(-20)]
        [TestCase(101)]
        [TestCase(120)]
        public void InvalidHealthTest(int newHealth)
        {
            _beeW.Health = newHealth;
            Assert.AreEqual(0, _beeW.Health);
        }

        [TestCase(70)]
        [TestCase(83)]
        [TestCase(97)]
        [TestCase(100)]
        public void WorkerBeeAliveTest(int hp)
        {
            _beeW.Health = hp;
            Assert.AreEqual(true, _beeW.Alive);
        }

        [TestCase(69)]
        [TestCase(50)]
        [TestCase(42)]
        [TestCase(34)]
        [TestCase(26)]
        [TestCase(14)]
        [TestCase(7)]
        [TestCase(0)]
        public void WorkerBeeNotAliveTest(int hp)
        {
            _beeW.Health = hp;
            Assert.AreEqual(false, _beeW.Alive);
        }

        [TestCase(20)]
        [TestCase(37)]
        [TestCase(45)]
        [TestCase(58)]
        [TestCase(62)]
        [TestCase(76)]
        [TestCase(89)]
        [TestCase(94)]
        [TestCase(100)]
        public void QueenBeeAliveTest(int hp)
        {
            _beeQ.Health = hp;
            Assert.AreEqual(true, _beeQ.Alive);
        }

        [TestCase(19)]
        [TestCase(10)]
        [TestCase(4)]
        [TestCase(0)]
        public void QueenBeeNotAliveTest(int hp)
        {
            _beeQ.Health = hp;
            Assert.AreEqual(false, _beeQ.Alive);
        }

        [TestCase(50)]
        [TestCase(63)]
        [TestCase(77)]
        [TestCase(84)]
        [TestCase(96)]
        [TestCase(100)]
        public void DroneBeeAliveTest(int hp)
        {
            _beeD.Health = hp;
            Assert.AreEqual(true, _beeD.Alive);
        }

        [TestCase(49)]
        [TestCase(35)]
        [TestCase(22)]
        [TestCase(12)]
        [TestCase(6)]
        [TestCase(0)]
        public void DroneBeeNotAliveTest(int hp)
        {
            _beeD.Health = hp;
            Assert.AreEqual(false, _beeD.Alive);
        }

        
    }
}

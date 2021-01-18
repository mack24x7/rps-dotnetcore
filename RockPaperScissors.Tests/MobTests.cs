using NUnit.Framework;

namespace RockPaperScissors.Tests
{
    public class MobTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void p1ThrowsRock_p2ThrowsRock_resultIsTie()
        {
            string gameResult = RockPaperScissors.Code.mobRPSGame.play("ROCK", "ROCK");
            Assert.AreSame("TIE", gameResult);
        }
    }
}
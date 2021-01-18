using NUnit.Framework;

namespace RockPaperScissors.Tests
{
    public class LabTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void p1ThrowsRock_p2ThrowsRock_resultIsTie()
        {
            string gameResult = RockPaperScissors.Code.labRPSGame.play("ROCK", "ROCK");
            Assert.AreSame("TIE", gameResult);
        }
        [Test]
        public void p1ThrowsPaper_p2ThrowsPaper_resultIsTie()
        {
            string gameResult = RockPaperScissors.Code.labRPSGame.play("PAPER", "PAPER");
            Assert.AreSame("TIE", gameResult);
        }
        [Test]
        public void p1ThrowsScissors_p2ThrowsScissors_resultIsTie()
        {
            string gameResult = RockPaperScissors.Code.labRPSGame.play("SCISSORS", "SCISSORS");
            Assert.AreSame("TIE", gameResult);
        }
        [Test]
        public void p1ThrowsRock_p2ThrowsPaper_resultIsP2()
        {
            string gameResult = RockPaperScissors.Code.labRPSGame.play("ROCK", "PAPER");
            Assert.AreSame("Player2", gameResult);
        }
        [Test]
        public void p1ThrowsRock_p2ThrowsScissors_resultIsP1()
        {
            string gameResult = RockPaperScissors.Code.labRPSGame.play("ROCK", "SCISSORS");
            Assert.AreSame("Player1", gameResult);
        }
        [Test]
        public void p1ThrowsPaper_p2ThrowsRock_resultIsP1()
        {
            string gameResult = RockPaperScissors.Code.labRPSGame.play("PAPER", "ROCK");
            Assert.AreSame("Player1", gameResult);
        }
        [Test]
        public void p1ThrowsPaper_p2ThrowsScissors_resultIsP2()
        {
            string gameResult = RockPaperScissors.Code.labRPSGame.play("PAPER", "SCISSORS");
            Assert.AreSame("Player2", gameResult);
        }
        [Test]
        public void p1ThrowsScissors_p2ThrowsRock_resultIsP2()
        {
            string gameResult = RockPaperScissors.Code.labRPSGame.play("SCISSORS", "ROCK");
            Assert.AreSame("Player2", gameResult);
        }
        [Test]
        public void p1ThrowsScissors_p2ThrowsPaper_resultIsP1()
        {
            // Testing mixed case refactor, as well as Scissors vs. Paper
            string gameResult = RockPaperScissors.Code.labRPSGame.play("sciSSors", "PapEr");
            Assert.AreSame("Player1", gameResult);
        }
    }
}
using GuessNumber;

namespace Tests
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        public void CheckDifferentNumbers()
        {
            //arrange
            bool expectedResult = false;

            //act
            GameGuessNumber test1 = new GameGuessNumber();
            bool firstResult = test1.IsWon(4, 9);
            bool secondResult = test1.IsWon(11, 9);

            //assert
            Assert.AreEqual(expectedResult, firstResult);
            Assert.AreEqual(expectedResult, secondResult);
        }

        [TestMethod]
        public void CheckSameNumbers()
        {
            //arrange
            bool expectedResult = true;

            //act
            GameGuessNumber test2 = new GameGuessNumber();
            bool actualResult = test2.IsWon(25, 25);

            //assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void CheckRestart()
        {
            //arrange
            bool expectedResult = true;

            //act
            GameGuessNumber test3 = new GameGuessNumber();
            bool firstResult = test3.RestartGame("r");
            bool secondResult = test3.RestartGame("R");

            //assert
            Assert.AreEqual(expectedResult, firstResult);
            Assert.AreEqual(expectedResult, secondResult);
        }

        [TestMethod]
        public void CheckNotRestart()
        {
            //arrange
            bool expectedResult = false;

            //act
            GameGuessNumber test3 = new GameGuessNumber();
            bool firstResult = test3.RestartGame("+");
            bool secondResult = test3.RestartGame("a");
            bool thirdResult = test3.RestartGame(" ");

            //assert
            Assert.AreEqual(expectedResult, firstResult);
            Assert.AreEqual(expectedResult, secondResult);
            Assert.AreEqual(expectedResult, thirdResult);
        }
    }
}
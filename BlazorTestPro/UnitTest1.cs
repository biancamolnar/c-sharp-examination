using Bunit;
using GuessMyNumber.Pages;

namespace BlazorTestPro
{
    public class UnitTest1 : TestContext
    {
        [Fact]
        public void GameShouldCheckTheGuess()
        {
            var game = RenderComponent<Game>();
            game.Instance.guessInput = "1";
            game.Instance.theNumber = 1;
            game.Find("button").Click();

            Assert.Equal(1, game.Instance.guessNum);
        }


        [Fact]
        public void GameShouldProduceRandomNumber()
        {
            var game = RenderComponent<Game>();

            var ProducedRandomNumber = game.Instance.theNumber;
            Assert.True(ProducedRandomNumber >= 0 && ProducedRandomNumber <= 20);
        }
        [Fact]
        public void GameShouldShowLowerMessage()
        {
            var game = RenderComponent<Game>();
            game.Instance.guessInput = "2";
            game.Instance.theNumber = 1;
            game.Find("button").Click();
            Assert.Equal("Nope, lower than that.", game.Instance.resultMessage);
        }

        [Fact]
        public void GameShouldShowHigherMessage()
        {
            var game = RenderComponent<Game>();
            game.Instance.guessInput = "1";
            game.Instance.theNumber = 2;
            game.Find("button").Click();
            Assert.Equal("Nope, higher than that.", game.Instance.resultMessage);
        }
        [Fact]
        public void GameShouldShowErrorMessage()
        {
            var game = RenderComponent<Game>();
            game.Instance.guessInput = "b";
            game.Instance.theNumber = 3;
            game.Find("button").Click();
            Assert.Equal("Hmmm, that doesn't look like a number. Try again.", game.Instance.resultMessage);
        }

        [Fact]
        public void GameShouldAddHighscore()
        {
            var game = RenderComponent<Game>();
            game.Instance.guessInput = "1";
            game.Instance.theNumber = 1;
            game.Find("button").Click();
            Assert.Equal("🥇 Highscore: 1", game.Instance.highScore);
        }
    }
}
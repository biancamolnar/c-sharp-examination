using Bunit;

namespace BlazorProjectTest
{
    public class UnitTest1 : TestContextBase
    {
        [Fact]
        public void GameShouldCheckTheGuess()
        {
            var game = RenderComponent<GuessMyNumber>();
            game.Instance.guessInput = "1";
            game.Instance.theNumber = 1;
            game.Find("button").Click();

            Assert.Equal(1, game.Instance.guessNum);
        }
    }
}
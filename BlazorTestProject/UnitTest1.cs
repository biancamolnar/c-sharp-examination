namespace BlazorTestProject

{
    public class UnitTest1
    {

        [Fact]
        public void Input_ErrorMessage()
        {

            var guessMyNumber = new GuessMyNumber();
            guessMyNumber.guessInput = "not a number";


            guessMyNumber.CheckGuess();


            Assert.Equal("Hmmm, that doesn't look like a number. Try again.", guessMyNumber.resultMessage);
        }

        [Fact]
        public void GuessIs_SuccessMessage()
        {

            var guessMyNumber = new GuessMyNumber();
            guessMyNumber.guessInput = "5";
            guessMyNumber.theNumber = 5;


            guessMyNumber.CheckGuess();


            Assert.Equal("You got it in 1 guesses!! Great job!", guessMyNumber.resultMessage);
        }

        [Fact]
        public void GuessIsLessThanNumber_HigherMessage()
        {

            var guessMyNumber = new GuessMyNumber();
            guessMyNumber.guessInput = "3";
            guessMyNumber.theNumber = 5;


            guessMyNumber.CheckGuess();


            Assert.Equal("Nope, higher than that.", guessMyNumber.resultMessage);
        }

        [Fact]
        public void GuessIsGreaterThanNumber_LowerMessage()
        {

            var guessMyNumber = new GuessMyNumber();
            guessMyNumber.guessInput = "7";
            guessMyNumber.theNumber = 4;


            guessMyNumber.CheckGuess();


            Assert.Equal("Nope, lower than that.", guessMyNumber.resultMessage);
        }
    }
}
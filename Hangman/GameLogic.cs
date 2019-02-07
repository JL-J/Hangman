using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    class GameLogic
    {
        private string word;
        private string guess;
        private int livesRemaining;
        private string currentDisplay;

        public GameLogic()
        {
            word = "pot";
            guess = String.Empty;
            livesRemaining = 10;
            currentDisplay = "***";
            IsOver = false;
        }

        private string GuessWord()
        {
            if (word.Contains(guess)) { UpdateDisplay(); }
            UpdateGameOver();
            return currentDisplay;
        }

        private void UpdateDisplay()
        {
            int index = word.IndexOf(guess);
            StringBuilder updateDisplay = new StringBuilder(currentDisplay);
            updateDisplay[index] = Convert.ToChar(guess);
            currentDisplay = updateDisplay.ToString();
        }

        private int UpdateLives()
        {
            livesRemaining -= 1;
            UpdateGameOver();
            return livesRemaining; 
        }

        private void UpdateGameOver()
        {
            bool noLives = (livesRemaining == 0);
            bool correctlyGuessedWord = (!currentDisplay.Contains("*"));
            if ( noLives || correctlyGuessedWord ) { IsOver = true; } 
        }

        private string EndMessage()
        {
            bool noLives = (livesRemaining == 0);
            bool correctlyGuessedWord = (!currentDisplay.Contains("*"));

            if (noLives) { return "You lose!!"; }
            if (correctlyGuessedWord) { return "You win! Congratulations!"; }
            return String.Empty;
        }

        public int Lives
        {
            get { return UpdateLives(); }
        }

        public bool IsOver { get; private set; }

        public string Guess
        {
            set { guess = value; }
        }

        public string Display
        {
            get { return GuessWord(); }
        }

        public string EndGameMessage
        {
            get { return EndMessage(); }
        }
    }
}

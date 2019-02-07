using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    class GameLogic
    {
        string word = "pot";
        string guess = String.Empty;
        string currentDisplay = "***";

        private string GuessWord()
        {
            if (word.Contains(guess))
            {
                int index = word.IndexOf(guess);
                StringBuilder updateDisplay = new StringBuilder(currentDisplay);
                updateDisplay[index] = Convert.ToChar(guess);
                currentDisplay = updateDisplay.ToString();
            }

            return currentDisplay;
        }

        public string Guess
        {
            set { guess = value; }
        }

        public string Display
        {
            get { return GuessWord(); }
        }

    }
}

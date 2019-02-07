﻿using System;
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
        private bool gameOver;

        public GameLogic()
        {
            word = "pot";
            guess = String.Empty;
            livesRemaining = 10;
            currentDisplay = "***";
            gameOver = false;
        }

        public int Lives
        {
            get { return UpdateLives(); }
        }

        public bool IsOver
        {
            get { return GameOver(); }
        }

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

        private bool GameOver()
        {
            return gameOver;
        }

        private string EndMessage()
        {
            if (livesRemaining == 0)
            {
                return "You lose!!";
            }
            if (!currentDisplay.Contains("*"))
            {
                return "You win! Congratulations!";
            }
            return String.Empty; 
        }

        private string GuessWord()
        {
            if (word.Contains(guess))
            {
                int index = word.IndexOf(guess);
                StringBuilder updateDisplay = new StringBuilder(currentDisplay);
                updateDisplay[index] = Convert.ToChar(guess);
                currentDisplay = updateDisplay.ToString();
            }
            UpdateGameOver();
            return currentDisplay;
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

            if (noLives || correctlyGuessedWord) { gameOver = true; } 
        }
    }
}

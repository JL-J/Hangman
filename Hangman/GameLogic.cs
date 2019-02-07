﻿using System;
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
        int livesRemaining = 10;
        string currentDisplay = "***";
        bool gameOver = false;

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
            if (!currentDisplay.Contains("*"))
            {
                gameOver = true; 
            }
            return currentDisplay;
        }

        private int UpdateLives()
        {
            livesRemaining -= 1;
            if (livesRemaining == 0)
            {
                gameOver = true;
            }
            return livesRemaining; 
        }
    }
}

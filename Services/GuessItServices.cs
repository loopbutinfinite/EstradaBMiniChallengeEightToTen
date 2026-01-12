using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day_5_Net_8_and_Api_Build_Along.Services
{
    public class GuessItServices
    {
        string userInputMed = "";
        string userInputHard = "";
        public string GuessItGameSelector(string userInput)
        {
            userInput.ToLower();
            if (userInput == "easy")
            {
                return GuessItGameEasy(userInput);
            }
            else if (userInput == "medium")
            {
                userInputMed = userInput;
                return GuessItGameMedium(userInputMed);
            }
            else if (userInput == "hard")
            {
                userInputHard = userInput;
                return GuessItGameHard(userInputHard);
            }
            else
            {
                return "Invalid input. Try again.";
            }
        }
        public string GuessItGameEasy(string userInput)
        {
            if(int.TryParse(userInput, out int num)){
                Random randomEasy = new Random();
                int cpuEasyNum = randomEasy.Next(1, 11);
                if (num < 0 || num > 10)
                {
                    return "Your guess was out of range. Guess a number between 1-10.";
                }
                else
                {
                    if (num > cpuEasyNum)
                    {
                        return $"Your guess {num} was higher.";
                    }
                    else if (num < cpuEasyNum)
                    {
                        return $"Your guess {num} was lower.";
                    }
                    else
                    {
                        return "You guessed correctly!!!";
                    }
                }
            }
            return"Invalid input. Please enter a valid number.";
        }
        public string GuessItGameMedium(string userInputMed)
        {
            if(int.TryParse(userInputMed, out int numMed)){
                Random randomMed = new Random();
                int cpuMedNum = randomMed.Next(1, 51);
                if (numMed < 0 || numMed > 50)
                {
                    return "Your guess was out of range. Guess a number between 1-50.";
                }
                else
                {
                    if (numMed > cpuMedNum)
                    {
                        return $"Your guess {numMed} was higher.";
                    }
                    else if (numMed < cpuMedNum)
                    {
                        return $"Your guess {numMed} was lower.";
                    }
                    else
                    {
                        return "You guessed correctly!!!";
                    }
                }
            }
            return"Invalid input. Please enter a valid number.";
        }
        public string GuessItGameHard(string userInputHard)
        {
            if (int.TryParse(userInputHard, out int numHard))
            {
                Random randomHard = new Random();
                int cpuHardNum = randomHard.Next(1, 101);
                if (numHard < 0 || numHard > 100)
                {
                    return "Your guess was out of range. Guess a number between 1-100.";
                }
                else
                {
                    if (numHard > cpuHardNum)
                    {
                        return $"Your guess {numHard} was higher.";
                    }
                    else if (numHard < cpuHardNum)
                    {
                        return $"Your guess {numHard} was lower.";
                    }
                    else
                    {
                        return "You guessed correctly!!!";
                    }
                }
            }
            return "Invalid input. Please enter a valid number.";
        }
    }
}
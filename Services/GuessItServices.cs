using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MonterrosaDMC5MiniChallengeEightToTen_Endpoint.Services
{
    public class GuessItServices
    {
        public string GuessItEasy(string guess)
        {
            int numberGuess;
            Random rng = new Random();
            int winningNumber = rng.Next(1, 11);
            bool isValid = int.TryParse(guess, out numberGuess);
            if(isValid && numberGuess > 0 && numberGuess < 11) {
                if(numberGuess > winningNumber){
                return $"Your guess was too high. The number was {winningNumber}";
                } else if(numberGuess < winningNumber){
                return $"Your guess was too low. The number was {winningNumber}";
                } else{
                return "You Win!!! Your guess is equal to the random number.";
                }
            }
            return "Error: Input a valid integer value.";
        }
        public string GuessItMedium(string guess)
        {
            int numberGuess;
            Random rng = new Random();
            int winningNumber = rng.Next(1, 51);
            bool isValid = int.TryParse(guess, out numberGuess);
            if(isValid && numberGuess > 0 && numberGuess < 51) {
                if(numberGuess > winningNumber){
                return $"Your guess was too high. The number was {winningNumber}";
                } else if(numberGuess < winningNumber){
                return $"Your guess was too low. The number was {winningNumber}";
                } else{
                return "You Win!!! Your guess is equal to the random number.";
                }
            }
            return "Error: Input a valid integer value.";        
        }
        public string GuessItHard(string guess)
        {
            int numberGuess;
            Random rng = new Random();
            int winningNumber = rng.Next(1, 101);
            bool isValid = int.TryParse(guess, out numberGuess);
            if(isValid && numberGuess > 0 && numberGuess < 101) {
                if(numberGuess > winningNumber){
                return $"Your guess was too high. The number was {winningNumber}";
                } else if(numberGuess < winningNumber){
                return $"Your guess was too low. The number was {winningNumber}";
                } else{
                return "You Win!!! Your guess is equal to the random number.";
                }
            }
            return "Error: Input a valid integer value.";        
        }
    }
}
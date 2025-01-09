using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MonterrosaDMC5MiniChallengeEightToTen_Endpoint.Services
{
    public class Magic8BallServices
    {
        public string Magic8Ball(string askQuestion)
        {
            Random rng = new Random();
            string[] answer = {"Yes","No","Never","Lol no","For sure","Probably","Obviously","How would I know"};
            int indexNumber = rng.Next(8);
            return $"The Magic 8 Ball says: {answer[indexNumber]}!";
        }
    }
}
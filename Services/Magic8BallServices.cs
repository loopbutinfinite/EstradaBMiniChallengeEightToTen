using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day_5_Net_8_and_Api_Build_Along.Services
{
    public class Magic8BallServices
    {
        public string Magic8BallResponse(string userQuestion)
        {
            int randomPrompts = 0;
            Random randomNum = new Random();
            randomPrompts = randomNum.Next(1, 9);

            if (userQuestion == "")
            {
                return "You need to enter a question. Please try again.";
            }
            else
            {
                switch (randomPrompts)
                {
                    case 1:
                        return "Absolutely!";
                    case 2:
                        return "Without a doubt!";
                    case 3:
                        return "Likely.";
                    case 4:
                        return "Yes";
                    case 5:
                        return "No";
                    case 6:
                        return "Uncertain";
                    case 7:
                        return "Perhaps";
                    case 8:
                        return "Ask again.";
                    default:
                        break;
                }
            }
            return "Fires";
        }
    }
}
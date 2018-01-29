using BattleShip.BLL.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BattleShip.UI
{
    public static class ConsoleInput
    {
        internal static Coordinate GetCoordinateFromUser()
        {
            Coordinate toReturn;
            bool validCoord = false;
            int coord1 = 0;
            int coord2 = 0;

            if (!validCoord)
            {

                bool valid = false;
                while (!valid)
                {
                    Console.WriteLine("Enter a valid coordinate. A-J and a valid number 1-10.");
                    string userInput = Console.ReadLine().ToUpper();

                    if (userInput.Length > 3 || userInput.Length == 0)
                    {
                        valid = false;
                    }
                    else if (userInput[0] - 'A' + 1 <= 10
                        && Convert.ToInt32(userInput.Substring(1)) > 0
                         && Convert.ToInt32(userInput.Substring(1)) < 11)
                    {
                        coord1 = userInput[0] - 'A' + 1;
                        coord2 = Convert.ToInt32(userInput.Substring(1));
                        valid = true;
                    }
                }
            }

            return toReturn = new Coordinate(coord1, coord2);
        }

        public static ShipDirection GetDirectionFromUser()
        {
            ShipDirection toReturn = 0;
            bool isValid = false;
            while (!isValid)
            {
                Console.WriteLine("Please Enter \"Up\" \"Down\" \"Left\" or \"Right\": ");
                string userInput = Console.ReadLine();
                if (userInput == "Up" || userInput == "Down" || userInput == "Left" || userInput == "Right")
                {
                    isValid = true;
                    toReturn = (ShipDirection)Enum.Parse(typeof(ShipDirection), userInput);
                }
            }
            return toReturn;
        }
    }
}

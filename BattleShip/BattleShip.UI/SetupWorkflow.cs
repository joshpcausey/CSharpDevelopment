using BattleShip.BLL.Requests;
using BattleShip.BLL.Responses;
using BattleShip.BLL.Ships;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip.UI
{
    public class SetupWorkflow
    {
        public int WhosTurn = 1;
        public static void PlaceShips(Player player)
        {
            for (ShipType s = ShipType.Destroyer; s <= ShipType.Carrier; s++)
            {
                PlaceShipRequest request = new PlaceShipRequest();
                request.ShipType = s;
                Console.WriteLine("Placing " + s);
                request.Coordinate = ConsoleInput.GetCoordinateFromUser();
                request.Direction = ConsoleInput.GetDirectionFromUser();

                ShipPlacement result = player.board.PlaceShip(request);
                if (result != ShipPlacement.Ok)
                {
                    Console.WriteLine("Could not place " + s + " there because of a(n) " + result);
                    s--;
                }
            }
            Console.Clear();
        }

        public static int RandomNumber12()
        {
            Random rnd = new Random();
            return rnd.Next(1, 3);
        }
    }
}

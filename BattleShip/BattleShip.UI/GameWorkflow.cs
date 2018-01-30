using BattleShip.BLL.GameLogic;
using BattleShip.BLL.Requests;
using BattleShip.BLL.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip.UI
{
    public class GameWorkflow
    {
        public static void WhoGoesFirst(string name)
        {
            Console.WriteLine($"{name} goes first");
        }
        public static void PrintEnemyBoard(Player player)
        {
            string[,] BoardPrinted = new string[11, 11];
            for (int x = 0; x < 11; x++)
            {
                for (int y = 0; y < 11; y++)
                {
                    Coordinate currentCoord = new Coordinate(x, y);
                    ShotHistory result = player.board.CheckCoordinate(currentCoord);
                    if(x == 0 || y == 0)
                    {
                        Console.Write("");
                    }
                    else if (result == ShotHistory.Miss)
                    {
                        Console.ForegroundColor = System.ConsoleColor.Yellow;
                        BoardPrinted[x, y] = " M ";
                        Console.Write(BoardPrinted[x, y]);
                        Console.ForegroundColor = System.ConsoleColor.White;
                    }
                    else if (result == ShotHistory.Hit)
                    {
                        Console.ForegroundColor = System.ConsoleColor.Red;
                        BoardPrinted[x, y] = " H ";
                        Console.Write(BoardPrinted[x, y]);
                        Console.ForegroundColor = System.ConsoleColor.White;
                    }
                    else
                    {
                        Console.Write(" U ");
                    } 
                }
                Console.WriteLine("");
            }
        }

        public static ShotStatus FireShotAtEnemey(Player player)
        {
            Coordinate coordToShoot = ConsoleInput.GetCoordinateFromUser();
            ShotStatus returnvValue = player.board.FireShot(coordToShoot).ShotStatus;
            //use return returnValue istead of if else
            if(returnvValue == ShotStatus.Hit)
            {
                Console.WriteLine(ShotStatus.Hit);
                return ShotStatus.Hit;
            }
            else if(returnvValue == ShotStatus.HitAndSunk)
            {
                Console.WriteLine(ShotStatus.HitAndSunk);
                return ShotStatus.HitAndSunk;
            }
            else if(returnvValue == ShotStatus.Duplicate)
            {
                Console.WriteLine(ShotStatus.Duplicate);
                return ShotStatus.Duplicate;
            }
            else if (returnvValue == ShotStatus.Miss)
            {
                Console.WriteLine(ShotStatus.Miss);
                return ShotStatus.Miss;
            }
            else
            {
                return ShotStatus.Victory;
            }
        }
    }
}

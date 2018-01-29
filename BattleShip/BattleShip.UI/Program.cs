using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip.UI
{
    public class Program
    {
        public static void Main()
        {
            Random r = new Random();
            int goingFirst = r.Next(1, 3);
            SplashScreen.ShowSplashScreen();
            Player p1 = new Player();
            Player p2 = new Player();
            Console.Write("Enter Player 1's Name: ");
            string p1Name = Console.ReadLine();
            p1.Name = p1Name;
            Console.Write("Enter Player 2's Name: ");
            string p2Name = Console.ReadLine();
            p2.Name = p2Name;
            SetupWorkflow.PlaceShips(p1);
            SetupWorkflow.PlaceShips(p2);
            switch (goingFirst)
            {
                case 1:
                    GameWorkflow.WhoGoesFirst(p1.Name);
                    break;
                case 2:
                    GameWorkflow.WhoGoesFirst(p2.Name);
                    break;
            }
            bool GameOver = false;
            while (!GameOver)
            {
                GameWorkflow.PrintEnemyBoard(p2);
                BLL.Responses.ShotStatus value1 = (GameWorkflow.FireShotAtEnemey(p2));
                if (value1 == BLL.Responses.ShotStatus.Victory)
                {
                    Console.WriteLine("Game over " + p1.Name + " wins.. ROLLTIDE");
                    GameOver = true;
                }
                GameWorkflow.PrintEnemyBoard(p1);
                BLL.Responses.ShotStatus value2 = (GameWorkflow.FireShotAtEnemey(p1));
                if (value2 == BLL.Responses.ShotStatus.Victory)
                {
                    Console.WriteLine("Game over " + p1.Name + " wins.. ROLLTIDE");
                    GameOver = true;
                }
            }
            if (GameOver)
            {
                Console.Clear();
                Console.WriteLine("Would you to play again? y or n ");
                string input = Console.ReadLine();
                if (input == "y")
                {
                    Program.Main();
                }
            }
        }
    }
}

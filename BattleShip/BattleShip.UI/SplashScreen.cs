using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip.UI
{
    public static class SplashScreen
    {
        public static void ShowSplashScreen()
        {
            Console.Write(@"
  ____        _   _   _        ____  _     _       
 | __ )  __ _| |_| |_| | ___  / ___|| |__ (_)_ __  
 |  _ \ / _` | __| __| |/ _ \ \___ \| '_ \| | '_ \ 
 | |_) | (_| | |_| |_| |  __/  ___) | | | | | |_) |
 |____/ \__,_|\__|\__|_|\___| |____/|_| |_|_| .__/ 
                                            |_|    
");
            System.Threading.Thread.Sleep(3000);
            Console.Clear();
        }
    }
}

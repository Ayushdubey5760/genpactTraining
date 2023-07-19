using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_8
{ public delegate void GameDel();
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Name: ");
            string name = Console.ReadLine();

            int spin = 1;
            Game game = new Game();


            GameDel gameDel = new GameDel(game.zeroSpin);
            while (spin <= 5)

            {
                Console.WriteLine("Enter Your Lucky Number Between 1 to 18");
                int num = int.Parse(Console.ReadLine());

                switch (num)
                {
                    case 1:
                        {
                            gameDel += new GameDel(game.fisrtSpin);
                            break;
                        }
                    case 2:
                        {
                            gameDel += new GameDel(game.SecondSpin);
                            break;
                        }
                    case 3:
                        {
                            gameDel += new GameDel(game.ThirdSpin);
                            break;
                        }
                    case 4:
                        {
                            gameDel += new GameDel(game.FourthSpin);
                            break;
                        }
                    case 5:
                        {
                            gameDel += new GameDel(game.FifthSpin);
                            break;
                        }
                    case 6:
                        {
                            gameDel += new GameDel(game.SixthSpin);
                            break;
                        }
                    case 7:
                        {
                            gameDel += new GameDel(game.SeventhSpin);
                            break;
                        }
                    case 8:
                        {
                            gameDel += new GameDel(game.EighthSpin);
                            break;
                        }
                    case 9:
                        {
                            gameDel += new GameDel(game.NinthSpin);
                            break;
                        }
                    case 10:
                        {
                            gameDel += new GameDel(game.TenthSpin);
                            break;
                        }
                }
                spin++;
            }
            gameDel();


            if (game.energyLevel >= 4 && game.winningProb > 60)
            {
                Console.WriteLine("Winner");

            }
            else if (game.energyLevel >= 1 && game.winningProb > 50)
            {
                Console.WriteLine("Runner up");
            }
            else
            {
                Console.WriteLine("Looser");
            }
            Console.ReadKey();

        }  
            
    }    
}
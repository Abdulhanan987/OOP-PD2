using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Schema;
using EZInput;
using Game.NewFolder1;
using Game.NewFolder2;
namespace Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            int x = 20; int y=20;
            int ex = 2
                ; int ey = 2;
            printPlayer(20,20);
            int ex1 = 70;
            int ey1 = 3;
            printEnemy(2, 2, "     ___", "   (o o)", " /|   |\\", " |   |");
            printEnemy(ex1, ey1, "     ___", "   (o o)", " /|   |\\", " |   |");
            while (true)
            {   
                if(Keyboard.IsKeyPressed(Key.LeftArrow))
                {
                    movePlayerLeft(x, y);
                    x--;
                }
                if(Keyboard.IsKeyPressed(Key.RightArrow))
                {
                    movePlayerRigth(x, y);
                    x++;
                }
                if(Keyboard.IsKeyPressed (Key.UpArrow))
                {
                    movePlayerUp(x, y);
                    y--;
                }
                if(Keyboard.IsKeyPressed(Key.DownArrow))
                {
                    movePlayerDown(x, y);
                    y++;
                }

                moveEnemy(ex, ey, "     ___", "   (o o)", " /|   |\\", " |   |");
                moveEnemy(ex1+1,ey1-1, "     ___", "   (o o)", " /|   |\\", " |   |");
                if (ex==60)
                {
                    eraseEnemy(ex + 1, ey+1, "     ___", "   (o o)", " /|   |\\", " |   |");
                    ex =2;
                   
                }
                if(ey1==25)
                { 
                    eraseEnemy(ex1+1, ey1, "     ___", "   (o o)", " /|   |\\", " |   |");
                    ey1 = 2;
                }
                
                    ex++;
                ey1++;
               Thread.Sleep(50);
            }
            
        }
        static void printPlayer(int x ,int y)
        {
            Player s = new Player(x,y,"     *","  :::::"," :::::",":::::");
            Console.SetCursorPosition(s.px, s.py);
            Console.WriteLine(s.line1);
            Console.SetCursorPosition(s.px+1, s.py+1);
            Console.WriteLine(s.line2);
            Console.SetCursorPosition(s.px+2, s.py+2);
            Console.WriteLine(s.line3);
            Console.SetCursorPosition(s.px + 3, s.py + 3);
            Console.WriteLine(s.line4);
        }
        static void printEnemy(int x , int y ,string l1, string l2,string l3,string l4)
        {
            Enemy enemy = new Enemy(x,y,l1,l2,l3,l4);
            Console.SetCursorPosition(enemy.ex,enemy.ey);
            Console.WriteLine(enemy.Char1);
            Console.SetCursorPosition(enemy.ex+1,enemy.ey+1);
            Console.WriteLine(enemy.Char2);
            Console.SetCursorPosition(enemy.ex+2,enemy.ey+2);
            Console.WriteLine(enemy.Char3);
            Console.SetCursorPosition(enemy.ex+3,enemy.ey+3);
            Console.WriteLine(enemy.Char4);
        }
        static void erasePlayer(int x ,int y)
        {
            Player s = new Player(x, y, "     *", "  :::::", " :::::", ":::::");
            Console.SetCursorPosition(s.px, s.py);
            Console.WriteLine("      ");
            Console.SetCursorPosition(s.px + 1, s.py + 1);
            Console.WriteLine("       ");
            Console.SetCursorPosition(s.px + 2, s.py + 2);
            Console.WriteLine("      ");
            Console.SetCursorPosition(s.px + 3, s.py + 3);
            Console.WriteLine("     ");
        }
        static void movePlayerLeft(int x , int y)
        {
            erasePlayer(x, y);
            x = x - 1;
            printPlayer(x, y);
            
        }
        static void movePlayerRigth(int x, int y)
        {
            erasePlayer(x, y);
            x = x + 1;
            printPlayer(x, y);

        }
        static void movePlayerUp(int x, int y)
        {
            erasePlayer(x, y);
            y = y - 1;
            printPlayer(x, y);

        }
        static void movePlayerDown(int x, int y)
        {
            erasePlayer(x, y);
            y = y + 1;
            printPlayer(x, y);

        }
        static void eraseEnemy(int x, int y, string l1, string l2, string l3, string l4)
        {
            Enemy enemy = new Enemy(x, y, l1, l2, l3, l4);
            Console.SetCursorPosition(enemy.ex, enemy.ey);
            Console.WriteLine("        ");
            Console.SetCursorPosition(enemy.ex + 1, enemy.ey + 1);
            Console.WriteLine("        ");
            Console.SetCursorPosition(enemy.ex + 2, enemy.ey + 2);
            Console.WriteLine("         ");
            Console.SetCursorPosition(enemy.ex + 3, enemy.ey + 3);
            Console.WriteLine("      ");
        }
        static void moveEnemy(int x, int y , string l1, string l2, string l3, string l4)
        {
            eraseEnemy(x,y,l1,l2,l3,l4);
            
            y= y + 1;   
            printEnemy(x, y, l1, l2, l3,l4) ;
        }
    }
}

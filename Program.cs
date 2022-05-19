using System;
using System.Diagnostics;

/*
--gameboard --> 2d array whit caracters --> how to add it to be global 
--show function --> displays the gameboard 
user input and question --> store the input in variable --> TWO INPUT NEEDED FOR TWO PLAYERS --> TWO DIEFFERENT VARIABLE 
modifier function --> change the strings in the array to the given caracter based on the number of the player X O
stat collecter --> reads the status of the game --> if someon win then end if not continue

main function:
while stat collecter false
show
user input 1
modifier 1
show
stat collecter
show
user input 2
modifier 2
show
stat collecter
*/

namespace Helllo
{
    public class Game
    {
        static void Main(string[] args)
        {   
            Gameboard mainboard = new Gameboard();
            User1 user1 = new User1();

            mainboard.Displayboard();
            user1.DisplayUserQuestion1();
        }
    }
    
    public class Gameboard 
    {
        public string[,] gameboard =
        {
            {"1", "2", "3"},
            {"4", "5", "6"},
            {"7", "8", "9"},
        };


        public void Displayboard()
        {
           int rowLength = gameboard.GetLength(0);
           int colLength = gameboard.GetLength(1);

           for(int i = 0; i < rowLength; i++)
           {
               for(int j= 0; j < colLength; j++)
               {
                   System.Console.Write(string.Format("{0}", gameboard[i, j]));
               }
               System.Console.Write(Environment.NewLine + Environment.NewLine);
           }
        }
    }
    public class User1
    {
        public string DisplayUserQuestion1()
        {
            System.Console.Write("What number do you choose?");
            
            string user1Answer =  System.Console.ReadLine();

            return user1Answer;
        }
    }

}




using System;
using System.Diagnostics;

/*
gameboard --> 2d array whit caracters --> how to add it to be global 
show function --> displays the gameboard 
user input and question --> store the input in variable --> TWO INPUT NEEDED FOR TWO PLAYERS --> TWO DIEFFERENT VARIABLE 
modifier function --> change the strings in the array to the given caracter based on the number of the player X O
stat collecter --> reads the status of the game --> if someon win then end if not continue

main function:
while stat collecter false
--show
--user input 1
--modifier 1
--show
--stat collecter
--show
--user input 2
--modifier 2
--show
--stat collecter


need an if function about stat collecter that goes to the main function 
*/

namespace TicTacToe
{
    public class Game
    {
        static void Main(string[] args)
        {   
            Gameboard mainboard = new Gameboard();
            User1 user1 = new User1();
            User2 user2 = new User2();

            while (mainboard.ReturnStat() == false)
            {
               //show
               mainboard.Displayboard();
               //user input1
               user1.DisplayUserQuestion1();
               // modifier 1
               mainboard.ChangeBoard1();
               //show
               mainboard.Displayboard();
               //stat collecter
               mainboard.ReturnStat();
               //show
               mainboard.Displayboard();
               // user input 2
               user2.DisplayUserQuestion2();
               // modifier 2
               mainboard.ChangeBoard2();
               // show
               mainboard.Displayboard();
               // stat collecter
               mainboard.ReturnStat();

            }
            if(mainboard.ReturnStat() == true)
            {
                System.Console.WriteLine("you are the winner!!!!");
            }
        }
    }
    
    public class Gameboard : User2
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

        public void ChangeBoard1()
        {
            if(User1Answer == "1")
            {
                gameboard.SetValue("x", 0,0);
            }
            if(User1Answer == "2")
            {
                gameboard[0,1] = "X";
            }
            if(User1Answer == "3")
            {
                gameboard[0,2] = "X";
            }
            if(User1Answer == "4")
            {
                gameboard[1,0] = "X";
            }
            if(User1Answer == "5")
            {
                gameboard[1,1] = "X";
            }
            if(User1Answer == "6")
            {
                gameboard[1,2] = "X";
            }
            if(User1Answer == "7")
            {
                gameboard[2,0] = "X";
            }
            if(User1Answer == "8")
            {
                gameboard[2,1] = "X";
            }
            if(User1Answer == "9")
            {
                gameboard[2,2] = "X";
            }
        }

        public void ChangeBoard2()
        {
            if(User2Answer == "1")
            {
                gameboard[0,0] = "O";
            }
            if(User2Answer == "2")
            {
                gameboard[0,1] = "O";
            }
            if(User2Answer == "3")
            {
                gameboard[0,2] = "O";
            }
            if(User2Answer == "4")
            {
                gameboard[1,0] = "O";
            }
            if(User2Answer == "5")
            {
                gameboard[1,1] = "O";
            }
            if(User2Answer == "6")
            {
                gameboard[1,2] = "O";
            }
            if(User2Answer == "7")
            {
                gameboard[2,0] = "O";
            }
            if(User2Answer == "8")
            {
                gameboard[2,1] = "O";
            }
            if(User2Answer == "9")
            {
                gameboard[2,2] = "O";
            }
        }

        public bool ReturnStat()
        {
             for (int i = 0; i < 3; i++)
            { //horizontal and vertical check 
                if (gameboard[i,0] == gameboard[i,1] && gameboard[i,1] == gameboard[i,2])
                    return true;
                if (gameboard[0,i] == gameboard[1,i] && gameboard[1,i] == gameboard[2,i])
                    return true;
        
            }
            // diagonal check 
            if (gameboard[0,0] == gameboard[1,1] && gameboard[1,1] == gameboard[2,2])
                return true;
            if (gameboard[0,2] == gameboard[1,1] && gameboard[1,1] == gameboard[2,0])
                return true;
            return false;
        }
            
            

            
    }

    public class User1
    {
        public string User1Answer;
        public void DisplayUserQuestion1()
        {
            System.Console.Write("What number do you choose?");
            
            User1Answer =  System.Console.ReadLine();

        }
    }

    public class User2 : User1
    {
        public string User2Answer;
        public void DisplayUserQuestion2()
        {
            System.Console.Write("What number do you choose?");
            
            User2Answer =  System.Console.ReadLine();

        }
    }

}




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football2
{
    internal class Game
    {
        public int GoalsTeam1 { get; set; }
        public int GoalsTeam2 { get; set; }
        public Game(Team team1, Player[] playersTeam1,Team team2, Player[] playersTeam2,Ref referee,Ref ass1,
            Ref ass2)
        {
            if(playersTeam1.Length != 11 && playersTeam2.Length != 11)
            {
                throw new ArgumentException();
            }
            System.Console.WriteLine("game start");
             GameStart(playersTeam1,playersTeam2);
             Results();
        }
        public void GameStart(Player[] playersTeam1, Player[] playersTeam2)
        {
            int turn = 0;
            for (var i = 0; i < 90; i++)
            {
                int x = Random.Shared.Next(1,101);
            
            if(x<=8){
                int randomPlayer = Random.Shared.Next(1,11);
                if(turn == 0){
                    Console.WriteLine($"Player {playersTeam1[randomPlayer].Name} Scored a goal! from Team1 Min {i}");
                    GoalsTeam1++;
                    
                }
                if(turn==1){
                    Console.WriteLine($"Player {playersTeam2[randomPlayer].Name} Scored a goal! From Team2 Min {i}");
                    GoalsTeam2++;
                    
                }
                
                
            }
            if(turn ==0){
                turn++;

            }
            else if(turn == 1){
                turn--;
            }
            }
            
            

        }
        public void Results()
        {
            Console.WriteLine($"Result is {GoalsTeam1} - {GoalsTeam2}");
            if(GoalsTeam2 > GoalsTeam1)
            {
                Console.WriteLine("Winner Team2");
            }
            else if (GoalsTeam1> GoalsTeam2)
            {
                Console.WriteLine("Winner Team1");
            }
            else{
                Console.WriteLine($"Tie");
                
            }
        }
    }
}

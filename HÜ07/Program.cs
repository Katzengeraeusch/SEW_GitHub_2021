using System;

namespace HÜ07
{
    class Program
    {
        static void Main(string[] args)
        {
            Team teamHome = new Team("Salzburg");
            Team teamVisiting = new Team("Rapid");
            Team teamGleichstand = new Team("NIEMAND!");
            
            Match match1 = new Match(DateTime.Now, teamHome, teamVisiting, teamGleichstand);
            match1.goal(teamHome);
            match1.goal(teamHome);
            match1.goal(teamVisiting);
            match1.winnerTeamMeth();
            Console.WriteLine(match1.getResult());

            Match match2 = new Match(DateTime.Now, teamHome, teamVisiting, teamGleichstand);
            match2.goal(teamHome);
            match2.goal(teamVisiting);
            match2.goal(teamVisiting);
            match2.winnerTeamMeth();
            Console.WriteLine(match2.getResult());

            Match match3 = new Match(DateTime.Now, teamHome, teamVisiting, teamGleichstand);
            match3.goal(teamHome);
            match3.goal(teamHome);
            match3.goal(teamVisiting);
            match3.goal(teamVisiting);
            match3.winnerTeamMeth();
            Console.WriteLine(match3.getResult());




        }
    }
}

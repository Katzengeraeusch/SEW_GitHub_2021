using System;
using System.Collections.Generic;
using System.Text;

namespace HÜ07
{
    class Match
    {
        //Datenkomponenten
        private Team homeTeam;
        private int goalsHomeTeam;
        private Team visitingTeam;
        private int goalsVisitingTeam;
        private DateTime date;
        private Team winnerTeam;
        private Team teamGleichstand;

        //Konstruktor
        public Match(DateTime datein, Team homeTeamin, Team visitingTeamin, Team teamGleichstandin)
        {
            this.homeTeam = homeTeamin;
            this.visitingTeam = visitingTeamin;
            this.date = datein;
            this.goalsHomeTeam = 0;
            this.goalsVisitingTeam = 0;
            this.teamGleichstand = teamGleichstandin;
        }

        
        //Methoden
        
        public void goal(Team team)
        {
          if(team == this.homeTeam )
            {
                this.goalsHomeTeam++;
            }

            if (team == this.visitingTeam)
            {
                this.goalsVisitingTeam++;
            }
        }

        public Team winnerTeamMeth()
        {
            if(this.goalsHomeTeam > this.goalsVisitingTeam)
            {
                this.winnerTeam = this.homeTeam;
            }

            if (this.goalsVisitingTeam > this.goalsHomeTeam)
            {
                this.winnerTeam = this.visitingTeam;
            }

            if (this.goalsHomeTeam == this.goalsVisitingTeam)
            {
                this.winnerTeam = this.teamGleichstand;
            }

            return this.winnerTeam;          
        }

        public string getResult()
        {
            return "Das Spiel vom " + this.date + " bei dem " + this.homeTeam.getteamName() + " gegen " + this.visitingTeam.getteamName() + " spielte gewann " + this.winnerTeam.getteamName() + " bei einem Punktestand von: " + this.goalsHomeTeam + " zu " + this.goalsVisitingTeam;
        }

    }
}

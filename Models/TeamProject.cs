using System;

namespace Bufftecks.Models
{
    public class TeamProject
    {
        public int teamID 
        {
            get
            {
                if (teamID == 3)
                {
                    return 9;
                }
                else{
                    return this.teamID;
                }
            } 
            
            set
            {

            }
        }
            
            

        public Team TheTeam{get; set;}

        public int ProjectID {get; set;}

        public Project TheProject {get; set;}
       
    }
}

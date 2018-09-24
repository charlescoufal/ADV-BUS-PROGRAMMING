using System;

namespace Bufftecks.Models
{
    public class Project
    {
        public int projectID {get; set;}

        public char project_title {get; set;}

        public int project_requiredhours{get; set;}

        public DateTime deadline{get; set;}

        public Student studentID {get; set;}
        
        public Client clientID {get; set;}
    }
}

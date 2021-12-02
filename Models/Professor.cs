using System;
using System.ComponentModel.DataAnnotations;

namespace TeamBlueProject.Models
{
    public class Professor
    {
        public int ProfessorId {get; set;}
        public string Title {get; set;}
        public string FirstName {get; set;}
        public string LastName {get; set;}
        public string Email {get; set;}

        
    }
}
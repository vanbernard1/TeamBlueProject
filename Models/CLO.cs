using System;
using System.ComponentModel.DataAnnotations;

namespace TeamBlueProject.Models
{
    public class CLO
    {
        public int CLOId {get; set;}
        public int CLONumber {get; set;}
        public string Objective {get; set;}
        public string AssessmentPlan {get; set;}
        public string StudentOutcome {get; set;}
              
    }
}
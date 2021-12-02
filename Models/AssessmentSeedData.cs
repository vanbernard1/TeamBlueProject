using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;
using System.Collections.Generic;

namespace TeamBlueProject.Models
{
    public static class AssessmentSeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new AssessmentDbContext(
            serviceProvider.GetRequiredService<DbContextOptions<AssessmentDbContext>>()))

        {
                //Look for any Assessments.
                if (context.Administrators.Any())
                {
                    return; //DB has been seeded
                }
                
                context.Administrators.AddRange(
                    new Administrator {Title = "Dr.", FirstName = "Jeffry", LastName = "Babb", Email = "babb@wtamu.edu"}

                );

                if (context.CLOs.Any())
                {
                    return;
                }

                context.CLOs.AddRange(
                new CLO {CLONumber = 1, Objective = "Analyze an organizational information system needed to elicit system requirements.", AssessmentPlan = "Assignments and Project", StudentOutcome = "An ability to analyze a problem, and to identify and define the computing requirements appropriate to its solution."},
                new CLO {CLONumber = 2, Objective = "Execute an appropriate SDLC process model.", AssessmentPlan = "Assignments and Project", StudentOutcome = "An ability to design, implement, and evaluate a computer-based solution to meet a given set of computing requrements in the context of the discipline."},
                new CLO {CLONumber = 3, Objective = "Given system requirments, design and implement an appropriate system architecture.", AssessmentPlan = "Assignments and Project", StudentOutcome = "An ability to design, implement, and evaluate a computer-based solution to meet a given set of computing requrements in the context of the discipline."},
                new CLO {CLONumber = 4, Objective = "Use source code management tools.", AssessmentPlan = "Assignments and Project", StudentOutcome = "An ability to design, implement, and evaluate a computer-based solution to meet a given set of computing requrements in the context of the discipline."},
                new CLO {CLONumber = 5, Objective = "Negotiate goals and conditions of a satisfaction for a software project with clietns and stakeholders.", AssessmentPlan = "Assignments and Project", StudentOutcome = "An ability to function effectively on teams to establish goals, plan tasks, meet deadlines, manage risk, and produce deliverables."},
                new CLO {CLONumber = 6, Objective = "Utilize collaboration tools to effectively work together in a software development team.", AssessmentPlan = "Assignments and Project", StudentOutcome = "An ability to function effectively on teams to establish goals, plan tasks, meet deadlines, manage risk, and produce deliverables."},
                new CLO {CLONumber = 7, Objective = "Implement a plan for the configuration, deployment and quality assurance of an information systems artifact.", AssessmentPlan = "Assignments and Project", StudentOutcome = "An ability to support the delivery, use, and management of information systems within an information systems environment."}
    
           );

                if (context.Deans.Any())
                {
                    return;
                }

                context.Deans.AddRange(
                    new Dean {Title = "Dr.", FirstName = "Amjad A.", LastName = "Abdullat", Email = "abdullat@wtamu.edu"}

                );

                if (context.Professors.Any())
                {
                    return;
                }

                context.Professors.AddRange(
                    new Professor {Title = "Mr.", FirstName = "Kareem", LastName = "Dana", Email = "dana@wtamu.edu"},
                    new Professor {Title = "Dr.", FirstName = "Sean", LastName ="Humpherys", Email = "humpherys@wtamu.edu"},
                    new Professor {Title = "Dr.", FirstName = "Jeffry", LastName = "Babb", Email = "babb@wtamu.edu"}
                );
        

            context.SaveChanges();
            }
        }  
    }
}
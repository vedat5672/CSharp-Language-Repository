using Microsoft.AspNetCore.Authorization;
using System;
using System.Threading.Tasks;

namespace Web_UnderTheHood.Authorization
{
    public class HRManagerProbationRequirement:IAuthorizationRequirement
    {
        public int ProbationMonths { get; }
        public HRManagerProbationRequirement(int probationMonths)
        {
            ProbationMonths = probationMonths;
        }
        
       
    }
    public class HRManagerProbationRequirementHandler : AuthorizationHandler<HRManagerProbationRequirement>
    {
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, HRManagerProbationRequirement requirement)
        {
            if(!context.User.HasClaim(x=>x.Type=="EmploymentDate"))
                return Task.CompletedTask;
            var empDate = DateTime.Parse(context.User.FindFirst(x => x.Type == "EmploymentDate").Value);
            var period = DateTime.Now - empDate;
            if (period.Days > 30 * requirement.ProbationMonths)
                context.Succeed(requirement);
            return Task.CompletedTask;
        
        }
    }
}

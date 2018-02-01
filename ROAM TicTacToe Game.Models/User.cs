namespace ROAMTicTacToe.Models
{
    using System;
    using System.Security.Claims;
    using System.Threading.Tasks;

    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;

    
    public class User : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<User> manager, string authenticationType)
        {
            
            var userIdentity = await manager.CreateIdentityAsync(this, authenticationType);

           
            return userIdentity;
        }

        public int Wins { get; set; }

        public int Losses { get; set; }

        public DateTime DateRegistration { get; set; }
    }
}

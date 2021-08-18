using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;


namespace MathModeling21.Models
{
    public class User : IdentityUser
    {
        //inherits properties from IdentityUser class 
        [NotMapped]
        public IList<string> RoleNames { get; set; }
    }
}

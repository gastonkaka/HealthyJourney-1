using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthyJourney.Domain.Entities
{
    public class User : IdentityUser
    {
        //[Key]
        //public string UserId { get; set; }

        //[Display(Name = "username")]
        //public string UserName { get; set; }

        //[DataType(DataType.EmailAddress)]
        //public string Email { get; set; }

        //[DataType(DataType.Password)]
        //public string Password { get; set; }

        //[Compare("Password")]
        //[DataType(DataType.Password)]
        //[NotMapped]
        //public string ConfirmPAssword { get; set; }

        //public bool IsApproved { get; set; }

      //  virtual public Infos Infos { get; set; }

    }
}

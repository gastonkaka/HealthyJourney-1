using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HealthyJourney.Angular.Models
{
    public class StripeChargeModel
    {
        [Required]
        public string Token { get; set; }
        [Required]
        public double Amount { get; set; }

        public string CardHolderName { get; set; }

    }
}
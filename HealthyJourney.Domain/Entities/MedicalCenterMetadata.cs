using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthyJourney.Domain.Entities
{
    public class MedicalCenterMetadata
    {
        public int Id { get; set; }
        public string file { get; set; }
        virtual public MedicalCenter MedicalCenter { get; set; }
    }
}

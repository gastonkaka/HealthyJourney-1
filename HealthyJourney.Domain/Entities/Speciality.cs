using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthyJourney.Domain.Entities
{
    public class Speciality
    {
        public int Id { get; set; }

        public string Label { get; set; }
        public string ImgPath { get; set; }
        public string Description { get; set; }

        virtual public IEnumerable<MedicalRecord> MedicalRecords { get; set; }
    }
}

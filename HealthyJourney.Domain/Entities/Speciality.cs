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
        [Key]
        public int Id { get; set; }

        public string Label { get; set; }
        public string ImgPath { get; set; }
        public string Description { get; set; }

        public bool Special { get; set; }

        virtual public IEnumerable<Infos> Infos { get; set; }
        virtual public IEnumerable<MedicalRecord> MedicalRecords { get; set; }

        public Speciality()
        {
            List<Infos> users = new List<Infos>();
            List<MedicalRecord> medialRecords = new List<MedicalRecord>(); 
        }

    }
}

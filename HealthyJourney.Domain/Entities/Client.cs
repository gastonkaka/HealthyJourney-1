using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthyJourney.Domain.Entities
{
    //[Table("Client")]
    public class Client : User
    {

        public string LastName { get; set; }
        public string FirstName { get; set; }

        [DataType(DataType.DateTime)]
        public int Age { get; set; }

        public string Country { get; set; }

        public string Language { get; set; }

        public string Currency { get; set; }

        virtual public IEnumerable<MedicalRecord> MedicalRecords { get; set; }
        virtual public IEnumerable<Comment> Comments { get; set; }
        virtual public IEnumerable<Consultation> Consultations { get; set; }
        virtual public IEnumerable<Facture> Factures { get; set; }

        virtual public IEnumerable<FeedBack> FeedBacks { get; set; }

    }
}

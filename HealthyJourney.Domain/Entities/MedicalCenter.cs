﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthyJourney.Domain.Entities
{
    public class MedicalCenter : ServiceProvider
    {

        virtual public IEnumerable<MedicalCenterMetadata> Files { get; set; }

    }
}

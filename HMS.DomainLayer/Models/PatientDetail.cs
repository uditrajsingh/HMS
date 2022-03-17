using System;
using System.Collections.Generic;

#nullable disable

namespace HMS.DomainLayer.Models
{
    public partial class PatientDetail
    {
        public int PatientId { get; set; }
        public string PatientStatus { get; set; }
        public string PatientProb { get; set; }
    }
}

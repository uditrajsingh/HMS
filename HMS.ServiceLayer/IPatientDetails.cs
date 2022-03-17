using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HMS.DomainLayer.Models;

namespace HMS.ServiceLayer
{
    public interface IPatientDetails
    {
        bool AddPatientDetails(PatientDetail rdobj);
        IList<PatientDetail>FindByStatus(string status);
        bool EditPatientDetails(PatientDetail rdUpdate);

    }
}

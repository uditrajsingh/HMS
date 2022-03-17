using HMS.DomainLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.ServiceLayer
{
    public class PatientDetails :IPatientDetails
    {
        HMSDBContext context;
        public PatientDetails()
        {
            context = new HMSDBContext();
        }
        public bool AddPatientDetails(PatientDetail rdobj)
        {
            context.PatientDetails.Add(rdobj);
            if (context.SaveChanges() > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool EditPatientDetails(PatientDetail rdUpdate)
        {
           var patient= FindById(rdUpdate.PatientId);

            patient.PatientStatus = rdUpdate.PatientStatus;
            patient.PatientStatus = rdUpdate.PatientStatus;
            if (context.SaveChanges() > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public  IList<PatientDetail>FindByStatus(string status)
        {
          return  context.PatientDetails.Where(x=>x.PatientStatus == status).ToList();
        }
        public PatientDetail FindById(int id)
        {
            return context.PatientDetails.Where(x => x.PatientId == id).FirstOrDefault();
        }
    }
}

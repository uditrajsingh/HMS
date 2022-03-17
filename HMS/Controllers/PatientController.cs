using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using HMS.ServiceLayer;
using HMS.DomainLayer;




namespace HMS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientController : ControllerBase
    {
        IPatientDetails _Patient;
        public PatientController(IPatientDetails Patient)
        {
            _Patient = Patient;
        }
        [HttpPost]
        public ActionResult AddPatient(HMS.DomainLayer.Models.PatientDetail Patientobj)
        {
            if (_Patient.AddPatientDetails(Patientobj))
            {
                return Ok("Patient Added");
            }
            else
            {
                return BadRequest();
            }


        }
        [HttpPut]
        public ActionResult UpdatePatient(HMS.DomainLayer.Models.PatientDetail Patientobj)
        {
            if (_Patient.EditPatientDetails(Patientobj))
            {
                return Ok("Patient Updated");
            }
            else
            {
                return BadRequest();
            }


        }

        [HttpGet]
        public ActionResult SearchPatient(string status)
        {
           

            var Patients = _Patient.FindByStatus(status);
            if (Patients != null && Patients.Count > 1)
            {
                return Ok(Patients);
            }
            return BadRequest("Not Found");

        }
    }
}

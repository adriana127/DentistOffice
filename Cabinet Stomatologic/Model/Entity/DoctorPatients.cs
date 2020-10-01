using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cabinet_Stomatologic.Model.Entity
{
    public class DoctorPatients
    {
        doctor _doc;
        patient _patient;
        int numberOfProcedures;

        public DoctorPatients(doctor doc, patient patient, int numberOfProcedures)
        {
            _doc = doc;
            _patient = patient;
            this.numberOfProcedures = numberOfProcedures;
        }

        public doctor Doc { get => _doc; set => _doc = value; }
        public patient Patient { get => _patient; set => _patient = value; }
        public int NumberOfProcedures { get => numberOfProcedures; set => numberOfProcedures = value; }
    }
}

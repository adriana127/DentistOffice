using Cabinet_Stomatologic.Model.Entity;
using Cabinet_Stomatologic.View_Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cabinet_Stomatologic.Model.Action
{
    class AppointmentActions
    {
        public AppointmentActions() {  }
        public ObservableCollection<doctorProcedure> GetAllProcedures() {
            DentistOfficeEntities2 context = new DentistOfficeEntities2();

            ObservableCollection<doctorProcedure> auxList = new ObservableCollection<doctorProcedure>();
            foreach(var procedure in context.doctorProcedures.ToList())
            {
                if(procedure.recordStatus.Equals("Active"))
                auxList.Add(procedure);
            }
            return auxList;
        }
        public ObservableCollection<appointment> GetAllAppointments()
        {
            DentistOfficeEntities2 context = new DentistOfficeEntities2();

            ObservableCollection<appointment> auxList = new ObservableCollection<appointment>();
            foreach (var appointment in context.appointments.ToList())
            {
                if (appointment.recordStatus.Equals("Active"))
                    auxList.Add(appointment);
            }
            return auxList;

        }
        internal void Remove(appointment selectedAppointment)
        {
            DentistOfficeEntities2 context = new DentistOfficeEntities2();
            context.DeactivateAppointment(selectedAppointment.idAppointment);
        }
        internal void Modify(appointment selectedAppointment, patient selectedPatient, doctor doctor, DateTime selectedDate, doctorProcedure procedure, int duration)
        {
            DentistOfficeEntities2 context = new DentistOfficeEntities2();
            context.ModifyAppointment(selectedDate, duration, selectedAppointment.idAppointment, doctor.idDoctor, selectedPatient.idPatient, procedure.idProcedure);
        }
        public ObservableCollection<doctor> DisplayAllDoctors()
        {
            DentistOfficeEntities2 context = new DentistOfficeEntities2();
            var auxList = context.doctors;
            ObservableCollection<doctor> listToReturn = new ObservableCollection<doctor>();
            foreach (var doctor in context.doctors)
            {
                if (doctor.recordStatus != "Inactive")
                    listToReturn.Add(doctor);
            }
            return listToReturn;
        }
        public ObservableCollection<patient> DisplayAllPatients()
        {
            DentistOfficeEntities2 context = new DentistOfficeEntities2();
            var auxList = context.patients;
            ObservableCollection<patient> listToReturn = new ObservableCollection<patient>();
            foreach (var patient in context.patients)
            {
                if (patient.recordStatus != "Inactive")
                    listToReturn.Add(patient);
            }
            return listToReturn;
        }
        public ObservableCollection<patient> SearchPatients(string fullname,string email)
        {
            DentistOfficeEntities2 context = new DentistOfficeEntities2();
            var auxList = context.patients;
            ObservableCollection<patient> listToReturn = new ObservableCollection<patient>();
            foreach (var patientFound in context.SearchPatient(fullname, email).ToList())
            {
                if (patientFound.recordStatus != "Inactive")
                {
                    patient aux = new patient();
                    aux.fullname = patientFound.fullname;
                        listToReturn.Add(aux);
                }
            }
            return listToReturn;
        }

        internal void SaveAppointment(patient selectedPatient, doctor doctor, DateTime selectedDate,doctorProcedure procedure,int duration)
        {
            DentistOfficeEntities2 context = new DentistOfficeEntities2();
            context.AddAppointment(selectedDate,duration,  doctor.idDoctor, selectedPatient.idPatient, procedure.idProcedure);
            context.SaveChanges();
            MainViewModel.Instance.ActiveScreen = new AppointemtsViewModel();
        
        }
    }
}

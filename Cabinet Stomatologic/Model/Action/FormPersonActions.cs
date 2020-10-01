using Cabinet_Stomatologic.Model.Entity;
using Cabinet_Stomatologic.View_Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Cabinet_Stomatologic.Model.Action
{
    public class FormPersonActions
    {
        public FormPersonActions() { }

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
            //return context.doctors.Cast<ObservableCollection<doctor>>().OrderBy(doctor=>doctor).Select(doctor=>doctor);
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
            //return context.doctors.Cast<ObservableCollection<doctor>>().OrderBy(doctor=>doctor).Select(doctor=>doctor);
            return listToReturn;
        }

        public void RemovePatient(patient selectedPatient)
        {
             DentistOfficeEntities2 context = new DentistOfficeEntities2();
            context.DeactivatePatient(selectedPatient.idPatient);
            context.SaveChanges();
            MainViewModel.Instance.ActiveScreen = new PatientViewModel();
        }

        public void AddPersonDetails(int id,string fullName,int docPatientId, string adress, string phoneNumber, string email, bool isDoctor, bool existing)
        {
            DentistOfficeEntities2 context = new DentistOfficeEntities2();
            if (isDoctor == true)
            {
                if (existing == false)
                    context.AddDoctorDetails(fullName, adress, phoneNumber, email);
                else
                    context.UpdateDoctorDetails(id, fullName, adress, phoneNumber, email);
            }
            else
            {
                if (existing == false)
                    context.AddPatientDetails(fullName, adress, phoneNumber, email, docPatientId);
                else
                    context.UpdatePatientDetails(id, fullName, adress, phoneNumber, email, docPatientId);
            }
            context.SaveChanges();

        }
        public void RemoveUser(int id)
        {
            DentistOfficeEntities2 context = new DentistOfficeEntities2();
            context.DeactivateDoctor(id);
            context.SaveChanges();
        }

        public void LogIn(string name, string password)
        {
            DentistOfficeEntities2 context = new DentistOfficeEntities2();

            var conturi = context.accounts.ToList();
            bool contExistent = false;
            foreach (var cont in conturi)
            {
                if (cont.email == name)
                {
                    if (cont.pass == password)
                    {
                        
                        MessageBox.Show("Bun venit!");
                        MainViewModel.Instance.ActiveScreen = new DoctorViewModel(2);
                    }
                    else
                    {
                        MessageBox.Show("Parola gresita!");

                    }
                    contExistent = true;
                }
            }
            if (contExistent == false)
            {
                MessageBox.Show("Cont inexistent!");
            }
        }

        public string GetMonthlySalary(doctor doc)
        {
            DentistOfficeEntities2 context = new DentistOfficeEntities2();

            //ObjectResult<int?> resultList = null;
            //var OutputParamter = new ObjectParameter("salary", typeof(int));
            //resultList = context.CalculateSalaryOnMonth(doc.idDoctor, OutputParamter);
            //return resultList.ToString();

            int salary=0;
            foreach(var appointment in context.appointments)
            {
                if(appointment.idDoctor==doc.idDoctor)
                {
                    salary = salary + int.Parse(appointment.doctorProcedure.price.ToString());
                }
            }
            return salary.ToString();

        }

        public ObservableCollection<DoctorPatients> GetPatientsDoctor(doctor doc)
        {
            DentistOfficeEntities2 context = new DentistOfficeEntities2();

            List<DoctorPatients> auxList = new List<DoctorPatients>();
            foreach (var patient in context.patients)
            {int counter = 0;
                if (patient.idDoc == doc.idDoctor)
                { 
                    foreach (var appointment in context.appointments)
                    {
                        if (appointment.idPatient == patient.idPatient)
                            counter += 1;

                    }
                    auxList.Add(new DoctorPatients(doc, patient, counter));
                } }
            var a= auxList.OrderBy(si => si.NumberOfProcedures).ToList();
            ObservableCollection<DoctorPatients> auxList2 = new ObservableCollection<DoctorPatients>();
            auxList.Sort(new Comparison<DoctorPatients>((x, y) => x.NumberOfProcedures.CompareTo(y.NumberOfProcedures)));

            foreach (var patient in auxList)
            {
             auxList2.Add(patient);
            }
            return auxList2;
        }

        public void SignUp(string name, string password)
        {
            DentistOfficeEntities2 context = new DentistOfficeEntities2();

            var conturi = context.accounts.ToList();
            bool contExistent = false;
            foreach (var cont in conturi)
            {
                if (cont.email == name)
                {

                    MessageBox.Show("Cont deja creat!");
                    contExistent = true;
                }
            }
            if (contExistent == false)
            {

                context.AddAccount(name, password,2);
              
                context.SaveChanges();
                MessageBox.Show("Cont creat cu succes!");
                MainViewModel.Instance.ActiveScreen = new LogInViewModel();
            }
        }

    }
}

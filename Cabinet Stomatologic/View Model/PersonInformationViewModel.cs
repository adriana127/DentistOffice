using Cabinet_Stomatologic.Command;
using Cabinet_Stomatologic.Model.Action;
using Cabinet_Stomatologic.Model.Entity;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Cabinet_Stomatologic.View_Model
{
    class PersonInformationViewModel:BaseViewModel
    {
        
        public PersonInformationViewModel() { }
        doctor _doc;
        patient _patient;

        string _personName = "";
        string _personPhone="";
        string _personEmail="";
        FormPersonActions actions;
        string _monthlySalary = "";

        ObservableCollection<DoctorPatients> _doctorPatientsList;

        public string PersonName { get => _personName; set { _personName = value; OnPropertyChanged(nameof(PersonName)); } }
        public string PersonPhone { get => _personPhone; set { _personPhone = value; OnPropertyChanged(nameof(PersonPhone)); } }
        public string PersonEmail { get => _personEmail; set { _personEmail = value; OnPropertyChanged(nameof(PersonEmail)); } }

        public PersonInformationViewModel(doctor doc)
        {
            _doc = doc;
            PersonName = doc.fullname;
            PersonPhone = doc.personinformation.phone;
            PersonEmail = doc.personinformation.email;
            actions = new FormPersonActions();
           
        }
        public PersonInformationViewModel(patient doc)
        {
            _patient = doc;
            PersonName = doc.fullname;
            PersonPhone = doc.personinformation.phone;
            PersonEmail = doc.personinformation.email;
            actions = new FormPersonActions();
        }
        public ICommand ModifyPersonForm
        {
            get
            {
                return new RelayCommand(() => {
                    if(_doc!=null)
                    MainViewModel.Instance.ActiveScreen = new FornPersonViewModel(_doc,true);
                else if(_patient!=null)
                        MainViewModel.Instance.ActiveScreen = new FornPersonViewModel(_patient, true);

                });
            }
        }
        public ICommand RemovePerson
        {
            get
            {
                return new RelayCommand(() => {
                    if (_doc != null)
                        actions.RemoveUser(_doc.idDoctor);
                    else
                        actions.RemovePatient(_patient);
                    MainViewModel.Instance.ActiveScreen = new DoctorViewModel();
                });
            }
        }

        public ICommand ChangeScreenToPatient
        {
            get
            {
                return new RelayCommand(() =>
                {
                    MainViewModel.Instance.ActiveScreen = new PatientViewModel();

                });
            }
        }

        public ICommand ChangeScreenToDoctor
        {
            get
            {
                return new RelayCommand(() =>
                {
                    MainViewModel.Instance.ActiveScreen = new DoctorViewModel();

                });
            }
        }
        public ICommand ChangeScreenToAppointment
        {
            get
            {
                return new RelayCommand(() =>
                {
                    MainViewModel.Instance.ActiveScreen = new AppointemtsViewModel();

                });
            }
        }

        public ObservableCollection<DoctorPatients> DoctorPatientsList { get {if(_doc!=null) _doctorPatientsList = actions.GetPatientsDoctor(_doc); return _doctorPatientsList; } set { _doctorPatientsList = value; OnPropertyChanged(nameof(DoctorPatientsList)); } }

        public string MonthlySalary { get {

                if (_doc != null)
                    _monthlySalary = actions.GetMonthlySalary(_doc);
                return _monthlySalary;
                    }


            set { _monthlySalary = value;
                OnPropertyChanged(nameof(MonthlySalary));
            } }


        public ICommand ChangeScreenToProcedures
        {
            get
            {
                return new RelayCommand(() =>
                {
                    MainViewModel.Instance.ActiveScreen = new ProcedureViewModel();

                });
            }
        }
        public ICommand ChangeScreenToAccounts
        {
            get
            {
                return new RelayCommand(() =>
                {
                    MainViewModel.Instance.ActiveScreen = new AccountsViewModel();

                });
            }
        }
    }
}

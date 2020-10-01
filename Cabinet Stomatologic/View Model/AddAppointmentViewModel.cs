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
    class AddAppointmentViewModel:BaseViewModel
    {
        AppointmentActions actions;
        public AddAppointmentViewModel(appointment selectedAppointment)
        {
            actions = new AppointmentActions();

            PatientSearch = "Insert Patient's Name";
            DoctorSearch = "Insert Doctor's Name";
            // SelectedDate = DateTime.Parse(selectedAppointment.dateAppointment.ToString());
            SelectedDate = DateTime.Today.AddDays(-1);

            Duration = selectedAppointment.duration.ToString();
        }
        public AddAppointmentViewModel()
        {
            actions = new AppointmentActions();

            PatientSearch = "Insert Patient's Name";
            DoctorSearch = "Insert Doctor's Name";
            SelectedDate = DateTime.Today.AddDays(-1);
        }

        ObservableCollection<doctorProcedure> _procedureList;
        DateTime _selectedDate;
        string _patientSearch;
        string _doctorSearch;
        patient _selectedPatient;
        doctor _doctor;
        doctorProcedure _selectedProcedue;

        string _duration;
        public ObservableCollection<doctorProcedure> ProcedureList
        {
            get { _procedureList = actions.GetAllProcedures(); return _procedureList; }
            set
            {
                _procedureList = value;
                OnPropertyChanged(nameof(ProcedureList));
            }
        }

        ObservableCollection<patient> _listPatients;

        public ObservableCollection<patient> ListPatients
        {
            get { 
                if(PatientSearch == "Insert Patient's Name"|| PatientSearch == "") 
                   _listPatients= actions.DisplayAllPatients();
                else
                    _listPatients = actions.SearchPatients(PatientSearch, PatientSearch);
                return _listPatients; }
            set
            {
                _listPatients = value;
                OnPropertyChanged(nameof(ListPatients));
            }
        }

        ObservableCollection<doctor> _listDoctors;

        public ObservableCollection<doctor> ListDoctors
        {
            get { _listDoctors = actions.DisplayAllDoctors(); return _listDoctors; }
            set
            {
                _listDoctors = value;
                OnPropertyChanged(nameof(ListDoctors));
            }
        }

        public DateTime SelectedDate { get => _selectedDate; set { _selectedDate = value; OnPropertyChanged(nameof(SelectedDate)); } } 
        public string PatientSearch
        {
            get => _patientSearch; set
            {
                _patientSearch = value;

                OnPropertyChanged(nameof(PatientSearch));
                if (ListPatients != null)
                {
                    if (PatientSearch == "Insert Patient's Name" || PatientSearch == "")
                        ListPatients = actions.DisplayAllPatients();
                    else
                        ListPatients = actions.SearchPatients(PatientSearch, PatientSearch);
                }
            }
        }
        public string DoctorSearch { get => _doctorSearch; set { _doctorSearch = value; OnPropertyChanged(nameof(DoctorSearch)); } }
    
    public ICommand Save
        {
            get { return new RelayCommand(() => {
                actions.SaveAppointment(SelectedPatient, SelectedDoctor, SelectedDate,SelectedProcedure,Int32.Parse(Duration));
            
            });
            }
        }

        public patient SelectedPatient { get => _selectedPatient; set { _selectedPatient = value; OnPropertyChanged(nameof(SelectedPatient)); } }
        public doctor SelectedDoctor { get => _doctor; set { _doctor = value; OnPropertyChanged(nameof(SelectedDoctor)); } }
        public doctorProcedure SelectedProcedure { get => _selectedProcedue; set { 
                _selectedProcedue = value; 
                OnPropertyChanged(nameof(SelectedProcedure)); } }

        public string Duration { get => _duration; set { _duration = value; OnPropertyChanged(nameof(Duration)); } }

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

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
    public class FornPersonViewModel : BaseViewModel
    {
        FormPersonActions actions;
        public FornPersonViewModel()
        {
            actions = new FormPersonActions();
            UserType = new ObservableCollection<string>();
            UserType.Add("Doctor");
            UserType.Add("Admin");
            UserType.Add("Patient");
            _doctorsList = new ObservableCollection<doctor>();
            IsAdmin = "Visible";
            IsDoctor = true;
            IsPatient = true;

            Existing = false;
        }
        public bool Existing;
        doctor _doc;
        patient _patient;
        public FornPersonViewModel(doctor doc, bool existing)
        {
            _doc = doc;
            actions = new FormPersonActions();
            UserType = new ObservableCollection<string>();
            _doctorsList = new ObservableCollection<doctor>();
            UserType.Add("Doctor");
            UserType.Add("Admin");
            UserType.Add("Patient");
            FullName = doc.fullname;
            Adress = doc.personinformation.adress;
            Email = doc.personinformation.email;
            PhoneNumber = doc.personinformation.phone;
            Existing = true;
            IsAdmin = "Hidden";
            IsDoctor = true;
            PatientVisibilty = "Visible";
            SelectedUserType = "Patient";
        }
        public FornPersonViewModel(patient patient, bool existing)
        {
            _patient = patient;
            actions = new FormPersonActions();
            UserType = new ObservableCollection<string>();
            _doctorsList = new ObservableCollection<doctor>();
            UserType.Add("Doctor");
            UserType.Add("Admin");
            UserType.Add("Patient");
            FullName = patient.fullname;
            Adress = patient.personinformation.adress;
            Email = patient.personinformation.email;
            PhoneNumber = patient.personinformation.phone;
            Existing = true;
            IsAdmin = "Visible";
            IsDoctor = false;
            PatientVisibilty = "Visible"; SelectedDoctor = patient.doctor;
        }

        string _fullName = "";
        string _adress = "";
        string _phoneNumber = "";
        string _email = "";
        string _selectedUserType = "";
        bool _isDoctor = false;
        string _isAdmin = "Visible";
        bool _isPatient ;
        ObservableCollection<doctor> _doctorsList;

        private ObservableCollection<string> userType;
        public string FullName { get => _fullName; set { _fullName = value; OnPropertyChanged(nameof(FullName)); } }
        public string Adress
        {
            get { return _adress; }
            set
            {
                _adress = value;
                OnPropertyChanged(nameof(Adress));
            }
        }
        public string PhoneNumber
        {
            get => _phoneNumber; set
            {
                _phoneNumber = value; OnPropertyChanged(nameof(PhoneNumber));
            }
        }
        public string Email
        {
            get => _email; set
            {
                _email = value; OnPropertyChanged(nameof(Email));
            }
        }

        string patientVisibilty = "Hidden";
        public bool IsDoctor
        {
            get => _isDoctor; set
            {
                _isDoctor = value;
                OnPropertyChanged(nameof(IsDoctor));
            }
        }

        public ICommand SaveDoctor
        {
            get
            {
                return new RelayCommand(() =>
                {
                    if (Existing == true)


                        actions.AddPersonDetails(_doc.idDoctor, FullName, _doc.idDoctor, Adress, PhoneNumber, Email, IsDoctor, Existing);
                    else
                      {  if (_doc == null)
                    
                        actions.AddPersonDetails(-1, FullName, -1, Adress, PhoneNumber, Email, IsDoctor, Existing);
                    
                    else
                    {
                        actions.AddPersonDetails(-1, FullName, _doc.idDoctor, Adress, PhoneNumber, Email, IsDoctor, Existing);
                    }}


                    MainViewModel.Instance.ActiveScreen = new DoctorViewModel();
                });
            }
        }


        public ObservableCollection<string> UserType
        {
            get => userType; set { userType = value; OnPropertyChanged(nameof(UserType)); }
        }

        public string SelectedUserType
        {
            get => _selectedUserType;
            set
            {
                _selectedUserType = value;
                OnPropertyChanged(nameof(SelectedUserType));
                if (_selectedUserType == "Doctor")
                {
                    IsDoctor = true;
                    IsPatient = false;
                    PatientVisibilty = "Hidden";
                }

                if (_selectedUserType == "Patient")
                {
                    IsDoctor = false;
                    IsPatient = true;
                    PatientVisibilty = "Visible";

                }
            }
        }

        public string IsAdmin { get => _isAdmin; set { _isAdmin = value; OnPropertyChanged(nameof(IsAdmin)); } }
        public bool IsPatient { get => _isPatient; set { _isPatient = value; OnPropertyChanged(nameof(IsPatient)); } }

        public string PatientVisibilty
        {
            get => patientVisibilty; set { patientVisibilty = value; OnPropertyChanged(nameof(PatientVisibilty)); }
        }

        public ObservableCollection<doctor> DoctorsList
        {
            get
            {
                _doctorsList = actions.DisplayAllDoctors();
                return _doctorsList;
            }
            set
            {
                _doctorsList = value;
                OnPropertyChanged(nameof(DoctorsList));
            }
        }

        public doctor SelectedDoctor
        {
            get { return _doc; }
            set
            {
                _doc = value;
                OnPropertyChanged(nameof(SelectedDoctor));
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
    }
}


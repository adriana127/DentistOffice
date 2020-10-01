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
    class PatientViewModel:BaseViewModel
    {
        FormPersonActions actions;
        ObservableCollection<patient> patientList;
        patient _selectedPatient;
        public PatientViewModel()
        {
            actions = new FormPersonActions();
            patientList = new ObservableCollection<patient>();
        }
        public PatientViewModel(int id)
        {
            actions = new FormPersonActions();

            patientList = new ObservableCollection<patient>();
        }
        public ObservableCollection<patient> PatientList
        {
            get
            {
                patientList = actions.DisplayAllPatients();
                return patientList;
            }
            set
            {
                patientList = value;
                OnPropertyChanged(nameof(PatientList));
            }
        }

        public ICommand RemovePatient
        {
            get
            {
                return new RelayCommand(() => {

                    actions.RemovePatient(SelectedPatient);

                }
                );
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

        public ICommand NavigatePersonForm
        {
            get
            {
                return new RelayCommand(() =>
                {
                    MainViewModel.Instance.ActiveScreen = new FornPersonViewModel();
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
        public patient SelectedPatient
        {
            get => _selectedPatient;

            set
            {
                _selectedPatient = value;
                OnPropertyChanged(nameof(SelectedPatient));
                MainViewModel.Instance.ActiveScreen = new PersonInformationViewModel(_selectedPatient);
            }
        }
    }
}

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
    public class DoctorViewModel : BaseViewModel
    {
        DoctorActions actions;
        ObservableCollection<doctor> doctorList;
        doctor _selectedDoctor;
        public DoctorViewModel()
        {
            actions = new DoctorActions(this);
            doctorList = new ObservableCollection<doctor>();
        }
        public DoctorViewModel(int id)
        {
            actions = new DoctorActions(this);
            doctorList = new ObservableCollection<doctor>();
        }
        public ObservableCollection<doctor> DoctorList
        {
            get
            {
                doctorList = actions.DisplayAllDoctors();
                return doctorList;
            }
            set
            {
                doctorList = value;
                OnPropertyChanged(nameof(DoctorList));
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

        public doctor SelectedDoctor
        {
            get => _selectedDoctor;

            set
            {
                _selectedDoctor = value;
                OnPropertyChanged(nameof(SelectedDoctor));
                MainViewModel.Instance.ActiveScreen = new PersonInformationViewModel(_selectedDoctor);
            }
        }
    }
}

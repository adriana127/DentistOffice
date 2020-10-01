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
    class AppointemtsViewModel:BaseViewModel
    {

        AppointmentActions actions;
        appointment _selectedAppointment;
       public AppointemtsViewModel() {
            actions = new AppointmentActions();
        }


        ObservableCollection<appointment> listAppointments;

        public ObservableCollection<appointment> ListAppointments { get { listAppointments = actions.GetAllAppointments(); return listAppointments; }


            set { listAppointments = value; OnPropertyChanged(nameof(ListAppointments)); } }

        public ICommand NavigateAppointmentForm
        {
            get
            {
                return new RelayCommand(() =>
                {
                    MainViewModel.Instance.ActiveScreen = new AddAppointmentViewModel();
                });
            }
        }

        public ICommand RemoveAppointment {
            get {
                return new RelayCommand(()
              =>
          {
              actions.Remove(SelectedAppointment);
              MainViewModel.Instance.ActiveScreen = new AppointemtsViewModel();

          });
            }
        
        }

        public ICommand ModifyAppointment{get {
                return new RelayCommand(()
              =>
          {
              MainViewModel.Instance.ActiveScreen = new AddAppointmentViewModel(SelectedAppointment);

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
        

        public appointment SelectedAppointment { get => _selectedAppointment; set { _selectedAppointment = value; OnPropertyChanged(nameof(SelectedAppointment)); } }



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

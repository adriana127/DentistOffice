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
    class ProcedureViewModel:BaseViewModel
    {
        ProcedureActions actions;
        public ProcedureViewModel() {
            ProcedureList = new ObservableCollection<doctorProcedure>();
            actions = new ProcedureActions();
        }
        ObservableCollection<doctorProcedure> _procedureList;
        doctorProcedure _selectedProcedure;
        string _procedureName;
        string _price;

        public ICommand ModifyProcedure
        {
            get
            {
                return new RelayCommand(() =>
                {

                    actions.Modify(SelectedProcedure, ProcedureName, Price);
                });
            }
        }
        public ICommand RemoveProcedure
        {
            get
            {
                return new RelayCommand(() =>
                {

                    actions.Remove(SelectedProcedure);
                });
            }
        }

        public ICommand AddProcedure
        {
            get
            {
                return new RelayCommand(() =>
                {

                    actions.Add(ProcedureName, Price);
                });
            }
        }

        
        public ObservableCollection<doctorProcedure> ProcedureList { get { _procedureList = actions.GetAllProcedures(); return _procedureList; } set { _procedureList = value; OnPropertyChanged(nameof(ProcedureList)); } }
        public doctorProcedure SelectedProcedure { get => _selectedProcedure; set { _selectedProcedure = value; OnPropertyChanged(nameof(SelectedProcedure)); ProcedureName = SelectedProcedure.nameProcedure;
                Price = SelectedProcedure.price.ToString();
            } }

        public string ProcedureName { get => _procedureName; set {_procedureName = value; OnPropertyChanged(nameof(ProcedureName)); } }
        public string Price { get => _price; set{ _price = value; OnPropertyChanged(nameof(Price)); }
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

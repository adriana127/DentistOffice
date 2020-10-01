using Cabinet_Stomatologic.Command;
using Cabinet_Stomatologic.Model.Entity;
using Cabinet_Stomatologic.Model.Action;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Cabinet_Stomatologic.Model.Actions;

namespace Cabinet_Stomatologic.View_Model
{
    public class AccountsViewModel : BaseViewModel
    {
        AccountActions actions;
        string _isAdmin;
        public string IsAdmin { get { return _isAdmin; } set { _isAdmin = value; OnPropertyChanged(nameof(IsAdmin)); } }

        public AccountsViewModel()
        {
            actions = new AccountActions();
        }
        account _cont;
        public AccountsViewModel(account cont)
        {
            _cont = cont;
            actions = new AccountActions(); 
        }
        ObservableCollection<account> _accountList;

        public ObservableCollection<account> AccountList
        {
            get { _accountList = actions.GetAllAccounts(); return _accountList; }
            set
            {
                _accountList = value;
                OnPropertyChanged(nameof(AccountList));
            }
        }

        account _selectedAccount;

        public account SelectedAccount
        {
            get { return _selectedAccount; }
            set
            {
                _selectedAccount = value;
                OnPropertyChanged(nameof(SelectedAccount));
                MainViewModel.Instance.ActiveScreen = new FormAccountViewModel(_selectedAccount, _cont);
            }
        }
        public ICommand NavigateAccountForm
        {
            get
            {
                return new RelayCommand(() =>
                {
                    MainViewModel.Instance.ActiveScreen = new FormAccountViewModel(_cont);
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

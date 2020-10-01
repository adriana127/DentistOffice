using Cabinet_Stomatologic.Command;

using Cabinet_Stomatologic.Model.Entity;
using Cabinet_Stomatologic.Model.Action;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using Cabinet_Stomatologic.Model.Actions;

namespace Cabinet_Stomatologic.View_Model
{
    public class FormAccountViewModel : BaseViewModel
    {
        ObservableCollection<string> _userTypes;
        AccountActions actions;
        account _account;
        string _visible;
        account _cont;
        string _isAdmin;

        public string IsAdmin { get { return _isAdmin; } set { _isAdmin = value; OnPropertyChanged(nameof(IsAdmin)); } }

        public FormAccountViewModel(account account, account cont)
        {
            _cont = cont;
            _account = account;
            Email = account.email;
            Password = account.pass;
            UserType = account.idUserType.ToString();
            //selec

            //selec
            actions = new AccountActions();
            UserTypes = new ObservableCollection<string>();
            UserTypes.Add("Patient");
            UserTypes.Add("Admin");
            UserTypes.Add("Doctor");
        }
        public FormAccountViewModel()
        {
            actions = new AccountActions();
            UserTypes = new ObservableCollection<string>();

            UserTypes.Add("Patient");
            UserTypes.Add("Admin");
            UserTypes.Add("Doctor");

        }

        public FormAccountViewModel(account cont)
        {
            _cont = cont;
            actions = new AccountActions();
            UserTypes = new ObservableCollection<string>();

            UserTypes.Add("Patient");
            UserTypes.Add("Admin");
            UserTypes.Add("Doctor");
        }


        string _email;
        string _password;
        string _userType;


        public ObservableCollection<string> UserTypes
        {
            get => _userTypes; set
            {
                _userTypes = value;

                OnPropertyChanged(nameof(UserTypes));
            }
        }

        public string UserType
        {
            get => _userType; set
            {
                _userType = value;
                OnPropertyChanged(nameof(UserType));
            }
        }
        public string Password
        {
            get => _password;
            set { _password = value; OnPropertyChanged(nameof(Password)); }
        }
        public string Email
        {
            get => _email; set { _email = value; OnPropertyChanged(nameof(Email)); }
        }
        public ICommand Save
        {
            get
            {
                return new RelayCommand(() => {
                    if ( Email == "" || Password == "" || UserType == "")
                        MessageBox.Show("Complete all fields!");
                    else
                    {
                        if (_account == null)
                            actions.SaveAccount(-1, Email, Password, UserType, _cont);
                        else
                            actions.SaveAccount(_account.idAccount,  Email, Password, UserType, _cont);
                    }

                });
            }
        }
        public ICommand Delete
        {
            get
            {
                return new RelayCommand(() => {

                    actions.DeleteAccount(_account.idAccount, _cont);

                });
            }
        }


        public ICommand ChangeScreenToAccounts
        {
            get
            {
                return new RelayCommand(() =>
                {
                    MainViewModel.Instance.ActiveScreen = new AccountsViewModel(_cont);
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
    }
}

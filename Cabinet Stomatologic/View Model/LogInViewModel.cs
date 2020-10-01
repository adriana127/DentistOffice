using Cabinet_Stomatologic.Command;
using Cabinet_Stomatologic.Model.Action;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Cabinet_Stomatologic.View_Model
{
    class LogInViewModel:BaseViewModel
    {

        FormPersonActions actions;
        public LogInViewModel()
        {
            actions = new FormPersonActions();
        }

        private string userName;
        public string UserName
        {
            get { return userName; }
            set
            {
                userName = value;
                OnPropertyChanged(nameof(UserName));
            }
        }

        private string userPassword;
        public string UserPassword
        {
            get { return userPassword; }
            set
            {
                userPassword = value;
                OnPropertyChanged(nameof(UserPassword));
            }
        }

        public ICommand LogIn
        {
            get
            {
                return new RelayCommand(() =>
                {
                    actions.LogIn(UserName, UserPassword);

                });
            }
        }
        public ICommand SignUp
        {
            get
            {
                return new RelayCommand(() =>
                {
                    MainViewModel.Instance.ActiveScreen = new SignUpViewModel();

                });
            }
        }
       
    }
}

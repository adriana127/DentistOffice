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
    class SignUpViewModel:BaseViewModel
    {

        FormPersonActions actions;
        public SignUpViewModel()
        {
            actions = new FormPersonActions();
        }

        string email;
        public string Email
        {
            get { return email; }
            set
            {
                email = value;
                OnPropertyChanged(nameof(Email));

            }
        }
        string password;
        public string Password
        {
            get { return password; }
            set
            {
                password = value;
                OnPropertyChanged(nameof(Password));

            }
        }

        bool angajat;
        public bool Angajat
        {
            get { return angajat; }
            set
            {
                angajat = value;

                OnPropertyChanged(nameof(Angajat));
            }
        }

        public ICommand Save
        {
            get
            {
                return new RelayCommand(() =>
                {
                    actions.SignUp(Email, Password);
                });

            }
        }
    }
}

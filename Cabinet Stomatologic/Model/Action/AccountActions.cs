using Cabinet_Stomatologic.Model.Entity;
using Cabinet_Stomatologic.View_Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Cabinet_Stomatologic.Model.Actions
{
    public class AccountActions
    {
        public AccountActions() { }
        public ObservableCollection<account> GetAllAccounts()
        {
            DentistOfficeEntities2 context = new DentistOfficeEntities2();
            ObservableCollection<account> auxList = new ObservableCollection<account>();
            foreach (var account in context.accounts.ToList())
            {
                // if (auxList.Contains(room.id) == false)
                if (account.recordStatus == "Active")
                    auxList.Add(account);
            }
            return auxList;
        }

        internal void SaveAccount(int id,  string email, string password, string userType, account cont)
        {
           
                DentistOfficeEntities2 context = new DentistOfficeEntities2();

                if (id == -1)
                {
                    if(userType=="Admin")
                    context.AddAccount(email, password, 2);
                    else if (userType == "Patient")
                        context.AddAccount(email, password, 3);
                    else if (userType == "Doctor")
                        context.AddAccount(email, password, 1);
                    context.SaveChanges();
                }
                else
                {
                    context.ModifyAccount(id, email, password);
                    context.SaveChanges();
                }
                MainViewModel.Instance.ActiveScreen = new AccountsViewModel(cont);
        }

        internal void DeleteAccount(int id, account _cont)
        {
            DentistOfficeEntities2 context = new DentistOfficeEntities2();

            context.DeactivateAccount(id);
            context.SaveChanges();
            MainViewModel.Instance.ActiveScreen = new AccountsViewModel(_cont);
        }
    }
}

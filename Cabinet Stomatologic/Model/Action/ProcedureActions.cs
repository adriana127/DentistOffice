using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cabinet_Stomatologic.Model.Entity;
using Cabinet_Stomatologic.View_Model;

namespace Cabinet_Stomatologic.Model.Action
{
    class ProcedureActions
    {
        public ProcedureActions() { }

        public ObservableCollection<doctorProcedure> GetAllProcedures()
        {
            DentistOfficeEntities2 context = new DentistOfficeEntities2();

            ObservableCollection<doctorProcedure> auxList=new ObservableCollection<doctorProcedure>();
            foreach(var procedure in context.doctorProcedures)
            {
                if(procedure.recordStatus=="Active")
                auxList.Add(procedure);
            }
            return auxList;
        }

        internal void Modify(doctorProcedure selectedProcedure, string procedureName, string price)
        {
            DentistOfficeEntities2 context = new DentistOfficeEntities2();
            context.UpdateMedicalProcedure(selectedProcedure.idProcedure, procedureName, Int32.Parse(price));
            MainViewModel.Instance.ActiveScreen = new ProcedureViewModel();

        }

        internal void Remove(doctorProcedure selectedProcedure)
        {
            DentistOfficeEntities2 context = new DentistOfficeEntities2();
            context.DeactivateMedicalProcedure(selectedProcedure.idProcedure,selectedProcedure.nameProcedure,1);

            MainViewModel.Instance.ActiveScreen = new ProcedureViewModel();
        }

        internal void Add(string procedureName, string price)
        {
            DentistOfficeEntities2 context = new DentistOfficeEntities2();
            context.AddMedicalProcedure(1, procedureName, Int32.Parse(price));
            MainViewModel.Instance.ActiveScreen = new ProcedureViewModel();

        }
    }
}

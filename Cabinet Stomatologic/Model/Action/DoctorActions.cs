using Cabinet_Stomatologic.Model.Entity;
using Cabinet_Stomatologic.View_Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cabinet_Stomatologic.Model.Action
{
    public class DoctorActions
    {
        DoctorViewModel doctorContext;
        public DoctorActions(DoctorViewModel docContext )
        {
            doctorContext = docContext;
        }

        public ObservableCollection<doctor> DisplayAllDoctors()
        {
            DentistOfficeEntities2 context =new DentistOfficeEntities2();
            var auxList = context.doctors;
            ObservableCollection<doctor> listToReturn = new ObservableCollection<doctor>();
            foreach(var doctor in context.doctors)
            {
                if(doctor.recordStatus!="Inactive")
                listToReturn.Add(doctor);
            }
            //return context.doctors.Cast<ObservableCollection<doctor>>().OrderBy(doctor=>doctor).Select(doctor=>doctor);
                return listToReturn;
        }



    }
}

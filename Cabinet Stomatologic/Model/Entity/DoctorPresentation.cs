using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cabinet_Stomatologic.Model.Entity
{
    class DoctorPresentation
    {
        string _lastName;
        string _firstName;
        string _photo;
        string _phone;

        public DoctorPresentation(string lastName, string firstName, string photo, string phone)
        {
            _lastName = lastName;
            _firstName = firstName;
            _photo = photo;
            _phone = phone;
        }

        public string LastName { get => _lastName; set => _lastName = value; }
        public string FirstName { get => _firstName; set => _firstName = value; }
        public string Photo { get => _photo; set => _photo = value; }
        public string Phone { get => _phone; set => _phone = value; }
    }
}

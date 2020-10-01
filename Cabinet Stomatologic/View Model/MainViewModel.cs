using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cabinet_Stomatologic.View_Model
{
    class MainViewModel : BaseViewModel
    {
        BaseViewModel _activeScreen = new DoctorViewModel();

        public MainViewModel()
        {
            Instance = this;
        }

        public BaseViewModel ActiveScreen { get => _activeScreen;
            set { _activeScreen = value;
                OnPropertyChanged(nameof(ActiveScreen));} }

    public static MainViewModel Instance { get; private set; }


}
}

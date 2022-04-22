using MVVM.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMLib
{
    public class MainWindowViewModel : ObservableObject
    {
        private string _title { get; set; } = "HELLLO";

        public string Title
        {
            get { return _title; } 
            set
            {
                _title = value;

                RaisePropertyChangedEvent(nameof(Title));
            }
        }

    }
}

using DbLib;
using MVVM.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVMLib
{
    public class MainWindowViewModel : ObservableObject
    {
        private ChinookContext db;

        public MainWindowViewModel()
        {
            db = new ChinookContext();
        }

        public int EmployeeCount => db.Employees.Count();

        private int _count = 0;

        public int Count
        {
            get { return _count; }
            set
            {
                _count = value;
                RaisePropertyChangedEvent(nameof(Count));
            }
        }


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

        public ICommand AddArtist => new RelayCommand<string>(_ =>
        {
            Count++;
        });


    }
}

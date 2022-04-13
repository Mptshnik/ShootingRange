using ShootingRange.Commands;
using ShootingRange.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ShootingRange.ViewModels
{
    public class ApplicationViewModel : INotifyPropertyChanged
    {
        private DatabaseContext _databaseContext = new DatabaseContext();
        
        #region Collections
        public ObservableCollection<Employee> Employees { get; set; }
        public ObservableCollection<Post> Posts { get; set; }

        #endregion

        #region Commands
        public RelayCommand AddEmployeeCommand { get; }
        public RelayCommand EditEmployeeCommand { get; }
        public RelayCommand DeleteEmployeeCommand { get; }
        #endregion

        #region Properties
        private Employee _selectedEmployee;
        public Employee SelectedEmployee 
        { 
            get 
            {
                return _selectedEmployee;
            } 
            set 
            {
                _selectedEmployee = value;
                OnPropertyChanged("SelectedEmployee");
            } 
        }
        #endregion

        public event PropertyChangedEventHandler PropertyChanged;

        public ApplicationViewModel()
        {

            Posts = new ObservableCollection<Post>()
            {
                new Post{ Name = "Инструктор" },
                new Post{ Name = "Кассир" },
                new Post{ Name = "Директор" },
                new Post{ Name = "Системный администратор" }
            };

            _databaseContext.Posts.AddRange(Posts);
            _databaseContext.SaveChanges();

            AddEmployeeCommand = new RelayCommand(ExecuteAddEmployeeCommand);
            EditEmployeeCommand = new RelayCommand(ExecuteEditEmployeeCommand, CanExecuteEditEmployeeCommand);
            DeleteEmployeeCommand = new RelayCommand(ExecuteDeleteEmployeeCommand, CanExecuteDeleteEmployeeCommand);
        }

        public void ExecuteAddEmployeeCommand(object obj)
        {
            
        }

        public void ExecuteEditEmployeeCommand(object obj)
        {

        }

        public void ExecuteDeleteEmployeeCommand(object obj)
        {

        }

        public bool CanExecuteDeleteEmployeeCommand(object obj)
        {
            return Employees.Count > 0 && SelectedEmployee != null;
        }

        public bool CanExecuteEditEmployeeCommand(object obj)
        {
            return Employees.Count > 0 && SelectedEmployee != null;
        }


        public void OnPropertyChanged([CallerMemberName] string property = "")
        {
            if(PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }
    }
}

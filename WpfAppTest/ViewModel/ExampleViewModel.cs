using System.Collections.Generic;
using WpfAppTest.Model;

namespace WpfAppTest.ViewModel
{
    public class ExampleViewModel: ViewModelBase
    {

        #region Cascaded ComboBox using List<T> class

        #region Private Fields
        private List<City> _CityList;
        private string _SelectedCityCode;
        private int _SelectedShiftId;
        private List<Employee> _EmpList;
        private List<Departments> _DepList;
        private List<Team> _TeamList;
        private List<Shift> _ShiftList;
        private string _SelectedDep;
        private string _SelectedEmp;
        private string _SelectedTeam;
        private string _SelectedShift;
        #endregion

        #region Public Properties
        /// <summary>
        /// Get or set a list of cities
        /// </summary>
        public List<City> CityList
        {
            get { return _CityList; }
            set
            {
                _CityList = value;
                OnPropertyChanged("CityList");
            }
        }

        #region Public Properties
        /// <summary>
        /// Get or set a list of employees
        /// </summary>
        public List<Employee> EmpList
        {
            get { return _EmpList; }
            set
            {
                _EmpList = value;
                OnPropertyChanged("EmpList");
            }
        }

        /// <summary>
        /// Get or set selected city by code
        /// </summary>
        public string SelectedCityCode
        {
            get { return _SelectedCityCode; }
            set
            {
                _SelectedCityCode = value;
                OnPropertyChanged("SelectedCityCode");

                // Trigger Enable/Disable UI element when a particular city is selected
                OnPropertyChanged("AllowDepSelection");

                // Generate a new list of states based on a selected city
                getDepList();
            }
        }

        public int SelectedShiftId
        {
            get { return _SelectedShiftId; }
            set
            {
                _SelectedShiftId = value;
                OnPropertyChanged("SelectedShiftId");

                OnPropertyChanged("AllowTeamSelection");

                getTeamList();
            }
        }

        public List<Departments> DepList
        {
            get { return _DepList; }
            set
            {
                _DepList = value;
                OnPropertyChanged("DepList");
            }
        }

        public List<Team> TeamList
        {
            get { return _TeamList; }
            set
            {
                _TeamList = value;
                OnPropertyChanged("TeamList");
            }
        }
        public List<Shift> ShiftList
        {
            get { return _ShiftList; }
            set
            {
                _ShiftList = value;
                OnPropertyChanged("ShiftList");
            }
        }

        public string SelectedDep
        {
            get { return _SelectedDep; }
            set
            {
                _SelectedDep = value;
                OnPropertyChanged("SelectedDep");
            }
        }

        public string SelectedTeam
        {
            get { return _SelectedTeam; }
            set
            {
                _SelectedTeam = value;
                OnPropertyChanged("SelectedTeam");
            }
        }

        public string SelectedShift
        {
            get { return _SelectedShift; }
            set
            {
                _SelectedShift = value;
                OnPropertyChanged("SelectedShift");
            }
        }

        public string SelectedEmp
        {
            get { return _SelectedEmp; }
            set
            {
                _SelectedEmp = value;
                OnPropertyChanged("SelectedEmp");
            }
        }

        public bool AllowDepSelection
        {
            get { return (SelectedCityCode != null); }
        }

        public bool AllowTeamSelection
        {
            get { return (SelectedCityCode != null); }
        }
        #endregion

        #region Constructors
        public ExampleViewModel()
        {
            City _City = new City();
            CityList = _City.getCities();
            Employee _Emp = new Employee();
            EmpList = _Emp.getEmployees();
            Shift _Shift = new Shift();
            ShiftList = _Shift.getShift();
        }
        #endregion

        #region Private Methods
        private void getDepList()
        {
            Departments _Dep = new Departments();
            DepList = _Dep.getDepByCityCode(SelectedCityCode);
        }

        private void getTeamList()
        {
            Team _Team = new Team();
            TeamList = _Team.getTeamByShiftId(SelectedShiftId);
        }

        private void getShiftList()
        {
            Shift _Shift = new Shift();
            ShiftList = _Shift.getShift();
        }

        private void getEmpList()
        {
            Employee _Emp = new Employee();
            EmpList = _Emp.getEmployees();
        }
        #endregion

        #endregion

        #endregion
    }
}

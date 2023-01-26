using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppTest.Model
{
    public class ExampleModel
    {
    }

    /// <summary>
    /// City object
    /// </summary>
    public class City
    {
        public string CityName { get; set; }
        public string CityCode { get; set; }

        public List<City> getCities()
        {
            List<City> returnCities = new List<City>();
            returnCities.Add(new City() { CityName = "Алматы", CityCode = "02" });
            returnCities.Add(new City() { CityName = "Астана", CityCode = "01" });
            return returnCities;
        }
    }

    /// <summary>
    /// Department object
    /// </summary>
    public class Departments
    {
        public string CityCode { get; set; }
        public string DepName { get; set; }

        public List<Departments> getDepartmentsCollection()
        {
            List<Departments> returnDeps = new List<Departments>();
            returnDeps.Add(new Departments() { CityCode = "02", DepName = "Цех" });
            returnDeps.Add(new Departments() { CityCode = "01", DepName = "Цех2" });
            returnDeps.Add(new Departments() { CityCode = "02", DepName = "Цех5" });
            return returnDeps;
        }

        public List<Departments> getDepByCityCode(string cityCode)
        {
            List<Departments> depList = new List<Departments>();
            foreach (Departments currentState in getDepartmentsCollection())
            {
                if (currentState.CityCode == cityCode)
                {
                    depList.Add(new Departments() { CityCode = currentState.CityCode, DepName = currentState.DepName });
                }
            }
            return depList;
        }
    }

    /// <summary>
    /// Employee object
    /// </summary>
    public class Employee
    {
        public string Name { get; set; }
        public int entityId { get; set; }

        public List<Employee> getEmployees()
        {
            List<Employee> returnEmployees = new List<Employee>();
            returnEmployees.Add(new Employee() { Name = "Ардак", entityId = 1 });
            returnEmployees.Add(new Employee() { Name = "Торгын", entityId = 2 });
            return returnEmployees;
        }
    }

    /// <summary>
    /// Shift object
    /// </summary>
    public class Shift
    {
        public string ShiftName { get; set; }
        public int shiftId { get; set; }

        public List<Shift> getShift()
        {
            List<Shift> returnShift = new List<Shift>();
            returnShift.Add(new Shift() { ShiftName = "Первая с 8 до 20:00", shiftId = 1 });
            returnShift.Add(new Shift() { ShiftName = "Вторая с 20:00 до 8:00 ", shiftId = 2 });
            return returnShift;
        }
    }

    /// <summary>
    /// Employee object
    /// </summary>
    public class Team
    {
        public string TeamName { get; set; }
        public int teamId { get; set; }
        public int shiftId { get; set; }

        public List<Team> getTeamList()
        {
            List<Team> returnEmployees = new List<Team>();
            returnEmployees.Add(new Team() { TeamName = "Бригада 1", teamId = 1, shiftId = 1 });
            returnEmployees.Add(new Team() { TeamName = "Бригада 2", teamId = 2, shiftId = 2 });
            return returnEmployees;
        }

        public List<Team> getTeamByShiftId(int shiftId)
        {
            List<Team> teamList = new List<Team>();
            foreach (Team currentItem in getTeamList())
            {
                if (currentItem.shiftId == shiftId)
                {
                    teamList.Add(new Team() { shiftId = currentItem.shiftId, TeamName = currentItem.TeamName });
                }
            }
            return teamList;
        }
    }
}

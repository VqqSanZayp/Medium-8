using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1._1
{
    class DataBase
    {
        private List<User> _users = new List<User>();

        public void AddUser(User user) => _users.Add(user);
        public void RemoveUser(User user) => _users.Remove(user);

        public User GetUser(string name) => _users.FirstOrDefault(user => user.Name == name);
        public User GetUser(int id) => _users.FirstOrDefault(user => user.Id == id);
        public IReadOnlyCollection<User> GetAllUsers() => _users;

        public IEnumerable<User> GetUsersWithHigherSalary(int salary) => _users.Where(users => users.Salary > salary);
        public IEnumerable<User> GetUsersWithLowerSalary(int salary) => _users.Where(users => users.Salary < salary);
        public IEnumerable<User> GetUsersInSalaryRange(int lowerSalary, int higherSalary) =>
            _users.Where(users => users.Salary > lowerSalary && users.Salary < higherSalary);
    }

    class User
    {
        static private int _idNewUser = 0;

        public int Id { get; private set; }
        public string Name { get; private set; }
        public int Salary { get; private set; }

        public User(string name, int salary)
        {
            Id = ++_idNewUser;
            Name = name;
            Salary = salary;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracExam3SemSPS
{
    class Employee
    {
        private string name;
        private string surname;
        public Employee(string name, string surname)
        {
            this.name = name;
            this.surname = surname;
        }
        public string Name
        {
            get
            {
                return name;
            }
        }
        public string Surname
        {
            get
            {
                return surname;
            }
        }
    }
    class Student : Employee
    {
        private string numGroup;
        public string NumGroup
        {
            get
            {
                return numGroup;
            }
            set
            {
                numGroup = value;
            }
        }
        public Student(string numGroup,string name, string surname ) 
            : base(name,surname)
        {
            NumGroup = numGroup;
        }
    }
    class Teacher : Employee
    {
        private string nameKaf;
        public string NameKaf
        {
            get
            {
                return nameKaf;
            }
            set
            {
                nameKaf = value;
            }
        }
        public Teacher(string nameKaf, string name, string surname)
            : base(name, surname)
        {
            NameKaf = nameKaf;
        }
    }
    class DataPSU
    {
        private List<Employee> employee;
        public DataPSU()
        {
            employee = new List<Employee>();
        }
        public DataPSU(Employee[] employeeArray)
        {
            if (employeeArray!=null)
                employee = employeeArray.ToList();
        }
        public DataPSU(List<Employee> employeeList)
        {
            if (employeeList != null)
                employee = employeeList;
        }
        public static override bool operator ==(Employee a, Employee b)
        {
                return a.Name == b.Name && a.Surname == b.Surname;
        }
        public bool CheckEmployee(Employee employee)
        {
            foreach (Employee e in this.employee)
            {
                if (e == employee)
                {
                    return true;
                }
            }
            return false;
        }
        public void Add(Student student) 
        {
            employee.Add(student);
        }
        public void Add(Teacher teacher) 
        {
            employee.Add(teacher);
        }
        public void Delete(Student student)
        {
            employee.Remove(student);
        }
        public void Delete(Teacher teacher)
        {
            employee.Remove(teacher);
        }
        public Employee[] GetEmloyee()
        {
            return employee.ToArray();
        }
    }
    class PSU
    {
        private DataPSU dataAll;
        private DataPSU dataInU;
        public DataPSU Data
        {
            get
            {
                return dataAll;
            }
        }
        public PSU(Employee[] employeeArray)
        {
            dataAll = new DataPSU(employeeArray);
            dataInU = new DataPSU();
        }
        public PSU(List<Employee> employeeList)
        {
            dataInU = new DataPSU();
            dataAll = new DataPSU(employeeList);
        }
        public PSU()
        {
            dataInU = new DataPSU();
            dataAll = new DataPSU();
        }
        public void Pass(Student student)
        {
            dataInU.Add(student);
        }
        public void Pass(Teacher teacher)
        {
            dataInU.Add(teacher);
        }
        public void LetGo(Student student)
        {
            dataInU.Delete(student);
        }
        public void LetGo(Teacher teacher)
        {
            dataInU.Delete(teacher);
        }
        public DataPSU ShowInU(bool ConsoleShow = true)
        {
            if (ConsoleShow == true)
            {
                foreach (Employee e in dataInU.GetEmloyee())
                {
                    Console.WriteLine(e.Name + " " + e.Surname);
                }
                return dataInU;
            }
            else
            {
                return dataInU;
            }
            
        }
        public void ConnectData(DataPSU data)
        {
            dataAll = data;
        }
    }
}

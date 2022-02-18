using System;
using System.Collections.Generic;

namespace Task_01
{
    [Serializable]
    public class Department
    {
        public string DepartmentName { get; set; }
        public List<Human> Employees { get; set; } = new();

        public Department() { }
        public Department(string name, List<Human> employees) 
            => (DepartmentName, Employees) = (name, employees);

        public override string ToString() =>
            $"{DepartmentName} department. Current department has following employees: {string.Join(" ", Employees)}";
    }
}
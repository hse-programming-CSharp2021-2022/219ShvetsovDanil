using System;
using System.Collections.Generic;

namespace Task_01
{
    [Serializable]
    public class University
    {
        public string UniversityName { get; set; }
        public List<Department> Departments { get; set; }

        public University() { }
        public University(string name, List<Department> departments) => (UniversityName, Departments) = (name, departments);

        public override string ToString() =>
            $"This is {UniversityName} university.\nIt has following departments: {string.Join(" ", Departments)}";
    }
}
using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQBenchmarkTest
{
    [MemoryDiagnoser]
    [RankColumn]
    public class Student
    {
        public string Name { get; set; }
        public byte Age { get; set; }
        public string Department { get; set; }

        [Benchmark]
        public void LINQWhere()
        {
            List<Student> students = new();
            students.Add(new() { Name = "Gabriel", Age = 21, Department = "Chemical Engineering" });
            students.Add(new() { Name = "Patrick", Age = 29, Department = "Quantity Surveying" });
            students.Add(new() { Name = "Silas", Age = 27, Department = "Civil Engineering" });

            var ages = students.Where(x => x.Age == 21);
            foreach (var age in ages)
            {
                Console.WriteLine(age.Name);
            } 
        }

        [Benchmark]
        public void LINQFirst()
        {
            List<Student> students = new();
            students.Add(new() { Name = "Gabriel", Age = 21, Department = "Chemical Engineering" });
            students.Add(new() { Name = "Patrick", Age = 29, Department = "Quantity Surveying" });
            students.Add(new() { Name = "Silas", Age = 27, Department = "Civil Engineering" });

            var ages = students.FirstOrDefault(x => x.Age == 21);
            Console.WriteLine(ages.Name);
        }
    }
}

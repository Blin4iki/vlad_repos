using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lessons
{
    internal class Student
    {
        public string Name{ get; set; }
        public string Group{ get; set; }
        public int Score{ get; set; }

        public void Print ()
        {
            Console.WriteLine ($"{Name}-name {Group}-group {Score}-Score");
        }  
        public Student (string name, int score)
        {
            Name = name;
            Score = score;
            Group = "1";
        }
    }
}

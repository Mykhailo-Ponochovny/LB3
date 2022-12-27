using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB2.models
{
    internal class Worker
    {
        public string id;
        public string name;
        public double salary;
        public int tracks;

        public Worker(string id, string name, double salary, int tracks)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
            this.tracks = tracks;
        }

        public override string ToString()
        {
            return $"ID {id}\n"
                + $"ПІБ {name}\n"
                + $"Зарплатня {salary}грн\n"
                + $"К-сть треків {tracks}\n";
        }
    }
}

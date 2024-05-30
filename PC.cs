using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF25._1
{
    internal class PC
    {

        public PC(string Cpu, string Gpu) 
        {
            this.CPU = Cpu;
            this.GPU = Gpu;
        }

        public string CPU { get; set; }
        public string GPU { get; set; }
    }
}

using System;

namespace lab_7
{
    public class Comp : IComparable
    {
        public string Name { get; set; }
        public string Os { get; set; }
        public string Virob { get; set; }
        public int Proc { get; set; }
        public double Bios { get; set; }
        public double OperMemory { get; set; }
        public bool Inch { get; set; }
        public bool Overclocking { get; set; }

        public string Info()
        {
            return Name + ", " + Os + ", " + Virob;
        }

        public int CompareTo(object obj)
        {
            Comp t = obj as Comp;
            return string.Compare(this.Name, t.Name);
        }

        public Comp()
        {

        }

        public Comp(string name, string os, string virob, int proc, double bios, double operMemory, bool inch, bool overclocking)
        {
            Name = name;
            Os = os;
            Virob = virob;
            Proc = proc;
            Bios = bios;
            OperMemory = operMemory;
            Inch = inch;
            Overclocking = overclocking;
        }
    }
}

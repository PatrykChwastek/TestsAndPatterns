using System;
using System.Collections.Generic;
using System.Text;

namespace TestsAndPatterns.builderPattern
{
    //model
    class Computer
    {
        public string CPU { get; set; }
        public string GPU { get; set; }
        public string RAM { get; set; }
        public string HardDrive { get; set; }

        public void printComuter()
        {
            Console.WriteLine("PC:"+
                "\nCPU: "+CPU+
                "\nGPU: "+GPU+
                "\nRAM: "+RAM+
                "\nHardDrive: "+HardDrive
                );
        }
    }

    // budowniczy 
    abstract class ComputerBuilder
    {
        protected Computer computer;

        public void newComputer()
        {
            computer = new Computer();
        }

        public Computer GetComputer()
        {
            return computer;
        }

        public abstract void buildCPU();
        public abstract void buildGPU();
        public abstract void buildRAM();
        public abstract void buildHardDrive();
    }

    // kierownik -inicjalizacja obiektu
    class ComputerDirector
    {
        private ComputerBuilder computerBuilder;

        public void setBuilder(ComputerBuilder computerBuilder)
        {
            this.computerBuilder = computerBuilder;
        }

        public Computer GetComputer()
        {
            return computerBuilder.GetComputer();
        }

        public void buildComputer()
        {
            computerBuilder.newComputer();
            computerBuilder.buildCPU();
            computerBuilder.buildGPU();
            computerBuilder.buildRAM();
            computerBuilder.buildHardDrive();
        }
    }
    //konkretny budowniczy
    class CheapComputer : ComputerBuilder
    {
        public override void buildCPU()
        {
            computer.CPU = "Ryzen 3";
        }

        public override void buildGPU()
        {
            computer.GPU = "GeForce GT 710";
        }

        public override void buildHardDrive()
        {
            computer.HardDrive = "HDD Samung 512GB";
        }

        public override void buildRAM()
        {
            computer.RAM = "DDR3 4GB";
        }
    }

    //konkretny budowniczy 2
    class AbsurdComputer : ComputerBuilder
    {
        public override void buildCPU()
        {
            computer.CPU = "Intel i9";
        }

        public override void buildGPU()
        {
            computer.GPU = "GeForce RTX 2080 super";
        }

        public override void buildHardDrive()
        {
            computer.HardDrive = "SSD 2TB";
        }

        public override void buildRAM()
        {
            computer.RAM = "DDR4 64GB";
        }
    }
}

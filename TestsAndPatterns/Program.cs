using System;
using TestsAndPatterns.builderPattern;
using TestsAndPatterns.DesignPatterns.Decorator;
using TestsAndPatterns.DesignPatterns.Observer;
using TestsAndPatterns.DesignPatterns.Singleton;

namespace TestsAndPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            BuilderPaternInit();
            DecoratorPaternInit();
            SingletonPaternInit();
            ObserverPaternInit();
        }

        public static void BuilderPaternInit()
        {
            Console.WriteLine("=====================Builder Patern=======================");

            Computer computerForOffice;
            Computer computerForFun;

            ComputerDirector director = new ComputerDirector();
            ComputerBuilder cheapComputerBuilder = new CheapComputer();
            ComputerBuilder expensiveComputerBuilder = new AbsurdComputer();

            director.setBuilder(cheapComputerBuilder);
            director.buildComputer();
            computerForOffice = director.GetComputer();

            Console.WriteLine("\nFirst Computer:");
            computerForOffice.printComuter();

            director.setBuilder(expensiveComputerBuilder);
            director.buildComputer();
            computerForFun = director.GetComputer();

            Console.WriteLine("\nSecond Computer:");
            computerForFun.printComuter();

            Console.WriteLine("=========================================================="+"\n");
        }

        public static void DecoratorPaternInit()
        {
            Console.WriteLine("====================Decorator Patern======================");

            Sandwich standardSandwich = new StandardSandwich();
            standardSandwich = new HamDecorator(standardSandwich);
            Console.WriteLine("Sandwich name: "+ standardSandwich.GetName()+"\nCost: "+standardSandwich.CalculateCost());

            standardSandwich = new KetchupDecorator(standardSandwich);
            Console.WriteLine("Add some ketchup to existing sandwich:");
            Console.WriteLine("Sandwich name: " + standardSandwich.GetName() + "\nCost: " + standardSandwich.CalculateCost());

            Console.WriteLine("==========================================================" + "\n");
        }

        public static void SingletonPaternInit()
        {
            Console.WriteLine("====================Singleton Patern======================");

            DBAccess.Istance.DBConectonData = "DBName=MDB,DBUser=user,DBPass=1234";
            DBAccess.Istance.PrintDBConectionData();

            Console.WriteLine("==========================================================" + "\n");
        }

        public static void ObserverPaternInit()
        {
            Console.WriteLine("====================Observer Patern=======================");

            Student student = new Student();
            Observer observer1 = new Observer("Parent");
            Observer observer2 = new Observer("Educator");
            student.Subscribe(observer1);
            student.Subscribe(observer2);
            student.Grade = 4;
            student.Grade = 5;

            Console.WriteLine("==========================================================" + "\n");
        }
    }
}

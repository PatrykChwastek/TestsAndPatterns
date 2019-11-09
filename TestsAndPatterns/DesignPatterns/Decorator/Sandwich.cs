using System;
using System.Collections.Generic;
using System.Text;

namespace TestsAndPatterns.DesignPatterns.Decorator
{
    // model
    public abstract class Sandwich
    {
        public abstract double CalculateCost();
        public abstract string GetName();
    }

    public class StandardSandwich : Sandwich
    {
        public override double CalculateCost()
        {
            return 2;
        }

        public override string GetName()
        {
            return "Standard Sandwich";
        }
    }

    public class LargeSandwich : Sandwich
    {
        public override double CalculateCost()
        {
            return 3.2;
        }

        public override string GetName()
        {
            return "Large Sandwich";
        }
    }

    // base decorator
    public class SandwichDecorator : Sandwich
    {
        protected Sandwich _sandwich;

        public SandwichDecorator(Sandwich sandwich)
        {
            _sandwich = sandwich;
        }
        public override double CalculateCost()
        {
            return _sandwich.CalculateCost();
        }

        public override string GetName()
        {
            return _sandwich.GetName();
        }
    }

    // concrete decorator
    public class HamDecorator : SandwichDecorator
    {
        public HamDecorator(Sandwich sandwich) : base(sandwich)
        {
        }

        public override double CalculateCost()
        {
            return base.CalculateCost()+1.40;
        }

        public override string GetName()
        {
            return "Ham " + base.GetName();
        }
    }

    // concrete decorator 2
    public class KetchupDecorator : SandwichDecorator
    {
        public KetchupDecorator(Sandwich sandwich) : base(sandwich)
        {
        }

        public override double CalculateCost()
        {
            return base.CalculateCost() + 0.60;
        }

        public override string GetName()
        {
            return "Ketchup " + base.GetName();
        }
    }
}

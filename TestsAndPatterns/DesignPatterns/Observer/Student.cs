using System;
using System.Collections.Generic;
using System.Text;

namespace TestsAndPatterns.DesignPatterns.Observer
{
    interface IObserver
    {
        void Update(int grade);
    }
    public class Observer : IObserver
    {
        public string ObserverName { get; private set; }
        public int Grade { get; set; }
        public Observer(string name)
        {
            this.ObserverName = name;
        }
        public void Update(int grade)
        {
            Grade = grade;
            Console.WriteLine("Message to "+ObserverName + " The grade is: " +Grade);
        }
    }

    public interface ISubject
    {
        void Subscribe(Observer observer);
        void Unsubscribe(Observer observer);
        void Notify(int grade);
    }
    class Student:ISubject
    {
        private List<Observer> observers = new List<Observer>();
        private int _grade;
        public int Grade
        {
            get
            {
                return _grade;
            }
            set
            {
                if (value!=_grade)
                {
                 Notify(value);
                }
                _grade = value;                             
            }
        }
        public void Subscribe(Observer observer)
        {
            observers.Add(observer);
        }

        public void Unsubscribe(Observer observer)
        {
            observers.Remove(observer);
        }

        public void Notify(int grade)
        {
            observers.ForEach(x => x.Update(grade));
        }
    }
}

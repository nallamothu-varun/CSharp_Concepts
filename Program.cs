// See https://aka.ms/new-console-template for more information
using System;
 namespace OOPExample
 {
    
    public class Program
    {
        static void Main(string[] args)
        {
            List<Laptop> laptops = new List<Laptop>() {new MacM1(), new Hp()};
            foreach(var laptop in laptops)
            {
                laptop.TurnOn(true);
            }
        }

    }
 }


using System;

public abstract class Laptop
{

    public virtual void TurnOn(bool activeBois)
    {
        Console.WriteLine("System Turning ON");
    }

    protected void PoweronSelfTest(){
        Console.WriteLine("Checking Processors");
        Console.WriteLine("Checking System Memory");
        Console.WriteLine("Checking USB");
    }

}
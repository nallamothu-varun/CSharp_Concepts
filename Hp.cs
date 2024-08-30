public class Hp : Laptop
{
    public override void TurnOn(bool activeBois)
    {
        base.PoweronSelfTest();
        if(activeBois == true){
            this.OnCpu();
            Console.WriteLine("Turning on Bois");
            this.RunBios();
        }else{
            this.OnCpu();
            Console.WriteLine("Turning on Hp Laptop");
        }
    }

    private void OnCpu(){
        Console.WriteLine("Turning on Cpu");
    }

    private void RunBios(){
        Console.WriteLine("Running Bios...");
    }

}
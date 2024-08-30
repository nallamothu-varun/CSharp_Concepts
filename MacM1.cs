public class MacM1:Laptop
{

    public override void TurnOn(bool activeBois)
    {
        base.PoweronSelfTest();
        if(activeBois == true){
            this.OnCpu();
            Console.WriteLine("Turning on Bois by Mac");
            this.RunBios();
        }else{
            this.OnCpu();
            Console.WriteLine("Turning on MacM1 Laptop");
        }
    }

    private void OnCpu(){
        Console.WriteLine("Turning on Mac Cpu");
    }

    private void RunBios(){
        Console.WriteLine("Running Mac Bios...");
    }
}
using System;
namespace RobotSimulator;
internal class Program
{
    static Robot robot = new Robot();
    static void Main(string[] args)
    {
        Console.TreatControlCAsInput = true;

        Console.WriteLine(new String('-', 50));
        Console.WriteLine("Robot Simulator Console Application");
        Console.WriteLine(new String('-', 50));

        while(true){
            Console.WriteLine("Enter a command (PLACE X,Y,F/MOVE/LEFT/RIGHT/REPORT)");
            Console.Write("Command:");
            string ? command = Console.ReadLine();
            if(!String.IsNullOrEmpty(command))
            {
                Command(command);                 
            }           
        }
    }

    static void Command(string commands){
        var command = commands.Split(' ');
        switch(command[0]){
            case "PLACE":
                if(command.Count() == 2)
                {
                    var placesVal = command[1].Split(',');
                    if(placesVal.Count() == 3)
                    {
                        int x;
                        var parseXResult = int.TryParse(placesVal[0], out x);
                        if(!parseXResult){
                            Console.WriteLine("Input wrong number");
                            goto case "PLACE";
                        }
                        int y;
                        var parseYResult = int.TryParse(placesVal[1], out y);
                        if(!parseYResult){
                            Console.WriteLine("Input wrong number");
                            goto case "PLACE";
                        }
                        var f = placesVal[2];
                        robot.Place(x,y,f);
                    }
                }
                break;
            case "MOVE":
                robot.Move();
                break;
            case "LEFT":
                robot.Left();
                break;
            case "RIGHT":
                robot.Right();
                break;
            case "REPORT":
                robot.Report();
                break;
            default:
                return;
        }
    }
}

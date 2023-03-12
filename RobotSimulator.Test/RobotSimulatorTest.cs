
using RobotSimulator;

namespace RobotSimulator.Test;

[TestClass]
public class RobotSimulatorTest
{
    private readonly Robot _robot;

    public RobotSimulatorTest(){
        _robot = new Robot();
    }

    [TestMethod]
    public void Place_MatchPlaceCondition_RobotHasValue()
    {
        int x = 0;
        int y= 0;
        string f = "NORTH";
        _robot.Place(x,y,f);
        Assert.AreEqual(x, _robot.x);
        Assert.AreEqual(y, _robot.y);
        Assert.AreEqual(f, _robot.facing);
    }
    [TestMethod]
    public void Place_NoMatchPlaceCondition_RobotHasNoValue()
    {
        int x = -1;
        int y= -1;
        string f = "NORTH";
        _robot.Place(x,y,f);
        Assert.IsNull(_robot.x);
        Assert.IsNull(_robot.y);
        Assert.AreEqual(string.Empty, _robot.facing);
    }

    [TestMethod]
    public void Move_PlaceX0Y0FNORTH_MoveToX0Y1FNORTH()
    {
        int x = 0;
        int y= 0;
        string f = "NORTH";
        _robot.Place(x,y,f);
        _robot.Move();
        Assert.AreEqual(x, _robot.x);
        Assert.AreEqual(y+1, _robot.y);
        Assert.AreEqual("NORTH", _robot.facing);
    }

    [TestMethod]
    public void Move_PlaceX0Y4FNORTH_NotMove()
    {
        int x = 0;
        int y= 4;
        string f = "NORTH";
        _robot.Place(x,y,f);
        _robot.Move();
        Assert.AreEqual(x, _robot.x);
        Assert.AreEqual(y, _robot.y);
        Assert.AreEqual("NORTH", _robot.facing);
    }
    [TestMethod]
    public void Move_PlaceX0Y3FNULL_NotMove()
    {
        int x = 0;
        int y= 3;
        string f = null;
        _robot.Place(x,y,f);
        _robot.Move();
        Assert.AreEqual(x, _robot.x);
        Assert.AreEqual(y, _robot.y);
        Assert.AreEqual(null, _robot.facing);
    }

    [TestMethod]
    public void Move_PlaceX0Y0FEAST_MoveToX1Y0FEAST()
    {
        int x = 0;
        int y= 0;
        string f = "EAST";
        _robot.Place(x,y,f);
        _robot.Move();
        Assert.AreEqual(x+1, _robot.x);
        Assert.AreEqual(y, _robot.y);
        Assert.AreEqual("EAST", _robot.facing);
    }

    [TestMethod]
    public void Move_PlaceX4Y0FEAST_NotMove()
    {
        int x = 4;
        int y= 0;
        string f = "EAST";
        _robot.Place(x,y,f);
        _robot.Move();
        Assert.AreEqual(x, _robot.x);
        Assert.AreEqual(y, _robot.y);
        Assert.AreEqual("EAST", _robot.facing);
    }

    [TestMethod]
    public void Move_PlaceX2Y3FSOUTH_MoveToX2Y2FSOUTH()
    {
        int x = 2;
        int y= 3;
        string f = "SOUTH";
        _robot.Place(x,y,f);
        _robot.Move();
        Assert.AreEqual(x, _robot.x);
        Assert.AreEqual(y-1, _robot.y);
        Assert.AreEqual("SOUTH", _robot.facing);
    }

    [TestMethod]
    public void Move_PlaceX2Y0FSOUTH_NotMove()
    {
        int x = 2;
        int y= 0;
        string f = "SOUTH";
        _robot.Place(x,y,f);
        _robot.Move();
        Assert.AreEqual(x, _robot.x);
        Assert.AreEqual(y, _robot.y);
        Assert.AreEqual("SOUTH", _robot.facing);
    }
    [TestMethod]
    public void Move_PlaceX2Y3FWEST_MoveToX2Y2FWEST()
    {
        int x = 2;
        int y= 3;
        string f = "WEST";
        _robot.Place(x,y,f);
        _robot.Move();
        Assert.AreEqual(x-1, _robot.x);
        Assert.AreEqual(y, _robot.y);
        Assert.AreEqual("WEST", _robot.facing);
    }

    [TestMethod]
    public void Move_PlaceX2Y0FWEST_NotMove()
    {
        int x = 0;
        int y= 2;
        string f = "WEST";
        _robot.Place(x,y,f);
        _robot.Move();
        Assert.AreEqual(x, _robot.x);
        Assert.AreEqual(y, _robot.y);
        Assert.AreEqual("WEST", _robot.facing);
    }

    [TestMethod]
    public void Left_PlaceFNORTH_FWEST()
    {
        int x = 0;
        int y= 0;
        string f = "NORTH";
        _robot.Place(x,y,f);
        _robot.Left();
        Assert.AreEqual(x, _robot.x);
        Assert.AreEqual(y, _robot.y);
        Assert.AreEqual("WEST", _robot.facing);
    }
    [TestMethod]
    public void Left_PlaceFWEST_FSOUTH()
    {
        int x = 0;
        int y= 0;
        string f = "WEST";
        _robot.Place(x,y,f);
        _robot.Left();
        Assert.AreEqual(x, _robot.x);
        Assert.AreEqual(y, _robot.y);
        Assert.AreEqual("SOUTH", _robot.facing);
    }

    [TestMethod]
    public void Left_PlaceFSOUTH_FEAST()
    {
        int x = 0;
        int y= 0;
        string f = "SOUTH";
        _robot.Place(x,y,f);
        _robot.Left();
        Assert.AreEqual(x, _robot.x);
        Assert.AreEqual(y, _robot.y);
        Assert.AreEqual("EAST", _robot.facing);
    }
    [TestMethod]
    public void Left_PlaceFEAST_FNORTH()
    {
        int x = 0;
        int y= 0;
        string f = "EAST";
        _robot.Place(x,y,f);
        _robot.Left();
        Assert.AreEqual(x, _robot.x);
        Assert.AreEqual(y, _robot.y);
        Assert.AreEqual("NORTH", _robot.facing);
    }

    [TestMethod]
    public void Right_PlaceFNORTH_FWEST()
    {
        int x = 0;
        int y= 0;
        string f = "NORTH";
        _robot.Place(x,y,f);
        _robot.Right();
        Assert.AreEqual(x, _robot.x);
        Assert.AreEqual(y, _robot.y);
        Assert.AreEqual("EAST", _robot.facing);
    }
    [TestMethod]
    public void Right_PlaceFWEST_FNORTH()
    {
        int x = 0;
        int y= 0;
        string f = "WEST";
        _robot.Place(x,y,f);
        _robot.Right();
        Assert.AreEqual(x, _robot.x);
        Assert.AreEqual(y, _robot.y);
        Assert.AreEqual("NORTH", _robot.facing);
    }

    [TestMethod]
    public void Right_PlaceFSOUTH_FWEST()
    {
        int x = 0;
        int y= 0;
        string f = "SOUTH";
        _robot.Place(x,y,f);
        _robot.Right();
        Assert.AreEqual(x, _robot.x);
        Assert.AreEqual(y, _robot.y);
        Assert.AreEqual("WEST", _robot.facing);
    }
    [TestMethod]
    public void Right_PlaceFEAST_FSOUTH()
    {
        int x = 0;
        int y= 0;
        string f = "EAST";
        _robot.Place(x,y,f);
        _robot.Right();
        Assert.AreEqual(x, _robot.x);
        Assert.AreEqual(y, _robot.y);
        Assert.AreEqual("SOUTH", _robot.facing);
    }

    [TestMethod]
    public void Report_PlaceX0Y0FEASTMove_MoveToX1Y0()
    {
        int x = 0;
        int y= 0;
        string f = "EAST";
        var stringWriter = new StringWriter();
        Console.SetOut(stringWriter);

        _robot.Place(x,y,f);
        _robot.Move();
        _robot.Report();
        Assert.AreEqual(x + 1, _robot.x);
        Assert.AreEqual(y, _robot.y);
        Assert.AreEqual("EAST", _robot.facing);

        var actualOutput = stringWriter.ToString().Trim();
        Assert.AreEqual($"{x+1},{y},EAST", actualOutput);
    }

    [TestMethod]
    public void Report_PlaceX0Y0FEASTLeftMove_MoveToX0Y1FNORTH()
    {
        int x = 0;
        int y= 0;
        string f = "EAST";
        var stringWriter = new StringWriter();
        Console.SetOut(stringWriter);

        _robot.Place(x,y,f);
        _robot.Left();
        _robot.Move();
        _robot.Report();
        Assert.AreEqual(x, _robot.x);
        Assert.AreEqual(y + 1, _robot.y);
        Assert.AreEqual("NORTH", _robot.facing);

        var actualOutput = stringWriter.ToString().Trim();
        Assert.AreEqual($"{x},{y+1},NORTH", actualOutput);
    }

    [TestMethod]
    public void Report_PlaceX5Y5FNORTHRightMove_NotMoveFEAST()
    {
        int x = 4;
        int y= 4;
        string f = "NORTH";
        var stringWriter = new StringWriter();
        Console.SetOut(stringWriter);

        _robot.Place(x,y,f);
        _robot.Right();
        _robot.Move();
        _robot.Report();

        Assert.AreEqual(x, _robot.x);
        Assert.AreEqual(y, _robot.y);
        Assert.AreEqual("EAST", _robot.facing);
        var actualOutput = stringWriter.ToString().Trim();
        Assert.AreEqual($"{x},{y},EAST", actualOutput);
    }
}
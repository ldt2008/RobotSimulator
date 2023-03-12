namespace RobotSimulator;
public class Robot
{
    public int? x;
    public int? y;
    public string facing = string.Empty;
    public int tableSize = 5;


    public enum Direction{
        NORTH,
        SOUTH,
        EAST,
        WEST

    }
    public void Place(int x, int y, string facing)
    {
        if (x >= 0 && x < tableSize && y >= 0 && y < tableSize)
        {
            this.x = x;
            this.y = y;
            this.facing = facing;
        }
    }

    public void Move()
    {
        if (facing == Direction.NORTH.ToString() && y < tableSize - 1)
        {
            y++;
        }
        else if (facing == Direction.SOUTH.ToString() && y > 0)
        {
            y--;
        }
        else if (facing == Direction.EAST.ToString() && x < tableSize - 1)
        {
            x++;
        }
        else if (facing == Direction.WEST.ToString() && x > 0)
        {
            x--;
        }
    }

    public void Left()
    {
        if (facing == Direction.NORTH.ToString())
        {
            facing = Direction.WEST.ToString();
        }
        else if (facing == Direction.SOUTH.ToString())
        {
            facing = Direction.EAST.ToString();
        }
        else if (facing == Direction.EAST.ToString())
        {
            facing = Direction.NORTH.ToString();
        }
        else if (facing == Direction.WEST.ToString())
        {
            facing = Direction.SOUTH.ToString();
        }
    }

    public void Right()
    {
        if (facing == Direction.NORTH.ToString())
        {
            facing = Direction.EAST.ToString();
        }
        else if (facing == Direction.SOUTH.ToString())
        {
            facing = Direction.WEST.ToString();
        }
        else if (facing == Direction.EAST.ToString())
        {
            facing = Direction.SOUTH.ToString();
        }
        else if (facing == Direction.WEST.ToString())
        {
            facing = Direction.NORTH.ToString();
        }
    }

    public void Report()
    {
        if (x.HasValue && y.HasValue && !string.IsNullOrEmpty(facing))
        {
            Console.WriteLine($"{x},{y},{facing}");
        }
    }
}
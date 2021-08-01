using System;
using System.Collections.Generic;

public enum Direction
{
    North,
    East,
    South,
    West
}

public class RobotSimulator
{
    public RobotSimulator(Direction direction, int x, int y)
    {
        _direction = direction;
        _x = x;
        _y = y;
    }
    
    private Direction _direction;
    private int _x;
    private int _y;

    public Direction Direction
    {
        get => _direction;
    }

    public int X
    {
        get => _x;
    }

    public int Y
    {
        get => _y;
    }

    protected void Advance()
    {
        switch (Direction)
        {
            case Direction.North:
                _y++; 
                break;
            case Direction.South:
                _y--; 
                break;
            case Direction.West:
                _x--; 
                break;
            case Direction.East:
                _x++; 
                break;
        }

    }
    protected void RotateLeft()
    {
        _direction = (Direction)((int)(_direction - 1 + 4) % 4);
    }
    protected void RotateRight()
    {
        _direction = (Direction)((int)(_direction + 1) % 4);
    }

    public void Move(string instructions)
    {
        foreach(char instr in instructions)
        {
            switch (instr)
            {
                case 'A': Advance();
                break;
                case 'R': RotateRight();
                break;
                case 'L': RotateLeft();
                break;

                default:
                    throw new InvalidOperationException($"Invalid instruction: '{instr}'");
            }
        }
    }
}
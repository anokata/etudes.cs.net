using System;

public class Queen
{
    public Queen(int row, int column)
    {
        Row = row;
        Column = column;
    }

    public int Row { get; }
    public int Column { get; }
}

public static class QueenAttack
{
    public static bool CanAttack(Queen white, Queen black)
    {
        // Attack by same row or column
        if (white.Row == black.Row || white.Column == black.Column) return true;
        // Attack by diagonal: distance by column and row is equal
        if ((Math.Abs(white.Row - black.Row)) == (Math.Abs(white.Column - black.Column))) return true;
        return false;
    }

    public static Queen Create(int row, int column)
    {
        return (row >= 0 && row < 8 && column < 8 && column >= 0) 
            ? new Queen(row, column) 
            : throw new ArgumentOutOfRangeException();
    }
}
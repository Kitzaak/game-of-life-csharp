using System.Collections.Generic;
using Xunit.Sdk;

namespace game_of_life;

public class Cells
{
    List<Cell> _cells;
    public Cells()
    {
        _cells = new List<Cell>();
    }

    public void Load(List<Cell> cells_to_add)
    {
        _cells.Clear();
        foreach(Cell cell in cells_to_add)
        {
            _cells.Add(cell);
        }
    }

    public int Count => _cells.Count;
    public bool Contains(Cell cell)
    {
        foreach(Cell _cell in _cells)
        {
            if(_cell.X == cell.X && _cell.Y == cell.Y)
                return true;
        }
        return false;
    }

    public void Mutate(Mutation mutation)
    {
        foreach(Cell _cell in _cells)
        {
            if(_cell.X == mutation.Cell.X && _cell.Y == mutation.Cell.Y)
            {
                if(mutation.Action == CellAction.Die)
                    _cells.Remove(_cell);
                return;
            }
        }
    }
}

public class Cell
{
    readonly int _x;
    readonly int _y;

    public Cell(int x = 0, int y = 0)
    {
        _x = x;
        _y = y;
    }

    public int X { get => _x; }
    public int Y { get => _y; }
}

public class Mutation
{
    readonly Cell _cell;
    readonly CellAction _action;

    public Mutation(Cell cell, CellAction action = CellAction.Flip)
    {
        _cell = cell;
        _action = action;
    }

    public Cell Cell { get => _cell; }
    public CellAction Action { get => _action; }
}

public enum CellAction
{
    Flip,
    Die,
    Live
}


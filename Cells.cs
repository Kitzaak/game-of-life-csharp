using System.Collections.Generic;

namespace game_of_life;

public class Cells
{
    List<Tuple> _cells;
    public Cells()
    {
        _cells = new List<Tuple>();
    }
}

public class Tuple
{
    int _x;
    int _y;

    public Tuple(int x = 0, int y = 0)
    {
        _x = x;
        _y = y;
    }
}

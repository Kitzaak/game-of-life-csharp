using Xunit;

namespace game_of_life;

public class CellsTests
{
    [Fact]
    void Can_create_cells_list_and_it_is_empty()
    {
        var cells = new Cells();

        Assert.Equal(0, cells.Count);
    }

    [Fact]
    void Can_load_cells()
    {
        var cells = new Cells();

        var cell_to_add = new List<Cell>
            {
                new(1,2),
                new(2,2),
                new(3,3)
            };

        cells.Load(cell_to_add);

        Assert.Equal(cell_to_add.Count, cells.Count);
    }

    [Fact]
    void Can_check_if_cell_is_alive()
    {
        var cells = new Cells();

        var cell_to_add = new List<Cell>
            {
                new(1,2),
                new(2,2),
                new(3,3)
            };

        cells.Load(cell_to_add);

        Assert.True(cells.Contains(cell_to_add[0]));
        Assert.True(cells.Contains(cell_to_add[1]));
        Assert.True(cells.Contains(cell_to_add[2]));

        Assert.False(cells.Contains(new(0,0)));
    }

    [Fact]
    void Add_remove_live_cells()
    {
        var cells = new Cells();

        var cell_to_add = new List<Cell>
            {
                new(1,2),
                new(2,2),
                new(3,3)
            };

        cells.Load(cell_to_add);
        var dying_cell = new Cell(2, 2);

        Assert.True(cells.Contains(dying_cell));
        
        cells.Mutate(new Mutation(dying_cell, CellAction.Die));

        Assert.False(cells.Contains(dying_cell));
    }
}

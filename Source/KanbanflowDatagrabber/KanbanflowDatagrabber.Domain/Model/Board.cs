namespace KanbanflowDatagrabber.Domain.Model;

public class Board
{
    public string Id { get; set; }
    public string Name { get; set; }
    public List<Column> Columns { get; set; }
    public List<Color> Colors { get; set; }
}

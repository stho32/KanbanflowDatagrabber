namespace KanbanflowDatagrabber.Domain.Model;

public record Board(string Id, string Name, List<Column> Columns, List<Color> Colors);

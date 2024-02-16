using Application.Entities;

namespace Application.Entities;

public class Day
{
    public string? City { get; set; }

    public string? Summary { get; set; }

    public int? HighTemp { get; set; }
    
    public int? LowTemp { get; set; }

    public DateTime Date { get; set; } = DateTime.Today;

    //------ ForeignKey down Below -------
    
    public List<TimeOfDay>?  Times { get; set; }
}

namespace Application.Entities;

public class TimeOfDay : BaseEntity
{

    public Day? Day { get; set; }

    public int? DayId { get; set; }
    
    public DateTime? Time { get; set; } = DateTime.Now;

    public int? TempC { get; set; }
    
    public int? TempF { get; set; }

    public int? Wind { get; set; }
    
    public int? UvIndex { get; set; }

    public string? Humidity { get; set; }

    public int? Visibility { get; set; }

    public decimal? Pressure { get; set; }

    public string? Summary { get; set; }
}
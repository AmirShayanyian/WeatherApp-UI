using Application.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Application.Entities;

public class Day : BaseEntity
{
    public string? City { get; set; }

    public string? Summary { get; set; }

    public int? HighTemp { get; set; }
    
    public int? LowTemp { get; set; }

    public DateTime Date { get; set; } = DateTime.Today;

    //------ ForeignKey down Below -------
    
    public List<TimeOfDay>?  Times { get; set; }
}

public class DayConfiguration : IEntityTypeConfiguration<Day>
{
    public void Configure(EntityTypeBuilder<Day> builder)
    {
        builder.HasMany(p => p.Times)
            .WithOne(p => p.Day)
            .HasForeignKey(p => p.DayId);
    }
}
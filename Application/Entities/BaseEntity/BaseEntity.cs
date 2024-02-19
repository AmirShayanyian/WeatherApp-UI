

namespace Application.Entities;

public class BaseEntity : BaseEntity<int>
{
    
}

public class BaseEntity<TKey> : IBaseEntity
{
    public TKey ID { get; set; }
}
using System.ComponentModel.DataAnnotations;

namespace Application.Entities.BaseEntity;

public class BaseEntity : BaseEntity<int>
{
    
}

public class BaseEntity<TKey> : IBaseEntity
{
    public TKey ID { get; set; }
}
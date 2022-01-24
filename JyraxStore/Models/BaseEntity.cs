using System;

namespace JyraxStore.Models
{
    public class BaseEntity
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public DateTime CreatedAt { get; set; }
        public string UpdatedAt { get; set; } = DateTime.Now.ToString();

    }
}

using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace lbhDynamics365AccessTokenApi.V1.Infrastructure
{
    [Table("example_entities")]
    public class DatabaseEntity
    {
        [Column("id")] public int Id { get; set; }

        [Column("created_at")] public DateTime CreatedAt { get; set; }

    }
}

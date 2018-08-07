using System;
using System.ComponentModel.DataAnnotations;

namespace Repository.Entities
{
    public class EntityBase
    {
        [Key]
        private Guid Id { get; set; }
    }
}
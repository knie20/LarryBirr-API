using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    [Table("test_class")]
    public class TestClass
    {
        [Key]
        public Guid TestClassId { get; set; }

        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set;}

        [Required(ErrorMessage = "Date is required")]
        public DateTime DateCreated { get; set; }

        
    }
}
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TaxSystem.Domain.Entities
{
    public class CurrentOwners
    {
        [Key]
        public int Id { get; set; }
        public bool IsCurrent { get; set; } = true;
        public string Name { get; set; }
        public string Phone { get; set; }
        public int PropertyOwnerId { get; set; }
        [ForeignKey(nameof(PropertyOwnerId))]
        public PropertyInfo Property { get; set; }
    }
}
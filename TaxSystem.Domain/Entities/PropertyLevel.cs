using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TaxSystem.Domain.Entities
{
    public class PropertyLevel
    {
        [Key]
        public int Id { get; set; }
        public string LevelName { get; set; }
    }
}

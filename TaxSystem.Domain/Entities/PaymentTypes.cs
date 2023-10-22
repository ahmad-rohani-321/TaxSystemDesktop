using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TaxSystem.Domain.Entities
{
    public class PaymentPeriods
    {
        [Key]
        public int Id { get; set; }
        public string TypeName { get; set; }
    }
}

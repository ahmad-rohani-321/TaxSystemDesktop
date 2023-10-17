using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq.Expressions;

namespace TaxSystem.Domain.Entities
{
    public class PropertyInfo
    {
        [Key]
        public int Id { get; set; }
        public string Location { get; set; }
        public string Longtitude { get; set; }
        public string Lantitude { get; set; }
        public string West { get; set; }
        public string East { get; set; }
        public string South { get; set; }
        public string North { get; set; }
        public string District { get; set; }
        public string Parcel { get; set; }
        public string Block { get; set; }
        public int PropertyOwnerId { get; set; }
        [ForeignKey(nameof(PropertyOwnerId))]
        public Owners Owner { get; set; }
        public int PaymentTypeId { get; set; }
        [ForeignKey(nameof(PaymentTypeId))]
        public PaymentTypes PaymentType { get; set; }
    }
}

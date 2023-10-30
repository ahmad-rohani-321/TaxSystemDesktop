
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaxSystem.Domain.Entities
{
    public class Owners
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FatherName { get; set; }
        public string GrandFatherName { get; set; }
        public string NationalID { get; set; }
        public string PageNo { get; set; }
        public string JuldNo { get; set; }
        public bool IsDeleted { get; set; } = false;
    }
}
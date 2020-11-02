using System.ComponentModel.DataAnnotations;

namespace ERP.Domain
{
    public class BaseEntity
    {
        [Key]
        public int Id { get; set; }
    }
}

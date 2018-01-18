using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NationBuilder.Models
{
    [Table("Nations")]
    public class Nation
    {
        [Key]
        public int Id { get; set; }
        public int Capital { get; set; }
        public int Population { get; set; }
        public int Stability { get; set; }
        public virtual ApplicationUser User { get; set; }
    }
}
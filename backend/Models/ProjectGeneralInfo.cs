using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsentCode.Models
{
    public class ProjectGeneralInfo
    {
        [Key]
        public Guid Id { get; set; }

        public required string Year { get; set; }

        public required string Status { get; set; }

        public required string Code { get; set; }

        public required string Name { get; set; }

        public required string Stage { get; set; }

        public required float Priority { get; set; }
    }
}

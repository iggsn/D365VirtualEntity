using System;
using System.ComponentModel.DataAnnotations;

namespace D365ODataService.Models
{
    public class Complaint
    {
        /// <summary>
        /// Primary key of an complaint
        /// </summary>
        [Key]
        public Guid Id { get; set; }

        [Required]
        public string Subject { get; set; }

        [Required]
        public string AccountNumber { get; set; }

        public string Description { get; set; }
    }
}
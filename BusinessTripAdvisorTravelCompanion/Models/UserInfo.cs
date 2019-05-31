using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace BusinessTripAdvisorTravelCompanion.Models
{
    public class UserInfo
    {
        [Required]
        [Key]
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public DateTime BirthDate { get; set; }

        [Required]
        [StringLength(128)]
        public string AspNetUserId { get; set; }
        public ApplicationUser AspNetUser { get; set; }
    }
}
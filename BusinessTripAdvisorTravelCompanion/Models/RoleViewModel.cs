using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace BusinessTripAdvisorTravelCompanion.Models
{
    public class RoleViewModel
    {
        [Required]
        public string Name { get; set; }
    }
}
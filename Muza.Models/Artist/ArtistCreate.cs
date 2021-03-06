using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Muza.Models.Artist
{
    public class ArtistCreate
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [MinLength(2, ErrorMessage = "{0} must be at least {1} characters long.")]
        [MaxLength(100, ErrorMessage = "{0} must contain no more than {1} characters.")]
        public string Name { get; set; }
        [Required]
        public string Genre { get; set; }
        [Required]
        public string YearCreated { get; set; }
        [Required]
        [MaxLength(9999, ErrorMessage = "{0} must contain no more than {1} characters.")]
        public string Description { get; set; }
    }
}
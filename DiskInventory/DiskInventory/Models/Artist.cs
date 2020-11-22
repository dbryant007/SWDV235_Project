using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DiskInventory.Models
{
    public partial class Artist
    {
        public Artist()
        {
            ArtistItem = new HashSet<ArtistItem>();
        }

        public int ArtistId { get; set; }
        
        [Required(ErrorMessage = "Please enter the artist's First Name.")] 
        public string ArtistFname { get; set; }

        //my ArtistLname column in the database is set to allow nulls so cannot add a required statement
        public string ArtistLname { get; set; }
        
        [Required]
        public int ArtistTypeId { get; set; }

        public virtual ArtistType ArtistType { get; set; }
        public virtual ICollection<ArtistItem> ArtistItem { get; set; }
    }
}

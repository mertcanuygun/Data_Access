using Code_First_MusicDb.Model.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_First_MusicDb.Model.Entities.Concrete
{
    public class Album : BaseEntity
    {
        [Required]
        public string Name { get; set; }
        public int TotalTrack { get; set; }
        public DateTime? ReleaseDate { get; set; }

        [ForeignKey("Artist")]
        public int ArtistId { get; set; }
        public Artist Artist { get; set; }

        public virtual List<Song> Songs { get; set; }
    }
}

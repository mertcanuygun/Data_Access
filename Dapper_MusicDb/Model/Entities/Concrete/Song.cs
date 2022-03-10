using Dapper_MusicDb.Model.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dapper_MusicDb.Model.Entities.Concrete
{
    public class Song : BaseEntity
    {
        [Required]
        public string SongName { get; set; }
        public double Length { get; set; }
        public int TrackNo { get; set; }
        public string SongWriter { get; set; }
        public string Genre { get; set; }

        [ForeignKey("Artist")]
        public int? ArtistId { get; set; }
        public Artist Artist { get; set; }

        [ForeignKey("Album")]
        public int AlbumId { get; set; }
        public Album Album { get; set; }

        public virtual List<PlayList_Song> PlayList_Songs { get; set; }
    }
}

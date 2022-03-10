using Code_First_MusicDb.Model.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_First_MusicDb.Model.Entities.Concrete
{
    public class PlayList_Song : BaseEntity
    {
        [ForeignKey("Song")]
        public int SongId { get; set; }
        public Song Song { get; set; }

        [ForeignKey("PlayList")]
        public int PlayListId { get; set; }
        public PlayList PlayList { get; set; }
    }
}

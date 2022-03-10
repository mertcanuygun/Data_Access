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
    public class PlayList : BaseEntity
    {
        [Required]
        public string Name { get; set; }

        [ForeignKey("User")]
        public int UserId { get; set; }
        public User User { get; set; }

        public virtual List<PlayList_Song> PlayList_Songs { get; set; }
    }
}

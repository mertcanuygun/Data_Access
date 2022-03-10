using Dapper_MusicDb.Model.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dapper_MusicDb.Model.Entities.Concrete
{
    public class Artist : BaseEntity
    {
        [Required]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public byte[] Picture { get; set; }

        public virtual List<Song> Songs { get; set; }
        public virtual List<Album> Albums { get; set; }
    }
}

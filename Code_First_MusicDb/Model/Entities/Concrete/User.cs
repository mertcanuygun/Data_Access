using Code_First_MusicDb.Model.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_First_MusicDb.Model.Entities.Concrete
{
    public class User : BaseEntity
    {
        [Required]
        [MinLength(8), MaxLength(50)]
        public string Name { get; set; }

        [Required]
        [MinLength(8), MaxLength(50)]
        public string LastName { get; set; }


        private string _email;
        [Required]
        public string Email { get { return _email; } set { _email = value; } }


        [MinLength(8), MaxLength(20)]
        private string _password;
        [Required]
        public string Password { get => _password; set => _password = value; }

        public virtual List<PlayList> PlayLists { get; set; }
    }
}

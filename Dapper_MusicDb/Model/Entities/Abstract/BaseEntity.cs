using Dapper_MusicDb.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dapper_MusicDb.Model.Entities.Abstract
{
    public abstract class BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }


        private DateTime _createDate = DateTime.Now;
        [Column(TypeName = "datetime2")]
        public DateTime CreateDate { get => _createDate; set => _createDate = value; }

        [Column(TypeName = "datetime2")]
        public DateTime? DeleteDate { get; set; }

        private Status _status;
        public Status Status { get => _status; set { _status = value; } }
    }
}

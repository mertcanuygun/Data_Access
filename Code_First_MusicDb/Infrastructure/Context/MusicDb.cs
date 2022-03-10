using Code_First_MusicDb.Model.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_First_MusicDb.Infrastructure.Context
{
    public class MusicDb : DbContext
    {
        public MusicDb()
        {
            Database.Connection.ConnectionString = @"Server=DESKTOP-6IMC28K;Database=MusicDb;Integrated Security=true";
        }

        public DbSet<Album> Albums { get; set; }
        public DbSet<Artist> Artists { get; set; }
        public DbSet<PlayList> PlayLists { get; set; }
        public DbSet<PlayList_Song> PlayList_Songs { get; set; }
        public DbSet<Song> Songs { get; set; }
        public DbSet<User> Users { get; set; }
    }
}

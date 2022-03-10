using Dapper;
using Dapper_MusicDb.Infrastructure.Repositories.Interface;
using Dapper_MusicDb.Model.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dapper_MusicDb.Infrastructure.Repositories.Concrete
{
    public class SongRepository :  IBaseRepository<Song>
    {
        SqlConnection _connection = new SqlConnection(@"Server= DESKTOP-6IMC28K; Database = MusicDb;Integrated Security=True;");

        public void Create(Song entity)
        {
            entity.Id = _connection.Execute("sp_InsertSong",new {@SongName=entity.SongName, @Length=entity.Length, @TrackNo=entity.TrackNo, @songwriter=entity.SongWriter, @Genre=entity.Genre, @ArtistId=entity.ArtistId, @AlbumId=entity.AlbumId, @CreateDate=DateTime.Now, @Status=1}
            ,commandType:CommandType.StoredProcedure);
        }

        public void Delete(Song entity)
        {
            _connection.Execute("sp_DeleteSong", new { @Id = entity.Id }, commandType: CommandType.StoredProcedure);
        }

        public List<Song> GetAllEntity()
        {
            return _connection.Query<Song>("sp_GetAllSong", commandType: CommandType.StoredProcedure).ToList();
        }

        public Song GetSong(int id)
        {
            return _connection.Query<Song>("sp_FindSong", new { @Id = id } , commandType: CommandType.StoredProcedure).First();
        }

        public void Update(Song entity)
        {
            entity.Id = _connection.Execute("sp_UpdateSong", new {@Id=entity.Id, @SongName = entity.SongName, @Length = entity.Length, @TrackNo = entity.TrackNo, @songwriter = entity.SongWriter, @Genre = entity.Genre, @ArtistId = entity.ArtistId, @AlbumId = entity.AlbumId }
             , commandType: CommandType.StoredProcedure);
        }
    }
}

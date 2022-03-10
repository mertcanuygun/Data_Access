using Dapper_MusicDb.Infrastructure.Repositories.Concrete;
using Dapper_MusicDb.Model.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dapper_MusicDb.UserInterface
{
    public partial class SongUpdatePage : Form
    {
        public SongUpdatePage()
        {
            InitializeComponent();
        }

        SongRepository songRepository = new SongRepository();

        private void btnFind_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtFind.Text);
            Song song = songRepository.GetSong(id);

            txtUpdateName.Text = song.SongName;
            txtUpdateLength.Text = song.Length.ToString();
            txtUpdateTrackNo.Text = song.TrackNo.ToString();
            txtUpdateSongWriter.Text = song.SongWriter;
            txtUpdateGenre.Text = song.Genre;
            txtUpdateArtistId.Text = song.ArtistId.ToString();
            txtUpdateAlbumId.Text = song.AlbumId.ToString();
        }

        private void btnListSongs_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = songRepository.GetAllEntity();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Song song = new Song();

            song.Id = int.Parse(txtFind.Text);
            song.SongName = txtUpdateName.Text;
            song.Length = double.Parse(txtUpdateLength.Text);
            song.TrackNo = int.Parse(txtUpdateTrackNo.Text);
            song.SongWriter = txtUpdateSongWriter.Text;
            song.Genre = txtUpdateGenre.Text;
            song.ArtistId = int.Parse(txtUpdateArtistId.Text);
            song.AlbumId = int.Parse(txtUpdateAlbumId.Text);

            songRepository.Update(song);

            dataGridView1.DataSource = songRepository.GetAllEntity();
        }
    }
}

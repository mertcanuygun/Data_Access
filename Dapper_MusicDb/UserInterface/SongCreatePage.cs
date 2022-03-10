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
    public partial class SongCreatePage : Form
    {
        public SongCreatePage()
        {
            InitializeComponent();
        }
        SongRepository songRepository = new SongRepository();

        private void SongCreatePage_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = songRepository.GetAllEntity();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Song song = new Song();

            song.SongName = txtSongName.Text;
            song.Length = double.Parse(txtLength.Text);
            song.TrackNo = int.Parse(txtTrackNo.Text);
            song.SongWriter = txtSongWriter.Text;
            song.Genre = txtGenre.Text;
            song.ArtistId = int.Parse(txtArtistId.Text);
            song.AlbumId = int.Parse(txtAlbumId.Text);

            songRepository.Create(song);

            dataGridView1.DataSource = songRepository.GetAllEntity();

        }

        
    }
}

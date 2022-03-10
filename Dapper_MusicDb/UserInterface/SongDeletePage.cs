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
    public partial class SongDeletePage : Form
    {
        public SongDeletePage()
        {
            InitializeComponent();
        }

        SongRepository songRepository = new SongRepository();

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtDeleteSong.Text);
            Song song = songRepository.GetSong(id);
            songRepository.Delete(song);

            dataGridView1.DataSource = songRepository.GetAllEntity();
        }
    }
}

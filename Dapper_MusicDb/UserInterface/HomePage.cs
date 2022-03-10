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
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {

        }

        void ChildForm(Form _childForm)
        {
            this.Width = _childForm.Width;
            this.Height = _childForm.Height;

            bool condition = false;

            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Text == _childForm.Text)
                {
                    condition = true;
                    frm.Activate();
                }
                else
                {
                    frm.Close();
                }

            }
            if (condition == false)
            {
                _childForm.MdiParent = this;
                _childForm.Show();
            }
        }

        private void songPageCreateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm(new SongCreatePage());
        }

        private void songPageUpdateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm(new SongUpdatePage());
        }

        private void songPageDeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm(new SongDeletePage());
        }
    }
}

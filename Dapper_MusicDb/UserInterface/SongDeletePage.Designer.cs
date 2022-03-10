namespace Dapper_MusicDb.UserInterface
{
    partial class SongDeletePage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpDeleteSong = new System.Windows.Forms.GroupBox();
            this.txtDeleteSong = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.grpDeleteSong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // grpDeleteSong
            // 
            this.grpDeleteSong.Controls.Add(this.btnDelete);
            this.grpDeleteSong.Controls.Add(this.txtDeleteSong);
            this.grpDeleteSong.Controls.Add(this.label8);
            this.grpDeleteSong.Location = new System.Drawing.Point(12, 12);
            this.grpDeleteSong.Name = "grpDeleteSong";
            this.grpDeleteSong.Size = new System.Drawing.Size(293, 202);
            this.grpDeleteSong.TabIndex = 7;
            this.grpDeleteSong.TabStop = false;
            this.grpDeleteSong.Text = "Delete";
            // 
            // txtDeleteSong
            // 
            this.txtDeleteSong.Location = new System.Drawing.Point(133, 48);
            this.txtDeleteSong.Name = "txtDeleteSong";
            this.txtDeleteSong.Size = new System.Drawing.Size(126, 31);
            this.txtDeleteSong.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(32, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 25);
            this.label8.TabIndex = 6;
            this.label8.Text = "Song Id";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(165, 108);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(94, 46);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 220);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1125, 377);
            this.dataGridView1.TabIndex = 8;
            // 
            // SongDeletePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1267, 624);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.grpDeleteSong);
            this.Name = "SongDeletePage";
            this.Text = "SongDeletePage";
            this.grpDeleteSong.ResumeLayout(false);
            this.grpDeleteSong.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDeleteSong;
        private System.Windows.Forms.TextBox txtDeleteSong;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
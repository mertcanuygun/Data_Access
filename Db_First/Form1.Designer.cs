namespace Db_First
{
    partial class Form1
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
            this.btn_select = new System.Windows.Forms.Button();
            this.btn_select2 = new System.Windows.Forms.Button();
            this.btn_where = new System.Windows.Forms.Button();
            this.btn_first = new System.Windows.Forms.Button();
            this.btn_firstordefault = new System.Windows.Forms.Button();
            this.btn_Find = new System.Windows.Forms.Button();
            this.btn_take2 = new System.Windows.Forms.Button();
            this.btn_take = new System.Windows.Forms.Button();
            this.btn_contains = new System.Windows.Forms.Button();
            this.btn_sum = new System.Windows.Forms.Button();
            this.btn_toList = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_startswith = new System.Windows.Forms.Button();
            this.btn_endswith = new System.Windows.Forms.Button();
            this.btn_any = new System.Windows.Forms.Button();
            this.btn_count = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_select
            // 
            this.btn_select.Location = new System.Drawing.Point(210, 430);
            this.btn_select.Name = "btn_select";
            this.btn_select.Size = new System.Drawing.Size(158, 56);
            this.btn_select.TabIndex = 5;
            this.btn_select.Text = "1.Select()";
            this.btn_select.UseVisualStyleBackColor = true;
            this.btn_select.Click += new System.EventHandler(this.btn_select_Click_1);
            // 
            // btn_select2
            // 
            this.btn_select2.Location = new System.Drawing.Point(374, 430);
            this.btn_select2.Name = "btn_select2";
            this.btn_select2.Size = new System.Drawing.Size(158, 56);
            this.btn_select2.TabIndex = 6;
            this.btn_select2.Text = "2. Select()";
            this.btn_select2.UseVisualStyleBackColor = true;
            this.btn_select2.Click += new System.EventHandler(this.btn_select2_Click);
            // 
            // btn_where
            // 
            this.btn_where.Location = new System.Drawing.Point(538, 430);
            this.btn_where.Name = "btn_where";
            this.btn_where.Size = new System.Drawing.Size(158, 56);
            this.btn_where.TabIndex = 7;
            this.btn_where.Text = "Where()";
            this.btn_where.UseVisualStyleBackColor = true;
            this.btn_where.Click += new System.EventHandler(this.btn_where_Click);
            // 
            // btn_first
            // 
            this.btn_first.Location = new System.Drawing.Point(702, 430);
            this.btn_first.Name = "btn_first";
            this.btn_first.Size = new System.Drawing.Size(158, 56);
            this.btn_first.TabIndex = 8;
            this.btn_first.Text = "First()";
            this.btn_first.UseVisualStyleBackColor = true;
            this.btn_first.Click += new System.EventHandler(this.btn_first_Click);
            // 
            // btn_firstordefault
            // 
            this.btn_firstordefault.Location = new System.Drawing.Point(866, 430);
            this.btn_firstordefault.Name = "btn_firstordefault";
            this.btn_firstordefault.Size = new System.Drawing.Size(175, 56);
            this.btn_firstordefault.TabIndex = 9;
            this.btn_firstordefault.Text = "FirstOrDefault()";
            this.btn_firstordefault.UseVisualStyleBackColor = true;
            this.btn_firstordefault.Click += new System.EventHandler(this.btn_firstordefault_Click);
            // 
            // btn_Find
            // 
            this.btn_Find.Location = new System.Drawing.Point(1047, 430);
            this.btn_Find.Name = "btn_Find";
            this.btn_Find.Size = new System.Drawing.Size(158, 56);
            this.btn_Find.TabIndex = 10;
            this.btn_Find.Text = "Find()";
            this.btn_Find.UseVisualStyleBackColor = true;
            this.btn_Find.Click += new System.EventHandler(this.btn_Find_Click);
            // 
            // btn_take2
            // 
            this.btn_take2.Location = new System.Drawing.Point(210, 492);
            this.btn_take2.Name = "btn_take2";
            this.btn_take2.Size = new System.Drawing.Size(158, 56);
            this.btn_take2.TabIndex = 11;
            this.btn_take2.Text = "2. Take()";
            this.btn_take2.UseVisualStyleBackColor = true;
            this.btn_take2.Click += new System.EventHandler(this.btn_take2_Click);
            // 
            // btn_take
            // 
            this.btn_take.Location = new System.Drawing.Point(46, 492);
            this.btn_take.Name = "btn_take";
            this.btn_take.Size = new System.Drawing.Size(158, 56);
            this.btn_take.TabIndex = 12;
            this.btn_take.Text = "1. Take()";
            this.btn_take.UseVisualStyleBackColor = true;
            this.btn_take.Click += new System.EventHandler(this.btn_take_Click);
            // 
            // btn_contains
            // 
            this.btn_contains.Location = new System.Drawing.Point(374, 492);
            this.btn_contains.Name = "btn_contains";
            this.btn_contains.Size = new System.Drawing.Size(158, 56);
            this.btn_contains.TabIndex = 13;
            this.btn_contains.Text = "Contains()";
            this.btn_contains.UseVisualStyleBackColor = true;
            this.btn_contains.Click += new System.EventHandler(this.btn_contains_Click);
            // 
            // btn_sum
            // 
            this.btn_sum.Location = new System.Drawing.Point(46, 554);
            this.btn_sum.Name = "btn_sum";
            this.btn_sum.Size = new System.Drawing.Size(158, 56);
            this.btn_sum.TabIndex = 14;
            this.btn_sum.Text = "Sum()";
            this.btn_sum.UseVisualStyleBackColor = true;
            this.btn_sum.Click += new System.EventHandler(this.btn_sum_Click);
            // 
            // btn_toList
            // 
            this.btn_toList.Location = new System.Drawing.Point(46, 430);
            this.btn_toList.Name = "btn_toList";
            this.btn_toList.Size = new System.Drawing.Size(158, 56);
            this.btn_toList.TabIndex = 4;
            this.btn_toList.Text = "ToList()";
            this.btn_toList.UseVisualStyleBackColor = true;
            this.btn_toList.Click += new System.EventHandler(this.btn_toList_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(46, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1213, 398);
            this.dataGridView1.TabIndex = 3;
            // 
            // btn_startswith
            // 
            this.btn_startswith.Location = new System.Drawing.Point(538, 492);
            this.btn_startswith.Name = "btn_startswith";
            this.btn_startswith.Size = new System.Drawing.Size(158, 56);
            this.btn_startswith.TabIndex = 14;
            this.btn_startswith.Text = "StartsWith()";
            this.btn_startswith.UseVisualStyleBackColor = true;
            this.btn_startswith.Click += new System.EventHandler(this.btn_startswith_Click);
            // 
            // btn_endswith
            // 
            this.btn_endswith.Location = new System.Drawing.Point(702, 492);
            this.btn_endswith.Name = "btn_endswith";
            this.btn_endswith.Size = new System.Drawing.Size(158, 56);
            this.btn_endswith.TabIndex = 14;
            this.btn_endswith.Text = "EndsWith()";
            this.btn_endswith.UseVisualStyleBackColor = true;
            this.btn_endswith.Click += new System.EventHandler(this.btn_endswith_Click);
            // 
            // btn_any
            // 
            this.btn_any.Location = new System.Drawing.Point(866, 492);
            this.btn_any.Name = "btn_any";
            this.btn_any.Size = new System.Drawing.Size(175, 56);
            this.btn_any.TabIndex = 14;
            this.btn_any.Text = "Any()";
            this.btn_any.UseVisualStyleBackColor = true;
            this.btn_any.Click += new System.EventHandler(this.btn_any_Click);
            // 
            // btn_count
            // 
            this.btn_count.Location = new System.Drawing.Point(1047, 492);
            this.btn_count.Name = "btn_count";
            this.btn_count.Size = new System.Drawing.Size(158, 56);
            this.btn_count.TabIndex = 14;
            this.btn_count.Text = "Count()";
            this.btn_count.UseVisualStyleBackColor = true;
            this.btn_count.Click += new System.EventHandler(this.btn_count_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1382, 719);
            this.Controls.Add(this.btn_select);
            this.Controls.Add(this.btn_select2);
            this.Controls.Add(this.btn_where);
            this.Controls.Add(this.btn_first);
            this.Controls.Add(this.btn_firstordefault);
            this.Controls.Add(this.btn_Find);
            this.Controls.Add(this.btn_take2);
            this.Controls.Add(this.btn_take);
            this.Controls.Add(this.btn_contains);
            this.Controls.Add(this.btn_startswith);
            this.Controls.Add(this.btn_endswith);
            this.Controls.Add(this.btn_any);
            this.Controls.Add(this.btn_count);
            this.Controls.Add(this.btn_sum);
            this.Controls.Add(this.btn_toList);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_select;
        private System.Windows.Forms.Button btn_select2;
        private System.Windows.Forms.Button btn_where;
        private System.Windows.Forms.Button btn_first;
        private System.Windows.Forms.Button btn_firstordefault;
        private System.Windows.Forms.Button btn_Find;
        private System.Windows.Forms.Button btn_take2;
        private System.Windows.Forms.Button btn_take;
        private System.Windows.Forms.Button btn_contains;
        private System.Windows.Forms.Button btn_sum;
        private System.Windows.Forms.Button btn_toList;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_startswith;
        private System.Windows.Forms.Button btn_endswith;
        private System.Windows.Forms.Button btn_any;
        private System.Windows.Forms.Button btn_count;
    }
}


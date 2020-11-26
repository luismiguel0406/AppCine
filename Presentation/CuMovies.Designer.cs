namespace Presentation
{
    partial class CuMovies
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CuMovies));
            this.sideMoviePanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtGenres = new System.Windows.Forms.TextBox();
            this.rtActors = new System.Windows.Forms.RichTextBox();
            this.pbMovie = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.PanelMovie = new System.Windows.Forms.Panel();
            this.dgvMoviePanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvMovies = new System.Windows.Forms.DataGridView();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.timerMovie = new System.Windows.Forms.Timer(this.components);
            this.btnEdit = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btnToggle = new System.Windows.Forms.Button();
            this.dtpReleaseDate = new System.Windows.Forms.DateTimePicker();
            this.sideMoviePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMovie)).BeginInit();
            this.PanelMovie.SuspendLayout();
            this.dgvMoviePanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // sideMoviePanel
            // 
            this.sideMoviePanel.Controls.Add(this.dtpReleaseDate);
            this.sideMoviePanel.Controls.Add(this.btnSave);
            this.sideMoviePanel.Controls.Add(this.btnCancel);
            this.sideMoviePanel.Controls.Add(this.button2);
            this.sideMoviePanel.Controls.Add(this.pbMovie);
            this.sideMoviePanel.Controls.Add(this.rtActors);
            this.sideMoviePanel.Controls.Add(this.txtGenres);
            this.sideMoviePanel.Controls.Add(this.txtTitle);
            this.sideMoviePanel.Controls.Add(this.label7);
            this.sideMoviePanel.Controls.Add(this.label6);
            this.sideMoviePanel.Controls.Add(this.label5);
            this.sideMoviePanel.Controls.Add(this.label4);
            this.sideMoviePanel.Controls.Add(this.label3);
            this.sideMoviePanel.Controls.Add(this.label2);
            this.sideMoviePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sideMoviePanel.Location = new System.Drawing.Point(0, 0);
            this.sideMoviePanel.Name = "sideMoviePanel";
            this.sideMoviePanel.Size = new System.Drawing.Size(183, 540);
            this.sideMoviePanel.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Movies";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Title";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Genres";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Release date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 238);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "Photo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 375);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 17);
            this.label7.TabIndex = 2;
            this.label7.Text = "Actors";
            // 
            // txtTitle
            // 
            this.txtTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.txtTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtTitle.Location = new System.Drawing.Point(6, 71);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(139, 23);
            this.txtTitle.TabIndex = 3;
            // 
            // txtGenres
            // 
            this.txtGenres.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.txtGenres.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtGenres.Location = new System.Drawing.Point(6, 134);
            this.txtGenres.Name = "txtGenres";
            this.txtGenres.Size = new System.Drawing.Size(139, 23);
            this.txtGenres.TabIndex = 6;
            // 
            // rtActors
            // 
            this.rtActors.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.rtActors.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.rtActors.Location = new System.Drawing.Point(6, 395);
            this.rtActors.Name = "rtActors";
            this.rtActors.Size = new System.Drawing.Size(161, 73);
            this.rtActors.TabIndex = 7;
            this.rtActors.Text = "";
            // 
            // pbMovie
            // 
            this.pbMovie.Location = new System.Drawing.Point(6, 258);
            this.pbMovie.Name = "pbMovie";
            this.pbMovie.Size = new System.Drawing.Size(100, 62);
            this.pbMovie.TabIndex = 8;
            this.pbMovie.TabStop = false;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(6, 326);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 27);
            this.button2.TabIndex = 9;
            this.button2.Text = "Open";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // PanelMovie
            // 
            this.PanelMovie.Controls.Add(this.panel2);
            this.PanelMovie.Controls.Add(this.label8);
            this.PanelMovie.Controls.Add(this.pictureBox2);
            this.PanelMovie.Controls.Add(this.dgvMoviePanel);
            this.PanelMovie.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelMovie.Location = new System.Drawing.Point(183, 0);
            this.PanelMovie.Name = "PanelMovie";
            this.PanelMovie.Size = new System.Drawing.Size(739, 540);
            this.PanelMovie.TabIndex = 11;
            // 
            // dgvMoviePanel
            // 
            this.dgvMoviePanel.Controls.Add(this.dgvMovies);
            this.dgvMoviePanel.Controls.Add(this.panel1);
            this.dgvMoviePanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvMoviePanel.Location = new System.Drawing.Point(0, 403);
            this.dgvMoviePanel.Name = "dgvMoviePanel";
            this.dgvMoviePanel.Size = new System.Drawing.Size(739, 137);
            this.dgvMoviePanel.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnToggle);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(739, 29);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Movies";
            // 
            // dgvMovies
            // 
            this.dgvMovies.AllowUserToAddRows = false;
            this.dgvMovies.AllowUserToDeleteRows = false;
            this.dgvMovies.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.dgvMovies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMovies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMovies.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvMovies.Location = new System.Drawing.Point(0, 29);
            this.dgvMovies.Name = "dgvMovies";
            this.dgvMovies.ReadOnly = true;
            this.dgvMovies.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMovies.Size = new System.Drawing.Size(739, 108);
            this.dgvMovies.TabIndex = 1;
            this.dgvMovies.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMovies_CellClick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(739, 403);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // btnCancel
            // 
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.Location = new System.Drawing.Point(95, 481);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(72, 39);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Location = new System.Drawing.Point(6, 481);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(69, 39);
            this.btnSave.TabIndex = 12;
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 11);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 17);
            this.label9.TabIndex = 10;
            this.label9.Text = "Search:";
            // 
            // txtSearch
            // 
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Location = new System.Drawing.Point(67, 13);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(168, 16);
            this.txtSearch.TabIndex = 11;
            this.txtSearch.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.txtSearch);
            this.panel2.Controls.Add(this.btnEdit);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 368);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(739, 35);
            this.panel2.TabIndex = 12;
            // 
            // timerMovie
            // 
            this.timerMovie.Interval = 30;
            this.timerMovie.Tick += new System.EventHandler(this.timerMovie_Tick);
            // 
            // btnEdit
            // 
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.Location = new System.Drawing.Point(483, 5);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(72, 27);
            this.btnEdit.TabIndex = 13;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // button5
            // 
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.Location = new System.Drawing.Point(602, 6);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(72, 27);
            this.button5.TabIndex = 14;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(63, 45);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 23);
            this.label8.TabIndex = 10;
            this.label8.Text = "Title";
            // 
            // btnToggle
            // 
            this.btnToggle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToggle.Image = ((System.Drawing.Image)(resources.GetObject("btnToggle.Image")));
            this.btnToggle.Location = new System.Drawing.Point(696, 0);
            this.btnToggle.Name = "btnToggle";
            this.btnToggle.Size = new System.Drawing.Size(40, 27);
            this.btnToggle.TabIndex = 13;
            this.btnToggle.UseVisualStyleBackColor = true;
            // 
            // dtpReleaseDate
            // 
            this.dtpReleaseDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpReleaseDate.Location = new System.Drawing.Point(6, 195);
            this.dtpReleaseDate.Name = "dtpReleaseDate";
            this.dtpReleaseDate.Size = new System.Drawing.Size(139, 23);
            this.dtpReleaseDate.TabIndex = 13;
            // 
            // CuMovies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.Controls.Add(this.PanelMovie);
            this.Controls.Add(this.sideMoviePanel);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CuMovies";
            this.Size = new System.Drawing.Size(922, 540);
            this.Load += new System.EventHandler(this.CuMovies_Load);
            this.sideMoviePanel.ResumeLayout(false);
            this.sideMoviePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMovie)).EndInit();
            this.PanelMovie.ResumeLayout(false);
            this.PanelMovie.PerformLayout();
            this.dgvMoviePanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel sideMoviePanel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pbMovie;
        private System.Windows.Forms.RichTextBox rtActors;
        private System.Windows.Forms.TextBox txtGenres;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel PanelMovie;
        private System.Windows.Forms.Panel dgvMoviePanel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridView dgvMovies;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Timer timerMovie;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnToggle;
        private System.Windows.Forms.DateTimePicker dtpReleaseDate;
    }
}

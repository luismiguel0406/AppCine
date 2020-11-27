namespace Presentation
{
    partial class CuActors
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CuActors));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvPanelActors = new System.Windows.Forms.Panel();
            this.topPanelDgvActors = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.cbGenre = new System.Windows.Forms.ComboBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvActors = new System.Windows.Forms.DataGridView();
            this.leftSidePanelActor = new System.Windows.Forms.Panel();
            this.rtMovies = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.pbActor = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.dtpBirthday = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNameActor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnShowMovies = new System.Windows.Forms.Button();
            this.listBMovies = new System.Windows.Forms.ListBox();
            this.lbActor = new System.Windows.Forms.Label();
            this.pbMainActor = new System.Windows.Forms.PictureBox();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.dgvPanelActors.SuspendLayout();
            this.topPanelDgvActors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActors)).BeginInit();
            this.leftSidePanelActor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbActor)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMainActor)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPanelActors
            // 
            this.dgvPanelActors.Controls.Add(this.topPanelDgvActors);
            this.dgvPanelActors.Controls.Add(this.dgvActors);
            this.dgvPanelActors.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvPanelActors.Location = new System.Drawing.Point(0, 333);
            this.dgvPanelActors.Margin = new System.Windows.Forms.Padding(4);
            this.dgvPanelActors.Name = "dgvPanelActors";
            this.dgvPanelActors.Size = new System.Drawing.Size(922, 207);
            this.dgvPanelActors.TabIndex = 0;
            // 
            // topPanelDgvActors
            // 
            this.topPanelDgvActors.Controls.Add(this.btnAdd);
            this.topPanelDgvActors.Controls.Add(this.label8);
            this.topPanelDgvActors.Controls.Add(this.cbGenre);
            this.topPanelDgvActors.Controls.Add(this.btnEdit);
            this.topPanelDgvActors.Controls.Add(this.btnDelete);
            this.topPanelDgvActors.Controls.Add(this.txtSearch);
            this.topPanelDgvActors.Controls.Add(this.label9);
            this.topPanelDgvActors.Controls.Add(this.label1);
            this.topPanelDgvActors.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanelDgvActors.Location = new System.Drawing.Point(0, 0);
            this.topPanelDgvActors.Margin = new System.Windows.Forms.Padding(4);
            this.topPanelDgvActors.Name = "topPanelDgvActors";
            this.topPanelDgvActors.Size = new System.Drawing.Size(922, 35);
            this.topPanelDgvActors.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.Location = new System.Drawing.Point(706, 0);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(72, 35);
            this.btnAdd.TabIndex = 24;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(375, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 17);
            this.label8.TabIndex = 23;
            this.label8.Text = "Genre:";
            // 
            // cbGenre
            // 
            this.cbGenre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.cbGenre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbGenre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cbGenre.FormattingEnabled = true;
            this.cbGenre.Location = new System.Drawing.Point(445, 4);
            this.cbGenre.Name = "cbGenre";
            this.cbGenre.Size = new System.Drawing.Size(128, 25);
            this.cbGenre.TabIndex = 22;
            // 
            // btnEdit
            // 
            this.btnEdit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.Location = new System.Drawing.Point(778, 0);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(72, 35);
            this.btnEdit.TabIndex = 20;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Location = new System.Drawing.Point(850, 0);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(72, 35);
            this.btnDelete.TabIndex = 21;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtSearch.Location = new System.Drawing.Point(159, 8);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(168, 23);
            this.txtSearch.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(98, 8);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 17);
            this.label9.TabIndex = 18;
            this.label9.Text = "Search:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Actors";
            // 
            // dgvActors
            // 
            this.dgvActors.AllowUserToAddRows = false;
            this.dgvActors.AllowUserToDeleteRows = false;
            this.dgvActors.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvActors.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.dgvActors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvActors.EnableHeadersVisualStyles = false;
            this.dgvActors.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvActors.Location = new System.Drawing.Point(9, 62);
            this.dgvActors.Margin = new System.Windows.Forms.Padding(4);
            this.dgvActors.Name = "dgvActors";
            this.dgvActors.ReadOnly = true;
            this.dgvActors.RowHeadersVisible = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvActors.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvActors.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvActors.Size = new System.Drawing.Size(985, 141);
            this.dgvActors.TabIndex = 2;
            this.dgvActors.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvActors_CellClick);
            // 
            // leftSidePanelActor
            // 
            this.leftSidePanelActor.Controls.Add(this.rtMovies);
            this.leftSidePanelActor.Controls.Add(this.label6);
            this.leftSidePanelActor.Controls.Add(this.btnSave);
            this.leftSidePanelActor.Controls.Add(this.btnCancel);
            this.leftSidePanelActor.Controls.Add(this.btnOpen);
            this.leftSidePanelActor.Controls.Add(this.pbActor);
            this.leftSidePanelActor.Controls.Add(this.label5);
            this.leftSidePanelActor.Controls.Add(this.rbFemale);
            this.leftSidePanelActor.Controls.Add(this.rbMale);
            this.leftSidePanelActor.Controls.Add(this.dtpBirthday);
            this.leftSidePanelActor.Controls.Add(this.label3);
            this.leftSidePanelActor.Controls.Add(this.txtNameActor);
            this.leftSidePanelActor.Controls.Add(this.label2);
            this.leftSidePanelActor.Controls.Add(this.label4);
            this.leftSidePanelActor.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftSidePanelActor.Location = new System.Drawing.Point(0, 0);
            this.leftSidePanelActor.Name = "leftSidePanelActor";
            this.leftSidePanelActor.Size = new System.Drawing.Size(406, 333);
            this.leftSidePanelActor.TabIndex = 2;
            // 
            // rtMovies
            // 
            this.rtMovies.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.rtMovies.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.rtMovies.Location = new System.Drawing.Point(20, 251);
            this.rtMovies.Name = "rtMovies";
            this.rtMovies.Size = new System.Drawing.Size(193, 73);
            this.rtMovies.TabIndex = 23;
            this.rtMovies.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 231);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 17);
            this.label6.TabIndex = 22;
            this.label6.Text = "Movies";
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Location = new System.Drawing.Point(233, 229);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(69, 39);
            this.btnSave.TabIndex = 21;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.Location = new System.Drawing.Point(322, 229);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(72, 39);
            this.btnCancel.TabIndex = 20;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpen.Location = new System.Drawing.Point(268, 156);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(100, 27);
            this.btnOpen.TabIndex = 19;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // pbActor
            // 
            this.pbActor.Location = new System.Drawing.Point(268, 35);
            this.pbActor.Name = "pbActor";
            this.pbActor.Size = new System.Drawing.Size(100, 101);
            this.pbActor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbActor.TabIndex = 18;
            this.pbActor.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(296, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 17);
            this.label5.TabIndex = 17;
            this.label5.Text = "Photo";
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(23, 195);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(73, 21);
            this.rbFemale.TabIndex = 16;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Location = new System.Drawing.Point(23, 168);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(57, 21);
            this.rbMale.TabIndex = 15;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // dtpBirthday
            // 
            this.dtpBirthday.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBirthday.Location = new System.Drawing.Point(20, 96);
            this.dtpBirthday.Name = "dtpBirthday";
            this.dtpBirthday.Size = new System.Drawing.Size(193, 23);
            this.dtpBirthday.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Gender";
            // 
            // txtNameActor
            // 
            this.txtNameActor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.txtNameActor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtNameActor.Location = new System.Drawing.Point(20, 35);
            this.txtNameActor.Name = "txtNameActor";
            this.txtNameActor.Size = new System.Drawing.Size(193, 23);
            this.txtNameActor.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Birthday";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Name";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnShowMovies);
            this.panel1.Controls.Add(this.listBMovies);
            this.panel1.Controls.Add(this.lbActor);
            this.panel1.Controls.Add(this.pbMainActor);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(406, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(516, 333);
            this.panel1.TabIndex = 3;
            // 
            // btnShowMovies
            // 
            this.btnShowMovies.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowMovies.Location = new System.Drawing.Point(28, 282);
            this.btnShowMovies.Name = "btnShowMovies";
            this.btnShowMovies.Size = new System.Drawing.Size(108, 27);
            this.btnShowMovies.TabIndex = 24;
            this.btnShowMovies.Text = "Show Movies";
            this.btnShowMovies.UseVisualStyleBackColor = true;
            this.btnShowMovies.MouseLeave += new System.EventHandler(this.btnShowMovies_MouseLeave);
            this.btnShowMovies.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnShowMovies_MouseMove);
            // 
            // listBMovies
            // 
            this.listBMovies.BackColor = System.Drawing.Color.Gold;
            this.listBMovies.FormattingEnabled = true;
            this.listBMovies.ItemHeight = 17;
            this.listBMovies.Location = new System.Drawing.Point(330, 220);
            this.listBMovies.Name = "listBMovies";
            this.listBMovies.Size = new System.Drawing.Size(169, 89);
            this.listBMovies.TabIndex = 12;
            // 
            // lbActor
            // 
            this.lbActor.AutoSize = true;
            this.lbActor.BackColor = System.Drawing.Color.Transparent;
            this.lbActor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbActor.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbActor.Location = new System.Drawing.Point(23, 231);
            this.lbActor.Name = "lbActor";
            this.lbActor.Size = new System.Drawing.Size(56, 28);
            this.lbActor.TabIndex = 11;
            this.lbActor.Text = "Title";
            // 
            // pbMainActor
            // 
            this.pbMainActor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbMainActor.Location = new System.Drawing.Point(0, 0);
            this.pbMainActor.Name = "pbMainActor";
            this.pbMainActor.Size = new System.Drawing.Size(516, 333);
            this.pbMainActor.TabIndex = 0;
            this.pbMainActor.TabStop = false;
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog1";
            // 
            // CuActors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.leftSidePanelActor);
            this.Controls.Add(this.dgvPanelActors);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CuActors";
            this.Size = new System.Drawing.Size(922, 540);
            this.Load += new System.EventHandler(this.CuActors_Load);
            this.dgvPanelActors.ResumeLayout(false);
            this.topPanelDgvActors.ResumeLayout(false);
            this.topPanelDgvActors.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActors)).EndInit();
            this.leftSidePanelActor.ResumeLayout(false);
            this.leftSidePanelActor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbActor)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMainActor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel dgvPanelActors;
        private System.Windows.Forms.DataGridView dgvActors;
        private System.Windows.Forms.Panel topPanelDgvActors;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel leftSidePanelActor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNameActor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.DateTimePicker dtpBirthday;
        private System.Windows.Forms.PictureBox pbActor;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbGenre;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbMainActor;
        private System.Windows.Forms.Label lbActor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox rtMovies;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.Button btnShowMovies;
        private System.Windows.Forms.ListBox listBMovies;
    }
}

namespace Presentation
{
    partial class Principal
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.topPanel = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.leftPanel1 = new System.Windows.Forms.Panel();
            this.btnActorMenu = new System.Windows.Forms.Button();
            this.btnMovieMenu = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.pblogo = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cuActors1 = new Presentation.CuActors();
            this.cuMovies1 = new Presentation.CuMovies();
            this.topPanel.SuspendLayout();
            this.leftPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pblogo)).BeginInit();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.topPanel.Controls.Add(this.btnClose);
            this.topPanel.Controls.Add(this.label1);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1030, 31);
            this.topPanel.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(992, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(36, 29);
            this.btnClose.TabIndex = 1;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            this.btnClose.MouseLeave += new System.EventHandler(this.btnClose_MouseLeave);
            this.btnClose.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnClose_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "CineArt";
            // 
            // leftPanel1
            // 
            this.leftPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.leftPanel1.Controls.Add(this.btnActorMenu);
            this.leftPanel1.Controls.Add(this.btnMovieMenu);
            this.leftPanel1.Controls.Add(this.btnHome);
            this.leftPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel1.Location = new System.Drawing.Point(0, 31);
            this.leftPanel1.Name = "leftPanel1";
            this.leftPanel1.Size = new System.Drawing.Size(101, 540);
            this.leftPanel1.TabIndex = 1;
            this.leftPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.leftPanel1_Paint);
            // 
            // btnActorMenu
            // 
            this.btnActorMenu.FlatAppearance.BorderSize = 0;
            this.btnActorMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActorMenu.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActorMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnActorMenu.Image")));
            this.btnActorMenu.Location = new System.Drawing.Point(4, 133);
            this.btnActorMenu.Name = "btnActorMenu";
            this.btnActorMenu.Size = new System.Drawing.Size(91, 33);
            this.btnActorMenu.TabIndex = 2;
            this.btnActorMenu.Text = "Actors";
            this.btnActorMenu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnActorMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnActorMenu.UseVisualStyleBackColor = true;
            this.btnActorMenu.Click += new System.EventHandler(this.btnActorMenu_Click);
            // 
            // btnMovieMenu
            // 
            this.btnMovieMenu.FlatAppearance.BorderSize = 0;
            this.btnMovieMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMovieMenu.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMovieMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnMovieMenu.Image")));
            this.btnMovieMenu.Location = new System.Drawing.Point(4, 74);
            this.btnMovieMenu.Name = "btnMovieMenu";
            this.btnMovieMenu.Size = new System.Drawing.Size(91, 33);
            this.btnMovieMenu.TabIndex = 1;
            this.btnMovieMenu.Text = "Movies";
            this.btnMovieMenu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMovieMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMovieMenu.UseVisualStyleBackColor = true;
            this.btnMovieMenu.Click += new System.EventHandler(this.btnMovieMenu_Click);
            // 
            // btnHome
            // 
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.Location = new System.Drawing.Point(4, 15);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(91, 33);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "Home";
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // pblogo
            // 
            this.pblogo.Image = ((System.Drawing.Image)(resources.GetObject("pblogo.Image")));
            this.pblogo.Location = new System.Drawing.Point(383, 166);
            this.pblogo.Name = "pblogo";
            this.pblogo.Size = new System.Drawing.Size(264, 239);
            this.pblogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pblogo.TabIndex = 4;
            this.pblogo.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(460, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "CineArt";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(452, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "by Luis Del Orbe";
            // 
            // cuActors1
            // 
            this.cuActors1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.cuActors1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cuActors1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuActors1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cuActors1.Location = new System.Drawing.Point(102, 31);
            this.cuActors1.Margin = new System.Windows.Forms.Padding(4);
            this.cuActors1.Name = "cuActors1";
            this.cuActors1.Size = new System.Drawing.Size(922, 540);
            this.cuActors1.TabIndex = 3;
            // 
            // cuMovies1
            // 
            this.cuMovies1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.cuMovies1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuMovies1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cuMovies1.Location = new System.Drawing.Point(102, 31);
            this.cuMovies1.Margin = new System.Windows.Forms.Padding(4);
            this.cuMovies1.Name = "cuMovies1";
            this.cuMovies1.Size = new System.Drawing.Size(922, 540);
            this.cuMovies1.TabIndex = 2;
            this.cuMovies1.Load += new System.EventHandler(this.cuMovies1_Load);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(1030, 571);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pblogo);
            this.Controls.Add(this.cuActors1);
            this.Controls.Add(this.cuMovies1);
            this.Controls.Add(this.leftPanel1);
            this.Controls.Add(this.topPanel);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.leftPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pblogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel leftPanel1;
        private System.Windows.Forms.Button btnHome;
        private CuMovies cuMovies1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMovieMenu;
        private System.Windows.Forms.Button btnActorMenu;
        private CuActors cuActors1;
        private System.Windows.Forms.PictureBox pblogo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}


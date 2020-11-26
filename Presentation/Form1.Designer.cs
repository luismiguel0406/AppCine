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
            this.topPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.leftPanel1 = new System.Windows.Forms.Panel();
            this.panelPrinicipal = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.topPanel.SuspendLayout();
            this.leftPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.Controls.Add(this.label1);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1059, 31);
            this.topPanel.TabIndex = 0;
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
            this.leftPanel1.Controls.Add(this.button1);
            this.leftPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel1.Location = new System.Drawing.Point(0, 31);
            this.leftPanel1.Name = "leftPanel1";
            this.leftPanel1.Size = new System.Drawing.Size(40, 528);
            this.leftPanel1.TabIndex = 1;
            // 
            // panelPrinicipal
            // 
            this.panelPrinicipal.AutoSize = true;
            this.panelPrinicipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPrinicipal.Location = new System.Drawing.Point(40, 31);
            this.panelPrinicipal.Name = "panelPrinicipal";
            this.panelPrinicipal.Size = new System.Drawing.Size(1019, 528);
            this.panelPrinicipal.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(0, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 33);
            this.button1.TabIndex = 0;
            this.button1.Text = "..";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(1059, 559);
            this.Controls.Add(this.panelPrinicipal);
            this.Controls.Add(this.leftPanel1);
            this.Controls.Add(this.topPanel);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.leftPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel leftPanel1;
        private System.Windows.Forms.Panel panelPrinicipal;
        private System.Windows.Forms.Button button1;
    }
}


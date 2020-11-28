using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void cuMovies1_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            btnClose.BackColor = Color.Transparent;
        }

        private void btnClose_MouseMove(object sender, MouseEventArgs e)
        {
            btnClose.BackColor = Color.Red;
        }

        private void leftPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Principal_Load(object sender, EventArgs e)
        {
            cuActors1.Hide();
            cuMovies1.Hide();
        }

        private void btnMovieMenu_Click(object sender, EventArgs e)
        {
            cuActors1.Hide();
            cuActors1.SendToBack();
            cuMovies1.Show();
            cuMovies1.BringToFront();
        }

        private void btnActorMenu_Click(object sender, EventArgs e)
        {
            cuMovies1.Hide();
            cuMovies1.SendToBack();
            cuActors1.Show();
            cuActors1.BringToFront();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            cuActors1.Hide();
            cuMovies1.Hide();
        }
    }
}

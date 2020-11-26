using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess;

namespace Presentation
{
    public partial class CuMovies : UserControl
    {
        int panelwidth;
        bool hidden;
        int idMovie;
        public CuMovies()
        {
            InitializeComponent();
            panelwidth = sideMoviePanel.Width;
            hidden = false;
            
                        
        }
        private bool edit = false;
        MovieDA movie = new MovieDA();
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void CuMovies_Load(object sender, EventArgs e)
        {
            dgvMovies.DataSource = movie.getMovies();
            
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            //busqueda por lo que se escriba
            if (txtSearch.Text != "")
            {
                dgvMovies.CurrentCell = null;
                foreach (DataGridViewRow r in dgvMovies.Rows)
                {
                    r.Visible = false;
                }
                foreach (DataGridViewRow r in dgvMovies.Rows)
                {
                    foreach (DataGridViewCell c in r.Cells)
                    {
                        if ((c.Value.ToString().ToUpper()).IndexOf(txtSearch.Text.ToUpper()) == 0)
                        {
                            r.Visible = true;
                            break;
                        }
                    }
                }
            }


            else
            {
              
                dgvMovies.DataSource = movie.getMovies();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            timerMovie.Start();
        }

        private void timerMovie_Tick(object sender, EventArgs e)
        {
            if (hidden)
            {
                sideMoviePanel.Width = sideMoviePanel.Width + 10;
                if (sideMoviePanel.Width >= panelwidth)
                {
                    timerMovie.Stop();
                    hidden = false;
                    this.Refresh();
                }

            }
            else
            {
                sideMoviePanel.Width = sideMoviePanel.Width - 10; 
                if (sideMoviePanel.Width <= 0)
                {
                    timerMovie.Stop();
                    hidden = true;
                    this.Refresh();
                }
            }
        }

        private void dgvMovies_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idMovie = int.Parse(dgvMovies.CurrentRow.Cells[0].Value.ToString());
            txtTitle.Text = dgvMovies.CurrentRow.Cells[1].Value.ToString();
            txtGenres.Text = dgvMovies.CurrentRow.Cells[2].Value.ToString();
            dtpReleaseDate.Text = dgvMovies.CurrentRow.Cells[3].Value.ToString();

            byte[] fotoempleado = new byte[0];



            rtActors.Text = dgvMovies.CurrentRow.Cells[5].Value.ToString();
        }
    }
}

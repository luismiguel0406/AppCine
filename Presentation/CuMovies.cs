using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess;
using System.IO;
using System.Data.SqlClient;

namespace Presentation
{
    public partial class CuMovies : UserControl
    {
        int panelwidth;
        bool hidden;
        int idMovie;
        //
        int panelheight;
        bool hiddenDgvPanel;

        byte[] file = null;

        public CuMovies()
        {
            InitializeComponent();

            dgvMoviePanel.Height = 29;
            sideMoviePanel.Width = 0;

            panelwidth = 183;
            hidden = true;
            // bottom panel
            panelheight = 108;
            hiddenDgvPanel = true;

            lbtitle.Parent = pictureBox2;
            btnActors.Parent = pictureBox2;
                        
        }
        private bool edit = false;
        MovieDA movie = new MovieDA();

        public void cleanTxt()
        {
            txtTitle.Clear();
            txtGenres.Clear();
            dtpReleaseDate.Value = DateTime.Now;
            pbMovie.Image = null;
            rtActors.Clear();
        }

        private void CuMovies_Load(object sender, EventArgs e)
        {
            dgvMovies.DataSource = movie.getMovies();
            listBactors.Hide();
             
            
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
            edit = true;
            if (txtTitle.Text.Trim().Equals(""))
            {
                MessageBox.Show("Select a row", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (dgvMoviePanel.Height<=79)
                {
                    timerdgv.Start();
                }
            }
            if (sideMoviePanel.Width<=183)
            {
                timerMovie.Start();
            }
           
        }

        private void timerMovie_Tick(object sender, EventArgs e)
        {
            if (hidden)
            {
                sideMoviePanel.Width = sideMoviePanel.Width + 30;
                if (sideMoviePanel.Width >= panelwidth)
                {
                    timerMovie.Stop();
                    hidden = false;  
                    this.Refresh();
                }

            }
            else
            {
                sideMoviePanel.Width = sideMoviePanel.Width - 30; 
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
            edit = true;
            
            idMovie = int.Parse(dgvMovies.CurrentRow.Cells[0].Value.ToString());
            txtTitle.Text = dgvMovies.CurrentRow.Cells[1].Value.ToString();

            lbtitle.Text = dgvMovies.CurrentRow.Cells[1].Value.ToString();
            lbtitle.Text.ToUpper();

            txtGenres.Text = dgvMovies.CurrentRow.Cells[2].Value.ToString();
            dtpReleaseDate.Text = dgvMovies.CurrentRow.Cells[3].Value.ToString();

            //busco la foto en la base de datos
            byte[] PhotoMovie = new byte[0];

            //obtengo la imagen

            MemoryStream MS = new MemoryStream(movie.getPhotoMovie(idMovie, PhotoMovie));
            pbMovie.Image = Bitmap.FromStream(MS);
            pictureBox2.Image = Bitmap.FromStream(MS);
                       

            rtActors.Text = dgvMovies.CurrentRow.Cells[5].Value.ToString();

        }

      

        private void btnCancel_Click(object sender, EventArgs e)
        {
            cleanTxt();
            edit = false;
            timerMovie.Start();
        }

        private void btnToggle_Click(object sender, EventArgs e)
        {
            timerdgv.Start();
        }

        private void timerdgv_Tick(object sender, EventArgs e)
        {
            if (hiddenDgvPanel)
            {
                dgvMoviePanel.Height = dgvMoviePanel.Height + 20;
                if (dgvMoviePanel.Height >= panelheight)
                {
                    timerdgv.Stop();
                    hiddenDgvPanel = false;
                    this.Refresh();
                }

            }
            else
            {
                dgvMoviePanel.Height = dgvMoviePanel.Height - 20;
                if (dgvMoviePanel.Height <= 29)
                {
                    timerdgv.Stop();
                    hiddenDgvPanel = true;
                    this.Refresh();
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (edit==false)
            {
                if (txtTitle.Text.Trim().Equals(""))
                {
                    MessageBox.Show("movie must to have a title");
                    return;
                }
                
              
                movie.addMovie(txtTitle.Text, txtGenres.Text, dtpReleaseDate.Value, file, rtActors.Text);
                MessageBox.Show("Done successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvMovies.DataSource = movie.getMovies();
                cleanTxt();
                timerMovie.Start();
            }
            if (edit)
            {
                if (txtTitle.Text.Trim().Equals(""))
                {
                    MessageBox.Show("movie must to have a title");
                    return;
                }
                //obtengo la foto
                using (MemoryStream ms = new MemoryStream())
                {
                    pbMovie.Image.Save(ms, ImageFormat.Jpeg);
                    file = ms.GetBuffer();
                    
                }

                movie.editMovie(idMovie,txtTitle.Text, txtGenres.Text, dtpReleaseDate.Value, file, rtActors.Text);
                MessageBox.Show("Done successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvMovies.DataSource = movie.getMovies();
                idMovie = 0;
                cleanTxt();
                timerMovie.Start();
            }

            
           
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "JPEG(*.jpg)|*.jpg|bmp(*.bmp)|*.bmp|png(*.png)|*.png";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pbMovie.Image = Image.FromFile(openFileDialog1.FileName);
                

            }

            Stream mystream = openFileDialog1.OpenFile();

            using (MemoryStream ms = new MemoryStream())
            {
                mystream.CopyTo(ms);
                file = ms.ToArray();
            }
        }

     
      
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (idMovie == 0)
            {
                MessageBox.Show("Select a Movie","Message",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }

            DialogResult dialog = MessageBox.Show(" Are you sure?","Message",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if (dialog ==DialogResult.Yes)
            {
                movie.deleteMovie(idMovie);
                dgvMovies.DataSource = movie.getMovies();
                cleanTxt();
            }
            
        }

       

        

        private void cbGenre_MouseMove(object sender, MouseEventArgs e)
        {
            cbGenre.Items.Clear();
            int rows = dgvMovies.RowCount;


            for (int i = 0; i < rows; i++)
            {
                cbGenre.Items.Add(dgvMovies.Rows[i].Cells[2].Value.ToString());
            }
        }

        private void cbGenre_TextChanged(object sender, EventArgs e)
        {
            //busqueda por lo que se escriba
            if (cbGenre.Text != "")
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
                        if ((c.Value.ToString().ToUpper()).IndexOf(cbGenre.Text.ToUpper()) == 0)
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            edit = false;
            cleanTxt();
            if (sideMoviePanel.Width<=183)
            {
                timerMovie.Start();
            }
            
        }

        private void btnDelete_MouseMove(object sender, MouseEventArgs e)
        {
            btnDelete.BackColor = Color.Red;
        }

        private void btnDelete_MouseLeave(object sender, EventArgs e)
        {
            btnDelete.BackColor = Color.Transparent;
        }

        private void btnEdit_MouseMove(object sender, MouseEventArgs e)
        {
            btnEdit.BackColor = Color.Gold;
        }

        private void btnEdit_MouseLeave(object sender, EventArgs e)
        {
            btnEdit.BackColor = Color.Transparent;
        }

        private void btnAdd_MouseMove(object sender, MouseEventArgs e)
        {
            btnAdd.BackColor = Color.Cyan;
        }

        private void btnAdd_MouseLeave(object sender, EventArgs e)
        {
            btnAdd.BackColor = Color.Transparent;
        }

        private void btnCancel_MouseMove(object sender, MouseEventArgs e)
        {
            btnCancel.BackColor = Color.Red;
        }

        private void btnCancel_MouseLeave(object sender, EventArgs e)
        {
            btnCancel.BackColor = Color.Transparent;
        }

        private void btnSave_MouseMove(object sender, MouseEventArgs e)
        {
            btnSave.BackColor = Color.Green;
        }

        private void btnSave_MouseLeave(object sender, EventArgs e)
        {
            btnSave.BackColor = Color.Transparent;
        }

        private void btnActors_MouseMove(object sender, MouseEventArgs e)
        {
            btnActors.BackColor = Color.Gold;
            listBactors.Show();
        }

        private void btnActors_MouseLeave(object sender, EventArgs e)
        {
            btnActors.BackColor = Color.Transparent;
            listBactors.Hide();
        }
    }
}

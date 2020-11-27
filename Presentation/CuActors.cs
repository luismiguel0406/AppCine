using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using DataAccess;

namespace Presentation
{
    public partial class CuActors : UserControl
    {
        int panelwidth;
        bool hidden;
        int idActor;
        
        

        byte[] file = null;
        public CuActors()
        {
            InitializeComponent();
            lbActor.Parent = pbMainActor;
        }
        private bool edit = false;
        ActorDA actors = new ActorDA();

        private void CuActors_Load(object sender, EventArgs e)
        {
            dgvActors.DataSource = actors.getActors();
            listBMovies.Hide();
        }
        public void cleanTxt()
        {
            txtNameActor.Clear();
            
            dtpBirthday.Value = DateTime.Now;
            pbActor.Image = null;
            rtMovies.Clear();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            openFileDialog2.InitialDirectory = "c:\\";
            openFileDialog2.Filter = "JPEG(*.jpg)|*.jpg|bmp(*.bmp)|*.bmp|png(*.png)|*.png";
            openFileDialog2.FilterIndex = 1;
            openFileDialog2.RestoreDirectory = true;

            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                pbActor.Image = Image.FromFile(openFileDialog2.FileName);


            }

            Stream mystream = openFileDialog2.OpenFile();

            using (MemoryStream ms = new MemoryStream())
            {
                mystream.CopyTo(ms);
                file = ms.ToArray();
            }
        }

       
        private void btnShowMovies_MouseMove(object sender, MouseEventArgs e)
        {
            listBMovies.Show();
        }

        private void btnShowMovies_MouseLeave(object sender, EventArgs e)
        {
            listBMovies.Hide();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string gender = "";
            if (rbMale.Checked)
            {
                gender = "Male";
            }
            if (rbFemale.Checked)
            {
                gender = "Female";
            }
            if (edit == false)
            {
                if (txtNameActor.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Actor must to have a name");
                    return;
                }


                actors.AddActor(txtNameActor.Text, dtpBirthday.Value,gender, file, rtMovies.Text);
                MessageBox.Show("Done successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvActors.DataSource = actors.getActors();
                cleanTxt();
               // timerActor.Start();
            }
            if (edit)
            {
                if (txtNameActor.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Actor must to have a name");
                    return;
                }
                actors.editActor(idActor, txtNameActor.Text, dtpBirthday.Value,gender, file, rtMovies.Text);
                MessageBox.Show("Done successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvActors.DataSource = actors.getActors();
                idActor = 0;
                cleanTxt();
                //timerActor.Start();
            }



        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            cleanTxt();
            edit = false;
            //timerActor.Start();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            edit = false;
            cleanTxt();
           // if (sideMoviePanel.Width <= 183)
           // {
            //    timerMovie.Start();
            //}
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (idActor == 0)
            {
                MessageBox.Show("Select an actor", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult dialog = MessageBox.Show(" Are you sure?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog == DialogResult.Yes)
            {
                actors.deleteActor(idActor);
                dgvActors.DataSource = actors.getActors();
                cleanTxt();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            edit = true;
            if (txtNameActor.Text.Trim().Equals(""))
            {
                MessageBox.Show("Seleccione una fila", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
               /* if (dgvMoviePanel.Height <= 79)
                {
                    timerdgv.Start();
                }*/
            }
           /* if (sideMoviePanel.Width <= 183)
            {
                timerMovie.Start();
            }
            */
        }

        private void dgvActors_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //editar
        }
    }
}

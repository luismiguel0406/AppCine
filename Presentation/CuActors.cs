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
        int panelActorWidth;
        bool hidden;
        int idActor;
        
        

        byte[] file = null;
        public CuActors()
        {
            InitializeComponent();
            lbActor.Parent = pbMainActor;

            panelActorWidth = 406;
            hidden = true;
        }
        private bool edit = false;
        ActorDA actors = new ActorDA();

        private void CuActors_Load(object sender, EventArgs e)
        {
           dgvActors.DataSource = actors.getActors();
           // listBMovies.Hide();
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

            Stream mystream2 = openFileDialog2.OpenFile();

            using (MemoryStream ms2 = new MemoryStream())
            {
                mystream2.CopyTo(ms2);
                file = ms2.ToArray();
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
            timerActor.Start();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            edit = false;
            cleanTxt();
            if (leftSidePanelActor.Width <= 406)
            {
                timerActor.Start();
            }
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
            if (leftSidePanelActor.Width <= 406)
            {
                timerActor.Start();
            }
            
        }

       

        private void btnAdd_MouseMove(object sender, MouseEventArgs e)
        {
            btnAdd.BackColor = Color.Cyan;
        }

        private void btnAdd_MouseLeave(object sender, EventArgs e)
        {
            btnAdd.BackColor = Color.Transparent;
        }

        private void btnEdit_MouseMove(object sender, MouseEventArgs e)
        {
            btnEdit.BackColor = Color.Gold;
        }

        private void btnEdit_MouseLeave(object sender, EventArgs e)
        {
            btnEdit.BackColor = Color.Transparent;
        }

        private void btnDelete_MouseMove(object sender, MouseEventArgs e)
        {
            btnDelete.BackColor = Color.Red;
        }

        private void btnDelete_MouseLeave(object sender, EventArgs e)
        {
            btnDelete.BackColor = Color.Transparent;
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

        private void cbGender_TextChanged(object sender, EventArgs e)
        {
            //busqueda por lo que se escriba
            if (cbGender.Text != "")
            {
                dgvActors.CurrentCell = null;
                foreach (DataGridViewRow r in dgvActors.Rows)
                {
                    r.Visible = false;
                }
                foreach (DataGridViewRow r in dgvActors.Rows)
                {
                    foreach (DataGridViewCell c in r.Cells)
                    {
                        if ((c.Value.ToString().ToUpper()).IndexOf(cbGender.Text.ToUpper()) == 0)
                        {
                            r.Visible = true;
                            break;
                        }
                    }
                }
            }


            else
            {

                dgvActors.DataSource = actors.getActors();
            }
        }

        private void timerActor_Tick(object sender, EventArgs e)
        {
            if (hidden)
            {
                leftSidePanelActor.Width = leftSidePanelActor.Width + 30;
                if (leftSidePanelActor.Width >= panelActorWidth)
                {
                    timerActor.Stop();
                    hidden = false;
                    this.Refresh();
                }

            }
            else
            {
                leftSidePanelActor.Width = leftSidePanelActor.Width - 30;
                if (leftSidePanelActor.Width <= 0)
                {
                    timerActor.Stop();
                    hidden = true;
                    this.Refresh();
                }
            }
        }

        private void dgvActors_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idActor = int.Parse(dgvActors.CurrentRow.Cells[0].Value.ToString());
            txtNameActor.Text = dgvActors.CurrentRow.Cells[1].Value.ToString();

            lbActor.Text = dgvActors.CurrentRow.Cells[1].Value.ToString();
            dtpBirthday.Text = dgvActors.CurrentRow.Cells[2].Value.ToString();


            if (dgvActors.CurrentRow.Cells[3].Value.ToString() == "Male")
            {

                rbMale.Checked = true;
                rbFemale.Checked = false;
            }
            if (dgvActors.CurrentRow.Cells[3].Value.ToString() == "Female")
            {
                rbMale.Checked = false;
                rbFemale.Checked = false;
            }



            //busco la foto en la base de datos
            byte[] PhotoActor = new byte[0];

            //obtengo la imagen

            MemoryStream MS = new MemoryStream(actors.getPhotoActor(idActor, PhotoActor));
            pbActor.Image = Bitmap.FromStream(MS);
            pbMainActor.Image = Bitmap.FromStream(MS);


            rtMovies.Text = dgvActors.CurrentRow.Cells[5].Value.ToString();
        }
    }
}

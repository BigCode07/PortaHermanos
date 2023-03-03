using FullProgram;
using System;
using System.Configuration;
using System.Linq;
using System.Windows.Forms;

namespace FullProgram
{
    public partial class Query : Form
    {
        public Query()
        {
            InitializeComponent();
        }

        Porta_HermanosEntities db = new Porta_HermanosEntities();

        private void showMessage(string msg, int duration)
        {
            using (Timer t = new Timer())
            {
                Timer time = new Timer();
                time.Interval = duration;
                time.Tick += timeTick;  /* Evento enlazado */

                time.Start();

                /* Muestras el texto en el MB */
                MessageBox.Show(msg);
            }
        }

        private void timeTick(object sender, EventArgs e)
        {
            (sender as Timer).Stop();  /* Detiene el Timer */
            SendKeys.Send("{ESC}"); /* Hace la simulación de la tecla Escape, también puedes usar {ENTER} */
        }


        private void QueryData(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void UpdateData()
        {

            dgvLegajos.Rows.Clear();

            IQueryable<Legajo> legajos = db.Legajos;



            if (txtCaja.Text != "")
            {
                int caja = Convert.ToInt32(txtCaja.Text);
                legajos = legajos.Where(a => a.Caja == caja);
            }

            if (txtLegajo.Text != "")
            {
                int legajo = Convert.ToInt32(txtLegajo.Text);
                legajos = legajos.Where(a => a.Legajo1 == legajo);
            }

            if (txtDni.Text != "")
            {
                int dni = Convert.ToInt32(txtDni.Text);
                legajos = legajos.Where(a => a.Dni == dni);
            }

            if (txtNombre.Text != "")
            {
                legajos = legajos.Where(l => l.Apeynom.Contains(txtNombre.Text));
            }

            if (cboEstado.Text != "")
            {
                int estado = Convert.ToInt32(cboEstado.SelectedValue);
                legajos = legajos.Where(l => l.IdEstado == estado);
            }


            if (mskFCarga.MaskCompleted == true)
            {
                DateTime fcarga = Convert.ToDateTime(mskFCarga.Text);
                legajos = legajos.Where(a => a.FCarga == fcarga);
            }

            if (txtUsuario.Text != "")
            {
                legajos = legajos.Where(a => a.Usuario == txtUsuario.Text);
            }


            lblRegFilter.Text += legajos.Count();

            if (legajos.Count() > 0)
            {
                
                foreach (var le in legajos.ToList())
                {
                    dgvLegajos.Rows.Add(le.Id, le.Caja, le.Legajo1, le.Apeynom, le.Dni,le.IdEstado, le.Imagen, le.Usuario, le.FCarga);
                }
            }
            else
            {
                showMessage("No hay registros", 1500);
            }

        }

        private void CallDgv(object sender, DataGridViewCellEventArgs e)
        {

            if (dgvLegajos.Columns[e.ColumnIndex].Name.Equals("Eliminar"))
            {
                if (MessageBox.Show("Seguro desea Eliminar este Registro?", "Eliminar", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    try
                    {
                        var reg = db.Legajos.Find(dgvLegajos.CurrentRow.Cells[0].Value);
                        db.Legajos.Remove(reg);
                        db.SaveChanges();
                        showMessage("Registro Eliminado", 1250);
                        UpdateData();

                    }
                    catch { MessageBox.Show("Error en la operacion, verifique o complete datos faltantes"); }
                }

            }


            if (dgvLegajos.Columns[e.ColumnIndex].Name.Equals("Modificar"))
            {
                if (MessageBox.Show("Seguro desea modificar este registro?", "Modificar?", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    try
                    {
                        var hc = db.Legajos.Find(dgvLegajos.CurrentRow.Cells[0].Value);

                        if (dgvLegajos.CurrentRow.Cells[1].Value != null)
                        {
                            hc.Caja = Convert.ToInt32(dgvLegajos.CurrentRow.Cells[1].Value);
                        }

                        if (dgvLegajos.CurrentRow.Cells[2].Value != null)
                        {
                            hc.Legajo1 = Convert.ToInt32(dgvLegajos.CurrentRow.Cells[2].Value);
                        }

                        if (dgvLegajos.CurrentRow.Cells[3].Value != null)
                        {
                            hc.Apeynom = dgvLegajos.CurrentRow.Cells[3].Value.ToString();
                        }

                        if (dgvLegajos.CurrentRow.Cells[4].Value != null)
                        {
                            hc.Dni = Convert.ToInt32(dgvLegajos.CurrentRow.Cells[4].Value);
                        }


                        if (dgvLegajos.CurrentRow.Cells[5].Value != null)
                        {
                            hc.IdEstado = Convert.ToInt32(dgvLegajos.CurrentRow.Cells[5].Value);
                        }


                        if (dgvLegajos.CurrentRow.Cells[6].Value != null)
                        {
                            hc.Imagen = dgvLegajos.CurrentRow.Cells[6].Value.ToString();
                        }



                        db.SaveChanges();
                        showMessage("Registro Modificado", 1000);
                        UpdateData();

                    }
                    catch { MessageBox.Show("Error en la operacion, verifique o complete datos faltantes"); }
                }
            }
        }


        private void Type()
        {
            var stated = db.Estadoes.ToList();
            {
                cboEstado.DataSource = stated;
                EstadoGrid.DataSource = stated;
                EstadoGrid.DisplayMember = "Estado1";
                cboEstado.DisplayMember = "Estado1";
                EstadoGrid.ValueMember = "Id";
                cboEstado.ValueMember = "Id";

                cboEstado.SelectedIndex = -1;
            }
        }


        private void CallImage(object sender, DataGridViewCellEventArgs e)
        {
            axAcroPDF1.src = ConfigurationManager.AppSettings["images"] + "\\" + dgvLegajos.CurrentRow.Cells["Imagen"].Value.ToString();

        }

        private void Desplace(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }


        private void AllClear(object sender, EventArgs e)
        {

            txtCaja.Text = txtDni.Text = txtLegajo.Text = txtNombre.Text = txtUsuario.Text = mskFCarga.Text = "";
            cboEstado.SelectedIndex = -1;
            dgvLegajos.Rows.Clear();
            txtCaja.Focus();


        }

        private void Query_Load(object sender, EventArgs e)
        {

            lblAllReg.Text += db.Legajos.ToList().Count();
            Type();
        }

       
    }
}


using FullProgram;
using System;
using System.Linq;
using System.Windows.Forms;
using System.Data.Entity.Validation;

namespace FullProgram
{
    public partial class Add : Form
    {

        public Add()
        {
            InitializeComponent();
        }



        Porta_HermanosEntities db = new Porta_HermanosEntities();

        public static string usuarioAdd;
        public static object Contador;

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

        private bool Exist()
        {

            int legajo = Convert.ToInt32(txtLegajo.Text);
            int dni = Convert.ToInt32(txtDni.Text);
            int idEstado = Convert.ToInt32(cboEstado.SelectedValue);

            var existe = db.Legajos.SingleOrDefault(a => a.Legajo1 == legajo && a.Dni == dni && a.Apeynom == txtNombre.Text && a.IdEstado == idEstado);
            if (existe != null)
            {
                return true;
            }
            else { return false; };

        }

        private void Type()
        {
            var stated = db.Estadoes.ToList();
            {
                cboEstado.DataSource = stated;
                cboEstado.DisplayMember = "Estado1";
                cboEstado.ValueMember = "Id";
                cboEstado.SelectedIndex = -1;
            }
        }

        private void AddData(object sender, EventArgs e)
        {


            Legajo legajo = new Legajo();

            if (txtCaja.Text == "" && txtLegajo.Text == "" && txtDni.Text == "")
            {
                showMessage("Faltan datos de cargar", 1500);
                txtCaja.Focus();
                return;
            }
            if (!Exist())
            {

                legajo.Caja = Convert.ToInt32(txtCaja.Text);
                legajo.Legajo1 = Convert.ToInt32(txtLegajo.Text);
                legajo.Dni = Convert.ToInt32(txtDni.Text);
                legajo.Apeynom = txtNombre.Text;
                legajo.IdEstado = Convert.ToInt32(cboEstado.SelectedValue);
                legajo.FCarga = DateTime.Now;
                legajo.Usuario = usuarioAdd;
                db.Legajos.Add(legajo);
                db.SaveChanges();
                showMessage("Se cargaron los datos", 1000);
                dgv.Rows.Add(txtCaja.Text, txtLegajo.Text, txtNombre.Text, txtDni.Text, cboEstado.Text);
            }
            else { showMessage("Ya existe un registro", 2000); }

            Clear();
        }

        private void Clear()
        {
            txtLegajo.Text = txtDni.Text = txtNombre.Text = "";
            cboEstado.SelectedIndex = -1;
            txtLegajo.Focus();

        }

        private void Desplace(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");

            }
        }

        private void DesplaceType(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void StartProgram(object sender, EventArgs e)
        {
            Type();
        }

        private void ClearAll(object sender, EventArgs e)
        {
            txtCaja.Text = txtLegajo.Text = txtDni.Text = txtNombre.Text = "";
            cboEstado.SelectedIndex = -1;
            dgv.Rows.Clear();
            txtCaja.Focus();

        }

        private void CallLegajo(object sender, EventArgs e)
        {
            if (txtLegajo.Text != "")
            {
                int existLegajo = Convert.ToInt32(txtLegajo.Text);

                var exist = db.Legajos.SingleOrDefault(l => l.Legajo1 == existLegajo);

                if (exist != null)
                {


                    var leg = db.Legajos.ToList();

                    int legajo = Convert.ToInt32(txtLegajo.Text);

                    var caja = db.Legajos.Where(l => l.Legajo1 == legajo).Select(l => l.Caja).FirstOrDefault();
                    if (caja != null)
                    {
                        txtCaja.Text = caja.ToString();
                    }

                    var nombre = db.Legajos.Where(l => l.Legajo1 == legajo).Select(l => l.Apeynom).FirstOrDefault();
                    if (nombre != null)
                    {
                        txtNombre.Text = nombre.ToString();
                    }



                    var dni = db.Legajos.Where(l => l.Legajo1 == legajo).Select(l => l.Dni).FirstOrDefault();
                    if (dni != null)
                    {
                        txtDni.Text = dni.ToString();
                    }

                    cboEstado.Focus();

                }
                else { return; }
            }
            else { return; }

        }


    }
}

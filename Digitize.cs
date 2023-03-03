using System;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Configuration;
using WindowsApplication1;

namespace FullProgram
{
    public partial class Digitize : Form
    {
        public Digitize()
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
            txtCaja.Focus();

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
                dgvAA.Rows.Add(txtCaja.Text, txtLegajo.Text, txtNombre.Text, txtDni.Text, cboEstado.Text);
            }

            else
            {
                MessageBox.Show("Cuidado, ya hay una imagen creada.", "Mensaje de aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                if (MessageBox.Show("Desea agragarle hojas?, presione SI para continuar y NO para cancelar", "Interfile", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    return;
                }
            }

            int cant = Scan();
            for (int i = 0; i < cant; i++)
            {
                Contador.ToString();
            }

            Clear();

        }

        private int Scan()
        {

            int cant = 0;
            string archivo = txtLegajo.Text + "-" + txtDni.Text + ".pdf";
            string ruta = ConfigurationManager.AppSettings["Images"];
            comprobarDiretorio(ruta);
            ruta = ruta + @"\" + archivo;
            bool bandera = true;

            showMessage("Escaneando", 500);
            while (bandera)
            {

                if (checkBox3.Checked)
                {
                    EZTwain.SetHideUI(false);
                }
                else
                {
                    EZTwain.SetHideUI(true);
                }

                // EZTwain.SetHideUI(true);
                EZTwain.SetJpegQuality(75);
                if (EZTwain.OpenDefaultSource())
                {

                    EZTwain.EnableDuplex(true);
                    EZTwain.SetBlankPageMode(1);
                    EZTwain.SelectFeeder(true);
                    EZTwain.SetBlankPageThreshold(0.005);
                    EZTwain.SetFileAppendFlag(true);
                    EZTwain.SetPixelType(0);
                    EZTwain.SetResolution(200);
                    // If you can't get a Window handle, use IntPtr.Zero:
                    EZTwain.AcquireMultipageFile(this.Handle, ruta);
                    cant += EZTwain.MultipageCount();


                }
                if (EZTwain.LastErrorCode() != 0)
                {
                    EZTwain.ReportLastError("Unable to scan.");
                }

                agregar(ruta);

                if (MessageBox.Show("Desea agregar otra hoja a este Lote?", "Mensaje", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.Cancel)
                {
                    txtCaja.Focus();
                    bandera = false;

                }
            }

            int legajo = Convert.ToInt32(txtLegajo.Text);
            int dni = Convert.ToInt32(txtDni.Text);
            int idEstado = Convert.ToInt32(cboEstado.SelectedValue);

            var update = db.Legajos.SingleOrDefault(a => a.Legajo1 == legajo && a.Dni == dni && a.Apeynom == txtNombre.Text && a.IdEstado == idEstado);
            update.Imagen = archivo;
            db.SaveChanges();

            showMessage("Se actualizaron los datos del registro", 1000);
            return cant;
        }



        private void agregar(string nombre)
        {

            axAcroPDF1.LoadFile(nombre);
            axAcroPDF1.Show();

        }

        private void comprobarDiretorio(string dire)
        {
            DirectoryInfo DIR = new DirectoryInfo(dire);

            if (!DIR.Exists)
            {
                DIR.Create();
            }

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

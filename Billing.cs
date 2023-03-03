
using System.Linq;
using FullProgram;
using System.Windows.Forms;
using System;

namespace FullProgram
{
    public partial class Billing : Form
    {
        public Billing()
        {
            InitializeComponent();
        }

    

        private void SelectDates(object sender, DateRangeEventArgs e)
        {
            Porta_HermanosEntities db = new Porta_HermanosEntities();
            label1.Text = "";
            IQueryable<Legajo> legajos = db.Legajos;

            DateTime fechaInicio = Convert.ToDateTime(monthCalendar.SelectionStart);
            DateTime fechaFin = Convert.ToDateTime(monthCalendar.SelectionEnd);

            legajos = legajos.Where(a => a.FCarga >= fechaInicio && a.FCarga <= fechaFin);
            label1.Text += "Registros Encontrados: " + legajos.Count();

        }
    }
}

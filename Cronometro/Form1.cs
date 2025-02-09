using System.Windows.Forms.VisualStyles;

namespace Cronometro
{
    public partial class Form1 : Form
    {
        private DateTime tiempo;
        private bool iniciado = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!iniciado)
            {
                tiempo = DateTime.Now;
                TIMER.Start();
                iniciado = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TIMER.Stop();
            iniciado = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TIMER.Stop();
            TIEMPO.Text = "00:00:00";
            iniciado = false;
            button1_Click(sender, e);
        }

        private void SEGUNDOS_Tick(object sender, EventArgs e)
        {
            int horas = (DateTime.Now - tiempo).Hours;
            int minutos = (DateTime.Now - tiempo).Minutes;
            int segundos = (DateTime.Now - tiempo).Seconds;

            TIEMPO.Text = horas.ToString("D2")+":"+minutos.ToString("D2")+":"+segundos.ToString("D2");
        }
    }
}

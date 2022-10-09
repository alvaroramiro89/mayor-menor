using System.Diagnostics.CodeAnalysis;
// V2 test github 
// V3 ultima prueba. 
// V4 esta ya es desde la computadora nueva
namespace mayor_menor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        //cargar numeros+
        private void mayorMenor()
        {
            string t1 = textBox1.Text;
            string t2 = textBox2.Text;
            string t3 = textBox3.Text;

            double numero1 = Double.Parse(t1);
            double numero2 = Double.Parse(t2);
            double numero3 = Double.Parse(t3);
            
            double[] lista = new double[3];
            lista[0] = numero1;
            lista[1] = numero2;
            lista[2] = numero3;
            
            double max = lista[0];
            double min = lista[0];

            for (int i = 0; i < 3; i++)
            {
                if (lista[i] > max)
                    max = lista[i];
                else if (lista[i] < min)
                    min = lista[i];
            }
            MessageBox.Show("El numero más chico que subiste es: " + min + " y el más alto es: " + max );
        }

        private void promedio()
        {
            string t1 = textBox1.Text;
            string t2 = textBox2.Text;
            string t3 = textBox3.Text;

            double numero1 = Double.Parse(t1);
            double numero2 = Double.Parse(t2);
            double numero3 = Double.Parse(t3);

            double[] lista = new double[3];
            lista[0] = numero1;
            lista[1] = numero2;
            lista[2] = numero3;

            double prom = 0;

            for (int i = 0; i < 3; i++)
            {
                //MessageBox.Show("el valores promedio es " + prom);
                prom = (prom + lista[i]);
                //MessageBox.Show("el valor que esta poninedo es es " + lista[i]);
                
            }

            double promedio = prom / 3;
            MessageBox.Show("el promedio de tus numeros es: " + promedio);
        }

        private void parImpar()
        {
            string t1 = textBox1.Text;
            string t2 = textBox2.Text;
            string t3 = textBox3.Text;

            double numero1 = Double.Parse(t1);
            double numero2 = Double.Parse(t2);
            double numero3 = Double.Parse(t3);

            double[] lista = new double[3];
            lista[0] = numero1;
            lista[1] = numero2;
            lista[2] = numero3;

            for (int i = 0; i < lista.Length; i++)
            {
                double resto = lista[i] % 2;
                if (resto == 0)
                    MessageBox.Show("Su número es par");
                else
                    MessageBox.Show("su numero es impar");

            };
        }
        private void button1_Click(object sender, EventArgs e)
        {
            parImpar();
            mayorMenor();
            promedio();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
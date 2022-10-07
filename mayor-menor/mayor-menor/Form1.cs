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
            double a = lista[0];

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


        private void button1_Click(object sender, EventArgs e)
        {
            mayorMenor();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
namespace Laboratorio_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_asignar_Click(object sender, EventArgs e)
        {
            // Declarar vector
            int[] datos = new int[5];
            // Inicializar vector
            datos[0] = 17;
            datos[1] = 20;
            datos[2] = 66;
            datos[3] = 88;
            datos[4] = 101;
            // Mostrar datos
            this.out_mostrar_data.Text = datos[int.Parse(this.in_dato.Text)].ToString();
                

        }

        private void out_mostrar_data_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] nombres = { "Guillermo", "Roniel", "Victor", "Javier", "Carlos"};
            this.out_nombres.Text = nombres.Length.ToString();

            // MOSTRAR TODOS LOS NOMBRES
            string listado = " ";
            for (int i = 0; i < nombres.Length; i++)
            {
                listado = listado + nombres[i].ToString() +", ";

            }
            this.out_listado.Text = listado;
        }

        public int[,] matriz = new int[3, 3];
        private void btnguardar_Click(object sender, EventArgs e)
        {
            

            // Empezamos a asignar los valores
            if (int.TryParse(this.f0c0.Text, out int resultado1))
            {
                matriz[0, 0] = int.Parse(this.f0c0.Text);
            }
            else
            {
                MessageBox.Show("Has ingresado un dato no numerico, por favor revisa en Fila 0, Columna 0");
            }
            if (int.TryParse(this.f0c1.Text, out int resultado2))
            {
                matriz[0, 1] = int.Parse(this.f0c1.Text);
            }
            else
            {
                MessageBox.Show("Has ingresado un dato no numerico, por favor revisa en Fila 0, Columna 1");
            }
            if (int.TryParse(this.f0c2.Text, out int resultado3))
            {
                matriz[0, 2] = int.Parse(this.f0c2.Text);
            }
            else
            {
                MessageBox.Show("Has ingresado un dato no numerico, por favor revisa en Fila 0, Columna 2");
            }
            if (int.TryParse(this.f1c0.Text, out int resultado4))
            {
                matriz[1, 0] = int.Parse(this.f1c0.Text);
            }
            else
            {
                MessageBox.Show("Has ingresado un dato no numerico, por favor revisa en Fila 1, Columna 0");
            }
            if (int.TryParse(this.f1c1.Text, out int resultado5))
            {
                matriz[1, 1] = int.Parse(this.f1c1.Text);
            }
            else
            {
                MessageBox.Show("Has ingresado un dato no numerico, por favor revisa en Fila 1, Columna 1");
            }
            if (int.TryParse(this.f1c2.Text, out int resultado6))
            {
                matriz[1, 2] = int.Parse(this.f1c2.Text);
            }
            else
            {
                MessageBox.Show("Has ingresado un dato no numerico, por favor revisa en Fila 1, Columna 2");
            }
            if (int.TryParse(this.f2c0.Text, out int resultado7))
            {
                matriz[2, 0] = int.Parse(this.f2c0.Text);
            }
            else
            {
                MessageBox.Show("Has ingresado un dato no numerico, por favor revisa en Fila 2, Columna 0");
            }
            if (int.TryParse(this.f2c1.Text, out int resultado8))
            {
                matriz[2, 1] = int.Parse(this.f2c1.Text);
            }
            else
            {
                MessageBox.Show("Has ingresado un dato no numerico, por favor revisa en Fila 0, Columna 0");
            }
            if (int.TryParse(this.f2c2.Text, out int resultado9))
            {
                matriz[2, 2] = int.Parse(this.f2c2.Text);
            }
            else
            {
                MessageBox.Show("Has ingresado un dato no numerico, por favor revisa en Fila 0, Columna 0");
            }
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void obtener_Click(object sender, EventArgs e)
        {
            int fila = 0;
            if (int.Parse(this.fila.Text) < 3) // El numero no puede ser mayor a 2
            {
                fila = int.Parse(this.fila.Text);
            }

            int columna = 0;
            if (int.Parse(this.columna.Text) < 3) 
            {
                columna = int.Parse(this.columna.Text);
            }

            this.resultado.Text = this.matriz[fila,columna].ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
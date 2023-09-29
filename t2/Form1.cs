namespace t2
{
    public partial class Form1 : Form
    {

        Medicamento[] arregloM = new Medicamento[10];
        static int indice = 0;


        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_registrar_Click(object sender, EventArgs e)
        {

            //Lectura de los textbox 
            Medicamento med = new Medicamento();
            med.Nombre = txt_nombre.Text;
            med.Precio = double.Parse(txt_precio.Text);
            med.Cantidad = int.Parse(txt_cantidad.Text);
            med.Codigo = txt_codigo.Text;
            med.Monto = med.calcularMonto();

            //Agregar objeto al arreglo
            arregloM[indice] = med;
            indice++; // incrementa la posicion del indice del array

            MessageBox.Show("Medicamento registrado");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Arreglo para mostrar la lista de medicamentos
            for (int i = 0; i < indice; i++)
            {
                ListViewItem fila = new ListViewItem(arregloM[i].Nombre);
                fila.SubItems.Add(arregloM[i].Codigo);
                fila.SubItems.Add(arregloM[i].Cantidad.ToString());
                fila.SubItems.Add(arregloM[i].Precio.ToString());
                fila.SubItems.Add(arregloM[i].Monto.ToString());
                lviewMedicamentos.Items.Add(fila);
            }
        }

        private void lviewMedicamentos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_cantidad_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
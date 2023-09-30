namespace t2
{
    public partial class Form1 : Form
    {

        List<Medicamento> listaMedicamentos = new List<Medicamento>();

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
            if (string.IsNullOrEmpty(txt_nombre.Text) || string.IsNullOrEmpty(txt_precio.Text) || string.IsNullOrEmpty(txt_cantidad.Text) || string.IsNullOrEmpty(txt_codigo.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }

            //Lectura de los textbox 
            Medicamento med = new Medicamento();
            med.Nombre = txt_nombre.Text;
            med.Precio = double.Parse(txt_precio.Text);
            med.Cantidad = int.Parse(txt_cantidad.Text);
            med.Codigo = txt_codigo.Text;
            med.Monto = med.calcularMonto();

            if (ExisteCodigoEnLista(med.Codigo))
            {
                MessageBox.Show("¡El código del medicamento ya existe! Por favor, ingrese un código diferente.");
                return; // Salir del método sin registrar el nuevo elemento
            }

            listaMedicamentos.Add(med);

            VisualizarMedicamentosListView(listaMedicamentos);

            MessageBox.Show("Medicamento registrado");

            LimpiarFormulario();
        }


        private void LimpiarFormulario()
        {
            txt_nombre.Text = "";
            txt_precio.Text = "";
            txt_cantidad.Text = "";
            txt_codigo.Text = "";
        }

        private void VisualizarMedicamentosListView(List<Medicamento> lista)
        {

            LimpiarListView();

            lista.ForEach(med =>
            {
                ListViewItem fila = new ListViewItem(med.Nombre);
                fila.SubItems.Add(med.Codigo);
                fila.SubItems.Add(med.Cantidad.ToString());
                fila.SubItems.Add(med.Precio.ToString());
                fila.SubItems.Add(med.Monto.ToString());
                lviewMedicamentos.Items.Add(fila);
            });

        }

        private void LimpiarListView()
        {
            lviewMedicamentos.Items.Clear();
        }

        private List<Medicamento> OrdenarList(List<Medicamento> lista)
        {
            int i, j;
            Medicamento aux;

            for (i = 0; i < lista.Count; i++)
            {
                for (j = 0; j < lista.Count - 1; j++)
                {
                    if (String.Compare(lista[j].Nombre, lista[j + 1].Nombre) > 0)
                    {
                        aux = lista[j];
                        lista[j] = lista[j + 1];
                        lista[j + 1] = aux;
                    }
                }
            }

            return lista;
        }


        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            LimpiarListView();
            MessageBox.Show("Medicamentos limpiados");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Medicamento> listaOrdenada = OrdenarList(listaMedicamentos);

            VisualizarMedicamentosListView(listaOrdenada);

        }

        private bool ExisteCodigoEnLista(string codigo)
        {
            // Verificar si el código ya existe en la lista de medicamentos
            return listaMedicamentos.Any(m => m.Codigo == codigo);
        }


        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            string valorAEliminar = txt_codigo.Text; // Obtener el valor del TextBox

            // Utilizar LINQ para encontrar el elemento en la lista (por ejemplo, por nombre)
            var elementoAEliminar = listaMedicamentos.FirstOrDefault(m => m.Codigo == valorAEliminar);

            if (elementoAEliminar != null)
            {
                // Eliminar el elemento de la lista
                listaMedicamentos.Remove(elementoAEliminar);

                // Actualizar la vista (por ejemplo, el ListView) con la lista modificada
                VisualizarMedicamentosListView(listaMedicamentos);

                MessageBox.Show($"Elemento '{valorAEliminar}' eliminado correctamente.");
                LimpiarFormulario();
            }
            else
            {
                MessageBox.Show($"No se encontró ningún elemento con el valor '{valorAEliminar}'.");
            }
        }
    }
}
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

            MostrarCantidadMedicamentos();

            MessageBox.Show("Medicamento registrado");

            LimpiarFormulario();
        }

        private void MostrarCantidadMedicamentos()
        {
            label_cantidadMed.Text = $"(Hay {listaMedicamentos.Count} medicamentos)";
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
                completarFilaListView(med);
            });

        }

        private void completarFilaListView(Medicamento medicina)
        {
            ListViewItem fila = new ListViewItem(medicina.Nombre);
            fila.SubItems.Add(medicina.Codigo);
            fila.SubItems.Add(medicina.Cantidad.ToString());
            fila.SubItems.Add(medicina.Precio.ToString());
            fila.SubItems.Add(medicina.Monto.ToString());
            lviewMedicamentos.Items.Add(fila);
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
            List<Medicamento> listaOrdenada = (OrdenarList(listaMedicamentos)).ToList();

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

                MostrarCantidadMedicamentos();

                MessageBox.Show($"Elemento '{valorAEliminar}' eliminado correctamente.");
                LimpiarFormulario();
            }
            else
            {
                MessageBox.Show($"No se encontró ningún elemento con el valor '{valorAEliminar}'.");
            }
        }

        private void txt_codigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_listar_Click(object sender, EventArgs e)
        {
            VisualizarMedicamentosListView(listaMedicamentos);
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            string valorBuscado = text_buscar.Text;
            LimpiarListView();
            bool encontroMedicamento = false;

            for(int i = 0; i < listaMedicamentos.Count; i++)
            {
                if (listaMedicamentos[i].Nombre == valorBuscado)
                {
                    MessageBox.Show($"Se ha encontrado el medicamento: '{valorBuscado}'.");
                    encontroMedicamento = true;
                    completarFilaListView(listaMedicamentos[i]);
                }
            }

            if (!encontroMedicamento)
            {
                MessageBox.Show($"El medicamento con el nombre: '{valorBuscado}' no existe.");
            }

        }
    }
}
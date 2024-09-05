using MySql.Data.MySqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Xml;
using System;
using System.Windows.Forms;

namespace HerramientasCrud
{
    public partial class Form1 : Form
    {
        private int filaSeleccionada = -1;
        private int contadorID = 1;
        public Form1()
        {
            InitializeComponent();

        }
        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.Columns.Add("Id", "Id");
            dataGridView1.Columns.Add("Nombre1", "Nombre1");
            dataGridView1.Columns.Add("descripción", "descripción");
            dataGridView1.Columns.Add("marca", "marca");
            dataGridView1.Columns.Add("precio", "precio");
            dataGridView1.Columns.Add("stock", "stock");
        }

        

        private void guardar_Click(object sender, EventArgs e)
        {
            string Id = numericUpDownID.Value.ToString();
            string Nombre1 = txtNombre.Text;
            string descripcion = txtDescripcion.Text;
            string marca = txtMarca.Text;
            string precio = txtPrecio.Text;
            string stock = txtStock.Text;

            if (string.IsNullOrWhiteSpace(Nombre1) ||
                string.IsNullOrWhiteSpace(descripcion) ||
                string.IsNullOrWhiteSpace(marca) ||
                string.IsNullOrWhiteSpace(precio) ||
                string.IsNullOrWhiteSpace(stock))
            {
                MessageBox.Show("Por favor, llena todos los campos antes de guardar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (filaSeleccionada >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[filaSeleccionada];
                row.Cells["ID"].Value = Id;
                row.Cells["Nombre"].Value = Nombre1;
                row.Cells["Descripcion"].Value = descripcion;
                row.Cells["Marca"].Value = marca;
                row.Cells["Precio"].Value = precio;
                row.Cells["Stock"].Value = stock;

                filaSeleccionada = -1;
                guardar.Text = "Guardar";

            }
            else
            {
                if (numericUpDownID.Value == 0)
                {
                    Id = contadorID.ToString();
                    contadorID++;
                }

                dataGridView1.Rows.Add(Id, Nombre1, descripcion, marca, precio, stock);
               
            }
            LimpiarCampos();
        }

        private void editar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                filaSeleccionada = dataGridView1.SelectedRows[0].Index;

                DataGridViewRow row = dataGridView1.Rows[filaSeleccionada];
                numericUpDownID.Value = Convert.ToInt32(row.Cells["ID"].Value);
                txtNombre.Text = row.Cells["Nombre"].Value.ToString();
                txtDescripcion.Text = row.Cells["Descripcion"].Value.ToString();
                txtMarca.Text = row.Cells["Marca"].Value.ToString();
                txtPrecio.Text = row.Cells["Precio"].Value.ToString();
                txtStock.Text = row.Cells["Stock"].Value.ToString();

                guardar.Text = "Actualizar ";
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una fila para editar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void borrar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una fila para borrar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void nombre_Click(object sender, EventArgs e)
        {
            int idBuscado = (int)numericUpDownID.Value;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["ID"].Value != null && Convert.ToInt32(row.Cells["ID"].Value) == idBuscado)
                {
                    txtResultado.Text = row.Cells["Nombre"].Value.ToString();
                    return;
                }
            }
            MessageBox.Show("No se encontró un producto con ese ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void cortar_Click(object sender, EventArgs e)
        {
            txtResultado.Clear();
        }
        private void LimpiarCampos()
        {
            numericUpDownID.Value = 0;
            txtNombre.Clear();
            txtDescripcion.Clear();
            txtMarca.Clear();
            txtPrecio.Clear();
            txtStock.Clear();
        }


    }
}

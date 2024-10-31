using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        private string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\DB\\Chofer.accdb";
        private OleDbConnection connection; 

        public Form1()
        {
            InitializeComponent();
            connection = new OleDbConnection(connectionString);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabInsertar;

            using (OleDbConnection localConnection = new OleDbConnection(connectionString))
            {
                try
                {
                    localConnection.Open();
                    MessageBox.Show("Conexion establecida con exito!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarDatos();
                }

                catch (OleDbException ex)
                {
                    MessageBox.Show("Error de conexion a la base de datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open(); 
                string insertQuery = "INSERT INTO Chofer (Nombre, Apellido, Observacion) VALUES (@Nombre, @Apellido, @Observacion)";
                OleDbCommand command = new OleDbCommand(insertQuery, connection);
                command.Parameters.AddWithValue("@Nombre", textNombre.Text);
                command.Parameters.AddWithValue("@Apellido", textApellido.Text);
                command.Parameters.AddWithValue("@Observacion", textObservacion.Text);
                command.ExecuteNonQuery();
                MessageBox.Show("Datos guardados correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar los datos: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                string updateQuery = "UPDATE Chofer SET Nombre = @Nombre, Apellido = @Apellido, Observacion = @Observacion WHERE ID = @ID"; 
                OleDbCommand command = new OleDbCommand(updateQuery, connection);
                command.Parameters.AddWithValue("@Nombre", txtNombre.Text);
                command.Parameters.AddWithValue("@Apellido", txtApellido.Text);
                command.Parameters.AddWithValue("@Observacion", txtObservacion.Text);
                command.Parameters.AddWithValue("@ID", txtID.Text);
                command.ExecuteNonQuery();
              MessageBox.Show("Datos actualizados correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar los datos: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void CargarDatos()
        {
            try
            {
                connection.Open();
                string selectQuery = "SELECT * FROM Chofer"; 

                OleDbDataAdapter dataAdapter = new OleDbDataAdapter(selectQuery, connection);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

               
                dataGridView1.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabMostrar)
            {
                CargarDatos(); 
            }
        }

    }
}


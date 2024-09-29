using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient; // Necesario para MySQL
using System; // Necesario para DateTime
using System.Data; // Necesario para DataTable
using System.IO; // Necesario para trabajar con archivos
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent(); // Inicializa los controles definidos en el diseñador

        LoadTop10Users(); // Llamar a LoadTop10Users para cargar la información de los usuarios
    }


    // Método para cargar los 10 primeros usuarios desde MySQL a un DataGridView
    private void LoadTop10Users()
    {
        string connectionString = "Server=localhost;Database=Prueba1;Uid=root;Pwd=;";
        using (MySqlConnection connection = new MySqlConnection(connectionString))
        {
            try
            {
                connection.Open();
                string query = "SELECT * FROM usuarios LIMIT 10";

                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                // Suponiendo que tienes un DataGridView llamado dataGridViewUsuarios en tu Form1
                dataGridViewUsuarios.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
    // Método para exportar los datos a un archivo CSV
    private void ExportToCSV()
    {
        string connectionString = "Server=localhost;Database=Prueba1;Uid=root;Pwd=;";
        using (MySqlConnection connection = new MySqlConnection(connectionString))
        {
            try
            {
                connection.Open();
                string query = @"
                    SELECT 
                        u.Login, 
                        CONCAT(u.Nombre, ' ', u.Paterno, ' ', u.Materno) AS NombreCompleto,
                        e.Sueldo,
                        e.FechaIngreso
                    FROM usuarios u
                    JOIN empleados e ON u.userId = e.userId";

                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataReader reader = command.ExecuteReader();

                // Crear el archivo CSV
                using (StreamWriter writer = new StreamWriter("UsuariosExportados.csv"))
                {
                    // Escribir la cabecera
                    writer.WriteLine("Login,Nombre Completo,Sueldo,Fecha Ingreso");

                    // Escribir los datos
                    while (reader.Read())
                    {
                        string login = reader["Login"].ToString();
                        string nombreCompleto = reader["NombreCompleto"].ToString();
                        string sueldo = reader["Sueldo"].ToString();
                        string fechaIngreso = reader["FechaIngreso"].ToString();

                        writer.WriteLine($"{login},{nombreCompleto},{sueldo},{fechaIngreso}");
                    }
                }

                MessageBox.Show("Archivo CSV generado con éxito.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }

    private void btnExportToCSV_Click(object sender, EventArgs e)
    {
        ExportToCSV();// Llamar a ExportToCSV para generar el archivo CSV
    }

    // Método para agregar un nuevo usuario
    private void AddUser()
    {
        string userId = adduserId.Text;
        string login = addLogin.Text;
        string nombre = addNombre.Text;
        string paterno = addPaterno.Text;
        string materno = addMaterno.Text;
        double salary;

        if (double.TryParse(addSueldo.Text, out salary))
        {
            string connectionString = "Server=localhost;Database=Prueba1;Uid=root;Pwd=;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Insertar en la tabla 'usuarios'
                    string insertUserQuery = @"
                        INSERT INTO usuarios (userId, Login, Nombre, Paterno, Materno)
                        VALUES (@UserId, @Login, @Nombre, @Paterno, @Materno)";

                    using (MySqlCommand command = new MySqlCommand(insertUserQuery, connection))
                    {
                        command.Parameters.AddWithValue("@UserId", userId);
                        command.Parameters.AddWithValue("@Login", login);
                        command.Parameters.AddWithValue("@Nombre", nombre);
                        command.Parameters.AddWithValue("@Paterno", paterno);
                        command.Parameters.AddWithValue("@Materno", materno);

                        command.ExecuteNonQuery();
                    }

                    // Insertar en la tabla 'empleados'
                    string insertEmpleadoQuery = @"
                        INSERT INTO empleados (userId, Sueldo, FechaIngreso)
                        VALUES (@UserId, @Sueldo, @FechaIngreso)";

                    using (MySqlCommand command = new MySqlCommand(insertEmpleadoQuery, connection))
                    {
                        command.Parameters.AddWithValue("@UserId", userId);
                        command.Parameters.AddWithValue("@Sueldo", salary);
                        command.Parameters.AddWithValue("@FechaIngreso", DateTime.Now);

                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Usuario agregado con éxito.");
                    // LoadData(); // Actualizar el DataGridView para mostrar los nuevos datos
                    LoadTop10Users(); // Actualizar la lista de los 10 primeros usuarios
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
        else
        {
            MessageBox.Show("Ingrese un salario válido.");
        }
    }
    // Evento Click del botón para agregar un nuevo usuario
    private void btnAddUser_Click(object sender, EventArgs e)
    {
        AddUser(); // Llamar a AddUser para agregar un nuevo usuario
    }

    private void bBuscar_Click(object sender, EventArgs e)
    {
        string connectionString = "Server=localhost;Database=Prueba1;Uid=root;Pwd=;";
        using (MySqlConnection connection = new MySqlConnection(connectionString))
            /* try
             {
                 connection.Open();
                 string query = "SELECT * FROM empleados where userId=textBox7.text ";

                 MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, connection);
                 DataTable dataTable = new DataTable();

                 textBox8.Text = dataTable;

                 //  dataAdapter.Fill(dataTable);


                 // Suponiendo que tienes un DataGridView llamado dataGridViewUsuarios en tu Form1
                 //dataGridViewUsuarios.DataSource = dataTable;
             }
             catch (Exception ex)
             {
                 MessageBox.Show("Error: " + ex.Message);
             }*/
            try
            {
                connection.Open();

                // Definir la consulta SQL
                string query = "SELECT * FROM empleados ";

                using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection))
                {
                    // Crear un DataTable para llenar los datos
                    DataTable dataTable = new DataTable();

                    // Llenar el DataTable con los datos
                    adapter.Fill(dataTable);

                    // Vincular el DataTable al DataGridView
                    dataG.DataSource = dataTable;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
    }

    private void button1_Click(object sender, EventArgs e)
    {
        string connectionString = "Server=localhost;Database=Prueba1;Uid=root;Pwd=;";
        using (MySqlConnection connection = new MySqlConnection(connectionString))
            try
            {
                connection.Open();

                // Definir la consulta SQL

                //string query = "UPDATE empleados SET Sueldo = textBox8.Text where userId =TextBU.Text;";
                // Convertir los valores de TextBox a numérico
                if (decimal.TryParse(textBox7.Text, out decimal sueldo))
                {
                    string query = "UPDATE empleados SET Sueldo = @Sueldo WHERE userId = @userId";

                    // Crear el comando
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        // Asignar valores a los parámetros
                        cmd.Parameters.AddWithValue("@Sueldo", sueldo);
                        cmd.Parameters.AddWithValue("@userId", textBU);
                        // cmd.Parameters.AddWithValue("@userId", userId);
                        // Ejecutar la consulta
                        cmd.ExecuteNonQuery();
                    }
                }
                else
                {
                    MessageBox.Show("Los valores ingresados no son válidos. Asegúrate de que el sueldo y el userId sean numéricos.");
                }



            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
    }

    private void dataG_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex >= 0) // Asegurarse de que se selecciona una fila válida
        {
            // Obtener la fila seleccionada
            DataGridViewRow row = dataG.Rows[e.RowIndex];

            // Pasar los valores de la fila a los TextBox
            textBox7.Text = row.Cells["Sueldo"].Value.ToString();
            textBU.Text = row.Cells["userId"].Value.ToString();

            // Añadir más TextBox si es necesario para otras columnas
        }
    }
}
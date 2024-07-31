using System; 
using System.Collections.Generic; 
using System.Data.SqlClient; 
using System.Data; 
using System.Data.SqlTypes; 
using System.Linq; 
using System.Security.Cryptography; 
using System.Text; 
using System.Threading.Tasks; 
using System.Windows.Forms; 
using System.Windows.Controls.Primitives; 

namespace CioDental1  
{
    internal class Conexión  
    {

        public DataSet Consulta(string Comando)
        {
            DataSet dsa = new DataSet(); 
            SqlConnection sqlCon = new SqlConnection("Data Source=DESKTOP-1BUCJLF\\SQLEXPRESS; Initial Catalog=CioDental1; Integrated Security=true");
            sqlCon.Open();  
            SqlDataAdapter sqlDA = new SqlDataAdapter(Comando, sqlCon); 
            sqlDA.Fill(dsa, "Tabla");  
            dsa.Dispose(); 
            sqlCon.Dispose(); 
            sqlDA.Dispose(); 
            return dsa; 
        }


        public void Grids(string Comando, DataGridView dgv)
        {
            DataSet dsa = new DataSet(); 
            SqlConnection sqlCon = new SqlConnection("Data Source=DESKTOP-1BUCJLF\\SQLEXPRESS; Initial Catalog=CioDental1; Integrated Security=true");
            SqlDataAdapter sqlDA = new SqlDataAdapter(Comando, sqlCon); 
            sqlDA.Fill(dsa, "Tabla"); 

            dgv.DataSource = dsa.Tables[0]; 

            dsa.Dispose(); 
            sqlCon.Dispose(); 
            sqlDA.Dispose(); 
        }

        
        public bool Modificaciones(String Comando)
        {
            SqlConnection sqlCon = new SqlConnection("Data Source=localhost; Initial Catalog=CioDental1; Integrated Security=true"); // Crea una conexión a la base de datos utilizando la cadena de conexión proporcionada
            SqlCommand sqlCmd = new SqlCommand(Comando, sqlCon); 

            sqlCon.Open(); 
            sqlCmd.ExecuteNonQuery(); 
            sqlCon.Close(); 

            sqlCmd.Dispose(); 
            sqlCon.Dispose(); 

            return true; 
        }

       
        public void Busquedas(string Comando, DataGridView grid, string Columna)
        {
            DataSet Dsa = new DataSet(); 
            BindingSource bs = new BindingSource(); 
            DataTable dt = new DataTable(); 
            string strCoon = "Data Source=DESKTOP-1BUCJLF\\SQLEXPRESS; Initial Catalog=CioDental1; Integrated Security=true"; 
            SqlConnection conn = new SqlConnection(strCoon); 
            SqlDataAdapter da = new SqlDataAdapter(Comando, conn); 

            da.Fill(dt); 
            bs.DataSource = dt.DefaultView; 

            grid.DataSource = bs; 
            DataSet ds = new DataSet(); 
            ds.Tables.Add(dt.Copy()); 

            DataView dv = new DataView(ds.Tables[0]); 
            dv.RowFilter = Columna; 

            if (dv.Count != 0) 
                grid.DataSource = dv; 
            else
                grid.DataSource = null; 
        }

        // Método para mostrar los pacientes en un ComboBox
        public void mostraspacientes(ComboBox pacientes)
        {
            SqlConnection sqlCon = new SqlConnection("Data Source=DESKTOP-1BUCJLF\\SQLEXPRESS; Initial Catalog=CioDental1; Integrated Security=true"); // Crea una conexión a la base de datos utilizando la cadena de conexión proporcionada
            sqlCon.Open(); // Abre la conexión a la base de datos
            string IdPac = "SELECT * FROM PACIENTES"; // Define el comando SQL para seleccionar todos los pacientes
            SqlDataAdapter sqlDA = new SqlDataAdapter(IdPac, sqlCon); // Crea un adaptador de datos SQL utilizando el comando y la conexión proporcionados
            DataTable dt = new DataTable(); // Crea un objeto DataTable para almacenar los resultados de la consulta
            sqlDA.Fill(dt); // Llena el DataTable con los resultados de la consulta

            pacientes.DataSource = dt; // Establece el DataTable como la fuente de datos del ComboBox

            pacientes.DisplayMember = "NomPac"; // Establece la columna a mostrar en el ComboBox
            pacientes.ValueMember = "IdPac"; // Establece la columna de valor en el ComboBox
        }

        // Método para mostrar los proveedores en un ComboBox
        public void mostrasproveedores(ComboBox proveedores)
        {
            SqlConnection sqlCon = new SqlConnection("Data Source=DESKTOP-1BUCJLF\\SQLEXPRESS; Initial Catalog=CioDental1; Integrated Security=true"); // Crea una conexión a la base de datos utilizando la cadena de conexión proporcionada
            sqlCon.Open(); // Abre la conexión a la base de datos
            string IdProv = "SELECT * FROM PROVEEDORES"; // Define el comando SQL para seleccionar todos los proveedores
            SqlDataAdapter sqlDA = new SqlDataAdapter(IdProv, sqlCon); // Crea un adaptador de datos SQL utilizando el comando y la conexión proporcionados
            DataTable dt = new DataTable(); // Crea un objeto DataTable para almacenar los resultados de la consulta
            sqlDA.Fill(dt); // Llena el DataTable con los resultados de la consulta

            proveedores.DataSource = dt; // Establece el DataTable como la fuente de datos del ComboBox

            proveedores.DisplayMember = "NomProv"; // Establece la columna a mostrar en el ComboBox
            proveedores.ValueMember = "IdProv"; // Establece la columna de valor en el ComboBox
        }

        // Método para mostrar los contactos de proveedores en un ComboBox
        public void mostrascontactoproveedor(ComboBox contactoproveedor)
        {
            SqlConnection sqlCon = new SqlConnection("Data Source=DESKTOP-1BUCJLF\\SQLEXPRESS; Initial Catalog=CioDental1; Integrated Security=true"); // Crea una conexión a la base de datos utilizando la cadena de conexión proporcionada
            sqlCon.Open(); // Abre la conexión a la base de datos
            string IdConProv = "SELECT * FROM ContactoProveedor"; // Define el comando SQL para seleccionar todos los contactos de proveedores
            SqlDataAdapter sqlDA = new SqlDataAdapter(IdConProv, sqlCon); // Crea un adaptador de datos SQL utilizando el comando y la conexión proporcionados
            DataTable dt = new DataTable(); // Crea un objeto DataTable para almacenar los resultados de la consulta
            sqlDA.Fill(dt); // Llena el DataTable con los resultados de la consulta

            contactoproveedor.DataSource = dt; // Establece el DataTable como la fuente de datos del ComboBox

            contactoproveedor.DisplayMember = "NombConProv"; // Establece la columna a mostrar en el ComboBox
            contactoproveedor.ValueMember = "IdConProv"; // Establece la columna de valor en el ComboBox
        }

        // Método para mostrar las citas en un ComboBox
        public void mostrascitas(ComboBox citas)
        {
            SqlConnection sqlCon = new SqlConnection("Data Source=DESKTOP-1BUCJLF\\SQLEXPRESS; Initial Catalog=CioDental1; Integrated Security=true"); // Crea una conexión a la base de datos utilizando la cadena de conexión proporcionada
            sqlCon.Open(); // Abre la conexión a la base de datos
            string IdCit = "SELECT * FROM CITAS"; // Define el comando SQL para seleccionar todas las citas
            SqlDataAdapter sqlDA = new SqlDataAdapter(IdCit, sqlCon); // Crea un adaptador de datos SQL utilizando el comando y la conexión proporcionados
            DataTable dt = new DataTable(); // Crea un objeto DataTable para almacenar los resultados de la consulta
            sqlDA.Fill(dt); // Llena el DataTable con los resultados de la consulta

            citas.DataSource = dt; // Establece el DataTable como la fuente de datos del ComboBox

            citas.DisplayMember = "IdCit"; // Establece la columna a mostrar en el ComboBox
            citas.ValueMember = "IdCit"; // Establece la columna de valor en el ComboBox
        }

        // Método para mostrar los usuarios en un ComboBox
        public void mostrasusuarios(ComboBox usuarios)
        {
            SqlConnection sqlCon = new SqlConnection("Data Source=DESKTOP-1BUCJLF\\SQLEXPRESS; Initial Catalog=CioDental1; Integrated Security=true"); // Crea una conexión a la base de datos utilizando la cadena de conexión proporcionada
            sqlCon.Open(); // Abre la conexión a la base de datos
            string NomUsr = "SELECT * FROM USUARIOS"; // Define el comando SQL para seleccionar todos los usuarios
            SqlDataAdapter sqlDA = new SqlDataAdapter(NomUsr, sqlCon); // Crea un adaptador de datos SQL utilizando el comando y la conexión proporcionados
            DataTable dt = new DataTable(); // Crea un objeto DataTable para almacenar los resultados de la consulta
            sqlDA.Fill(dt); // Llena el DataTable con los resultados de la consulta

            usuarios.DataSource = dt; // Establece el DataTable como la fuente de datos del ComboBox

            usuarios.DisplayMember = "NomUsr"; // Establece la columna a mostrar en el ComboBox
            usuarios.ValueMember = "NomUsr"; // Establece la columna de valor en el ComboBox
        }

        // Método para mostrar las marcas en un ComboBox
        public void mostrasmarcas(ComboBox pacientes)
        {
            SqlConnection sqlCon = new SqlConnection("Data Source=DESKTOP-1BUCJLF\\SQLEXPRESS; Initial Catalog=CioDental1; Integrated Security=true"); // Crea una conexión a la base de datos utilizando la cadena de conexión proporcionada
            sqlCon.Open(); // Abre la conexión a la base de datos
            string IdMar = "SELECT * FROM MARCAS"; // Define el comando SQL para seleccionar todas las marcas
            SqlDataAdapter sqlDA = new SqlDataAdapter(IdMar, sqlCon); // Crea un adaptador de datos SQL utilizando el comando y la conexión proporcionados
            DataTable dt = new DataTable(); // Crea un objeto DataTable para almacenar los resultados de la consulta
            sqlDA.Fill(dt); // Llena el DataTable con los resultados de la consulta

            pacientes.DataSource = dt; // Establece el DataTable como la fuente de datos del ComboBox

            pacientes.DisplayMember = "NomMar"; // Establece la columna a mostrar en el ComboBox
            pacientes.ValueMember = "IdMar"; // Establece la columna de valor en el ComboBox
        }

        // Método para mostrar las bitácoras en un DataGridView
        public void mostrasbitacoras(DataGridView bitacoras)
        {
            SqlConnection sqlCon = new SqlConnection("Data Source=DESKTOP-1BUCJLF\\SQLEXPRESS; Initial Catalog=CioDental1; Integrated Security=true"); // Crea una conexión a la base de datos utilizando la cadena de conexión proporcionada
            sqlCon.Open(); // Abre la conexión a la base de datos
            string IdBit = "SELECT * FROM BITACORA"; // Define el comando SQL para seleccionar todas las bitácoras
            SqlDataAdapter sqlDA = new SqlDataAdapter(IdBit, sqlCon); // Crea un adaptador de datos SQL utilizando el comando y la conexión proporcionados
            DataTable dt = new DataTable(); // Crea un objeto DataTable para almacenar los resultados de la consulta
            sqlDA.Fill(dt); // Llena el DataTable con los resultados de la consulta

            bitacoras.DataSource = dt; // Establece el DataTable como la fuente de datos del DataGridView
        }

        // Método para validar si una consulta SQL devuelve filas
        public bool val(string query)
        {
            SqlCommand cmd = new SqlCommand(); // Crea un nuevo comando SQL
            SqlConnection sqlCon = new SqlConnection("Data Source=DESKTOP-1BUCJLF\\SQLEXPRESS; Initial Catalog=CioDental1; Integrated Security=true"); // Crea una conexión a la base de datos utilizando la cadena de conexión proporcionada
            sqlCon.Open(); // Abre la conexión a la base de datos
            cmd = new SqlCommand(query, sqlCon); // Asigna el comando SQL y la conexión al objeto SqlCommand
            SqlDataReader dr; // Declara un lector de datos SQL
            dr = cmd.ExecuteReader(); // Ejecuta el comando y asigna el resultado al lector de datos

            if (dr.HasRows == true) // Verifica si el lector de datos tiene filas
            {
                return true; // Retorna verdadero si tiene filas
            }
            else
            {
                return false; // Retorna falso si no tiene filas
            }

            //sqlCon.Close(); // Cierra la conexión a la base de datos (nota: esta línea no se ejecutará debido al return anterior)
        }

        // Método para leer datos de una consulta SQL y devolver un SqlDataReader
        public SqlDataReader leerdato(string cons)
        {
            SqlDataReader dr; // Declara un lector de datos SQL
            SqlConnection sqlCon = new SqlConnection("Data Source=DESKTOP-1BUCJLF\\SQLEXPRESS; Initial Catalog=CioDental1; Integrated Security=true"); // Crea una conexión a la base de datos utilizando la cadena de conexión proporcionada
            sqlCon.Open(); // Abre la conexión a la base de datos
            SqlCommand cmdImstruction = new SqlCommand(cons, sqlCon); // Crea un comando SQL con la consulta y la conexión proporcionadas
            dr = cmdImstruction.ExecuteReader(); // Ejecuta el comando y asigna el resultado al lector de datos

            return dr; // Retorna el lector de datos
        }

        // Método estático para permitir solo la entrada de números en un evento de pulsación de tecla
        public static void SoloNumeros(KeyPressEventArgs V)
        {
            if (Char.IsDigit(V.KeyChar)) // Verifica si el carácter presionado es un dígito
            {
                V.Handled = false; // Permite la entrada del carácter
            }
            else if (Char.IsSeparator(V.KeyChar)) // Verifica si el carácter presionado es un separador
            {
                V.Handled = false; // Permite la entrada del carácter
            }
            else if (Char.IsControl(V.KeyChar)) // Verifica si el carácter presionado es un carácter de control
            {
                V.Handled = false; // Permite la entrada del carácter
            }
            else
            {
                V.Handled = true; // Bloquea la entrada del carácter
                MessageBox.Show("Solo números"); // Muestra un mensaje indicando que solo se permiten números
            }
        }


        // Clase estática para manejar la autenticación de usuarios en el sistema
        public static class SistemaAutenticacion
        {
            public static string NombreUsuarioLogueado { get; private set; } // Propiedad para almacenar el nombre del usuario logueado

            // Método para establecer el nombre del usuario logueado
            public static void EstablecerUsuarioLogueado(string nombreUsuario)
            {
                NombreUsuarioLogueado = nombreUsuario; // Asigna el nombre del usuario a la propiedad NombreUsuarioLogueado
            }
        }


        // Clase estática que proporciona utilidades relacionadas con la seguridad del sistema
        public static class UtilidadesSeguridad
        {
            // Método para verificar si un usuario es administrador
            public static bool EsAdministrador(string nombreUsuario)
            {
                string consulta = "SELECT RolUsr FROM Usuarios WHERE NomUsr = @NomUsr"; // Consulta SQL para obtener el rol del usuario

                // Usa una conexión a la base de datos utilizando la cadena de conexión proporcionada
                using (SqlConnection coneccion = new SqlConnection("Data Source=DESKTOP-1BUCJLF\\SQLEXPRESS; Initial Catalog=CioDental1; Integrated Security=true"))
                {
                    // Usa un comando SQL con la consulta y la conexión proporcionadas
                    using (SqlCommand command = new SqlCommand(consulta, coneccion))
                    {
                        command.Parameters.AddWithValue("@NomUsr", nombreUsuario); // Agrega el parámetro a la consulta SQL

                        coneccion.Open(); // Abre la conexión a la base de datos
                        SqlDataReader reader = command.ExecuteReader(); // Ejecuta el comando y asigna el resultado al lector de datos

                        if (reader.Read()) // Verifica si el lector de datos tiene filas
                        {
                            string rol = reader["RolUsr"].ToString(); // Obtiene el rol del usuario
                            return (rol == "Administrador"); // Retorna verdadero si el rol es "Administrador"
                        }
                    }
                }

                return false; // Retorna falso si no se encontró el rol o si el usuario no es administrador
            }
        }



        // Método para buscar citas de un paciente por su nombre y mostrar los resultados en un DataGridView
        public void BuscarCitasPorNombrePaciente(string nombrePaciente, DataGridView dgvCitas)
        {
            string[] nombres = nombrePaciente.Split(' '); // Divide el nombre completo en nombre y apellido
            string nombre = nombres[0]; // Obtiene el primer nombre
            string apellido = nombres.Length > 1 ? nombres[1] : ""; // Verifica si hay apellido

            // Consulta SQL para buscar citas por nombre de paciente
            string consulta = @"SELECT Citas.IdCit, Citas.IdPac, Pacientes.NomPac, Pacientes.ApePac, Citas.FecCit, Citas.HorCit, Citas.EstCit
                    FROM Citas
                    INNER JOIN Pacientes ON Citas.IdPac = Pacientes.IdPac
                    WHERE (Pacientes.NomPac LIKE '%" + nombre + "%' AND Pacientes.ApePac LIKE '%" + apellido + "%')";

            Grids(consulta, dgvCitas); // Llama al método Grids para mostrar los resultados en el DataGridView
        }


        // Método para buscar facturas por nombre de paciente y mostrar los resultados en un DataGridView
        public void BuscarFacturaPorNombrePaciente(string nombrePaciente, DataGridView dgvFactura)
        {
            string consulta = @"SELECT
                                FE.IdFac,
                                FE.FecFac,
                                FE.HorFac,
                                FE.IdCit,
                                FE.NomUsr,
                                FD.IdFacDet,
                                FD.IdPro,
                                FD.IdTra,
                                FD.PrecPro,
                                FD.PrecTra
                            FROM
                                FacturaEncabezado FE
                            JOIN
                                FacturaDetalle FD ON FE.IdFac = FD.IdFac
                            JOIN
                                Citas C ON FE.IdCit = C.IdCit
                            JOIN
                                Pacientes P ON C.IdPac = P.IdPac
                            WHERE
                                P.NomPac LIKE '%" + nombrePaciente + "%'"; // Consulta SQL para buscar facturas por nombre de paciente

            Grids(consulta, dgvFactura); // Llama al método Grids para mostrar los resultados en el DataGridView
        }

        // Método para buscar compras por nombre de producto y mostrar los resultados en un DataGridView
        public void BuscarCompraPorNombreProducto(string nombreProducto, DataGridView dgvCompra)
        {
            string consulta = @"SELECT
                             C.IdCom,
                             C.NroFac,
                             C.FecCom,
                             C.IdConProv,
                             CD.IdComDet,
                             CD.IdPro,
                             CD.CantPro,
                             CD.PrePro
                        FROM
                              ComprasEncabezdo C
                        JOIN
                              ComprasDetalles CD ON C.IdCom = CD.IdCom
                        JOIN
                              Productos P ON CD.IdPro = P.IdPro
                            
                        WHERE
                               P.NomPro LIKE '%" + nombreProducto + "%'"; // Consulta SQL para buscar compras por nombre de producto

            Grids(consulta, dgvCompra); // Llama al método Grids para mostrar los resultados en el DataGridView
        }


        // Método para insertar un detalle de factura en la base de datos
        public void InsertarFacturaDetalle(int IdFacDet, int IdFac, int? IdTra, int? PreTra, int? IdPro, int? CantPro, int? PrePro)
        {
            using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-1BUCJLF\\SQLEXPRESS; Initial Catalog=CioDental1; Integrated Security=true"))
            {
                conn.Open(); // Abre la conexión a la base de datos

                // Crea un comando SQL para insertar el detalle de factura
                SqlCommand cmd = new SqlCommand("INSERT INTO FacturaDetalle (IdFacDet, IdFac, IdTra, PrecTra, IdPro, CantPro, PrecPro) VALUES (@IdFacDet, @IdFac, @IdTra, @PrecTra, @IdPro, @CantPro, @PrecPro)", conn);
                cmd.Parameters.AddWithValue("@IdFacDet", IdFacDet); // Asigna el valor del parámetro IdFacDet
                cmd.Parameters.AddWithValue("@IdFac", IdFac); // Asigna el valor del parámetro IdFac
                cmd.Parameters.AddWithValue("@IdTra", IdTra ?? (object)DBNull.Value); // Asigna el valor del parámetro IdTra
                cmd.Parameters.AddWithValue("@PrecTra", PreTra ?? (object)DBNull.Value); // Asigna el valor del parámetro PreTra
                cmd.Parameters.AddWithValue("@IdPro", IdPro ?? (object)DBNull.Value); // Asigna el valor del parámetro IdPro
                cmd.Parameters.AddWithValue("@CantPro", CantPro ?? (object)DBNull.Value); // Asigna el valor del parámetro CantPro
                cmd.Parameters.AddWithValue("@PrecPro", PrePro ?? (object)DBNull.Value); // Asigna el valor del parámetro PrePro

                cmd.ExecuteNonQuery(); // Ejecuta el comando SQL para insertar los datos
                conn.Close(); // Cierra la conexión a la base de datos
            }
        }

        // Método para actualizar un detalle de factura en la base de datos
        public void ActualizarFacturaDetalle(int IdFacDet, int IdFac, int? IdTra, int? PreTra, int? IdPro, int? CantPro, int? PrePro)
        {
            using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-1BUCJLF\\SQLEXPRESS; Initial Catalog=CioDental1; Integrated Security=true"))
            {
                conn.Open(); // Abre la conexión a la base de datos

                // Crea un comando SQL para actualizar el detalle de factura
                SqlCommand cmd = new SqlCommand("UPDATE FacturaDetalle SET IdFac = @IdFac, IdTra = @IdTra, PrecTra = @PrecTra, IdPro = @IdPro, CantPro = @CantPro, PrecPro = @PrecPro WHERE IdFacDet = @IdFacDet", conn);
                cmd.Parameters.AddWithValue("@IdFacDet", IdFacDet); // Asigna el valor del parámetro IdFacDet
                cmd.Parameters.AddWithValue("@IdFac", IdFac); // Asigna el valor del parámetro IdFac
                cmd.Parameters.AddWithValue("@IdTra", IdTra ?? (object)DBNull.Value); // Asigna el valor del parámetro IdTra
                cmd.Parameters.AddWithValue("@PrecTra", PreTra ?? (object)DBNull.Value); // Asigna el valor del parámetro PreTra
                cmd.Parameters.AddWithValue("@IdPro", IdPro ?? (object)DBNull.Value); // Asigna el valor del parámetro IdPro
                cmd.Parameters.AddWithValue("@CantPro", CantPro ?? (object)DBNull.Value); // Asigna el valor del parámetro CantPro
                cmd.Parameters.AddWithValue("@PrecPro", PrePro ?? (object)DBNull.Value); // Asigna el valor del parámetro PrePro

                cmd.ExecuteNonQuery(); 
                conn.Close(); 
            }
        }

    }
}



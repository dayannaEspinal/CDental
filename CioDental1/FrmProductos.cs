using System; // Importa el espacio de nombres System, que contiene clases fundamentales para el desarrollo .NET.
using System.Collections.Generic; // Importa el espacio de nombres para colecciones genéricas.
using System.ComponentModel; // Importa el espacio de nombres para componentes.
using System.Data; // Importa el espacio de nombres para el manejo de datos.
using System.Data.SqlClient; // Importa el espacio de nombres para conectarse a SQL Server.
using System.Drawing; // Importa el espacio de nombres para el manejo de gráficos.
using System.Linq; // Importa el espacio de nombres para consultas de datos.
using System.Text; // Importa el espacio de nombres para el manejo de texto.
using System.Threading.Tasks; // Importa el espacio de nombres para tareas asincrónicas.
using System.Windows.Forms; // Importa el espacio de nombres para el manejo de formularios.
using static CioDental1.Conexión; // Importa la clase Conexión estáticamente, para acceder a sus miembros directamente.

namespace CioDental1 // Define el espacio de nombres del proyecto.
{
    public partial class FrmProductos : Form // Define la clase FrmProductos que hereda de Form.
    {
        public FrmProductos() // Constructor del formulario FrmProductos.
        {
            InitializeComponent(); // Inicializa los componentes del formulario.
        }

        Conexión conexion = new Conexión(); // Crea una instancia de la clase Conexión para manejar la base de datos.

        private void Autonum() // Método para generar automáticamente el próximo ID de producto.
        {
            SqlDataReader reader = null; // Declara un SqlDataReader para leer datos de la base de datos.
            string query = "SELECT IdPro FROM PRODUCTOS"; // Define la consulta para obtener los IDs de productos.
            if (conexion.val(query) == true) // Verifica si la consulta devuelve resultados.
            {
                query = "SELECT MAX(IdPro) FROM PRODUCTOS"; // Define la consulta para obtener el ID máximo de productos.
                reader = conexion.leerdato(query); // Ejecuta la consulta y obtiene los datos.
                while (reader.Read()) // Lee los resultados de la consulta.
                {
                    lblCodProd.Text = Convert.ToString(Convert.ToInt32(reader.GetValue(0)) + 1); // Asigna el siguiente ID de producto al label.
                }
                reader.Close(); // Cierra el SqlDataReader.
            }
            else
            {
                lblCodProd.Text = "1"; // Asigna "1" si no hay productos en la base de datos.
            }
        }

        private void btnGuardarProducto_Click(object sender, EventArgs e) // Evento click del botón btnGuardarProducto.
        {
            if (txtNombreProducto.Text == "" || txtPrecioProducto.Text == "") // Verifica si los campos nombre o precio están vacíos.
            {
                MessageBox.Show("Datos incompletos"); // Muestra un mensaje si los datos están incompletos.
                return; // Sale del método.
            }

            int stockPro; // Declara una variable para el stock del producto.
            if (string.IsNullOrWhiteSpace(nUdStockPro.Text)) // Verifica si el campo de stock está vacío o contiene solo espacios en blanco.
            {
                stockPro = 0; // Asigna 0 si el campo está vacío.
            }
            else
            {
                if (!int.TryParse(nUdStockPro.Text, out stockPro)) // Intenta convertir el texto a un entero.
                {
                    MessageBox.Show("El valor ingresado para el stock no es válido"); // Muestra un mensaje si el valor de stock no es válido.
                    return; // Sale del método.
                }
            }

            int IdPro = int.Parse(lblCodProd.Text); // Convierte el texto de lblCodProd a entero y lo asigna a IdPro.
            string NomPro = txtNombreProducto.Text; // Asigna el texto de txtNombreProducto a la variable NomPro.
            string DesPro = txtDescripcionProducto.Text; // Asigna el texto de txtDescripcionProducto a la variable DesPro.
            DateTime FecVen = dtpFecVen.Value; // Asigna el valor de dtpFecVen a la variable FecVen.
            int PrecPro = int.Parse(txtPrecioProducto.Text); // Convierte el texto de txtPrecioProducto a entero y lo asigna a PrecPro.
            int StockPro = int.Parse(nUdStockPro.Text); // Convierte el texto de nUdStockPro a entero y lo asigna a StockPro.
            int IdMar_Pro = (int)cbxMarcas.SelectedValue; // Convierte el valor seleccionado de cbxMarcas a entero y lo asigna a IdMar_Pro.

            conexion.Modificaciones("exec Insertar_Productos '" + IdPro + " ', ' " + NomPro + " ', ' " + DesPro + " ', ' " + FecVen + " ', ' " + PrecPro + " ',' " + StockPro + " ', ' " + IdMar_Pro + " ' "); // Ejecuta la consulta para insertar un nuevo producto en la base de datos.
            MessageBox.Show("El producto ha sido GUARDADO correctamente"); // Muestra un mensaje indicando que el producto ha sido guardado.
            Autonum(); // Llama al método Autonum para actualizar el ID del producto.
            txtNombreProducto.Clear(); // Limpia el texto de txtNombreProducto.
            txtDescripcionProducto.Clear(); // Limpia el texto de txtDescripcionProducto.
            dtpFecVen.ResetText(); // Resetea el texto de dtpFecVen.
            txtPrecioProducto.Clear(); // Limpia el texto de txtPrecioProducto.
            nUdStockPro.Value = 0; // Resetea el valor de nUdStockPro a 0.
            conexion.Busquedas("exec VisProducto", dgvProductos, "NomPro LIKE '%" + txtBuscarProducto.Text + "%*' "); // Ejecuta la consulta para buscar productos y mostrar el resultado en dgvProductos.

            string hora = DateTime.Now.ToLongTimeString(); // Obtiene la hora actual y la asigna a la variable hora.
            string fecha = DateTime.Now.ToShortDateString(); // Obtiene la fecha actual y la asigna a la variable fecha.
            string accion = "Se guardó un producto"; // Define la acción realizada.
            string usuario = SistemaAutenticacion.NombreUsuarioLogueado; // Obtiene el nombre del usuario logueado y lo asigna a la variable usuario.

            conexion.Modificaciones("exec Insertar_Bitacoras  '" + fecha + "', '" + hora + "', '" + accion + "','" + usuario + "' "); // Ejecuta la consulta para insertar una nueva bitácora en la base de datos.
        }

        private void btnSalirProducto_Click(object sender, EventArgs e) // Evento click del botón btnSalirProducto.
        {
            Form J = new FrmMenuPrincipal(); // Crea una instancia del formulario FrmMenuPrincipal.
            J.Show(); // Muestra el formulario FrmMenuPrincipal.
        }

        private void btnModificarProducto_Click(object sender, EventArgs e) // Evento click del botón btnModificarProducto.
        {
            if (!UtilidadesSeguridad.EsAdministrador(SistemaAutenticacion.NombreUsuarioLogueado)) // Verifica si el usuario logueado es un administrador.
            {
                MessageBox.Show("No tienes permiso para realizar esta acción."); // Muestra un mensaje si el usuario no tiene permisos.
                return; // Sale del método.
            }

            if (txtNombreProducto.Text == "") // Verifica si el campo de nombre de producto está vacío.
            {
                MessageBox.Show("Datos incompletos"); // Muestra un mensaje si los datos están incompletos.
                return; // Sale del método.
            }

            int IdPro = int.Parse(lblCodProd.Text); // Convierte el texto de lblCodProd a entero y lo asigna a IdPro.
            string NomPro = txtNombreProducto.Text; // Asigna el texto de txtNombreProducto a la variable NomPro.
            string DesPro = txtDescripcionProducto.Text; // Asigna el texto de txtDescripcionProducto a la variable DesPro.
            DateTime FecVen = dtpFecVen.Value; // Asigna el valor de dtpFecVen a la variable FecVen.
            int PrecPro = int.Parse(txtPrecioProducto.Text); // Convierte el texto de txtPrecioProducto a entero y lo asigna a PrecPro.
            int StockPro = int.Parse(nUdStockPro.Text); // Convierte el texto de nUdStockPro a entero y lo asigna a StockPro.
            int IdMar_Pro = (int)cbxMarcas.SelectedValue; // Convierte el valor seleccionado de cbxMarcas a entero y lo asigna a IdMar_Pro.

            conexion.Modificaciones("exec Actualizar_Productos '" + IdPro + " ', ' " + NomPro + " ', ' " + DesPro + " ', ' " + FecVen + " ', ' " + PrecPro + " ',' " + StockPro + " ', ' " + IdMar_Pro + " ' "); // Ejecuta la consulta para actualizar el producto en la base de datos.
            MessageBox.Show("El producto ha sido ACTUALIZADO correctamente"); // Muestra un mensaje indicando que el producto ha sido actualizado.
            Autonum(); // Llama al método Autonum para actualizar el ID del producto.
            txtNombreProducto.Clear(); // Limpia el texto de txtNombreProducto.
            txtDescripcionProducto.Clear(); // Limpia el texto de txtDescripcionProducto.
            dtpFecVen.ResetText(); // Resetea el texto de dtpFecVen.
            txtPrecioProducto.Clear(); // Limpia el texto de txtPrecioProducto.
            nUdStockPro.Value = 0; // Resetea el valor de nUdStockPro a 0.

            string hora = DateTime.Now.ToLongTimeString(); // Obtiene la hora actual y la asigna a la variable hora.
            string fecha = DateTime.Now.ToShortDateString(); // Obtiene la fecha actual y la asigna a la variable fecha.
            string accion = "Se actualizó un producto"; // Define la acción realizada.
            string usuario = SistemaAutenticacion.NombreUsuarioLogueado; // Obtiene el nombre del usuario logueado y lo asigna a la variable usuario.

            conexion.Modificaciones("exec Insertar_Bitacoras  '" + fecha + "', '" + hora + "', '" + accion + "','" + usuario + "' "); // Ejecuta la consulta para insertar una nueva bitácora en la base de datos.
            conexion.Busquedas("exec VisProducto", dgvProductos, "NomPro LIKE '%" + txtBuscarProducto.Text + "%*' "); // Ejecuta la consulta para buscar productos y mostrar el resultado en dgvProductos.
        }

        private void btnEliminarProducto_Click(object sender, EventArgs e) // Evento click del botón btnEliminarProducto.
        {
            if (MessageBox.Show("¿Seguro que quieres ELIMINAR este producto?", "Eliminar producto", MessageBoxButtons.YesNo) == DialogResult.Yes) // Muestra un mensaje de confirmación para eliminar el producto.
            {
                int IdPro = int.Parse(lblCodProd.Text); // Convierte el texto de lblCodProd a entero y lo asigna a IdPro.
                conexion.Modificaciones("exec Eliminar_Productos '" + IdPro + "'"); // Ejecuta la consulta para eliminar el producto de la base de datos.
                MessageBox.Show("El producto ha sido ELIMINADO"); // Muestra un mensaje indicando que el producto ha sido eliminado.
                Autonum(); // Llama al método Autonum para actualizar el ID del producto.

                string hora = DateTime.Now.ToLongTimeString(); // Obtiene la hora actual y la asigna a la variable hora.
                string fecha = DateTime.Now.ToShortDateString(); // Obtiene la fecha actual y la asigna a la variable fecha.
                string accion = "Se eliminó un producto"; // Define la acción realizada.
                string usuario = SistemaAutenticacion.NombreUsuarioLogueado; // Obtiene el nombre del usuario logueado y lo asigna a la variable usuario.

                conexion.Modificaciones("exec Insertar_Bitacoras  '" + fecha + "', '" + hora + "', '" + accion + "','" + usuario + "' "); // Ejecuta la consulta para insertar una nueva bitácora en la base de datos.
                conexion.Busquedas("exec VisProducto", dgvProductos, "NomPro LIKE '%" + txtBuscarProducto.Text + "%*' "); // Ejecuta la consulta para buscar productos y mostrar el resultado en dgvProductos.
            }
        }

        private void txtBuscarProducto_TextChanged(object sender, EventArgs e) // Evento que se dispara cuando el texto en txtBuscarProducto cambia.
        {
            conexion.Busquedas("exec VisProducto", dgvProductos, "NomPro LIKE '%" + txtBuscarProducto.Text + "%*' "); // Ejecuta la consulta para buscar productos y mostrar el resultado en dgvProductos.
        }

        private void FrmProductos_Load(object sender, EventArgs e) // Evento que se dispara cuando el formulario FrmProductos se carga.
        {
            Autonum(); // Llama al método Autonum para actualizar el ID del producto.
            conexion.mostrasmarcas(cbxMarcas); // Muestra las marcas en el ComboBox cbxMarcas.
        }

        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e) // Evento que se dispara cuando se hace clic en una celda de dgvProductos.
        {
            try
            {
                lblCodProd.Text = dgvProductos.CurrentRow.Cells[0].Value.ToString(); // Asigna el valor de la primera celda de la fila seleccionada a lblCodProd.
                txtNombreProducto.Text = dgvProductos.CurrentRow.Cells[1].Value.ToString(); // Asigna el valor de la segunda celda de la fila seleccionada a txtNombreProducto.
                txtDescripcionProducto.Text = dgvProductos.CurrentRow.Cells[2].Value.ToString(); // Asigna el valor de la tercera celda de la fila seleccionada a txtDescripcionProducto.
                dtpFecVen.Value = (DateTime)dgvProductos.CurrentRow.Cells[3].Value; // Asigna el valor de la cuarta celda de la fila seleccionada a dtpFecVen.
                txtPrecioProducto.Text = dgvProductos.CurrentRow.Cells[4].Value.ToString(); // Asigna el valor de la quinta celda de la fila seleccionada a txtPrecioProducto.
                nUdStockPro.Text = dgvProductos.CurrentRow.Cells[5].Value.ToString(); // Asigna el valor de la sexta celda de la fila seleccionada a nUdStockPro.
                cbxMarcas.SelectedValue = dgvProductos.CurrentRow.Cells[6].Value; // Asigna el valor de la séptima celda de la fila seleccionada a cbxMarcas.
            }
            catch
            {
                // Manejo de excepciones vacío.
            }
        }

        private void txtNombreProducto_TextChanged(object sender, EventArgs e) // Evento que se dispara cuando el texto en txtNombreProducto cambia.
        {
            // Actualmente vacío, puedes agregar lógica aquí si es necesario.
        }

        private void txtPrecioProducto_KeyPress(object sender, KeyPressEventArgs e) // Evento que se dispara cuando se presiona una tecla en txtPrecioProducto.
        {
            Conexión.SoloNumeros(e); // Llama al método SoloNumeros de la clase Conexión para permitir solo números en el campo.
        }

        private void label10_Click(object sender, EventArgs e) // Evento que se dispara cuando se hace clic en label10.
        {
            // Actualmente vacío, puedes agregar lógica aquí si es necesario.
        }
    }
}

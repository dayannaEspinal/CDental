using FontAwesome.Sharp; // Importa la biblioteca FontAwesome.Sharp para usar iconos en la aplicación.
using System; // Importa el espacio de nombres principal de .NET.
using System.Collections.Generic; // Importa el espacio de nombres para trabajar con listas genéricas.
using System.ComponentModel; // Importa el espacio de nombres para la funcionalidad de los componentes.
using System.Data; // Importa el espacio de nombres para trabajar con datos.
using System.Data.SqlClient; // Importa el espacio de nombres para trabajar con SQL Server.
using System.Drawing; // Importa el espacio de nombres para trabajar con gráficos.
using System.Linq; // Importa el espacio de nombres para consultas LINQ.
using System.Text; // Importa el espacio de nombres para manipulación de texto.
using System.Threading.Tasks; // Importa el espacio de nombres para tareas asíncronas.
using System.Windows.Forms; // Importa el espacio de nombres para crear aplicaciones Windows Forms.
using static CioDental1.Conexión; // Importa de manera estática la clase Conexión del proyecto actual.
using static System.Windows.Forms.VisualStyles.VisualStyleElement; // Importa de manera estática elementos de estilo visual.

namespace CioDental1 // Define el espacio de nombres del proyecto.
{
    public partial class FrmCompras : Form // Define la clase FrmCompras que hereda de Form.
    {
        public FrmCompras() // Constructor de la clase FrmCompras.
        {
            InitializeComponent(); // Inicializa los componentes del formulario.
        }

        Conexión conexion = new Conexión(); // Crea una instancia de la clase Conexión.
        SqlConnection sqlCon = new SqlConnection("Data Source=DESKTOP-1BUCJLF\\SQLEXPRESS; Initial Catalog=CioDental1; Integrated Security=true"); // Crea una conexión a la base de datos SQL Server.

        private void Autonum() // Método para generar automáticamente el IdCom.
        {
            SqlDataReader reader = null; // Declara un lector de datos SQL inicializado en null.
            string query = "SELECT IdCom FROM ComprasEncabezdo"; // Define la consulta SQL para seleccionar IdCom.
            if (conexion.val(query) == true) // Verifica si la consulta devuelve algún valor.
            {
                query = "SELECT MAX(IdCom) FROM ComprasEncabezdo"; // Define la consulta SQL para obtener el valor máximo de IdCom.
                reader = conexion.leerdato(query); // Ejecuta la consulta y obtiene el lector de datos.
                while (reader.Read()) // Itera sobre los resultados de la consulta.
                {
                    lblIdCom.Text = Convert.ToString(Convert.ToInt32(reader.GetValue(0))+1); // Asigna al label el valor de IdCom incrementado en 1.
                }
                reader.Close(); // Cierra el lector de datos.
            }
            else
            {
                lblIdCom.Text = "1"; // Asigna el valor 1 al label si no hay registros.
            }
        }

        private void AutonumDetalle() // Método para generar automáticamente el IdComDet.
        {
            SqlDataReader reader = null; // Declara un lector de datos SQL inicializado en null.
            string query = "SELECT MAX(IdComDet) FROM ComprasDetalles"; // Define la consulta SQL para obtener el valor máximo de IdComDet.
            reader = conexion.leerdato(query); // Ejecuta la consulta y obtiene el lector de datos.

            if (reader != null && reader.HasRows) // Verifica si el lector no es null y tiene filas.
            {
                while (reader.Read()) // Itera sobre los resultados de la consulta.
                {
                    int maxIdComDet = reader.IsDBNull(0) ? 0 : reader.GetInt32(0); // Obtiene el valor máximo de IdComDet o 0 si es null.
                    nextCode = maxIdComDet + 1; // Incrementa el valor máximo en 1.
                    lblDetalle.Text = nextCode.ToString(); // Asigna al label el valor de nextCode.
                }
            }
            else
            {
                nextCode = 1; // Asigna el valor 1 a nextCode si no hay registros.
                lblDetalle.Text = nextCode.ToString(); // Asigna al label el valor de nextCode.
            }

            reader.Close(); // Cierra el lector de datos.
        }

        private void btnGuardarCompras_Click(object sender, EventArgs e) // Evento que se dispara al hacer clic en el botón de guardar compras.
        {
            if (txtCodFacCompras.Text == "") // Verifica si el campo de texto del código de factura está vacío.
            {
                MessageBox.Show("Datos incompletos"); // Muestra un mensaje indicando que los datos están incompletos.
                return; // Sale del método si el campo está vacío.
            }
            else
            {
                // No se realiza ninguna acción en el bloque else.
            }

            int IdCom = int.Parse(lblIdCom.Text); // Obtiene el IdCom desde el label y lo convierte a entero.
            int NroFac = int.Parse(txtCodFacCompras.Text); // Obtiene el número de factura desde el campo de texto y lo convierte a entero.
            DateTime FecCom = dtpFechaCompras.Value; // Obtiene la fecha de compra desde el control DateTimePicker.
            int ConProv_Com = (int)cbxConProv_Com.SelectedValue; // Obtiene el proveedor seleccionado desde el ComboBox y lo convierte a entero.

            // Ejecuta el procedimiento almacenado para insertar un registro en ComprasEncabezado.
            conexion.Modificaciones("exec Insertar_ComprasEncabezado '" + IdCom + " ', ' " + NroFac + " ', ' " + FecCom + " ', ' " + ConProv_Com + " ' ");

            foreach (DataGridViewRow row in dgvCompraGeneral.Rows) // Itera sobre cada fila del DataGridView de compras generales.
            {
                foreach (DataGridViewCell cell in row.Cells) // Itera sobre cada celda en la fila.
                {
                    if (cell.Value == null || string.IsNullOrWhiteSpace(cell.Value.ToString())) // Verifica si la celda está vacía o contiene solo espacios en blanco.
                    {
                        MessageBox.Show("Datos incompletos"); // Muestra un mensaje indicando que los datos están incompletos.
                        return; // Sale del método si alguna celda está vacía.
                    }
                }

                int IdComDet = int.Parse(row.Cells[0].Value.ToString()); // Obtiene el IdComDet desde la celda y lo convierte a entero.
                int IdPro = int.Parse(row.Cells[1].Value.ToString()); // Obtiene el IdPro desde la celda y lo convierte a entero.
                int CanPro = int.Parse(row.Cells[3].Value.ToString()); // Obtiene la cantidad del producto desde la celda y lo convierte a entero.
                int PrePro = int.Parse(row.Cells[4].Value.ToString()); // Obtiene el precio del producto desde la celda y lo convierte a entero.

                // Ejecuta el procedimiento almacenado para insertar un registro en ComprasDetalles.
                conexion.Modificaciones("exec Insertar_ComprasDetalles '" + IdComDet + " ', ' " + IdCom + " ', ' " + IdPro + " ', ' " + CanPro + " ', ' " + PrePro + " ' ");
                // Ejecuta el procedimiento almacenado para aumentar el stock del producto.
                conexion.Modificaciones("exec AumentarStockProducto ' " + IdPro + " ', ' " + CanPro + " ' ");
            }
            MessageBox.Show("La compra ha sido GUARDADA correctamente"); // Muestra un mensaje indicando que la compra se guardó correctamente.

            AutonumDetalle(); // Llama al método para actualizar el número automático del detalle.
            txtPrePro.Clear(); // Limpia el campo de texto del precio del producto.
            nUdCanPro.Value = 0; // Reinicia el valor del control NumericUpDown de cantidad del producto.
            txtNomPro.Clear(); // Limpia el campo de texto del nombre del producto.
            txtTotalPro.Clear(); // Limpia el campo de texto del total del producto.

            string hora = DateTime.Now.ToLongTimeString(); // Obtiene la hora actual como cadena.
            string fecha = DateTime.Now.ToShortDateString(); // Obtiene la fecha actual como cadena.
            string accion = "Se guardó una compra"; // Define la acción realizada.
            string usuario = SistemaAutenticacion.NombreUsuarioLogueado; // Obtiene el nombre del usuario logueado.

            // Ejecuta el procedimiento almacenado para insertar un registro en la bitácora.
            conexion.Modificaciones("exec Insertar_Bitacoras  '" + fecha + "', '" + hora + "', '" + accion + "','" + usuario + "' ");

            FrmReporteObtenerDetallesCompras frmReporteCompra = new FrmReporteObtenerDetallesCompras(IdCom); // Crea una instancia del formulario de reporte de detalles de compras.
            frmReporteCompra.Show(); // Muestra el formulario de reporte de detalles de compras.
        }

        private void FrmCompras_Load(object sender, EventArgs e) // Evento que se dispara al cargar el formulario.
        {
            Autonum(); // Llama al método para actualizar el número automático del encabezado.
            AutonumDetalle(); // Llama al método para actualizar el número automático del detalle.
            conexion.mostrascontactoproveedor(cbxConProv_Com); // Muestra los contactos del proveedor en el ComboBox.
        }

        private void btnModificarCompras_Click(object sender, EventArgs e) // Evento que se dispara al hacer clic en el botón de modificar compras.
        {
            if (!UtilidadesSeguridad.EsAdministrador(SistemaAutenticacion.NombreUsuarioLogueado)) // Verifica si el usuario logueado es administrador.
            {
                MessageBox.Show("No tienes permiso para realizar esta acción."); // Muestra un mensaje indicando que no tiene permisos.
                return; // Sale del método si el usuario no es administrador.
            }

            if (txtCodFacCompras.Text == "" || txtCodPro.Text == "" || txtPrePro.Text == "" || nUdCanPro.Value == 0) // Verifica si los campos obligatorios están vacíos.
            {
                MessageBox.Show("Datos incompletos"); // Muestra un mensaje indicando que los datos están incompletos.
                return; // Sale del método si algún campo está vacío.
            }
            else
            {
                // No se realiza ninguna acción en el bloque else.
            }

            int IdCom = int.Parse(lblIdCom.Text); // Obtiene el IdCom desde el label y lo convierte a entero.
            int NroFac = int.Parse(txtCodFacCompras.Text); // Obtiene el número de factura desde el campo de texto y lo convierte a entero.
            DateTime FecCom = dtpFechaCompras.Value; // Obtiene la fecha de compra desde el control DateTimePicker.
            int ConProv_Com = (int)cbxConProv_Com.SelectedValue; // Obtiene el proveedor seleccionado desde el ComboBox y lo convierte a entero.

            int IdComDet = int.Parse(lblDetalle.Text); // Obtiene el IdComDet desde el label y lo convierte a entero.
            int IdPro = int.Parse(txtCodPro.Text); // Obtiene el IdPro desde el campo de texto y lo convierte a entero.
            int PrePro = int.Parse(txtPrePro.Text); // Obtiene el precio del producto desde el campo de texto y lo convierte a entero.
            int CanPro = int.Parse(nUdCanPro.Text); // Obtiene la cantidad del producto desde el control NumericUpDown y lo convierte a entero.

            // Ejecuta el procedimiento almacenado para actualizar un registro en ComprasEncabezado.
            conexion.Modificaciones("exec Actualizar_ComprasEncabezado '" + IdCom + " ', ' " + NroFac + " ', ' " + FecCom + " ', ' " + ConProv_Com + " ' ");
            // Ejecuta el procedimiento almacenado para actualizar un registro en ComprasDetalles.
            conexion.Modificaciones("exec Actualizar_ComprasDetalles '" + IdComDet + " ', ' " + IdCom + " ', ' " + IdPro + " ', ' " + CanPro + " ', ' " + PrePro + " ' ");
            // Ejecuta el procedimiento almacenado para aumentar el stock del producto.
            conexion.Modificaciones("exec AumentarStockProducto ' " + IdPro + " ', ' " + CanPro + " ' ");
            MessageBox.Show("La compra ha sido ACTUALIZADA correctamente"); // Muestra un mensaje indicando que la compra se actualizó correctamente.

            AutonumDetalle(); // Llama al método para actualizar el número automático del detalle.
            txtCodPro.Clear(); // Limpia el campo de texto del código del producto.
            txtPrePro.Clear(); // Limpia el campo de texto del precio del producto.
            nUdCanPro.Value = 0; // Reinicia el valor del control NumericUpDown de cantidad del producto.
            txtNomPro.Clear(); // Limpia el campo de texto del nombre del producto.
            txtTotalPro.Clear(); // Limpia el campo de texto del total del producto.

            string hora = DateTime.Now.ToLongTimeString(); // Obtiene la hora actual como cadena.
            string fecha = DateTime.Now.ToShortDateString(); // Obtiene la fecha actual como cadena.
            string accion = "Se actualizó una compra"; // Define la acción realizada.
            string usuario = SistemaAutenticacion.NombreUsuarioLogueado; // Obtiene el nombre del usuario logueado.

            // Ejecuta el procedimiento almacenado para insertar un registro en la bitácora.
            conexion.Modificaciones("exec Insertar_Bitacoras  '" + fecha + "', '" + hora + "', '" + accion + "','" + usuario + "' ");
        }

        private void btnEliminarCompras_Click(object sender, EventArgs e) // Evento que se dispara al hacer clic en el botón de eliminar compras.
        {
            if (MessageBox.Show("¿Seguro que quieres ELIMINAR esta compra encabezado?", "Eliminar compra encabezado", MessageBoxButtons.YesNo) == DialogResult.Yes) // Muestra un cuadro de diálogo de confirmación.
            {
                int IdCom = int.Parse(lblIdCom.Text); // Obtiene el IdCom desde el label y lo convierte a entero.
                conexion.Modificaciones("exec Eliminar_ComprasEncabezado '" + IdCom + "'"); // Ejecuta el procedimiento almacenado para eliminar un registro en ComprasEncabezado.
                MessageBox.Show("La compra encabezado ha sido ELIMINADA"); // Muestra un mensaje indicando que la compra se eliminó.

                Autonum(); // Llama al método para actualizar el número automático del encabezado.

                string hora = DateTime.Now.ToLongTimeString(); // Obtiene la hora actual como cadena.
                string fecha = DateTime.Now.ToShortDateString(); // Obtiene la fecha actual como cadena.
                string accion = "Se eliminó una compra"; // Define la acción realizada.
                string usuario = SistemaAutenticacion.NombreUsuarioLogueado; // Obtiene el nombre del usuario logueado.

                // Ejecuta el procedimiento almacenado para insertar un registro en la bitácora.
                conexion.Modificaciones("exec Insertar_Bitacoras  '" + fecha + "', '" + hora + "', '" + accion + "','" + usuario + "' ");
            }
        }

        private void btnSalirCompras_Click(object sender, EventArgs e) // Evento que se dispara al hacer clic en el botón de salir de compras.
        {
            Form A = new FrmMenuPrincipal(); // Crea una instancia del formulario principal.
            A.Show(); // Muestra el formulario principal.
        }

        private void btnGuardarProcDet_Click(object sender, EventArgs e) // Evento que se dispara al hacer clic en el botón de guardar proceso detalle.
        {
            // El método está vacío y no realiza ninguna acción.
        }

        private void btnGuardarComDetalle_Click(object sender, EventArgs e) // Evento que se dispara al hacer clic en el botón de guardar compra detalle.
        {
            // El método está vacío y no realiza ninguna acción.
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e) // Evento que se dispara al hacer clic en el botón de buscar producto.
        {
            using (BuscarProductos formBusqueda = new BuscarProductos()) // Crea una instancia del formulario de búsqueda de productos y lo utiliza dentro de un bloque using.
            {
                formBusqueda.ShowDialog(); // Muestra el formulario de búsqueda de productos como un cuadro de diálogo modal.

                if (formBusqueda.ProductoSeleccionado != null) // Verifica si se seleccionó un producto en el formulario de búsqueda.
                {
                    txtCodPro.Text = formBusqueda.ProductoSeleccionado.Codigo.ToString(); // Asigna el código del producto seleccionado al campo de texto correspondiente.
                    txtNomPro.Text = formBusqueda.ProductoSeleccionado.Nombre; // Asigna el nombre del producto seleccionado al campo de texto correspondiente.
                    txtPrePro.Text = formBusqueda.ProductoSeleccionado.Precio.ToString(); // Asigna el precio del producto seleccionado al campo de texto correspondiente.
                }
            }
        }

        private decimal total = 0; // Declara una variable decimal para almacenar el total.

        private void btnTotPro_Click(object sender, EventArgs e) // Evento que se dispara al hacer clic en el botón de total del producto.
        {
            decimal subtotal = decimal.Parse(nUdCanPro.Text) * decimal.Parse(txtPrePro.Text); // Calcula el subtotal multiplicando la cantidad del producto por el precio del producto.
            txtTotalPro.Text = subtotal.ToString(); // Asigna el subtotal calculado al campo de texto del total del producto.
            total += subtotal; // Suma el subtotal al total acumulado.
            lblTotalFinal.Text = total.ToString(); // Actualiza el label del total final con el nuevo total.
        }

        private void txtBuscarComDetalle_TextChanged(object sender, EventArgs e) // Evento que se dispara al cambiar el texto en el campo de búsqueda de detalles de compra.
        {
            // El método está vacío y no realiza ninguna acción.
        }

        private void LimpiarCamposEspecificos() // Método para limpiar campos específicos del formulario.
        {
            Autonum(); // Llama al método para actualizar el número automático del encabezado.
            txtCodFacCompras.Clear(); // Limpia el campo de texto del código de factura de compras.
            dtpFechaCompras.ResetText(); // Resetea el control DateTimePicker de fecha de compras.
            lblTotalFinal.Text = ""; // Limpia el label del total final.
            txtEfectivo.Clear(); // Limpia el campo de texto del efectivo.
            lblCambio.Text = ""; // Limpia el label del cambio.
            dgvCompraGeneral.Rows.Clear(); // Limpia las filas del DataGridView de compras generales.
        }

        private void btnLimpiarComEnc_Click(object sender, EventArgs e) // Evento que se dispara al hacer clic en el botón de limpiar compra encabezado.
        {
            LimpiarCamposEspecificos(); // Llama al método para limpiar campos específicos.
        }

        private void btnGuardarDetalles_Click(object sender, EventArgs e) // Evento que se dispara al hacer clic en el botón de guardar detalles.
        {
            if (txtCodPro.Text == "" || txtPrePro.Text == "" || nUdCanPro.Value == 0) // Verifica si los campos obligatorios están vacíos.
            {
                MessageBox.Show("Datos incompletos"); // Muestra un mensaje indicando que los datos están incompletos.
                return; // Sale del método si algún campo está vacío.
            }
            else
            {
                // No se realiza ninguna acción en el bloque else.
            }

            int IdComDet = int.Parse(lblDetalle.Text); // Obtiene el IdComDet desde el label y lo convierte a entero.
            int IdCom = int.Parse(lblIdCom.Text); // Obtiene el IdCom desde el label y lo convierte a entero.
            int IdPro = int.Parse(txtCodPro.Text); // Obtiene el IdPro desde el campo de texto y lo convierte a entero.
            int PrePro = int.Parse(txtPrePro.Text); // Obtiene el precio del producto desde el campo de texto y lo convierte a entero.
            int CanPro = int.Parse(nUdCanPro.Text); // Obtiene la cantidad del producto desde el control NumericUpDown y lo convierte a entero.
            int NomPro = int.Parse(txtNomPro.Text); // Este campo parece incorrecto, el nombre del producto no debería convertirse a entero.
            int TotPro = int.Parse(txtTotalPro.Text); // Obtiene el total del producto desde el campo de texto y lo convierte a entero.

            // Ejecuta el procedimiento almacenado para insertar un registro en ComprasDetalles.
            conexion.Modificaciones("exec Insertar_ComprasDetalles '" + IdComDet + " ', ' " + IdCom + " ', ' " + IdPro + " ', ' " + CanPro + " ', ' " + PrePro + " ' ");
            MessageBox.Show("La compra detalle ha sido GUARDADA correctamente"); // Muestra un mensaje indicando que la compra detalle se guardó correctamente.

            AutonumDetalle(); // Llama al método para actualizar el número automático del detalle.
            txtPrePro.Clear(); // Limpia el campo de texto del precio del producto.
            nUdCanPro.Value = 0; // Reinicia el valor del control NumericUpDown de cantidad del producto.
            txtNomPro.Clear(); // Limpia el campo de texto del nombre del producto.
            txtTotalPro.Clear(); // Limpia el campo de texto del total del producto.

            string hora = DateTime.Now.ToLongTimeString(); // Obtiene la hora actual como cadena.
            string fecha = DateTime.Now.ToShortDateString(); // Obtiene la fecha actual como cadena.
            string accion = "Se guardó una compra detalle"; // Define la acción realizada.
            string usuario = SistemaAutenticacion.NombreUsuarioLogueado; // Obtiene el nombre del usuario logueado.

            // Ejecuta el procedimiento almacenado para insertar un registro en la bitácora.
            conexion.Modificaciones("exec Insertar_Bitacoras  '" + fecha + "', '" + hora + "', '" + accion + "','" + usuario + "' ");
        }

        private void btnModificarDetalles_Click(object sender, EventArgs e) // Evento que se dispara al hacer clic en el botón de modificar detalles.
        {
            if (!UtilidadesSeguridad.EsAdministrador(SistemaAutenticacion.NombreUsuarioLogueado)) // Verifica si el usuario es administrador.
            {
                MessageBox.Show("No tienes permiso para realizar esta acción."); // Muestra un mensaje indicando que no tiene permisos.
                return; // Sale del método si no tiene permisos.
            }

            if (txtCodPro.Text == "" || txtPrePro.Text == "" || nUdCanPro.Value == 0) // Verifica si los campos obligatorios están vacíos.
            {
                MessageBox.Show("Datos incompletos"); // Muestra un mensaje indicando que los datos están incompletos.
                return; // Sale del método si algún campo está vacío.
            }
            else
            {
                // No se realiza ninguna acción en el bloque else.
            }

            int IdComDet = int.Parse(lblDetalle.Text); // Obtiene el IdComDet desde el label y lo convierte a entero.
            int IdCom = int.Parse(lblIdCom.Text); // Obtiene el IdCom desde el label y lo convierte a entero.
            int IdPro = int.Parse(txtCodPro.Text); // Obtiene el IdPro desde el campo de texto y lo convierte a entero.
            int PrePro = int.Parse(txtPrePro.Text); // Obtiene el precio del producto desde el campo de texto y lo convierte a entero.
            int CanPro = int.Parse(nUdCanPro.Text); // Obtiene la cantidad del producto desde el control NumericUpDown y lo convierte a entero.

            // Ejecuta el procedimiento almacenado para actualizar un registro en ComprasDetalles.
            conexion.Modificaciones("exec Actualizar_ComprasDetalles '" + IdComDet + " ', ' " + IdCom + " ', ' " + IdPro + " ', ' " + CanPro + " ', ' " + PrePro + " ' ");
            MessageBox.Show("La compra detalle ha sido GUARDADA correctamente"); // Muestra un mensaje indicando que la compra detalle se guardó correctamente.

            AutonumDetalle(); // Llama al método para actualizar el número automático del detalle.
            txtPrePro.Clear(); // Limpia el campo de texto del precio del producto.
            nUdCanPro.Value = 0; // Reinicia el valor del control NumericUpDown de cantidad del producto.
            txtNomPro.Clear(); // Limpia el campo de texto del nombre del producto.
            txtTotalPro.Clear(); // Limpia el campo de texto del total del producto.

            string hora = DateTime.Now.ToLongTimeString(); // Obtiene la hora actual como cadena.
            string fecha = DateTime.Now.ToShortDateString(); // Obtiene la fecha actual como cadena.
            string accion = "Se actualizó una compra detalle"; // Define la acción realizada.
            string usuario = SistemaAutenticacion.NombreUsuarioLogueado; // Obtiene el nombre del usuario logueado.

            // Ejecuta el procedimiento almacenado para insertar un registro en la bitácora.
            conexion.Modificaciones("exec Insertar_Bitacoras  '" + fecha + "', '" + hora + "', '" + accion + "','" + usuario + "' ");
        }

        private void dgvCompra_CellClick(object sender, DataGridViewCellEventArgs e) // Evento que se dispara al hacer clic en una celda del DataGridView de compras.
        {
            // El método está vacío y no realiza ninguna acción.
        }

        private int nextCode = 1; // Declara una variable para el siguiente código de detalle.
        private void btnAñadirCompra_Click(object sender, EventArgs e) // Evento que se dispara al hacer clic en el botón de añadir compra.
        {
            if (string.IsNullOrWhiteSpace(txtCodPro.Text) || string.IsNullOrWhiteSpace(txtPrePro.Text) || nUdCanPro.Value == 0) // Verifica si los campos obligatorios están vacíos.
            {
                MessageBox.Show("Por favor, complete todos los campos"); // Muestra un mensaje indicando que los datos están incompletos.
                return; // Sale del método si algún campo está vacío.
            }

            decimal cantPro = nUdCanPro.Value; // Obtiene la cantidad del producto desde el control NumericUpDown.
            decimal precPro = decimal.Parse(txtPrePro.Text); // Obtiene el precio del producto desde el campo de texto y lo convierte a decimal.

            decimal totalParcial = cantPro * precPro; // Calcula el total parcial multiplicando la cantidad por el precio.

            lblDetalle.Text = nextCode.ToString(); // Asigna el siguiente código de detalle al label.
            dgvCompraGeneral.Rows.Add(lblDetalle.Text, txtCodPro.Text, txtNomPro.Text, nUdCanPro.Text, txtPrePro.Text, totalParcial); // Añade una nueva fila al DataGridView con los detalles del producto.

            nextCode++; // Incrementa el siguiente código de detalle.

            txtCodPro.Clear(); // Limpia el campo de texto del código del producto.
            txtNomPro.Clear(); // Limpia el campo de texto del nombre del producto.
            nUdCanPro.Value = 0; // Reinicia el valor del control NumericUpDown de cantidad del producto.
            txtPrePro.Clear(); // Limpia el campo de texto del precio del producto.

            string hora = DateTime.Now.ToLongTimeString(); // Obtiene la hora actual como cadena.
            string fecha = DateTime.Now.ToShortDateString(); // Obtiene la fecha actual como cadena.
            string accion = "Se añadió un detalle a la compra"; // Define la acción realizada.
            string usuario = SistemaAutenticacion.NombreUsuarioLogueado; // Obtiene el nombre del usuario logueado.

            // Ejecuta el procedimiento almacenado para insertar un registro en la bitácora.
            conexion.Modificaciones("exec Insertar_Bitacoras  '" + fecha + "', '" + hora + "', '" + accion + "','" + usuario + "' ");
        }

        private void btnCalcularCambio_Click(object sender, EventArgs e) // Evento que se dispara al hacer clic en el botón de calcular cambio.
        {
            CalcularCambio(); // Llama al método para calcular el cambio.
        }

        private void CalcularCambio() // Método para calcular el cambio.
        {
            if (!string.IsNullOrEmpty(txtEfectivo.Text)) // Verifica si el campo de texto del efectivo no está vacío.
            {
                int efectivo = int.Parse(txtEfectivo.Text); // Obtiene el monto de efectivo desde el campo de texto y lo convierte a entero.
                int total = int.Parse(lblTotalFinal.Text); // Obtiene el total final desde el label y lo convierte a entero.
                int cambio = efectivo - total; // Calcula el cambio restando el total del efectivo.
                lblCambio.Text = cambio.ToString(); // Asigna el cambio calculado al label del cambio.
            }
        }

        private void dgvCompraGeneral_CellClick(object sender, DataGridViewCellEventArgs e) // Evento que se dispara al hacer clic en una celda del DataGridView de compras generales.
        {
            try // Inicia un bloque try para capturar cualquier excepción que pueda ocurrir.
            {
                lblDetalle.Text = dgvCompraGeneral.CurrentRow.Cells[0].Value.ToString(); // Asigna el valor de la primera celda de la fila seleccionada al label lblDetalle.
                txtCodPro.Text = dgvCompraGeneral.CurrentRow.Cells[1].Value.ToString(); // Asigna el valor de la segunda celda de la fila seleccionada al campo de texto txtCodPro.
                txtNomPro.Text = dgvCompraGeneral.CurrentRow.Cells[2].Value.ToString(); // Asigna el valor de la tercera celda de la fila seleccionada al campo de texto txtNomPro.
                nUdCanPro.Text = dgvCompraGeneral.CurrentRow.Cells[3].Value.ToString(); // Asigna el valor de la cuarta celda de la fila seleccionada al control NumericUpDown nUdCanPro.
                txtPrePro.Text = dgvCompraGeneral.CurrentRow.Cells[4].Value.ToString(); // Asigna el valor de la quinta celda de la fila seleccionada al campo de texto txtPrePro.
            }
            catch // Captura cualquier excepción que pueda ocurrir durante la asignación de valores.
            {
                // El bloque catch está vacío y no realiza ninguna acción en caso de excepción.
            }
        }

        private void dgvCompraGeneral_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Implementación vacía.
        }
    }
}

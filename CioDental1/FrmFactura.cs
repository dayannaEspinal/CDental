using System; // Importa el espacio de nombres System.
using System.Collections.Generic; // Importa el espacio de nombres para colecciones genéricas.
using System.Data.SqlClient; // Importa el espacio de nombres para SQL Server.
using System.ComponentModel; // Importa el espacio de nombres para componentes.
using System.Data; // Importa el espacio de nombres para datos.
using System.Data.SqlTypes; // Importa el espacio de nombres para tipos de datos SQL.
using System.Drawing; // Importa el espacio de nombres para gráficos.
using System.Linq; // Importa el espacio de nombres para consultas LINQ.
using System.Text; // Importa el espacio de nombres para manipulación de texto.
using System.Threading.Tasks; // Importa el espacio de nombres para tareas asincrónicas.
using System.Windows.Forms; // Importa el espacio de nombres para Windows Forms.
using static CioDental1.Conexión; // Importa estáticamente la clase Conexión.

namespace CioDental1 // Define el espacio de nombres CioDental1.
{
    public partial class FrmFactura : Form // Define la clase del formulario.
    {
        public FrmFactura() // Constructor de la clase FrmFactura.
        {
            InitializeComponent(); // Inicializa los componentes del formulario.
        }

        Conexión conexion = new Conexión(); // Crea una instancia de la clase Conexión.
        SqlConnection sqlCon = new SqlConnection("Data Source=DESKTOP-1BUCJLF\\SQLEXPRESS; Initial Catalog=CioDental1; Integrated Security=true"); // Define la conexión SQL.

        private void Autonum() // Método para autonumerar facturas.
        {
            SqlDataReader reader = null; // Inicializa el lector de datos SQL.
            string query = "SELECT IdFac FROM FacturaEncabezado"; // Define la consulta SQL.

            if (conexion.val(query) == true) // Verifica si existen registros.
            {
                query = "SELECT MAX(IdFac) FROM FacturaEncabezado"; // Define la consulta para obtener el ID máximo.
                reader = conexion.leerdato(query); // Ejecuta la consulta y obtiene el lector de datos.

                while (reader.Read()) // Lee los datos.
                {
                    lblFact.Text = Convert.ToString(Convert.ToInt32(reader.GetValue(0)) + 1); // Asigna el nuevo ID al label.
                }

                reader.Close(); // Cierra el lector de datos.
            }
            else
            {
                lblFact.Text = "1"; // Asigna el valor 1 si no existen registros.
            }
        }

        private void AutonumFacDet() // Método para autonumerar detalles de facturas.
        {
            SqlDataReader reader = null; // Inicializa el lector de datos SQL.
            string query = "SELECT MAX(IdFacDet) FROM FacturaDetalle"; // Define la consulta SQL.

            reader = conexion.leerdato(query); // Ejecuta la consulta y obtiene el lector de datos.

            if (reader != null && reader.HasRows) // Verifica si el lector tiene filas.
            {
                while (reader.Read()) // Lee los datos.
                {
                    int maxIdFacDet = reader.IsDBNull(0) ? 0 : reader.GetInt32(0); // Obtiene el valor máximo o 0 si es nulo.
                    nextCode = maxIdFacDet + 1; // Calcula el siguiente código.
                    lblCodFacDet.Text = nextCode.ToString(); // Asigna el nuevo código al label.
                }
            }
            else
            {
                nextCode = 1; // Asigna el valor 1 si no existen registros.
                lblCodFacDet.Text = nextCode.ToString(); // Asigna el nuevo código al label.
            }

            reader.Close(); // Cierra el lector de datos.
        }

        private void btnGuardarFactura_Click(object sender, EventArgs e) // Evento que se ejecuta al hacer clic en el botón de guardar factura.
        {
            if (txtCodCit_Fac.Text == "") // Verifica si el campo de código de cita está vacío.
            {
                MessageBox.Show("Datos incompletos"); // Muestra un mensaje de advertencia.
                return; // Finaliza el método.
            }
            else
            {
                // No hace nada si el campo no está vacío.
            }

            int IdFac = int.Parse(lblFact.Text); // Obtiene el ID de la factura.
            DateTime FecFac = dtpFechaFactura.Value; // Obtiene la fecha de la factura.
            DateTime HorFac = dtpHoraFac.Value; // Obtiene la hora de la factura.
            int IdCit_Fac = int.Parse(txtCodCit_Fac.Text); // Obtiene el código de la cita.
            string NomUsr = (string)cbxUsr_Fac.SelectedValue; // Obtiene el nombre del usuario.

            // Inserta el encabezado de la factura en la base de datos.
            conexion.Modificaciones("exec Insertar_FacturaEncabezado '" + IdFac + " ', ' " + FecFac + " ', ' " + HorFac + " ', ' " + IdCit_Fac + " ', ' " + NomUsr + " ' ");

            // Recorre todas las filas del DataGridView.
            foreach (DataGridViewRow row in dgvAÑADIR.Rows)
            {
                int IdFacDet = int.Parse(row.Cells[0].Value.ToString()); // Obtiene el ID del detalle de la factura.
                int? IdTra = !string.IsNullOrEmpty(row.Cells[1].Value?.ToString()) ? int.Parse(row.Cells[1].Value.ToString()) : (int?)null; // Obtiene el ID del tratamiento.
                int? PreTra = !string.IsNullOrEmpty(row.Cells[3].Value?.ToString()) ? int.Parse(row.Cells[3].Value.ToString()) : (int?)null; // Obtiene el precio del tratamiento.
                int? IdPro = !string.IsNullOrEmpty(row.Cells[4].Value?.ToString()) ? int.Parse(row.Cells[4].Value.ToString()) : (int?)null; // Obtiene el ID del producto.
                int? CantPro = !string.IsNullOrEmpty(row.Cells[6].Value?.ToString()) ? int.Parse(row.Cells[6].Value.ToString()) : (int?)null; // Obtiene la cantidad del producto.
                int? PrePro = !string.IsNullOrEmpty(row.Cells[7].Value?.ToString()) ? int.Parse(row.Cells[7].Value.ToString()) : (int?)null; // Obtiene el precio del producto.

                // Inserta el detalle de la factura en la base de datos.
                conexion.InsertarFacturaDetalle(IdFacDet, IdFac, IdTra, PreTra, IdPro, CantPro, PrePro);
                // Disminuye el stock del producto en la base de datos.
                conexion.Modificaciones("exec DisminuirStockProducto ' " + IdPro + " ', ' " + CantPro + " ' ");
            }

            MessageBox.Show("La factura ha sido GUARDADA correctamente"); // Muestra un mensaje de éxito.

            dtpFechaFactura.ResetText(); // Restablece el texto del control de fecha.
            dtpHoraFac.ResetText(); // Restablece el texto del control de hora.

            AutonumFacDet(); // Actualiza el número de identificación del detalle de la factura.
            txtCodPro.Clear(); // Limpia el campo de código del producto.
            txtNomPro.Clear(); // Limpia el campo de nombre del producto.
            txtPrePro.Clear(); // Limpia el campo de precio del producto.
            nUdCanPro.Value = 0; // Restablece el valor del control de cantidad del producto.
            txtTotalPro.Clear(); // Limpia el campo de total del producto.
            txtCodTra.Clear(); // Limpia el campo de código del tratamiento.
            txtTra.Clear(); // Limpia el campo de tratamiento.
            txtPreTra.Clear(); // Limpia el campo de precio del tratamiento.

            string hora = DateTime.Now.ToLongTimeString(); // Obtiene la hora actual.
            string fecha = DateTime.Now.ToShortDateString(); // Obtiene la fecha actual.
            string accion = "Se guardó una factura"; // Define la acción realizada.
            string usuario = SistemaAutenticacion.NombreUsuarioLogueado; // Obtiene el nombre de usuario actual.

            // Registra la acción en la bitácora.
            conexion.Modificaciones("exec Insertar_Bitacoras  '" + fecha + "', '" + hora + "', '" + accion + "','" + usuario + "' ");

            FrmReporteFactura frmReporteFactura = new FrmReporteFactura(IdFac); // Crea una nueva instancia del formulario de reporte de factura.
            frmReporteFactura.Show(); // Muestra el formulario de reporte de factura.
        }

        private void FrmFactura_Load(object sender, EventArgs e) // Evento que se ejecuta al cargar el formulario.
        {
            Autonum(); // Autonumera la factura.
            AutonumFacDet(); // Autonumera el detalle de la factura.
            conexion.mostrasusuarios(cbxUsr_Fac); // Muestra los usuarios en el ComboBox.
        }

        private void btnSalirMarca_Click(object sender, EventArgs e) // Evento que se ejecuta al hacer clic en el botón de salir.
        {
            Form H = new FrmMenuPrincipal(); // Crea una nueva instancia del formulario del menú principal.
            H.Show(); // Muestra el formulario del menú principal.
        }

        private void btnModificarFactura_Click(object sender, EventArgs e) // Evento que se ejecuta al hacer clic en el botón de modificar factura.
        {
            if (!UtilidadesSeguridad.EsAdministrador(SistemaAutenticacion.NombreUsuarioLogueado)) // Verifica si el usuario actual es un administrador.
            {
                MessageBox.Show("No tienes permiso para realizar esta acción."); // Muestra un mensaje de advertencia si el usuario no es administrador.
                return; // Termina la ejecución del método si el usuario no es administrador.
            }

            if (txtCodCit_Fac.Text == "") // Verifica si el campo de código de cita está vacío.
            {
                MessageBox.Show("Datos incompletos"); // Muestra un mensaje de advertencia.
                return; // Finaliza el método.
            }
            else
            {
                // No hace nada si el campo no está vacío.
            }

            int IdFac = int.Parse(lblFact.Text); // Obtiene el ID de la factura.
            DateTime FecFac = dtpFechaFactura.Value; // Obtiene la fecha de la factura.
            DateTime HorFac = dtpHoraFac.Value; // Obtiene la hora de la factura.
            int IdCit_Fac = int.Parse(txtCodCit_Fac.Text); // Obtiene el código de la cita.
            string NomUsr = (string)cbxUsr_Fac.SelectedValue; // Obtiene el nombre del usuario.

            int IdFacDet = int.Parse(lblCodFacDet.Text); // Obtiene el ID del detalle de la factura del label correspondiente.

            int? IdPro = null; // Declara una variable nullable para el ID del producto.
            if (!string.IsNullOrEmpty(txtCodPro.Text)) // Verifica si el campo de código de producto no está vacío.
            {
                IdPro = int.Parse(txtCodPro.Text); // Asigna el valor del campo de código de producto a la variable IdPro.
            }

            int? IdTra = null; // Declara una variable nullable para el ID del tratamiento.
            if (!string.IsNullOrEmpty(txtCodTra.Text)) // Verifica si el campo de código de tratamiento no está vacío.
            {
                IdTra = int.Parse(txtCodTra.Text); // Asigna el valor del campo de código de tratamiento a la variable IdTra.
            }

            int? PrePro = null; // Declara una variable nullable para el precio del producto.
            if (!string.IsNullOrEmpty(txtPrePro.Text)) // Verifica si el campo de precio del producto no está vacío.
            {
                PrePro = int.Parse(txtPrePro.Text); // Asigna el valor del campo de precio del producto a la variable PrePro.
            }

            int? TotPro = null; // Declara una variable nullable para el total del producto.
            if (!string.IsNullOrEmpty(txtTotalPro.Text)) // Verifica si el campo de total del producto no está vacío.
            {
                TotPro = int.Parse(txtTotalPro.Text); // Asigna el valor del campo de total del producto a la variable TotPro.
            }

            int? PreTra = null; // Declara una variable nullable para el precio del tratamiento.
            if (!string.IsNullOrEmpty(txtPreTra.Text)) // Verifica si el campo de precio del tratamiento no está vacío.
            {
                PreTra = int.Parse(txtPreTra.Text); // Asigna el valor del campo de precio del tratamiento a la variable PreTra.
            }

            int? CantPro = null; // Declara una variable nullable para la cantidad del producto.
            if (!string.IsNullOrEmpty(nUdCanPro.Text)) // Verifica si el campo de cantidad del producto no está vacío.
            {
                CantPro = int.Parse(nUdCanPro.Text); // Asigna el valor del campo de cantidad del producto a la variable CantPro.
            }

            // Actualiza el encabezado de la factura en la base de datos.
            conexion.Modificaciones("exec Actualizar_FacturaEncabezado '" + IdFac + " ', ' " + FecFac + " ', ' " + HorFac + " ', ' " + IdCit_Fac + " ', ' " + NomUsr + " ' ");

            conexion.ActualizarFacturaDetalle(IdFacDet, IdFac, IdTra, PreTra, IdPro, CantPro, PrePro); // Llama al método para actualizar el detalle de la factura en la base de datos.
            MessageBox.Show("La factura ha sido ACTUALIZADA correctamente"); // Muestra un mensaje de éxito.

            dtpFechaFactura.ResetText(); // Restablece el texto de la fecha de la factura.
            dtpHoraFac.ResetText(); // Restablece el texto de la hora de la factura.

            AutonumFacDet(); // Llama al método para autogenerar el número de detalle de factura.
            txtCodPro.Clear(); // Limpia el campo de código de producto.
            txtNomPro.Clear(); // Limpia el campo de nombre de producto.
            txtPrePro.Clear(); // Limpia el campo de precio de producto.
            nUdCanPro.Value = 0; // Restablece el valor de la cantidad de producto.
            txtTotalPro.Clear(); // Limpia el campo de total de producto.
            txtCodTra.Clear(); // Limpia el campo de código de tratamiento.
            txtTra.Clear(); // Limpia el campo de tratamiento.
            txtPreTra.Clear(); // Limpia el campo de precio de tratamiento.

            string hora = DateTime.Now.ToLongTimeString(); // Obtiene la hora actual.
            string fecha = DateTime.Now.ToShortDateString(); // Obtiene la fecha actual.
            string accion = "Se actualizó una factura detalle"; // Define la acción realizada.
            string usuario = SistemaAutenticacion.NombreUsuarioLogueado; // Obtiene el nombre de usuario actual.

            conexion.Modificaciones("exec Insertar_Bitacoras  '" + fecha + "', '" + hora + "', '" + accion + "','" + usuario + "' "); // Inserta la acción en la bitácora.
        }


        private void btnEliminarFactura_Click(object sender, EventArgs e) // Evento que se ejecuta al hacer clic en el botón de eliminar factura.
        {
            if (MessageBox.Show("¿Seguro que quieres ELIMINAR esta factura encabezado?", "Eliminar factura encabezado", MessageBoxButtons.YesNo) == DialogResult.Yes) // Confirma la eliminación de la factura.
            {
                int IdFac = int.Parse(lblFact.Text); // Obtiene el ID de la factura.
                conexion.Modificaciones("exec Eliminar_FacturaEncabezado '" + IdFac + "'"); // Elimina el encabezado de la factura en la base de datos.
                MessageBox.Show("La factura encabezado ha sido ELIMINADA"); // Muestra un mensaje de éxito.
                Autonum(); // Actualiza el número de identificación de la factura.

                string hora = DateTime.Now.ToLongTimeString(); // Obtiene la hora actual.
                string fecha = DateTime.Now.ToShortDateString(); // Obtiene la fecha actual.
                string accion = "Se eliminó una factura"; // Define la acción realizada.
                string usuario = SistemaAutenticacion.NombreUsuarioLogueado; // Obtiene el nombre de usuario actual.

                // Registra la acción en la bitácora.
                conexion.Modificaciones("exec Insertar_Bitacoras  '" + fecha + "', '" + hora + "', '" + accion + "','" + usuario + "' ");
            }
        }

        private void dgvFacDetalle_CellContentClick(object sender, DataGridViewCellEventArgs e) // Evento que se ejecuta al hacer clic en el contenido de una celda en el DataGridView de detalles de factura.
        {
            // Implementación vacía.
        }

        private void btnGuardarFacDetalle_Click(object sender, EventArgs e) // Evento que se ejecuta al hacer clic en el botón de guardar detalle de factura.
        {
            // Implementación vacía.
        }

        private void dgvFacDetalle_CellEndEdit(object sender, DataGridViewCellEventArgs e) // Evento que se ejecuta al terminar de editar una celda en el DataGridView de detalles de factura.
        {
            // Implementación vacía.
        }

        private void dgvFacDetalle_RowEnter(object sender, DataGridViewCellEventArgs e) // Evento que se ejecuta al entrar en una fila en el DataGridView de detalles de factura.
        {
            // Implementación vacía.
        }

        private void button1_Click(object sender, EventArgs e) // Evento que se ejecuta al hacer clic en el botón de búsqueda de productos.
        {
            using (BuscarProductos formBusqueda = new BuscarProductos()) // Crea una nueva instancia del formulario de búsqueda de productos.
            {
                formBusqueda.ShowDialog(); // Muestra el formulario de búsqueda de productos como un cuadro de diálogo.

                if (formBusqueda.ProductoSeleccionado != null) // Verifica si se ha seleccionado un producto.
                {
                    txtCodPro.Text = formBusqueda.ProductoSeleccionado.Codigo.ToString(); // Establece el código del producto seleccionado.
                    txtNomPro.Text = formBusqueda.ProductoSeleccionado.Nombre; // Establece el nombre del producto seleccionado.
                    txtPrePro.Text = formBusqueda.ProductoSeleccionado.Precio.ToString(); // Establece el precio del producto seleccionado.
                }
            }
        }

        private void button2_Click(object sender, EventArgs e) // Evento que se ejecuta al hacer clic en el botón de buscar tratamiento.
        {
            using (BuscarTratamiento formBusqueda = new BuscarTratamiento()) // Crea una nueva instancia del formulario de búsqueda de tratamientos.
            {
                formBusqueda.ShowDialog(); // Muestra el formulario de búsqueda de tratamientos como un cuadro de diálogo.

                if (formBusqueda.TratamientoSeleccionado != null) // Verifica si se ha seleccionado un tratamiento.
                {
                    txtCodTra.Text = formBusqueda.TratamientoSeleccionado.Codigo.ToString(); // Establece el código del tratamiento seleccionado.
                    txtTra.Text = formBusqueda.TratamientoSeleccionado.Nombre; // Establece el nombre del tratamiento seleccionado.
                    txtPreTra.Text = formBusqueda.TratamientoSeleccionado.Precio.ToString(); // Establece el precio del tratamiento seleccionado.
                }
            }
        }

        private int subtotalProductos = 0; // Inicializa el subtotal de productos.
        private int subtotalTratamientos = 0; // Inicializa el subtotal de tratamientos.
        private int impuesto = 0; // Inicializa el impuesto.
        private int totalFinal = 0; // Inicializa el total final.

        private List<int> totalesProductos = new List<int>(); // Inicializa la lista de totales de productos.
        private List<int> preciosTratamientos = new List<int>(); // Inicializa la lista de precios de tratamientos.

        private void CalcularTotal() // Método para calcular el total.
        {
            subtotalProductos = totalesProductos.Sum(); // Calcula la suma de los totales de productos.

            subtotalTratamientos = preciosTratamientos.Sum(); // Calcula la suma de los precios de tratamientos.

            impuesto = (int)(subtotalProductos * 0.15m); // Calcula el impuesto sobre los productos.

            totalFinal = subtotalProductos + subtotalTratamientos + impuesto; // Calcula el total final.

            lblSubTotal.Text = (subtotalProductos + subtotalTratamientos).ToString(); // Muestra el subtotal.
            lblImpuesto.Text = impuesto.ToString(); // Muestra el impuesto.
            lblTotal.Text = totalFinal.ToString(); // Muestra el total final.
        }

        private void btnTotPro_Click(object sender, EventArgs e) // Evento que se ejecuta al hacer clic en el botón de calcular total de producto.
        {
            int cantidad; // Declara la variable para la cantidad.
            int precio; // Declara la variable para el precio.
            int total; // Declara la variable para el total.

            if (int.TryParse(nUdCanPro.Text, out cantidad)) // Intenta convertir el texto de cantidad a un entero.
            {
                if (int.TryParse(txtPrePro.Text, out precio)) // Intenta convertir el texto de precio a un entero.
                {
                    total = cantidad * precio; // Calcula el total.
                    txtTotalPro.Text = total.ToString(); // Muestra el total en el campo de texto.

                    totalesProductos.Add(total); // Agrega el total a la lista de totales de productos.

                    CalcularTotal(); // Llama al método para calcular el total.
                }
                else
                {
                    MessageBox.Show("Por favor, ingrese un valor numérico válido en el campo de precio."); // Muestra un mensaje de advertencia.
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un valor numérico válido en el campo de cantidad."); // Muestra un mensaje de advertencia.
            }
        }

        private void button2_Click_1(object sender, EventArgs e) // Evento que se ejecuta al hacer clic en el botón de buscar citas.
        {
            using (BuscarCitas formBusqueda = new BuscarCitas()) // Crea una nueva instancia del formulario de búsqueda de citas.
            {
                formBusqueda.ShowDialog(); // Muestra el formulario de búsqueda de citas como un cuadro de diálogo.

                if (formBusqueda.CitaSeleccionado != null) // Verifica si se ha seleccionado una cita.
                {
                    txtCodCit_Fac.Text = formBusqueda.CitaSeleccionado.Codigo.ToString(); // Establece el código de la cita seleccionada.
                    txtPac.Text = formBusqueda.CitaSeleccionado.Nombre; // Establece el nombre del paciente de la cita seleccionada.
                    txtApePac.Text = formBusqueda.CitaSeleccionado.Apellido; // Establece el apellido del paciente de la cita seleccionada.
                }
            }
        }

        private void txtBuscarFacDetalle_TextChanged(object sender, EventArgs e) // Evento que se ejecuta al cambiar el texto en el campo de búsqueda de detalle de factura.
        {
            // Implementación vacía.
        }

        private void btnCalcularCambio_Click(object sender, EventArgs e) // Evento que se ejecuta al hacer clic en el botón de calcular cambio.
        {
            CalcularCambio(); // Llama al método para calcular el cambio.
        }

        private void CalcularCambio() // Método para calcular el cambio.
        {
            if (!string.IsNullOrEmpty(txtEfectivo.Text)) // Verifica si el campo de efectivo no está vacío.
            {
                int efectivo = int.Parse(txtEfectivo.Text); // Obtiene el valor del efectivo.
                int total = int.Parse(lblTotal.Text); // Obtiene el valor del total.
                int cambio = efectivo - total; // Calcula el cambio.
                lblCambio.Text = cambio.ToString(); // Muestra el cambio en el campo de texto.
            }
        }

        private void btnPrecTra_Click(object sender, EventArgs e) // Evento que se ejecuta al hacer clic en el botón de agregar precio de tratamiento.
        {
            int precioTratamiento; // Declara la variable para el precio del tratamiento.
            if (int.TryParse(txtPreTra.Text, out precioTratamiento)) // Intenta convertir el texto del precio de tratamiento a un entero.
            {
                preciosTratamientos.Add(precioTratamiento); // Agrega el precio del tratamiento a la lista de precios de tratamientos.

                CalcularTotal(); // Llama al método para calcular el total.
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un valor numérico válido en el campo de precio del tratamiento."); // Muestra un mensaje de advertencia.
            }
        }

        private void LimpiarCamposEspecificos() // Método para limpiar campos específicos del formulario.
        {
            Autonum(); // Llama al método para autogenerar el número de factura.
            txtCodCit_Fac.Clear(); // Limpia el campo de código de cita.
            txtPac.Clear(); // Limpia el campo de nombre del paciente.
            lblSubTotal.Text = ""; // Limpia el campo de subtotal.
            lblImpuesto.Text = ""; // Limpia el campo de impuesto.
            lblTotal.Text = ""; // Limpia el campo de total.
            txtEfectivo.Clear(); // Limpia el campo de efectivo.
            lblCambio.Text = ""; // Limpia el campo de cambio.
            dgvAÑADIR.Rows.Clear(); // Limpia todas las filas del DataGridView.
        }

        private void btnLimpiarFac_Click(object sender, EventArgs e) // Evento que se ejecuta al hacer clic en el botón de limpiar factura.
        {
            LimpiarCamposEspecificos(); // Llama al método para limpiar campos específicos.
        }

        private void btnAgregarDetalle_Click(object sender, EventArgs e) // Evento que se ejecuta al hacer clic en el botón de agregar detalle.
        {
            // Implementación vacía.
        }

        private void btnGuardarDetalle_Click(object sender, EventArgs e) // Evento que se ejecuta al hacer clic en el botón de guardar detalle.
        {
            // Implementación vacía.
        }

        private void btnGuardarFacturaEncabezado_Click(object sender, EventArgs e) // Evento que se ejecuta al hacer clic en el botón de guardar encabezado de factura.
        {
            // Implementación vacía.
        }

        private void btnSoloDetalle_Click(object sender, EventArgs e) // Evento que se ejecuta al hacer clic en el botón de guardar solo detalle.
        {
            int IdFac = int.Parse(lblFact.Text); // Obtiene el ID de la factura.
            foreach (DataGridViewRow row in dgvAÑADIR.Rows) // Itera sobre cada fila en el DataGridView.
            {
                int IdFacDet = int.Parse(row.Cells[0].Value.ToString()); // Obtiene el ID del detalle de la factura.
                int? IdTra = !string.IsNullOrEmpty(row.Cells[1].Value?.ToString()) ? int.Parse(row.Cells[1].Value.ToString()) : (int?)null; // Obtiene el ID del tratamiento si existe.
                int? PreTra = !string.IsNullOrEmpty(row.Cells[3].Value?.ToString()) ? int.Parse(row.Cells[3].Value.ToString()) : (int?)null; // Obtiene el precio del tratamiento si existe.
                int? IdPro = !string.IsNullOrEmpty(row.Cells[4].Value?.ToString()) ? int.Parse(row.Cells[4].Value.ToString()) : (int?)null; // Obtiene el ID del producto si existe.
                int? CantPro = !string.IsNullOrEmpty(row.Cells[6].Value?.ToString()) ? int.Parse(row.Cells[6].Value.ToString()) : (int?)null; // Obtiene la cantidad del producto si existe.
                int? PrePro = !string.IsNullOrEmpty(row.Cells[7].Value?.ToString()) ? int.Parse(row.Cells[7].Value.ToString()) : (int?)null; // Obtiene el precio del producto si existe.

                conexion.InsertarFacturaDetalle(IdFacDet, IdFac, IdTra, PreTra, IdPro, CantPro, PrePro); // Inserta el detalle de la factura en la base de datos.
            }

            MessageBox.Show("La factura detalle ha sido GUARDADA correctamente"); // Muestra un mensaje de éxito.
            dtpFechaFactura.ResetText(); // Restablece el texto de la fecha de la factura.
            dtpHoraFac.ResetText(); // Restablece el texto de la hora de la factura.

            AutonumFacDet(); // Llama al método para autogenerar el número de detalle de factura.
            txtCodPro.Clear(); // Limpia el campo de código de producto.
            txtNomPro.Clear(); // Limpia el campo de nombre de producto.
            txtPrePro.Clear(); // Limpia el campo de precio de producto.
            nUdCanPro.Value = 0; // Restablece el valor de la cantidad de producto.
            txtTotalPro.Clear(); // Limpia el campo de total de producto.
            txtCodTra.Clear(); // Limpia el campo de código de tratamiento.
            txtTra.Clear(); // Limpia el campo de tratamiento.
            txtPreTra.Clear(); // Limpia el campo de precio de tratamiento.

            string hora = DateTime.Now.ToLongTimeString(); // Obtiene la hora actual.
            string fecha = DateTime.Now.ToShortDateString(); // Obtiene la fecha actual.
            string accion = "Se guardó una factura detalle"; // Define la acción realizada.
            string usuario = SistemaAutenticacion.NombreUsuarioLogueado; // Obtiene el nombre de usuario actual.

            conexion.Modificaciones("exec Insertar_Bitacoras  '" + fecha + "', '" + hora + "', '" + accion + "','" + usuario + "' "); // Inserta la acción en la bitácora.
        }

        private void dgvFactura_CellClick(object sender, DataGridViewCellEventArgs e) // Evento que se ejecuta al hacer clic en una celda del DataGridView de factura.
        {
            // Implementación vacía.
        }

        private void btnModificarDetalle_Click(object sender, EventArgs e) // Evento que se ejecuta al hacer clic en el botón de modificar detalle.
        {
            // Implementación vacía.
        }

        private int nextCode = 1; // Declara e inicializa la variable nextCode en 1 para llevar el código del próximo detalle a añadir

        private void btnAñadir_Click(object sender, EventArgs e) // Evento que se activa al hacer clic en el botón "Añadir"
        {
            decimal? cantPro = nUdCanPro.Value != 0 ? (decimal?)nUdCanPro.Value : null; // Obtiene y convierte la cantidad de producto, asignando null si es cero
            decimal? precPro = !string.IsNullOrEmpty(txtPrePro.Text) ? decimal.Parse(txtPrePro.Text) : (decimal?)null; // Obtiene y convierte el precio del producto, asignando null si está vacío
            decimal? precTra = !string.IsNullOrEmpty(txtPreTra.Text) ? decimal.Parse(txtPreTra.Text) : (decimal?)null; // Obtiene y convierte el precio del tratamiento, asignando null si está vacío

            decimal? totalProducto = (cantPro.HasValue && precPro.HasValue) ? cantPro * precPro : (decimal?)null; // Calcula el total del producto multiplicando la cantidad por el precio, asignando null si alguno de los valores es null

            decimal? totalParcial; // Declaración de la variable para almacenar el total parcial

            if (precTra.HasValue) // Comprueba si hay un precio de tratamiento
            {
                totalParcial = precTra + (totalProducto ?? 0); // Calcula el total parcial sumando el precio del tratamiento al total del producto, si el total del producto es null, se toma como 0
            }
            else
            {
                totalParcial = totalProducto; // Si no hay precio de tratamiento, el total parcial es igual al total del producto
            }

            lblCodFacDet.Text = nextCode.ToString(); // Establece el código del próximo detalle en la etiqueta lblCodFacDet

            dgvAÑADIR.Rows.Add(
                lblCodFacDet.Text, // Añade el código del detalle a la fila del DataGridView
                txtCodTra.Text, // Añade el código del tratamiento a la fila del DataGridView
                txtTra.Text, // Añade el nombre del tratamiento a la fila del DataGridView
                txtPreTra.Text, // Añade el precio del tratamiento a la fila del DataGridView
                txtCodPro.Text, // Añade el código del producto a la fila del DataGridView
                txtNomPro.Text, // Añade el nombre del producto a la fila del DataGridView
                cantPro.HasValue ? (object)cantPro.Value : DBNull.Value, // Añade la cantidad del producto a la fila del DataGridView o DBNull si no hay valor
                precPro.HasValue ? (object)precPro.Value : DBNull.Value, // Añade el precio del producto a la fila del DataGridView o DBNull si no hay valor
                totalProducto.HasValue ? (object)totalProducto.Value : DBNull.Value, // Añade el total del producto a la fila del DataGridView o DBNull si no hay valor
                totalParcial.HasValue ? (object)totalParcial.Value : DBNull.Value // Añade el total parcial (tratamiento + producto) a la fila del DataGridView o DBNull si no hay valor
            );

            nextCode++; // Incrementa el contador de código para el próximo detalle

            // Limpia los campos de entrada de datos
            txtCodTra.Clear(); // Limpia el cuadro de texto del código de tratamiento
            txtTra.Clear(); // Limpia el cuadro de texto del nombre del tratamiento
            txtPreTra.Clear(); // Limpia el cuadro de texto del precio del tratamiento
            txtCodPro.Clear(); // Limpia el cuadro de texto del código del producto
            txtNomPro.Clear(); // Limpia el cuadro de texto del nombre del producto
            nUdCanPro.Value = 0; // Restablece el valor del control de cantidad del producto a cero
            txtPrePro.Clear(); // Limpia el cuadro de texto del precio del producto

            // Registra la acción en la bitácora de cambios
            string hora = DateTime.Now.ToLongTimeString(); // Obtiene la hora actual en formato de cadena larga
            string fecha = DateTime.Now.ToShortDateString(); // Obtiene la fecha actual en formato de cadena corta
            string accion = "Se añadió un detalle a la factura"; // Describe la acción realizada
            string usuario = SistemaAutenticacion.NombreUsuarioLogueado; // Obtiene el nombre del usuario autenticado
            conexion.Modificaciones("exec Insertar_Bitacoras  '" + fecha + "', '" + hora + "', '" + accion + "','" + usuario + "' "); // Inserta un registro en la tabla de bitácora
        }

        private void dgvAÑADIR_CellClick(object sender, DataGridViewCellEventArgs e) // Evento que se activa al hacer clic en una celda del DataGridView dgvAÑADIR
        {
            try
            {
                // Muestra los detalles del producto y tratamiento seleccionado en los campos correspondientes
                lblCodFacDet.Text = dgvAÑADIR.CurrentRow.Cells[0].Value.ToString(); // Muestra el código del detalle
                txtCodTra.Text = dgvAÑADIR.CurrentRow.Cells[1].Value.ToString(); // Muestra el código del tratamiento
                txtTra.Text = dgvAÑADIR.CurrentRow.Cells[2].Value.ToString(); // Muestra el nombre del tratamiento
                txtPreTra.Text = dgvAÑADIR.CurrentRow.Cells[3].Value.ToString(); // Muestra el precio del tratamiento
                txtCodPro.Text = dgvAÑADIR.CurrentRow.Cells[4].Value.ToString(); // Muestra el código del producto
                txtNomPro.Text = dgvAÑADIR.CurrentRow.Cells[5].Value.ToString(); // Muestra el nombre del producto
                nUdCanPro.Text = dgvAÑADIR.CurrentRow.Cells[6].Value.ToString(); // Muestra la cantidad del producto
                txtPrePro.Text = dgvAÑADIR.CurrentRow.Cells[7].Value.ToString(); // Muestra el precio del producto
            }
            catch
            {
                // Maneja cualquier excepción que pueda ocurrir al intentar acceder a los datos de la fila seleccionada
            }
        }



        private void groupBox6_Enter(object sender, EventArgs e)
        {
            // Implementación vacía.
        }

    }
}

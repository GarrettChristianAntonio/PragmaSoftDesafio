using Controllers;

namespace View
{
    public partial class AdministradorSeries : Form
    {


        //Inyección de dependencias
        private readonly ILogic _logic;
        public AdministradorSeries(ILogic logic)
        {
            _logic = logic;
            InitializeComponent();
        }



        //Boton consultar        
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            ActualizarGrilla();
        }



        //Boton Agregar se le pasa la referencia del formulario actual "AdministradorSeries" al formulario "AgregarModificar" a travez del constructor para poder actualizar la grilla desde éste último.
        //También se le pasa la referencia de la instancia de la interfaz para el acceso a la información
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            new AgregarModificar(this, _logic).ShowDialog();
        }



        //Boton Modificar se verifica que se encuentre seleccionada una lista de la grilla con el metodo HayFilaSeleccionada, luego se verifica sí el estado de la fila selecciónada es igual a 'AN' no puede modificarse.
        //De lo contrario se pasa la referencia del formulario actual "AdministradorSeries" al formulario "AgregarModificar" a travez del constructor para poder actualizar la grilla desde éste último.
        //Tambien se le pasa la referencia de la instancia de la interfaz para el acceso a la información, Se le pasa los datos de la fila seleccionada
        //Debido a posibles problemas en la implementación se utiliza un bloque para manejar posibles de excepciones.        
        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (HayFilaSeleccionada())
                {
                    if (dataGridView1.SelectedRows[0].Cells["Estado"].Value.ToString() == "AN") { MessageBox.Show("No se puede modificar una serie anulada"); }
                    else
                    {
                        new AgregarModificar(_logic, dataGridView1.SelectedRows[0], this).ShowDialog();
                    }
                }
            }
            catch (Exception es) { MessageBox.Show("error" + es); }

        }


        //Metodo ActualizarGrilla se crea el metodo mismo con el motivo de reutilizar el código
        //Además como los registros al igual que las columnas de la grilla son almacenados con el resultado de una consulta de la base de datos
        //se oculta la columna id y se desativa el check de la columna "ATP" tal como se muestra en el video instructivo del desafio.
        //Debido a posibles problemas en la implementación se utiliza un bloque para manejar posibles de excepciones.
        public void ActualizarGrilla()
        {
            try
            {
                dataGridView1.DataSource = _logic.ObtenerServicios();
                if (dataGridView1.Columns.Contains("Id"))
                {
                    dataGridView1.Columns["Id"].Visible = false;
                    dataGridView1.MultiSelect = false;
                    lblSinRegistro.Visible=false;
                }
                if (dataGridView1.Columns.Contains("ATP"))
                {
                    dataGridView1.Columns["ATP"].ReadOnly = true;
                }
            }
            catch (Exception es) { MessageBox.Show("error" + es); }
        }



        //El Boton "Anular" :Verifica si hay fila seleccionada con el metodo "HayFilaSeleccionada"
        //Verifica Se implementa un bloque condicional donde si el valor de la columna "Estado" de la fila seleecionada es igual a 'AN'(Serie Anulada) mostrar menssage "El registro ya fue anulado"
        //Se implementa un mensageBox que implementan botones y se verifica a travez de un bloque condicional la respuesta del cliente
        //Si la respuesta del cliente es continuar: se almacena el valor de la columna "Id" la almacena en una variable y se la enviamos al metodo Anular implementado en la capa logica que nos retorna un...
        //booleano como respuesta de un metodo de la capa de datos verificando si la consulta fue exitosa.        
        //al final mostramos mensage de la operación y actualizamos la grilla
        private void btnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                if (HayFilaSeleccionada())
                {
                    if (dataGridView1.SelectedRows[0].Cells["Estado"].Value.ToString() == "AN") { MessageBox.Show("El Registro se encuentra anulado"); }
                    else
                    {
                        DialogResult result = MessageBox.Show("¿Quieres continuar?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            string columnaSeleccionada = dataGridView1.SelectedRows[0].Cells["Id"].Value.ToString();
                            if (_logic.Anular(columnaSeleccionada))
                            {
                                MessageBox.Show("Serie Anulada");
                                ActualizarGrilla();
                            }
                        }
                    }
                }
            }
            catch (Exception es) { MessageBox.Show("error" + es); }
        }


        //Similar al botonAnular, pero no preguntamos el estado del registro y utilizamos el metodo Eliminar de la capa logica que tiene el mismo comportamiento.
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (HayFilaSeleccionada())
                {
                    DialogResult result = MessageBox.Show("¿Quieres continuar?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        string columnaSeleccionada = dataGridView1.SelectedRows[0].Cells["Id"].Value.ToString();
                        if (_logic.Eliminar(columnaSeleccionada))
                        {
                            MessageBox.Show("Serie Eliminada");
                            ActualizarGrilla();
                        }
                    }
                }
            }
            catch (Exception es) { MessageBox.Show("error" + es); }
        }


        //Boton para salir
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        //Suscripción al evento del boton X para que termine la ejecución del programa en vez de cerrar el formulario.
        private void AdministradorSeries_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }


        //Metodo implementado con la finalidad de reutilización de código que sirve para verificar si hay una fila seleccionada.
        private bool HayFilaSeleccionada()
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una fila antes de realizar esta acción.");
                return false;
            }
        }
    }
}

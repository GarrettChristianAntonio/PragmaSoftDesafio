using Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    //En este formulario es reutilizado para agregar o modificar una serie y el comportamiento esta definido por las sobrecargas del constructor
    public partial class AgregarModificar : Form
    {
        private readonly ILogic _logic; //inyeccion de dependencias
        private List<string> _genero; // con el proposito de almacenar los distintos generos de los registros, resultado de una consulta a la base de datos para luego almacenarlos en el combobox
        Dictionary<string, object> dic; //Se reutiliza en las acciones agregar o modificar para enviarle el contenido de los "inputs" a la capa de logica 
        private AdministradorSeries _adminstradorSeries; //Se utiliza para almacenar la referencia del controlador y así poder utilizar el metodo ActualizarGrilla


        //Constructor utilizado con el Boton Modificar
        //recibe:
        //      la referencia de la instancia de la interfaz
        //       DataGridViewRow que contiene la información de la fila seleccionada en el formulario que sera introducida en éste
        //       administradorSeries referencia de la instancia del formulario para poder utilizar metodos
        //       Se deshabilita y oculta el boton "AceptarAgregar" que es parte de la accion agregar Serie
        public AgregarModificar(ILogic logic, DataGridViewRow datarow, AdministradorSeries administradorSerie)
        {
            _logic = logic;
            _adminstradorSeries = administradorSerie;
            InitializeComponent();
            btnAceptarAgregar.Enabled = false;
            btnAceptarAgregar.Visible = false;
            cbGenero.DataSource = _logic.ObtenerGeneros();//obtiene los distintos valores de genero con el resultado de una consulta a la base de datos y los almacena en la lista 
            PasarData(datarow);
            this.Text = "Modificar Serie";
        }


        //Constructor utilizado con el boton Agregar
        //recibe la referencia del formulario para utlizar el metodo actualizarGrilla
        // la referencia de la instancia de la interfaz
        // deshabilita y oculta el boton "btnAceptar" que es parte de la accion Modificar Serie
        public AgregarModificar(AdministradorSeries administradorSerie, ILogic logic)
        {
            _logic = logic;
            _adminstradorSeries = administradorSerie;
            InitializeComponent();
            cbGenero.DataSource = _logic.ObtenerGeneros();
            btnAceptar.Enabled = false;
            btnAceptar.Visible = false;
            this.Text = "Agregar Serie";
        }


        //Metodo implementado con el objetivo de reutilización de código.
        public void PasarData(DataGridViewRow datarow)
        {
            try
            {
                dic = new Dictionary<string, object>();
                dic.Add("Id", datarow.Cells["Id"].Value.ToString());
                txtTitulo.Text = datarow.Cells["Titulo"].Value.ToString();
                rTxtDescripcion.Text = datarow.Cells["Descripcion"].Value.ToString();
                dtpFechaDeEstreno.Value = (DateTime)datarow.Cells["FechaEstreno"].Value;
                cbGenero.SelectedItem = datarow.Cells["Genero"].Value.ToString();
                txtPrecioAlquiler.Text = datarow.Cells["PrecioAlquiler"].Value.ToString();
                txtEstrellas.Text = datarow.Cells["Estrellas"].Value.ToString();
                cbATP.Checked = (bool)datarow.Cells["ATP"].Value;
            }
            catch (Exception es) { MessageBox.Show("error" + es); }
        }

        //Cierra solo el formulario actual
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //el boton btnAceptar es parte de la acción Modificar Serie
        //se verifica que todos los campos sean requeridos
        //se añaden los campos a un diccionario
        //se utiliza el metodo Modificar de la capa logica enviandole el diccionario que retorna un booleano
        //se verifica si fue exitosa la operación y se muestra mensage.
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (verificarInputs())
                {
                    dic.Add("Titulo", txtTitulo.Text);
                    dic.Add("Descripcion", rTxtDescripcion.Text);
                    dic.Add("FechaEstreno", dtpFechaDeEstreno.Value);
                    dic.Add("Genero", cbGenero.SelectedItem);
                    dic.Add("PrecioAlquiler", txtPrecioAlquiler.Text);
                    dic.Add("Estrellas", txtEstrellas.Text);
                    dic.Add("ATP", cbATP.Checked);
                    if (_logic.Modificar(dic))
                    {
                        MessageBox.Show("Serie Modificada exitosamente.");
                        _adminstradorSeries.ActualizarGrilla();
                        this.Close();
                    }
                }
            }
            catch (Exception es) { MessageBox.Show("error" + es); }
        }

        //el boton btnAceptar es parte de la acción Agregar Serie
        //se verifica que todos los campos sean requeridos
        //se añaden los campos a un diccionario
        //se utiliza el metodo Modificar de la capa logica enviandole el diccionario que retorna un booleano
        //se verifica si fue exitosa la operación y se muestra mensage.
        private void btnAceptarAgregar_Click(object sender, EventArgs e)
        {
            if (verificarInputs())
            {
                dic = new Dictionary<string, object>();
                dic.Add("Titulo", txtTitulo.Text);
                dic.Add("Descripcion", rTxtDescripcion.Text);
                dic.Add("FechaEstreno", dtpFechaDeEstreno.Value);
                dic.Add("Genero", cbGenero.SelectedItem);
                dic.Add("PrecioAlquiler", txtPrecioAlquiler.Text);
                dic.Add("Estrellas", txtEstrellas.Text);
                dic.Add("ATP", cbATP.Checked);
                try
                {
                    if (_logic.Agregar(dic))
                    {
                        MessageBox.Show("Serie agregada exitosamente.");
                        _adminstradorSeries.ActualizarGrilla();
                        this.Close();
                    }
                }
                catch (Exception es) { MessageBox.Show("error" + es); }
            }
        }


        //metodo para reutilización de código
        private bool verificarInputs()
        {
            if (string.IsNullOrWhiteSpace(txtTitulo.Text))
            {
                MessageBox.Show("Error: El título es requerido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrWhiteSpace(rTxtDescripcion.Text))
            {
                MessageBox.Show("Error: La descripción es requerida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtEstrellas.Text))
            {
                MessageBox.Show("Error: Las estrellas son requeridas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtPrecioAlquiler.Text))
            {
                MessageBox.Show("Error: El precio de alquiler es requerido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }
}

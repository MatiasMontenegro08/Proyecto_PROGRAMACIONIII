using DOMINIO;
using NEGOCIO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRESENTACION
{
    public partial class frmVenta : Form
    {
        Venta registro;
        List<Venta> lista;
        public frmVenta()
        {
            InitializeComponent();
        }

        private void frmVenta_Load(object sender, EventArgs e)
        {
            try
            {
                CargarPlanilla();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidarDatos())
                {
                    return;
                }
                if (registro == null)
                {
                    registro = new Venta();
                }
                AsignarRegistro(registro);
                AgregarOmodificar(registro);
                CargarPlanilla();
                registro = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvLibro.CurrentRow != null)
            {
                Venta registroselec = new Venta();
                registroselec = (Venta)dgvLibro.CurrentRow.DataBoundItem;
                CargarDatos(registroselec);
                registro = registroselec;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvLibro.CurrentRow != null)
            {
                EliminarRegistro();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            FiltroDesdeHasta();
        }

        //MÉTODOS
        private void CargarPlanilla()
        {
            VentaNegocio negocio = new VentaNegocio();
            dgvLibro.DataSource = negocio.Listar();
            ocultarColumnas();
            lblValiDetalle.Text = "";
            lblValiFecha.Text = "";
            lblValiMonto.Text = "";
            Total();
        }
        private void Total()
        {
            VentaNegocio negocio = new VentaNegocio();
            decimal total = negocio.ObtenerTotal();
            lblResultado.Text = "$ " + total.ToString();
        }
        private void ocultarColumnas()
        {
            dgvLibro.Columns["Id"].Visible = false;
            dgvLibro.Columns["Total"].Visible = false;
        }
        private void EliminarRegistro()
        {
            VentaNegocio negocio = new VentaNegocio();
            Venta seleccionado;
            try
            {
                DialogResult respuesta = MessageBox.Show("Desea eliminar el registro seleccionado ? ", "Eliminar registro", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    seleccionado = (Venta)dgvLibro.CurrentRow.DataBoundItem;
                    negocio.EliminarFijo(seleccionado.Id);
                    CargarPlanilla();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void Limpiar()
        {
            txtDetalle.Clear();
            txtFecha.Clear();
            txtMonto.Clear();
            txtDesde.Clear();
            txtHasta.Clear();
            lblValiDetalle.Text = "";
            lblValiFecha.Text = "";
            lblValiMonto.Text = "";
            txtFecha.Focus();
            registro = null;
            CargarPlanilla();
        }
        private void CargarDatos(Venta registroselec)
        {
            txtDetalle.Text = registroselec.Detalle;
            txtFecha.Text = registroselec.Fecha;
            txtMonto.Text = registroselec.Monto.ToString();
        }
        private bool ValidarDatos()
        {
            if (txtFecha.Text == "")
            {
                lblValiFecha.Text = "Campo obligatorio*";
                txtFecha.Focus();
                return true;
            }
            if (txtDetalle.Text == "")
            {
                lblValiDetalle.Text = "Campo obligatorio*";
                txtDetalle.Focus();
                return true;
            }
            if (txtMonto.Text == "")
            {
                lblValiMonto.Text = "Campo obligatorio*";
                txtMonto.Focus();
                return true;
            }
            if (SoloNumero(txtMonto.Text))
            {
                return true;
            }
            return false;
        }
        private bool SoloNumero(string cadena)
        {
            decimal valor;
            if (!decimal.TryParse(txtMonto.Text, out valor))
            {
                MessageBox.Show("Ingresar solo números!");
                txtMonto.Focus();
                txtMonto.SelectAll();
                return true;
            }
            return false;
        }
        private void AsignarRegistro(Venta registro)
        {
            registro.Detalle = txtDetalle.Text;
            registro.Fecha = txtFecha.Text;
            registro.Monto = Convert.ToDecimal(txtMonto.Text);
        }
        private void AgregarOmodificar(Venta registro)
        {
            VentaNegocio negocio = new VentaNegocio();
            if (registro.Id != 0)
            {
                negocio.Modificar(registro);
                MessageBox.Show("Registro modificado!");
                Limpiar();
            }
            else
            {
                negocio.Agregar(registro);
                MessageBox.Show("Registro agregado!");
                Limpiar();
            }
        }
        private void FiltroDesdeHasta()
        {
            VentaNegocio negocio = new VentaNegocio();
            try
            {
                if (txtDesde.Text != "" && txtHasta.Text != "")
                {
                    dgvLibro.DataSource = null;
                    dgvLibro.DataSource = negocio.FiltroDesdeHasta(txtDesde.Text, txtHasta.Text);
                    ocultarColumnas();
                }
                else
                {
                    MessageBox.Show("Completar los campos Desde / Hasta");
                    txtDesde.Focus();
                    CargarPlanilla();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}

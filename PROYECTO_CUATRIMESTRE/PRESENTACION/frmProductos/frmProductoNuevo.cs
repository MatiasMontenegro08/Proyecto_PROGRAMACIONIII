﻿using DOMINIO;
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
    public partial class frmProductoNuevo : Form
    {
        private Producto producto = null;
        private OpenFileDialog archivo = null; //Para cargar imagenes.

        public frmProductoNuevo()
        {
            InitializeComponent();
        }
        public frmProductoNuevo(Producto seleccionado)
        {
            InitializeComponent();
            producto = seleccionado;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            ProductoNegocio negocio = new ProductoNegocio();
            try
            {
                if (ValidarDatos())
                {
                    return;
                }
                if (producto == null)
                {
                    producto = new Producto();
                }
                producto.Nombre = txtNombre.Text;
                producto.Descripcion = txtDesc.Text;
                producto.PrecioUnitario = Convert.ToDecimal(txtCosto.Text);
                producto.ImgUrl = txtImgUrl.Text;

                /*Faltan agregar los métodos de la clase Negocio para 
                 porder cargar los productos a la base de datos*/
                if (producto.Id != 0)
                {
                    negocio.Modificar(producto);
                    MessageBox.Show("Producto modificado!");
                }
                else
                {
                    negocio.Agregar(producto);
                    MessageBox.Show("Producto agregado!");
                }
                //GuardarImagen(archivo); //Método para poder guardar la imágen.
                //Cerramos la ventana una vez cargado o modificado el producto.
                //Opcion dos: antes de cerrar la ventana, preguntar si desea agregar otro producto.
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnImg_Click(object sender, EventArgs e)
        {

        }

        //MÉTODOS
        private void Limpiar()
        {
            txtNombre.Clear();
            txtDesc.Clear();
            txtCosto.Clear();
            txtImgUrl.Clear();
            txtNombre.Focus();
        }
        private bool ValidarDatos()
        {
            if (txtNombre.Text == "")
            {
                MessageBox.Show("Completar el campo NOMBRE!");
                txtNombre.Focus();
                return true;
            }
            if (txtDesc.Text == "")
            {
                MessageBox.Show("Completar el campo DESCRIPCIÓN!");
                txtDesc.Focus();
                return true;
            }
            if (txtCosto.Text == "")
            {
                MessageBox.Show("Completar el campo COSTO!");
                txtCosto.Focus();
                return true;
            }
            //Validar si txtCosto solo ingreso números.
            return false;
        }
    }
}

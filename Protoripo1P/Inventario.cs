using Protoripo1P.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Protoripo1P
{
    public partial class Inventario : Form
    {
        public Inventario()
        {

            InitializeComponent();

            csInventario inventario = new csInventario();
            inventario.cargarCombobox(cbxIdBodega, "bodegas", "codigo_bodega", "nombre_bodega");
            inventario.cargarCombobox(cbxIdProducto, "productos", "codigo_producto", "nombre_producto");

            
            funCargarTabla(null);

            txtIdInventario.Enabled = false;
        }

        private void Inventario_Load(object sender, EventArgs e)
        {

        }

        private void funCargarTabla(string dato)
        {
            
            csInventario inventario = new csInventario();

            dgvDatos.DataSource = inventario.consulta(dato);
        }

        private void dgvBodega_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {

            if (txtExistencia.Text=="")
            {
                MessageBox.Show("No se pueden ingresar campos vacios, Todos los campos deben estar llenos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                csInventario inventario = funObtenerTxt();
                inventario.funInsertar();

                funCargarTabla(null);
                funVaciarCampos();
            }
            

        }

        private void funVaciarCampos()
        {
            txtIdInventario.Text = "";            
            txtExistencia.Text = "";
            cbxIdProducto.SelectedIndex = -1;
            cbxIdBodega.SelectedIndex = -1;

        }

        private csInventario funObtenerTxt()
        {
   
            String ordenExistencia = "0";
            String idBodega = cbxIdBodega.SelectedValue.ToString();
            String idProducto = cbxIdProducto.SelectedValue.ToString();
            String saldoExistencia = txtExistencia.Text;

            csInventario inventario = new csInventario(ordenExistencia, idBodega, idProducto, saldoExistencia);            

            return inventario;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            
            String idOrden = txtIdInventario.Text;
            csInventario inventario = funObtenerTxt();

            inventario.funModificar(idOrden);
            funCargarTabla(null);

        }

        private void btnLlenar_Click(object sender, EventArgs e)
        {
            funVaciarCampos();

            txtIdInventario.Text = dgvDatos.CurrentRow.Cells[0].Value.ToString();

            String idBodega = dgvDatos.CurrentRow.Cells[1].Value.ToString();


            csInventario inventario = new csInventario();
            inventario.obtenerNombreB(idBodega);
            cbxIdBodega.SelectedValue = idBodega;

            String idProducto = dgvDatos.CurrentRow.Cells[2].Value.ToString();
            inventario.obtenerNombreP(idProducto);
            cbxIdProducto.SelectedValue = idProducto;

            txtExistencia.Text = dgvDatos.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            String idOrden = txtIdInventario.Text;
            csInventario inventario = funObtenerTxt();

            inventario.funEliminar(idOrden);
            funCargarTabla(null);

            funVaciarCampos();

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            String buscarPE = txtBuscar.Text;
            funCargarTabla(buscarPE);

            funVaciarCampos();

        }
    }
}

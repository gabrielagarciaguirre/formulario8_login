using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace formulario8_login
{
    public partial class Fusuario : Form
    {
        // Crear la variable para la conexión 
        public OleDbConnection miconexion;

        // Crear la variable para saber cuál actualizar 
        public string usuario_modificar;
        private OleDbConnection myCon;
        

        public Fusuario()
        {
            //Crear cadena de conexion a la base 
            myCon = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Sistema\sistema.accdb");



            InitializeComponent();
        }

        private void Fusuario_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla '_sistema_mdbDataSet.Username' Puede moverla o quitarla según sea necesario.
            this.usernameTableAdapter.Fill(this._sistema_mdbDataSet.Username);
            //Desabilitar campos, se activan al crear nuevo registro
            txtusuario.Enabled = false;
            txtclave.Enabled = false;
            lstnivel.Enabled = false;


            // TODO: esta línea de código carga datos en la tabla '_sistema_mdbDataSet.Username' Puede moverla o quitarla según sea necesario.
            this.usernameTableAdapter.Fill(this._sistema_mdbDataSet.Username);

        }

        private void bprimero_Click(object sender, EventArgs e)
        {
            this.usernameBindingSource.MoveFirst();
        }

        private void banterior_Click(object sender, EventArgs e)
        {
            this.usernameBindingSource.MovePrevious();
        }

        private void bsiguiente_Click(object sender, EventArgs e)
        {
            this.usernameBindingSource.MoveNext();
        }

        private void bultimo_Click(object sender, EventArgs e)
        {
            this.usernameBindingSource.MoveLast();
        }

        private void bnuevo_Click(object sender, EventArgs e)
        {
            txtusuario.Enabled = true;
            txtclave.Enabled = true;
            lstnivel.Enabled = true;
            txtusuario.Text = "";
            txtclave.Text = "";
            lstnivel.Text = "Seleccionar nivel";
            txtusuario.Focus();
            bnuevo.Visible = false;
            bguardar.Visible = true;
        }

        private void bguardar_Click(object sender, EventArgs e)
        {
            try
            {

                OleDbCommand guardar = new OleDbCommand();
                miconexion.Open();
                guardar.Connection = miconexion;
                guardar.CommandType = CommandType.Text;

                guardar.CommandText = "INSERT INTO tusuario ([nombre], [clave],[nivel]) Values('" + txtusuario.Text.ToString() + "', '" + txtclave.Text.ToString() + "','" + lstnivel.Text.ToString() + "')";

                guardar.ExecuteNonQuery();
                miconexion.Close();

                bnuevo.Visible = true;
                bguardar.Visible = false;

                //Deshabilitar campos, se activan al crear nuevo registro 
                txtusuario.Enabled = false;
                txtclave.Enabled = false;
                lstnivel.Enabled = false;
                bnuevo.Focus();

                //Mensaje que se guardó correctamente 
                MessageBox.Show("Usuario agregado con éxito", "Ok",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.usernameTableAdapter.Fill(this._sistema_mdbDataSet.Username);
                this.usernameBindingSource.MoveLast();
            }

            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }

        }

        private void bmodificar_Click(object sender, EventArgs e)
        {
            txtusuario.Enabled = true;
            txtclave.Enabled = true;
            lstnivel.Enabled = true;
            txtusuario.Focus();
            bmodificar.Visible = false;
            bactualizar.Visible = true;

            usuario_modificar = txtusuario.Text.ToString();
        }

        private void bactualizar_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbCommand actualizar = new OleDbCommand();
                miconexion.Open();
                actualizar.Connection = miconexion;
                actualizar.CommandType = CommandType.Text;

                string nom = txtusuario.Text.ToString();
                string cla = txtclave.Text.ToString();
                string niv = lstnivel.Text;

                //Podemos actualizar todos los campos de una vez 
                actualizar.CommandText = "UPDATE tusuario SET nombre = '" + nom + "', clave = '" + cla + "',nivel = '" + niv + "' WHERE nombre = '" + usuario_modificar + "'";

                actualizar.ExecuteNonQuery();
                miconexion.Close();

                bmodificar.Visible = true;
                bactualizar.Visible = false;

                txtusuario.Enabled = false;
                txtclave.Enabled = false;
                lstnivel.Enabled = false;

                //Mensaje que se guardó correctamente 
                MessageBox.Show("Usuario actualizado con éxito", "Ok",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

                //this.tusuarioTableAdapter.Fill(this.sistemaDataSet.tusuario); 
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }


        private void beliminar_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbCommand eliminar = new OleDbCommand();
                miconexion.Open();
                eliminar.Connection = miconexion;
                eliminar.CommandType = CommandType.Text;

                eliminar.CommandText = "DELETE FROM tusuario WHERE nombre = '" +
                txtusuario.Text.ToString() + "'";

                eliminar.ExecuteNonQuery();
                this.usernameBindingSource.MoveNext();
                miconexion.Close();

                //Mensaje que se guardó correctamente 
                MessageBox.Show("Usuario eliminado con éxito", "Ok",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

                //this.tusuarioTableAdapter.Fill(this.sistemaDataSet.tusuario);  
                this.usernameBindingSource.MovePrevious();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void bsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

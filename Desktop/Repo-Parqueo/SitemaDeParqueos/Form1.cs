using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SitemaDeParqueos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            using (SqlConnection cn = Conexion.ObtenerConexion())
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Parqueos (Numero, Estado, FechaRegistro) VALUES (@numero, @estado, @fecha)", cn);
                cmd.Parameters.AddWithValue("@numero", txtNumero.Text);
                cmd.Parameters.AddWithValue("@estado", cmbEstado.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@fecha", dtpFechaRegistro.Value);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Parqueo guardado.");
                MostrarParqueos();
            }


        }
        private void MostrarParqueos()
        {
            using (SqlConnection cn = Conexion.ObtenerConexion())
            {
                cn.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Parqueos", cn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvParqueos.DataSource = dt;
            }
        }
    }
}

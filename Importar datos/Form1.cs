using System;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Importar_datos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DataView ImportarDatos(string nombrearchivo)
        {
            //UTILIZAMOS 12.0 DEPENDIENDO DE LA VERSION DEL EXCEL, EN CASO DE QUE LA VERSIÓN QUE TIENES ES INFERIOR AL DEL 2013, CAMBIAR POR A EXCEL 8.0 Y EN VEZ DE
            //ACE.OLEDB.12.0 UTILIZAR LO SIGUIENTE (Jet.Oledb.4.0)
            string conexion = string.Format("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = {0}; Extended Properties = 'Excel 12.0;'", nombrearchivo);

            OleDbConnection conector = new OleDbConnection(conexion);

            conector.Open();

            //DEPENDIENDO DEL NOMBRE QUE TIENE LA PESTAÑA EN TU ARCHIVO EXCEL COLOCAR DENTRO DE LOS []
            OleDbCommand consulta = new OleDbCommand("select * from [Productos$]", conector);

            OleDbDataAdapter adaptador = new OleDbDataAdapter
            {
                SelectCommand = consulta
            };

            DataSet ds = new DataSet();

            adaptador.Fill(ds);

            conector.Close();

            return ds.Tables[0].DefaultView;
        }

        private void BtnImportarDatos_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                //DE ESTA MANERA FILTRAMOS TODOS LOS ARCHIVOS EXCEL EN EL NAVEGADOR DE ARCHIVOS
                Filter = "Excel | *.xls;*.xlsx;",
                
                //AQUÍ INDICAMOS QUE NOMBRE TENDRÁ EL NAVEGADOR DE ARCHIVOS COMO TITULO
                Title = "Seleccionar Archivo"
            };

            //EN CASO DE SELECCIONAR EL ARCHIVO, ENTONCES PROCEDEMOS A ABRIR EL ARCHIVO CORRESPONDIENTE
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                DataDetalles.DataSource = ImportarDatos(openFileDialog.FileName);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cadena;
            cadena = txtcadena.Text;
           // SqlConnection cn;
            
            //lblfecha.Text = DateTime.Now.ToString("dd/mm/yyyy");
            //lbltiempo.Text = DateTime.Now.ToString("HH:mm:ss");
            SqlConnection cn = new SqlConnection(cadena);
           // cn = new SqlConnection(cadena);//demo conexion


            try
            {
                if ((DataDetalles.Rows.Count == 0))
                {
                    return;
                }

                string query = "insert into Productos values (@Codigo_Barras, @Descripcion, @UsoTerapeutico, @SustanciaActiva, @Precio_compra, @Precio_venta, @Fecha_vencimiento, @stock, @Ubicacion, @Lote, @cod_lab, @cod_cate, @cod_prov, @cod_pre, @IGV_incluido, @Descuento, @Estado)";
                SqlCommand cmd = new SqlCommand(query, cn);
                foreach (DataGridViewRow row in DataDetalles.Rows)
                {
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@Codigo_Barras", Convert.ToString(row.Cells["Codigo_Barras"].Value));
                    cmd.Parameters.AddWithValue("@Descripcion", Convert.ToString(row.Cells["Descripcion"].Value));
                    //aqui esta el error al pasar la fecha y la hora no reconoce el formato
                    cmd.Parameters.AddWithValue("@UsoTerapeutico", Convert.ToString(row.Cells["UsoTerapeutico"].Value));
                    //aqui esta el error al pasar la fecha y la hora no reconoce el formato
                    cmd.Parameters.AddWithValue("@SustanciaActiva", Convert.ToString(row.Cells["SustanciaActiva"].Value));
                    cmd.Parameters.AddWithValue("@Precio_compra", Convert.ToDecimal(row.Cells["Precio_compra"].Value));
                    cmd.Parameters.AddWithValue("@Precio_venta", Convert.ToDecimal(row.Cells["Precio_venta"].Value));

                    cmd.Parameters.AddWithValue("@Fecha_vencimiento", Convert.ToDateTime(row.Cells["Fecha_vencimiento"].Value));
                    cmd.Parameters.AddWithValue("@stock", Convert.ToInt64(row.Cells["stock"].Value));
                    cmd.Parameters.AddWithValue("@Ubicacion", Convert.ToString(row.Cells["Ubicacion"].Value));
                    cmd.Parameters.AddWithValue("@Lote", Convert.ToString(row.Cells["Lote"].Value));
                    cmd.Parameters.AddWithValue("@cod_lab", Convert.ToInt64(row.Cells["Laboratorio"].Value));
                    cmd.Parameters.AddWithValue("@cod_cate", Convert.ToInt64(row.Cells["Categoria"].Value));
                    cmd.Parameters.AddWithValue("@cod_prov", Convert.ToInt64(row.Cells["Proveedor"].Value));
                    cmd.Parameters.AddWithValue("@cod_pre", Convert.ToInt64(row.Cells["Presentacion"].Value));
                    cmd.Parameters.AddWithValue("@IGV_incluido", Convert.ToString(row.Cells["IGV_incluido"].Value));
                    cmd.Parameters.AddWithValue("@Descuento", Convert.ToString(row.Cells["Descuento"].Value));
                    cmd.Parameters.AddWithValue("@Estado", Convert.ToString(row.Cells["Estado"].Value));
                    cn.Open();
                    cmd.ExecuteNonQuery();
                    cn.Close();
                    
                }
                MessageBox.Show("Datos ingresados correctamente");

            }
            catch (Exception f)
            {

                MessageBox.Show(f.Message);
            }
        }
    }
}

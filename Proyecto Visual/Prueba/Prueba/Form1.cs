using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace Prueba
{
    public partial class Form1 : Form
    {
        //Inicicalizacion de la conexion con SqlServer
        SqlConnection LaConexion = null;

        //Inicializacion de la funcion de transaccion de SqlServer
        SqlTransaction LaTransaccion = null;

        //Inicializa el formulario
        public Form1()
        {
            InitializeComponent();
        }

        //Genera las funciones de Edicion y Actualización
        private void buildingsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.buildingsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.materialsDataSet);
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            //Se extraen los datos de las tablas de la base de datos y se adaptan a los formularios
            this.partNumbersTableAdapter.Fill(this.materialsDataSet.PartNumbers);

            this.customersTableAdapter.Fill(this.materialsDataSet.Customers);

            this.buildingsTableAdapter.Fill(this.materialsDataSet.Buildings);

            //Aquí es cargado el combobox con los datos de la tabla Buildings
            CBOBuilding.DataSource = this.materialsDataSet.Buildings;
            CBOBuilding.DisplayMember = "Building";
        }

        //Boton para cerrar la pestaña
        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void CBOBuilding_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //Boton de Alta de Edificios
        private void BtnAltBuil_Click(object sender, EventArgs e)

        {
            //Nombre a la conexion e inicializacion
            SqlConnection conexion = new SqlConnection();
            //Conexion con la base de datos por medio de ConnectionString
            conexion.ConnectionString = "Data Source=LAPTOP-58Q14SMR\\SQLEXPRESS;Initial Catalog=Materials;Integrated Secur" +
            "ity=True";
            //Conexion abierta
            conexion.Open();
            //Genera una transaccion dando una orden por medio de la conexion
            SqlTransaction transaccion = conexion.BeginTransaction(IsolationLevel.Serializable);
            //se genera un comando que toma acción el Stored Procedure de insercion de datos para la tabla Buildings procediente de SqlServer
            SqlCommand comando = new SqlCommand("SP_Insert_Buiding", conexion, transaccion);
            //El comando se ejecuta por medio de escritura de comandos en segundo plano
            comando.CommandType = CommandType.StoredProcedure;
            //Los parametros deben estar vaciados
            comando.Parameters.Clear();
            //Los parametros que se escriban en el Text Box se guardaran como el parametro @Building que es con lo que trabaja el Store Procedure
            comando.Parameters.AddWithValue("@Building", Convert.ToString(txtBuild.Text.ToString()));
            //se ejecuta el Query del Stored Procedure
            comando.ExecuteNonQuery();
            //la transaccion se ejecuta y se obtienen resultados
            transaccion.Commit();
            //Se cierra la conexion
            conexion.Close();
        }
        //En este apartado se genera un archivo de Excel de la tabla PartNumbers, se guaran columnas y filas de a cuerdo a como estan acomodados
        //en el DataGridView. Ademas genera una fila extra que toma los nombres de las columnas pero actualmente cuenta con error al mostrar los nombres.
        private void ExportarDatos(DataGridView partNumbers)
        {
            Excel.Application exportarExcel = new Excel.Application();

            exportarExcel.Application.Workbooks.Add(true);

            int indiceColumna = 0;

            foreach(DataGridViewColumn columna in partNumbers.Columns)
            {
                indiceColumna++;

                exportarExcel.Cells[1, indiceColumna] = columna.Name;
            }

            int indiceFila = 0;

            foreach (DataGridViewRow fila in partNumbers.Rows)
            {
                indiceFila++;
                indiceColumna = 0;
                foreach(DataGridViewColumn columna in partNumbers.Columns)
                {
                    indiceColumna++;
                    exportarExcel.Cells[indiceFila + 1, indiceColumna] = fila.Cells[columna.Name].Value;
                }

            }
            exportarExcel.Visible = true;
        }
        //Ejecuta la exportacion a Excel
        private void btnEx_Click(object sender, EventArgs e)
        {
            ExportarDatos(partNumbersDataGridView);
        }
        //Mismo proceso de obtencion de conexion y obtencion de stored procedure de Sql Sserver
        //Ademas de ejecutar el mismo proceso de obtencion de parametros y ejecuccion de este
        private void btnAltCust_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection();

            conexion.ConnectionString = "Data Source=LAPTOP-58Q14SMR\\SQLEXPRESS;Initial Catalog=Materials;Integrated Secur" +
            "ity=True";

            conexion.Open();

            SqlTransaction transaccion = conexion.BeginTransaction(System.Data.IsolationLevel.Serializable);

            SqlCommand comando = new SqlCommand("SP_Insert_Customers", conexion, transaccion);

            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.Clear();

            comando.Parameters.AddWithValue("@Customer", Convert.ToString(txtCustomer.Text.ToString()));
            comando.Parameters.AddWithValue("@Prefix", Convert.ToString(txtPrefix.Text.ToString()));
            comando.Parameters.AddWithValue("@FKBuilding", Convert.ToString(txtFKBuilding.Text.ToString()));
            

            comando.ExecuteNonQuery();

            transaccion.Commit();

            conexion.Close();
        }

        private void btnPNumber_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection();

            conexion.ConnectionString = "Data Source=LAPTOP-58Q14SMR\\SQLEXPRESS;Initial Catalog=Materials;Integrated Secur" +
            "ity=True";

            conexion.Open();

            SqlTransaction transaccion = conexion.BeginTransaction(System.Data.IsolationLevel.Serializable);

            SqlCommand comando = new SqlCommand("SP_Insert_PartNumbers", conexion, transaccion);

            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.Clear();

            comando.Parameters.AddWithValue("@PartNumber", Convert.ToString(txtPNumber.Text.ToString()));
            comando.Parameters.AddWithValue("@Available", Convert.ToString(txtAvailable.Text.ToString()));
            comando.Parameters.AddWithValue("@FKCustomer", Convert.ToString(txtFKCustomer.Text.ToString()));

            comando.ExecuteNonQuery();

            transaccion.Commit();

            conexion.Close();
        }

        private void partNumbersDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtFKBuilding_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}

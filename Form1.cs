using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Linq;
using MongoDB.Bson.Serialization;
using System.Text.Json;
using System.Text.Json.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace AppExcel
{
    public partial class Form1 : Form
    {
        static List<dadoExcel> list;
        static List<dadoExcel> list_dados;

        static MongoClient client = new MongoClient("mongodb://localhost:27017");
        static IMongoDatabase db = client.GetDatabase("Excel_Datos");
        static IMongoCollection<dadoExcel> collection = db.GetCollection<dadoExcel>("excel");



        public string TextBoxText { get { return txtPorcentual.Text; } }

        public void ReadAllDocuments() {

            var dadoPorcentual = from x in collection.AsQueryable<dadoExcel>() select x;
            var ds = dadoPorcentual.ToList();

            if (ds.Count > 0)
            {
                 txtPorcentual.Text = ds[0].Tarifa.ToString();
            }   

            var query = from x in collection.AsQueryable<dadoExcel>(new AggregateOptions { AllowDiskUse = true })                        
                        orderby x.Rate_EUR
                        select x;

            var tb = query.ToList();

            lblTotal.Text = "Total = " + query.ToList().Count.ToString();

            list = query.ToList();
            dataGridView1.DataSource = list;
            list_dados = list;


            var grupoby = from x in collection.AsQueryable<dadoExcel>(new AggregateOptions { AllowDiskUse = true })
                          group x by x.Pais into g
                          select g;

            var orderDados = grupoby.OrderBy(x => x.Key).ToList();

            comboBox1.Items.Clear();
            for (int i = 0; i < orderDados.Count; i++)
            {
                comboBox1.Items.Add(orderDados[i].Key);
            }

            var ExcelDelete = (from x in collection.AsQueryable<dadoExcel>(new AggregateOptions { AllowDiskUse = true })
                            group x by x.Excel into g
                            select new
                            {
                                Excel = g.Max(m => m.Excel)

                            }).ToList();

            var DadosExcel = ExcelDelete.OrderBy(x => x.Excel).ToList();

            comboBoxDeleteExcel.Items.Clear();
            for (int i = 0; i < DadosExcel.Count; i++)
            {
                comboBoxDeleteExcel.Items.Add(DadosExcel[i].Excel);
            }

            if (DadosExcel.Count > 0)
            {
                textBox1.Text = dataGridView1.Rows[0].Cells[1].Value.ToString();
                textBox2.Text = dataGridView1.Rows[0].Cells[2].Value.ToString();
                textBox3.Text = dataGridView1.Rows[0].Cells[3].Value.ToString();
            }
        }

        public Form1()
        {
            MessageBox.Show("Actualizar datos...");
            InitializeComponent();
            ReadAllDocuments();
            lblValor.Text = "0";
            this.tabPage1.Text = "INICIO";
            this.tabPage2.Text = "DELETE EXCEL";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            buscaCombobox();
        }

        private void buscaCombobox()
        {
            var dados = "";
            if (comboBox1.SelectedIndex != -1)
            {
                txtName.Text = comboBox1.SelectedItem.ToString();
                dados = comboBox1.SelectedItem.ToString();
            }        
            
            double valor = Valor();

            //var result =   collection.Find(x => x.Pais == txtName.Text && x.Rate_EUR <= valor).ToList();
            var query = from x in list
                        where x.Pais.Contains(dados.ToString()) && x.Rate_EUR <= valor
                        orderby x.Rate_EUR
                        select x;


            list_dados = query.ToList();
            dataGridView1.DataSource = query.ToList();
            lblTotal.Text = "Total = " + query.ToList().Count.ToString();
        }
        
        private void button1_Click(object sender, EventArgs e) {
            
            double valor = Valor();
        
            //var result =   collection.Find(x => x.Pais == txtName.Text && x.Rate_EUR <= valor).ToList();
           var query = from x in list
                       where x.Pais.Contains(txtName.Text) && x.Rate_EUR <= valor
                       orderby x.Rate_EUR
                       select x;

            dataGridView1.DataSource = query.ToList();
            list_dados = query.ToList();

            lblTotal.Text = "Total = " + query.ToList().Count.ToString();
        } 



        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {            
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();         
       
        }

        private void comboBoxValor_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblValor.Text = comboBoxValor.SelectedItem.ToString();

            if (comboBoxValor.SelectedItem.ToString() != null)
            {
                buscaCombobox();
            }           
        }

        double Valor()
        {
            double valor_ = 1000;
            if (lblValor.Text == "3")
            {
                valor_ = 3;
            }
            if (lblValor.Text == "2")
            {
                valor_ = 2;
            }
            if (lblValor.Text == "1")
            {
                valor_ = 1;
            }

            if (lblValor.Text == "0.9" || lblValor.Text == "0")
            {
                valor_ = 0.9;
            }
            if (lblValor.Text == "0.09")
            {
                valor_ = 0.09;
            }
            if (lblValor.Text == "0.009")
            {
                valor_ = 0.009;
            }

            return valor_;
        }

        public static async Task WriteCollectionToFile(IMongoDatabase database, string collectionName, string fileName)
        {
            var collection = database.GetCollection<RawBsonDocument>(collectionName);

            // Make sure the file is empty before we start writing to it
            File.WriteAllText(fileName, string.Empty);

            using (var cursor = await collection.FindAsync(new BsonDocument()))
            {
                while (await cursor.MoveNextAsync())
                {
                    var batch = cursor.Current;
                    foreach (var document in batch)
                    {
                        File.AppendAllLines(fileName, new[] { document.ToString() });
                    }
                }
            }
        }

        public static async Task LoadCollectionFromFile(IMongoDatabase database, string collectionName, string fileName)
        {
            using (FileStream fs = File.Open(fileName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            using (BufferedStream bs = new BufferedStream(fs))
            using (StreamReader sr = new StreamReader(bs))
            {
                var collection = database.GetCollection<BsonDocument>(collectionName);

                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    await collection.InsertOneAsync(BsonDocument.Parse(line));
                }
            }
        }

        private void exportarCSVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Group_mongodb group = new Group_mongodb();
            group.excelExport();

            DialogResult dr = MessageBox.Show("¿Quieres exportar más Excel? 'Si'. 'No', solo actualiza datod en sistema.", "Atencion!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dr == DialogResult.Yes)
            {
                group.excelExport();

            }
            else      
            {
                ReadAllDocuments();
                MessageBox.Show("Datos actualizado", "Hecho", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
          
        }

        private void btnTodosEnUm_Click(object sender, EventArgs e)
        {
              var grupoby = from x in list
                            group x by x.Pais into g
                            select new { Pais = g.Key
                                         , Destination = g.Min(m => m.Destination)
                                         , Prefix = g.Min(m => m.Prefix)
                                         , Rate_EUR = g.Min(m => m.Rate_EUR)
                                         , Tuyo_Rate = g.Min(m => m.Tuyo_Rate)
                                         , Excel = g.Min(m => m.Excel)                                                   
                                         , Tarifa = g.Select(m => m.Tarifa)
                            };

            var dados = grupoby.ToList();
            lblTotal.Text = "Total = " + dados.ToList().Count.ToString();
            dataGridView1.DataSource = grupoby.OrderBy(x => x.Pais).ToList();
            
        }
        

        private void actualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            ReadAllDocuments();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {         
            DialogResult dr = MessageBox.Show("¿Quieres Borrar Excel " + comboBoxDeleteExcel.SelectedItem.ToString() + " ?.", "Atencion!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dr == DialogResult.Yes)
            {
                if (comboBoxDeleteExcel.SelectedIndex != -1)
                {
                    var EmpInfoArray =
                         new BsonDocument {
                    { "Excel", comboBoxDeleteExcel.SelectedItem.ToString() } };

                    collection.DeleteMany(EmpInfoArray);

                    MessageBox.Show("Datos borrados " + comboBoxDeleteExcel.SelectedItem.ToString());
                    ReadAllDocuments();
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {           
            lblId_.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();       
  
        }

        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("¿Quieres registro: " + lblId_.Text + " ?.", "Atencion!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dr == DialogResult.Yes) {
                collection.DeleteOne(s => s._id == ObjectId.Parse(lblId_.Text));
                MessageBox.Show("Datos Borrado");
                ReadAllDocuments();
            }
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {

            double valor = Valor();

            if (comboBox1.SelectedIndex == -1)
            {
            
                if (radioButtonDestination.Checked == true)
                { 
                    var query = from x in list_dados
                                orderby x.Destination ascending
                                select x;
                    dataGridView1.DataSource = query.ToList();
                    lblTotal.Text = "Total = " + query.ToList().Count.ToString();
                }

                if (radioButtonPrefix.Checked == true)
                {                    
                    var query = from x in list_dados
                                orderby x.Prefix ascending
                                select x;
                    dataGridView1.DataSource = query.ToList();
                    lblTotal.Text = "Total = " + query.ToList().Count.ToString();

                }

                if (radioButtonValor.Checked == true)
                {
                    var query = from x in list_dados
                                orderby x.Rate_EUR ascending
                                select x;
                    dataGridView1.DataSource = query.ToList();
                    lblTotal.Text = "Total = " + query.ToList().Count.ToString();
                }
            }
            else
            {
                txtName.Text = comboBox1.SelectedItem.ToString();

                if (radioButtonValor.Checked == true)
                {
                    //var result =   collection.Find(x => x.Pais == txtName.Text && x.Rate_EUR <= valor).ToList();
                    var query = from x in list_dados
                                where x.Pais.Contains(comboBox1.SelectedItem.ToString()) && x.Rate_EUR <= valor
                                orderby x.Destination ascending
                                select x;

                    dataGridView1.DataSource = query.ToList();
                    lblTotal.Text = "Total = " + query.ToList().Count.ToString();
                }

                if (radioButtonValor.Checked == true)
                {
                    //var result =   collection.Find(x => x.Pais == txtName.Text && x.Rate_EUR <= valor).ToList();
                    var query = from x in list_dados
                                where x.Pais.Contains(comboBox1.SelectedItem.ToString()) && x.Rate_EUR <= valor
                                orderby x.Prefix ascending
                                select x;

                    dataGridView1.DataSource = query.ToList();
                    lblTotal.Text = "Total = " + query.ToList().Count.ToString();
                }

                if (radioButtonValor.Checked == true)
                {
                    //var result =   collection.Find(x => x.Pais == txtName.Text && x.Rate_EUR <= valor).ToList();
                    var query = from x in list_dados
                                where x.Pais.Contains(comboBox1.SelectedItem.ToString()) && x.Rate_EUR <= valor
                                orderby x.Rate_EUR ascending
                                select x;

                    dataGridView1.DataSource = query.ToList();
                    lblTotal.Text = "Total = " + query.ToList().Count.ToString();
                }
            }
   
        }

        private void btnDesc_Click(object sender, EventArgs e)
        {
            this.timer1.Start();
            double valor = Valor();

            if (comboBox1.SelectedIndex == -1)
            {

                if (radioButtonDestination.Checked == true)
                {
                    var query = from x in list_dados
                                orderby x.Destination descending
                                select x;
                    dataGridView1.DataSource = query.ToList();
                    lblTotal.Text = "Total = " + query.ToList().Count.ToString();
                }

                if (radioButtonPrefix.Checked == true)
                {
                    var query = from x in list_dados
                                orderby x.Prefix descending
                                select x;
                    dataGridView1.DataSource = query.ToList();
                    lblTotal.Text = "Total = " + query.ToList().Count.ToString();
                }

                if (radioButtonValor.Checked == true)
                {
                    var query = from x in list_dados
                                orderby x.Rate_EUR descending
                                select x;
                    dataGridView1.DataSource = query.ToList();
                    lblTotal.Text = "Total = " + query.ToList().Count.ToString();
                }

            }
            else
            {
                txtName.Text = comboBox1.SelectedItem.ToString();
                if (radioButtonValor.Checked == true)
                {
                    //var result =   collection.Find(x => x.Pais == txtName.Text && x.Rate_EUR <= valor).ToList();
                    var query = from x in list_dados
                                where x.Pais.Contains(comboBox1.SelectedItem.ToString()) && x.Rate_EUR <= valor
                                orderby x.Destination descending
                                select x;
                    dataGridView1.DataSource = query.ToList();
                    lblTotal.Text = "Total = " + query.ToList().Count.ToString();
                }

                if (radioButtonValor.Checked == true)
                {
                    var query = from x in list_dados
                                where x.Pais.Contains(comboBox1.SelectedItem.ToString()) && x.Rate_EUR <= valor
                                orderby x.Prefix descending
                                select x;

                    dataGridView1.DataSource = query.ToList();
                    lblTotal.Text = "Total = " + query.ToList().Count.ToString();
                }

                if (radioButtonValor.Checked == true)
                {
                    var query = from x in list_dados
                                where x.Pais.Contains(comboBox1.SelectedItem.ToString()) && x.Rate_EUR <= valor
                                orderby x.Rate_EUR descending
                                select x;

                    dataGridView1.DataSource = query.ToList();
                    lblTotal.Text = "Total = " + query.ToList().Count.ToString();
                }
            }
           

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (radioButtonDestination.Checked == true)
            {
                var query = from x in list
                            where x.Destination.Contains(textBox4.Text)
                            select x;

                dataGridView1.DataSource = query.ToList();
            }

            if (radioButtonPrefix.Checked == true)
            {
                //var result =   collection.Find(x => x.Pais == txtName.Text && x.Rate_EUR <= valor).ToList();
                var query = from x in list
                            where x.Prefix.Contains(textBox4.Text)
                            select x;
                dataGridView1.DataSource = query.ToList();
            }

        }

        private void radioButtonDestination_CheckedChanged(object sender, EventArgs e)
        {
            textBox4.Visible = true;
        }

        private void radioButtonPrefix_CheckedChanged(object sender, EventArgs e)
        {
            textBox4.Visible = true;
        }

        private void radioButtonValor_CheckedChanged(object sender, EventArgs e)
        {
            textBox4.Visible = false;
        }

        private void btnPorcentual_Click(object sender, EventArgs e)
        {
            var updateDef = Builders<dadoExcel>.Update.Set("Tarifa", txtPorcentual.Text);
            collection.UpdateMany(s => s.Tarifa > -1 , updateDef);
            ReadAllDocuments();
        }

        private void btnName_Click(object sender, EventArgs e)
        {

            string filename = "";
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "CSV (*.csv)|*.csv";
            sfd.FileName = "Tuyo_Prefix.csv";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Los datos se exportarán y se le notificará cuando esté listo.");
                if (File.Exists(filename))
                {
                    try
                    {
                        File.Delete(filename);
                    }
                    catch (IOException ex)
                    {
                        MessageBox.Show("No fue posible escribir los datos en el disco." + ex.Message);
                    }
                }
                int columnCount = dataGridView1.ColumnCount;
                List<int> dados = new List<int>();
                string columnNames = "";
                string[] output = new string[dataGridView1.RowCount + 1];
                for (int i = 0; i < columnCount; i++)
                {
                    if (dataGridView1.Columns[i].Name.ToString() == "Destination" || dataGridView1.Columns[i].Name.ToString() == "Prefix" || dataGridView1.Columns[i].Name.ToString() == "Tuyo_Rate" || dataGridView1.Columns[i].Name.ToString() == "Data")
                    {
                        columnNames += dataGridView1.Columns[i].Name.ToString() + ";";
                        dados.Add(i);
                    }

                }
                output[0] += columnNames;
                int colunas = 0;
                for (int i = 1; (i - 1) < dataGridView1.RowCount; i++)
                {
                    for (int j = 0; j < columnCount; j++)
                    {
                        for (int ii = 0; ii < dados.Count; ii++)
                        {
                            colunas = dados[ii];

                            if (colunas == j)
                            {
                                output[i] += dataGridView1.Rows[i - 1].Cells[j].Value.ToString() + ";";
                                break;
                            }
                        }
                    }
                }
                System.IO.File.WriteAllLines(sfd.FileName, output, System.Text.Encoding.UTF8);
                MessageBox.Show("Su archivo fue generado y está listo para usar.");
            }
        }
    }
}



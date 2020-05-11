using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Driver;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.Text.Json;

namespace AppExcel
{
    public class Group_mongodb
    {
        public void excelExport()
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                var client = new MongoClient("mongodb://localhost:27017");
                var database = client.GetDatabase("Excel_Datos");
                var collection = database.GetCollection<BsonDocument>("excel");

                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "txt files (*.csv)|*.csv";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                DateTime data = Convert.ToDateTime(DateTime.Today);

                string namoExcel = openFileDialog.SafeFileName;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = openFileDialog.FileName;      

                    var csv = new List<string[]>();
                    var lines = File.ReadAllLines(filePath);

                    foreach (string line in lines)
                        csv.Add(line.Split(';'));

                    var EmpInfoArray = new List<BsonDocument>() { };
                    var info = lines[1].Split(';');

                    if (info.Length > 3)
                    {
                        MessageBox.Show("Este Excel no es permitido, deve tener solo 3 informaciones = |Destination|Prefix|Rate_EUR|  en formato .CSV separado por ';' ");
                    }
                    else
                    {
                        for (int i = 1; i < lines.Length; i++)
                        {
                            var dados = lines[i].Split(';');
                            var tipo_dados = dados[0].Split(' ', '-', ',', '*');
                            EmpInfoArray.Add(
                                new BsonDocument {
                                    { "Destination", dados[0] }
                                    , { "Prefix",dados[1] }
                                    , { "Rate_EUR", Convert.ToDouble(dados[2]) }
                                    , { "Tuyo_Rate", Convert.ToDouble(dados[2]) }
                                    , { "Tarifa", 0 }
                                    , { "Data", data}
                                    , { "Excel", openFileDialog.SafeFileName }
                                    , { "Pais", tipo_dados[0] }
                                }
                            );
                        }
                        collection.InsertMany(EmpInfoArray);
                    }
                }
            }    
        }
    }
}

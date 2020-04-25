using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Bson.Serialization.Attributes;
using System.Configuration;
using Microsoft.Azure.Documents;
using Newtonsoft.Json.Linq;
using System.IO;
using Newtonsoft.Json;

namespace AppExcel

{
    class dadoExcel
    {  

        [BsonId]
        public ObjectId _id { get; set; }

        [BsonElement("Destination")]
        public String Destination { get; set; }

        [BsonElement("Prefix")]
        public String Prefix { get; set; }

        [BsonElement("Rate_EUR")]
        public double Rate_EUR { get; set; }

        [BsonElement("Tuyo_Rate")]
        public double Tuyo_Rate
        {
          
            get => Rate_EUR + (Rate_EUR * Tarifa / 100);
        }

        [BsonElement("Beneficio")]
        public double Beneficio
        {
            get => Tuyo_Rate - Rate_EUR;
        }

        [BsonElement("Data")]
        public DateTime Data { get; set; }

        [BsonElement("Excel")]
        public string Excel { get; set; }

        [BsonElement("Pais")]
        public string Pais { get; set; }

        [BsonElement("Tarifa")]
        public int Tarifa { get; set; }

    }



}


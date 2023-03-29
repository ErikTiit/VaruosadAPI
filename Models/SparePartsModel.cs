using System;
using CsvHelper.Configuration;
using System.Globalization;
using CsvHelper.Configuration.Attributes;
using CsvHelper;
using System.ComponentModel.DataAnnotations;

namespace VaruosadAPI.Models
{

    public class SparePartsModel


    {


        [Key]
        [Index(0)]
        public string? Id { get; set; }

        [Index(1)]
        public string? Name { get; set; }

        [Index(2)]
        
        public string? Warehouse1 { get; set; }

        [Index(3)]
        public string? Warehouse2 { get; set; }

        [Index(4)]
        public string? Warehouse3 { get; set; }

        [Index(5)]
        public string? Warehouse4 { get; set; }

        [Index(6)]
        public string? WareHouse5 { get; set; }

        [Index(7)]
        public string? Warehouse6 { get; set; }

        [Index(8)]
        public string? WithoutVAT { get; set; }

        [Index(9)]
        public string? Model { get; set; }

        [Index(10)]
        public float? Price { get; set; }





    }
}


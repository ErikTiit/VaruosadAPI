using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using VaruosadAPI.Data;
using System;
using System.Linq;
using CsvHelper.Configuration;
using CsvHelper;
using System.Globalization;
using System.Text;

namespace VaruosadAPI.Models;



public static class SeedData
{

    

    public static void Initialize(IServiceProvider serviceProvider)
    {
        
        
            using (var context = new SparePartsContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<SparePartsContext>>()))


            {


            if (context.SparePartsModel.Any())
            {
                return;   // DB has been seeded
            }

            var fileName = @"LE.csv";
            var configuration = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                HasHeaderRecord = false,
                Delimiter = "\t"
            };

            using (var fs = File.Open(fileName, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                using (var textReader = new StreamReader(fs, Encoding.UTF8))
                using (var csv = new CsvReader(textReader, configuration))
                {
                    var data = csv.GetRecords<SparePartsModel>();

                    context.SparePartsModel.AddRange(data);
                }

                
            }




            context.SaveChanges();


        }

    }
}
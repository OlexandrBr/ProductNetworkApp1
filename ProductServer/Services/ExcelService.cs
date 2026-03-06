using ClosedXML.Excel;
using ProductServer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductServer.Services
{
    public class ExcelService
    {
        public List<Product> LoadProducts(string filePath)
        {
            List<Product> products = new List<Product>();

            using (var workbook = new XLWorkbook(filePath))
            {
                var worksheet = workbook.Worksheet(1);
                var rows = worksheet.RowsUsed().Skip(1); 

                foreach (var row in rows)
                {
                    string name = row.Cell(1).GetValue<string>().Trim();
                    decimal price = row.Cell(2).GetValue<decimal>();
                    int quantity = row.Cell(3).GetValue<int>();

                    products.Add(new Product
                    {
                        Name = name,
                        Price = price,
                        Quantity = quantity
                    });
                }
            }

            return products;
        }
    }
}

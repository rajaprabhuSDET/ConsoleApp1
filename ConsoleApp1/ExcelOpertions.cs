using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using Excel = Microsoft.Office.Interop.Excel;
using Bytescout;
using Bytescout.Spreadsheet;

namespace ConsoleApp1
{
    class ExcelOpertions 
    {
        Spreadsheet document;
        Bytescout.Spreadsheet.Worksheet sheet;
        Cell cell;

        static void Main(String []args)
        {
            try
            {
                OLEDBConnection conn = new Class1("Provider = Microsoft.Jet.OleDb.4.0; Data Source = D:\\MySamplefile.xls;Extended Properties = Excel 8.0; ");
            }
            catch(Exception e)
            {

            }

        }

        public ExcelOpertions(String filename)
        {
            document = new Spreadsheet();
            document.LoadFromFile(filename);

        }

        public void GetSheet(String sheetname)
        {
           sheet = document.Workbook.Worksheets.ByName(sheetname);
        }

        public String ReadCell(String Range)
        {
            cell = sheet.Cell(Range);
           
            String cellvalue=cell.ValueAsString;
            
            return cellvalue; 
        }

        public void WriteCell(String Range, String datatowrite)
        {

        }
    }
}

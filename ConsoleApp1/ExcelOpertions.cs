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

        static void Main(String args[])
        {
            try
            {
                
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
            OLEDBConnection conn = new OLEDBConnection();
            return cellvalue; 
        }

        public void WriteCell(String Range, String datatowrite)
        {

        }
    }
}

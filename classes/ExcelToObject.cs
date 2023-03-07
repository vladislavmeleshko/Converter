using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;

namespace Converter.classes
{
    public class ExcelToObject
    {
        public string path_to_file { get; set; }
        public ExcelToObject(string path_to_file) 
        {
            this.path_to_file = path_to_file;
        }

        public descBalance get_list()
        {
            descBalance descBalanceObj = new descBalance();

            try
            {
                Excel.Application ex = new Excel.Application();
                ex.Visible = true;
                ex.Workbooks.Open(path_to_file,
                                    Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                                    Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                                    Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                                    Type.Missing, Type.Missing);
                ex.DisplayAlerts = false;
                Excel.Worksheet sheet = (Excel.Worksheet)ex.Worksheets.get_Item(1);

                descBalanceObj.accTitle = Convert.ToString(sheet.Cells[1, 1].Value);
                descBalanceObj.dateFrom = Convert.ToString(sheet.Cells[3, 4].Value.ToString().Split(' ')[1]);
                descBalanceObj.dateTo = Convert.ToString(sheet.Cells[3, 4].Value.ToString().Split(' ')[3]);
                descBalanceObj.extractList = new ExtractList();
                descBalanceObj.extractList.openingBalance = Convert.ToString(sheet.Cells[6, 4].Value.ToString().Split('B')[0]);
                descBalanceObj.extractList.tDbAmount = Convert.ToString(sheet.Cells[7, 4].Value.ToString().Split('B')[0]);
                descBalanceObj.extractList.tCrAmount = Convert.ToString(sheet.Cells[8, 4].Value.ToString().Split('B')[0]);
                descBalanceObj.extractList.openingBalance = Convert.ToString(sheet.Cells[9, 4].Value.ToString().Split('B')[0]);

                descBalanceObj.extractList.turns = new List<Turns>();
                int row = 12;
                while (sheet.Cells[row, 1].value != null)
                {
                    Turns turn = new Turns();
                    turn.docDate = Convert.ToDateTime(sheet.Cells[row, 1].Value);
                    turn.docN = Convert.ToString(sheet.Cells[row, 2].Value);
                    turn.corrName = Convert.ToString(sheet.Cells[row, 7].Value);
                    turn.docId = Convert.ToString(sheet.Cells[row, 8].Value);
                    turn.corrAccount = Convert.ToString(sheet.Cells[row, 9].Value);
                    turn.corrBankCode = Convert.ToString(sheet.Cells[row, 10].Value);
                    turn.naznText = Convert.ToString(sheet.Cells[row, 11].Value);
                    turn.crAmount = Convert.ToString(sheet.Cells[row, 16].Value);
                    descBalanceObj.extractList.turns.Add(turn);
                    row++;
                }
                ex.ActiveWorkbook.Close(false);
                ex.Quit();
                return descBalanceObj;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
    }
}

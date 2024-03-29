﻿using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
                ex.Workbooks.Open(path_to_file,
                                    Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                                    Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                                    Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                                    Type.Missing, Type.Missing);
                ex.DisplayAlerts = false;
                Worksheet sheet = (Worksheet)ex.Worksheets.get_Item(1);

                /*descBalanceObj.accTitle = Convert.ToString(sheet.Cells[1, 1].Value);
                descBalanceObj.dateFrom = Convert.ToString(sheet.Cells[3, 4].Value.ToString().Split(' ')[1]);
                descBalanceObj.dateTo = Convert.ToString(sheet.Cells[3, 4].Value.ToString().Split(' ')[3]);

                descBalanceObj.extractList = new descBalanceExtractList();
                descBalanceObj.extractList.unp = Convert.ToString(sheet.Cells[2, 4].Value);
                descBalanceObj.extractList.dateTime = Convert.ToDateTime(sheet.Cells[4, 4].Value.ToString().Replace(",", " ").Split(' ')[0] + " " + sheet.Cells[4, 4].Value.ToString().Split(' ')[1].Replace(".", ":"));
                descBalanceObj.extractList.openingBalance = Convert.ToDecimal(sheet.Cells[6, 4].Value.ToString().Replace("BYN", "").Replace(" ", "").Replace(".", ","));
                descBalanceObj.extractList.openingBalanceNat = Convert.ToDecimal(sheet.Cells[6, 4].Value.ToString().Replace("BYN", "").Replace(" ", "").Replace(".", ","));
                descBalanceObj.extractList.tDbAmount = Convert.ToDecimal(sheet.Cells[7, 4].Value.ToString().Replace("BYN", "").Replace(" ", "").Replace(".", ","));
                descBalanceObj.extractList.tDbAmountNat = Convert.ToDecimal(sheet.Cells[7, 4].Value.ToString().Replace("BYN", "").Replace(" ", "").Replace(".", ","));
                descBalanceObj.extractList.tCrAmount = Convert.ToDecimal(sheet.Cells[8, 4].Value.ToString().Replace("BYN", "").Replace(" ", "").Replace(".", ","));
                descBalanceObj.extractList.tCrAmountNat = Convert.ToDecimal(sheet.Cells[8, 4].Value.ToString().Replace("BYN", "").Replace(" ", "").Replace(".", ","));
                descBalanceObj.extractList.closingBalance = Convert.ToDecimal(sheet.Cells[9, 4].Value.ToString().Replace("BYN", "").Replace(" ", "").Replace(".", ","));
                descBalanceObj.extractList.closingBalanceNat = Convert.ToDecimal(sheet.Cells[9, 4].Value.ToString().Replace("BYN", "").Replace(" ", "").Replace(".", ","));
                descBalanceObj.extractList.openingBalanceDate = Convert.ToDateTime(sheet.Cells[3, 4].Value.ToString().Split(' ')[1]);
                descBalanceObj.extractList.closingBalanceDate = Convert.ToDateTime(sheet.Cells[3, 4].Value.ToString().Split(' ')[3]);

                int row = 12;
                descBalanceObj.extractList.turns = new List<descBalanceExtractListTurns>();
                while (sheet.Cells[row, 1].value != null)
                {
                    descBalanceExtractListTurns turn = new descBalanceExtractListTurns();
                    turn.docDate = Convert.ToDateTime(sheet.Cells[row, 1].Value);
                    turn.docN = Convert.ToString(sheet.Cells[row, 2].Value);
                    turn.corrName = Convert.ToString(sheet.Cells[row, 7].Value);
                    turn.unp = Convert.ToString(sheet.Cells[row, 8].Value);
                    turn.corrAccount = Convert.ToString(sheet.Cells[row, 9].Value);
                    turn.corrBankCode = Convert.ToString(sheet.Cells[row, 10].Value);
                    turn.naznText = Convert.ToString(sheet.Cells[row, 11].Value);
                    turn.crAmount = Convert.ToDecimal(sheet.Cells[row, 16].Value.ToString().Replace(".", ","));
                    turn.crAmountNat = Convert.ToDecimal(sheet.Cells[row, 16].Value.ToString().Replace(".", ","));
                    descBalanceObj.extractList.turns.Add(turn);
                    row++;
                }*/

                descBalanceObj.accTitle = Convert.ToString(sheet.Cells[1, 1].Value);
                descBalanceObj.dateFrom = Convert.ToString(sheet.Cells[6, 4].Value.ToString().Split(' ')[1]);
                descBalanceObj.dateTo = Convert.ToString(sheet.Cells[6, 4].Value.ToString().Split(' ')[3]);

                descBalanceObj.extractList = new descBalanceExtractList();
                descBalanceObj.extractList.unp = Convert.ToString(sheet.Cells[5, 4].Value);
                descBalanceObj.extractList.dateTime = Convert.ToDateTime(sheet.Cells[7, 4].Value.ToString().Replace(",", " ").Split(' ')[0] + " " + sheet.Cells[7, 4].Value.ToString().Split(' ')[1].Replace(".", ":"));
                descBalanceObj.extractList.openingBalance = Convert.ToDecimal(sheet.Cells[9, 4].Value.ToString().Replace("BYN", "").Replace(" ", "").Replace(".", ","));
                descBalanceObj.extractList.openingBalanceNat = Convert.ToDecimal(sheet.Cells[9, 4].Value.ToString().Replace("BYN", "").Replace(" ", "").Replace(".", ","));
                descBalanceObj.extractList.tDbAmount = Convert.ToDecimal(sheet.Cells[10, 4].Value.ToString().Replace("BYN", "").Replace(" ", "").Replace(".", ","));
                descBalanceObj.extractList.tDbAmountNat = Convert.ToDecimal(sheet.Cells[10, 4].Value.ToString().Replace("BYN", "").Replace(" ", "").Replace(".", ","));
                descBalanceObj.extractList.tCrAmount = Convert.ToDecimal(sheet.Cells[11, 4].Value.ToString().Replace("BYN", "").Replace(" ", "").Replace(".", ","));
                descBalanceObj.extractList.tCrAmountNat = Convert.ToDecimal(sheet.Cells[11, 4].Value.ToString().Replace("BYN", "").Replace(" ", "").Replace(".", ","));
                descBalanceObj.extractList.closingBalance = Convert.ToDecimal(sheet.Cells[12, 4].Value.ToString().Replace("BYN", "").Replace(" ", "").Replace(".", ","));
                descBalanceObj.extractList.closingBalanceNat = Convert.ToDecimal(sheet.Cells[12, 4].Value.ToString().Replace("BYN", "").Replace(" ", "").Replace(".", ","));
                descBalanceObj.extractList.openingBalanceDate = Convert.ToDateTime(sheet.Cells[6, 4].Value.ToString().Split(' ')[1]);
                descBalanceObj.extractList.closingBalanceDate = Convert.ToDateTime(sheet.Cells[6, 4].Value.ToString().Split(' ')[3]);

                int row = 15;
                descBalanceObj.extractList.turns = new List<descBalanceExtractListTurns>();
                while (sheet.Cells[row, 1].value != null)
                {
                    descBalanceExtractListTurns turn = new descBalanceExtractListTurns();
                    turn.docDate = Convert.ToDateTime(sheet.Cells[row, 1].Value);
                    turn.docN = Convert.ToString(sheet.Cells[row, 2].Value);
                    turn.corrName = Convert.ToString(sheet.Cells[row, 4].Value);
                    turn.unp = Convert.ToString(sheet.Cells[row, 5].Value);
                    turn.corrAccount = Convert.ToString(sheet.Cells[row, 6].Value);
                    turn.corrBankCode = Convert.ToString(sheet.Cells[row, 7].Value);
                    turn.naznText = Convert.ToString(sheet.Cells[row, 8].Value);
                    turn.crAmount = Convert.ToDecimal(sheet.Cells[row, 13].Value.ToString().Replace(".", ","));
                    turn.crAmountNat = Convert.ToDecimal(sheet.Cells[row, 13].Value.ToString().Replace(".", ","));
                    descBalanceObj.extractList.turns.Add(turn);
                    row++;
                }

                ex.ActiveWorkbook.Close(false);
                ex.Quit();
                return descBalanceObj;
            }
            catch(Exception ex)
            {
                if (ex.HResult == -2146827284)
                    MessageBox.Show("Файл с таким именем не найден!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }
}

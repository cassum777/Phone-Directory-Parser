using System;
using Excel = Microsoft.Office.Interop.Excel;
using Worksheet = Microsoft.Office.Interop.Excel.Worksheet;

namespace PhoneDirectoryParser
{
    public class ExcelConverter
    {

        Excel.Application xlexcel;
        Excel.Workbook xlWorkBook;
        Worksheet xlWorkSheet;

        public ExcelConverter() {
            object misValue = System.Reflection.Missing.Value;
            xlexcel = new Excel.Application {
                Visible = true
            };
            xlWorkBook = xlexcel.Workbooks.Add(misValue);
            xlWorkSheet = (Worksheet)xlWorkBook.Worksheets.get_Item(1);
        }

        public void CreateDocument() {
            SettingСolumn();
            var CR = (Excel.Range)xlWorkSheet.Cells[1, 1];

            CR.Select();
            xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);
            JoinCells();
        }
        private void SettingСolumn() {
            xlWorkSheet.Rows[1].VerticalAlignment = Excel.Constants.xlCenter;
            xlWorkSheet.Rows[1].HorizontalAlignment = Excel.Constants.xlCenter;
            xlWorkSheet.Rows[1].WrapText = true;
            xlWorkSheet.Columns[1].WrapText = true;
            xlWorkSheet.Columns[1].NumberFormat = "@";
            xlWorkSheet.Columns[1].VerticalAlignment = Excel.Constants.xlTop;
            xlWorkSheet.Columns[1].ColumnWidth = 13;
            xlWorkSheet.Columns[2].ColumnWidth = 45;
            xlWorkSheet.Columns[3].ColumnWidth = 13;
            xlWorkSheet.Columns[4].ColumnWidth = 13;
            xlWorkSheet.Columns[4].NumberFormat = "@";
            xlWorkSheet.Columns[5].ColumnWidth = 20;

        }
        private void JoinCells() {
            var countGrid = Form1.CountObjectDatagrid + 2;
            int indexFirstPhone = 1;
            int indexEndPhone = 1;

            for (var i = 2; i <= countGrid; i++) {
                if (xlWorkSheet.Cells[i, 5].Value2 == null) {
                    //объеденение 2-7 ячеек строки итогов
                    xlWorkSheet.Range[xlWorkSheet.Cells[i, 2], xlWorkSheet.Cells[i, 7]].Merge();
                    //сделать текст строки жирным
                    xlWorkSheet.Cells[i, 1].EntireRow.Font.Bold = true;
                }
                if (xlWorkSheet.Cells[i, 1].Value2 != null) {
                    //объеденение первого столбца
                    indexEndPhone = i - 1;
                    xlWorkSheet.Range[xlWorkSheet.Cells[indexFirstPhone, 1], xlWorkSheet.Cells[indexEndPhone, 1]].Merge();

                    indexFirstPhone = i;
                }
            }

        }
    }
}

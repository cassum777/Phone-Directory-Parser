using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;

namespace PhoneDirectoryParser
{
    public partial class Form1 : Form
    {
        public Form1() {
            InitializeComponent();
        }

        private void ButtonOpenPhoneDirectory_Click(object sender, EventArgs e) {
            if (openFileDialog1.ShowDialog() == DialogResult.OK) {

                var filePath = openFileDialog1.FileName;
                var textLoader = new TextLoader();
                var callList = textLoader.GetContent(filePath);
                DataGridAdd(callList);
            }

        }
        private void DataGridAdd(List<Call> callList) {
            var length = callList.Count;

            if (length == 0) {
                return;
            }
            var i = 0;
            var phoneNumber = callList[i].PhoneNumber;


            dataGridView1.Rows.Add(phoneNumber, callList[i].NameOfService, callList[i].Direction, callList[i].CalledNumber,
                                   callList[i].DateAndTimeToStartAConversation, callList[i].DurationOfMinutes, callList[i].Cost);

            var indexFirst = 0;
            int indexEnd;
            while (++i < length) {
                long? phoneNumberOrNull;
                if (phoneNumber == callList[i].PhoneNumber) {
                    phoneNumberOrNull = null;
                } else {
                    phoneNumber = callList[i].PhoneNumber;
                    phoneNumberOrNull = phoneNumber;
                    indexEnd = i - 1;
                    DataGridAddTotal(callList, indexFirst, indexEnd);
                    indexFirst = i;
                }
                dataGridView1.Rows.Add(phoneNumberOrNull, callList[i].NameOfService, callList[i].Direction, callList[i].CalledNumber,
                                   callList[i].DateAndTimeToStartAConversation, callList[i].DurationOfMinutes, callList[i].Cost);
            }
            indexEnd = callList.Count - 1;

            DataGridAddTotal(callList, indexFirst, indexEnd);


            DataGridAddAllTotal(callList);
        }
        private void DataGridAddTotal(List<Call> callList, int indexFirst, int indexEnd) {
            int nMinutes = 0;
            decimal nCost = 0;
            for (int i = indexFirst; i <= indexEnd; i++) {
                nMinutes += callList[i].DurationOfMinutes;
                nCost += callList[i].Cost;
            }
            dataGridView1.Rows.Add($"Итого по: {callList[indexFirst].PhoneNumber}", null, null, $"Количество разговоров: {indexEnd - indexFirst + 1}", null, $"Количество минут: {nMinutes}", $"На сумму: {nCost}");
        }
        private void DataGridAddAllTotal(List<Call> callList) {
            var nMinutes = callList.Sum(x => x.DurationOfMinutes);
            var nCost = callList.Sum(x => x.Cost);
            dataGridView1.Rows.Add("Итого:", null, null, $"Количество разговоров: {callList.Count}", null, $"Количество минут: {nMinutes}", $"На сумму: {nCost}");
        }
        private void CopyAlltoClipboard() {
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.SelectAll();
            DataObject dataObj = dataGridView1.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
        }

        private void ButtonToExcel_Click(object sender, EventArgs e) {
            CopyAlltoClipboard();
            Excel.Application xlexcel;
            Workbook xlWorkBook;
            Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;
            xlexcel = new Excel.Application {
                Visible = true
            };
            xlWorkBook = xlexcel.Workbooks.Add(misValue);
            xlWorkSheet = (Worksheet)xlWorkBook.Worksheets.get_Item(1);
            var CR = (Range)xlWorkSheet.Cells[1, 1];
            CR.Select();
            xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);
        }
    }
}

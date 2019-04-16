using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PhoneDirectoryParser
{
    public partial class Form1 : Form
    {
        public static int CountObjectDatagrid { get; private set; }
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
            CountObjectDatagrid = callList.Count;
            var count = callList.Count;

            if (CountObjectDatagrid == 0) {
                return;
            }
            var i = 0;
            var phoneNumber = callList[i].PhoneNumber;
            //var nameOfServece = callList[i].NameOfService;

            dataGridView1.Rows.Add(phoneNumber, callList[i].NameOfService, callList[i].Direction, callList[i].CalledNumber,
                                   callList[i].DateAndTimeToStartAConversation, callList[i].DurationOfMinutes, callList[i].Cost);

            var indexFirst = 0;
            int indexEnd;
            while (++i < count) {
                long? phoneNumberOrNull;
                //string nameOfServeceOrNull;

                if (phoneNumber == callList[i].PhoneNumber) {
                    phoneNumberOrNull = null;
                } else {
                    CountObjectDatagrid++;
                    phoneNumber = callList[i].PhoneNumber;
                    phoneNumberOrNull = phoneNumber;
                    indexEnd = i - 1;
                    DataGridAddTotal(callList, indexFirst, indexEnd);
                    indexFirst = i;
                }

                //nameOfServeceOrNull = nameOfServece == callList[i].NameOfService ? null : (nameOfServece = callList[i].NameOfService);

                dataGridView1.Rows.Add(phoneNumberOrNull, callList[i].NameOfService, callList[i].Direction, callList[i].CalledNumber,
                                   callList[i].DateAndTimeToStartAConversation, callList[i].DurationOfMinutes, callList[i].Cost);
            }
            indexEnd = callList.Count - 1;
            CountObjectDatagrid++;
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
            dataGridView1.Rows.Add("Итого по ", $"номеру: {callList[indexFirst].PhoneNumber}    Количество разговоров: {indexEnd - indexFirst + 1}    Количество минут: {nMinutes}    На сумму: {nCost}");
        }
        private void DataGridAddAllTotal(List<Call> callList) {
            var nMinutes = callList.Sum(x => x.DurationOfMinutes);
            var nCost = callList.Sum(x => x.Cost);
            dataGridView1.Rows.Add("Итого: ", $"количество разговоров: {callList.Count}    Количество минут: {nMinutes}    На сумму: {nCost}");
        }
        private void CopyAlltoClipboard() {
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dataGridView1.SelectAll();
            DataObject dataObj = dataGridView1.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
        }

        private void ButtonToExcel_Click(object sender, EventArgs e) {
            CopyAlltoClipboard();
            var documentExcel = new ExcelConverter();
            documentExcel.CreateDocument();
        }

    }
}

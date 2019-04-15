using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        private void DataGridAdd(List<PhoneDirectory> phoneDirectories) {
            int length = phoneDirectories.Count;
            if(length == 0) {
                return;
            }
            int indexFirst = 0;
            int indexEnd = 0;
            long phoneNumber = phoneDirectories[0].PhoneNumber;

            dataGridView1.Rows.Add(phoneNumber, phoneDirectories[0].NameOfService, phoneDirectories[0].Direction, phoneDirectories[0].CalledNumber,
                                   phoneDirectories[0].DateAndTimeToStartAConversation, phoneDirectories[0].DurationOfMinutes, phoneDirectories[0].Cost);


            for(var i = 1; i < length; i++) {
                if(phoneNumber == phoneDirectories[i].PhoneNumber) {
                    dataGridView1.Rows.Add(null, phoneDirectories[i].NameOfService, phoneDirectories[i].Direction, phoneDirectories[i].CalledNumber,
                   phoneDirectories[i].DateAndTimeToStartAConversation, phoneDirectories[i].DurationOfMinutes, phoneDirectories[i].Cost);
                } else {
                    phoneNumber = phoneDirectories[i].PhoneNumber;

                    indexEnd = i - 1;
                    DataGridAddTotal(phoneDirectories, indexFirst, indexEnd);
                    indexFirst = i;

                    dataGridView1.Rows.Add(phoneDirectories[i].PhoneNumber, phoneDirectories[i].NameOfService, phoneDirectories[i].Direction, phoneDirectories[i].CalledNumber,
                    phoneDirectories[i].DateAndTimeToStartAConversation, phoneDirectories[i].DurationOfMinutes, phoneDirectories[i].Cost);
                }
            }
            indexEnd = phoneDirectories.Count - 1;

            DataGridAddTotal(phoneDirectories, indexFirst, indexEnd);


            DataGridAddAllTotal(phoneDirectories);
        }
        private void DataGridAddTotal(List<PhoneDirectory> phoneDirectories, int indexFirst, int indexEnd) {
            int nMinutes = 0;
            decimal nCost = 0;
            for(int i = indexFirst; i <= indexEnd; i++) {
                nMinutes += phoneDirectories[i].DurationOfMinutes;
                nCost += phoneDirectories[i].Cost;
            }
            dataGridView1.Rows.Add($"Итого по: {phoneDirectories[indexFirst].PhoneNumber}", null, null,
                     $"Количество разговоров: {indexEnd - indexFirst + 1}",null, $"Количество минут: {nMinutes}", $"На сумму: {nCost}");
        }
        private void DataGridAddAllTotal(List<PhoneDirectory> phoneDirectories) {
            var nMinutes = phoneDirectories.Sum(x => x.DurationOfMinutes);
            var nCost = phoneDirectories.Sum(x => x.Cost);
            dataGridView1.Rows.Add("Итого:", null, null, $"Количество разговоров: {phoneDirectories.Count}", null, $"Количество минут: {nMinutes}", $"На сумму: {nCost}");
        }
        private void ButtonExportToExcel_Click(object sender, EventArgs e) {
 
        }
    }
}

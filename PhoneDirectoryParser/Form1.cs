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

            }

        }

        private void ButtonExportToExcel_Click(object sender, EventArgs e) {
            var dd = new EPPlus(TextLoader.AplicationPath, )
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneDirectoryParser
{
    public class TextLoader {

        public static string AplicationPath { get; } = Environment.CurrentDirectory;

        public string folderName = "PhoneDirectory";

        static readonly Encoding defaulEncoding = Encoding.GetEncoding("Windows-1251");

        public List<PhoneDirectory> GetContent(string filePatch) {
            var callList = new List<PhoneDirectory>();
            using (var sr = new StreamReader(filePatch, defaulEncoding)) {
                sr.ReadLine();
                while (!sr.EndOfStream) {
                    callList.Add(new PhoneDirectory(sr.ReadLine().Split('|')));
                }
                return callList;
            };
        }
        public void Save() {
            var folderPath = Path.Combine(AplicationPath, folderName);
            if (!Directory.Exists(folderPath)) {
                Directory.CreateDirectory(folderPath);
            }
        }
    }
}

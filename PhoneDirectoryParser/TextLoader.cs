using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace PhoneDirectoryParser
{
    public class TextLoader {

        public static string AplicationPath { get; } = Environment.CurrentDirectory;

        public string folderName = "PhoneDirectory";

        static readonly Encoding defaulEncoding = Encoding.GetEncoding("Windows-1251");

        public List<Call> GetContent(string filePatch) {
            var callList = new List<Call>();
            using (var sr = new StreamReader(filePatch, defaulEncoding)) {
                sr.ReadLine();
                while (!sr.EndOfStream) {
                    callList.Add(new Call(sr.ReadLine().Split('|')));
                }
                return callList.OrderBy(x => x.PhoneNumber).ToList();
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

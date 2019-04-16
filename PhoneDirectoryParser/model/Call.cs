using System;

namespace PhoneDirectoryParser
{
    public class Call
    {
        
        public Call(params string[] callLine) {
            PhoneNumber = long.Parse(callLine[0]);
            NameOfService = callLine[1].Replace("Исходящее", "Исх.").Replace("соединение", "соед.");
            Direction = callLine[2];
            CalledNumber = long.Parse(callLine[3]);
            DateAndTimeToStartAConversation = DateTime.Parse(callLine[4]);
            DurationOfMinutes = int.Parse(callLine[5]);
            Cost = decimal.Parse(callLine[6], System.Globalization.NumberStyles.AllowDecimalPoint, System.Globalization.NumberFormatInfo.InvariantInfo);
        }

        public long PhoneNumber { get; set; }

        public string NameOfService { get; set; }

        public string Direction { get; set; }

        public long CalledNumber { get; set; }

        public DateTime DateAndTimeToStartAConversation { get; set; }

        public int DurationOfMinutes { get; set; }

        public decimal Cost { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneDirectoryParser
{
    public class PhoneDirectory
    {
        public PhoneDirectory(string phoneNumber, string nameOfService, string direction, string calledNumber, string dateAndTimeToStartAConversation, string durationOfMinutes, string cost) {
            PhoneNumber = long.Parse(phoneNumber);
            NameOfService = nameOfService;
            Direction = direction;
            CalledNumber = long.Parse(calledNumber);
            DateAndTimeToStartAConversation = DateTime.Parse(dateAndTimeToStartAConversation);
            DurationOfMinutes = int.Parse(durationOfMinutes);
            Cost = double.Parse(cost);
        }
        public PhoneDirectory(params string[] callLine) {
            PhoneNumber = long.Parse(callLine[0]);
            NameOfService = callLine[1];
            Direction = callLine[2];
            CalledNumber = long.Parse(callLine[3]);
            DateAndTimeToStartAConversation = DateTime.Parse(callLine[4]);
            DurationOfMinutes = int.Parse(callLine[5]);
            Cost = double.Parse(callLine[6], System.Globalization.NumberStyles.AllowDecimalPoint, System.Globalization.NumberFormatInfo.InvariantInfo);
        }

        public long PhoneNumber { get; set; }

        public string NameOfService { get; set; }

        public string Direction { get; set; }

        public long CalledNumber { get; set; }

        public DateTime DateAndTimeToStartAConversation { get; set; }

        public int DurationOfMinutes { get; set; }

        public double Cost { get; set; }
    }
}

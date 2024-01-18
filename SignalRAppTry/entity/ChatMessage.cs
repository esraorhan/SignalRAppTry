using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SignalRAppTry.entity
{
    public class ChatMessage
    {
        [Key]
        public int ID { get; set; }
        public string User { get; set; }
        public string Message { get; set; }
        public DateTime SendTime { get; set; }
    }
}

using System;

namespace BLL.DTOs
{
    public class MessageDTO
    {
        public int ChatId { get; set; }

        public string MessageContent { get; set; }

        public DateTime TimeStamp { get; set; }

        public int SenderId { get; set; }

        public int ChatListId { get; set; }
    }
}

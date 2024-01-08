namespace BLL.DTOs
{
    public class NotificationDTO
    {
        public int NotificationId { get; set; }

        public int ReceiverId { get; set; }

        public string Content { get; set; }

        public string Type { get; set; }

        public bool IsRead { get; set; }

        public string RedirectUrl { get; set; }
    }
}

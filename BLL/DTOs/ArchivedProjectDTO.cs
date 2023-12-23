﻿using System;

namespace BLL.DTOs
{
    internal class ArchivedProjectDTO
    {
        public int ProjectId { get; set; }

        public int ClientId { get; set; }

        public DateTime CompletionDate { get; set; }

        public string Review { get; set; }

        public int Rating { get; set; }

        public int Revenue { get; set; }

        public byte[] Picture { get; set; }
    }
}

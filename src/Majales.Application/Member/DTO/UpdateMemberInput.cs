﻿using System;
namespace Majales.Member.DTO
{
    public class UpdateMemberInput
    {
        public int Id { get; set; }
        public string Avatar { get; set; }
        public string NationalId { get; set; }
        public string JobTitle { get; set; }
        public string Degree { get; set; }
        public string College { get; set; }
        public string Department { get; set; }
        public long UserId { get; set; }
    
    }
}

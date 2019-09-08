using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities.Auditing;
using Majales.Authorization.Users;

namespace Majales.Models
{
    public class Member : FullAuditedEntity
    {

        public string Avatar { get; set; }
        public string NationalId { get; set; }
        
        public string JobTitle { get; set; }
        public string Degree { get; set; }
        public string College { get; set; }
        public string Department { get; set; }

        public virtual MeetingAttendance MeetingAttendance { get; set; }
        public virtual ICollection<MajlisMembership> membership { get; set; }
        public virtual ICollection<Vote> Votes { get; set; }
       public virtual ICollection<Comment> Comments { get; set; }

        public virtual ICollection<MeetingMinutes> meeting_Minutes { get; set; }
        
        [ForeignKey("User")]
        public long UserId { get; set; }
        public virtual User User { get; set; }


        public Member()
        {
            membership = new Collection<MajlisMembership>();
            Votes      = new Collection<Vote>();
            Comments   = new Collection<Comment>();
            meeting_Minutes = new Collection<MeetingMinutes>();
        }
        
    }
}
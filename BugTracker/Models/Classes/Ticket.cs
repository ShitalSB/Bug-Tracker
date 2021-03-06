﻿using System;
using System.Collections.Generic;

namespace BugTracker.Models.Classes
{
    public class Ticket
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTimeOffset Created { get; set; }
        public DateTimeOffset? Updated { get; set; }
        
        public string CreatorId { get; set; }
        public virtual ApplicationUser Creator { get; set; }

        public string  AssignId { get; set; }
        public virtual ApplicationUser Assign { get; set; }

        public int TicketTypeId { get; set; }
        public virtual Type TicketType { get; set; }

        public int TicketProjectId { get; set; }
        public virtual Project TicketProject { get; set; }

        public int TicketPriorityId { get; set; }
        public virtual Priority TicketPriority { get; set; }

        public int TicketStatusId { get; set; }
        public virtual Status TicketStatus { get; set; }

        public virtual ICollection<Attechments> Attechments { get; set; }
        public virtual ICollection<Comment>Comments { get; set; }
        public virtual ICollection<History> Histories { get; set; }
        public Ticket()
        {
            Created = DateTime.Now;
            Attechments = new HashSet<Attechments>();
            Comments = new HashSet<Comment>();
            Histories = new HashSet<History>();
        }
    }
}
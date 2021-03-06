﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BugTracker.Models.Classes
{
    public class Project
    {
        public Project()
        {
            Users = new HashSet<ApplicationUser>();
            Tickets = new HashSet<Ticket>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<ApplicationUser> Users { get; set; }
        public virtual ICollection<Ticket> Tickets { get; set; }
    }
}
﻿using Socialmedia.core.Entities;
using System;
using System.Collections.Generic;

#nullable disable
namespace Socialmedia.Core.Entities
{
    public partial class Comment : BaseEntity
    {
        //public int CommentId { get; set; }
        public int PostId { get; set; }
        public int UserId { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public bool IsActive { get; set; }

        public virtual Post Post { get; set; }
        public virtual User User { get; set; }
    }
}

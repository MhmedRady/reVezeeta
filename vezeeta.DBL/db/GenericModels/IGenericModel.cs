﻿using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace vezeeta.DBL
{
    public interface IGenericModel
    {
        public Guid Id { get; set; }   
        [Comment("Created At DateTime")]
        public DateTime? created_at { get; set; }
        [Comment("Last Update DateTime")]
        public DateTime? updated_at { get; set; }
    }
}

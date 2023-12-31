﻿using DataAccess.IRepositories;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DataAccess.Entities
{
    public class SaleOff : IEntity
    {
        [Key]
        public string Id { get; set; }
        public double? Discount { get; set; }
        public DateTime? BeginDatetime { get; set; }
        public DateTime? ExpiryDatetime { get; set; }
        public int? Numbers { get; set; }
        public string? Description { get; set; }
        public bool Active { get; set; } = false;
        public DateTime? SysDate { get; set; }

        public virtual Hotel? HotelCodeByUser { get; set; }
        
        public string? HotelCodeByUserId { get; set; }
    }
}

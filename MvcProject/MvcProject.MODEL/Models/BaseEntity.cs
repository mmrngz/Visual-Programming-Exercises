﻿using MvcProject.MODEL.Enums;
using System;

namespace MvcProject.MODEL.Models
{
    public class BaseEntity
    {
        public BaseEntity() 
        {
            DateTime= DateTime.Now;
            Status = DataStatus.Inserted;
        }
        public int ID { get; set; } 
        public DataStatus Status { get; set; }
        public DateTime DateTime { get; set; }  
        public DateTime ModifiedDate { get; set; }      

    }
}

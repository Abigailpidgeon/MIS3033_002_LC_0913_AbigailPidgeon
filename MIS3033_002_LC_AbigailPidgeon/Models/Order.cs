﻿
using System.ComponentModel.DataAnnotations;

namespace a
{
    public class Order
    {
        [Key]//primary key in this table
        public int Id { get; set; }
        public double QtyApple { get; set; }
        public double QtyBanana { get; set; }

    }
}

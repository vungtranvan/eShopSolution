﻿using eShopSolution.Data.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Entities
{
    public class Slider
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public string Description { set; get; }
        public string Image { set; get; }
        public string Url { set; get; }
        public int SortOrder { set; get; }
        public Status Status { set; get; }
    }
}

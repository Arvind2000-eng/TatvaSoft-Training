﻿using System;
using System.Collections.Generic;

#nullable disable

namespace HelperLand.Models
{
    public partial class State
    {
        public State()
        {
            Cities = new HashSet<City>();
        }

        public int StateId { get; set; }
        public string StateName { get; set; }

        public virtual ICollection<City> Cities { get; set; }
    }
}

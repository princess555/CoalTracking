﻿using CTS_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CTS_Manual_Input.Models.Dictionary
{
    public class WagonScalesLocations
    {
        public WagonScale WagonScale { get; set; }
        public SelectList Locations { get; set; }
    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rolcore
{
    /// <summary>
    /// Contains constants related to minutes.
    /// </summary>
    public class Minutes
    {
        /// <summary>
        /// Minutes per hour.
        /// </summary>
        public const int PerHour = 60;

        /// <summary>
        /// Minutes per day.
        /// </summary>
        public const int PerDay = Minutes.PerHour * Hours.PerDay;
    }
}

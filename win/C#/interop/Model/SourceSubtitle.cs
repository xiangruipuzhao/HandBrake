﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HandBrake.Interop
{
    public class SourceSubtitle
    {
        /// <summary>
        /// Gets or sets the 1-based subtitle track number. 0 means foriegn audio search.
        /// </summary>
        public int TrackNumber { get; set; }
        public bool Default { get; set; }
        public bool Forced { get; set; }
        public bool BurnedIn { get; set; }

        public SourceSubtitle Clone()
        {
            return new SourceSubtitle
            {
                TrackNumber = this.TrackNumber,
                Default = this.Default,
                Forced = this.Forced,
                BurnedIn = this.BurnedIn
            };
        }
    }
}

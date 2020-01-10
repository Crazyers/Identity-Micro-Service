﻿using System;
using System.Collections.Generic;

namespace Microfisher.Snowflake.Core.Models
{
    public class Paging<T>
    {
        public long PageIndex { get; set; }

        public long PageCount { get; set; }

        public long RecordCount { get; set; }

        public List<T> PageData { get; set; }

    }
}

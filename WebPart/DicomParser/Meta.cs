﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace DicomParser
{
    public class Meta
    {
        public string GroupTag { get; set; }
        public string ElementTag { get; set; }
        public string Description { get; set; }
        public string Value { get; set; }

        public override bool Equals(object obj)
        {
            if (!(obj is Meta meta))
                return false;
            return Description == meta.Description;
        }
        public override string ToString()
            => JsonConvert.SerializeObject(this);
    }
}

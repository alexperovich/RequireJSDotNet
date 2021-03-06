﻿// RequireJS.NET
// Copyright VeriTech.io
// http://veritech.io
// Dual licensed under the MIT and GPL licenses:
// http://www.opensource.org/licenses/mit-license.php
// http://www.gnu.org/licenses/gpl.html

namespace RequireJsNet.Models
{
    public class BundleItem
    {
        public string ModuleName { get; set; }

        public string CompressionType { get; set; }

        public string RelativePath { get; set; }
    }
}

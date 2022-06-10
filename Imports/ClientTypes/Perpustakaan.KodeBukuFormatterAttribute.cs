using Serenity;
using Serenity.ComponentModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace SerenPro.Perpustakaan
{
    public partial class KodeBukuFormatterAttribute : CustomFormatterAttribute
    {
        public const string Key = "SerenPro.Perpustakaan.KodeBukuFormatter";

        public KodeBukuFormatterAttribute()
            : base(Key)
        {
        }
    }
}

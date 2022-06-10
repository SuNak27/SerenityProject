using Serenity;
using Serenity.ComponentModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace SerenPro.Perpustakaan
{
    public partial class PengarangFormatterAttribute : CustomFormatterAttribute
    {
        public const string Key = "SerenPro.Perpustakaan.PengarangFormatter";

        public PengarangFormatterAttribute()
            : base(Key)
        {
        }
    }
}

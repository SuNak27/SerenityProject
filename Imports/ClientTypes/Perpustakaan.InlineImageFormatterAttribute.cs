using Serenity;
using Serenity.ComponentModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace SerenPro.Perpustakaan
{
    public partial class InlineImageFormatterAttribute : CustomFormatterAttribute
    {
        public const string Key = "SerenPro.Perpustakaan.InlineImageFormatter";

        public InlineImageFormatterAttribute()
            : base(Key)
        {
        }

        public string FileProperty
        {
            get { return GetOption<string>("fileProperty"); }
            set { SetOption("fileProperty", value); }
        }

        public bool Thumb
        {
            get { return GetOption<bool>("thumb"); }
            set { SetOption("thumb", value); }
        }
    }
}

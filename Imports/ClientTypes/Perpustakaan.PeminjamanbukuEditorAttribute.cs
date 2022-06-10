using Serenity;
using Serenity.ComponentModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace SerenPro.Perpustakaan
{
    public partial class PeminjamanbukuEditorAttribute : CustomEditorAttribute
    {
        public const string Key = "SerenPro.Perpustakaan.PeminjamanbukuEditor";

        public PeminjamanbukuEditorAttribute()
            : base(Key)
        {
        }
    }
}

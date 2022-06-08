using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace SerenPro.Perpustakaan.Forms
{
    [FormScript("Perpustakaan.Kategori")]
    [BasedOnRow(typeof(KategoriRow), CheckNames = true)]
    public class KategoriForm
    {
        public string Nama { get; set; }
    }
}
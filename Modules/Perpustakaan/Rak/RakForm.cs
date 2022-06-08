using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace SerenPro.Perpustakaan.Forms
{
    [FormScript("Perpustakaan.Rak")]
    [BasedOnRow(typeof(RakRow), CheckNames = true)]
    public class RakForm
    {
        public string Rak { get; set; }
    }
}
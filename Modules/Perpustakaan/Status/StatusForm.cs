using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace SerenPro.Perpustakaan.Forms
{
    [FormScript("Perpustakaan.Status")]
    [BasedOnRow(typeof(StatusRow), CheckNames = true)]
    public class StatusForm
    {
        public string Status { get; set; }
    }
}
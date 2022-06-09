using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace SerenPro.Perpustakaan.Columns
{
    [ColumnsScript("Perpustakaan.Status")]
    [BasedOnRow(typeof(StatusRow), CheckNames = true)]
    public class StatusColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public int Id { get; set; }
        [EditLink]
        public string Status { get; set; }
    }
}
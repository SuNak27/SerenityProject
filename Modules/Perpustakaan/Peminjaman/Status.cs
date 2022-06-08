using System.ComponentModel;
using Serenity.ComponentModel;

namespace SerenPro.Perpustakaan
{
  [EnumKey("Perpustakaan.Status")]
  public enum Status
  {
    [Description("Dipinjam")]
    Dipinjam = 1,
    [Description("Dikembalikan")]
    Dikembalikan = 2,
  }
}
using System.ComponentModel;
using Serenity.ComponentModel;

namespace SerenPro.Administration
{
  [EnumKey("Administration.JenKel")]
  public enum JenKel
  {
    [Description("Laki - Laki")]
    LakiLaki = 1,
    [Description("Perempuan")]
    Perempuan = 2
  }
}
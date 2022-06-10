namespace SerenPro.Perpustakaan {
  @Serenity.Decorators.registerFormatter()
  export class JudulBukuFormatter implements Slick.Formatter {
    format(ctx: Slick.FormatterContext) {
      if (ctx.item.IdBuku == "" || ctx.item.IdBuku == null) {
        return "<span class''>-</span>";
      } else {
        var jenis = SerenPro.Perpustakaan.BukuRow.getLookup().itemById[parseInt(ctx.item.IdBuku)].JudulBuku;

        return `<span>${jenis}</span>`;
      }
    }
  }

  @Serenity.Decorators.registerFormatter()
  export class PenerbitFormatter implements Slick.Formatter {
    format(ctx: Slick.FormatterContext) {
      if (ctx.item.IdBuku == "" || ctx.item.IdBuku == null) {
        return "<span class''>-</span>";
      } else {
        var jenis = SerenPro.Perpustakaan.BukuRow.getLookup().itemById[parseInt(ctx.item.IdBuku)].Penerbit;

        return `<span>${jenis}</span>`;
      }
    }
  }

  @Serenity.Decorators.registerFormatter()
  export class PengarangFormatter implements Slick.Formatter {
    format(ctx: Slick.FormatterContext) {
      if (ctx.item.IdBuku == "" || ctx.item.IdBuku == null) {
        return "<span class''>-</span>";
      } else {
        var jenis = SerenPro.Perpustakaan.BukuRow.getLookup().itemById[parseInt(ctx.item.IdBuku)].Pengarang;

        return `<span>${jenis}</span>`;
      }
    }
  }

  @Serenity.Decorators.registerFormatter()
  export class DeskripsiFormatter implements Slick.Formatter {
    format(ctx: Slick.FormatterContext) {
      if (ctx.item.IdBuku == "" || ctx.item.IdBuku == null) {
        return "<span class''>-</span>";
      } else {
        var jenis = SerenPro.Perpustakaan.BukuRow.getLookup().itemById[parseInt(ctx.item.IdBuku)].DeskripsiBuku;

        return `<span>${jenis}</span>`;
      }
    }
  }

  @Serenity.Decorators.registerFormatter()
  export class GambarFormatter implements Slick.Formatter {
    format(ctx: Slick.FormatterContext) {
      if (ctx.item.IdBuku == "" || ctx.item.IdBuku == null) {
        return "<span class''>-</span>";
      } else {
        var jenis = SerenPro.Perpustakaan.BukuRow.getLookup().itemById[parseInt(ctx.item.IdBuku)].Gambar;

        return `<img style='max-height: 145px; max-width: 100%;' src='/upload/${jenis}'>`;

      }
    }
  }

  @Serenity.Decorators.registerFormatter()
  export class KodeBukuFormatter implements Slick.Formatter {
    format(ctx: Slick.FormatterContext) {
      if (ctx.item.IdBuku == "" || ctx.item.IdBuku == null) {
        return "<span class''>-</span>";
      } else {
        var jenis = SerenPro.Perpustakaan.BukuRow.getLookup().itemById[parseInt(ctx.item.IdBuku)].KodeBuku;

        return `<span>${jenis}</span>`;

      }
    }
  }



}
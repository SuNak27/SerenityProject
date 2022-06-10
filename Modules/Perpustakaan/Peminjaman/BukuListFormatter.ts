namespace SerenPro.Perpustakaan {

  @Serenity.Decorators.registerFormatter()
  export class BukuListFormatter implements Slick.Formatter {
    format(ctx: Slick.FormatterContext) {
      let idList = ctx.value;
      if (!idList || !idList.length)
        return "";

      return idList.map(x => {
        return x.IdBukuJudulBuku;
      }).join(", ");
    }
  }
}
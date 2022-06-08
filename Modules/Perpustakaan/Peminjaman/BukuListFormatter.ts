namespace SerenPro.Perpustakaan {

  @Serenity.Decorators.registerFormatter()
  export class BukuListFormatter implements Slick.Formatter {
    format(ctx: Slick.FormatterContext) {
      let idList = ctx.value as number[];
      if (!idList || !idList.length)
        return "";

      let byId = BukuRow.getLookup().itemById;

      return idList.map(x => {
        let g = byId[x];
        if (!g)
          return x.toString();

        return Q.htmlEncode(g.JudulBuku);
      }).join(", ");
    }
  }
}
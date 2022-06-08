using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.SaveRequest<SerenPro.Perpustakaan.KategoriRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = SerenPro.Perpustakaan.KategoriRow;

namespace SerenPro.Perpustakaan
{
    public interface IKategoriSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class KategoriSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IKategoriSaveHandler
    {
        public KategoriSaveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}
using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.SaveRequest<SerenPro.Perpustakaan.PeminjamanbukuRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = SerenPro.Perpustakaan.PeminjamanbukuRow;

namespace SerenPro.Perpustakaan
{
    public interface IPeminjamanbukuSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class PeminjamanbukuSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IPeminjamanbukuSaveHandler
    {
        public PeminjamanbukuSaveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}
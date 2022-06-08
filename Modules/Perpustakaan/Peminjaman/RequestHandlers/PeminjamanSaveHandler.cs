using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.SaveRequest<SerenPro.Perpustakaan.PeminjamanRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = SerenPro.Perpustakaan.PeminjamanRow;

namespace SerenPro.Perpustakaan
{
    public interface IPeminjamanSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class PeminjamanSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IPeminjamanSaveHandler
    {
        public PeminjamanSaveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}
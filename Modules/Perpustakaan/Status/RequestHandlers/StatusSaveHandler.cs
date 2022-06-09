using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.SaveRequest<SerenPro.Perpustakaan.StatusRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = SerenPro.Perpustakaan.StatusRow;

namespace SerenPro.Perpustakaan
{
    public interface IStatusSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class StatusSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IStatusSaveHandler
    {
        public StatusSaveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}
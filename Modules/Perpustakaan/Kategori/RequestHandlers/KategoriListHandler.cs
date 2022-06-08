using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<SerenPro.Perpustakaan.KategoriRow>;
using MyRow = SerenPro.Perpustakaan.KategoriRow;

namespace SerenPro.Perpustakaan
{
    public interface IKategoriListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class KategoriListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IKategoriListHandler
    {
        public KategoriListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}
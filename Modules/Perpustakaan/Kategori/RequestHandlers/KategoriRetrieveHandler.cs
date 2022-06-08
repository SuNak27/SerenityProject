using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<SerenPro.Perpustakaan.KategoriRow>;
using MyRow = SerenPro.Perpustakaan.KategoriRow;

namespace SerenPro.Perpustakaan
{
    public interface IKategoriRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

    public class KategoriRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IKategoriRetrieveHandler
    {
        public KategoriRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}
using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = SerenPro.Perpustakaan.KategoriRow;

namespace SerenPro.Perpustakaan
{
    public interface IKategoriDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

    public class KategoriDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IKategoriDeleteHandler
    {
        public KategoriDeleteHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}
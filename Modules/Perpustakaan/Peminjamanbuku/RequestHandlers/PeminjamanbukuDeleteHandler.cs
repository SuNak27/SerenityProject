using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = SerenPro.Perpustakaan.PeminjamanbukuRow;

namespace SerenPro.Perpustakaan
{
    public interface IPeminjamanbukuDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

    public class PeminjamanbukuDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IPeminjamanbukuDeleteHandler
    {
        public PeminjamanbukuDeleteHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}
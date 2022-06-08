using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = SerenPro.Perpustakaan.BukuRow;

namespace SerenPro.Perpustakaan
{
    public interface IBukuDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

    public class BukuDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IBukuDeleteHandler
    {
        public BukuDeleteHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}
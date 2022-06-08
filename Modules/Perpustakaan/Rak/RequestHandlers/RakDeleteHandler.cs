using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = SerenPro.Perpustakaan.RakRow;

namespace SerenPro.Perpustakaan
{
    public interface IRakDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

    public class RakDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IRakDeleteHandler
    {
        public RakDeleteHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}
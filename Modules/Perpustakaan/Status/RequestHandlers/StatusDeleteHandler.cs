using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = SerenPro.Perpustakaan.StatusRow;

namespace SerenPro.Perpustakaan
{
    public interface IStatusDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

    public class StatusDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IStatusDeleteHandler
    {
        public StatusDeleteHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}
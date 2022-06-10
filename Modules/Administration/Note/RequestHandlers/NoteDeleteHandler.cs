using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = SerenPro.Administration.NoteRow;

namespace SerenPro.Administration
{
    public interface INoteDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

    public class NoteDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, INoteDeleteHandler
    {
        public NoteDeleteHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}
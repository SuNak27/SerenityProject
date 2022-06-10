using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.SaveRequest<SerenPro.Administration.NoteRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = SerenPro.Administration.NoteRow;

namespace SerenPro.Administration
{
    public interface INoteSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

    public class NoteSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, INoteSaveHandler
    {
        public NoteSaveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}
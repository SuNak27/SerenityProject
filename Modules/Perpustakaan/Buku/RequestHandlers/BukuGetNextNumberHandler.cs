using Serenity.Extensions;
using Serenity.Services;
using System.Data;
using MyRow = SerenPro.Perpustakaan.BukuRow;

namespace SerenPro.Perpustakaan
{
    public interface IBukuGetNextNumberHandler : IRequestHandler
    {
        GetNextNumberResponse GetNextNumber(IDbConnection connection, GetNextNumberRequest request);
    }

    public class BukuGetNextNumberHandler : IBukuGetNextNumberHandler
    {
        public GetNextNumberResponse GetNextNumber(IDbConnection connection, GetNextNumberRequest request)
        {
            return GetNextNumberHelper.GetNextNumber(connection, request, MyRow.Fields.KodeBuku);
        }
    }
}
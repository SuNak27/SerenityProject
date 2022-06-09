using Serenity.Extensions;
using Serenity.Services;
using System.Data;
using MyRow = SerenPro.Perpustakaan.PeminjamanRow;

namespace SerenPro.Perpustakaan
{
    public interface IPeminjamanGetNextNumberHandler : IRequestHandler
    {
        GetNextNumberResponse GetNextNumber(IDbConnection connection, GetNextNumberRequest request);
    }

    public class PeminjamanGetNextNumberHandler : IPeminjamanGetNextNumberHandler
    {
        public GetNextNumberResponse GetNextNumber(IDbConnection connection, GetNextNumberRequest request)
        {
            return GetNextNumberHelper.GetNextNumber(connection, request, MyRow.Fields.KodePeminjaman);
        }
    }
}
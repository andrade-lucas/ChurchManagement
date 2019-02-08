using System;
using System.Data;

namespace Church.Infra.Context
{
    public interface IDB : IDisposable
    {
        IDbConnection GetCon();
    }
}

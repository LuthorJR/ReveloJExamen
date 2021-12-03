using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace ReveloJExamen
{
    public interface DataBase
    {
        SQLiteAsyncConnection GetConnection();
    }
}

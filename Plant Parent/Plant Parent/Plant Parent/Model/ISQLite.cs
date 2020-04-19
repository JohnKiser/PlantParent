using System;
using SQLite;

namespace Plant_Parent.Model
{
    public interface ISQLite
    {
        SQLiteConnection GetConnection();
    }
}

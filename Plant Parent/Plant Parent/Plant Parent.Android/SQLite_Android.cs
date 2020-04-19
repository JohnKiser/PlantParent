using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using SQLite;
using Xamarin.Forms;
using Plant_Parent.Droid;
using Plant_Parent.Model;
using System.IO;

[assembly: Dependency(typeof(SQLite_Android))]

namespace Plant_Parent.Droid
{
    class SQLite_Android : ISQLite
    {
        public SQLite_Android()
        {

        }

        #region ISQLite implementation

        public SQLiteConnection GetConnection()
        {
            var fileName = "Plants.db";
            var documentsPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            var path = Path.Combine(documentsPath, fileName);
            var connection = new SQLiteConnection(path);

            return connection;
        }

        #endregion
    }
}
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace ListaNotasSQLite
{
    public class Nota
    {
        [PrimaryKey, AutoIncrement]
        public int id { get; set; }
        public String text { get; set; }
        public DateTime date { get; set; }
    }
}

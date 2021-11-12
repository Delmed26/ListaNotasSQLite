using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ListaNotasSQLite
{
    public class NotasBD
    {
        readonly SQLiteAsyncConnection _database;

        public NotasBD(String path)
        {
            _database = new SQLiteAsyncConnection(path);
            _database.CreateTableAsync<Nota>().Wait();
        }

        public Task<List<Nota>> GetNotesAsync()
        {
            return _database.Table<Nota>().ToListAsync();
        }
        
        public Task<Nota> GetNoteAsync(int id)
        {
            return _database.Table<Nota>().Where(i => i.id == id).FirstOrDefaultAsync();
        }

        public Task<int> SaveNoteAsync(Nota nota)
        {
            if (nota.id != 0)
                return _database.UpdateAsync(nota);

            return _database.InsertAsync(nota);
        }

        public Task<int> DeleteNoteAsync(Nota nota)
        {
            return _database.DeleteAsync(nota);
        }
    }
}

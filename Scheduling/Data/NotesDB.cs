using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using Scheduling.Models;
using System.Threading.Tasks;


namespace Scheduling.Data
{
    public class NotesDB
    {
        readonly SQLiteAsyncConnection db;//создаем подключение

        public NotesDB(string connectionString)//инициализируем подключение
        {
            db = new SQLiteAsyncConnection(connectionString);
            db.CreateTableAsync<Note>().Wait();//создаем таблицу
        }

        public Task<List<Note>> GetNotesAsync()
        {
            return db.Table<Note>().ToListAsync();//получаем нужную таблицу и асинхронно приводим данные к типу List
        }

        public Task<Note> GetNoteAsync(int id)//получение конкретной записки по id
        {
            return db.Table<Note>()//доступ к таблице
                .Where(i => i.ID == id)
                .FirstOrDefaultAsync();//первое значение, которое найдется по данному id

        }

        public Task<int> SaveNoteAsync(Note note)//добавляем или сохраняем изменения в записке
        {
            if (note.ID != 0)//изменяем строку
            {
                return db.UpdateAsync(note);
            }
            else//добавляем новую строку
            {
                return db.InsertAsync(note);
            }
        }

        public Task<int> DeleteNoteAsync(Note note)//удалить заметку
        {
            return db.DeleteAsync(note);
        }
    }
}
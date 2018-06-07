using FriendAPP.Model;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FriendAPP.Data
{
    public class FriendDataBase
    {
        #region Atributos

        private readonly SQLiteAsyncConnection database;

        #endregion

        #region Constructores

        public FriendDataBase(string dbPath)
        {
            database = new SQLiteAsyncConnection(dbPath);
            database.CreateTableAsync<Friend>().Wait();
        }

        public Task<List<Friend>> GetFriendAsync()
        {
            return database.Table<Friend>().ToListAsync();
        }

        public Task<Friend> GetFriendAsync(int id)
        {
            return database.Table<Friend>().Where(f => f.ID == id).FirstOrDefaultAsync();
        }

        public Task<int> SaveFriendAsync(Friend friend)
        {
            if (friend.ID != 0)
            {
                return database.UpdateAsync(friend);
            }
            else
            {
                return database.InsertAsync(friend);
            }
        }

        public Task<int> SDeleteFriendAsync(Friend friend)
        {            
                return database.DeleteAsync(friend);
        }
        #endregion
    }
}

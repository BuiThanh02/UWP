using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PRACTICAL2.Adapter;
using SQLitePCL;
using PRACTICAL2.Models;

namespace PRACTICAL2.Service
{
    interface IItemService
    {
        List<User> GetCart();

        bool AddNew(User item);
        bool CheckItem(User item);
    }
    class ItemService : IItemService
    {
        public bool AddNew(User item)
        {
            try
            {
                SQLiteConnection connection = SQLiteHelper.GetInstance().SQLiteConnection;
                var sql_txt = "insert into User(Name,Password) value(?,?)";

                var statement = connection.Prepare(sql_txt);
                statement.Bind(1, item.Name);
                statement.Bind(2, item.Pasword);
                var rs = statement.Step();
                return rs == SQLiteResult.OK;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool CheckItem(User item)
        {
            try
            {
                SQLiteConnection connection = SQLiteHelper.GetInstance().SQLiteConnection;
                var sql_txt = "select * from User where Name = ?,Password = ?";

                var statement = connection.Prepare(sql_txt);
                statement.Bind(1, item.Name);
                statement.Bind(2, item.Pasword);
                var rs = statement.Step();
                return rs == SQLiteResult.OK;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public List<User> GetCart()
        {
            List<User> cart = new List<User>();
            try
            {
                SQLiteConnection connection = SQLiteHelper.GetInstance().SQLiteConnection;
                var sql_txt = "select * from User";
                var statement = connection.Prepare(sql_txt);
                while (SQLiteResult.ROW == statement.Step())
                {
                    User item = new User()
                    {
                        Name = statement[0] as string,
                        Pasword = statement[1] as string,
                    };
                    cart.Add(item);
                }

            }
            catch (Exception e)
            {

            }
            return cart;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Windows.Forms;
using System.Data.SQLite;

namespace TestWork2
{
    class SqliteHelper
    {
        public static string SqliteConnectionString(string path)
        {
            return new SQLiteConnectionStringBuilder()
            {
                DataSource = path,
                ReadOnly = false

            }.ToString();
        }

        public static int SqliteExecute(string connString, string cmdText,
            params SQLiteParameter[] cmdParams)
        {
            using (var connection = new SQLiteConnection(connString))
            {
                connection.Open();

                return Execute(connection, cmdText, cmdParams);
            }
        }

        public static DataTable SqliteExecuteReader(string connString, string cmdText,
            params SQLiteParameter[] cmdParams)
        {
            using (var connection = new SQLiteConnection(connString))
            {
                connection.Open();

                return ExecuteReader(connection, cmdText, cmdParams);
            }
        }

        public static void UpdateData(string connString, string cmdText, DataTable dt,
            params SQLiteParameter[] cmdParams)
        {
            using (var connection = new SQLiteConnection(connString))
            {
                connection.Open();

                UpdateData(connection, cmdText, dt, cmdParams);
            }
        }

        private static int Execute(SQLiteConnection connection, string cmdText,
            params SQLiteParameter[] cmdParams)
        {
            using (var cmd = connection.CreateCommand())
            {
                cmd.CommandText = cmdText;

                if (cmdParams != null)
                    cmd.Parameters.AddRange(cmdParams);

                int result = cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();

                return result;
            }
        }

        private static DataTable ExecuteReader(SQLiteConnection connection, string cmdText,
                    params SQLiteParameter[] cmdParams)
        {
            using (var cmd = connection.CreateCommand())
            {

                DataTable dt = new DataTable();

                cmd.CommandText = cmdText;

                if (cmdParams != null)
                    cmd.Parameters.AddRange(cmdParams);

                using (var reader = cmd.ExecuteReader())
                {
                    if (!reader.HasRows)
                        return null;

                    dt.Load(reader);
                }

                cmd.Parameters.Clear();

                return dt;
            }
        }

        private static void UpdateData(SQLiteConnection connection, string cmdText,
                    DataTable dt, params SQLiteParameter[] cmdParams)
        {

            using (var adapter = new SQLiteDataAdapter(cmdText, connection))
            using (var cmd = connection.CreateCommand())
            {
                cmd.CommandText = cmdText;

                if (cmdParams != null)
                    cmd.Parameters.AddRange(cmdParams);

                adapter.SelectCommand = cmd;

                using (SQLiteCommandBuilder builder = new SQLiteCommandBuilder())
                {
                    builder.DataAdapter = adapter;
                    adapter.Update(dt);
                }

                cmd.Parameters.Clear();
            }
        }

        public static List<string[]> GetForeignKeysList
            (string connString, string tableName)
        {
            using (var connection = new SQLiteConnection(connString))
            {
                connection.Open();

                return GetForeignKeysList(connection, tableName);
            }
        }

        private static List<string[]> GetForeignKeysList
            (SQLiteConnection connection, string tableName)
        {
            string cmdText = string.Format($"PRAGMA foreign_key_list('{tableName}')");

            using (var cmd = connection.CreateCommand())
            {
                List<string[]> foreignKeys = new List<string[]>();

                cmd.CommandText = cmdText;

                using (var reader = cmd.ExecuteReader())
                {
                    if (!reader.HasRows)
                        return null;

                    while(reader.Read())
                    {
                        foreignKeys.Add(new string[] 
                        { 
                            reader["table"].ToString(), 
                            reader["from"].ToString(), 
                            reader["to"].ToString() 
                        });
                    }
                }

                cmd.Parameters.Clear();

                return foreignKeys;
            }
        }
    }

}

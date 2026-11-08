using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using SmartCoffeeSystem.models; // keep models namespace for supporting DTOs if any

namespace SmartCoffeeSystem.Services
{
    public class AccountRepository
    {
        private readonly string _connString;

        public AccountRepository()
        {
            _connString = ConfigurationManager.ConnectionStrings["DefaultConnection"]?.ConnectionString
                ?? throw new InvalidOperationException("DefaultConnection not found in configuration.");
        }

        // 創建帳號
        public int Create(Accounts account, string plainPassword)
        {   
            if (account == null) throw new ArgumentNullException(nameof(account));
            if (string.IsNullOrEmpty(plainPassword)) throw new ArgumentException("password required", nameof(plainPassword));

            var hashed = Services.HashPassword(plainPassword);

            using (var conn = new SqlConnection(_connString))
            using (var cmd = conn.CreateCommand())
            {
                cmd.CommandText = @"INSERT INTO Accounts (UserName, PasswordHash, CreateTime, EmployeeId)
VALUES (@UserName, @PasswordHash, @CreateTime, @EmployeeId);
SELECT SCOPE_IDENTITY();";
                cmd.Parameters.AddWithValue("@UserName", account.Account ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@PasswordHash", hashed);
                cmd.Parameters.AddWithValue("@CreateTime", account.CreateTime == default ? DateTime.Now : account.CreateTime);
                cmd.Parameters.AddWithValue("@EmployeeId", account.EmployeeId);

                conn.Open();
                var result = cmd.ExecuteScalar();
                return Convert.ToInt32(result);
            }
        }

        // 讀取帳號
        public Accounts Read(int accountId)
        {
            using (var conn = new SqlConnection(_connString))
            using (var cmd = conn.CreateCommand())
            {
                cmd.CommandText = "SELECT Account, UserName, PasswordHash, CreateTime, EmployeeId FROM Accounts WHERE Account = @Account";
                cmd.Parameters.AddWithValue("@Account", accountId);
                conn.Open();
                using (var rdr = cmd.ExecuteReader())
                {
                    if (!rdr.Read()) return null;
                    return new Accounts
                    {
                        EmployeeId = rdr.GetInt32(0),
                        Account = rdr.IsDBNull(1) ? null : rdr.GetString(1),
                        Password = rdr.IsDBNull(2) ? null : rdr.GetString(2),
                        CreateTime = rdr.IsDBNull(3) ? DateTime.MinValue : rdr.GetDateTime(3),
                        Email = rdr.IsDBNull(4) ? null:rdr.GetString(4)
                    };
                }
            }
        }

        // 更新帳號
        public bool Update(Accounts account, string newPlainPassword = null)
        {
            if (account == null) throw new ArgumentNullException(nameof(account));

            using (var conn = new SqlConnection(_connString))
            using (var cmd = conn.CreateCommand())
            {
                var updatePassword = !string.IsNullOrEmpty(newPlainPassword);
                cmd.CommandText = updatePassword
                    ? "UPDATE Accounts SET Account=@Account, Password=@Password, EmployeeId=@EmployeeId WHERE Email=@Email"
                    : "UPDATE Accounts SET Account=@Account, Password=@Password, EmployeeId=@EmployeeId WHERE Email=@Email";

                cmd.Parameters.AddWithValue("@UserName", account.Account ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@EmployeeId", account.EmployeeId);
                cmd.Parameters.AddWithValue("@Account", account.Account);

                if (updatePassword)
                {
                    var hashed = Services.HashPassword(newPlainPassword);
                    cmd.Parameters.AddWithValue("@PasswordHash", hashed);
                }

                conn.Open();
                var rows = cmd.ExecuteNonQuery();
                return rows > 0;
            }
        }

        // 刪除帳號
        public bool Delete(int accountId)
        {
            using (var conn = new SqlConnection(_connString))
            using (var cmd = conn.CreateCommand())
            {
                cmd.CommandText = "DELETE FROM Accounts WHERE Account = @Account";
                cmd.Parameters.AddWithValue("@Account", accountId);
                conn.Open();
                var rows = cmd.ExecuteNonQuery();
                return rows > 0;
            }
        }

        // 讀取帳號
        public List<Accounts> GetAll()
        {
            var list = new List<Accounts>();
            using (var conn = new SqlConnection(_connString))
            using (var cmd = conn.CreateCommand())
            {
                cmd.CommandText = "SELECT Account, UserName, PasswordHash, CreateTime, EmployeeId FROM Accounts";
                conn.Open();
                using (var rdr = cmd.ExecuteReader())
                {
                    while (rdr.Read())
                    {
                        list.Add(new Accounts
                        {
                            EmployeeId = rdr.GetInt32(0),
                            Account = rdr.IsDBNull(1) ? null : rdr.GetString(1),
                            Password = rdr.IsDBNull(2) ? null : rdr.GetString(2),
                            CreateTime = rdr.IsDBNull(3) ? DateTime.MinValue : rdr.GetDateTime(3),
                            Email= rdr.IsDBNull(4)? null:rdr.GetString(4)
                        });
                    }
                }
            }
            return list;
        }
    }
}

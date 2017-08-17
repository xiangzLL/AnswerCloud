using AnswerDB.Models;
using Microsoft.EntityFrameworkCore;
using MySQL.Data.EntityFrameworkCore.Extensions;

namespace AnswerDB
{ 
    public class AnswerDbContext:DbContext
    {
        //public AnswerDbContext(DbContextOptions<AnswerDbContext> options) : base(options)
        //{
        //}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=127.0.0.1;database=AnswerDB;uid=root;pwd=123456;SslMode=None");
        }

        public DbSet<User> Users { get; set; }
    }
}

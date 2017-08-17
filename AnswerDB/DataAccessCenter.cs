using System;
using System.Collections.Generic;
using System.Text;

namespace AnswerDB
{
    public class DataAccessCenter
    {
        public static void Initilalize(AnswerDbContext context)
        {
            context.Database.EnsureCreated();
        }
    }
}

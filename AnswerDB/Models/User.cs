using AnswerDB.Models.Resumes;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace AnswerDB.Models
{
    public class User
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public Resume UserResume { get; set; }
    }
}

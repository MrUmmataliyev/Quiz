using Microsoft.EntityFrameworkCore;
using Quiz.Application.Abstractions;
using Quiz.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz.Infrastructure.Persistance
{
    public class QuizDbContext : DbContext, IQuiz
    {
        public QuizDbContext(DbContextOptions<QuizDbContext> options) 
            :base(options)
        {
            Database.Migrate();
        }
        public DbSet<Test> Questions { get; set; }
    }
}

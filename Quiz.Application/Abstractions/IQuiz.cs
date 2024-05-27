using Microsoft.EntityFrameworkCore;
using Quiz.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz.Application.Abstractions
{
    public interface IQuiz
    {
        public DbSet<Test> Questions { get; set; }
        public Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}

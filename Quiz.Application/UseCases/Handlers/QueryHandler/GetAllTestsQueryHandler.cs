using MediatR;
using Microsoft.EntityFrameworkCore;
using Quiz.Application.Abstractions;
using Quiz.Application.UseCases.Queries;
using Quiz.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz.Application.UseCases.Handlers.QueryHandler
{
    public class GetAllTestsQueryHandler : IRequestHandler<GetAllTestQuery, List<Test>>
    {
        private readonly IQuiz _context;

        public GetAllTestsQueryHandler(IQuiz context)
        {
            _context = context;
        }

        public async Task<List<Test>> Handle(GetAllTestQuery request, CancellationToken cancellationToken)
        {
            var catalogs = await _context.Questions.ToListAsync();
            return catalogs;
        }
    }
}

using MediatR;
using Quiz.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz.Application.UseCases.Queries
{
    public class GetAllTestQuery : IRequest<List<Test>>
    {
    }
}

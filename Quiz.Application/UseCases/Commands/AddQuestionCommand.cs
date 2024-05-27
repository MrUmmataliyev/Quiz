using MediatR;
using Quiz.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz.Application.UseCases.Commands
{
    public class AddQuestionCommand : IRequest<ResponseModel>
    {
        public string Question { get; set; }
        public string CorrectAnswer { get; set; }
        public string inCorrect1 { get; set; }
        public string inCorrect2 { get; set; }
        public string inCorrect3 { get; set; }
    }
}

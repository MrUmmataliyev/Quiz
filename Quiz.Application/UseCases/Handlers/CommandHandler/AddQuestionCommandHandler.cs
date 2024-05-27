using MediatR;
using Quiz.Application.Abstractions;
using Quiz.Application.UseCases.Commands;
using Quiz.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz.Application.UseCases.Handlers.CommandHandler
{
    public class AddQuestionCommandHandler : IRequestHandler<AddQuestionCommand, ResponseModel>
    {
        private readonly IQuiz _context;

        public AddQuestionCommandHandler(IQuiz context)
        {
            _context = context;
        }

        public async Task<ResponseModel> Handle(AddQuestionCommand request, CancellationToken cancellationToken)
        {
            if (request != null)
            {
                var test = new Test
                {
                      Question= request.Question,
                      CorrectAnswer= request.CorrectAnswer,
                      inCorrect1=request.inCorrect1,
                      inCorrect2=request.inCorrect2,
                      inCorrect3=request.inCorrect3,
                };
                await _context.Questions.AddAsync(test, cancellationToken);
                await _context.SaveChangesAsync(cancellationToken);
                return new ResponseModel
                {
                    StatusCode = 201,
                    Message = $"Question is Created",
                    IsSuccess = true,
                };
            }
            return new ResponseModel
            {
                Message = "Test might be null",
                StatusCode = 400
            };
        }
    }
}

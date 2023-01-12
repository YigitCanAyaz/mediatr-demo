using MediatR;

namespace MediatRDemo.MediatR.Queries
{
    public class GetProductByIdQuery : IRequest<GetProductViewModel>
    {
        public Guid Id { get; set; } 
    }
}

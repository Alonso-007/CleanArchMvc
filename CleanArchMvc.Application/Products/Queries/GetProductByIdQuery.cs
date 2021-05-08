using CleanArchMvc.Domain.Entities;
using MediatR;

namespace CleanArchMvc.Application.Products.Queries
{
    public class GetProductByIdQuery : IRequest<Product>
    {
        public int Id { get; private set; }

        public GetProductByIdQuery(int id)
        {
            Id = id;
        }
    }
}
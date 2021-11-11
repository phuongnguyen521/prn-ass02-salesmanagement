using AutoMapper;
using BusinessObject.Object;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleFormsApp.Mappers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            #region Member
            CreateMap<Member, MemberDto>();
            CreateMap<MemberDto, Member>();
            #endregion

            #region Product
            CreateMap<Product, ProductDto>();
            CreateMap<ProductDto, Product>();
            #endregion

            #region Order
            IOrderDetailRepository orderDetailRepository = new OrderDetailRepository();
            CreateMap<BusinessObject.Object.Order, OrderDto>()
            .ForMember(des => des.OrderTotal,
            act => act.MapFrom(src => orderDetailRepository.GetTotalOrder(src)));
            CreateMap<OrderDto, Order>();
            #endregion

            #region OrderDetail
            //OrderDetail
            IProductRepository productRepository = new ProductRepository();
            CreateMap<OrderDetail, OrderDetailDto>()
                .ForMember(des => des.ProductName,
                act => act.MapFrom(src => productRepository.GetProductNameByID(src.ProductId)))
                .ForMember(des => des.No,
                act => act.MapFrom(src => src.ProductId));
            CreateMap<OrderDetailDto, OrderDetail>()
                .ForMember(des => des.OrderId, act => act.MapFrom(src => src.OrderId))
                .ForMember(des => des.ProductId, act => act.MapFrom(src => src.ProductId))
                .ForMember(des => des.Quantity, act => act.MapFrom(src => src.Quantity))
                .ForMember(des => des.UnitPrice, act => act.MapFrom(src => src.UnitPrice))
                .ForMember(des => des.Quantity, act => act.MapFrom(src => src.Quantity))
                .ForMember(des => des.Discount, act => act.MapFrom(src => src.Discount));
            #endregion       
        }
    }
}

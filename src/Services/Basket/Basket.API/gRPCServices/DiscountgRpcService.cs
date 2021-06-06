using Discount.gRPC.Protos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Basket.API.gRPCServices
{
    public class DiscountgRpcService
    {
        private readonly DiscountProtoService.DiscountProtoServiceClient discountProtoServiceClient;

        public DiscountgRpcService(DiscountProtoService.DiscountProtoServiceClient discountProtoService)
        {
            this.discountProtoServiceClient = discountProtoService ?? throw new ArgumentNullException(nameof(discountProtoServiceClient));
        }

        public async Task<CouponModel> GetDiscount(string productName)
        {
            var discountRequest = new GetDiscountRequest() { ProductName = productName };

            return await discountProtoServiceClient.GetDiscountAsync(discountRequest);
        }
    }
}

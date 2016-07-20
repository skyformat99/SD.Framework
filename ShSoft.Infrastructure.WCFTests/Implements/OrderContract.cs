﻿using System.ServiceModel;
using ShSoft.Infrastructure.StubIAppService.Interfaces;
using ShSoft.Infrastructure.WCFTests.Interfaces;

namespace ShSoft.Infrastructure.WCFTests.Implements
{
    /// <summary>
    /// 订单服务契约实现
    /// </summary>
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall)]
    public class OrderContract : IOrderContract
    {
        /// <summary>
        /// 商品接口
        /// </summary>
        private readonly IProductContract _productContract;

        /// <summary>
        /// 依赖注入构造器
        /// </summary>
        /// <param name="productContract"></param>
        public OrderContract(IProductContract productContract)
        {
            this._productContract = productContract;
        }

        /// <summary>
        /// 获取订单
        /// </summary>
        /// <returns>订单</returns>
        public string GetOrder()
        {
            return this._productContract.GetProducts();
        }
    }
}
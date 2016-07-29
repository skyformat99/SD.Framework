﻿using System.ServiceModel;

namespace ShSoft.Infrastructure.WCFTests.Interfaces
{
    /// <summary>
    /// 订单服务契约接口
    /// </summary>
    [ServiceContract(Namespace = "http://ShSoft.Infrastructure.WCFTests.Interfaces")]
    public interface IOrderContract : IApplicationService
    {
        /// <summary>
        /// 获取订单
        /// </summary>
        /// <returns>订单</returns>
        [OperationContract]
        string GetOrder();
    }
}
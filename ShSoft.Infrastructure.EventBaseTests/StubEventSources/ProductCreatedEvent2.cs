﻿using System;
using ShSoft.Infrastructure.EventBase;

namespace ShSoft.Infrastructure.EventBaseTests.StubEventSources
{
    /// <summary>
    /// 商品已创建事件
    /// </summary>
    [Serializable]
    public class ProductCreatedEvent2 : Event
    {
        /// <summary>
        /// 无参构造器
        /// </summary>
        protected ProductCreatedEvent2() { }

        /// <summary>
        /// 基础构造器
        /// </summary>
        public ProductCreatedEvent2(string productNo, string productName, decimal price, DateTime? triggerTime = null)
            : base(triggerTime)
        {
            this.ProductNo = productNo;
            this.ProductName = productName;
            this.Price = price;
        }

        /// <summary>
        /// 商品编号
        /// </summary>
        public string ProductNo { get; private set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        public string ProductName { get; private set; }

        /// <summary>
        /// 商品价格
        /// </summary>
        public decimal Price { get; private set; }
    }
}

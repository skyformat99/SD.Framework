#项目概述

	本框架致力于提升开发效率，减少领域驱动设计实现的复杂性。
	
	基于个人长期使用的经验，遵循面向对象的设计原则，不断从业务项目中提取，逐渐演变为该框架。

	框架中主要涉及Factory、Mediator、Provider、Facade、层超类型等模式。


1、ShSoft.Common
	
	公共基础类库，包含一些常用扩展工具。

	NuGet包地址：https://www.nuget.org/packages/ShSoft.Common


2、ShSoft.Infrastructure

	基础设施，包含系统常量、自定义异常、基接口与基类。

	NuGet包地址：https://www.nuget.org/packages/ShSoft.Infrastructure


3、ShSoft.Infrastructure.AOP

	AOP基础设施，包含为不同项目封装的不同处理异常的方式。

	NuGet包地址：https://www.nuget.org/packages/ShSoft.Infrastructure.AOP


4、ShSoft.Infrastructure.Event

	领域事件基础设施，包含领域事件基类、领域事件处理者工厂、领域事件中介者、Session存储提供者。

	NuGet包地址：https://www.nuget.org/packages/ShSoft.Infrastructure.Event


5、ShSoft.Infrastructure.Event.EFStorer

	EntityFramework领域事件存储提供者。

	NuGet包地址：https://www.nuget.org/packages/ShSoft.Infrastructure.Event.EFStorer


6、ShSoft.Infrastructure.Global

	全局操作基础设施，包括全局初始化、释放资源、事务。

	NuGet包地址：https://www.nuget.org/packages/ShSoft.Infrastructure.Global


7、ShSoft.Infrastructure.Repository

	仓储基础设施，包含EntityFramework DbContext的三次封装、数据库清理者、EntityFramework仓储提供者、EntityFramework UnitOfWork提供者。

	NuGet包地址：https://www.nuget.org/packages/ShSoft.Infrastructure.Repository


8、ShSoft.Infrastructure.WCF

	WCF服务端基础设施。

	NuGet包地址：https://www.nuget.org/packages/ShSoft.Infrastructure.WCF
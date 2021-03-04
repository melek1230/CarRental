using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Order:IEntity
    {
        public int OrderId { get; set; }
        public int CarId { get; set; }
        public int BrandId { get; set; }
        public int ColorId { get; set; }
//        CONSTRAINT[PK_Orders] PRIMARY KEY CLUSTERED([OrderID] ASC),
//    CONSTRAINT[FK_Orders_Customers] FOREIGN KEY([CustomerID]) REFERENCES[dbo].[Customers] ([CustomerID]),
//    CONSTRAINT[FK_Orders_Employees] FOREIGN KEY([EmployeeID]) REFERENCES[dbo].[Employees] ([EmployeeID]),
//    CONSTRAINT[FK_Orders_Shippers] FOREIGN KEY([ShipVia]) REFERENCES[dbo].[Shippers] ([ShipperID])
//);


//GO
//CREATE NONCLUSTERED INDEX[CustomerID]
//    ON[dbo].[Orders] ([CustomerID] ASC);


//GO
//CREATE NONCLUSTERED INDEX[CustomersOrders]
//    ON[dbo].[Orders] ([CustomerID] ASC);


//GO
//CREATE NONCLUSTERED INDEX[EmployeeID]
//    ON[dbo].[Orders] ([EmployeeID] ASC);


//GO
//CREATE NONCLUSTERED INDEX[EmployeesOrders]
//    ON[dbo].[Orders] ([EmployeeID] ASC);


//GO
//CREATE NONCLUSTERED INDEX[OrderDate]
//    ON[dbo].[Orders] ([OrderDate] ASC);


//GO
//CREATE NONCLUSTERED INDEX[ShippedDate]
//    ON[dbo].[Orders] ([ShippedDate] ASC);


//GO
//CREATE NONCLUSTERED INDEX[ShippersOrders]
//    ON[dbo].[Orders] ([ShipVia] ASC);


//GO
//CREATE NONCLUSTERED INDEX[ShipPostalCode]
//    ON[dbo].[Orders] ([ShipPostalCode] ASC);

}

}

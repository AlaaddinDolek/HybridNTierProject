using Microsoft.EntityFrameworkCore.ChangeTracking;
using Project.BLL.ManagerServices.Abstracts;
using Project.DAL.Repositories.Concretes;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.ManagerServices.Concretes
{
    public class OrderManager:BaseManager<Order>,IOrderManager
    {
        OrderRepository _oRep;
        public OrderManager(OrderRepository oRep):base(oRep)
        {
            _oRep = oRep;
        }
    }
}

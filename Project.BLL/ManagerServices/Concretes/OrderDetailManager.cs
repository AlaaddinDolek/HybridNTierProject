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
    public class OrderDetailManager:BaseManager<OrderDetail>, IOrderDetailManager
    {
        OrderDetailRepository _odRep;
        public OrderDetailManager(OrderDetailRepository odRep):base(odRep)
        {
            _odRep = odRep;
        }
    }
}

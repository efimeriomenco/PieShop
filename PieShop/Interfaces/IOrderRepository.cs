﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PieShop.Models;

namespace PieShop.Interfaces
{
  public interface IOrderRepository
    {
        void CreateOrder(Order order);
    }
}

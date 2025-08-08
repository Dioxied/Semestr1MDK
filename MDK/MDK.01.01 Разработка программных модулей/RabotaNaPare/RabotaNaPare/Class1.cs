using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatusApp
{
    public enum Status
    {
        New = 1, //Новый заказ
        Processing, //Заказ в процессе
        Shipped, //Заказ отправлен
        Delivered, // Заказ доставлен
        Cancelled, //Заказ отменен
        Returned //Заказ возвращен
    }
}


using dotnetproject.Interfaces ;
using System;
using dotnetproject.DTO ;

namespace dotnetproject.ServiceObjects
{
    public class StatusSO : IItemUpdateStrategy 
    {
        public void UpdateItem(ItemDTO item)
        {
            Console.WriteLine("StatusSO.UpdateItem()");
        }
    }
}
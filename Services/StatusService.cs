using dotnetproject.Interfaces ;
using System;
using dotnetproject.DTO ;

namespace dotnetproject.Services
{
    public class StatusService : IItemUpdateStrategy 
    {
        public void UpdateItem(ItemDTO item)
        {
            Console.WriteLine("StatusService.UpdateItem()");
        }
    }
}
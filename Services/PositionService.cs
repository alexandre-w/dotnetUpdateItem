using dotnetproject.Interfaces ;
using System;
using dotnetproject.DTO ;

namespace dotnetproject.Services
{
    public class PositionService : IItemUpdateStrategy 
    {
        public void UpdateItem(ItemDTO item)
        {
            Console.WriteLine("PositionService.UpdateItem()");
        }
    }
}
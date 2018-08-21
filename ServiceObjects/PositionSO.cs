using dotnetproject.Interfaces ;
using System;
using dotnetproject.DTO ;

namespace dotnetproject.ServiceObjects
{
    public class PositionSO : IItemUpdateStrategy 
    {
        public void UpdateItem(ItemDTO item)
        {
            Console.WriteLine("PositionSO.UpdateItem()");
        }
    }
}
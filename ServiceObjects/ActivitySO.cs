using dotnetproject.Interfaces ;
using System;
using dotnetproject.DTO ;


namespace dotnetproject.ServiceObjects
{
    public class ActivitySO : IItemUpdateStrategy
    {
        public void UpdateItem(ItemDTO item)
        {
            Console.WriteLine("ActivitySO.UpdateItem()");
        }
 
    }
}
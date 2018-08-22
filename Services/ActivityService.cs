using dotnetproject.Interfaces ;
using System;
using dotnetproject.DTO ;


namespace dotnetproject.Services
{
    public class ActivityService : IItemUpdateStrategy
    {
        public void UpdateItem(ItemDTO item)
        {
            Console.WriteLine("ActivityService.UpdateItem()");
        }
 
    }
}
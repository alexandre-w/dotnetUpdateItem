using System.Collections.Generic ;
using dotnetproject.Interfaces ;
using dotnetproject.Services ;
using dotnetproject.Dico ;
using dotnetproject.DTO ;

namespace dotnetproject
{
    public class Context {
        private static Dictionary<ENameTable, IItemUpdateStrategy> _strategies =
        new Dictionary<ENameTable, IItemUpdateStrategy>();


        static Context () {
            _strategies.Add(ENameTable.Activity, new ActivityService());
            _strategies.Add(ENameTable.Position, new PositionService());
            _strategies.Add(ENameTable.Status, new StatusService());
        }

        public static void Update(ItemDTO item)
        {
            _strategies[item.tableName].UpdateItem(item);
        }

    }
}
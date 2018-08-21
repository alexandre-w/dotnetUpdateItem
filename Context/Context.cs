using System.Collections.Generic ;
using dotnetproject.Interfaces ;
using dotnetproject.ServiceObjects ;
using dotnetproject.Dico ;
using dotnetproject.DTO ;

namespace dotnetproject
{
    public class Context {
        private static Dictionary<ENameTable, IItemUpdateStrategy> _strategies =
        new Dictionary<ENameTable, IItemUpdateStrategy>();


        static Context () {
            _strategies.Add(ENameTable.Activity, new ActivitySO());
            _strategies.Add(ENameTable.Position, new PositionSO());
            _strategies.Add(ENameTable.Status, new StatusSO());
        }

        public static void Update(ItemDTO item)
        {
            _strategies[item.tableName].UpdateItem(item);
        }

    }
}
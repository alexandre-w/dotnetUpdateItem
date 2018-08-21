using dotnetproject.DTO ;

namespace dotnetproject.Interfaces
{
    public interface IItemUpdateStrategy
    {
        void UpdateItem(ItemDTO item);
    }
}
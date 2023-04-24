using APITest.Models;

namespace APITest.Services.Breakfasts;

public interface IBreakfastService
{
    void CreateBreakfast(Breakfast breakfast);

    Breakfast GetBreakfast(Guid id);
}
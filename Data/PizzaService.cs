namespace BlazingPizza.Data;

public class PizzaService
{
    public async Task<Pizza[]> GetPizzasAsync()
    {
        var pizzases = new Pizza[]
        {
            new Pizza(){PizzaId= 1,Name="Margerita",Description="Special Cheese", Vegetarian=false,Vegan = false},
            new Pizza(){PizzaId= 2,Name="Hawaian",Description="Special Cheese", Vegetarian=false,Vegan = false},
            new Pizza(){PizzaId= 3,Name="Italian",Description="Special Cheese", Vegetarian=false,Vegan = false},
            new Pizza(){PizzaId= 4,Name="Perperoni",Description="Special Cheese", Vegetarian=false,Vegan = false},
            new Pizza(){PizzaId= 5,Name="Fiorenta",Description="Special Cheese", Vegetarian=false,Vegan = false},
            };
        // return Task.FromResult(pizzases);
        return pizzases;
    }
}
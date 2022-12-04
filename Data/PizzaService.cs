namespace BlazingPizza.Data;

public class PizzaService
{
    // public async  Task<Pizza[]> GetPizzasAsync()
    public  Task<PizzaSample[]> GetPizzasAsync()
    {
        var pizzases = new PizzaSample[]
        {
            new PizzaSample(){PizzaId= 1,Name="Margerita",Description="Special Cheese", Vegetarian=false,Vegan = false},
            new PizzaSample(){PizzaId= 2,Name="Hawaian",Description="Special Cheese", Vegetarian=false,Vegan = false},
            new PizzaSample(){PizzaId= 3,Name="Italian",Description="Special Cheese", Vegetarian=false,Vegan = false},
            new PizzaSample(){PizzaId= 4,Name="Perperoni",Description="Special Cheese", Vegetarian=false,Vegan = false},
            new PizzaSample(){PizzaId= 5,Name="Fiorenta",Description="Special Cheese", Vegetarian=false,Vegan = false},
            };
        return Task.FromResult(pizzases);
        //return pizzases;
    }
}
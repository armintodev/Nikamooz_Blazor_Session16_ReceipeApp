namespace ReceipeApp.Shared;

public class Receipe
{
    public Receipe()
    {
        Ingredients = new();
    }

    public string Name { get; set; }

    public string Description { get; set; }

    public string Detail { get; set; }

    public int PreparationTime { get; set; }

    public List<Ingredient> Ingredients { get; set; }
}

public class Ingredient
{
    public string Name { get; set; }

    public string Value { get; set; }
}
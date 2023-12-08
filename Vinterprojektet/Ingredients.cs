using System.ComponentModel;
using System.Runtime.CompilerServices;
List<Ingredient> Ingredienser = new();
Ingredienser.Add(new Ingredient());
Ingredienser.Add(new Ingredient());
Ingredienser.Add(new Ingredient());
Ingredienser.Add(new Ingredient());

Ingredienser[0].name = "Capsicum";
Ingredienser[1].name = "";

Ingredienser[0].cost = 10;

public class Ingredient
{
    public string name;

     public int Pungency;

     public int doctorness;

     public int Tastyness;

     
}





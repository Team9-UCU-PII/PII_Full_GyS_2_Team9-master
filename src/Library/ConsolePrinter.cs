using System;

namespace Full_GRASP_And_SOLID.Library
{
    public class ConsolePrinter 
    {
        public static void PrintRecipe(Recipe recipe)
        {
            Console.WriteLine($"Receta de {recipe.FinalProduct.Description}:");
            foreach (Step step in recipe.steps)
            {
                Console.WriteLine($"{step.Quantity} de '{step.Input.Description}' " +
                    $"usando '{step.Equipment.Description}' durante {step.Time} segundos");
            }
            Console.WriteLine($"El precio total de esta receta es: {recipe.GetProductionCost()}");
        }

    }
}

//Conviene separar ambas responsaiblidades (imprimir y armar txt de receta) para facilitar futuros
//actualizaciones o cambios al programa en si. Tal asi denuncia el principio SRP, que es el que ejemplificamos
//en este ejercicio.
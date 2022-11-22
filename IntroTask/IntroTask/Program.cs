 
Console.WriteLine("To bake a cake you will need:");
string[] actions = { "1.Buy all ingredients;", "2.Mix together all ingredients in the bowl;", "3.Preheat the oven to 175°C.", "4.Put mixed ingredients in the oven for 40min.", "5.Eat a cake!" };
// Create a List and add a collection
List<string> actionsList = new List<string>();
actionsList.AddRange(actions);
foreach (string a in actionsList)
    Console.WriteLine(a);
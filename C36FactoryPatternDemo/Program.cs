


//breakfast joint
//buscuits and gravy
//overeasy eggs
//grits
//pancakes

//FIRST STEP: CREATE AN INTERFACE
//SECOND STEP: CREATE CLASSES THAT CONFORM TO THE INTERFACE
//THIRD STEP: CREATE THE FACTORY

using C36FactoryPatternDemo;

Console.WriteLine("Good morning! What would you like to have this morning?");
var response = Console.ReadLine();

IOrderable customerOrder = FoodFactory.OrderFood(response);

customerOrder.CallingOutOrder();

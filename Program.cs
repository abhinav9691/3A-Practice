﻿using _3A_Practice;

//Car myCar = new Car();

// Call the honk() method (From the Vehicle class) on the myCar object
//myCar.honk();
// Display the value of the brand field (from the Vehicle class) and the value of the modelName from the Car class
//Console.WriteLine(myCar.brand + " " + myCar.modelName);


//Animal myAnimal = new Animal();  // Create a Animal object
//Animal myPig = new Pig();  // Create a Pig object
//Animal myDog = new Dog();  // Create a Dog object

//myAnimal.animalSound();
//myPig.animalSound();
//myDog.animalSound();


DemoEncap obj = new DemoEncap();

// calls set accessor of the property Name,
// and pass "Ankita" as value of the
// standard field 'value'
obj.Name = "Abhinav";

// calls set accessor of the property Age,
// and pass "21" as value of the
// standard field 'value'
obj.Age = 21;

// Displaying values of the variables
Console.WriteLine(" Name : " + obj.Name);
Console.WriteLine(" Age : " + obj.Age);
# Classes 

# What is a Class?
- Building blocks for software applications.  Each block is responsible for the behaviour of particular application section, all combine make up the application.

- The parts of a class:
  - Data - represented by fields.
  - Behaviour - represented by method/functions.

      | Data          | Behaviour     |
      | ---           | ---           |
      | Name: string  | .Walks()      |
      | Age: byte     | .Runs()       |

# Objects

# What is an Object?
- An instance of a class that lives in memory. 
  - The class above could have the objects ** Tony, Thor, and Scott **.  These then would be considered instances from the Person class. 
 
To create an instance of a class the new operator is used:  
> Classname identifier = new Classname(); 

This can also be achieved by:
> var classname = new Classname();

# Class Members
- Instance member:  Accesible from an object.
    - var person = new Person();
    - person.Walks();
    
- Static member:  Accesible from the class.  Used for single instance items.
    - Console.WriteLine();


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS___Code_Examples
{
    //Classes and Structs
    //Classes and structs are two of the basic constructs of the common type system in the.NET Framework.
    //Each is essentially a data structure that encapsulates a set of data
    //and behaviors that belong together as a logical unit.
    //The data and behaviors are the members of the class or struct, and they include its methods, properties, and events,
    //and so on, as listed later in this topic.

    //Clases y Estructuras
    //Las clases y estructuras son dos de las construcciones básicas del sistema de tipos comunes en el marco.NET.
    //Cada uno es esencialmente una estructura de datos que encapsula un conjunto de datos
    //y comportamientos que pertenecen juntos como una unidad lógica.
    //Los datos y comportamientos son los miembros de la clase o estructura, e incluyen sus métodos, propiedades y eventos,
    //y así sucesivamente, como se enumeran más adelante en este tema.

    //A class or struct declaration is like a blueprint that is used to create instances or objects at run time.
    //If you define a class or struct called Person, Person is the name of the type.
    //If you declare and initialize a variable p of type Person, p is said to be an object or instance of Person.
    //Multiple instances of the same Person type can be created,
    //and each instance can have different values in its properties and fields.
    //Una declaración de clase o estructura es como un plano que se utiliza para crear instancias u objetos en tiempo de ejecución.
    //Si define una clase o estructura llamada Person, Person es el nombre del tipo.
    //Si declara e inicializa una variable p de tipo Person, p se dice que es un objeto o instancia de Person.
    //Se pueden crear múltiples instancias del mismo tipo de persona,
    //y cada instancia puede tener valores diferentes en sus propiedades y campos.

    //A class is a reference type.When an object of the class is created,
    //the variable to which the object is assigned holds only a reference to that memory.
    //When the object reference is assigned to a new variable, the new variable refers to the original object.
    //Changes made through one variable are reflected in the other variable because they both refer to the same data.
    //Una clase es un tipo de referencia.Cuando se crea un objeto de la clase,
    //la variable a la que se asigna el objeto sólo contiene una referencia a esa memoria.
    //Cuando se asigna la referencia de objeto a una nueva variable, la nueva variable se refiere al objeto original.
    //Los cambios realizados a través de una variable se reflejan en la otra variable porque ambos se refieren a los mismos datos.

    //A struct is a value type.When a struct is created, the variable to which the struct is assigned
    //holds the struct's actual data. When the struct is assigned to a new variable, it is copied.
    //The new variable and the original variable therefore contain two separate copies of the same data.
    //Changes made to one copy do not affect the other copy.
    //Una estructura es un tipo de valor.Cuando se crea una estructura, la variable a la que se asigna la estructura
    //contiene los datos reales de la estructura. Cuando la estructura se asigna a una nueva variable, se copia.
    //Por lo tanto, la nueva variable y la variable original contienen dos copias separadas de los mismos datos.
    //Los cambios realizados en una copia no afectan a la otra copia.

    //In general, classes are used to model more complex behavior, or data that is intended to be
    //modified after a class object is created.
    //Structs are best suited for small data structures that contain primarily data that is not intended to be
    //modified after the struct is created.
    //For more information, see Classes, Objects, and Structs.
    //En general, las clases se utilizan para modelar comportamientos más complejos, o datos que se pretende que sean
    //modificado después de crear un objeto de clase.
    //Las estructuras son las más adecuadas para las estructuras de datos pequeñas que contienen principalmente datos que no están destinados a ser
    //modificado después de que se crea la estructura.
    //Para obtener más información, vea Clases, Objetos y Structs.

    //Example
    //In the following example, ClassesStructs in the ProgrammingGuide namespace has three members:
    //an instance constructor, a property named Number, and a method named Multiply.
    //The Main method in the Program class creates an instance(object) of CustomClass,
    //and the object’s method and property are accessed by using dot notation.
    //Ejemplo
    //En el ejemplo siguiente, ClassesStructs en el espacio de nombres ProgrammingGuide tiene tres miembros:
    //un constructor de instancia, una propiedad denominada Number y un método denominado Multiply.
    //El método Main en la clase Program crea una instancia (object) de CustomClass,
    //y se accede al método y propiedad del objeto mediante la notación de puntos.

    //Class definition.
    //Definicion de la clase.
    class ClassesStructs
    {
        //Class members.
        //
        //Property.
        //Miembros de la clase.
        //
        //Propiedad.
        public int Number { get; set; }
        //Method.
        //Metodo.
        public int Multiply(int num)
        {
            return num * Number;
        }
        //Instance Constructor.
        //Constructor de instancia.
        public ClassesStructs()
        {
            Number = 0;
        }
    }

    //Another class definition that contains Main, the program entry point.
    //Otra definición de clase que contiene Main, el punto de entrada del programa.
    //class ProgEx
    //{
    //    static void Main(string[] args)
    //    {
    //        //Create an object of type ClassesStructs
    //        //Crear un objeto del tipo ClassesStructs
    //        ClassesStructs ClsStr = new ClassesStructs();

    //        //Set the value of the public property.
    //        //Establece el valor de la propiedad pública.
    //        ClsStr.Number = 27;

    //        //Call the public method.
    //        //Llama al metodo publico
    //        int result = ClsStr.Multiply(4);
    //        Console.WriteLine($"The result is {result}.");
    //    }

    //    //The example displays the following output:
    //    //The result is 108.
    //    //El ejemplo muestra la siguiente salida:
    //    //El resultado es 108.
    //}
}

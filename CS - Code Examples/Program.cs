using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS___Code_Examples
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    //Constructors
    //Whenever a class or struct is created, its constructor is called.
    //A class or struct may have multiple constructors that take different arguments.
    //Constructors enable the programmer to set default values, limit instantiation,
    //and write code that is flexible and easy to read.
    //For more information and examples, see Using Constructors and Instance Constructors.
    //Constructores
    //Cada vez que se crea una clase o estructura, se llama a su constructor.
    //Una clase o estructura puede tener varios constructores que toman argumentos diferentes.
    //Los constructores permiten al programador establecer valores predeterminados, limitar la creación de instancias
    //y escribir código flexible y fácil de leer.Para obtener más información y ejemplos, vea Usar Constructores e Instanciadores.
    //Default constructors
    //If you don't provide a constructor for your class, C# creates one by default that instantiates the object and
    //sets member variables to the default values as listed in the Default Values Table.
    //If you don't provide a constructor for your struct, C# relies on an implicit default constructor to automatically
    //initialize each field of a value type to its default value as listed in the Default Values Table.
    //For more information and examples, see Instance Constructors.
    //Constructores por defecto
    //Si no proporciona un constructor para su clase, C # crea uno por defecto que instancia el objeto y
    //establece variables de miembro a los valores predeterminados como se enumeran en la tabla de valores predeterminados.
    //Si no proporciona un constructor para su estructura, C # se basa en un constructor implícito predeterminado para inicializar automáticamente
    //cada campo de un tipo de valor a su valor predeterminado como se muestra en la Tabla de valores predeterminados.
    //Para obtener más información y ejemplos, consulte Constructores de instancias.
    //Constructor syntax
    //A constructor is a method whose name is the same as the name of its type.
    //Its method signature includes only the method name and its parameter list; it does not include a return type.
    //The following example shows the constructor for a class named Person.
    //Sintaxis del constructor
    //Un constructor es un método cuyo nombre es el mismo que el nombre de su tipo.
    //Su firma de método incluye sólo el nombre del método y su lista de parámetros; no incluye un tipo de devolución.
    //El siguiente ejemplo muestra el constructor de una clase denominada Person.
    public class Person
    {
        private string last;
        private string First;

        public Person(string lastName,string firstName)
        {
            last = lastName;
            First = firstName;
        }
        //Remaining implementation of Person class.
        //Implementación restante de la clase Person.
    }
    //Avanzado Data Binding, solo referencia
    //If a constructor can be implemented as a single statement, you can use an expression body definition.
    //The following example defines a Location class whose constructor has a single string parameter named name.
    //The expression body definition assigns the argument to the locationName field.
    //Si un constructor puede implementarse como una sola sentencia, puede utilizar una definición de cuerpo de expresión.
    //El siguiente ejemplo define una clase de ubicación cuyo constructor tiene un solo parámetro de cadena llamado nombre.
    //La definición del cuerpo de expresión asigna el argumento al campo locationName.
    public class Location
    {
        private string locationName;

        public Location(string name) => locationName = name;

        public string Name
        {
            get => locationName;
            set => locationName = value;
        }
    }
    //Static constructors
    //The previous examples have all shown instance constructors, which create a new object.
    //A class or struct can also have a static constructor, which initializes static members of the type.
    //Static constructors are parameterless.
    //If you don't provide a static constructor to initialize static fields, the C# compiler
    //will supply a default static constructor that initializes static fields to their default value
    //as listed in the Default Values Table.
    //Constructores estáticos
    //Los ejemplos anteriores han mostrado constructores de instancia, que crean un nuevo objeto.
    //Una clase o estructura también puede tener un constructor estático, que inicializa los miembros estáticos del tipo.
    //Los constructores estáticos no tienen parámetros.
    //Si no proporciona un constructor estático para inicializar campos estáticos, el compilador C #
    //proporcionará un constructor estático predeterminado que inicializa los campos estáticos a su valor predeterminado
    //como se muestra en la Tabla de valores predeterminados.
    //The following example uses a static constructor to initialize a static field.
    //El ejemplo siguiente utiliza un constructor estático para inicializar un campo estático.
    public class Adult : Person
    {
        private static int minimumAge;

        public Adult(string lastName, string firstName) : base(lastName, firstName)
        {
            
        }

        static Adult()
        {
            minimumAge = 18;
        }
        //Remaining implementation of Adult class.
        //Implementación restante de la clase Adult.
    }
    //You can also define a static constructor with an expression body definition, as the following example shows.
    //También puede definir un constructor estático con una definición de cuerpo de expresión, como se muestra en el siguiente ejemplo.
    public class Child : Person
    {
        private static int maximumAge;

        public Child(string lastName, string firstName) : base(lastName, firstName)
        {

        }

        static Child() => maximumAge = 18;
        //Remaining implementation of Child class.
        //Implementación restante de la clase Child.
    }
    //For more information and examples, see Static Constructors.
    //Para obtener más información y ejemplos, consulte Constructores estáticos.
}

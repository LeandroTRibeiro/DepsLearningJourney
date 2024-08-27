namespace Abstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            // Cria uma instância da classe Cat e executa os métodos
            Cat cat = new Cat();
            cat.MakeSound(); 
            cat.Move();      
            
            // Cria uma instância da classe Dog e executa os métodos
            Dog dog = new Dog();
            dog.MakeSound(); 
            dog.Move();      
        }
    }
}
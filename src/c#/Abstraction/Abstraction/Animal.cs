namespace Abstraction;

// Classe abstrata Animal que serve como base para outros tipos de animais
public abstract class Animal
{
    // Propriedade que armazena o nome do animal
    public string Name { get; set; }
    
    // Método abstrato que deve ser implementado nas classes derivadas para definir o som do animal
    public abstract void MakeSound();
    
    // Método abstrato que deve ser implementado nas classes derivadas para definir o movimento do animal
    public abstract void Move();
}
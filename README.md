# builder
Este es el ejemplo práctico del patrón de diseño builder en c# y una corta explicación para entender en lo que consiste. 

Basado en el libro:
#### Design Patterns Elements of reusable Object-Oriented Software de Erich Gamma, Richard Helm, Ralph Johnson, John Vlissides.

## Definición
Es un patrón de diseño creacional el cual separa la construcción de un objeto complejo desde su represntación para que el mismo proceso de construcción sirva para crear diferentes representaciones.

## Aplicabilidad
El patrón builder debería usarse cuando el algoritmo para crear un objeto complejo debe ser independiente de las partes que lo componen y de como ellas se ensamblan, también debería usarse cuando el proceso de construcción debe permitir diferentes representaciones para el objeto construido.

## Participantes en el patrón

### Builder
Especifica una interfaz abstracta para crear las partes de un objeto producto.

### ConcreteBuilder
Construye y ensambla partes de un objeto producto implementando la interfaz del builder. Además define y mantiene seguimiento a las representaciones que crea, también provee una interfaz para obtener el producto.

### Director
Construye un objeto usando la interfaz builder.

### Product
Representa el objeto complejo en construcción.

### Client
El cliente crea el objeto director y lo configura con el objeto builder deseado.

# PatronesDotNet
Implementación de patrones de diseño con ejemplos concretos en .Net.
Incluye proyecto de Test y otro de Consola para poder ver el funcionamiento de los patrones.

La mayoría de los ejemplos han sido tomados de los siguientes sitios web:
+ http://migranitodejava.blogspot.com.ar
+ http://www.dofactory.com/net/design-patterns

# Breve descripción de los patrones incluidos
Patrones de comportamiento

 Chain of Responsibility (Cadena de responsabilidad): Permite establecer la línea que deben llevar los mensajes para que los objetos realicen la tarea indicada.

 Command (Orden): Encapsula una operación en un objeto, permitiendo ejecutar dicha operación sin necesidad de conocer el contenido de la misma.

 Interpreter (Intérprete): Dado un lenguaje, define una gramática para dicho lenguaje, así como las herramientas necesarias para interpretarlo.

 Iterator (Iterador): Permite realizar recorridos sobre objetos compuestos independientemente de la implementación de estos.

 Mediator (Mediador): Define un objeto que coordine la comunicación entre objetos de distintas clases, pero que funcionan como un conjunto.

 Memento (Recuerdo): Permite volver a estados anteriores del sistema.

 Observer (Observador): Define una dependencia de uno-a-muchos entre objetos, de forma que cuando un objeto cambie de estado se notifique y actualicen automáticamente todos los objetos que dependen de él.

 State (Estado): Permite que un objeto modifique su comportamiento cada vez que cambie su estado interno.

 Strategy (Estrategia): Permite disponer de varios métodos para resolver un problema y elegir cuál utilizar en tiempo de ejecución.

 Template Method (Método plantilla): Define en una operación el esqueleto de un algoritmo, delegando en las subclases algunos de sus pasos, esto permite que las subclases redefinan ciertos pasos de un algoritmo sin cambiar su estructura.

 Visitor (Visitante): Permite definir nuevas operaciones sobre una jerarquía de clases sin modificar las clases sobre las que opera.

______

Patrones creacionales

 Abstract Factory (fábrica abstracta): permite trabajar con objetos de distintas familias de manera que las familias no se mezclen entre sí y haciendo transparente el tipo de familia concreta que se esté usando.

 Builder (constructor virtual): abstrae el proceso de creación de un objeto complejo, centralizando dicho proceso en un único punto.

 Factory Method (método de fabricación): centraliza en una clase constructora la creación de objetos de un subtipo de un tipo determinado, ocultando al usuario la casuística para elegir el subtipo que crear.

 Prototype (prototipo): crea nuevos objetos clonándolos de una instancia ya existente.

 Singleton (instancia única): garantiza la existencia de una única instancia para una clase y la creación de un mecanismo de acceso global a dicha instancia.

______

Patrones estructurales

 Adapter (Adaptador): Adapta una interfaz para que pueda ser utilizada por una clase que de otro modo no podría utilizarla.

 Bridge (Puente): Desacopla una abstracción de su implementación.

 Composite (Objeto compuesto): Permite tratar objetos compuestos como si de uno simple se tratase.

 Decorator (Envoltorio): Añade funcionalidad a una clase dinámicamente.

 Facade (Fachada): Provee de una interfaz unificada simple para acceder a una interfaz o grupo de interfaces de un subsistema.

 Flyweight (Peso ligero): Reduce la redundancia cuando gran cantidad de objetos que poseen idéntica información.

 Proxy: Mantiene un representante de un objeto.

_____

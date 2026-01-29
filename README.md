# 🧩 Patrones de Diseño en C# — Ejemplos Didácticos

Este repositorio reúne una colección creciente de **patrones de diseño del catálogo GoF (Gang of Four)**, implementados en C# con un dominio común basado en **Usuarios y Mensajes**.

El objetivo es ofrecer ejemplos **claros, prácticos y didácticos**, mostrando:

- qué problema resuelve cada patrón  
- cómo se implementa en C#  
- cómo se diferencia de otros patrones  
- cómo aplicarlo en un contexto realista  
- cómo mantener el código extensible y mantenible  

Cada patrón incluye:

- Interfaces y clases concretas  
- Ejemplo de uso  
- Explicación integrada en el código  
- Ventajas y motivación  
- Implementación coherente con el dominio  


# 🏭 1. Factory Method

### 🎯 Idea principal  
Permite que las subclases decidan qué objeto crear.  
La clase base define un método abstracto y las subclases implementan la creación del producto.

### 🧠 En este proyecto  
- `UsuarioBase` define `CrearMensaje()`.  
- `UsuarioA`, `UsuarioB`, etc., deciden qué mensaje concreto devolver.  
- El cliente trabaja solo con la abstracción `IMensajeDeBienvenida`.

### ✔ Ventajas  
- Cumple DIP (Dependency Inversion Principle) y OCP (Open/Closed Principle).  
- Fácil de extender con nuevos tipos de usuarios.  
- El cliente no conoce clases concretas.


# 🧪 2. Abstract Factory

### 🎯 Idea principal  
Crear **familias de productos relacionados** sin acoplarse a sus clases concretas.

### 🧠 En este proyecto  
- `IUsuarioFactory` crea mensajes de bienvenida, despedida y error.  
- Cada fábrica concreta (`UsuarioAFactory`, `UsuarioBFactory`) produce una familia consistente de mensajes.  
- Se pueden segregar interfaces (`IUsuarioBienvenida`, etc.) para cumplir ISP.

### ✔ Ventajas  
- Garantiza compatibilidad entre productos.  
- Permite añadir nuevas familias sin modificar código existente.  
- Encapsula completamente la creación.


# 🧱 3. Builder

### 🎯 Idea principal  
Construir objetos complejos paso a paso, evitando constructores gigantes.

### 🧠 En este proyecto  
- `IMensajeBuilder` define pasos para construir un `MensajeCompleto`.  
- El cliente decide qué partes incluir.  
- El resultado final es un objeto compuesto y legible.

### ✔ Ventajas  
- Flexibilidad total en la construcción.  
- Evita telescoping constructors.  
- Permite variaciones del mismo objeto.


# 🧬 4. Prototype

### 🎯 Idea principal  
Clonar objetos existentes sin conocer su clase concreta.

### 🧠 En este proyecto  
- Cada mensaje implementa `IPrototype<T>`.  
- `Clonar()` devuelve una copia independiente del mensaje.  
- Permite crear variaciones sin modificar el original.

### ✔ Ventajas  
- Evita recrear objetos desde cero.  
- Útil cuando la creación es costosa o compleja.  
- Cumple OCP (Open/Closed Principle) y DIP (Dependency Inversion Principle).


# 🔌 5. Adapter

### 🎯 Idea principal  
Permite que clases con **interfaces incompatibles** trabajen juntas sin modificarlas.  
El Adapter actúa como un **traductor** entre lo que el sistema espera y lo que una clase externa ofrece.

### 🧠 En este proyecto  
- El sistema espera objetos que implementen `IMensajeDeBienvenida`.  
- Los servicios externos (`ServiciosExternoA`, `ServiciosExternoB`, `ServiciosExternoC`) implementan otra interfaz incompatible: `IServiciosMensajeExterno`.  
- El Adapter (`MensajeExternoAdapter`) convierte `EscribirMensaje()` en `GetMessage()`.  
- Gracias al Adapter, el cliente puede usar cualquier servicio externo sin cambiar su código.  
- Un único Adapter sirve para todos los servicios externos porque comparten la misma interfaz incompatible.

### ✔ Ventajas  
- Permite integrar servicios externos o de terceros sin modificarlos.  
- Evita acoplar el sistema a interfaces que no controla.  
- Cumple OCP (Open/Closed Principle): se pueden añadir nuevos servicios externos sin tocar el código existente.  
- Cumple DIP (Dependency Inversion Principle): el cliente depende solo de `IMensajeDeBienvenida`.  
- Facilita la reutilización de código legado o bibliotecas externas.


# 🌉 6. Bridge

### 🎯 Idea principal  
Separa **la abstracción** de **su implementación**, permitiendo que ambas evolucionen de forma independiente.  
Bridge evita la explosión de clases que ocurre cuando intentas combinar múltiples variantes mediante herencia.

### 🧠 En este proyecto  
- La abstracción son los **mensajes de bienvenida** (`MensajeBridge`).  
- La implementación son los **formatos de mensaje** (`IFormatoMensaje`).  
- Los mensajes concretos (`MensajeBienvenidaA_Bridge`, `MensajeBienvenidaB_Bridge`) delegan el formateo en un objeto externo.  
- Los formatos (`FormatoMayusculas`, `FormatoConPrefijo`) pueden cambiar sin afectar a los mensajes.  
- Los mensajes pueden crecer sin modificar los formatos.  
- El cliente puede combinar libremente cualquier mensaje con cualquier formato.

### ✔ Ventajas  
- Evita la explosión de clases (sin Bridge tendrías que crear combinaciones como `MensajeA_Mayusculas`, `MensajeA_Prefijo`, `MensajeB_Mayusculas`, etc.).  
- Abstracción e implementación evolucionan de forma independiente.  
- Cumple OCP (Open/Closed Principle): puedes añadir nuevos mensajes o nuevos formatos sin modificar código existente.  
- Cumple DIP (Dependency Inversion Principle): el mensaje depende de la abstracción `IFormatoMensaje`, no de implementaciones concretas.  
- Facilita la extensión del sistema sin romper nada.


Aquí tienes la sección **Composite** con el **mismo estilo, estructura y simplicidad** que tu sección de Bridge.  
Lista para pegar en tu README.


# 🌳 7. Composite

### 🎯 Idea principal  
Permite tratar **objetos individuales** y **objetos compuestos** de la misma manera.  
Composite es ideal para construir estructuras jerárquicas (tipo árbol) donde un elemento puede contener otros elementos, pero todos comparten la misma interfaz.

### 🧠 En este proyecto  
- El componente base es la interfaz **`IMensajeDeBienvenida`**.  
- Un mensaje simple se representa con **`MensajeSimple`**.  
- Un mensaje compuesto se representa con **`MensajeCompuesto`**, que puede contener varios `IMensajeDeBienvenida`.  
- El cliente no necesita saber si está usando un mensaje simple o un mensaje compuesto.  
- `MensajeCompuesto` se encarga de recorrer internamente todos los mensajes que contiene.

### ✔ Ventajas  
- Permite construir estructuras jerárquicas sin cambiar el código cliente.  
- El cliente trata objetos simples y compuestos de forma uniforme.  
- Facilita añadir nuevos tipos de mensajes sin modificar código existente OCP (Open/Closed Principle).   
- Evita condicionales del tipo “si es simple haz esto, si es compuesto haz lo otro”.  
- Muy útil para representar estructuras parte–todo (carpetas/archivos, menús/submenús, grupos de mensajes, etc.).


# 🎨 8. Decorator

### 🎯 Idea principal  
Permite **añadir responsabilidades adicionales a un objeto de forma dinámica**, sin modificar su clase original.  
Un decorador envuelve un objeto y añade comportamiento antes o después de delegar la llamada.

Es una alternativa flexible a la herencia cuando quieres extender comportamiento sin crear una explosión de subclases.

### 🧠 En este proyecto  
- El componente base es la interfaz **`IMensajeDeBienvenida`**.  
- El mensaje original se representa con **`MensajeSimple`**.  
- Los decoradores implementan la misma interfaz y envuelven un mensaje existente.  
- Cada decorador añade una responsabilidad extra:
  - `DecoradorConFecha` → añade la fecha actual  
  - `DecoradorMayusculas` → convierte el texto a mayúsculas  
  - `DecoradorConPrefijo` → añade un prefijo  
- Los decoradores se aplican en cadena, uno encima del otro.
- El cliente no necesita saber cuántos decoradores hay ni en qué orden están aplicados.

### ✔ Ventajas  
- Añade funcionalidades sin modificar la clase original.  
- Evita crear subclases como `MensajeMayusculas`, `MensajeConPrefijo`, `MensajeMayusculasConFecha`, etc.  
- Los decoradores pueden combinarse dinámicamente en tiempo de ejecución.  
- Cumple OCP(Open/Closed Principle): puedes añadir nuevos decoradores sin modificar código existente.  
- Cumple DIP(Dependency Inversion Principle): los decoradores dependen de la abstracción, no de implementaciones concretas.  
- Permite construir comportamientos complejos a partir de piezas simples.


# 🏛️ 7. Façade

### 🎯 Idea principal  
Proporciona una **interfaz simple y unificada** para acceder a un **subsistema complejo**.  
En lugar de que el cliente tenga que interactuar con múltiples clases, dependencias y pasos internos, la fachada expone un único método de alto nivel que encapsula toda la complejidad.

### 🧠 En este proyecto  
- El subsistema está compuesto por varias clases internas:  
  `ValidadorDeUsuario`, `GeneradorDeTextoDeBienvenida`,  
  `CalculadorDeImportancia`, `FormateadorDeMensaje`, `LoggerDeAccesos`.  
- Cada clase realiza una tarea específica y el cliente **no debería conocerlas ni coordinarlas**.  
- La fachada (`BienvenidaFacade`) expone un único método:  
  `CrearBienvenida(usuario)`.  
- La fachada valida, genera el texto, calcula la importancia, formatea el mensaje y registra el acceso.  
- El cliente recibe directamente un `IMensajeDeBienvenida` completamente preparado.  
- El subsistema puede cambiar internamente sin afectar al cliente.

### ✔ Ventajas  
- Simplifica el uso de un subsistema complejo.  
- Reduce el acoplamiento entre cliente y componentes internos.  
- Protege al cliente de cambios internos en el subsistema.  
- Mejora la claridad del código al encapsular procesos complejos.  
- Cumple SRP (Single Responsibility Principle): la fachada es la única responsable de coordinar el flujo.  
- Cumple OCP (Open/Closed Principle): el subsistema puede crecer sin modificar el código cliente.  
- Facilita la creación de APIs limpias y fáciles de usar.


# 🪶 8. Flyweight

### 🎯 Idea principal  
Reduce el **uso de memoria** compartiendo objetos **inmutables y repetidos** entre múltiples instancias.  
Flyweight evita crear miles de objetos idénticos, reutilizando uno solo y almacenando únicamente la parte **intrínseca** (compartida), mientras que la parte **extrínseca** (variable) se pasa desde fuera.

### 🧠 En este proyecto  
- Muchos mensajes pueden compartir información común:  
  por ejemplo, el **formato base**, el **prefijo**, o una **plantilla de texto**.  
- Esa parte común es **intrínseca** y se guarda en objetos Flyweight (`MensajeFlyweight`).  
- La parte variable (usuario, fecha, importancia) es **extrínseca** y se pasa desde fuera.  
- El `MensajeFlyweightFactory` garantiza que si dos mensajes usan la misma plantilla, se reutiliza el mismo objeto Flyweight.  
- El cliente no crea Flyweights directamente: siempre los solicita a la fábrica.  
- Esto reduce drásticamente la creación de objetos repetidos y optimiza memoria.

### ✔ Ventajas  
- Reduce el consumo de memoria cuando hay muchos objetos similares.  
- Evita duplicar información inmutable o repetida.  
- Centraliza la creación y reutilización de objetos mediante una fábrica.  
- Cumple OCP (Open/Closed Principle): puedes añadir nuevos tipos de Flyweight sin modificar los existentes.  
- Cumple SRP (Single Responsibility Principle): la fábrica es la única responsable de gestionar la reutilización.  
- Ideal para sistemas con miles de elementos repetidos (textos, iconos, nodos, caracteres, etc.).


# 🛡️ 9. Proxy

### 🎯 Idea principal  
Proxy actúa como un **intermediario** que controla el acceso a un objeto real.  
Permite añadir lógica adicional (seguridad, logs, cache, lazy loading) sin modificar el objeto real.

### 🧠 En este proyecto  
- El sistema trabaja con `IMensajeDeBienvenida`.  
- `MensajeReal` es el objeto costoso que genera el mensaje.  
- `MensajeProxy` controla el acceso al objeto real.  
- El proxy crea el objeto real solo cuando es necesario (lazy loading).  
- El cliente no sabe si está usando el proxy o el objeto real.  
- El proxy puede añadir logs, validaciones o cache sin modificar `MensajeReal`.

### ✔ Ventajas  
- Controla el acceso a objetos costosos o sensibles.  
- Permite lazy loading (crear el objeto solo cuando se necesita).  
- Añade funcionalidades sin modificar el objeto real.  
- Cumple OCP (Open/Closed Principle): puedes añadir nuevos proxies sin tocar el código existente.  
- Cumple SRP (Single Responsibility Principle): el objeto real no se preocupa por seguridad, logs o cache.  


# 🧩 10. Chain of Responsibility

### 🎯 Idea principal  
Chain of Responsibility permite procesar una petición a través de una **cadena de handlers independientes**, donde cada uno decide si:

- maneja la petición  
- o la delega al siguiente handler  

El cliente no conoce la estructura de la cadena ni cuántos handlers la componen.  
La petición fluye paso a paso hasta que alguien la resuelve.

### 🧠 En este proyecto  
- El sistema trabaja con un `MensajeContexto` que contiene usuario, fecha e importancia.  
- Cada validación es un handler independiente:  
  - `ValidarUsuarioHandler`  
  - `ValidarFechaHandler`  
  - `ValidarImportanciaHandler`  
- `GenerarMensajeHandler` es el último eslabón de la cadena.  
- La cadena se construye explícitamente usando `SetNext()`.  
- Cada handler valida su parte y decide si continúa o detiene la cadena.  
- El cliente solo conoce el primer handler (`ValidarUsuarioHandler`).  

### ✔ Ventajas  
- Desacopla el cliente de la lógica de validación.  
- Permite añadir, quitar o reordenar handlers sin modificar el cliente.  
- Cada handler tiene una única responsabilidad (SRP).  
- Evita condicionales anidados o enormes bloques `if/else`.  
- Facilita pruebas unitarias por handler.  
- Cumple OCP (Open/Closed Principle): puedes añadir nuevas validaciones sin tocar las existentes.  


# ⚔️ 11. Command

### 🎯 Idea principal  
Command encapsula una **acción como un objeto independiente**.  
Permite ejecutar, deshacer, almacenar o encolar operaciones sin que el cliente conozca cómo se realizan.

### 🧠 En este proyecto  
- `ICommand` define las operaciones `Execute()` y `Undo()`.  
- `EnviarMensajeCommand` implementa `ICommand` y representa una acción concreta.  
- El comando contiene los datos necesarios y una referencia al receptor.  
- `MensajeReceiver` ejecuta la lógica real (enviar y deshacer el mensaje).  
- El invocador solo conoce la interfaz `ICommand`, no la implementación del comando ni del receptor.

### ✔ Ventajas  
- Encapsula acciones como objetos reutilizables.  
- Permite Undo/Redo de forma natural.  
- Desacopla quién solicita la acción de quién la ejecuta.  
- Facilita colas de comandos, logs y macros.  
- Cumple SRP (Single Responsibility Principle) : cada comando tiene una única responsabilidad.  
- Cumple OCP (Open/Closed Principle): puedes añadir nuevos comandos sin modificar código existente.


# 🧾 12. Interpreter

### 🎯 Idea principal  
Interpreter define una gramática y permite evaluar reglas construyendo un **árbol de expresiones**.  
Cada expresión sabe cómo interpretarse sobre un contexto.

### 🧠 En este proyecto  
- `IExpresion` define el método `Interpretar()`.  
- Las expresiones terminales evalúan reglas simples (usuario, importancia, etc.).  
- Las expresiones no terminales combinan reglas (AND, OR).  
- El cliente construye el árbol de expresiones y lo evalúa sobre un `MensajeContexto`.

### ✔ Ventajas  
- Permite definir reglas como objetos reutilizables.  
- Facilita crear mini-lenguajes internos (DSL).  
- Las reglas pueden combinarse para formar expresiones complejas.  
- Cumple OCP (Open/Closed Principle): puedes añadir nuevas expresiones sin modificar las existentes.


# 🔁 13. Iterator

### 🎯 Idea principal  
Iterator permite recorrer una colección **sin exponer su estructura interna**.  
El iterador encapsula el estado del recorrido y ofrece una forma uniforme de avanzar por los elementos.

### 🧠 En este proyecto  
- `IIterator<T>` define `HasNext()` y `Next()`.  
- `IColeccion<T>` define `CrearIterador()`.  
- `ColeccionDeMensajesDeBienvenida` almacena mensajes explicativos.  
- `MensajeIterator` controla la iteración interna.  
- El cliente recorre los mensajes sin conocer cómo están almacenados.

### ✔ Ventajas  
- Oculta la estructura interna de la colección.  
- Permite múltiples iteradores simultáneos.  
- Facilita cambiar la forma de recorrer sin modificar el cliente.  
- Cumple SRP (Single Responsibility Principle): la colección no gestiona la iteración.  
- Cumple OCP (Open/Closed Principle): puedes añadir nuevos iteradores sin tocar el cliente.


# 🔁 14. Mediator

### 🎯 Idea principal  
Mediator centraliza la comunicación entre varios componentes para **evitar que se conozcan entre sí**.  
En lugar de que los objetos colaboren directamente, delegan la coordinación en un mediador que decide qué hacer ante cada evento.

### 🧠 En este proyecto  
- `IMediator` define `Notificar(remitente, evento, datos)`.  
- `EventoDeBienvenida` es un **enum** que tipa los eventos del flujo.  
- `CentroDeCoordinacionMediator` coordina todo el proceso según el evento recibido.  
- `RegistroDeUsuarios` dispara el evento inicial `UsuarioRegistrado`.  
- `ValidadorDeUsuario` valida y notifica `UsuarioValidado` o `ErrorValidacion`.  
- `GeneradorDeMensajes` crea el mensaje de bienvenida.  
- `NotificadorDeUsuarios` envía el mensaje generado.  
- `LoggerDeBienvenida` registra cada paso.  
- Los componentes **no se conocen entre sí**; solo conocen al Mediator.

### ✔ Ventajas  
- Reduce el acoplamiento entre componentes.  
- Centraliza la lógica de interacción en un único punto.  
- Facilita modificar el flujo sin tocar los componentes.  
- Permite añadir nuevos eventos sin romper el código existente.  
- El enum evita errores de strings y mejora la escalabilidad.  


# 🧩 15. Memento

### 🎯 Idea principal  
Memento permite **guardar y restaurar el estado interno de un objeto sin violar su encapsulación**.  
Es ideal para implementar **Undo/Redo**, versiones o snapshots de objetos.

### 🧠 En este proyecto  
- `EditorDeMensajes` actúa como **Originator**: mantiene el estado del texto y sabe cómo guardarlo y restaurarlo.  
- `MensajeMemento` es el **snapshot inmutable** que captura el estado del editor en un momento concreto.  
- `HistorialDeMensajes` funciona como **Caretaker**, almacenando los estados sin conocer su contenido.  
- El cliente puede escribir texto, guardar estados y deshacer cambios restaurando snapshots previos.

### ✔ Ventajas  
- Permite deshacer cambios sin exponer la estructura interna del objeto.  
- Mantiene la encapsulación del estado.  
- Facilita guardar versiones o snapshots.  
- Cumple SRP (Single Responsibility Principle): la colección no gestiona la iteración.
- Cumple OCP (Open/Closed Principle): puedes ampliar el estado sin modificar el historial.  


# 🧩 16. Observer

### 🎯 Idea principal  
Observer permite que un objeto (**Subject**) notifique automáticamente a múltiples observadores (**Observers**) cuando su estado cambia.  
Cada observador reacciona de forma independiente, sin que el Subject conozca sus detalles internos.

### 🧠 En este proyecto  
- `ColeccionDeMensajesDeBienvenida` actúa como **Subject**: almacena mensajes y notifica a los observadores cuando se agrega uno nuevo.  
- `IObserver` define la interfaz común para todos los observadores.  
- `LoggerObserver`, `ContadorObserver`, `AuditoriaObserver` y `UppercaseObserver` son **Observers concretos** que reaccionan al mensaje recibido.  
- El cliente suscribe observadores y agrega mensajes; la colección se encarga de disparar las notificaciones.

### ✔ Ventajas  
- Reduce el acoplamiento: el Subject no conoce la lógica de los observadores.  
- Permite añadir o quitar observadores sin modificar el Subject.  
- Facilita la extensión del sistema con nuevos comportamientos reactivos.  
- Mantiene un flujo claro: agregar un mensaje → notificar automáticamente.  
- Encaja muy bien en sistemas basados en eventos, logs, auditoría o monitoreo.


# 🧩 17. State

### 🎯 Idea principal  
El patrón **State** permite que un objeto modifique su comportamiento cuando cambia su estado interno.  
Cada estado encapsula su propia lógica, evitando condicionales extensos y manteniendo el código más limpio y extensible.

### 🧠 En este proyecto  
- `IEstadoMensaje` define la interfaz común para todos los estados.  
- `EstadoInicial`, `EstadoEnProceso`, `EstadoFinalizado` y `EstadoError` son **estados concretos**, cada uno con su propio comportamiento.  
- `MensajeDeBienvenidaConEstado` actúa como **Contexto**, manteniendo el estado actual y delegando en él la generación del mensaje.  
- El cliente cambia el estado manualmente para mostrar cómo varía el comportamiento del mensaje.

### ✔ Ventajas  
- Elimina `if` o `switch` basados en estados.  
- Cada estado tiene una responsabilidad clara (alta cohesión).  
- Permite agregar nuevos estados sin modificar el código existente (OCP).  
- El comportamiento del objeto cambia de forma explícita y controlada.  
- Ideal para procesos con etapas, flujos dinámicos o máquinas de estados.


# 🧩 18. Strategy

### 🎯 Idea principal  
El patrón **Strategy** permite definir una familia de algoritmos, encapsularlos y hacerlos intercambiables.  
El contexto delega el comportamiento en la estrategia seleccionada, evitando condicionales y facilitando la extensibilidad.

### 🧠 En este proyecto  
- `IStrategySaludo` define la interfaz común para todas las estrategias.  
- `estrategiaSaludoFormal`, `estrategiaSaludoInformal` y `estrategiaSaludoNavidad` son estrategias concretas.  
- `MensajeDeBienvenidaConStrategy` actúa como contexto y delega el comportamiento en la estrategia actual.  
- El cliente puede cambiar la estrategia en tiempo de ejecución.

### ✔ Ventajas  
- Evita condicionales extensos.  
- Permite intercambiar algoritmos sin modificar el código del contexto.  
- Facilita agregar nuevas estrategias sin tocar las existentes OCP (Open/Closed Principle).
- Aumenta la cohesión y reduce el acoplamiento.


# 🧩 20. Template Method

## 🎯 Idea principal
Template Method define el esqueleto de un algoritmo en una clase base.  
Las subclases implementan o redefinen pasos concretos, pero la estructura general del proceso permanece fija.

## 🧠 En este proyecto
- `MensajeBienvenidaTemplate` define el flujo completo del mensaje:
  1. Saludo inicial  
  2. Cuerpo del mensaje  
  3. Despedida  
  4. Hook opcional  

- `MensajeBienvenidaFormal` y `MensajeBienvenidaInformal` personalizan los pasos necesarios.
- El cliente solo invoca `GenerarMensaje(nombre)`, no elige el algoritmo.

## ✔ Ventajas
- Reutiliza la estructura del algoritmo.
- Evita duplicación de código.
- Permite variaciones controladas del comportamiento.
- Mantiene el flujo del proceso inalterado.


# 🧩 21. Visitor

## 🎯 Idea principal
Visitor permite agregar operaciones nuevas a una jerarquía de clases **sin modificar los elementos existentes**.  
Cada elemento acepta un visitante, y el visitante ejecuta la operación adecuada según el **tipo concreto** del elemento.  
Este mecanismo se conoce como **doble despacho**.

## 🧠 En este proyecto
- Los elementos son distintos tipos de mensajes:
  - MensajeBienvenidaFormal  
  - MensajeBienvenidaInformal  
  - MensajeBienvenidaNavidad  
- Cada elemento expone un método `Aceptar`, que recibe un visitante y delega en él la operación correspondiente.
- Los visitantes representan comportamientos que queremos aplicar sobre los mensajes:
  - VisitanteImprimir  
  - VisitanteContarCaracteres  
- La interfaz del visitante define un método `Visitar` por cada tipo concreto de mensaje, permitiendo que el lenguaje seleccione automáticamente la operación correcta cuando el elemento ejecuta `visitante.Visitar(this)`.

## ✔ Ventajas
- Permite agregar operaciones nuevas sin modificar los elementos.
- Mantiene la jerarquía de mensajes estable y cerrada a cambios.
- Separa datos (elementos) de comportamientos (visitantes).
- Evita condicionales del tipo `if (esFormal) ... else if (esInformal) ...`.
- Facilita operaciones complejas sobre estructuras heterogéneas.

---

# ▶ Ejecución

Cada patrón tiene su propio ejemplo en `Program.cs` o en su carpeta correspondiente.  
Puedes ejecutar el proyecto y ver en consola:

- El mensaje generado por cada patrón  
- La explicación del patrón  
- Notas adicionales explicando el patrón  
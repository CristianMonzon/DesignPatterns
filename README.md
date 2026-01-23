# 🧩 Patrones de Diseño en C# — Ejemplos Didácticos  
Este repositorio contiene una colección de ejemplos prácticos y didácticos de **cuatro patrones de creación** del catálogo GoF, todos implementados con un dominio común: **Usuarios y Mensajes**.

El objetivo es mostrar **cómo se diferencian**, **cuándo usarlos** y **cómo se implementan** de forma clara, extensible y mantenible.

## 📚 Patrones incluidos

- **Factory Method**  
- **Abstract Factory**  
- **Builder**  
- **Prototype**

Cada patrón incluye:
- Interfaces  
- Implementaciones concretas  
- Ejemplo de uso  
- Explicación del patrón integrada en el código  

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
- Facilita añadir nuevos tipos de mensajes sin modificar código existente (OCP).  
- Evita condicionales del tipo “si es simple haz esto, si es compuesto haz lo otro”.  
- Muy útil para representar estructuras parte–todo (carpetas/archivos, menús/submenús, grupos de mensajes, etc.).


# ▶ Ejecución

Cada patrón tiene su propio ejemplo en `Program.cs` o en su carpeta correspondiente.  
Puedes ejecutar el proyecto y ver en consola:

- El mensaje generado por cada patrón  
- La explicación del patrón  

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
- Cumple DIP y OCP.  
- Fácil de extender con nuevos tipos de usuarios.  
- El cliente no conoce clases concretas.

---

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
- Cumple OCP y DIP.

# ▶ Ejecución

Cada patrón tiene su propio ejemplo en `Program.cs` o en su carpeta correspondiente.  
Puedes ejecutar el proyecto y ver en consola:

- El mensaje generado por cada patrón  
- La explicación del patrón  

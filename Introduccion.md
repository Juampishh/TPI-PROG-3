                                    Introducción 
En este informe buscamos describir el desarrollo de una aplicación que interactue
Con el usuario final destinada a la diagramación de un restaurante. Este proyecto se fue desarrollado utilizando .NET y C# en el entorno de Windows Forms, cumpliendo con las especificaciones requeridas en la consigna. Nuestra aplicación cuenta con dos modos principales uno de edición y otro de previsualización, y esta diseñada para ser sobre todas las cosas fácil de usar e intuitiva

Resultados esperados 
Desarrollar una app que permita a los usuarios diseñar y gestionar la distribución de uno o mas restaurantes
Implementar funcionalidades que faciliten la reserva y gestión de mesas, incluyendo la visualización del estado de cada mesa y su menú 
Almacenar y recuperar la distribución y los datos de uso en formatos JSON

Descripción de funciones 
Modo Edición
El modo edición permite a los usuarios crear un plano de la distribución del restaurante. Las funcionalidades clave incluyen:

Diseño del Plano: Los usuarios pueden arrastrar y soltar elementos desde una caja de herramientas para armar la distribución del restaurante, incluyendo mesas de distintos tamaños y formas, sillas individuales, divisores, paredes,baños, puertas y otros elementos necesarios  
Caja de Herramientas: Contiene todos los elementos necesarios para el diseño, permitiendo a los usuarios seleccionar y configurar cada uno de ellos según sus necesidades.
Guardar Distribución: La distribución creada puede guardarse en un archivo JSON
Modo Previsualización
El modo previsualización permite a los usuarios ver y gestionar el plano generado en el modo edición. Las funcionalidades clave incluyen:
    Estado de las Mesas: Visualización del estado de cada mesa (libre, reservada, ocupada).
Detalles de las Mesas y Sillas: Información sobre el número de mesa o silla

4. Diseño de la Aplicación
La aplicación se ha desarrollado utilizando Windows Forms para proporcionar una interfaz gráfica atractiva y fácil de usar. A continuación se describen los componentes principales del diseño:
Interfaz de Usuario (UI): Diseñada para ser intuitiva, con una clara separación entre los modos edición y previsualización. Los elementos se presentan de manera organizada y accesible.
Caja de Herramientas: Incluye todos los elementos necesarios para el diseño del plano del restaurante, permitiendo una fácil personalización.
Panel de Edición: Área donde los usuarios pueden arrastrar y soltar elementos para crear el plano del restaurante.
Panel de Previsualización: Área donde se muestra el estado actual del restaurante, incluyendo detalles de mesas y clientes.
5. Implementación Técnica
La implementación técnica de la aplicación incluye los siguientes aspectos:
•	Uso de .NET y C#: La aplicación se ha desarrollado utilizando el entorno .NET y el lenguaje de programación C#, aprovechando las capacidades de Windows Forms para la creación de interfaces gráficas.
•	Gestión de Archivos: Se ha implementado la funcionalidad para guardar y cargar distribuciones en formatos JSON
UserControl: El plano generado puede ser consumido por un UserControl dentro de una aplicación de gestión de restaurantes, permitiendo su integración en un sistema más amplio.

7. Futuras Mejoras
Para futuras versiones de la aplicación, se pueden considerar las siguientes mejoras:
•	Integración con Sistemas de Reserva en Línea: Permitir a los clientes realizar reservas directamente desde una plataforma en línea.
Optimización de la UI: Mejorar la interfaz de usuario para una experiencia más fluida y rápida.

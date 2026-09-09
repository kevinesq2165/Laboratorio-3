# Laboratorio #3 - Clases, Windows Forms y Consola en C#

Herramientas de la Programación Aplicada III (.Net)
Universidad Tecnológica de Panamá - Facultad de Ingeniería en Sistemas

Programado por: Kevin Esquivel

## Tecnologías utilizadas

- Lenguaje: C#
- IDE: Visual Studio 2026
- .NET (aplicaciones de consola y Windows Forms)

## Estructura del proyecto

Este laboratorio está dividido en 3 proyectos independientes, cada uno cubriendo un tema distinto del módulo:


## Crap - Juego de Craps

Aplicación de consola que simula el juego de dados Craps. Se trabajó con:

- Una clase Craps con el generador de números aleatorios (Random) para tirar los dados.
- Dos enum: uno para los nombres especiales de los números del dado (SIETE, ONCE, DOCE, etc.) y otro para el estado del juego (CONTINUA, GANA, PIERDE).
- Un switch que decide si el jugador gana, pierde o debe seguir tirando en el primer lanzamiento.
- Un while que repite los lanzamientos mientras el juego siga en estado CONTINUA, hasta que el jugador logre su punto o saque un 7.

## Lab#3 - Registro de Colaboradores con DataGridView

Aplicación de Windows Forms que registra personas y las muestra en una tabla. Se trabajó con:

- Una clase Persona con propiedades automáticas (Id, Nombres, Apellidos, Correo, FechaNacimiento, Salario).
- Una clase estática Utilidades con un método que valida, usando expresiones regulares (Regex), que el correo tenga un formato válido.
- Un List<Persona> que guarda todos los colaboradores ingresados y se enlaza al DataGridView para mostrarlos en forma de tabla.
- Un ErrorProvider que marca con un ícono de error los campos vacíos o inválidos (ID, nombres, apellidos, correo, salario) antes de dejar agregar un registro nuevo.
- Validación del salario con decimal.TryParse, para asegurar que lo ingresado sea un número válido antes de guardarlo.
- Un botón para limpiar la lista completa y dejar la tabla vacía.

## Formulario - Interfaz MDI

Aplicación de Windows Forms que muestra cómo abrir una ventana dentro de otra usando el patrón MDI (Multiple Document Interface). Se trabajó con:

- Form1 como el contenedor principal, con la propiedad IsMdiContainer en true.
- FormHijoTexto como la ventana hija que se abre dentro de Form1.
- Un botón en la barra de herramientas que, al presionarlo, crea una instancia de FormHijoTexto, le asigna MdiParent = this (para que quede contenida dentro del formulario padre) y la muestra con Show().

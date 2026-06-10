# Sistema de Gestión de Voluntariado

## Descripción General

Programa de consola desarrollado en C# que permite administrar los participantes de una organización de voluntariado.

La aplicación brinda la posibilidad de registrar voluntarios y coordinadores, almacenar sus datos en una colección y visualizar la información de todos los integrantes cargados en el sistema.

## Estructura del Proyecto

### Participante

Clase principal que reúne los datos básicos compartidos por todos los integrantes:

* Nombre
* DNI

### Voluntario

Clase derivada de Participante que representa a los voluntarios:

* Horas de servicio realizadas

### Coordinador

Clase derivada de Participante que incorpora datos específicos de coordinación:

* Área de trabajo asignada
* Número de personas supervisadas

## Funciones Disponibles

* Registrar nuevos voluntarios.
* Registrar nuevos coordinadores.
* Consultar la lista completa de participantes.
* Finalizar la ejecución del programa.

## Conceptos Implementados

* Programación Orientada a Objetos (POO).
* Herencia entre clases.
* Encapsulamiento de datos.
* Polimorfismo.
* Manejo de colecciones mediante `List<Participante>`.

## Tecnologías Utilizadas

* Lenguaje C#
* Aplicación de consola

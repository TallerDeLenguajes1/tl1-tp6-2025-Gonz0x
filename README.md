[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/24pP-Pw_)
## EJERCICIO 4
# ¿String es una tipo por valor o un tipo por referencia?
- Es un tipo por referencia (class)
- Pero se comporta como por valor en la práctica porque es inmutable y seguro de usar como si fuera un valor.
# ¿Qué secuencias de escape tiene el tipo string?
Secuencia	Significado
\n	Nueva línea (line feed)
\r	Retorno de carro (carriage return)
\t	Tabulación horizontal
\\	Barra invertida (\)
\"	Comillas dobles (")
\'	Comillas simples (')
\b	Retroceso (backspace)
\f	Avance de página (form feed)
\v	Tabulación vertical
\0	Null (carácter nulo, U+0000)
\uXXXX	Unicode en 4 dígitos hex (ej: \u00A9 → ©)
\xXX	Carácter ASCII/Unicode por código hexadecimal
# ¿Qué sucede cuando utiliza el carácter @ y $ antes de una cadena de texto?
@: Evita que se interpreten secuencias de escape como \n o \\. Útil para escribir rutas de archivo, texto multilinea, etc.
$: Permite insertar variables directamente en la cadena usando {}.
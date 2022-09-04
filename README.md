### Taller de Lenguajes II - 2022

# Trabajo Práctico N° 1 
## Manejo de Try - Catch

### 4.1) Diferentes formas de lanzar la excepción al método llamador...

```cs
catch (Exception ex)
{
    throw; //a
    throw new AlgunaExcepcion("mensaje de error 1", ex); //b
    throw new AlgunaExcepcion("mensaje de error 2"); //c
    throw ex; //d
}
```

**a)** Lanza una excepción dentro de un método sin proporcionar ningún argumento o información adicional sobre la la misma.

**b)** Genera una excepción especificando el mensaje de error y la instancia Exception que produjo la excepción actual. 

**c)** Genera una excepción especificando un mensaje de error.

**d)** Re-lanzar al método la excepción actual (que atrapó).

### 4.2) Propiedad StackTrace :

El "rastro de la pila" es una representación ordenada de la pila de llamadas cuando ocurre una propagación de excepciones. Es decir que, proporciona una forma de hacer un seguimiento hasta el número de línea en el método donde se produjo la excepción.


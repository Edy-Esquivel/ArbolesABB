Este Programa se utiliza para controlar una lista de tareas asignadas a un equipo de Desarrollo de Software, Por medio de arboles Binarios de Busqueda.

//INICIO

Datos que se deben ingresar en el Formulario:
  - Nombre de Tarea
  - Duración
  - Porcentaje de Avance
  - Programador Asignado
  
  
Funcionamiento:
- El programa Inserta la información y el recorrido de los datos ingresados se puede visualizar en PreOrden, InOrden, PostOrden por medio de sus botones.
- En la lógica del programa se creó una clase llamada Tarea, donde se guardan los datos de la pantalla y esta clase es el valor del nodo y este nodo maneja todo lo
  relacionado al manejo del arbol; Lo que se modifica es la interface comparador o bien se implementa en tarea para sobreescribir los metodos, de Mayor que, Menor que, Igual que,
  para que estos sean comparados por Nombre de Z a la letra A.
- Luego se tiene una sección en el formulario de Busqueda, la cual debe de ser escrita y al encontrarla, lanzará una alerta en pantalla confirmando la misma.
- Y por ultimo, en esa misma sección, se puede eliminar la tarea que se buscó al presionar el boton Eliminar del formulario.


//FIN

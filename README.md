# II-Introduccion-Unity

![Project GIF](escena.gif)

## Decripción

En esta escena se han utilizado tres objetos 3D básicos, un cubo, una esfera y un terreno modificado; un objeto (Pallet) del paquete "Industrial Props" y tres prefabs del paquete "Starter Assets" (caja, escalera y estructura), así como el personaje jugable con cámara en tercera persona del mismo paquete.

---

## Script

El script `PrintObjectPosition.cs` recorre los objetos hijos de un objeto vacío, mostrando el nombre y la posición de cada uno mediante su componente Transform. Este objeto actúa como padre de todos los objetos en la escena, facilitando el uso del script para obtener la posición necesitada. Al usar el método `Start()`, la posición se imprimirá una sola vez, al inicio del renderizado.

---

## Autor

Álvaro Fontenla León
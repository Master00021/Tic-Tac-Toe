# Devlog Tic-Tac-Toe

Decidí repasar la programación en C# nativo, por lo tanto, me propuse a crear este famoso juego, solamente con la consola y C# nativo.

El producto final esperado es tener un ciclo de juego completo, conectado el cierre con el inicio una vez la partida termina, incluyendo obviamente todas las "mecánicas" que este juego tiene.

Escribiré las dificultades que me vaya encontrando durante el desarrollo de este videojuego.

## 27 de mayo de 2024

Mi primera dificultad fue el crear el mismo proyecto. Nunca antes lo había hecho desde Visual Studio Code, por lo que fui a la página de inicio de VSC, vi el video de Getting Started. Entendí que lógicamente, para crear un nuevo proyecto, debería de utilizar el comando 'Ctrl + Shift + P' y desde aquella ventana crear un nuevo proyecto, y este, en específico, sería uno del tipo 'Console App'.

La segunda dificultad fue pensar en cómo debería de dividir las diferentes funcionalidades, en cuantos scripts, qué tarea cumpliría cada script, sin poder lograr dimensionar de forma clara el scope de las funcionalidades que debería tener el proyecto completado. Por esto, decidí simplemente 'tirarme a la piscina' e ir conociendo lo que necesitaba hacer, según lo que me propusiera hacer. De esta forma, la misma acción me diría que es lo siguiente que necesitaría para resolverla.

Lo siguiente fue ir probando qué es lo que me pedía el método Main del programa para que funcionara, recordando varias cosas. Por ejemplo, para utilizar métodos u objetos no estáticos dentro de un método estático, se necesita de tener dicho objeto instanciado. Esto me condujo a dividir cada funcionalidad en una clase, para instanciarlos dentro del main y así poder llamar a sus métodos según sea necesario.

La tercera y última dificultad de hoy fue la clase 'Turn' y más específicamente el bucle 'for' que se encarga de escribir en consola el tablero del Tic-Tac-Toe con el movimiento del jugador.

Hoy se me olvidó utilizarlo, pero en las siguientes sesiones utilizaré la aplicación 'Clockify' para medir mis tiempos de desarrollo de forma más precisa. Diría que hoy estuve unas tres horas y media.
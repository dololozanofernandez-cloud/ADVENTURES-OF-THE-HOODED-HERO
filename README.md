Las aventuras del héroe encapuchado
Adventures of the Hooded Hero es un juego de plataformas en 2D desarrollado en Unity. El jugador controla a un valiente héroe encapuchado que debe sortear obstáculos, evitar enemigos (como murciélagos) y llegar al final del nivel para alcanzar la victoria.

🚀 Características
Jugabilidad Clásica : Mecánicas de plataformas con movimiento fluido y saltos precisos.

Sistema de Límites : El jugador está restringido a los bordes de la pantalla para una experiencia de juego enfocada.

Enemigos Desafiantes : Contacto letal con enemigos que reinicia el nivel instantáneamente.

Interfaz multiplataforma : Menús adaptables y controles táctiles dinámicos que se ocultan automáticamente en versiones de escritorio.

Condición de Victoria : Sistema de detección de posición para pasar a la pantalla de "YOU WIN".

🛠️ Tecnologías Utilizadas
Motor : Unity 2022+ (o versión actual).

Lenguaje : C#.

Sistema de entrada : Nuevo paquete de Unity Input System para soporte de teclado y controles táctiles.

UI : Canvas Scaler responsivo para múltiples resoluciones.

🕹️ Controles
Escritorio (PC/Mac)
Moverse : Teclas A/ Do Flechas de dirección.

Saltar : Barra espaciadora ( Space).

Móvil (Android/iOS)
Joystick/Botones en pantalla : Controles táctiles dedicados en la parte inferior de la interfaz.

📂 Instalación y configuración
Clonar el repositorio :

Intento

git clone https://github.com/tu-usuario/hooded-hero.git
Abrir en Unity : Importar la carpeta del proyecto desde el Unity Hub.

Configuración de Escenas :

Asegúrese de agregar las escenas en File > Build Settingsel siguiente orden:

MenuPrincipal(Índice 0)

Escena1(Índice 1)

Fin(Índice 2)

📝 Guiones principales
MovimientoJugador.cs: Gestiona la física del personaje y aplica el Mathf.Clamppara los límites de pantalla.

Enemigo.cs: Controla la detección de colisiones mediante OnCollisionEnter2Dpara reiniciar la escena.

Botones.cs: Maneja la lógica de navegación entre menús (Iniciar, Reiniciar, Salir).

VisibilidadBotones.cs: Detecta la plataforma activa para mostrar u ocultar la interfaz táctil.

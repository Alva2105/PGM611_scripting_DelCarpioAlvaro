# PGM611 - Juego 2D (Del Carpio Alvaro)

Videojuego de plataformas 2D en etapa inicial, desarrollado en Unity siguiendo la guía "Creando un videojuego 2D con Unity".

## Requisitos

- Unity **6000.3.16f1** (Unity 6.3 LTS) con Universal 2D
- Escena principal: `Assets/Scenes/SampleScene.unity`

## Controles

| Acción | Tecla |
|---|---|
| Moverse | Flechas ← → o A / D |
| Saltar | Espacio |

## Funcionalidades

- **Animaciones** del personaje para reposo, correr y saltar (`Assets/Animaciones/Jugador/PjController.controller`).
- **Coleccionables:** abejas que desaparecen al tocarlas, con contador en pantalla (TextMeshPro).
- **Cámara** que sigue al personaje (`Assets/Scripts/Camara.cs`).
- Piso con Tilemap y colisiones, salto con detección de piso.
- Enemigos (puerquitos) y zona de caída que reinician el nivel.

## Scripts

- `Assets/Scripts/Jugador.cs`: movimiento, salto, animaciones, recolección y reinicio del nivel.
- `Assets/Scripts/Camara.cs`: seguimiento de la cámara.

## Recursos

Sprites: [Legacy Fantasy - High Forest (anokolisa)](https://anokolisa.itch.io/sidescroller-pixelart-sprites-asset-pack-forest-16x16)

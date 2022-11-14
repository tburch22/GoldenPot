# GoldenPot
---

### Planung
Ich habe mir vorgenommen ein Konsolenspiel zu programmieren. Dabei wollte ich mir etwas vornehmen womit ich schon vertraut bin, aber trotzdem einen Lernfaktor vorfinde. Somit mache ich eine portierung einer CLI-Render-Engine die ich zuvor in Python entwickelt hatte.
Mit dieser Engine möchte ich das Arcade Spiel Mario-Bros nachbilden.

### Architektur 
Die App besteht aus einigen Komponenten. Man kann das Programm in zwei Konzerne aufteilen, 1. Das Spiel, 2. die Render-Engine.  

CLI-Render:
   Die Render-Engine besteht aus der Renderer Klasse welche die Grafikrohdaten nimmt und in ein 2d Char-Array umwandelt welches auf der Konsole angezeigt werden kann.
   Die Grafikrohdaten werden in der Canvas (Leinwand) Klasse zwischengespeichert, somit kann man mehrere Grafikkontexte verwalten, bspw. für Hintergrund und Vordergrund.
   Die Grafikrohdaten werden von sogenannten Paintern (Maler/Künstler) generiert mit eingabeparametern die auch bei Runtime geändert werden können.
   Das grundsätzliche Basiselement ist das Rich (Reich - Von Rich Text, Text mit Formatdaten), dieses element wird in den Canvas benutzt und vom Renderer zu strings verarbeitet.
   
### Roadmap
* [x] Basics            - Basisklassen fertigstellen
* [ ] Game Loop         - Ein Mainloop der Painter-Parameter ändert
* [ ] Viewport          - Ein In-Between-Painter (Nimmt Painterdaten an und wandelt sie weiter), simuliert eine Kamera
* [ ] UI                - Ein GUI-System
* [ ] Analog Reflection - Automatisches Gameobject -> Grafikkontext linking
* [ ] Color Bleed       - Metatransparenz für Farben (Riches übernehmen Farben von Riches im Hintergrund)

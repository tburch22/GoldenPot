# GoldenPot
---

### Planung
Ich habe mir vorgenommen ein Konsolenspiel zu programmieren. Dabei wollte ich mir etwas vornehmen womit ich schon vertraut bin, aber trotzdem einen Lernfaktor vorfinde. Somit mache ich eine portierung einer CLI-Render-Engine die ich zuvor in Python entwickelt hatte.
Mit dieser Engine möchte ich das Spiel Super Mario Bros. nachbilden.

### Anforderungen
* Generator-Klassen für Grafiken.
* Leinwand mit mehreren Ebenen.
* Transparenz
* Farbe
* Platformer System
* Implementation von Mario Bros. (Arcade)

### Architektur 
Die App besteht aus einigen Komponenten. Man kann das Programm in zwei Konzerne aufteilen, 1. Das Spiel, 2. die Render-Engine.  

CLI-Render:
   Die Render-Engine besteht aus der Renderer Klasse welche die Grafikrohdaten nimmt und in ein 2d Char-Array umwandelt welches auf der Konsole angezeigt werden kann.
   Die Grafikrohdaten werden in der Canvas (Leinwand) Klasse zwischengespeichert, somit kann man mehrere Grafikkontexte verwalten, bspw. für Hintergrund und Vordergrund.
   Die Grafikrohdaten werden von sogenannten Paintern (Maler/Künstler) generiert mit eingabeparametern die auch bei Runtime geändert werden können.
   Das grundsätzliche Basiselement ist das Rich (Reich - Von Rich Text, Text mit Formatdaten), dieses element wird in den Canvas benutzt und vom Renderer zu strings verarbeitet.  
   #M2 Blitting von Objekten auf Leinwand und erster teil Renderer.  
   #M3 Renderer fertiggestellt.  
   #M4 Renderer funktionstüchtig.
   
# Milestone 5: Zusammenfassung
Der letzte Milestone wurde nun erreicht, jedoch wurde das Projekt nicht fertiggestellt, was war los, was sollte man beim nächsten mal besser machen?
Zu nächst sollte man betrachten was bisher erreicht wurde.
Ich habe eine 2D render engine in C# entwickelt. Diese ist voll funktionsfähig und entspricht den initialen Anforderungen.
Es können Grafiken generiert oder manuell eingebunden werden. Diess können programmatisch auf einer Leinwand platziert werde.
Grafiken können beliebige ASCII oder UNICODE zeichen in beliebigen Farben verwenden.
Alle Grafiken sind selbstständing, selbst die Leinwände sind selbständig und können in mehreren Renderer-Instanzen verwendet werden, 
und voneinander unabhängig modifiziert werden.
Alle Grafikobjekte sind auf verschiedenen Ebenen, so kann ein Tiefeneffekt erzeugt werden.
Zuletzt unterstütz die engine Transparenz zwischen den Grafikobjekten.
Damit wurde der große schwierige Teil des Projekts implementiert.

## Was fehlt?
Grundsätzlich Fehlt das Spiel das auf der Engine aufgebaut werden sollte.
Nur ein Teil des Spielfelds wurde zu Testzwecken der Engine eingebaut.

## Was sollte man besser machen?
Beim nächsten mal sollte man sich kleinere Projekte vornehmen. Dieses Projekt ist schließlich 2 Projekte in einem, beide sind sehr Komplex und groß,
für ein Starterprojekt.
Zudem sollte man ein besseres Zeitmanagement durchsetzen.
  
  
### Roadmap
* [x] Basics                - Basisklassen fertigstellen (Canvas, etc.)
* [x] Transparenzkomponente - Transparenz einbinden.
* [X] Renderer              - Render Klasse zum funktionieren bringen.
* [X] Game Loop             - Ein Mainloop der Painter-Parameter ändert.
* [X] Surface Painter       - Custom Grafiken Anzeigen.
* [/] Sprite Painter        - Spieler mit Spritesheet Animation.
* [/] Kollisionen           - Gravitation
* [/] Gegner                - Gegner die auf der Map sich bewegen.
* [/] Bezier Transform      - Painter der Bezier kurven darstellt.

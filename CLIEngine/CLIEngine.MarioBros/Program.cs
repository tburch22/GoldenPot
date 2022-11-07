namespace CLIEngine.MarioBros;
using _painters;

/*
* [-] Basics
* [ ] Color Display
* [ ] Game Loop
* [ ] Viewport
* [ ] UI
* [ ] Analog Reflection
* [ ] Color Bleed
*/

// Main Program
class Program {
    static public void Main(String[] args)
    {
        Renderer renderman = new Renderer();
        Canvas demoCanvas = new Canvas(80, 45);

        demoCanvas.Blit(new BasicText().Paint());
    }
}
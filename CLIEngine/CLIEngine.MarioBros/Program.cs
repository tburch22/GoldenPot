namespace CLIEngine.MarioBros;
using _painters;

// Main Program
class Program {
    static public void Main(String[] args)
    {
        Renderer renderman = new Renderer();
        Canvas demoCanvas = new Canvas(80, 45);

        demoCanvas.Blit(new BasicText("Test Text", Color.Black, BGColor.White).Paint(), (0, 0));
    }
}
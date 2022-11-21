namespace CLIEngine.MarioBros;
using _painters;

// Main Program
class Program {
    static public void Main(String[] args)
    {
        Renderer renderman = new Renderer();
        Canvas baseCanvas = new Canvas(80, 45);

        baseCanvas.Blit(new BasicText("Test Text", Color.Black, BGColor.White).Paint(), (0, 0));
        renderman.Stash(baseCanvas);


        while(true) {
            ConsoleWrapper.flush(renderman.Process((baseCanvas.size.Item1, baseCanvas.size.Item2)));

            ConsoleWrapper.throttle(17);
        }
    }
}
namespace CLIEngine.MarioBros;
using _painters;

// Main Program
class Program {
    static public void Main(String[] args)
    {
        Renderer renderman = new Renderer();
        Canvas baseCanvas = new Canvas(125, 42);


        baseCanvas.Blit(new BasicText("Mario Bros. CLI 0.4.1-alpha", Color.Black, BGColor.White).Paint(), (baseCanvas.size.Item1/2, baseCanvas.size.Item2-1));
        renderman.Stash(baseCanvas);

        while(true) {
            ConsoleWrapper.flush(renderman.Process((baseCanvas.size.Item1, baseCanvas.size.Item2)));
            ConsoleWrapper.throttle(30);
        }
    }
}
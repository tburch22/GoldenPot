namespace CLIEngine.MarioBros;
using _painters;

// Main Program
class Program {
    static public void Main(String[] args)
    {
        Renderer renderman = new Renderer();
        Canvas baseCanvas = new Canvas(125, 42);

        #region PlayingField
        baseCanvas.Blit(new BlockGen(new Rich("\u2800", Color.Black, BGColor.Black), baseCanvas.size.Item1, baseCanvas.size.Item2));
        baseCanvas.Blit(
            new Surface(
            "      ######\n"+
            "############\n"+
            "############\n"+
            "############\n"+
            "############\n"+
            "      ######\n",
            Color.LGreen, 
            BGColor.Black
            ).Paint(), (0, 0)
        );
        #endregion

        #region UIElements
        baseCanvas.Blit(new BasicText("Mario Bros. CLI 0.4.1-alpha", Color.Black, BGColor.White).Paint(), (baseCanvas.size.Item1/2, baseCanvas.size.Item2-1));
        #endregion

        renderman.Stash(baseCanvas);
        while(true) {
            ConsoleWrapper.flush(renderman.Process((baseCanvas.size.Item1, baseCanvas.size.Item2)));
            ConsoleWrapper.throttle(30);
        }
    }
}
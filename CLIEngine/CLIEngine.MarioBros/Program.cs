namespace CLIEngine.MarioBros;
using _painters;

// Main Program
class Program {
    static public void Main(String[] args)
    {
        Renderer renderman = new Renderer();
        Canvas baseCanvas = new Canvas(145, 42);

        #region PlayingField
        baseCanvas.Blit(new BlockGen(new Rich("\u2588", Color.Black, BGColor.Black), (baseCanvas.size.Item1, baseCanvas.size.Item2)).Paint(), (0, 0));
        baseCanvas.Blit(
            new Surface(
            "      \u2588\u2588\u2588\u2588\u2588\u2588\n"+
            "\u2588\u2588\u2588\u2588\u2588\u2588\u2588\u2588\u2588\u2588\u2588\u2588\n"+
            "\u2588\u2588\u2588\u2588\u2588\u2588\u2588\u2588\u2588\u2588\u2588\u2588\n"+
            "\u2588\u2588\u2588\u2588\u2588\u2588\u2588\u2588\u2588\u2588\u2588\u2588\n"+
            "\u2588\u2588\u2588\u2588\u2588\u2588\u2588\u2588\u2588\u2588\u2588\u2588\n"+
            "      \u2588\u2588\u2588\u2588\u2588\u2588\n",
            Color.LGreen, 
            BGColor.Black
            ).Paint(), (0, 4)
        );
        baseCanvas.Blit(
            new Surface(
            "      \u2588\u2588\u2588\u2588\u2588\u2588\n"+
            "\u2588\u2588\u2588\u2588\u2588\u2588\u2588\u2588\u2588\u2588\u2588\u2588\n"+
            "\u2588\u2588\u2588\u2588\u2588\u2588\u2588\u2588\u2588\u2588\u2588\u2588\n"+
            "\u2588\u2588\u2588\u2588\u2588\u2588\u2588\u2588\u2588\u2588\u2588\u2588\n"+
            "\u2588\u2588\u2588\u2588\u2588\u2588\u2588\u2588\u2588\u2588\u2588\u2588\n"+
            "      \u2588\u2588\u2588\u2588\u2588\u2588\n",
            Color.LGreen, 
            BGColor.Black
            ).Paint(), (baseCanvas.size.Item1-12, 4)
        );
        baseCanvas.Blit(new BlockGen(new Rich("\u2592", Color.Blue, BGColor.Red), (baseCanvas.size.Item1, 3)).Paint(), (0, 0));
        #endregion

        #region UIElements
        baseCanvas.Blit(new BasicText("Mario Bros. CLI 0.5.7-alpha", Color.Black, BGColor.White).Paint(), ((baseCanvas.size.Item1/2)-14, baseCanvas.size.Item2-2));
        #endregion

        renderman.Stash(baseCanvas);
        while(true) {
            ConsoleWrapper.flush(renderman.Process((baseCanvas.size.Item1, baseCanvas.size.Item2)));
            ConsoleWrapper.throttle(30);
        }
    }
}
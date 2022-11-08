namespace CLIEngine.MarioBros;

// Stores frame data layers.
public class Canvas
{
    // Layer<Y<X<Char>>>
    private List<List<List<Rich>>> store;
    private (int, int) size;

    public Canvas(int xSrc, int ySrc) {
        store = new List<List<List<Rich>>>();
        size = (xSrc, ySrc);
    }

    public void Blit(List<List<Rich>> layer, (int, int) locator) {
        List<Rich> hMargin = new List<Rich>();
        Rich vSpacer = new Rich(" ", Color.Opacity, BGColor.Opacity);

    }

    public List<List<List<Rich>>> Layers() {
        return store;
    }
}

namespace CLIEngine.MarioBros;

// Stores frame data layers.
public class Canvas
{
    // Layer<Y<X<Char>>>
    List<List<List<Rich>>> store;
    (int, int) size;

    public Canvas(int xSrc, int ySrc) {
        store = new List<List<List<Rich>>>();
        size = (xSrc, ySrc);
    }

    public void Paint(List<List<Rich>> layer, (int, int) locator) {

    }

    public List<List<List<Rich>>> Layers() {
        return store;
    }
}

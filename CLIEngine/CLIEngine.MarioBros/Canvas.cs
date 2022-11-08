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
        List<List<Rich>> result = new List<List<Rich>>();
        Rich vSpacer = new Rich(" ", Color.Opacity, BGColor.Opacity);
        List<Rich> hFinalSpacer = Enumerable.Repeat(vSpacer, size.Item1).ToList();

        Console.WriteLine(layer.ToString());

        foreach(List<Rich> row in layer) {
            List<Rich> hSpacer = Enumerable.Repeat(vSpacer, locator.Item1).ToList();
            hSpacer.AddRange(row);
            hSpacer.AddRange(Enumerable.Repeat(vSpacer, size.Item1-(row.Count+locator.Item1)));
            result.Append(hSpacer);
        }

        for(int a = 0; a < locator.Item2; a++) {
            result.Prepend(hFinalSpacer);
        }

        for(int b = 0; b < size.Item2-result.Count; b++) {
            result.Append(hFinalSpacer);
        }    

        store.Append(result);    

        Console.WriteLine(layer.ToString());
    }

    public List<List<List<Rich>>> Layers() {
        return store;
    }
}

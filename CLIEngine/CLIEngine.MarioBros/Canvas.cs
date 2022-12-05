using Newtonsoft.Json;

namespace CLIEngine.MarioBros;

// Stores frame data layers.
public class Canvas
{
    // Layer<Y<X<Char>>>
    private List<List<List<Rich>>> store;
    public (int, int) size;

    public Canvas(int xSrc, int ySrc) {
        store = new List<List<List<Rich>>>();
        size = (xSrc, ySrc);
    }

    public void Blit(List<List<Rich>> layer, (int, int) locator) {
        List<List<Rich>> result = new List<List<Rich>>();
        Rich spacer = new Rich(" ", Color.Opacity, BGColor.Opacity);
        List<Rich> hFinalSpacer = Enumerable.Repeat(spacer, size.Item1).ToList();

        result.AddRange(Enumerable.Repeat(hFinalSpacer, locator.Item2));

        foreach(List<Rich> row in layer) {
            List<Rich> hSpacer = Enumerable.Repeat(spacer, locator.Item1).ToList();
            hSpacer.AddRange(row);
            hSpacer.AddRange(Enumerable.Repeat(spacer, size.Item1-(row.Count+locator.Item1)));
            result.Add(hSpacer);
        }

        result.AddRange(Enumerable.Repeat(hFinalSpacer, size.Item2-(result.Count)));

        store.Add(result);
    }

    public List<List<List<Rich>>> Layers() {
        return store;
    }
}

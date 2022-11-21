namespace CLIEngine.MarioBros;

// Takes a canvas or analog object and generates a composite of each layer.
public class Renderer
{
    private List<List<List<Rich>>> buffer;
    private List<List<Rich>> final;
    private List<dynamic> contexts;

    public Renderer() {
        buffer = new List<List<List<Rich>>>();
        final = new List<List<Rich>>();
        contexts = new List<dynamic>();
    }
    
    public void Stash(dynamic context) {
        contexts.Add(context);
    }

    private bool isTransparent(Rich currRich) {
        if (currRich.simpleChar() == "\u2800") {
            return true;
        } else {
            return false;
        }
    }

    private String flatten((int, int) size) {
        String finalString = "";
        for(int scanY = 0; scanY < size.Item2; scanY++) {
            for(int scanX = 0; scanX < size.Item1; scanX++) {
                finalString += final[scanY][scanX].glue();
            }
            finalString += "\n";
        }
        return finalString;
    }

    public string Process((int, int) size) {
        // Clear the buffer.
        buffer =  new List<List<List<Rich>>>();
        final = new List<List<Rich>>();

        // Convert contexts into layers and push them onto the buffer.
        foreach(dynamic contextObject in contexts) {
            if (contextObject is Canvas) {
                buffer.AddRange(contextObject.Layers());
            }
        }

        // Flatten the buffer and push result into final. - Main Render Algorithm
        for(int partY = size.Item2; partY > 0; partY--) {
            List<Rich> horizontalScan = new List<Rich>();
            for(int partX = size.Item1; partX > 0; partX--) {
                Rich swapChar = new Rich("\u2800", Color.Opacity, BGColor.Opacity);
                foreach(List<List<Rich>> layer in buffer) {
                    Rich currRich = layer[partY][partX];
                    if(isTransparent(currRich)) {
                        break;
                    } else {
                        swapChar = currRich;
                    }
                }
                horizontalScan.Add(swapChar);
            }
            final.Add(horizontalScan);
        }

        // Turn the final buffer into a printable string and return it.
        return flatten(size);
    }
}

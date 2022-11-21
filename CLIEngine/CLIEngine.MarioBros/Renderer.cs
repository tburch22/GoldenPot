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

    private String flatten() {
        return "";
    }

    public string Process((int, int) size) {
        // Convert contexts into layers and push them onto the buffer.
        foreach(dynamic contextObject in contexts) {
            if (contextObject is Canvas) {
                buffer.AddRange(contextObject.Layers());
            }
        }

        // Flatten the buffer and push result into final. - Main Render Algorithm
        (int, int) pointer = size;
        for(int partY = size.Item2; partY > 0; partY--) {
            for(int partX = size.Item1; partX > 0; partX--) {
                foreach(List<List<Rich>> layer in buffer) {
                    
                }
            }
        }

        // Turn the final buffer into a printable string.
        return "kwje\u2800lkw";
    }
}

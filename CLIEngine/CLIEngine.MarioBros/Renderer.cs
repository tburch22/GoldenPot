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

    public string Process() {

        // Convert contexts into layers and push them onto the buffer.
        foreach(dynamic contextObject in contexts) {
            if (contextObject is Canvas) {
                buffer.AddRange(contextObject.Layers());
            }
        }

        // Flatten the buffer and push result into final. - Main Render Algorithm


        // Turn the final buffer into a printable string.
        return "kwjelkw";
    }
}

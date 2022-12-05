namespace CLIEngine.MarioBros._painters;

// Generates true text.
public class BasicText : IPainter
{
    private string text;
    private Color fgcolor;
    private BGColor bgcolor;

    public BasicText(string input, Color fg, BGColor bg) {
        text = input;
        fgcolor = fg;
        bgcolor = bg;
    }

    private Rich toRich(Char mod) {
        return new Rich(mod.ToString(), fgcolor, bgcolor);
    }

    public List<List<Rich>> Paint() {
        List<List<Rich>> output = new List<List<Rich>>();
        List<Rich> charArray = new List<Rich>();
        foreach (Char charTmp in text) {
            charArray.Add(toRich(charTmp));
        }
        output.Add(charArray);
        return output;
    }
}

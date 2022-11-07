namespace CLIEngine.MarioBros;

// A rich character, saves symbol info along with color and miscellaneous data.
public class Rich
{
    private string character;
    private Color charColor;
    private BGColor charBackground;

    public Rich(string charSrc, Color clSrc, BGColor bgSrc) {
        character = charSrc;
        charColor = clSrc;
        charBackground = bgSrc;
    }

    public string glue() {
        return "\u001b[" + (int) charColor + ";" + (int) charBackground + "m" + character + "\u001b[0m";
    }
}

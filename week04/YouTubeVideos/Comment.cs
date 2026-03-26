public class Comment
{
    private string _commentername;
    private string _text;

    public Comment(string name, string text)
    {
        _commentername = name;
        _commenttext = text;
    }

    public string GetName()
    {
        return _commentername;
    }

    public string GetText()
    {
        return _commenttext;
    }
}
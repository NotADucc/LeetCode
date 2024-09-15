using LeetCode.Shared;

namespace LeetCode.CSharp;

internal class Solution0535 : IRunProgram
{
    private record Input(string Data, string Result);
    public void Run()
    {
        Input[] inputs = new Input[]
        {
            new Input("http://badge.example.net/beginner.aspx?aftermath=achiever&actor=air", "http://badge.example.net/beginner.aspx?aftermath=achiever&actor=air")
        };

        foreach (Input input in inputs)
        {
            var encoded = encode(input.Data);
            Console.WriteLine(encoded);
            Console.WriteLine(decode(encoded));
            Console.WriteLine(input.Result);
            Console.WriteLine();
        }
    }

    private Dictionary<string, string> _decoded = new Dictionary<string, string>();
    private Dictionary<string, string> _encoded = new Dictionary<string, string>();

    private const string _prefixTinyURL = "http://tinyurl.com/";
    public string encode(string longUrl)
    {
        if (!_decoded.ContainsKey(longUrl))
        {
            string count = (_decoded.Count + 1).ToString();
            _decoded.Add(longUrl, count);
            _encoded.Add(count, longUrl);
        }

        return $"{_prefixTinyURL}{_decoded[longUrl]}";
    }
    public string decode(string shortUrl)
    {
        return _encoded[shortUrl[(shortUrl.LastIndexOf("/") + 1)..]];
    }
}

public class Codec
{

    Dictionary<string,string> dict1 = new Dictionary<string,string>();
    Dictionary<string,string> dict2 = new Dictionary<string,string>();
    int num=1;
    string shorturl = \http://tinyurl.com//\;
    // Encodes a URL to a shortened URL
    public string encode(string longUrl)
    {
        shorturl += $\{num++}\;
        dict1[longUrl] = shorturl  ;
        dict2[shorturl] =longUrl ;
        return dict1[longUrl];
    }

    // Decodes a shortened URL to its original URL.
    public string decode(string shortUrl)
    {
        return dict2[shorturl];
    }
}
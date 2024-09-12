using LeetCode.Shared;
using System.Text.RegularExpressions;

namespace LeetCode.CSharp;

internal class Solution0468 : IRunProgram
{
    public void Run()
    {
        ValidIPAddress("172.16.254.1").Print();
        ValidIPAddress("2001:0db8:85a3:0:0:8A2E:0370:7334").Print();
    }
    public string ValidIPAddress(string queryIP)
    {
        if (ValidIpv4(queryIP))
        {
            return "IPv4";
        }
        else if (ValidIpv6(queryIP))
        {
            return "IPv6";
        }
        else
        {
            return "Neither";
        }
    }

    private bool ValidIpv4(string ip)
    {
        var regex = new Regex(@"^((25[0-5]|2[0-4][0-9]|1[0-9]{1,2}|[0-9])[.]){3}((25[0-5]|2[0-4][0-9]|1[0-9]{1,2}|[0-9]))$", RegexOptions.Compiled);
        return regex.IsMatch(ip);
    }

    private bool ValidIpv6(string ip)
    {
        var regex = new Regex(@"^([0-9abcdefABCDEF]{1,4}:){7}[0-9abcdefABCDEF]{1,4}$", RegexOptions.Compiled);
        return regex.IsMatch(ip);
    }
}

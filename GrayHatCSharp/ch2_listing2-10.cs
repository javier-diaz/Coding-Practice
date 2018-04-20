using System;

class AnyClass
{
    public static void Main( string[] args )
    {
        string url = args[0];
        int index = url.IndexOf( "?" );
        string[] parms = url.Remove(0, index+1).Split('&');

        foreach (string parm in parms)
        {
            string xssUrl = url.Replace(parm, parm + "fd<xss>sa");
            string sqlUrl = url.Replace(parm, parm + "fd'sa");

            Console.WriteLine(xssUrl);
            Console.WriteLine(sqlUrl);
        }
    } 
}

using System;
using System.Text.RegularExpressions;

public class PhoneNumber
{
    private string number;
    private string smsNumber;
    public PhoneNumber(string phoneNumber)
    {
        number = phoneNumber;
        smsNumber = "0000000000";

        Regex rgx = new Regex("[^0-9]");
        string bareNumber = rgx.Replace(number, "");

        if (bareNumber.Length == 11 && bareNumber.StartsWith("1"))
        {
            smsNumber = bareNumber.Substring(1, 10);
        }
        else if (bareNumber.Length == 10)
        {
            smsNumber = bareNumber;
        }
    }


    public string Number
    {
        get
        {
            return smsNumber;
        }
    }

    public string AreaCode
    {
        get
        {
            return smsNumber.Substring(0, 3);
        }
    }

    public override string ToString()
    {
        return string.Format("({0}) {1}-{2}", smsNumber.Substring(0, 3), smsNumber.Substring(3, 3), smsNumber.Substring(6, 4));
    }
}
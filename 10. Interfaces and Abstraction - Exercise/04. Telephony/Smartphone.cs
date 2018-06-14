namespace _04._Telephony
{
    using Interfaces;

    public class Smartphone : ICallable, IBrowsable
    {
        public string Browse(string url)
        {
            if (!this.IsValidUrl(url))
            {
                return "Invalid URL!";
            }

            return $"Browsing: {url}!";
        }

        private bool IsValidUrl(string url)
        {
            for (int i = 0; i < url.Length; i++)
            {
                if (char.IsDigit(url[i]))
                {
                    return false;
                }
            }

            return true;
        }

        public string Call(string number)
        {
            if (!this.IsValidNumber(number))
            {
                return "Invalid number!";
            }

            return $"Calling... {number}";
        }

        private bool IsValidNumber(string number)
        {
            for (int i = 0; i < number.Length; i++)
            {
                if (char.IsLetter(number[i]) || char.IsSymbol(number[i]))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
using System;
using System.Text.RegularExpressions;

namespace UsingVersionAttribute
{
    class VersionAttribute : Attribute
    {
        private string version;

        public VersionAttribute()
        {
            Version = "1.0";
        }

        public VersionAttribute(string version)
        {
            this.Version = version;
        }

        public string Version
        {
            get
            {
                return version;
            }
            private set
            {
                if (Regex.IsMatch(value, @"\b[0-9]+\.[0-9]+\b"))
                {
                    version = value;
                }
                else
                {
                    throw new FormatException("The version in the Version attribute must be in the format majorVersion.minorVersion!");
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Task14
{
    [AttributeUsage(AttributeTargets.Property)]
    public class PatternAttribute : Attribute
    {
        private string Pattern { get; }

        public PatternAttribute(string pattern) => Pattern = pattern;

        public bool CheckPattern(string input) => Regex.IsMatch(input, Pattern);
    }
}

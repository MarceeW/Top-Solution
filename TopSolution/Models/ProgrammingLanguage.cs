using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace TopSolution.Models
{
    public static class ProgrammingLanguageValues
    {
        public static readonly string[] Values = new string[] { "C#","C++","C","JAVA","PYTHON" };
    }
    public enum ProgrammingLanguage
    {
        CSharp,
        Cpp,
        C,
        Java,
        Python,
    }
}

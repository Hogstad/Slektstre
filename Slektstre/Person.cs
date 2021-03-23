using System;
using System.Dynamic;

namespace Slektstre
{
    public class Person
    {
        public int? Id;
        public string FirstName;
        public string LastName;
        public int? BirthYear;
        public int? DeathYear;
        public Person Father;
        public Person Mother;
        private string getContent(string pre, object value, string after = null)
        {
            return value == null ? "" : $"{pre}{value}{after ?? ""}";
        }
        public string GetDescription()
        {
            return getContent("", FirstName, " ") +
                   getContent("", LastName, " ") +
                   getContent("(Id=", Id, ")") +
                   getContent(" Født: ", BirthYear, " ") +
                   getContent("Død: ", DeathYear, " ") +
                   getContent("Far: ", Father, "") +
                   getContent(" Mor: ", Mother, "");
        }
        public override string ToString()
        {
            if (Id != null)
            {
                return $"{FirstName ?? ""} {LastName ?? ""}(Id={Id})".Trim();
            }
            else return $"{FirstName ?? ""} {LastName ?? ""}".Trim();
        }
    }
}

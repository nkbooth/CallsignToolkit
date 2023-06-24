using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallsignToolkit.Utilities
{
    public class Name
    {
        public string FirstName
        {
            get
            {
                return firstName ?? FullName;
            }
            set
            {
                if (!string.IsNullOrEmpty(fullName) || fullName == "")
                {
                    firstName = value;
                }
                else
                {
                    throw new ArgumentException("Cannot set FirstName directly if FullName is already set");
                }

            }
        }
        public string LastName
        {
            get
            {
                return lastName ?? string.Empty;
            }
            set
            {
                if (!string.IsNullOrEmpty(fullName))
                {
                    lastName = value;
                }
                else
                {
                    throw new ArgumentException("Cannot set LastName directly if FullName is already set");
                }
            }
        }

        public string FullName
        {
            get
            {
                if (!string.IsNullOrEmpty(fullName) || fullName == "")
                {
                    return fullName;
                }
                else
                {
                    return $"{FirstName} {LastName}";
                }
            }

            set
            {
                if (string.IsNullOrEmpty(FirstName) || string.IsNullOrEmpty(LastName))
                {
                    fullName = value;
                }
                else
                {
                    throw new ArgumentException("Cannot set FullName directly if FirstName and LastName are already set");
                }
            }
        }
        public string FullNameReverse
        {
            get
            {
                if (!string.IsNullOrEmpty(fullName) || fullName == "")
                {
                    return fullName;
                }
                else
                {
                    return $"{LastName}, {FirstName}";
                }
            }

        }

        private string fullName = string.Empty;
        private string firstName = string.Empty;
        private string lastName = string.Empty;


        public Name() { }
        public Name(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }
    }
}

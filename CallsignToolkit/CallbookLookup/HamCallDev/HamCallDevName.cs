using CallsignToolkit.Utilities;

namespace CallsignToolkit.CallbookLookup.HamCallDev
{
    public class HamCallDevName : Name
    {
        public new string FullName
        {
            get
            {
                if (!string.IsNullOrEmpty(fullName) || fullName == "")
                {
                    return fullName;
                }
                else if (!string.IsNullOrEmpty(firstName) && !string.IsNullOrEmpty(MiddleInitial) && !string.IsNullOrEmpty(lastName))
                {
                    return $"{FirstName} {MiddleInitial}. {LastName}";
                }
                else if (!string.IsNullOrEmpty(firstName) && string.IsNullOrEmpty(MiddleInitial) && !string.IsNullOrEmpty(lastName))
                {
                    return $"{FirstName} {LastName}";
                }
                else if (!string.IsNullOrEmpty(firstName) && string.IsNullOrEmpty(MiddleInitial) && string.IsNullOrEmpty(lastName))
                {
                    return $"{FirstName}";
                }
                else return string.Empty;
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
        public new string? FirstName { get => firstName; set => firstName = value; }
        public string MiddleInitial { get => middleInitial ?? string.Empty; set => middleInitial = value; }
        public new string? LastName { get => lastName; set => lastName = value; }

        private string? fullName;
        private string? firstName;
        private string? middleInitial;
        private string? lastName;
    }
}

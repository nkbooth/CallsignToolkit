using CallsignToolkit.Utilities;

namespace CallsignToolkit.CallbookLookup.QRZ
{
    public class QRZName : Name
    {
        public string Nickname { get => nickname ?? string.Empty; set => nickname = value; }
        public override string FirstName 
        { 
            get
            {
                if(string.IsNullOrEmpty(firstName) && !string.IsNullOrEmpty(lastName))
                    return lastName;
                else 
                    return firstName ?? string.Empty;
            }
            set => firstName = value; }
        public override string LastName 
        { 
            get
            {
                if (string.IsNullOrEmpty(firstName) && !string.IsNullOrEmpty(lastName))
                    return string.Empty;
                else
                    return lastName;
            }
            set => lastName = value; }

        public override string FullName
        {
            get
            {
                if (!string.IsNullOrEmpty(fullName))
                {
                    return fullName;
                }
                else if (!string.IsNullOrEmpty(firstName) && string.IsNullOrEmpty(nickname) && string.IsNullOrEmpty(lastName))
                {
                    return firstName;
                }
                else if (!string.IsNullOrEmpty(firstName) && !string.IsNullOrEmpty(nickname) && !string.IsNullOrEmpty(lastName))
                {
                    return $"{firstName} \"{nickname}\" {lastName}";
                }
                else if (!string.IsNullOrEmpty(firstName) && !string.IsNullOrEmpty(nickname) && !string.IsNullOrEmpty(middleInitial) && !string.IsNullOrEmpty(lastName))
                {
                    return $"{firstName} {middleInitial} \"{nickname}\" {lastName}";
                }
                else if (!string.IsNullOrEmpty(firstName) && string.IsNullOrEmpty(nickname) && !string.IsNullOrEmpty(middleInitial) && !string.IsNullOrEmpty(lastName))
                {
                    return $"{firstName} {middleInitial} {lastName}";
                }
                else if (string.IsNullOrEmpty(firstName) && string.IsNullOrEmpty(nickname) && !string.IsNullOrEmpty(lastName))
                {
                    return $"{lastName}";
                }

                return string.Empty;
            }
        }

        private string? nickname;
    }
}

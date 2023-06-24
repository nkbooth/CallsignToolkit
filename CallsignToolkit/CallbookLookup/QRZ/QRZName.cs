using CallsignToolkit.Utilities;

namespace CallsignToolkit.CallbookLookup.QRZ
{
    public class QRZName : Name
    {
        public string Nickname { get => nickname ?? string.Empty; set => nickname = value; }
        public new string FirstName { get => firstName ?? string.Empty; set => firstName = value; }
        public new string LastName { get => lastName ?? string.Empty; set => lastName = value; }

        public new string FullName
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
                else if (!string.IsNullOrEmpty(firstName) && string.IsNullOrEmpty(nickname) && !string.IsNullOrEmpty(lastName))
                {
                    return $"{firstName} {lastName}";
                }
                else if (string.IsNullOrEmpty(firstName) && string.IsNullOrEmpty(nickname) && !string.IsNullOrEmpty(lastName))
                {
                    return $"{lastName}";
                }

                return string.Empty;
            }
        }

        private string? firstName;
        private string? lastName;
        private string? nickname;
        private string? fullName;
    }
}

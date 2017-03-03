namespace Group_Project.Classes
{
    /// <summary>
    /// A class to hold a username & password
    /// </summary>
    public class Password
    {
        /// <summary>
        /// The username
        /// </summary>
        public string Username;
        /// <summary>
        /// The password (password is a key word in SQL which caused an issue)
        /// </summary>
        public string PassCode;
        /// <summary>
        /// The access rights that this username holds
        /// </summary>
        public string AccessRights;
    }
}

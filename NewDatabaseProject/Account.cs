namespace NewDatabaseProject
{
    class Account
    {
        readonly string username;
        readonly string password;

        public Account(string _username, string _password)
        {
            username = _username;
            password = _password;
        }

        public string GetUsername()
        {
            return username;
        }

        public string GetPassword()
        {
            return password;
        }
    }
}

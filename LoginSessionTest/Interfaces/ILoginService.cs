﻿namespace LoginSessionTest.Interfaces
{
    public class ILoginService
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool IsLoggedIn { get; set; }
    }
}

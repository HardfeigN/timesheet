namespace time_sheet.Other_Classes
{
    public class UserPrivilegesControl
    {
        public UsersTypes UserType { get; private set; }
        private bool _initialize;

        public UserPrivilegesControl(UsersTypes type) 
        {
            if (!_initialize)
            {
                UserType = type;
                _initialize = true; 
            }
        }
    }
}

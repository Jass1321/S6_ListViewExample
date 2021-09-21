using System;
using System.Collections.Generic;
using System.Text;

namespace S6_ListViewExample
{
    class Item
    {
        public string Id
        {
            get;
            set;
        }
        public string UserName
        {
            get;
            set;
        }
        public DateTime RegisterDate
        {
            get;
            set;
        }
        public string Field
        {
            get;
            set;
        }
        public string Password
        {
            get;
            set;
        }
        public int Heats
        {
            get;
            set;
        }
        public string UserNameSort
        {
            get
            {
                if (string.IsNullOrWhiteSpace(UserName) || UserName.Length == 0)
                    return "?";

                return UserName[0].ToString().ToUpper();
            }
        }
        }
}

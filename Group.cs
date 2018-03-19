public class Group
    {
        private string group_name;
        private int year;
        
        public string Group_name
        {
            get
            {
                return group_name;
            }
            set
            {
                group_name = value;
            }
        }
        public int Year
        {
            get
            {
                return year;
            }
            set
            {
                year = value;
            }
        }



        public Group(string groupname, int year_enter)
        {
            group_name = groupname;
            year = year_enter;
        }
        
       
    }

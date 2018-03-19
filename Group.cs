public class Group
    {
        private string group_name;
        private int year;
        private EDU_plan edu_plan;
        
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



        public Group(string groupname, int year_enter,EDU_plan Edu_plan)
        {
            group_name = groupname;
            year = year_enter;
            edu_plan = Edu_plan;
        }
        
       
    }

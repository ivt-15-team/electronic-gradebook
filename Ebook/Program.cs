using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ebook
{
    static class Program
    {
        //static public List<EDU_plan> EDU_plans = new List<EDU_plan>();
        //static public List<Edu_Plan_Content> EDU_plan_Contents = new List<Edu_Plan_Content>();

        static public string login;
        static public string access;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {   
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Autorization());
            Application.Run(new Form1());
            //Application.Run(new Edu_plan_Form());
        }
    }
}

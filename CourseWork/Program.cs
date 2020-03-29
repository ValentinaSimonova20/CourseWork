using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWork
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
        }

        

        

    }
    static class Client1
    {
        public static int id { get; set; }
        public static string role { get; set; }
    }

    static class SelectedArea
    {
        public static int area_id { get; set; }
        public static int person_id { get; set; }
        public static string areaName { get; set; }
        public static int areaSpace { get; set; }
        public static int rooms { get; set; }
        public static int price { get; set; }
        public static string describe { get; set; }
        public static string dgvType { get; set; }
    }
}

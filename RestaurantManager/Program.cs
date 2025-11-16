using RestaurantManager.Forms;
using RestaurantManager.Models;

namespace RestaurantManager
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            UserList.InitUserListData();
            TableIDStorage.Load();
            TableList.InitTableListData();
          
            Application.Run(new SignInForm());
        }
    }
}
using RestaurantManager.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManager.Models
{
    public enum UserRole
    {
        Admin,
        Staff,
    }
    public class User
    {

        private string userID;
        private string userName;
        private string password;
        private UserRole role;


        public User(string userID, string userName, string password, UserRole role)
        {
            this.userID = userID;
            this.userName = userName;
            this.password = password;
            this.role = role;
        }


        public string UserID { get => userID; set => userID = value; }
        public string UserName { get => userName; set => userName = value; }
        public string Password { get => password; set => password = value; }
        public UserRole Role { get => role; set => role = value; }



        public override string ToString()
        {
            return $"UserID: {userID}, UserName: {userName}, Role: {role}";
        }


    }

    ///===================================================================================================///

    public static class UserList
    {
        public static List<User> Users { get; set; } = new List<User>();




        private static List<User> InitializeDefaultUsersList()
        {
            var defaultList = new List<User> { new User("ADM001", Constant.DEFAULT_ADMIN_USERNAME.ToString(), Constant.DEFAULT_PASSWORD.ToString(), UserRole.Admin) };
            FileUtils.SaveToJson(Constant.USER_DATA_FILE, defaultList);

            return defaultList;
        }


        public static bool InitUserListData()
        {
            try
            {
                if (!File.Exists(Constant.USER_DATA_FILE))
                {
                    // First run: create default user
                    Users = InitializeDefaultUsersList();
                    return true;
                }

                // Try to load existing file
                Users = FileUtils.LoadFromJson<List<User>>(Constant.USER_DATA_FILE);

                // Handle empty or invalid file
                if (Users == null || Users.Count == 0)
                {
                    Users = InitializeDefaultUsersList();
                    return true; // treated as first run or recovery
                }

                return false; // loaded successfully
            }
            catch (Exception ex)
            {
                // Corrupted file: show warning and recreate default list
                MessageBox.Show($"Failed to load user data: {ex.Message}\nA default admin user will be created.",
                                "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                Users = InitializeDefaultUsersList();
                return true;
            }
        }

        public static User GetUserByID(string userID)
        {
            foreach (var u in Users)
            {
                if (u.UserID == userID)
                {
                    return u;
                }
            }
            return null;
        }
        public static bool AddUser(User user)
        {
            try 
            {
                if (GetUserByID(user.UserID)==null)
                {
                    Users.Add(user);
                    FileUtils.SaveToJson(Constant.USER_DATA_FILE, Users);
                    return true;
                }
                else
                {
                    MessageBox.Show("User ID already exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
               
            }
            catch(Exception ex) 
            {
                MessageBox.Show($"Failed to add user: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            
        }
        public static bool RemoveUser(User user)
        {
            try
            {
                Users.Remove(user);
                FileUtils.SaveToJson(Constant.USER_DATA_FILE, Users);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to remove user: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            
        }
        public static bool UpdateUser(User user)
        {
            try
            {
                var u = GetUserByID(user.UserID);
                if (u != null)
                {
                    u.UserName = user.UserName;
                    u.Password = user.Password;
                    u.Role = user.Role;
                    FileUtils.SaveToJson(Constant.USER_DATA_FILE, Users);
                    return true;

                }
                else
                {
                    MessageBox.Show("User not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to update user: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }
        }
    }



}

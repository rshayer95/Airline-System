using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WPFApp
{
    class LoginHelper
    {
        public static DataTable loginTable = new DataTable("Users");
        public static Dictionary<string,dynamic> users = new Dictionary<string,dynamic>();
        public static bool isLoggedIn = false;
        public static bool isSuperUser = false;
        
        //Dictionary<login> = new Dictionary();
        public static void populateloginTable()
        {
            loginTable.Columns.Add("ID");
            loginTable.Columns.Add("Username");
            loginTable.Columns.Add("Password");
            loginTable.Columns.Add("SuperUser");

            DataRow row = loginTable.NewRow();
            //User 1
            row["ID"] = 1;
            row["Username"] = "deep_sandhu";
            row["Password"] = "kaur123";
            row["SuperUser"] = 1;
            loginTable.Rows.Add(row);

            DataRow row2 = loginTable.NewRow();
            //User 2
            row2["ID"] = 2;
            row2["Username"] = "tracy_241";
            row2["Password"] = "snow123";
            row2["SuperUser"] = 1;
            loginTable.Rows.Add(row2);

            //User 3
            DataRow row3 = loginTable.NewRow();
            row3["ID"] = 3;
            row3["Username"] = "greigJ";
            row3["Password"] = "J247";
            row3["SuperUser"] = 0;
            loginTable.Rows.Add(row3);

            //User 4
            DataRow row4 = loginTable.NewRow();
            row4["ID"] = 4;
            row4["Username"] = "teju_cs";
            row4["Password"] = "csteju123";
            row4["SuperUser"] = 0;
            loginTable.Rows.Add(row4);

            //User 5
            DataRow row5 = loginTable.NewRow();
            row5["ID"] = 5;
            row5["Username"] = "user_27";
            row5["Password"] = "user1234567";
            row5["SuperUser"] = 0;
            loginTable.Rows.Add(row5);
            for(int i =0; i< loginTable.Rows.Count; i++)
            {
                users.Add(loginTable.Rows[i]["Username"].ToString(), loginTable.Rows[i]);
                
            }


        }


    }
}

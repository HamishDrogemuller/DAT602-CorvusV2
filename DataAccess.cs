using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace CorvusV2
{
    public class DataAccess
    {

        private static String connectionString = "Server=localhost;Port=3306;Database=Corvus;Uid=Strix;password=Corvere300;";
        private MySqlConnection mySqlConnection = new MySqlConnection(connectionString);

        public String AddNewUser(String pUsername, String pPassword, String pEmail)
        {


            List<MySqlParameter> prmNewUser = new List<MySqlParameter>();

            MySqlParameter scUsername = new MySqlParameter("@Username", MySqlDbType.VarChar, 20);
            scUsername.Value = pUsername;
            prmNewUser.Add(scUsername);

            MySqlParameter scPassword = new MySqlParameter("@Password", MySqlDbType.VarChar, 50);
            scPassword.Value = pPassword;
            prmNewUser.Add(scPassword);

            MySqlParameter scEmail = new MySqlParameter("@Email", MySqlDbType.VarChar, 50);
            scEmail.Value = pEmail;
            prmNewUser.Add(scEmail);

            var aDataSet = MySqlHelper.ExecuteDataset(mySqlConnection, "Call AddNewUser(@UserName, @Password, @Email)", prmNewUser.ToArray());

            return aDataSet.Tables[0].Rows[0].Field<string>("Message");
        }

        public String Login(String pUsername, String pPassword)
        {
            List<MySqlParameter> prmLogin = new List<MySqlParameter>();

            MySqlParameter scUsername = new MySqlParameter("@Username", MySqlDbType.VarChar, 20);
            scUsername.Value = pUsername;
            prmLogin.Add(scUsername);

            MySqlParameter scPassword = new MySqlParameter("@Password", MySqlDbType.VarChar, 50);
            scPassword.Value = pPassword;
            prmLogin.Add(scPassword);

            var aDataSet = MySqlHelper.ExecuteDataset(mySqlConnection, "Call Login(@Username, @Password)", prmLogin.ToArray());

            return aDataSet.Tables[0].Rows[0].Field<String>("Message");
        }

        public String Logout(String pUsername)
        {
            List <MySqlParameter> prmLogout = new List<MySqlParameter>();

            MySqlParameter scUsername = new MySqlParameter("@Username", MySqlDbType.VarChar, 20);
            scUsername.Value = pUsername;
            prmLogout.Add(scUsername);

            var aDataSet = MySqlHelper.ExecuteDataset(mySqlConnection, "Call Logout(@Username)", prmLogout.ToArray());

            return aDataSet.Tables[0].Rows[0].Field<String>("Message");
        }

        public String deleteAccount(String pUsername)
        {
            List<MySqlParameter> prmDeleteAccount = new List<MySqlParameter>();

            MySqlParameter scUsername = new MySqlParameter("@Username", MySqlDbType.VarChar, 20);
            scUsername.Value = pUsername;
            prmDeleteAccount.Add(scUsername);

            var aDataSet = MySqlHelper.ExecuteDataset(mySqlConnection, "Call deleteAccount(@Username)", prmDeleteAccount.ToArray());

            return aDataSet.Tables[0].Rows[0].Field<String>("Message");

        }

        public String getActivePlayers()
        {
            List<MySqlParameter> prmActivePlayers = new List<MySqlParameter>();

            var aDataSet = MySqlHelper.ExecuteDataset(mySqlConnection, "Call getActivePlayers()", prmActivePlayers.ToArray());

            return aDataSet.Tables[0].Rows[0].Field<String>("Message");
        }

        public String PlayerMove(string pUsername, int pTileID)
        {
            List<MySqlParameter> prmPlayerMove = new List<MySqlParameter>();

            MySqlParameter scUsername = new MySqlParameter("@Username", MySqlDbType.VarChar, 20);
            scUsername.Value = pUsername;
            prmPlayerMove.Add(scUsername);

            MySqlParameter scTileID = new MySqlParameter("@TileID", MySqlDbType.Int32, 10);
            scTileID.Value = pTileID;
            prmPlayerMove.Add(scUsername);

            var aDataset = MySqlHelper.ExecuteDataset(mySqlConnection, "Call playerMove(@Username, @TileID)", prmPlayerMove.ToArray());

            return aDataset.Tables[0].Rows[0].Field<String>("Message");
        }

        public String updatePlayer(String pUsername, String pPassword, String pEmail)
        {
            List<MySqlParameter> prmUpdatePlayer = new List<MySqlParameter>();

            MySqlParameter scUsername = new MySqlParameter("@Username", MySqlDbType.VarChar, 20);
            scUsername.Value = pUsername;
            prmUpdatePlayer.Add(scUsername);

            MySqlParameter scPassword = new MySqlParameter("@Password", MySqlDbType.VarChar, 20);
            scPassword.Value = pPassword;
            prmUpdatePlayer.Add(scPassword);

            MySqlParameter scEmail = new MySqlParameter("@Email", MySqlDbType.VarChar, 20);
            scEmail.Value = pEmail;
            prmUpdatePlayer.Add(scEmail);

            var aDataSet = MySqlHelper.ExecuteDataset(mySqlConnection, "Call adminUpdateUser(@Username,@Password,@Email)", prmUpdatePlayer.ToArray());

            return aDataSet.Tables[0].Rows[0].Field<String>("Message");
        }

        public string generateBoard()
        {
            List<MySqlParameter> prmGenerateBoard = new List<MySqlParameter>();

            var aDataSet = MySqlHelper.ExecuteDataset(mySqlConnection, "Call generateBoard()", prmGenerateBoard.ToArray());

            return aDataSet.Tables[0].Rows[0].Field<String>("Message");
        }

        public string joinGame(String pUsername)
        {
            List<MySqlParameter> prmJoinGame = new List<MySqlParameter>();

            MySqlParameter scUsername = new MySqlParameter("@Username", MySqlDbType.VarChar, 20);
            scUsername.Value = pUsername;
            prmJoinGame.Add(scUsername);

            var aDataSet = MySqlHelper.ExecuteDataset(mySqlConnection, "Call adminUpdateUser(@Username)", prmJoinGame.ToArray());

            return aDataSet.Tables[0].Rows[0].Field<String>("Message");
        }

        public string chat(String pUsername, String pMessage)
        {
            List<MySqlParameter> prmChat = new List<MySqlParameter>();

            MySqlParameter scUsername = new MySqlParameter("@Username", MySqlDbType.VarChar, 20);
            scUsername.Value = pUsername;
            prmChat.Add(scUsername);

            MySqlParameter scMessage = new MySqlParameter("@Username", MySqlDbType.VarChar, 255);
            scMessage.Value = pMessage;
            prmChat.Add(scMessage);

            var aDataSet = MySqlHelper.ExecuteDataset(mySqlConnection, "Call adminUpdateUser(@Username)", prmChat.ToArray());

            return aDataSet.Tables[0].Rows[0].Field<String>("Message");
        }

        public string gameEnd()
        {
            List<MySqlParameter> prmGameEnd = new List<MySqlParameter>();

            var aDataSet = MySqlHelper.ExecuteDataset(mySqlConnection, "Call gaemEnd()", prmGameEnd.ToArray());

            return aDataSet.Tables[0].Rows[0].Field<String>("Message");
        }



    }
}

   



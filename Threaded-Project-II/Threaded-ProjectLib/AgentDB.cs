using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThreadedProjectLib;

namespace Threaded_ProjectLib
{
    /* Agent Data Access class to verify agent data and generate hashsalt password
     * Author: Jeremiah Lobo
     * Created Date: Jan 2019
     */
    public class AgentDB : BaseDB
    {
        
        public bool AgentLogin(Agent agent)
        {
            //Check username 
            if (CheckAgentEmail(agent))
            {

                //Console.WriteLine(VerifyPassword(agent.AgentPassword, hashsalt.Hash, hashsalt.Salt));
                string hashedPassword = GetHashPasswordByAgentId(agent).HashedPassword.ToString();
                if (VerifyPassword(agent.AgentPassword, hashedPassword ))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        //BCrypt Password
        //is currently recommend by the IETF (Internet Engineering Task Force) for new applications.
        public static void GenerateSaltedHash(string submittedPassword)
        {
            // hash and save a password
            var hashedPassword = BCrypt.Net.BCrypt.HashPassword(submittedPassword);
            //Send to DB
            Console.WriteLine(hashedPassword);
        }

        private bool VerifyPassword(string submittedPassword, string hashedPassword)
        {

            // check a password
            bool validPassword = BCrypt.Net.BCrypt.Verify(submittedPassword, hashedPassword);
            return validPassword;
        }

        private bool CheckAgentEmail( Agent agent)
        {

            using (SqlConnection connection = GetConnection())
            {
                try
                {
                    //open the connection
                    connection.Open();
                    SqlCommand checkEmail = new SqlCommand("SELECT COUNT(*) FROM Agents WHERE Agents.AgtEmail = @email", connection);
                    checkEmail.Parameters.AddWithValue("@email", agent.AgtEmail);
                    int UserExist = (int)checkEmail.ExecuteScalar();
                    if (UserExist > 0)
                    {
                        SqlCommand command = new SqlCommand("SELECT AgentId FROM Agents WHERE Agents.AgtEmail = @email", connection);
                        command.Parameters.AddWithValue("@email", agent.AgtEmail);

                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            //Set Agent ID
                            agent.AgentId = Convert.ToInt32(reader["AgentId"]);
                        }
                        return true;
                    }
                    else
                    {
                        //Username doesn't exist.
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    //Utils.WriteErrorLog("Login failed Type: " + ex.GetType() + "  Message: " + ex.Message);
                    Utils.ErrorManager(ex, "Agents", "AgentDB.CheckAgentEmail()");
                    return false;
                }
            }
        }

        private Agent GetHashPasswordByAgentId( Agent agent )
        {
            using (SqlConnection connection = GetConnection())
            {
                //SqlCommand AgentHashSalt = new SqlCommand("SELECT Hash, Salt FROM HashSalt WHERE AgentID = @agentId", connection);
                SqlCommand AgentHashSalt = new SqlCommand("SELECT HashedPassword FROM Agents WHERE AgentID = @agentId", connection);
                AgentHashSalt.Parameters.AddWithValue("@agentId", agent.AgentId);
               
                //open the connection

                connection.Open();
                SqlDataReader reader = AgentHashSalt.ExecuteReader();
                try
                {
                    while (reader.Read())
                    {
                        agent.HashedPassword = reader["HashedPassword"].ToString();
                    }

                    return agent;
                }
                catch(Exception ex)
                {
                    Utils.ErrorManager(ex, "Agents", "AgentDB.GetHashPasswordByAgentId()");
                }
                finally
                {
                    // Always call Close when done reading.
                    reader.Close();
                }
            }

            return agent;
        }
    }
}

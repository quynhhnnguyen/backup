using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Threaded_ProjectLib
{
    /* Agent Object
     * Author: Jeremiah Lobo
     * Created Date: Jan 2019
     */
    public class Agent
    {
        private string agentPassword;

        private int agentId;
        //Commented out property we may or may not use
       // private string AgtFirstName;

        //private string AgtMiddleInitial;

       //private string AgtLastName;

        //private string AgtBusPhone;

        public string AgtEmail;

        //private string AgtPosition;

        private int AgencyId;

        public string HashedPassword;

        public Agent( string AgtEmail = "", string AgentPassword = "")
        {
            this.AgtEmail = AgtEmail; 
            this.AgentPassword = AgentPassword;
        }

        public Agent(string AgtEmail = "")
        {
            this.AgencyId = AgentId;
        }

        public string AgentPassword
        {

            set {this.agentPassword = value; }
            get { return this.agentPassword; }

        }
        

        public int AgentId
        {
            set { this.agentId = value; }
            get { return this.agentId;  }
        }
    }
}

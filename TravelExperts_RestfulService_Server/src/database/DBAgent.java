package database;
/**
 * Agent Data Access class
 * 
 * @author Quynh Nguyen (Queenie) 
 * Created: 04/15/2019
 */
import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;
import java.util.List;
import java.util.logging.Level;
import java.util.logging.Logger;

import org.mindrot.jbcrypt.BCrypt;

import model.Agent;
import utilities.Utils;

public class DBAgent {

	private static final Logger LOGGER = Logger.getLogger(DBAgent.class.getName());
	
	public DBAgent() {
		// TODO Auto-generated constructor stub
	}

	/*
	 * get all Agents
	 */
	public static List<Agent> getAgents() {

		List<Agent> agents = new ArrayList<Agent>();

		String sql = "SELECT * FROM Agents";

		try {
			Connection conn = DBConnection.getConnection();
			PreparedStatement stmt = conn.prepareStatement(sql);

			ResultSet rs = stmt.executeQuery();

			// loop through the result set
			while (rs.next()) {
				Agent ele = new Agent();
				ele.setAgentId(rs.getInt("AgentId"));
				ele.setAgtFirstName(rs.getString("AgtFirstName"));
				ele.setAgtLastName(rs.getString("AgtLastName"));
				ele.setAgtMiddleInitial(rs.getString("AgtMiddleInitial")==null
						?"":rs.getString("AgtMiddleInitial"));
				ele.setAgtBusPhone(rs.getString("AgtBusPhone"));
				ele.setAgtEmail(rs.getString("AgtEmail"));
				ele.setAgtPosition(rs.getString("AgtPosition"));
				ele.setAgencyId(rs.getInt("AgencyId"));
				ele.setUserName(rs.getString("UserName"));
				ele.setPassword(rs.getString("Password"));
				
				agents.add(ele);
			}
		} catch (SQLException e) {
			LOGGER.log(Level.SEVERE, "DBAgent.getAgents: " + e.getMessage());
		} finally {
			DBConnection.closeConnection();
		}

		return agents;
	}

	/*
	 * get Agent by AgentId
	 */
	public static Agent getAgent(int agentId) {

		Agent ele = new Agent();

		String sql = "SELECT * FROM Agents WHERE AgentId=?";

		try {
			Connection conn = DBConnection.getConnection();
			PreparedStatement stmt = conn.prepareStatement(sql);
			stmt.setInt(1, agentId);

			ResultSet rs = stmt.executeQuery();

			// loop through the result set
			if (rs.next()) {

				ele.setAgentId(rs.getInt("AgentId"));
				ele.setAgtFirstName(rs.getString("AgtFirstName"));
				ele.setAgtLastName(rs.getString("AgtLastName"));
				ele.setAgtMiddleInitial(rs.getString("AgtMiddleInitial")==null
						?"":rs.getString("AgtMiddleInitial"));
				ele.setAgtBusPhone(rs.getString("AgtBusPhone"));
				ele.setAgtEmail(rs.getString("AgtEmail"));
				ele.setAgtPosition(rs.getString("AgtPosition"));
				ele.setAgencyId(rs.getInt("AgencyId"));
				ele.setUserName(rs.getString("UserName"));
				ele.setPassword(rs.getString("Password"));
			}
		} catch (SQLException e) {
			LOGGER.log(Level.SEVERE, "DBAgent.getAgent: " + e.getMessage());
		} finally {
			DBConnection.closeConnection();
		}

		return ele;
	}
	
	/*
	 * add Agent
	 */
	public static boolean addAgent(Agent agent) {

		boolean result = false;

		String sql = "INSERT INTO Customers (AgtFirstName, AgtMiddleInitial, " + 
				" AgtLastName, AgtBusPhone, AgtEmail, AgtPosition, AgencyId, " + 
				" UserName, Password)\r\n" + 
				" VALUES ( ?, ?, ?, ?, ?, ?, ?, ?, ?)\r\n";    

		try {
			Connection conn = DBConnection.getConnection();
			PreparedStatement stmt = conn.prepareStatement(sql);

			stmt.setString(1, agent.getAgtFirstName());
			stmt.setString(2, agent.getAgtMiddleInitial());
			stmt.setString(3, agent.getAgtLastName());
			stmt.setString(4, agent.getAgtBusPhone());
			stmt.setString(5, agent.getAgtEmail());
			stmt.setString(6, agent.getAgtPosition());
	
			stmt.setInt(7, agent.getAgencyId());
			stmt.setString(8, agent.getUserName());
			stmt.setString(9, Utils.hashString(agent.getPassword()));

			result = stmt.execute();
			
		} catch (SQLException e) {
			LOGGER.log(Level.SEVERE, "DBAgent.addAgent: " + e.getMessage());
		} finally {
			DBConnection.closeConnection();
		}

		return result;
	}

	/*
	 * update Agent
	 */
	public static boolean updateAgent(Agent agent) {

		boolean result = false;

		String sql = "UPDATE Agents SET AgtFirstName = ?, AgtMiddleInitial = ?, "
				+ "AgtLastName = ?, AgtBusPhone = ?, AgtEmail = ?, "
				+ "AgtPosition = ?, AgencyId = ? WHERE AgentId = ?";

		try {
			Connection conn = DBConnection.getConnection();
			PreparedStatement stmt = conn.prepareStatement(sql);

			stmt.setString(1, agent.getAgtFirstName());
			stmt.setString(2, agent.getAgtMiddleInitial());
			stmt.setString(3, agent.getAgtLastName());
			stmt.setString(4, agent.getAgtBusPhone());
			stmt.setString(5, agent.getAgtEmail());
			stmt.setString(6, agent.getAgtPosition());
			stmt.setInt(7, agent.getAgencyId());
			stmt.setInt(8, agent.getAgentId());
			//stmt.setString(9, agent.getUserName());
			//stmt.setString(10, agent.getPassword());

			result = stmt.executeUpdate()==1;
		} catch (SQLException e) {
			LOGGER.log(Level.SEVERE, "DBAgent.updateAgent: " + e.getMessage());
		} finally {
			DBConnection.closeConnection();
		}

		return result;
	}

	/*
	 * delete Agent by agencyId
	 */
	public static boolean deleteAgent(int agentId) {

		boolean result = true;

		Connection conn = DBConnection.getConnection();

		String sql = "DELETE FROM Agents WHERE AgencyId = ?";

		PreparedStatement stmt = null;

		try {
			conn.setAutoCommit(false);

			stmt = conn.prepareStatement(sql);

			stmt.setInt(1, agentId);

			result = stmt.execute();
			conn.commit();

		} catch (SQLException e) {
			LOGGER.log(Level.SEVERE, "DBAgent.deleteAgent: " + e.getMessage());
			try {
				conn.rollback();
			} catch (SQLException e1) {
				LOGGER.log(Level.SEVERE, "DBAgent.deleteAgent: " + e.getMessage());
			}

		} finally {
			try {
				conn.setAutoCommit(true);
				stmt.close();
			} catch (SQLException e) {
				LOGGER.log(Level.SEVERE, "DBAgent.deleteAgent: " + e.getMessage());
			}
			DBConnection.closeConnection();
		}

		return result;
	}
	
	/*
	 * authenticate Agent username and password
	 */
	public static boolean agentAuthenticate(String username, String password) throws SQLException {

		boolean matched = false;
		
		Agent ele = new Agent();

		String sql = "SELECT * FROM Agents WHERE UserName=?";

		try {
			Connection conn = DBConnection.getConnection();
			PreparedStatement stmt = conn.prepareStatement(sql);
			stmt.setString(1, username);

			ResultSet rs = stmt.executeQuery();

			// loop through the result set
			if (rs.next()) {

				ele.setPassword(rs.getString("Password"));

			}
			
	        matched = BCrypt.checkpw(password, ele.getPassword());
	        
		} catch (SQLException e) {
			LOGGER.log(Level.SEVERE, "DBAgent.agentAuthenticate: " + e.getMessage());
			throw e;
		} finally {
			DBConnection.closeConnection();
		}

		return matched;
	}

}

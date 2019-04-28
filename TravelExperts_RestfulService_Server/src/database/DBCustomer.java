package database;
/**
 * Customer Data Access class
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

import model.Customer;
import utilities.Utils;

public class DBCustomer {

	private static final Logger LOGGER = Logger.getLogger(DBCustomer.class.getName());

	/*
	 * authenticate Customer username and password
	 */
	public static boolean customerAuthenticate(String username, String password) throws SQLException {

		boolean matched = false;

		Customer ele = new Customer();

		String sql = "SELECT * FROM Customers WHERE UserName=?";

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
			LOGGER.log(Level.SEVERE, "DBCustomer.customerAuthenticate: " + e.getMessage());
			throw e;
		} finally {
			DBConnection.closeConnection();
		}

		return matched;
	}
	
	/*
	 * get all Customers
	 */
	public static List<Customer> getCustomers() {

		List<Customer> customers = new ArrayList<Customer>();

		String sql = "SELECT * FROM Customers";

		try {
			Connection conn = DBConnection.getConnection();
			PreparedStatement stmt = conn.prepareStatement(sql);

			ResultSet rs = stmt.executeQuery();

			// loop through the result set
			while (rs.next()) {
				Customer ele = new Customer();
				ele.setCustomerId(rs.getInt("CustomerId"));
				ele.setCustFirstName(rs.getString("CustFirstName"));				
				ele.setCustLastName(rs.getString("CustLastName"));
				
				ele.setCustAddress(rs.getString("CustAddress"));
				ele.setCustCity(rs.getString("CustCity"));
				ele.setCustProv(rs.getString("CustProv"));
				ele.setCustPostal(rs.getString("CustPostal"));
				ele.setCustCountry(rs.getString("CustCountry"));
				ele.setCustHomePhone(rs.getString("CustHomePhone"));
				ele.setCustBusPhone(rs.getString("CustBusPhone"));
				ele.setCustEmail(rs.getString("CustEmail"));
				
				ele.setAgentId(rs.getInt("AgentId"));
				ele.setUserName(rs.getString("UserName"));
				ele.setPassword(rs.getString("Password"));
		
				customers.add(ele);
			}
		} catch (SQLException e) {
			LOGGER.log(Level.SEVERE, "DBCustomer.getCustomers: " + e.getMessage());
		} finally {
			DBConnection.closeConnection();
		}

		return customers;
	}
	
	/*
	 * get all Customers
	 */
	public static Customer getCustomer(int customerId) {

		Customer ele = new Customer();

		String sql = "SELECT * FROM Customers WHERE CustomerId = ?";

		try {
			Connection conn = DBConnection.getConnection();
			PreparedStatement stmt = conn.prepareStatement(sql);
			stmt.setInt(1, customerId);

			ResultSet rs = stmt.executeQuery();

			// loop through the result set
			if (rs.next()) {
				
				ele.setCustomerId(rs.getInt("CustomerId"));
				ele.setCustFirstName(rs.getString("CustFirstName"));				
				ele.setCustLastName(rs.getString("CustLastName"));
				
				ele.setCustAddress(rs.getString("CustAddress"));
				ele.setCustCity(rs.getString("CustCity"));
				ele.setCustProv(rs.getString("CustProv"));
				ele.setCustPostal(rs.getString("CustPostal"));
				ele.setCustCountry(rs.getString("CustCountry"));
				ele.setCustHomePhone(rs.getString("CustHomePhone"));
				ele.setCustBusPhone(rs.getString("CustBusPhone"));
				ele.setCustEmail(rs.getString("CustEmail"));
				
				ele.setAgentId(rs.getInt("AgentId"));
				ele.setUserName(rs.getString("UserName"));
				ele.setPassword(rs.getString("Password"));		
			}
			
		} catch (SQLException e) {
			LOGGER.log(Level.SEVERE, "DBCustomer.getCustomers: " + e.getMessage());
		} finally {
			DBConnection.closeConnection();
		}

		return ele;
	}
		
	/*
	 * add Customer
	 */
	public static boolean addCustomer(Customer customer) {

		boolean result = false;

		String sql = "INSERT INTO Customers (CustFirstName, CustLastName, " + 
				" CustAddress, CustCity, CustProv, CustPostal, CustCountry, " + 
				" CustHomePhone, CustBusPhone, CustEmail, AgentId, UserName, " + 
				" Password)\r\n" + 
				" VALUES ( ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)\r\n";

		try {
			Connection conn = DBConnection.getConnection();
			PreparedStatement stmt = conn.prepareStatement(sql);

			stmt.setString(1, customer.getCustFirstName());
			stmt.setString(2, customer.getCustLastName());
			stmt.setString(3, customer.getCustAddress());
			stmt.setString(4, customer.getCustCity());
			stmt.setString(5, customer.getCustProv());
			stmt.setString(6, customer.getCustPostal());

			stmt.setString(7, customer.getCustCountry());
			stmt.setString(8, customer.getCustHomePhone());
			stmt.setString(9, customer.getCustBusPhone());
			stmt.setString(10, customer.getCustEmail());
			
			stmt.setInt(11, customer.getAgentId());
			stmt.setString(12, customer.getUserName());
			stmt.setString(13, Utils.hashString(customer.getPassword()));

			result = stmt.execute();
			
		} catch (SQLException e) {
			LOGGER.log(Level.SEVERE, "DBCustomer.addCustomer: " + e.getMessage());
		} finally {
			DBConnection.closeConnection();
		}

		return result;
	}

}

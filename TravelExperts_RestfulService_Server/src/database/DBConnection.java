package database;

/** 
 * Database Connection Class 
 * Author: Quynh Nguyen (Queenie)
 * Date: 04/08/2019
 **/
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.SQLException;
import java.util.logging.Level;
import java.util.logging.Logger;

public class DBConnection {

	private static final Logger LOGGER = Logger.getLogger(DBConnection.class.getName());
	
	private static Connection conn = null;
	
	public DBConnection() {
		// TODO Auto-generated constructor stub
	}

	// get resource path
	private String getResourcePath() {
		StringBuilder sb = new StringBuilder();
		sb.append("jdbc:sqlite:");
		sb.append(DBConnection.class.getClassLoader().getResource("/database/"));
		sb.append("TravelExpertsSqlLite.db");
		return sb.toString();
	}

	/**
	 * Connect to the TravelExpertsSqlLite.db database
	 * 
	 * @return the Connection object
	 */
	public static Connection getConnection() {

		
		try {
			if(conn == null) {
				Class.forName("org.sqlite.JDBC");
				conn = DriverManager.getConnection((new DBConnection()).getResourcePath());
			}			
		} catch (SQLException | ClassNotFoundException e) {
			LOGGER.log(Level.SEVERE, "DBConnection.getConnection(): " + e.getMessage());
		}
		return conn;
	}
	
	public static void closeConnection() {
		if(conn != null) {
			try {
				conn.close();
				conn = null;
			} catch (SQLException e) {
				// TODO Auto-generated catch block
				LOGGER.log(Level.SEVERE, "DBConnection.closeConnection(): " + e.getMessage());
			}
		}
	}

}

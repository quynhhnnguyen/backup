package database;

/**
 * Agency Data Access class
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

import model.Agency;

public class DBAgency {

	private static final Logger LOGGER = Logger.getLogger(DBAgency.class.getName());

	public DBAgency() {
		// TODO Auto-generated constructor stub
	}

	/*
	 * get all Agencies
	 */
	public static List<Agency> getAgencies() {

		List<Agency> agencies = new ArrayList<Agency>();

		String sql = "SELECT * FROM Agencies ";

		try {
			Connection conn = DBConnection.getConnection();
			PreparedStatement stmt = conn.prepareStatement(sql);

			ResultSet rs = stmt.executeQuery();

			// loop through the result set
			while (rs.next()) {
				Agency ele = new Agency();
				ele.setAgencyId(rs.getInt("AgencyId"));
				ele.setAgncyAddress(rs.getString("AgncyAddress"));
				ele.setAgncyCity(rs.getString("AgncyCity"));
				ele.setAgncyProv(rs.getString("AgncyProv"));
				ele.setAgncyPostal(rs.getString("AgncyPostal"));
				ele.setAgncyCountry(rs.getString("AgncyCountry"));
				ele.setAgncyPhone(rs.getString("AgncyPhone"));
				ele.setAgncyFax(rs.getString("AgncyFax"));
				agencies.add(ele);
			}
		} catch (SQLException e) {
			LOGGER.log(Level.SEVERE, "DBAgency.getAgencies: " + e.getMessage());
		} finally {
			DBConnection.closeConnection();
		}

		return agencies;
	}

	/*
	 * get Agency by AgencyId
	 */
	public static Agency getAgency(int agencyId) {

		Agency ele = new Agency();

		String sql = "SELECT * FROM Agencies WHERE AgencyId=?";

		try {
			Connection conn = DBConnection.getConnection();
			PreparedStatement stmt = conn.prepareStatement(sql);
			stmt.setInt(1, agencyId);

			ResultSet rs = stmt.executeQuery();

			// loop through the result set
			while (rs.next()) {

				ele.setAgencyId(rs.getInt("AgencyId"));
				ele.setAgncyAddress(rs.getString("AgncyAddress"));
				ele.setAgncyCity(rs.getString("AgncyCity"));
				ele.setAgncyProv(rs.getString("AgncyProv"));
				ele.setAgncyPostal(rs.getString("AgncyPostal"));
				ele.setAgncyCountry(rs.getString("AgncyCountry"));
				ele.setAgncyPhone(rs.getString("AgncyPhone"));
				ele.setAgncyFax(rs.getString("AgncyFax"));
			}
		} catch (SQLException e) {
			LOGGER.log(Level.SEVERE, "DBAgency.getAgency: " + e.getMessage());
		} finally {
			DBConnection.closeConnection();
		}

		return ele;
	}

	/*
	 * update Agency
	 */
	public static boolean updateAgency(Agency agency) {

		boolean result = true;

		String sql = "UPDATE Agencies SET AgncyAddress = ?, AgncyCity = ?,"
				+ " AgncyProv = ?, AgncyPostal = ?, AgncyCountry = ?, "
				+ "AgncyPhone = ?, AgncyFax = ? WHERE AgencyId = ?";

		try {
			Connection conn = DBConnection.getConnection();
			PreparedStatement stmt = conn.prepareStatement(sql);

			stmt.setString(1, agency.getAgncyAddress());
			stmt.setString(2, agency.getAgncyCity());
			stmt.setString(3, agency.getAgncyProv());
			stmt.setString(4, agency.getAgncyPostal());
			stmt.setString(5, agency.getAgncyCountry());
			stmt.setString(6, agency.getAgncyPhone());
			stmt.setString(7, agency.getAgncyFax());
			stmt.setInt(8, agency.getAgencyId());

			result = stmt.executeUpdate() == 1;
		} catch (SQLException e) {
			LOGGER.log(Level.SEVERE, "DBAgency.updateAgency: " + e.getMessage());
		} finally {
			DBConnection.closeConnection();
		}

		return result;
	}

	/*
	 * delete Agency by agencyId
	 */
	public static boolean deleteAgency(int agencyId) {

		boolean result = true;

		Connection conn = DBConnection.getConnection();

		String sql = "DELETE FROM Agencies WHERE AgencyId = ?";

		PreparedStatement stmt = null;

		try {
			conn.setAutoCommit(false);

			stmt = conn.prepareStatement(sql);

			stmt.setInt(1, agencyId);

			result = stmt.execute();
			conn.commit();

		} catch (SQLException e) {
			LOGGER.log(Level.SEVERE, "DBAgency.deleteAgency: " + e.getMessage());
			try {
				conn.rollback();
			} catch (SQLException e1) {
				LOGGER.log(Level.SEVERE, "DBAgency.deleteAgency: " + e.getMessage());
			}

		} finally {
			try {
				conn.setAutoCommit(true);
				stmt.close();
			} catch (SQLException e) {
				LOGGER.log(Level.SEVERE, "DBAgency.deleteAgency: " + e.getMessage());
			}
			DBConnection.closeConnection();
		}

		return result;
	}

}

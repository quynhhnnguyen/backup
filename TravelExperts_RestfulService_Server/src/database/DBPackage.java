package database;
/**
 * Package Data Access class
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

import model.Booking;
import model.Package;

public class DBPackage {

	private static final Logger LOGGER = Logger.getLogger(DBPackage.class.getName());
	
	public DBPackage() {
		// TODO Auto-generated constructor stub
	}

	/*
	 * get all Packages
	 */
	public static List<Package> getPackages() {

		List<Package> packages = new ArrayList<Package>();

		String sql = "SELECT * FROM Packages";

		try {
			Connection conn = DBConnection.getConnection();
			PreparedStatement stmt = conn.prepareStatement(sql);

			ResultSet rs = stmt.executeQuery();

			// loop through the result set
			while (rs.next()) {
				Package ele = new Package();
				ele.setPackageId(rs.getInt("PackageId"));
				ele.setPkgName(rs.getString("PkgName"));
				ele.setPkgStartDate(rs.getDate("PkgStartDate"));
				ele.setPkgEndDate(rs.getDate("PkgEndDate"));
				ele.setPkgDesc(rs.getString("PkgDesc"));
				ele.setPkgBasePrice(rs.getBigDecimal("PkgBasePrice"));
				ele.setPkgAgencyCommission(rs.getBigDecimal("PkgAgencyCommission"));
				packages.add(ele);
			}
		} catch (SQLException e) {
			packages = null;
			LOGGER.log(Level.SEVERE, "DBPackage.getPackages: " + e.getMessage());
		} finally {
			DBConnection.closeConnection();
		}

		return packages;

	}

	/*
	 * get Package by packageId
	 */
	public static Package getPackage(int packageId) {

		Package ele = new Package();

		String sql = "SELECT * FROM Packages WHERE PackageId=?";

		try {
			Connection conn = DBConnection.getConnection();
			PreparedStatement stmt = conn.prepareStatement(sql);
			stmt.setInt(1, packageId);

			ResultSet rs = stmt.executeQuery();

			// loop through the result set
			if (rs.next()) {
				ele.setPackageId(rs.getInt("PackageId"));
				ele.setPkgName(rs.getString("PkgName"));
				ele.setPkgStartDate(rs.getDate("PkgStartDate"));
				ele.setPkgEndDate(rs.getDate("PkgEndDate"));
				ele.setPkgDesc(rs.getString("PkgDesc"));
				ele.setPkgBasePrice(rs.getBigDecimal("PkgBasePrice"));
				ele.setPkgAgencyCommission(rs.getBigDecimal("PkgAgencyCommission"));
			}
		} catch (SQLException e) {
			ele = null;
			LOGGER.log(Level.SEVERE, "DBPackage.getPackage: " + e.getMessage());
		} finally {
			DBConnection.closeConnection();
		}

		return ele;
	}

	/*
	 * update Package
	 */
	public static boolean updatePackage(Package pack) {

		boolean result = true;

		String sql = "UPDATE Packages SET PkgName = ?, PkgStartDate = ?, "
				+ "PkgEndDate = ?, PkgDesc = ?, PkgBasePrice = ?, "
				+ "PkgAgencyCommission = ? WHERE PackageId = ?";

		try {
			Connection conn = DBConnection.getConnection();
			PreparedStatement stmt = conn.prepareStatement(sql);

			stmt.setString(1, pack.getPkgName());
			stmt.setString(2, pack.getPkgStartDate().toString());
			stmt.setString(3, pack.getPkgEndDate().toString());
			stmt.setString(4, pack.getPkgDesc());
			stmt.setBigDecimal(5, pack.getPkgBasePrice());
			stmt.setBigDecimal(6, pack.getPkgAgencyCommission());
			stmt.setInt(7, pack.getPackageId());

			result = stmt.executeUpdate() == 1;
		} catch (SQLException e) {
			LOGGER.log(Level.SEVERE, "DBPackage.updatePackage: " + e.getMessage());
		} finally {
			DBConnection.closeConnection();
		}

		return result;
	}

	/*
	 * delete Package by packageId
	 */
	public static boolean deletePackage(int packageId) {

		boolean result = true;

		Connection conn = DBConnection.getConnection();

		String sql = "DELETE FROM Packages WHERE PackageId = ?";

		PreparedStatement stmt = null;

		try {
			conn.setAutoCommit(false);

			stmt = conn.prepareStatement(sql);

			stmt.setInt(1, packageId);

			result = stmt.execute();
			conn.commit();

		} catch (SQLException e) {
			LOGGER.log(Level.SEVERE, "DBPackage.deletePackage: " + e.getMessage());
			try {
				conn.rollback();
			} catch (SQLException e1) {
				LOGGER.log(Level.SEVERE, "DBPackage.deletePackage: " + e.getMessage());
			}

		} finally {
			try {
				conn.setAutoCommit(true);
				stmt.close();
			} catch (SQLException e) {
				LOGGER.log(Level.SEVERE, "DBPackage.deletePackage: " + e.getMessage());
			}
			DBConnection.closeConnection();
		}

		return result;
	}

	/*
	 * book Package
	 */
	public static boolean bookPackage(Booking booking) {

		boolean result = true;

		String sql = "";

		try {
			Connection conn = DBConnection.getConnection();
			PreparedStatement stmt = conn.prepareStatement(sql);



			result = stmt.executeUpdate() == 1;
		} catch (SQLException e) {
			LOGGER.log(Level.SEVERE, "DBPackage.bookPackage: " + e.getMessage());
		} finally {
			DBConnection.closeConnection();
		}

		return result;
	}
}

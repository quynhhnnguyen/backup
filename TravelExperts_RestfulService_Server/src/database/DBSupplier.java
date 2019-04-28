package database;
/**
 * Supplier Data Access class
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

import model.Supplier;

public class DBSupplier {

	private static final Logger LOGGER = Logger.getLogger(DBSupplier.class.getName());
	
	public DBSupplier() {
		// TODO Auto-generated constructor stub
	}

	/*
	 * get all Suppliers
	 */
	public static List<Supplier> getSuppliers() {

		List<Supplier> suppliers = new ArrayList<Supplier>();

		String sql = "SELECT * FROM Suppliers";

		try {
			Connection conn = DBConnection.getConnection();
			PreparedStatement stmt = conn.prepareStatement(sql);

			ResultSet rs = stmt.executeQuery();

			// loop through the result set
			while (rs.next()) {
				Supplier ele = new Supplier();
				ele.setSupplierId(rs.getInt("SupplierId"));
				ele.setSupName(rs.getString("SupName"));
				suppliers.add(ele);
			}
		} catch (SQLException e) {
			LOGGER.log(Level.SEVERE, "DBSupplier.getSuppliers: " + e.getMessage());
		} finally {
			DBConnection.closeConnection();
		}

		return suppliers;
	}

	/*
	 * get Product by productId
	 */
	public static Supplier getSupplier(int supplierId) {

		Supplier ele = new Supplier();

		String sql = "SELECT * FROM Suppliers WHERE SupplierId=?";

		try {
			Connection conn = DBConnection.getConnection();
			PreparedStatement stmt = conn.prepareStatement(sql);
			stmt.setInt(1, supplierId);

			ResultSet rs = stmt.executeQuery();

			// loop through the result set
			if (rs.next()) {
				ele.setSupplierId(rs.getInt("SupplierId"));
				ele.setSupName(rs.getString("SupName"));
			}
		} catch (SQLException e) {
			LOGGER.log(Level.SEVERE, "DBSupplier.getSupplier: " + e.getMessage());
		} finally {
			DBConnection.closeConnection();
		}

		return ele;
	}

	/*
	 * update Product
	 */
	public static boolean updateSupplier(Supplier supplier) {

		boolean result = true;

		String sql = "UPDATE Suppliers SET SupName = ? WHERE SupplierId = ?";

		try {
			Connection conn = DBConnection.getConnection();
			PreparedStatement stmt = conn.prepareStatement(sql);

			stmt.setString(1, supplier.getSupName());
			stmt.setInt(2, supplier.getSupplierId());

			result = stmt.executeUpdate() == 1;
		} catch (SQLException e) {
			LOGGER.log(Level.SEVERE, "DBSupplier.updateSupplier: " + e.getMessage());
		} finally {
			DBConnection.closeConnection();
		}

		return result;
	}

	/*
	 * delete Supplier by supplierId
	 */
	public static boolean deleteSupplier(int supplierId) {

		boolean result = true;

		Connection conn = DBConnection.getConnection();

		String sql = "DELETE FROM Suppliers WHERE SupplierId = ?";

		PreparedStatement stmt = null;

		try {
			conn.setAutoCommit(false);

			stmt = conn.prepareStatement(sql);

			stmt.setInt(1, supplierId);

			result = stmt.execute();
			conn.commit();

		} catch (SQLException e) {
			LOGGER.log(Level.SEVERE, "DBSupplier.deleteSupplier: " + e.getMessage());
			try {
				conn.rollback();
			} catch (SQLException e1) {
				LOGGER.log(Level.SEVERE, "DBSupplier.deleteSupplier: " + e.getMessage());
			}

		} finally {
			try {
				conn.setAutoCommit(true);
				stmt.close();
			} catch (SQLException e) {
				LOGGER.log(Level.SEVERE, "DBSupplier.deleteSupplier: " + e.getMessage());
			}
			DBConnection.closeConnection();
		}

		return result;
	}
}

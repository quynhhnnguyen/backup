package database;
/**
 * Product Data Access class
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

import model.Product;

public class DBProduct {

	private static final Logger LOGGER = Logger.getLogger(DBProduct.class.getName());
	
	public DBProduct() {
		// TODO Auto-generated constructor stub
	}

	/*
	 * get all Products
	 */
	public static List<Product> getProducts() {

		List<Product> products = new ArrayList<Product>();

		String sql = "SELECT * FROM Products";

		try {
			Connection conn = DBConnection.getConnection();
			PreparedStatement stmt = conn.prepareStatement(sql);

			ResultSet rs = stmt.executeQuery();

			// loop through the result set
			while (rs.next()) {
				Product ele = new Product();
				ele.setProductId(rs.getInt("ProductId"));
				ele.setProdName(rs.getString("ProdName"));
				products.add(ele);
			}
		} catch (SQLException e) {
			LOGGER.log(Level.SEVERE, "DBProduct.getProducts: " + e.getMessage());
		} finally {
			DBConnection.closeConnection();
		}

		return products; 
	}

	/*
	 * get Product by productId
	 */
	public static Product getProduct(int productId) {

		Product ele = new Product();

		String sql = "SELECT * FROM Products WHERE ProductId=?";

		try {
			Connection conn = DBConnection.getConnection();
			PreparedStatement stmt = conn.prepareStatement(sql);
			stmt.setInt(1, productId);

			ResultSet rs = stmt.executeQuery();

			// loop through the result set
			if (rs.next()) {
				ele.setProductId(rs.getInt("ProductId"));
				ele.setProdName(rs.getString("ProdName"));
			}
		} catch (SQLException e) {
			LOGGER.log(Level.SEVERE, "DBProduct.getProduct: " + e.getMessage());
		} finally {
			DBConnection.closeConnection();
		}

		return ele;
	}

	/*
	 * update Product
	 */
	public static boolean updateProduct(Product product) throws SQLException {

		boolean result = true;

		String sql = "UPDATE Products SET ProdName = ? WHERE ProductId = ?";

		try {
			Connection conn = DBConnection.getConnection();
			PreparedStatement stmt = conn.prepareStatement(sql);

			stmt.setString(1, product.getProdName());
			stmt.setInt(2, product.getProductId());

			result = stmt.executeUpdate() == 1;
		} catch (SQLException e) {
			LOGGER.log(Level.SEVERE, "DBProduct.updateProduct: " + e.getMessage());
			throw e;
		} finally {
			DBConnection.closeConnection();
		}

		return result;
	}

	/*
	 * delete Product by productId
	 */
	public static boolean deleteProduct(int productId) {

		boolean result = true;

		Connection conn = DBConnection.getConnection();

		String sql = "DELETE FROM Products WHERE ProductId = ?";

		PreparedStatement stmt = null;

		try {
			conn.setAutoCommit(false);

			stmt = conn.prepareStatement(sql);

			stmt.setInt(1, productId);

			result = stmt.execute();
			conn.commit();

		} catch (SQLException e) {
			LOGGER.log(Level.SEVERE, "DBProduct.deleteProduct: " + e.getMessage());
			try {
				conn.rollback();
			} catch (SQLException e1) {
				LOGGER.log(Level.SEVERE, "DBProduct.deleteProduct: " + e.getMessage());
			}

		} finally {
			try {
				conn.setAutoCommit(true);
				stmt.close();
			} catch (SQLException e) {
				LOGGER.log(Level.SEVERE, "DBProduct.deleteProduct: " + e.getMessage());
			}
			DBConnection.closeConnection();
		}

		return result;
	}
}

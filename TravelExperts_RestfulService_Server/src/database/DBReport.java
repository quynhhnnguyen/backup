package database;
/**
 * OrderDetail Data Access class queries data on OrderDetailsByCustId View
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

import model.OrderDetail;

public class DBReport {

	private static final Logger LOGGER = Logger.getLogger(DBReport.class.getName());
	
	public DBReport() {
		// TODO Auto-generated constructor stub
	}
	
	/*
	 * get all OrderDetails by Customer Id
	 */
	public static List<OrderDetail> getOrderDetailsByCustId(int customerId, String bookingNo) {

		List<OrderDetail> orderDetails = new ArrayList<OrderDetail>();

		String sql = "SELECT * FROM OrderDetailsByID WHERE CustomerId = ?";
		
		if(bookingNo != null && bookingNo != "") {
			sql += " AND BookingNo = ?";
		}
		

		try {
			Connection conn = DBConnection.getConnection();
			PreparedStatement stmt = conn.prepareStatement(sql);

			stmt.setInt(1, customerId);
			
			if(bookingNo != null && bookingNo != "") {
				stmt.setString(2, bookingNo);
			}
				
			
			
			ResultSet rs = stmt.executeQuery();

			// loop through the result set
			while (rs.next()) {
				OrderDetail ele = new OrderDetail();
				ele.setBookingId(rs.getInt("BookingId"));
				ele.setCustomerId(rs.getInt("CustomerId"));
				ele.setBookingDate(rs.getDate("BookingDate"));				
				ele.setBookingNo(rs.getString("BookingNo"));
				ele.setTravelerCount(rs.getInt("TravelerCount"));
				ele.setTripTypeId(rs.getInt("TripTypeId"));
				ele.setTripTypeName(rs.getString("TTName"));
				ele.setBookingDetailId(rs.getInt("BookingDetailId"));
				ele.setItineraryNo(rs.getInt("ItineraryNo"));
				ele.setTripStart(rs.getTimestamp("TripStart"));
				ele.setTripEnd(rs.getDate("TripEnd"));
				ele.setDescription(rs.getString("Description"));
				ele.setDestination(rs.getString("Destination"));
				ele.setBasePrice(rs.getBigDecimal("BasePrice"));
				ele.setAgencyCommission(rs.getBigDecimal("AgencyCommission"));
				ele.setRegionId(rs.getInt("RegionId"));
				ele.setRegionName(rs.getString("RegionName"));
				ele.setClassId(rs.getInt("ClassId"));
				ele.setClassName(rs.getString("ClassName"));
				ele.setFeeId(rs.getInt("FeeId"));
				ele.setFeeName(rs.getString("FeeName"));
				ele.setProductSupplierId(rs.getInt("ProductSupplierId"));
				ele.setProdName(rs.getString("ProdName"));
				ele.setSupName(rs.getString("SupName"));
				
				orderDetails.add(ele);

			}
		} catch (SQLException e) {
			LOGGER.log(Level.SEVERE, "DBReport.getOrderDetailsByCustId: " + e.getMessage());
		} finally {
			DBConnection.closeConnection();
		}

		return orderDetails; 
	}
	
	

}

package database;
/** 
 * DBProvinceState Class to do queries on Provinces_States table
 * Author: Quynh Nguyen (Queenie)
 * Date: 04/11/2019
 **/
import java.sql.Connection;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import java.util.ArrayList;
import java.util.List;
import java.util.logging.Level;
import java.util.logging.Logger;

import model.ProvincesState;

public class DBProvinceState {

	private static final Logger LOGGER = Logger.getLogger(DBProvinceState.class.getName());
	
	public DBProvinceState() {
		// TODO Auto-generated constructor stub
	}

	/*
     * get Provinces or States based on country
     */
    public static List<ProvincesState> getProvStates(int countryId){
    	
    	List<ProvincesState> provStates = new ArrayList<ProvincesState>();
    	
        String sql = "SELECT * FROM provinces_states "
        		+ "WHERE countryId = " + countryId;
        
        try {
        	Connection conn = DBConnection.getConnection();
            Statement stmt  = conn.createStatement();
        		
             ResultSet rs    = stmt.executeQuery(sql);
            
            // loop through the result set
            while (rs.next()) {
            	ProvincesState ele = new ProvincesState(rs.getInt("id"),
            					rs.getString("code"), rs.getInt("countryId"), 
            					rs.getString("name"));
            	provStates.add(ele);
            }
        } catch (SQLException e) {
			LOGGER.log(Level.SEVERE, "DBProvinceState.getProvStates: " + e.getMessage());
        }
        
        return provStates;
    }
}

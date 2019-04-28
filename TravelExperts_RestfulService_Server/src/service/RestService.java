package service;

import java.io.UnsupportedEncodingException;
/** 
 * Rest Service Class provides all Rest API for Travel Experts \n
 * @version 1.0 - Date: 04/13/2019
 * @author Quynh Nguyen (Queenie)
 * 
 **/
import java.lang.reflect.Type;
import java.net.URLDecoder;
import java.util.List;
import java.util.logging.Level;
import java.util.logging.Logger;

import javax.ws.rs.Consumes;
import javax.ws.rs.FormParam;
import javax.ws.rs.GET;
import javax.ws.rs.POST;
import javax.ws.rs.Path;
import javax.ws.rs.PathParam;
import javax.ws.rs.Produces;
import javax.ws.rs.core.MediaType;

import com.google.gson.Gson;
import com.google.gson.JsonObject;
import com.google.gson.reflect.TypeToken;

import database.DBAgency;
import database.DBAgent;
import database.DBCustomer;
import database.DBProvinceState;
import database.DBReport;
import model.Agency;
import model.Agent;
import model.Customer;
import model.OrderDetail;
import model.ProvincesState;
import utilities.Utils;

@Path(value = "/api")
public class RestService {

	private static final Logger LOGGER = Logger.getLogger(RestService.class.getName()); 
	
	public RestService() {
		// TODO Auto-generated constructor stub
	}

	/**
	 * Customer Authentication - API:
	 * http://domain-name/TravelExperts/service/api/customer/authenticate
	 * 
	 * @param username Customer's username to login
	 * @param password password to login
	 * @return json String including result of authentication and error code if
	 *         there is
	 */
	@POST
	@Path("customer/authenticate")
	@Produces(MediaType.APPLICATION_JSON)
	public String customerAuthenticate(@FormParam("username") String username, @FormParam("password") String password) {

		try {
			if(!DBCustomer.customerAuthenticate(username, password))
				return Utils.FAILURE;
		}
		catch (Exception e) {
			LOGGER.log(Level.SEVERE, "RestService.customerAuthenticate: " + e.getMessage());
			return Utils.INTERNAL_ERROR;
		}
		
		return Utils.SUCCESS;

	}

	/**
	 * Agent Authentication - API:
	 * http://domain-name/TravelExperts/service/api/agent/authenticate
	 * 
	 * @param username Agent's username to login
	 * @param password password to login
	 * @return json String including result of authentication and error code if
	 *         there is
	 */
	@POST
	@Path("agent/authenticate")
	@Produces(MediaType.APPLICATION_JSON)
	public String agentAuthenticate(@FormParam("username") String username, @FormParam("password") String password) {

		try {
			if(!DBAgent.agentAuthenticate(username, password))
				return Utils.FAILURE;
		}
		catch (Exception e) {
			LOGGER.log(Level.SEVERE, "RestService.agentAuthenticate: " + e.getMessage());
			return Utils.INTERNAL_ERROR;
		}
		
		return Utils.SUCCESS;

	}
	
	/**
	 * Customer registration - Login Account to Travel Experts system -
	 * 
	 * API: http://domain-name/TravelExperts/service/api/customer/register
	 * 
	 * @param agent Agent object 
	 * @return json String including result of registration and error code if there
	 *         is
	 */
	@POST
	@Path("/agent/update")
	@Consumes(MediaType.APPLICATION_JSON)
	@Produces(MediaType.APPLICATION_JSON)
	public String updateAgent(String  agent) {
		try {
			agent = URLDecoder.decode(agent, "UTF-8");
			agent = agent.substring(6, agent.length()-1);
		} catch (UnsupportedEncodingException e1) {
			// TODO Auto-generated catch block
			e1.printStackTrace();
		}
		System.out.println("updateAgent: " + agent);
		Gson gson = new Gson();
		
		Type type = new TypeToken<Agent>() {}.getType();
		Agent agentObj = gson.fromJson(agent, type);
		
		try {
			if(!DBAgent.updateAgent(agentObj))
				return "false";
		}
		catch (Exception e) {
			LOGGER.log(Level.SEVERE, "RestService.updateAgent: " + e.getMessage());
			return "false";//Utils.INTERNAL_ERROR;
		}
		
		return "true";

	}
	
	/**
	 * Customer registration - Login Account to Travel Experts system -
	 * 
	 * API: http://domain-name/TravelExperts/service/api/customer/register
	 * 
	 * @param customer Customer object (all registered data)
	 * @return json String including result of registration and error code if there
	 *         is
	 */
	@POST
	@Path("/customer/register")
	@Consumes(MediaType.APPLICATION_JSON)
	@Produces(MediaType.APPLICATION_JSON)
	public String registerCustomer(String customer) {

		Gson gson = new Gson();
		
		Type type = new TypeToken<Customer>() {}.getType();
		Customer customerObj = gson.fromJson(customer, type);
		
		try {
			if(!DBCustomer.addCustomer(customerObj))
				return Utils.FAILURE;
		}
		catch (Exception e) {
			LOGGER.log(Level.SEVERE, "RestService.registerCustomer: " + e.getMessage());
			return Utils.INTERNAL_ERROR;
		}
		
		return Utils.SUCCESS;

	}

	/**
	 * Get List of Agents -
	 * 
	 * API: http://domain-name/TravelExperts/service/api/agent/listAll
	 * 
	 * @return json of All Agents and error code if there is
	 */
	@GET
	@Path("/agent/listAll")
	@Produces(MediaType.APPLICATION_JSON)
	public String getAllAgents() {
		System.out.println("in aganets");

		List<Agent> list = DBAgent.getAgents();
		if(list == null)
			return Utils.INTERNAL_ERROR;
		
		Gson gson = new Gson();
		Type type = new TypeToken<List<Agent>>() { }.getType();
		String stringJSON = gson.toJson(list, type);
		
		System.out.println(stringJSON);
		return stringJSON;

	}
	
	/**
	 * Get list of Customers - API:
	 * http://domain-name/TravelExperts/service/api/customer/listAll
	 * 
	 * @return json of All Customers and error code if there is
	 */
	@GET
	@Path("/customer/listAll")
	@Produces(MediaType.APPLICATION_JSON)
	public String getAllCustomers() {

		List<Customer> list = DBCustomer.getCustomers();
		if(list == null)
			return Utils.INTERNAL_ERROR;
		
		Gson gson = new Gson();
		Type type = new TypeToken<List<Customer>>() { }.getType();
		String stringJSON = gson.toJson(list, type);
		
		return stringJSON;

	}

	/**
	 * Get list of Agencies - API:
	 * http://domain-name/TravelExperts/service/api/agency/listAll
	 * 
	 * @return json of All agencies and error code if there is
	 */
	@GET
	@Path("/agency/listAll")
	@Produces(MediaType.APPLICATION_JSON)
	public String getAllAgencies() {

		List<Agency> list = DBAgency.getAgencies();
		if(list == null)
			return Utils.INTERNAL_ERROR;
		
		Gson gson = new Gson();
		Type type = new TypeToken<List<Agency>>() { }.getType();
		String stringJSON = gson.toJson(list, type);
		
		return stringJSON;

	}

	/**
	 * Get Booking History - API:
	 * http://domain-name/TravelExperts/service/api/booking/getReport/{customerId}
	 * 
	 * @param customerId Customer Id
	 * @return json of Booking History and error code if there is
	 */
	@GET
	@Path("/booking/getReport/{customerId}")
	@Produces(MediaType.APPLICATION_JSON)
	public String getReport(@PathParam("customerId") int customerId) {

		List<OrderDetail> list = DBReport.getOrderDetailsByCustId(customerId, null);
		if(list == null)
			return Utils.INTERNAL_ERROR;
		
		Gson gson = new Gson();
		Type type = new TypeToken<List<OrderDetail>>() { }.getType();
		String stringJSON = gson.toJson(list, type);
		
		return stringJSON;

	}

	/**
	 * Get Invoice - API:
	 * http://domain-name/TravelExperts/service/api/invoice/generate/{customerId}/{bookingNo}
	 * 
	 * @param customerId Customer Id
	 * @param bookingNo  Booking Number
	 * @return json of Invoice (sending invoice to customer's email) and error code
	 *         if there is
	 */
	@GET
	@Path("/invoice/generate/{customerId}/{bookingNo}")
	@Produces(MediaType.APPLICATION_JSON)
	public String generateInvoice(@PathParam("customerId") int customerId, 
			@PathParam("bookingNo") String bookingNo) {

		List<OrderDetail> list = DBReport.getOrderDetailsByCustId(customerId, bookingNo);
		if(list == null)
			return Utils.INTERNAL_ERROR;
		
		if(!Utils.generatePDF(list))
			return Utils.FAILURE;
		
		return Utils.SUCCESS;

	}

	/**
	 * List of Provinces or States based on countryId - API:
	 * http://domain-name/TravelExperts/service/api/getgetProvStates/{countryId}
	 * 
	 * @param countryId Country Id
	 * @return json of Provinces or States and error code if there is
	 */
	@GET
	@Path("/getProvStates/{countryId}")
	@Produces(MediaType.APPLICATION_JSON)
	public String getProvStates(@PathParam("countryId") String countryId) {

		List<ProvincesState> list = 
				DBProvinceState.getProvStates(Integer.valueOf(countryId));
		Gson gson = new Gson();
		Type type = new TypeToken<List<ProvincesState>>() { }.getType();
		String stringJSON = gson.toJson(list, type);

		return stringJSON;

	}
}

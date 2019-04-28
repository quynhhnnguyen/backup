package service;

import java.lang.reflect.Type;
import java.util.List;

import javax.ws.rs.Consumes;
import javax.ws.rs.DELETE;
import javax.ws.rs.GET;
import javax.ws.rs.POST;
import javax.ws.rs.Path;
import javax.ws.rs.PathParam;
import javax.ws.rs.Produces;
import javax.ws.rs.core.MediaType;

import com.google.gson.Gson;
import com.google.gson.reflect.TypeToken;

import database.DBPackage;
import model.Booking;
import model.Package;
import utilities.Utils;

@Path(value = "/package")
public class PackageService {

	public PackageService() {
		// TODO Auto-generated constructor stub
	}

	/**
	 * Get list of Packages - API:
	 * http://domain-name/TravelExperts/service/package/listAll
	 * 
	 * @return json of All packages and error code if there is
	 */
	@GET
	@Path("/listAll")
	@Produces(MediaType.APPLICATION_JSON)
	public String getAllPackages() {

		List<Package> list = DBPackage.getPackages();
		if(list == null)
			return Utils.INTERNAL_ERROR;
		
		Gson gson = new Gson();
		Type type = new TypeToken<List<Package>>() { }.getType();
		String stringJSON = gson.toJson(list, type);
		
		return stringJSON;

	}

	/**
	 * Get Package Information by Package Id - API:
	 * http://domain-name/TravelExperts/service/package/get/{packageId}
	 * 
	 * @param packageId Package Id
	 * @return json of Package Information and error code if there is
	 */
	@GET
	@Path("/get/{packageId}")
	@Produces(MediaType.APPLICATION_JSON)
	public String getPackage(@PathParam("packageId") int packageId) {

		Package pack = DBPackage.getPackage(packageId);
		
		if(pack == null)
			return Utils.INTERNAL_ERROR;

		Gson gson = new Gson();
		Type type = new TypeToken<Package>() { }.getType();
		String stringJSON = gson.toJson(pack, type);

		return stringJSON;

	}

	/**
	 * Update Package - API: http://domain-name/TravelExperts/service/package/update
	 * 
	 * @param pckage - Package Object
	 * @return json String including result of updating package and error code if
	 *         there is
	 */
	@POST
	@Path("/update")
	@Consumes(MediaType.APPLICATION_JSON)
	@Produces(MediaType.APPLICATION_JSON)
	public String updatePackage(String pckage) {

		Gson gson = new Gson();
		
		Type type = new TypeToken<Package>() {}.getType();
		Package packObj = gson.fromJson(pckage, type);
		
		if(!DBPackage.updatePackage(packObj))
			return Utils.INTERNAL_ERROR;
		
		return Utils.SUCCESS;
	}

	/**
	 * Delete Package - API: http://domain-name/TravelExperts/service/package/delete
	 * 
	 * @param packageId - Package Id
	 * @return json String including result of deleting package and error code if
	 *         there is
	 */
	@DELETE
	@Path("/delete/{packageId}")
	@Produces(MediaType.APPLICATION_JSON)
	public String deletePackage(@PathParam("packageId") int packageId) {

		if(!DBPackage.deletePackage(packageId))
			return Utils.INTERNAL_ERROR;
		
		return Utils.SUCCESS;

	}
	
	/**
	 * Booking Package - API:
	 * http://domain-name/TravelExperts/service/package/book
	 * 
	 * @param booking Booking Object
	 * @return json String including result of booking Package and error code if
	 *         there is
	 */
	@POST
	@Path("/book")
	@Consumes(MediaType.APPLICATION_JSON)
	@Produces(MediaType.APPLICATION_JSON)
	public String bookPackage(String booking) {

		Gson gson = new Gson();
		
		Type type = new TypeToken<Booking>() {}.getType();
		Booking bookingObj = gson.fromJson(booking, type);
		
		if(!DBPackage.bookPackage(bookingObj))
			return Utils.INTERNAL_ERROR;
		
		return Utils.SUCCESS;

	}

}

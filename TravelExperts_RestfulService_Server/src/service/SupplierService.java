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

import database.DBSupplier;
import model.Supplier;
import utilities.Utils;

@Path(value = "/supplier")
public class SupplierService {

	public SupplierService() {
		// TODO Auto-generated constructor stub
	}

	/**
	 * Get Suppliers - API:
	 * http://domain-name/TravelExperts/service/supplier/listAll
	 * 
	 * @return json of All Suppliers and error code if there is
	 */
	@GET
	@Path("/listAll")
	@Produces(MediaType.APPLICATION_JSON)
	public String getAllSuppliers() {

		List<Supplier> list = DBSupplier.getSuppliers();
		if(list == null)
			return Utils.INTERNAL_ERROR;
		
		Gson gson = new Gson();
		Type type = new TypeToken<List<Supplier>>() { }.getType();
		String stringJSON = gson.toJson(list, type);
		
		return stringJSON;

	}

	/**
	 * Get Supplier Information by Supplier Id - API:
	 * http://domain-name/TravelExperts/service/supplier/get/{supplierId}
	 * 
	 * @param supplierId Supplier Id
	 * @return json of Supplier Information and error code if there is
	 */
	@GET
	@Path("/get/{supplierId}")
	@Produces(MediaType.APPLICATION_JSON)
	public String getSupplier(@PathParam("supplierId") int supplierId) {

		Supplier supplier = DBSupplier.getSupplier(supplierId);
		if(supplier == null)
			return Utils.INTERNAL_ERROR;
		
		Gson gson = new Gson();
		Type type = new TypeToken<Supplier>() { }.getType();
		String stringJSON = gson.toJson(supplier, type);
		
		return stringJSON;

	}

	/**
	 * Update Supplier - API:
	 * http://domain-name/TravelExperts/service/supplier/update
	 * 
	 * @param supplier - Supplier Object
	 * @return json String including result of updating Supplier and error code if
	 *         there is
	 */
	@POST
	@Path("/update")
	@Consumes(MediaType.APPLICATION_JSON)
	@Produces(MediaType.APPLICATION_JSON)
	public String updateSupplier(String supplier) {

		Gson gson = new Gson();
		
		Type type = new TypeToken<Supplier>() {}.getType();
		Supplier supplierObj = gson.fromJson(supplier, type);
		
		if(!DBSupplier.updateSupplier(supplierObj))
			return Utils.INTERNAL_ERROR;
		
		return Utils.SUCCESS;

	}

	/**
	 * Delete Supplier - API:
	 * http://domain-name/TravelExperts/service/supplier/delete
	 * 
	 * @param supplierId - Supplier Id
	 * @return json String including result of deleting Supplier and error code if
	 *         there is
	 */
	@DELETE
	@Path("/delete/{supplierId}")
	@Produces(MediaType.APPLICATION_JSON)
	public String deleteSupplier(@PathParam("supplierId") int supplierId) {

		if(!DBSupplier.deleteSupplier(supplierId))
			return Utils.INTERNAL_ERROR;
		
		return Utils.SUCCESS;

	}

}

package service;

import java.lang.reflect.Type;
import java.sql.SQLException;
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

import database.DBProduct;
import model.Product;
import utilities.Utils;

@Path(value = "/product")
public class ProductService {

	public ProductService() {
		// TODO Auto-generated constructor stub
	}

	/**
	 * Get Products - API:
	 * http://domain-name/TravelExperts/service/product/listAll
	 * 
	 * @return json of All Products and error code if there is
	 */
	@GET
	@Path("/listAll")
	@Produces(MediaType.APPLICATION_JSON)
	public String getAllProducts() {

		List<Product> list = DBProduct.getProducts();
		if(list == null)
			return Utils.INTERNAL_ERROR;
		
		Gson gson = new Gson();
		Type type = new TypeToken<List<Product>>() { }.getType();
		String stringJSON = gson.toJson(list, type);
		
		return stringJSON;
	}

	/**
	 * Get Product Information by Product Id - API:
	 * http://domain-name/TravelExperts/service/product/get/{productId}
	 * 
	 * @param productId Product Id
	 * @return json of Product Information and error code if there is
	 */
	@GET
	@Path("/get/{productId}")
	@Produces(MediaType.APPLICATION_JSON)
	public String getProduct(@PathParam("productId") int productId) {

		Product product = DBProduct.getProduct(productId);
		if(product == null)
			return Utils.INTERNAL_ERROR;
		
		Gson gson = new Gson();
		Type type = new TypeToken<Product>() { }.getType();
		String stringJSON = gson.toJson(product, type);
		
		return stringJSON;

	}

	/**
	 * Update Product - API:
	 * http://domain-name/TravelExperts/service/product/update
	 * 
	 * @param product - Product Object
	 * @return json String including result of updating Product and error code if
	 *         there is
	 */
	@POST
	@Path("/update")
	@Consumes(MediaType.APPLICATION_JSON)
	@Produces(MediaType.APPLICATION_JSON)
	public String updateProduct(String product) {

		Gson gson = new Gson();
		
		Type type = new TypeToken<Product>() {}.getType();
		Product productObj = gson.fromJson(product, type);
		
		try {
			if(!DBProduct.updateProduct(productObj))
				return "false";
		} catch (SQLException e) {
			// TODO Auto-generated catch block
			//e.printStackTrace();
			return "false";
		}//Utils.INTERNAL_ERROR;
		
		return "true"; //Utils.SUCCESS;

	}

	/**
	 * Delete Product - API:
	 * http://domain-name/TravelExperts/service/product/delete
	 * 
	 * @param productId - Product Id
	 * @return json String including result of deleting Product and error code if
	 *         there is
	 */
	@DELETE
	@Path("/delete/{productId}")
	@Produces(MediaType.APPLICATION_JSON)
	public String deleteProduct(@PathParam("productId") int productId) {

		if(!DBProduct.deleteProduct(productId))
			return Utils.INTERNAL_ERROR;
		
		return Utils.SUCCESS;

	}

}

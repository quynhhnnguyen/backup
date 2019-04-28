package model;

import java.io.Serializable;
import javax.persistence.*;


/**
 * The persistent class for the provinces_states database table.
 * 
 */
@Entity
@Table(name="provinces_states")
@NamedQuery(name="ProvincesState.findAll", query="SELECT p FROM ProvincesState p")
public class ProvincesState implements Serializable {
	private static final long serialVersionUID = 1L;

	@Id
	private int id;

	private String code;

	private int countryId;

	private String name;

	public ProvincesState() {
	}

	public ProvincesState(int id, String code, int countryId, String name) {
		this.id = id;
		this.code = code;
		this.countryId = countryId;
		this.name = name;
	}
	
	public int getId() {
		return this.id;
	}

	public void setId(int id) {
		this.id = id;
	}

	public String getCode() {
		return this.code;
	}

	public void setCode(String code) {
		this.code = code;
	}

	public int getCountryId() {
		return this.countryId;
	}

	public void setCountryId(int countryId) {
		this.countryId = countryId;
	}

	public String getName() {
		return this.name;
	}

	public void setName(String name) {
		this.name = name;
	}

}
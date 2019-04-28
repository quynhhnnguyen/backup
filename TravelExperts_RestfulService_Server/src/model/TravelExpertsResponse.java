package model;

import java.util.ArrayList;

public class TravelExpertsResponse {
	
	private ArrayList<?> result;
	
	private int responseCode;

	public Object getResult() {
		return result;
	}

	public void setResult(ArrayList<?> result) {
		this.result = result;
	}

	public int getResponseCode() {
		return responseCode;
	}

	public void setResponseCode(int responseCode) {
		this.responseCode = responseCode;
	}
	
}

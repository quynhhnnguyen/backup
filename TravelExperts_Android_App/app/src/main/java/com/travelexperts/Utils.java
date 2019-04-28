package com.travelexperts;

import android.content.Context;
import android.view.Gravity;
import android.widget.Toast;

import com.android.volley.RequestQueue;
import com.android.volley.Response;
import com.android.volley.VolleyError;
import com.android.volley.toolbox.JsonArrayRequest;
import com.android.volley.toolbox.Volley;
import com.travelexperts.model.Agent;

import org.json.JSONArray;
import org.json.JSONException;
import org.json.JSONObject;

import java.util.ArrayList;
import java.util.List;

/**
 * Utilities class - all utilities and call rest api methods
 * Author: Quynh Nguyen(Queenie)
 * Date: 04-09-2019
 */
public class Utils {
    public static final String SERVER_NAME = "http://10.0.2.2:9080/TravelExperts/service";
    public static final String CUSTOMER_SERVICE = "/api/customer";
    public static final String LOGIN_SERVICE = "/authenticate";
    public final static String CUSTOMER_REGISTRATION_SERVICE ="/register";
    public final static String AGENTLIST_SERVICE = "/api/agent";
    public final static String AGENCYLIST_SERVICE = "/api/agency";
    public final static String BOOKING_REPORT_SERVICE = "/report/bookings/";
    public final static String PACKAGE_SERVICE = "/package";
    public final static String PRODUCT_SERVICE = "/product";
    public final static String SUPPLIER_SERVICE = "/supplier";
    public final static String LISTALL_SERVICE = "/listAll";

    private static RequestQueue requestQueue;
    private static JsonArrayRequest request;

    // show message function
    public static void showMessage(Context context, String message) {
        Toast toast = Toast.makeText(context,
                message, Toast.LENGTH_LONG);
        toast.setGravity(Gravity.CENTER_VERTICAL, 0, 300);
        toast.show();
    }

    public static ArrayList<Agent> getAgentsRequest(Context context){

        final ArrayList<Agent> list = new ArrayList<>();
        String url = Utils.SERVER_NAME + Utils.AGENTLIST_SERVICE + Utils.LISTALL_SERVICE;

        requestQueue = Volley.newRequestQueue(context);
        request = new JsonArrayRequest(url, new Response.Listener<JSONArray>() {
            @Override
            public void onResponse(JSONArray response) {
                JSONObject jsonObject = null;

                for(int i=0; i < response.length(); i++)
                {
                    try{
                        jsonObject = response.getJSONObject(i);
                        //make a class object
                        Agent agent = new Agent();

                        agent.setAgentId(jsonObject.getInt("agentId"));
                        agent.setAgtFirstName(jsonObject.getString("agtFirstName"));
                        agent.setAgtMiddleInitial(jsonObject.getString("agtMiddleInitial"));
                        agent.setAgtLastName(jsonObject.getString("agtLastName"));
                        agent.setAgtBusPhone(jsonObject.getString("agtBusPhone"));
                        agent.setAgtEmail(jsonObject.getString("agtEmail"));
                        agent.setAgtPosition(jsonObject.getString("agtPosition"));
                        //agent.setUserName(jsonObject.getString("userName"));
                        //agent.setPassword(jsonObject.getString("password"));
                        agent.setAgencyId(jsonObject.getInt("agencyId"));

                        list.add(agent);
                    } catch (JSONException e) {
                        e.printStackTrace();
                    }
                }
            }
        }, new Response.ErrorListener() {
            @Override
            public void onErrorResponse(VolleyError error) {
                System.out.println(error);
            }
        });

        requestQueue.add(request);
        return list;
    }

}

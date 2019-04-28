package com.travelexperts.model;

import java.io.Serializable;


public class Agent implements Serializable {
    private int agentId;
    private String agtFirstName;
    private String agtMiddleInitial;
    private String agtLastName;
    private String agtBusPhone;
    private String agtEmail;
    private String agtPosition;
    private int agencyId;
    private String userName;
    private String password;

    // constructor
    public Agent() {}

    public Agent(int agentId, String agtFirstName, String agtMiddleInitial, String agtLastName,
                 String agtBusPhone, String agtEmail, String agtPosition, int agencyId,
                 String userName, String password) {
        this.agentId = agentId;
        this.agtFirstName = agtFirstName;
        this.agtMiddleInitial = agtMiddleInitial;
        this.agtLastName = agtLastName;
        this.agtBusPhone = agtBusPhone;
        this.agtEmail = agtEmail;
        this.agtPosition = agtPosition;
        this.agencyId = agencyId;
        this.userName = userName;
        this.password = password;
    }

    // Getter
    public int getAgentId() {
        return agentId;
    }

    public String getAgtFirstName() {
        return agtFirstName;
    }

    public String getAgtMiddleInitial() {
        return agtMiddleInitial;
    }

    public String getAgtLastName() {
        return agtLastName;
    }

    public String getAgtBusPhone() {
        return agtBusPhone;
    }

    public String getAgtEmail() {
        return agtEmail;
    }

    public String getAgtPosition() {
        return agtPosition;
    }

    public int getAgencyId() {
        return agencyId;
    }

    public String getUserName() {
        return userName;
    }

    public String getPassword() {
        return password;
    }

    // setter
    public void setAgentId(int agentId) {
        this.agentId = agentId;
    }

    public void setAgtFirstName(String agtFirstName) {
        this.agtFirstName = agtFirstName;
    }

    public void setAgtMiddleInitial(String agtMiddleInitial) {
        this.agtMiddleInitial = agtMiddleInitial;
    }

    public void setAgtLastName(String agtLastName) {
        this.agtLastName = agtLastName;
    }

    public void setAgtBusPhone(String agtBusPhone) {
        this.agtBusPhone = agtBusPhone;
    }

    public void setAgtEmail(String agtEmail) {
        this.agtEmail = agtEmail;
    }

    public void setAgtPosition(String agtPosition) {
        this.agtPosition = agtPosition;
    }

    public void setAgencyId(int agencyId) {
        this.agencyId = agencyId;
    }

    public void setUserName(String userName) {
        this.userName = userName;
    }

    public void setPassword(String password) {
        this.password = password;
    }

    // Agent information from object


    @Override
    public String toString() {
        return agtLastName + ", " + agtFirstName + " " +
                (agtMiddleInitial == null? "" : agtMiddleInitial);
    }
}

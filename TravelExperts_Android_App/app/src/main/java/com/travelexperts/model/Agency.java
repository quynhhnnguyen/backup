package com.travelexperts.model;

import java.io.Serializable;

public class Agency implements Serializable {
    private int agencyId;
    private String agncyAddress;
    private String agncyCity;
    private String agncyProv;
    private String agancyPostal;
    private String agncyCountry;
    private String agancyPhone;
    private String agancyFax;

    public Agency(int agencyId, String agncyAddress, String agncyCity, String agncyProv, String agancyPostal, String agncyCountry, String agancyPhone, String agancyFax) {
        this.agencyId = agencyId;
        this.agncyAddress = agncyAddress;
        this.agncyCity = agncyCity;
        this.agncyProv = agncyProv;
        this.agancyPostal = agancyPostal;
        this.agncyCountry = agncyCountry;
        this.agancyPhone = agancyPhone;
        this.agancyFax = agancyFax;
    }

    public int getAgencyId() {
        return agencyId;
    }

    public void setAgencyId(int agencyId) {
        this.agencyId = agencyId;
    }

    public String getAgncyAddress() {
        return agncyAddress;
    }

    public void setAgncyAddress(String agncyAddress) {
        this.agncyAddress = agncyAddress;
    }

    public String getAgncyCity() {
        return agncyCity;
    }

    public void setAgncyCity(String agncyCity) {
        this.agncyCity = agncyCity;
    }

    public String getAgncyProv() {
        return agncyProv;
    }

    public void setAgncyProv(String agncyProv) {
        this.agncyProv = agncyProv;
    }

    public String getAgancyPostal() {
        return agancyPostal;
    }

    public void setAgancyPostal(String agancyPostal) {
        this.agancyPostal = agancyPostal;
    }

    public String getAgncyCountry() {
        return agncyCountry;
    }

    public void setAgncyCountry(String agncyCountry) {
        this.agncyCountry = agncyCountry;
    }

    public String getAgancyPhone() {
        return agancyPhone;
    }

    public void setAgancyPhone(String agancyPhone) {
        this.agancyPhone = agancyPhone;
    }

    public String getAgancyFax() {
        return agancyFax;
    }

    public void setAgancyFax(String agancyFax) {
        this.agancyFax = agancyFax;
    }


    @Override
    public String toString() {
        return "Agency{" +
                "Agency Id=" + agencyId  +
                '}';
    }
}

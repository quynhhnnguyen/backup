package model;

import java.io.Serializable;
import java.math.BigDecimal;
import java.util.Date;


/**
 * OrderDetail database view.
 * 
 */
public class OrderDetail implements Serializable {
	private static final long serialVersionUID = 1L;

	private int bookingId;
	
	private int customerId;
	
	private Date bookingDate;
	
	private String bookingNo;
	
	private int travelerCount;
	
	private int tripTypeId;
	
	private String tripTypeName; 
	
	private int bookingDetailId;
	
	private double itineraryNo;
	
	private Date tripStart;
	
	private Date tripEnd;
	
	private String description;
	
	private String destination;
	
	private BigDecimal basePrice;
	
	private BigDecimal agencyCommission;

	private int regionId;
	
	private String regionName; 
	
	private int classId;
	
	private String className; 
	
	private int feeId;
	
	private String feeName; 
	
	private int productSupplierId;
	
	private String prodName; 
	
	private String SupName; 
	
	public OrderDetail() {
	}

	public int getBookingId() {
		return bookingId;
	}

	public void setBookingId(int bookingId) {
		this.bookingId = bookingId;
	}

	public int getCustomerId() {
		return customerId;
	}

	public void setCustomerId(int customerId) {
		this.customerId = customerId;
	}

	public Date getBookingDate() {
		return bookingDate;
	}

	public void setBookingDate(Date bookingDate) {
		this.bookingDate = bookingDate;
	}

	public String getBookingNo() {
		return bookingNo;
	}

	public void setBookingNo(String bookingNo) {
		this.bookingNo = bookingNo;
	}

	public int getTravelerCount() {
		return travelerCount;
	}

	public void setTravelerCount(int travelerCount) {
		this.travelerCount = travelerCount;
	}

	public int getTripTypeId() {
		return tripTypeId;
	}

	public void setTripTypeId(int tripTypeId) {
		this.tripTypeId = tripTypeId;
	}

	public String getTripTypeName() {
		return tripTypeName;
	}

	public void setTripTypeName(String tripTypeName) {
		this.tripTypeName = tripTypeName;
	}

	public int getBookingDetailId() {
		return bookingDetailId;
	}

	public void setBookingDetailId(int bookingDetailId) {
		this.bookingDetailId = bookingDetailId;
	}

	public double getItineraryNo() {
		return itineraryNo;
	}

	public void setItineraryNo(double itineraryNo) {
		this.itineraryNo = itineraryNo;
	}

	public Date getTripStart() {
		return tripStart;
	}

	public void setTripStart(Date tripStart) {
		this.tripStart = tripStart;
	}

	public Date getTripEnd() {
		return tripEnd;
	}

	public void setTripEnd(Date tripEnd) {
		this.tripEnd = tripEnd;
	}

	public String getDescription() {
		return description;
	}

	public void setDescription(String description) {
		this.description = description;
	}

	public String getDestination() {
		return destination;
	}

	public void setDestination(String destination) {
		this.destination = destination;
	}

	public BigDecimal getBasePrice() {
		return basePrice;
	}

	public void setBasePrice(BigDecimal basePrice) {
		this.basePrice = basePrice;
	}

	public BigDecimal getAgencyCommission() {
		return agencyCommission;
	}

	public void setAgencyCommission(BigDecimal agencyCommission) {
		this.agencyCommission = agencyCommission;
	}

	public int getRegionId() {
		return regionId;
	}

	public void setRegionId(int regionId) {
		this.regionId = regionId;
	}

	public String getRegionName() {
		return regionName;
	}

	public void setRegionName(String regionName) {
		this.regionName = regionName;
	}

	public int getClassId() {
		return classId;
	}

	public void setClassId(int classId) {
		this.classId = classId;
	}

	public String getClassName() {
		return className;
	}

	public void setClassName(String className) {
		this.className = className;
	}

	public int getFeeId() {
		return feeId;
	}

	public void setFeeId(int feeId) {
		this.feeId = feeId;
	}

	public String getFeeName() {
		return feeName;
	}

	public void setFeeName(String feeName) {
		this.feeName = feeName;
	}

	public int getProductSupplierId() {
		return productSupplierId;
	}

	public void setProductSupplierId(int productSupplierId) {
		this.productSupplierId = productSupplierId;
	}

	public String getProdName() {
		return prodName;
	}

	public void setProdName(String prodName) {
		this.prodName = prodName;
	}

	public String getSupName() {
		return SupName;
	}

	public void setSupName(String supName) {
		SupName = supName;
	}
	
}
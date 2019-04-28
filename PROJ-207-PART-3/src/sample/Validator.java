package sample;

import javafx.fxml.FXML;
import javafx.scene.control.*;

import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class Validator {
    @FXML
    protected ComboBox cbCustomerId;
    @FXML
    protected TextField CustFirstName;
    @FXML
    protected TextField CustLastName;
    @FXML
    protected TextField CustAddress;
    @FXML
    protected TextField CustCity;
    @FXML
    protected TextField CustProv;
    @FXML
    protected TextField CustPostal;
    @FXML
    protected TextField CustCountry;
    @FXML
    protected TextField CustHomePhone;
    @FXML
    protected TextField CustBusPhone;
    @FXML
    protected TextField CustEmail;
    @FXML
    protected ComboBox cbAgentId;
    @FXML
    protected Button btnEdit;
    @FXML
    protected Button btnSave;
    @FXML
    protected Button btnAddCustomer;
    @FXML
    protected ComboBox cbBookingId;
    @FXML
    protected DatePicker BookingDate;
    @FXML
    protected TextField BookingNo;
    @FXML
    protected ComboBox cbTripTypeId;
    @FXML
    protected TextField TravelerCount;
    @FXML
    protected ComboBox cbCustId;
    @FXML
    protected Button btnEditBookings;
    @FXML
    protected Button btnSaveBookings;
    @FXML
    protected Button btnAddBookings;
    @FXML
    protected TextField PackageId;
    @FXML
    protected ComboBox cbPackageId;
    @FXML
    protected TextField PkgName;
    @FXML
    protected DatePicker PkgStartDate;
    @FXML
    protected DatePicker PkgEndDate;
    @FXML
    protected TextField PkgDesc;
    @FXML
    protected TextField PkgBasePrice;
    @FXML
    protected TextField PkgAgencyCommission;
    @FXML
    protected Button btnEditPackages;
    @FXML
    protected Button btnSavePackages;
    @FXML
    protected Button btnAddPackages;
    @FXML
    protected ComboBox cbProductId;
    @FXML
    protected TextField ProdName;
    @FXML
    protected Button btnAddProducts;
    @FXML
    protected Button btnEditProducts;
    @FXML
    protected Button btnSaveProducts;
    @FXML
    private Button btnDeletePackage;
    @FXML
    private Button btnClearCustomer;
    @FXML
    private Button btnClearBookings;
    @FXML
    private Button btnClearPackages;
    @FXML
    private Button btnClear;
    @FXML
    private Button btnDeleteProduct;

    @FXML
    void initialize() {
        assert cbCustomerId != null : "fx:id=\"cbCustomerId\" was not injected: check your FXML file 'realSample.fxml'.";
        assert CustFirstName != null : "fx:id=\"CustFirstName\" was not injected: check your FXML file 'realSample.fxml'.";
        assert CustLastName != null : "fx:id=\"CustLastName\" was not injected: check your FXML file 'realSample.fxml'.";
        assert CustAddress != null : "fx:id=\"CustAddress\" was not injected: check your FXML file 'realSample.fxml'.";
        assert CustCity != null : "fx:id=\"CustCity\" was not injected: check your FXML file 'realSample.fxml'.";
        assert CustProv != null : "fx:id=\"CustProv\" was not injected: check your FXML file 'realSample.fxml'.";
        assert CustPostal != null : "fx:id=\"CustPostal\" was not injected: check your FXML file 'realSample.fxml'.";
        assert CustCountry != null : "fx:id=\"CustCountry\" was not injected: check your FXML file 'realSample.fxml'.";
        assert CustHomePhone != null : "fx:id=\"CustHomePhone\" was not injected: check your FXML file 'realSample.fxml'.";
        assert CustBusPhone != null : "fx:id=\"CustBusPhone\" was not injected: check your FXML file 'realSample.fxml'.";
        assert CustEmail != null : "fx:id=\"CustEmail\" was not injected: check your FXML file 'realSample.fxml'.";
        assert cbAgentId != null : "fx:id=\"cbAgentId\" was not injected: check your FXML file 'realSample.fxml'.";
        assert btnEdit != null : "fx:id=\"btnEdit\" was not injected: check your FXML file 'realSample.fxml'.";
        assert btnSave != null : "fx:id=\"btnSave\" was not injected: check your FXML file 'realSample.fxml'.";
        assert btnClearCustomer != null : "fx:id=\"btnClearCustomer\" was not injected: check your FXML file 'realSample.fxml'.";
        assert btnAddCustomer != null : "fx:id=\"btnAddCustomer\" was not injected: check your FXML file 'realSample.fxml'.";
        assert cbBookingId != null : "fx:id=\"cbBookingId\" was not injected: check your FXML file 'realSample.fxml'.";
        assert BookingDate != null : "fx:id=\"BookingDate\" was not injected: check your FXML file 'realSample.fxml'.";
        assert BookingNo != null : "fx:id=\"BookingNo\" was not injected: check your FXML file 'realSample.fxml'.";
        assert TravelerCount != null : "fx:id=\"TravelerCount\" was not injected: check your FXML file 'realSample.fxml'.";
        assert cbCustId != null : "fx:id=\"cbCustId\" was not injected: check your FXML file 'realSample.fxml'.";
        assert cbTripTypeId != null : "fx:id=\"cbTripTypeId\" was not injected: check your FXML file 'realSample.fxml'.";
        assert PackageId != null : "fx:id=\"PackageId\" was not injected: check your FXML file 'realSample.fxml'.";
        assert btnEditBookings != null : "fx:id=\"btnEditBookings\" was not injected: check your FXML file 'realSample.fxml'.";
        assert btnSaveBookings != null : "fx:id=\"btnSaveBookings\" was not injected: check your FXML file 'realSample.fxml'.";
        assert btnClearBookings != null : "fx:id=\"btnClearBookings\" was not injected: check your FXML file 'realSample.fxml'.";
        assert btnAddBookings != null : "fx:id=\"btnAddBookings\" was not injected: check your FXML file 'realSample.fxml'.";
        assert cbPackageId != null : "fx:id=\"cbPackageId\" was not injected: check your FXML file 'realSample.fxml'.";
        assert PkgName != null : "fx:id=\"PkgName\" was not injected: check your FXML file 'realSample.fxml'.";
        assert PkgStartDate != null : "fx:id=\"PkgStartDate\" was not injected: check your FXML file 'realSample.fxml'.";
        assert PkgEndDate != null : "fx:id=\"PkgEndDate\" was not injected: check your FXML file 'realSample.fxml'.";
        assert PkgDesc != null : "fx:id=\"PkgDesc\" was not injected: check your FXML file 'realSample.fxml'.";
        assert PkgBasePrice != null : "fx:id=\"PkgBasePrice\" was not injected: check your FXML file 'realSample.fxml'.";
        assert PkgAgencyCommission != null : "fx:id=\"PkgAgencyCommission\" was not injected: check your FXML file 'realSample.fxml'.";
        assert btnEditPackages != null : "fx:id=\"btnEditPackages\" was not injected: check your FXML file 'realSample.fxml'.";
        assert btnSavePackages != null : "fx:id=\"btnSavePackages\" was not injected: check your FXML file 'realSample.fxml'.";
        assert cbProductId != null : "fx:id=\"cbProductId\" was not injected: check your FXML file 'realSample.fxml'.";
        assert ProdName != null : "fx:id=\"ProdName\" was not injected: check your FXML file 'realSample.fxml'.";
        assert btnEditProducts != null : "fx:id=\"btnEditProducts\" was not injected: check your FXML file 'realSample.fxml'.";
        assert btnSaveProducts != null : "fx:id=\"btnSaveProducts\" was not injected: check your FXML file 'realSample.fxml'.";
        assert btnClear != null : "fx:id=\"btnClear\" was not injected: check your FXML file 'realSample.fxml'.";
        assert btnAddProducts != null : "fx:id=\"btnAddProducts\" was not injected: check your FXML file 'realSample.fxml'.";
        assert btnClearPackages != null : "fx:id=\"btnClearPackages\" was not injected: check your FXML file 'realSample.fxml'.";
        assert btnAddPackages != null : "fx:id=\"btnAddPackages\" was not injected: check your FXML file 'realSample.fxml'.";
        assert btnDeleteProduct != null : "fx:id=\"btnDeleteProduct\" was not injected: check your FXML file 'realSample.fxml'.";

    }


    private String endLine; //stores string that is added to end of each validatioin message.

    public Validator() {
        this.endLine = "\n";
    }

    public Validator(String endLine) {
        this.endLine = endLine;
    }

    public String isPresent(String value, String name)
    {
        String msg = "";

        if(value.isEmpty()) {
            msg = name + " is required." + endLine;
        }
        return msg;
    }

    public String isDouble(String value, String name)
    {
        String msg = "";
        try {
            Double.parseDouble(value);
        }
        catch (NumberFormatException e){
            msg = name + " must be a valid number." + endLine;
        }
        return msg;
    }

    public String isFloat(String value, String name)
    {
        String msg = "";
        try {
            Float.parseFloat(value);
        }
        catch (NumberFormatException e){
            msg = name + " must be a valid number." + endLine;
        }
        return msg;
    }

    public String isInteger(String value, String name)
    {
        String msg = "";
        try {
            Integer.parseInt(value);
        }
        catch (NumberFormatException e){
            msg = name + " must be an integer." + endLine;
        }
        return msg;
    }



    /*public boolean validateFieldsCustomer(){
        //System.out.println(CustFirstName.getText());
     //   if (CustEmail.getText().isEmpty()) {
      if(CustFirstName.getText() == "" || CustLastName.getText() == "" || CustAddress.getText() == "" || CustCity.getText() == "" || CustProv.getText() == "" || CustPostal.getText() == "" || CustCountry.getText() == "" || CustHomePhone.getText() == "" || CustBusPhone.getText() == ""  || CustEmail.getText() == "" ) {
            Alert alert = new Alert(Alert.AlertType.WARNING);
            alert.setTitle("Validator Fields");
            alert.setHeaderText(null);
            alert.setContentText("Please Enter into Fields");
            alert.showAndWait();
        }
        return false;
    }

  //   || TravelerCount.getText().isEmpty() || PkgName.getText().isEmpty() || PkgDesc.getText().isEmpty() || PkgBasePrice.getText().isEmpty() || PkgAgencyCommission.getText().isEmpty() || ProdName.getText().isEmpty()

    public boolean validateNumber() {
        Pattern p = Pattern.compile("[0-9]+");
        Matcher m = p.matcher(PkgBasePrice.getText());
        Matcher n = p.matcher(PkgAgencyCommission.getText());
        Matcher o = p.matcher(TravelerCount.getText());
        Matcher h = p.matcher(CustHomePhone.getText());
        Matcher b = p.matcher(CustBusPhone.getText());
        if((m.find() && m.group().equals(PkgBasePrice.getText())) || (n.find() && n.group().equals(PkgAgencyCommission.getText())) || (o.find() && o.group().equals(TravelerCount.getText())) || (h.find() && h.group().equals(CustHomePhone.getText())) || (b.find() && b.group().equals(CustBusPhone.getText()))) {
            return true;
        }
        else {
            Alert alert = new Alert(Alert.AlertType.WARNING);
            alert.setTitle("Validator Number");
            alert.setHeaderText(null);
            alert.setContentText("Please Enter a Valid Number");
            alert.showAndWait();
        }
        return  false;
    }

    public boolean validateEmail() {
        Pattern p = Pattern.compile("[a-zA-Z0-9][a-zA-Z0-9._]*@[a-zA-Z0-9]+([.][a-zA-Z]+)+");
        Matcher m = p.matcher(CustEmail.getText());
        if(m.find() && m.group().equals(CustEmail.getText())) {
            return true;
        }
        else {
            Alert alert = new Alert(Alert.AlertType.WARNING);
            alert.setTitle("Validator Email");
            alert.setHeaderText(null);
            alert.setContentText("Please Enter a Valid Email");
            alert.showAndWait();
        }
        return false;
    }

    private boolean validatePostalCode() {
        Pattern pc =Pattern.compile("^(?!.*[DFIOQU])[A-VXY][0-9][A-Z] ?[0-9][A-Z][0-9]$");
        Matcher m = pc.matcher(CustPostal.getText());
        if(m.find() && m.group().equals(CustPostal.getText())) {
            return true;
        }
        else {
            Alert alert = new Alert(Alert.AlertType.WARNING);
            alert.setTitle("Validator Postal Code");
            alert.setHeaderText(null);
            alert.setContentText("Please Enter a Valid Postal Code");
            alert.showAndWait();
        }
        return false;
    }*/
}
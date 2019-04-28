package sample;

import javafx.beans.property.SimpleIntegerProperty;
import javafx.beans.property.SimpleStringProperty;

public class Products {
    SimpleIntegerProperty productId;
    SimpleStringProperty prodName;

    public Products(int productId, String prodName) {
        this.productId =new SimpleIntegerProperty(productId);
        this.prodName =new SimpleStringProperty(prodName);
    }

    public int getProductId() {
        return productId.get();
    }

    public SimpleIntegerProperty productIdProperty() {
        return productId;
    }

    public void setProductId(int productId) {
        this.productId.set(productId);
    }

    public String getProdName() {
        return prodName.get();
    }

    public SimpleStringProperty prodNameProperty() {
        return prodName;
    }

    public void setProdName(String prodName) {
        this.prodName.set(prodName);
    }

    @Override
    public String toString() {
        return "Product ID: " + productId.get() + "";
    }
}

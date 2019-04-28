package sample;

import javafx.beans.property.SimpleStringProperty;

public class TripTypes {
    SimpleStringProperty triptypeId;
    SimpleStringProperty ttName;

    public TripTypes(String tripTypeId, String TTName) {
        triptypeId = new SimpleStringProperty(tripTypeId);
        this.ttName = new SimpleStringProperty(TTName);
    }

    public String getTriptypeId() {
        return triptypeId.get();
    }

    public SimpleStringProperty triptypeIdProperty() {
        return triptypeId;
    }

    public void setTriptypeId(String triptypeId) {
        this.triptypeId.set(triptypeId);
    }

    public String getTtName() {
        return ttName.get();
    }

    public SimpleStringProperty ttNameProperty() {
        return ttName;
    }

    public void setTtName(String ttName) {
        this.ttName.set(ttName);
    }

    @Override
    public String toString() {
        return triptypeId.get() + "";
    }
}

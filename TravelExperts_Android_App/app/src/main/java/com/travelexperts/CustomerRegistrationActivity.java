package com.travelexperts;

import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;

import com.travelexperts.model.Customer;

public class CustomerRegistrationActivity extends AppCompatActivity {

    EditText EditFirstName, EditLastName, EditAdd, EditCity, EditProvince, EditPostalCode, EditCountry, EditHomePhone,EditBusPhone, EditEmail, EditUserName, EditPassword;
    Button BtnSubmit, BtnReset;

    //CustomerDataSource source;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_customer_registration);


            //source = new CustomerDataSource(this);
            //source.helper.openDataBase();

            EditFirstName = findViewById(R.id.EditFirstName);
            EditLastName = findViewById(R.id.EditLastName);
            EditAdd = findViewById(R.id.EditAdd);
            EditCity = findViewById(R.id.EditCity);
            EditProvince = findViewById(R.id.EditProvince);
            EditPostalCode = findViewById(R.id.EditPostalCode);
            EditCountry = findViewById(R.id.EditCountry);
            EditHomePhone = findViewById(R.id.EditHomePhone);
            EditBusPhone = findViewById(R.id.EditBusPhone);
            EditEmail = findViewById(R.id.EditEmail);
            EditUserName = findViewById(R.id.EditUserName);
            EditPassword = findViewById(R.id.EditPassword);

            Customer c = (Customer) getIntent().getSerializableExtra("customer");

        EditFirstName.setText(c.getCustFirstName());
        EditLastName.setText(c.getCustLastName());
        EditAdd.setText(c.getCustAddress());
        EditCity.setText(c.getCustCity());
        EditProvince.setText(c.getCustProv());
        EditPostalCode.setText(c.getCustPostal());
        EditCountry.setText(c.getCustCountry());
        EditHomePhone.setText(c.getCustHomePhone());
        EditBusPhone.setText(c.getCustBusPhone());
        EditEmail.setText(c.getCustEmail());
        EditUserName.setText(c.getUserName());
        EditPassword.setText(c.getPassword());

            //add a click listener to the button to call
            //the datasource update method
            BtnSubmit = findViewById(R.id.BtnSubmit);
            BtnSubmit.setOnClickListener(new View.OnClickListener() {
                @Override
                public void onClick(View v) {
                    Customer cust = new Customer( EditFirstName.getText().toString(), EditLastName.getText().toString(),                            EditAdd.getText().toString(), EditCity.getText().toString(),
                            EditProvince.getText().toString(), EditPostalCode.getText().toString(),
                            EditCountry.getText().toString(), EditHomePhone.getText().toString(),
                            EditBusPhone.getText().toString(), EditEmail.getText().toString(),
                            EditUserName.getText().toString(),
                            EditPassword.getText().toString());


                }
            });
        }
    }
//}

package com.travelexperts;

import android.content.Intent;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;

import com.travelexperts.model.Agency;

public class AgencyDetailActivity extends AppCompatActivity {

    // variable declaration
    EditText EditAgencyId, EditAdd, EditCity, EditProvince, EditPostalCode,
            EditCountry, EditPhone, EditFax;
   // AgentDataSource source;
    Button BtnSubmit;


    // build UI
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_agency_detail);

           // source = new AgentDataSource(this);
           // source.getHelper().openDataBase();

            // find text-box components
            EditAgencyId = findViewById(R.id.EditAgencyId);
            EditAdd = findViewById(R.id.EditAdd);
            EditCity = findViewById(R.id.EditCity);
            EditProvince = findViewById(R.id.EditProvince);
            EditPostalCode = findViewById(R.id.EditPostalCode);
            EditCountry = findViewById(R.id.EditCountry);
            EditPhone = findViewById(R.id.EditPhone);
            EditFax = findViewById(R.id.EditFax);

            // bind Agent information to text-boxes
            Agency agency = (Agency) getIntent().getSerializableExtra("agency");
            EditAgencyId.setText(agency.getAgencyId() +  "");
            EditAdd.setText(agency.getAgncyAddress());
            EditCity.setText(agency.getAgncyCity());
            EditProvince.setText(agency.getAgncyProv());
            EditPostalCode.setText(agency.getAgancyPostal());
            EditCountry.setText(agency.getAgncyCountry());
            EditPhone.setText(agency.getAgancyPhone());
            EditFax.setText(agency.getAgancyFax() + "");

            //add a click listener to the button to call
            //the datasource update method
            BtnSubmit = findViewById(R.id.BtnSubmit);
            BtnSubmit.setOnClickListener(new View.OnClickListener() {
                @Override
                public void onClick(View v) {
                    Agency agency = new Agency(Integer.parseInt(EditAgencyId.getText().toString()),
                            EditAdd.getText().toString(), EditCity.getText().toString(),
                            EditProvince.getText().toString(), EditPostalCode.getText().toString(),
                            EditCountry.getText().toString(), EditPhone.getText().toString(),
                            EditFax.getText().toString());

                    if(true/*source.update(agency)*/) // successful
                        Utils.showMessage(AgencyDetailActivity.this,
                                "Agency Information was updated successful.");
                    else // un-successful update
                        Utils.showMessage(AgencyDetailActivity.this,
                                "Agency Information was updated unsuccessful.");


                    // come back to Main page
                    Intent intent = new Intent(getApplicationContext(), HomePage.class);
                    startActivity(intent);
                }
            });
        }
    }
//}

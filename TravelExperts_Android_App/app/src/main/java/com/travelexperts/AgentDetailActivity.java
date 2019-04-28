package com.travelexperts;

import android.content.Intent;
import android.os.Bundle;
import android.support.v7.app.AppCompatActivity;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;

import com.travelexperts.datasource.AgentDataSource;
import com.travelexperts.model.Agent;

public class AgentDetailActivity extends AppCompatActivity {

    // variable declaration
    EditText etAgentId, etAgentFName, etAgentMName, etAgentLName, etAgentPhoneNum,
            etAgentEmail, etAgentPosition, etAgencyId;
    AgentDataSource source;
    Button btnSave;

    // build UI
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_agent_detail);

        source = new AgentDataSource(this);
        source.getHelper().openDataBase();

        // find text-box components
        etAgentId = findViewById(R.id.etAgentId);
        etAgentFName = findViewById(R.id.etAgnFName);
        etAgentMName = findViewById(R.id.etAgnMName);
        etAgentLName = findViewById(R.id.etAgnLName);
        etAgentPhoneNum = findViewById(R.id.etAgnPhoneNum);
        etAgentEmail = findViewById(R.id.etAgnEmail);
        etAgentPosition = findViewById(R.id.etAgnPosition);
        etAgencyId = findViewById(R.id.etAgnAgencyId);

        // bind Agent information to text-boxes
        Agent agent = (Agent)getIntent().getSerializableExtra("agent");
        etAgentId.setText(agent.getAgentId() +  "");
        etAgentFName.setText(agent.getAgtFirstName());
        etAgentMName.setText(agent.getAgtMiddleInitial());
        etAgentLName.setText(agent.getAgtLastName());
        etAgentPhoneNum.setText(agent.getAgtBusPhone());
        etAgentEmail.setText(agent.getAgtEmail());
        etAgentPosition.setText(agent.getAgtPosition());
        etAgencyId.setText(agent.getAgencyId() + "");

        //add a click listener to the button to call
        //the datasource update method
        btnSave = findViewById(R.id.btnSave);
        btnSave.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                Agent agent = new Agent(Integer.parseInt(etAgentId.getText().toString()),
                        etAgentFName.getText().toString(), etAgentMName.getText().toString(),
                        etAgentLName.getText().toString(), etAgentPhoneNum.getText().toString(),
                        etAgentEmail.getText().toString(), etAgentPosition.getText().toString(),
                        Integer.parseInt(etAgencyId.getText().toString()), null, null);

                if(source.update(agent)) // successful
                    Utils.showMessage(AgentDetailActivity.this,
                            "Agent Information was updated successful.");
                else // un-successful update
                    Utils.showMessage(AgentDetailActivity.this,
                            "Agent Information was updated unsuccessful.");


                // come back to Main page
                Intent intent = new Intent(getApplicationContext(), MainActivity.class);
                startActivity(intent);
            }
        });
    }

}

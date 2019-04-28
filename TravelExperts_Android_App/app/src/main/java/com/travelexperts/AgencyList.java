package com.travelexperts;

import android.content.Intent;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.AdapterView;
import android.widget.ArrayAdapter;
import android.widget.ListView;

import com.travelexperts.model.Agency;
import com.travelexperts.model.Agent;

import java.util.ArrayList;

public class AgencyList extends AppCompatActivity {

    ListView agencyList;
    //AgentDataSource source;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_agencylist);

        agencyList = findViewById(R.id.lvAgency);
        //source = new AgentDataSource(this);

        ArrayList list = new ArrayList(); //source.getAllAgency();
        ArrayAdapter<Agency> adapter = new ArrayAdapter<>(this, android.R.layout.simple_list_item_1, list);
        agencyList.setAdapter(adapter);

        agencyList.setOnItemClickListener(new AdapterView.OnItemClickListener() {
            @Override
            public void onItemClick(AdapterView<?> parent, View view, int position, long id) {
                Intent intent = new Intent(getApplicationContext(), AgencyDetailActivity.class);
                intent.putExtra("agent", (Agent)agencyList.getAdapter().getItem(position));
                startActivity(intent);
            }
        });
    }
}

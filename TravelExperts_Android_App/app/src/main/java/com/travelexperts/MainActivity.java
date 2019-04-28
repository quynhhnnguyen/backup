package com.travelexperts;

import android.content.Intent;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.AdapterView;
import android.widget.ArrayAdapter;
import android.widget.ListView;

import com.travelexperts.datasource.AgentDataSource;
import com.travelexperts.model.Agent;

import java.util.ArrayList;
/**
 * Main Activity
 * Author: Quynh Nguyen(Queenie)
 * Date: 03-29-2019
 */
public class MainActivity extends AppCompatActivity {

    ListView lvAgents;
    ArrayAdapter<Agent> agents;

    // build UI
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        lvAgents = findViewById(R.id.lvAgents);

        // build a list view of agents
        /*AgentDataSource ds = new AgentDataSource(this);
        ArrayList<Agent> list = ds.getAllAgents();*/
        ArrayList<Agent> list = Utils.getAgentsRequest(this);
        agents = new ArrayAdapter<>(this, android.R.layout.simple_list_item_1, list);

        lvAgents.setAdapter(agents);

        lvAgents.setOnItemClickListener(new AdapterView.OnItemClickListener() {
            @Override
            public void onItemClick(AdapterView<?> parent, View view, int position, long id) {
                Intent intent = new Intent(getApplicationContext(), AgentDetailActivity.class);
                intent.putExtra("agent", (Agent)lvAgents.getAdapter().getItem(position));
                startActivity(intent);
            }
        });
    }
}

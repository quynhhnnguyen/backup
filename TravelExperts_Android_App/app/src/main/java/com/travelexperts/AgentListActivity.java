package com.travelexperts;

import android.content.Intent;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.AdapterView;
import android.widget.ArrayAdapter;
import android.widget.ListView;

import com.travelexperts.model.Agent;

import java.util.ArrayList;

public class AgentListActivity extends AppCompatActivity {

    ListView agentList;
    //AgentDataSource source;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_agentlist);
        agentList = findViewById(R.id.lvAgents);
        //source = new AgentDataSource(this);

        ArrayList list = new ArrayList();//source.getAllAgents();
        ArrayAdapter<Agent> adapter = new ArrayAdapter<>(this, android.R.layout.simple_list_item_1, list);
        agentList.setAdapter(adapter);

        agentList.setOnItemClickListener(new AdapterView.OnItemClickListener() {
            @Override
            public void onItemClick(AdapterView<?> parent, View view, int position, long id) {
                Intent intent = new Intent(getApplicationContext(), AgentDetailActivity.class);
                intent.putExtra("agent", (Agent)agentList.getAdapter().getItem(position));
                startActivity(intent);
            }
        });
    }
}

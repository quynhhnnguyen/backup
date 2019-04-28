package com.travelexperts.datasource;

import android.content.ContentValues;
import android.content.Context;
import android.database.Cursor;
import android.database.sqlite.SQLiteDatabase;

import com.travelexperts.DBHelper;
import com.travelexperts.model.Agent;

import java.util.ArrayList;

public class AgentDataSource {
    SQLiteDatabase db;
    DBHelper helper;

    public AgentDataSource(Context context) {
        helper = new DBHelper(context);
        helper.createDataBase();
        db = helper.getWritableDatabase();
    }

    public Agent getAgent(int agentId)
    {
        String[]args = { agentId + "" };
        String sql = "select * from Agents where AgentId=?";
        Cursor cursor = db.rawQuery(sql, args);
        cursor.moveToNext();
        return new Agent(cursor.getInt(0), cursor.getString(1), cursor.getString(2),
                cursor.getString(3), cursor.getString(4), cursor.getString(5),
                cursor.getString(6), cursor.getInt(7), null, null);
        /*int agentId, String agtFirstName, String agtMiddleInitial, String agtLastName,
                 String agtBusPhone, String agtEmail, String agtPosition, int agencyId*/
    }

    public ArrayList<Agent> getAllAgents()
    {
        ArrayList<Agent> list = new ArrayList<>();
        Cursor cursor = db.rawQuery("select * from Agents", null);
        while (cursor.moveToNext())
        {
            list.add(new Agent(cursor.getInt(0), cursor.getString(1),
                    cursor.getString(2),
                    cursor.getString(3), cursor.getString(4), cursor.getString(5),
                    cursor.getString(6), cursor.getInt(7), null, null));
        }
        return list;
    }

    public boolean update(Agent c)
    {
        ContentValues values = new ContentValues();

        values.put("agtFirstName", c.getAgtFirstName());
        values.put("agtMiddleInitial", c.getAgtMiddleInitial());
        values.put("agtLastName", c.getAgtLastName());
        values.put("agtBusPhone", c.getAgtBusPhone());
        values.put("agtEmail", c.getAgtEmail());
        values.put("agtPosition", c.getAgtPosition());
        values.put("agencyId", c.getAgencyId());

        String where = "AgentId=?";
        String [] whereArgs = { c.getAgentId() + ""};

        return db.update("Agents", values, where, whereArgs) > 0;
    }

    public DBHelper getHelper() {
        return helper;
    }
}

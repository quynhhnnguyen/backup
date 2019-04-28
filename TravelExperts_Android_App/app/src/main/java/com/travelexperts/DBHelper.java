package com.travelexperts;

import android.content.Context;
import android.database.sqlite.SQLiteDatabase;
import android.database.sqlite.SQLiteOpenHelper;
import android.util.Log;

import java.io.FileOutputStream;
import java.io.IOException;
import java.io.InputStream;
import java.io.OutputStream;
/**
 * Database Helper class to copy database, handle database connection
 * Author: Quynh Nguyen(Queenie)
 * Date: 03-29-2019
 */
public class DBHelper extends SQLiteOpenHelper {
    // Variable declaration
    private static String name = "TravelExpertsSqlLite.db";
    private static String path = "/data/data/com.example.assignment13/databases/";
    private final Context myContext;
    private SQLiteDatabase myDatabase;

    // construction
    public DBHelper(Context context) {
        super(context, name, null, 1);
        this.myContext = context;
    }

    // create database
    public void createDataBase()
    {
        if (dbExists())
        {
            //do nothing
        }
        else
        {
            copyDatabase();
        }
    }

    // copy database
    private void copyDatabase() {
        try {
            InputStream myInput = myContext.getAssets().open(name);
            OutputStream myOutput = new FileOutputStream(path + name);

            byte [] buffer = new byte[1024];
            int length;
            while ((length = myInput.read(buffer))>0)
            {
                myOutput.write(buffer, 0, length);
            }

            myOutput.flush();
            myOutput.close();
            myInput.close();
        } catch (IOException e) {
            e.printStackTrace();
        }
    }

    // check if database exists or not
    private boolean dbExists() {
        SQLiteDatabase checkdb = null;
        try {
            checkdb = SQLiteDatabase.openDatabase(path + name, null, SQLiteDatabase.OPEN_READONLY);
            Log.d("DBHelper", "check DB existence: " + checkdb);
        } catch (Exception e) {
            e.printStackTrace();
        }
        if (checkdb != null)
        {
            checkdb.close();
        }
        return checkdb != null ? true : false;
    }

    // open connection
    public void openDataBase()
    {
        myDatabase = SQLiteDatabase.openDatabase(path + name, null, SQLiteDatabase.OPEN_READWRITE);
    }


    @Override
    public void onCreate(SQLiteDatabase db) {

    }

    @Override
    public void onUpgrade(SQLiteDatabase db, int oldVersion, int newVersion) {

    }
}

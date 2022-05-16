package com.example.calculationsquare;

import androidx.appcompat.app.AppCompatActivity;
import android.content.ContentValues;
import android.database.Cursor;
import android.database.sqlite.SQLiteDatabase;
import android.os.Bundle;
import android.provider.BaseColumns;
import android.provider.ContactsContract;
import android.text.method.ScrollingMovementMethod;
import android.util.Log;
import android.view.View;
import android.widget.EditText;
import android.widget.TextView;
import android.widget.Toast;
import static java.lang.Math.sqrt;

public class MainActivity extends AppCompatActivity {

    EditText textX1;
    EditText textX2;
    EditText textX3;

    TextView numberX1;
    TextView numberX2;
    TextView history;

    SQLiteDatabase database;
    DatabaseHelper DBHelper;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        textX1 = (EditText)findViewById(R.id.numberX1);
        textX2 = (EditText)findViewById(R.id.numberX2);
        textX3 = (EditText)findViewById(R.id.numberX3);

        numberX1 = (TextView) findViewById(R.id.textNumberX1);
        numberX2 = (TextView) findViewById(R.id.textNumberX2);
        history = (TextView) findViewById(R.id.history);

        history.setMovementMethod(new ScrollingMovementMethod());

        DBHelper = new DatabaseHelper(this);
        database = DBHelper.getWritableDatabase();
    }

    public void onButtonClick(View v) {
        try {
            ContentValues contentValues = new ContentValues();

            double x1 = Double.parseDouble(textX1.getText().toString());
            double x2 = Double.parseDouble(textX2.getText().toString());
            double x3 = Double.parseDouble(textX3.getText().toString());
            double D, resultX1, resultX2;

            x1 = Math.round(x1 * 100.0) / 100.0;
            x2 = Math.round(x2 * 100.0) / 100.0;
            x3 = Math.round(x3 * 100.0) / 100.0;
            contentValues.put(DBHelper.COLUMN_A, x1);
            contentValues.put(DBHelper.COLUMN_B, x2);
            contentValues.put(DBHelper.COLUMN_C, x3);

            if (x1!=0) {
                D = x2*x2-4*x1*x3;
                if(D>0) {
                    resultX1=(-x2+sqrt(D))/(2*x1);
                    resultX2=(-x2-sqrt(D))/(2*x1);
                    resultX1 = Math.round(resultX1 * 100.0) / 100.0;
                    resultX2 = Math.round(resultX2 * 100.0) / 100.0;
                    numberX1.setText(String.valueOf(resultX2));
                    numberX2.setText(String.valueOf(resultX1));
                    contentValues.put(DBHelper.COLUMN_RESULTX1, resultX1);
                    contentValues.put(DBHelper.COLUMN_RESULTX2, resultX2);
                    database.insert(DBHelper.TABLE_CONTACTS,null,contentValues);
                    history.append(" "+x1 + "x^2+"+x2+"x+"+x3+"=0"+"\n");
                    history.append(" x1= " + resultX2 + ", x2= " + resultX1 + ";\n");
                    history.append("-----------------------------------------------------------------\n");
                } else if (D==0) {
                    resultX1=resultX2=x2/(2*x1);
                    resultX1 = Math.round(resultX1 * 100.0) / 100.0;
                    resultX2 = Math.round(resultX2 * 100.0) / 100.0;
                    numberX1.setText(String.valueOf(resultX2));
                    numberX2.setText(String.valueOf(resultX1));
                    contentValues.put(DBHelper.COLUMN_RESULTX1, resultX1);
                    contentValues.put(DBHelper.COLUMN_RESULTX2, resultX2);
                    database.insert(DBHelper.TABLE_CONTACTS,null,contentValues);
                    history.append(" "+x1 + "x^2+"+x2+"x+"+x3+"=0"+"\n");
                    history.append(" x1=x2= " + resultX1 + ";\n");
                    history.append("-----------------------------------------------------------------\n");
                } else if (D<0) {
                    numberX1.setText("-");
                    numberX2.setText("-");
                    resultX1=resultX2=0;
                    contentValues.put(DBHelper.COLUMN_RESULTX1, resultX1);
                    contentValues.put(DBHelper.COLUMN_RESULTX2, resultX2);
                    database.insert(DBHelper.TABLE_CONTACTS,null,contentValues);
                    history.append(" "+x1 + "x^2+"+x2+"x+"+x3+"=0"+"\n");
                    history.append(" x1 and x2 has no roots;\n");
                    history.append("-----------------------------------------------------------------\n");
                    Toast toast = Toast.makeText(getApplicationContext(),"D<0 this has no roots",Toast.LENGTH_LONG);
                    toast.show();
                }
            }
        } catch (NumberFormatException e) {
            Toast toast = Toast.makeText(getApplicationContext(),"Please enter correct number",Toast.LENGTH_SHORT);
            toast.show();
        }
    }
    public void onShowDBButtonClick (View v){
        Cursor cursor = database.query(DBHelper.TABLE_CONTACTS, null, null, null, null,null,null,null);
        if(cursor.moveToFirst()) {
            int AInd = cursor.getColumnIndexOrThrow(DBHelper.COLUMN_A);
            int BInd = cursor.getColumnIndex(DBHelper.COLUMN_B);
            int CInd = cursor.getColumnIndex(DBHelper.COLUMN_C);
            int resultX1Ind = cursor.getColumnIndex(DBHelper.COLUMN_RESULTX1);
            int resultX2Ind = cursor.getColumnIndex(DBHelper.COLUMN_RESULTX2);
            DBHelper.getReadableDatabase();
            database.insert(DBHelper.TABLE_CONTACTS,null,null);
            do {
                history.append(" (" + cursor.getDouble( AInd) + ")x^2+(" + cursor.getDouble(BInd) + ")x+(" + cursor.getDouble(CInd) + ")=0,\n" +
                        "x1= "+ cursor.getDouble(resultX2Ind) + ", x2= " + cursor.getDouble(resultX1Ind) + " \n");
                history.append("-----------------------------------------------------------------\n");
            } while (cursor.moveToNext());
        } else {
            history.append("Database not contains value.\n");
            history.append("-----------------------------------------------------------------\n");
        }
        cursor.close();
    }

    public void onClearButtonClick (View v) {
        history.setText("");
    }

    public void onClearDBButtonClick (View v) {
        database.delete(DBHelper.TABLE_CONTACTS, null, null);
    }
}
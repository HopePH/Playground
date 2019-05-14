package com.example.addcalculator;

import android.os.Bundle;
import android.support.v7.app.AppCompatActivity;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.TextView;

public class MainActivity extends AppCompatActivity {

    EditText number1;
    EditText number2;
    Button Add_button;
    TextView result;
    Button Clear_button;
    private Bundle savedIntanceState;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        number1=(EditText) findViewById(R.id.edit_text);
        number2=(EditText) findViewById(R.id.edit_text2);
        Add_button=(Button) findViewById(R.id.button);
        result=(TextView) findViewById(R.id.textView_answer);

        Add_button.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                double num1 = Double.parseDouble(number1.getText().toString());
                double num2 = Double.parseDouble(number2.getText().toString());

                double sum = num1 + num2;

                result.setText(Double.toString(sum));

            }
        });

        {
            final EditText edit_text = (EditText) findViewById(R.id.edit_text);
            final EditText edit_text2 = (EditText) findViewById(R.id.edit_text2);
            final TextView textView_answer = (TextView) findViewById(R.id.textView_answer);
            Clear_button = (Button) findViewById(R.id.button2);

            Clear_button.setOnClickListener(new View.OnClickListener() {
                @Override
                public void onClick(View v) {
                    edit_text.setText("");
                    edit_text2.setText("");
                    textView_answer.setText("");
                }
            });
        }
    }



}

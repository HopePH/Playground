package com.example.addcalculator;

import android.os.Bundle;
import android.support.v7.app.AppCompatActivity;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.TextView;

import com.example.arithmetic.Arithmetic;

import static java.lang.Integer.parseInt;

public class MainActivity extends AppCompatActivity {
    EditText number1;
    EditText number2;
    Button Add_button;
    TextView result;
    Button Clear_button;

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
                Arithmetic arithmetic = new Arithmetic();
                int num1 = parseInt(number1.getText().toString());
                int num2 = parseInt(number2.getText().toString());
                arithmetic.SetNumber1(num1);
                arithmetic.SetNumber2(num2);
                result.setText(arithmetic.Add());
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

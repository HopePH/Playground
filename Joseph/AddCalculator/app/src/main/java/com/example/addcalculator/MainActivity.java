package com.example.addcalculator;

import android.os.Bundle;
import android.support.v7.app.AppCompatActivity;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.TextView;
import android.widget.Toast;

import com.example.arithmetic.Arithmetic;
import com.example.arithmetic.Divide;
import com.example.arithmetic.Multiply;
import com.example.arithmetic.Subtract;
import static java.lang.Integer.parseInt;

public class MainActivity extends AppCompatActivity {
    EditText number1;
    EditText number2;
    Button Add_button;
    TextView result;
    Button Clear_button;
    Button Sub_button;
    Button Multiply_button;
    Button Divide_button;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        number1 = findViewById(R.id.edit_text);
        number2 = findViewById(R.id.edit_text2);
        Add_button = findViewById(R.id.button);
        Sub_button = findViewById(R.id.button4);
        Multiply_button = findViewById(R.id.button3);
        Divide_button = findViewById(R.id.button5);
        result = findViewById(R.id.textView_answer);

        Add_button.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                    Arithmetic arithmetic = new Arithmetic();
                    arithmetic.SetNumber1(parseInt(number1.getText().toString()));
                    arithmetic.SetNumber2(parseInt(number2.getText().toString()));
                    result.setText(String.valueOf(arithmetic.Add()));
            }
        });

        Sub_button.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                Subtract subtract = new Subtract();
                int num1 = parseInt(number1.getText().toString());
                int num2 = parseInt(number2.getText().toString());
                subtract.SetNumber1(num1);
                subtract.SetNumber2(num2);
                result.setText(String.valueOf(num1 - num2));
            }
        });

        Multiply_button.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                Multiply multiply = new Multiply();
                int num1 = parseInt(number1.getText().toString());
                int num2 = parseInt(number2.getText().toString());
                multiply.SetNumber1(num1);
                multiply.SetNumber2(num2);
                result.setText(String.valueOf(num1 * num2));
            }
        });

        Divide_button.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                Divide divide = new Divide();
                int num1 = parseInt(number1.getText().toString());
                int num2 = parseInt(number2.getText().toString());
                divide.SetNumber1(num1);
                divide.SetNumber2(num2);
                result.setText(String.valueOf(num1 / num2));
            }
        });

        {
            final EditText edit_text = findViewById(R.id.edit_text);
            final EditText edit_text2 = findViewById(R.id.edit_text2);
            final TextView textView_answer = findViewById(R.id.textView_answer);
            Clear_button = findViewById(R.id.button2);

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

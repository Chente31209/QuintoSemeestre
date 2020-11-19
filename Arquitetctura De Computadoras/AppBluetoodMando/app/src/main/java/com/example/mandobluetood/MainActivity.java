package com.example.mandobluetood;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.view.View;
import android.widget.*;

public class MainActivity extends AppCompatActivity {

     Button btnBuscar;
     Button btnConetar;
     EditText txt;
     Button btnAriba ,btnDereha,btnIzquierda,btnStop,BtnDereha;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
         btnBuscar = (Button) findViewById(R.id.Buscar);
         btnConetar = (Button) findViewById(R.id.Conetar);
         txt = (EditText) findViewById(R.id.lista);

         btnBuscar.setOnClickListener(new View.OnClickListener() {
             @Override
             public void onClick(View view) {
                 txt.setText("Hola Soy un boton");
             }
         });

    }




}
package com.example.practik_7

import android.content.Intent
import android.os.Bundle
import android.widget.Button
import android.widget.EditText
import androidx.activity.enableEdgeToEdge
import androidx.appcompat.app.AppCompatActivity
import androidx.core.view.ViewCompat
import androidx.core.view.WindowInsetsCompat


class ekranregistr : AppCompatActivity() {
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        enableEdgeToEdge()
        setContentView(R.layout.activity_ekranregistr)
        ViewCompat.setOnApplyWindowInsetsListener(findViewById(R.id.main)) { v, insets ->
            val systemBars = insets.getInsets(WindowInsetsCompat.Type.systemBars())
            v.setPadding(systemBars.left, systemBars.top, systemBars.right, systemBars.bottom)
            insets
        }
        val butReg: Button = findViewById(R.id.button2)
        val textLogin: EditText = findViewById(R.id.editTextText2)
        val textPas: EditText = findViewById(R.id.editTextText3)

        butReg.setOnClickListener {
            val newlogin = textLogin.text.toString()
            val newpas = textPas.text.toString()
            val connect = Intent(this, MainActivity::class.java)
            connect.putExtra("1", newlogin)
            connect.putExtra("2", newpas)
            startActivity(connect)


        }
    }
}
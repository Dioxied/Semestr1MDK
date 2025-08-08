package com.example.mypets

import android.annotation.SuppressLint
import android.os.Bundle
import android.widget.Button
import android.widget.TextView
import androidx.activity.enableEdgeToEdge
import androidx.appcompat.app.AppCompatActivity
import androidx.core.view.ViewCompat
import androidx.core.view.WindowInsetsCompat

class MainActivity : AppCompatActivity() {
    @SuppressLint("MissingInflatedId")
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        enableEdgeToEdge()
        setContentView(R.layout.activity_main)
        ViewCompat.setOnApplyWindowInsetsListener(findViewById(R.id.main)) { v, insets ->
            val systemBars = insets.getInsets(WindowInsetsCompat.Type.systemBars())
            v.setPadding(systemBars.left, systemBars.top, systemBars.right, systemBars.bottom)
            insets
        }

    var lst = listOf("🐷", "🐱", "\uD83D\uDC39", "\uD83D\uDC30", "\uD83D\uDC2E", "\uD83D\uDC2D", "\uD83E\uDD8A", "\uD83D\uDC17")
    var are: TextView = findViewById(R.id.textView)
    var i = 0
    var BNext: Button = findViewById(R.id.button2)
    var BBack: Button = findViewById(R.id.button)
    are.text = lst[i]
    BNext.setOnClickListener {
        i++
        if (i == lst.size){
            i = 0
        }
        are.text = lst[i]
    }
    BBack.setOnClickListener {
        i--
        if (i == -1) {
            i = lst.size - 1
        }
        are.text = lst[i]
    }

    }
}
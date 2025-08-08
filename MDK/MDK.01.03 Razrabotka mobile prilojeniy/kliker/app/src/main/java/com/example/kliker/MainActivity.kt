package com.example.kliker

import android.annotation.SuppressLint
import android.graphics.Color
import android.os.Bundle
import android.widget.Button
import android.widget.TextView
import androidx.activity.enableEdgeToEdge
import androidx.appcompat.app.AppCompatActivity
import androidx.core.view.ViewCompat
import androidx.core.view.WindowInsetsCompat

class MainActivity : AppCompatActivity() {
    private lateinit var ClickB : Button
    private lateinit var ClickReset : Button
    private lateinit var counterText : TextView
    private lateinit var textResult : TextView
    private lateinit var ClickUp : Button
    private lateinit var textUp : TextView
    private lateinit var textCountClick : TextView


    private var priceUp = 50
    private var clickOne = 1
    private var Count = 0


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
        ClickB = findViewById(R.id.button)
        counterText = findViewById(R.id.textView)
        textResult = findViewById(R.id.textView2)
        textUp = findViewById(R.id.textView3)
        ClickReset = findViewById(R.id.button2)
        ClickUp = findViewById(R.id.button3)
        textCountClick = findViewById(R.id.textView4)


        ClickB.setOnClickListener {
            Count+= clickOne
            counterText.text = "Количество тапов: $Count"

            if (Count % 50 == 0 && Count >= 100){
            textResult.text = "$Count ТАПОВ!!!!\nХомяк гордится тобой!!!"
            }
            else if (100 > Count && Count >= 75){
                textResult.text = "Ого, 75 тапов!\nХомяк очень доволен"
            }
            else if (100 > Count && Count >= 50) {
                textResult.text = "Поздравляю, ты набрал 50 тапов\nХомяк доволен тобой"
            }

            if (Count < priceUp){
                ClickUp.setTextColor(Color.RED)
                textUp.text = "Стоймость Апгрейда $priceUp"
            }
            else {
                ClickUp.setTextColor(Color.GREEN)
                textUp.text = "Доступен Апгрейд!"
            }
            textCountClick.text = "Кликов за один тап: $clickOne"

        }
        ClickReset.setOnClickListener {
            Count = 0
            counterText.text = "Количество тапов: $Count"
            textResult.text = ""
            priceUp = 50
            clickOne = 1
        }
        ClickUp.setOnClickListener {
            if (priceUp <= Count) {
                clickOne *=2
                priceUp *=3
                textCountClick.text = "Кликов за один тап: $clickOne"
                textUp.text = "Стоймость Апгрейда $priceUp"
            }
        }
    }
}
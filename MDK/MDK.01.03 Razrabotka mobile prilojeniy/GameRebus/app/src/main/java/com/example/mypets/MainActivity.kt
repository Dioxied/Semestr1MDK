package com.example.mypets

import android.annotation.SuppressLint
import android.os.Bundle
import android.widget.Button
import android.widget.EditText
import android.widget.ImageView
import android.widget.TextView
import android.widget.Toast
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

        var Rebus = listOf(R.drawable.img1, R.drawable.img2, R.drawable.img3, R.drawable.img4, R.drawable.img5, R.drawable.img6, R.drawable.img7)
        var otvet = listOf("снегурочка", "скворец", "кисточка", "клык", "блокнот", "переход", "стол")

        val image = findViewById<ImageView>(R.id.imageView)
        val vvod = findViewById<EditText>(R.id.editTextText)
        val But = findViewById<Button>(R.id.button)
        val Count = findViewById<TextView>(R.id.textView)


        var wiwi = ""
        var cou = 0
        var i = 0

        vvod.setOnClickListener {
            vvod.setText("")
        }
        But.setOnClickListener {
            wiwi = vvod.text.toString()
            if (wiwi == otvet[i]){
                i++
                if (i == otvet.size) {
                    i = 0
                    if (cou == 21) {
                        Toast.makeText(applicationContext, "Красавчик", Toast.LENGTH_LONG).show()
                    } else if (cou > 11) {
                        Toast.makeText(applicationContext, "Неплохо", Toast.LENGTH_LONG).show()
                    } else if (cou > 0) {
                        Toast.makeText(applicationContext, "Пойдет", Toast.LENGTH_LONG).show()
                    } else {Toast.makeText(applicationContext,"Тебе нужно тренироваться",Toast.LENGTH_LONG).show()}
                }
                image.setImageResource(Rebus[i])
                vvod.setText("")
                cou += 3

            }
            else{cou -= 5}
            Count.setText("Count $cou")
        }

    }
}
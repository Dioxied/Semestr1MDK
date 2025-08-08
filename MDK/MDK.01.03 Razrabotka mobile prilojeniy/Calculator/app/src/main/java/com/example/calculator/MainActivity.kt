package com.example.calculator

import android.os.Bundle
import android.widget.Button
import android.widget.TextView
import androidx.activity.enableEdgeToEdge
import androidx.appcompat.app.AppCompatActivity
import androidx.core.view.ViewCompat
import androidx.core.view.WindowInsetsCompat



class MainActivity : AppCompatActivity() {
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        enableEdgeToEdge()
        setContentView(R.layout.activity_main)
        ViewCompat.setOnApplyWindowInsetsListener(findViewById(R.id.main)) { v, insets ->
            val systemBars = insets.getInsets(WindowInsetsCompat.Type.systemBars())
            v.setPadding(systemBars.left, systemBars.top, systemBars.right, systemBars.bottom)
            insets
        }
        fun umn(sp: MutableList<Any>) {
            val index = sp.indexOf("×")
            val el = (sp[index - 1] as Float) * (sp[index + 1] as Float)
            sp.removeAt(index - 1)
            sp.removeAt(index)
            sp[index - 1] = el
        }
        fun delen(sp: MutableList<Any>) {
            val index = sp.indexOf("/")
            val el = (sp[index - 1] as Float) / (sp[index + 1] as Float)
            sp.removeAt(index - 1)
            sp.removeAt(index)
            sp[index - 1] = el
        }
        fun plus(sp: MutableList<Any>) {
            val index = sp.indexOf("+")
            val el = (sp[index - 1] as Float) + (sp[index + 1] as Float)
            sp.removeAt(index - 1)
            sp.removeAt(index)
            sp[index - 1] = el
        }
        fun minus(sp: MutableList<Any>) {
            val index = sp.indexOf("-")
            val el = (sp[index - 1] as Float) - (sp[index + 1] as Float)
            sp.removeAt(index - 1)
            sp.removeAt(index)
            sp[index - 1] = el
        }
        fun procent(sp: MutableList<Any>) {
            val index = sp.indexOf("%")
            val el = (sp[index - 1] as Float) * (sp[index + 1] as Float) / 100
            sp.removeAt(index - 1)
            sp.removeAt(index)
            sp[index - 1] = el
        }
        fun solveurav(uravnenie:String) : String {
            val urav = uravnenie + "["
            val sp = mutableListOf<Any>()
            var r = ""
            for (i in urav) {
                if (i.isDigit() || i == '.') {
                    r += i
                } else {
                    if (r.isNotEmpty()) {
                        sp.add(r.toFloat())
                        r = ""
                    }
                    sp.add(i.toString())
                }
            }
            sp.removeAt(sp.size - 1)
            while (sp.size > 1) {
                when {
                    "%" in sp -> procent(sp)
                    "×" in sp || "/" in sp -> {
                        when {
                            "×" in sp && "/" in sp -> {
                                if (sp.indexOf("×") < sp.indexOf("/")) umn(sp) else delen(sp)
                            }
                            "×" in sp -> umn(sp)
                            "/" in sp -> delen(sp)
                        }
                    }
                    "+" in sp || "-" in sp -> {
                        when {
                            "+" in sp && "-" in sp -> {
                                if (sp.indexOf("+") < sp.indexOf("-")) plus(sp) else minus(sp)
                            }
                            "+" in sp -> plus(sp)
                            "-" in sp -> minus(sp)
                        }
                    }
                }
            }
            if (sp[0].toString() == "Infinity"){return "Ошибка"}
            else{return sp[0].toString()}
        }

        var but_0: Button = findViewById(R.id.but_0)
        var but_1: Button = findViewById(R.id.but_1)
        var but_2: Button = findViewById(R.id.but_2)
        var but_3: Button = findViewById(R.id.but_3)
        var but_4: Button = findViewById(R.id.but_4)
        var but_5: Button = findViewById(R.id.but_5)
        var but_6: Button = findViewById(R.id.but_6)
        var but_7: Button = findViewById(R.id.but_7)
        var but_8: Button = findViewById(R.id.but_8)
        var but_9: Button = findViewById(R.id.but_9)
        var but_C: Button = findViewById(R.id.but_C)
        var but_procent: Button = findViewById(R.id.but_procent)
        var but_back: Button = findViewById(R.id.but_back)
        var but_delen: Button = findViewById(R.id.but_delen)
        var but_umnoj: Button = findViewById(R.id.but_umnoj)
        var but_minus: Button = findViewById(R.id.but_minus)
        var but_plus: Button = findViewById(R.id.but_plus)
        var but_ravno: Button = findViewById(R.id.but_ravno)
        var but_sapat: Button = findViewById(R.id.but_sapat)
        var texturavinprog = findViewById<TextView>(R.id.texturav)
        var predResultinprog = findViewById<TextView>(R.id.predResult)

        var texturav = ""
        var textResult = ""
        var sizetexturav = 96

        fun printTextInProgram(text : String = texturav){
            if (texturav.length == 0){texturavinprog.setText("0")}
            else{
            texturavinprog.setText(text)}

        }
        fun printTextInResultProgram(text: String){
            if (text.length >2){
            predResultinprog.setText(text)}
        }

        but_0.setOnClickListener {
            if (texturav.length == 6 || texturav.length == 8 || texturav.length == 10){
                sizetexturav -= 20
                texturavinprog.setTextSize(sizetexturav.toFloat())
            }
            texturav += "0"
            printTextInProgram()
            try{
                printTextInResultProgram(solveurav(texturav))
            }
            catch (e: Exception){}
        }
        but_1.setOnClickListener {
            if (texturav.length == 6 || texturav.length == 8 || texturav.length == 10){
                sizetexturav -= 20
                texturavinprog.setTextSize(sizetexturav.toFloat())
            }
            texturav += "1"
            printTextInProgram()
            try{
                printTextInResultProgram(solveurav(texturav))
            }
            catch (e: Exception){}
        }
        but_2.setOnClickListener {
            if (texturav.length == 6 || texturav.length == 8 || texturav.length == 10){
                sizetexturav -= 20
                texturavinprog.setTextSize(sizetexturav.toFloat())
            }
            texturav += "2"
            printTextInProgram()
            try{
                printTextInResultProgram(solveurav(texturav))
            }
            catch (e: Exception){}
        }
        but_3.setOnClickListener {
            if (texturav.length == 6 || texturav.length == 8 || texturav.length == 10){
                sizetexturav -= 20
                texturavinprog.setTextSize(sizetexturav.toFloat())
            }
            texturav += "3"
            printTextInProgram()
            try{
                printTextInResultProgram(solveurav(texturav))
            }
            catch (e: Exception){}
        }
        but_4.setOnClickListener {
            if (texturav.length == 6 || texturav.length == 8 || texturav.length == 10){
                sizetexturav -= 20
                texturavinprog.setTextSize(sizetexturav.toFloat())
            }
            texturav += "4"
            printTextInProgram()
            try{
                printTextInResultProgram(solveurav(texturav))
            }
            catch (e: Exception){}
        }
        but_5.setOnClickListener {
            if (texturav.length == 6 || texturav.length == 8 || texturav.length == 10){
                sizetexturav -= 20
                texturavinprog.setTextSize(sizetexturav.toFloat())
            }
            texturav += "5"
            printTextInProgram()
            try{
                printTextInResultProgram(solveurav(texturav))
            }
            catch (e: Exception){}
        }
        but_6.setOnClickListener {
            if (texturav.length == 6 || texturav.length == 8 || texturav.length == 10){
                sizetexturav -= 20
                texturavinprog.setTextSize(sizetexturav.toFloat())
            }
            texturav += "6"
            printTextInProgram()
            try{
                printTextInResultProgram(solveurav(texturav))
            }
            catch (e: Exception){}
        }
        but_7.setOnClickListener {
            if (texturav.length == 6 || texturav.length == 8 || texturav.length == 10){
                sizetexturav -= 20
                texturavinprog.setTextSize(sizetexturav.toFloat())
            }
            texturav += "7"
            printTextInProgram()
            try{
                printTextInResultProgram(solveurav(texturav))
            }
            catch (e: Exception){}
        }
        but_8.setOnClickListener {
            if (texturav.length == 6 || texturav.length == 8 || texturav.length == 10){
                sizetexturav -= 20
                texturavinprog.setTextSize(sizetexturav.toFloat())
            }
            texturav += "8"
            printTextInProgram()
            try{
                printTextInResultProgram(solveurav(texturav))
            }
            catch (e: Exception){}
        }
        but_9.setOnClickListener {
            if (texturav.length == 6 || texturav.length == 8 || texturav.length == 10){
                sizetexturav -= 20
                texturavinprog.setTextSize(sizetexturav.toFloat())
            }
            texturav += "9"
            printTextInProgram()
            try{
                printTextInResultProgram(solveurav(texturav))
            }
            catch (e: Exception){}
        }
        but_C.setOnClickListener {
            texturav = ""
            sizetexturav = 96
            texturavinprog.setTextSize(sizetexturav.toFloat())
            printTextInProgram()
        }
        but_back.setOnClickListener {
            try{var txt = texturav.substring(0, texturav.length-1)
                texturav = txt}
            catch (e:Exception){
                texturav=""
            }

            if (texturav.length == 6 || texturav.length == 8 || texturav.length == 10){
                sizetexturav += 20
                texturavinprog.setTextSize(sizetexturav.toFloat())}
                printTextInResultProgram("$sizetexturav")
            printTextInProgram()


        }
        but_delen.setOnClickListener {
            if (texturav.length == 6 || texturav.length == 8 || texturav.length == 10){
                sizetexturav -= 20
                texturavinprog.setTextSize(sizetexturav.toFloat())
            }
            if ('/' in texturav){
                if (texturav[texturav.length-1] == '/'){}
                else{texturav += "/"}
            }
            else if (texturav.length == 0){}
            else{texturav += "/"}
            printTextInProgram()
        }
        but_plus.setOnClickListener {
            if (texturav.length == 6 || texturav.length == 8 || texturav.length == 10){
                sizetexturav -= 20
                texturavinprog.setTextSize(sizetexturav.toFloat())
            }
            if ('+' in texturav){
                if (texturav[texturav.length-1] == '+'){}
                else{texturav += "+"}
            }
            else if (texturav.length == 0){}
            else{texturav += "+"}
            printTextInProgram()
        }
        but_minus.setOnClickListener {
            if (texturav.length == 6 || texturav.length == 8 || texturav.length == 10){
                sizetexturav -= 20
                texturavinprog.setTextSize(sizetexturav.toFloat())
            }
            if ('-' in texturav){
                if (texturav[texturav.length-1] == '-'){}
                else{texturav += "-"}
            }
            else if (texturav.length == 0){texturav+="0-"}
            else{texturav += "-"}
            printTextInProgram()
        }
        but_umnoj.setOnClickListener {
            if (texturav.length == 6 || texturav.length == 8 || texturav.length == 10){
                sizetexturav -= 20
                texturavinprog.setTextSize(sizetexturav.toFloat())
            }
            if ('×' in texturav){
                if (texturav[texturav.length-1] == '×'){}
                else{texturav += "×"}
            }
            else if (texturav.length == 0){}
            else{texturav += "×"}
            printTextInProgram()
        }
        but_sapat.setOnClickListener {
            if (texturav.length == 6 || texturav.length == 8 || texturav.length == 10){
                sizetexturav -= 20
                texturavinprog.setTextSize(sizetexturav.toFloat())
            }
            if ("." in texturav){}
            else{texturav += "."}
            printTextInProgram()
        }
        but_procent.setOnClickListener {
            if (texturav.length == 6 || texturav.length == 8 || texturav.length == 10){
                sizetexturav -= 20
                texturavinprog.setTextSize(sizetexturav.toFloat())
            }
            if ('%' in texturav){
                if (texturav[texturav.length-1] == '%'){}
                else{texturav += "%"}
            }
            else if (texturav.length == 0){}
            else{texturav += "%"}
            printTextInProgram()
        }
        but_ravno.setOnClickListener {
            try{
                var t : String = solveurav(texturav)
                if (t.length <= 6){
                    sizetexturav = 96
                    texturavinprog.setTextSize(sizetexturav.toFloat())
                }
                else if (t.length <= 8){
                    sizetexturav = 76
                    texturavinprog.setTextSize(sizetexturav.toFloat())
                }
                else if (t.length <= 10){
                    sizetexturav = 56
                    texturavinprog.setTextSize(sizetexturav.toFloat())
                }
                else{
                    sizetexturav = 36
                    texturavinprog.setTextSize(sizetexturav.toFloat())
                }
                printTextInResultProgram("   ")
                printTextInProgram(t)
                texturav = t
            }
            catch (e: Exception){}
        }

    }
}
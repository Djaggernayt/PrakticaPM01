package com.example.kasmartlab

import android.content.Intent
import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.os.CountDownTimer
import android.view.View
import android.widget.Button
import android.widget.TextView
import android.widget.Toast

class password : AppCompatActivity() {
    //28.03.2023 Калинин Арсений Олегович Описание: переменные для объектов страницы
    lateinit var textView: TextView
    lateinit var button: Button
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_password)

        textView= findViewById(R.id.viewtimer)
        button = findViewById(R.id.postcode)
        //28.03.2023 Калинин Арсений Олегович Описание: старт таймера
        onTick()
    }
//28.03.2023 Калинин Арсений Олегович Описание: таймер
    fun onTick(){
        object : CountDownTimer(60000,1000){
            override fun onTick(p0: Long) {
                button.visibility = View.GONE
                textView.visibility = View.VISIBLE
                textView.text = "Отправить код повторно можно будет через "+ p0/1000+ " секунд"
            }

            override fun onFinish() {
               button.visibility = View.VISIBLE
               textView.visibility = View.GONE
                Toast.makeText(applicationContext,"Можно отправить повторно", Toast.LENGTH_SHORT).show()
            }
        }.start()
    }
    //28.03.2023 Калинин Арсений Олегович Описание: повторная отправка кода
    fun onTime(view:View){
        onTick()
        Toast.makeText(this,"Код успешно отправлен", Toast.LENGTH_SHORT).show()
    }
    //28.03.2023 Калинин Арсений Олегович Описание: проверка кода и переход в окно создания пароля
    fun onEnter(view: View){
        val intent = Intent(this,PassCreate::class.java)
        startActivity(intent)
    }

}
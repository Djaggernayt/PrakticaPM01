package com.example.kasmartlab

import android.content.Intent
import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.view.View
import android.widget.Button
import android.widget.ImageView
import android.widget.TextView

class MainActivity : AppCompatActivity() {
    //28.03.2023 Калинин Арсений Олегович Описание: итератор
    var i=0
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_main)
    }
    fun onSkip(view: View){
        //28.03.2023 Калинин Арсений Олегович Описание: переход на страницу Вход и регистрация
        val intent = Intent(this, SingInAndLogin::class.java)
        startActivity(intent)
    }
    fun onEnter(view: View){
        //28.03.2023 Калинин Арсений Олегович Описание: переменные для объектов страницы
        val bskip = findViewById<Button>(R.id.skip)
        val tvt = findViewById<TextView>(R.id.textTitle)
        val tvb = findViewById<TextView>(R.id.textBoard)
        val ip1 = findViewById<ImageView>(R.id.point1)
        val ip2 = findViewById<ImageView>(R.id.point2)
        val ip3 = findViewById<ImageView>(R.id.point3)
        val ipick = findViewById<ImageView>(R.id.imagepick)
        //использование итератора
        if(i==0) {

            tvt.text = "Уведомления"
            tvb.text = "Вы быстро узнаете о результатах"
            ip1.setBackgroundResource(R.drawable.onpoint)
            ip2.setBackgroundResource(R.drawable.point)
            ipick.layout(0,0,366,0)
            ipick.setImageResource(R.drawable.docman)
        }else
        if(i==1)
        {
            tvt.text = "Мониторинг"
            tvb.text = "Наши врачи всегда наблюдают \n" +
                    "за вашими показателями здоровья"
            ip1.setBackgroundResource(R.drawable.onpoint)
            ip2.setBackgroundResource(R.drawable.onpoint)
            ip3.setBackgroundResource(R.drawable.point)
            ipick.setImageResource(R.drawable.docwoman)
            bskip.text = "Завершить"
        }
        else if(i==2)
        {
            //переход на страницу Вход и регистрация
            val intent = Intent(this, SingInAndLogin::class.java)
            startActivity(intent)
        }
        i++
    }

    override fun onStop() {
        super.onStop()
    }
}
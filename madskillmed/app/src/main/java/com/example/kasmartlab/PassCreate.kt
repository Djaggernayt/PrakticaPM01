package com.example.kasmartlab

import android.content.Intent
import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.view.View
import android.widget.Button
import android.widget.ImageView
import android.widget.Toast

class PassCreate : AppCompatActivity() {
    var lis = listOf<String>()
    var i = 0
    lateinit var point1:ImageView
    lateinit var point2:ImageView
    lateinit var point3:ImageView
    lateinit var point4:ImageView
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_pass_create)
        point1 = findViewById<ImageView>(R.id.ponts1)
        point2 = findViewById<ImageView>(R.id.ponts2)
        point3 = findViewById<ImageView>(R.id.ponts3)
        point4 = findViewById<ImageView>(R.id.ponts4)

    }
    //28.03.2023 Калинин Арсений Олегович Описание: попытка использвания ввода пароля
    fun onNumb(view:View){
        val button = findViewById<Button>(R.id.b1)
        //lis.plus(button.text.toString())
        i++
        if(i==1){
            point1.setImageResource(R.drawable.point)
        }else if(i==2)
        {
            point2.setImageResource(R.drawable.point)
        }
        else if(i==3){
            point3.setImageResource(R.drawable.point)

        }else if(i==4){
            point4.setImageResource(R.drawable.point)
        }
    }



    fun onBack(view: View){

    }
    // 28.03.2023 Калинин Арсений Олегович Описание: переход на создание карты
    fun onSkip(view: View){
        val intent = Intent(this,CreateCard::class.java)
        startActivity(intent)
        Toast.makeText(this,"Установка пароля пропущена", Toast.LENGTH_SHORT).show()
    }
}
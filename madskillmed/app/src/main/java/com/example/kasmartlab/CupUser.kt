package com.example.kasmartlab

import android.annotation.SuppressLint
import android.content.Intent
import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.view.TextureView
import android.view.View
import android.widget.ImageView
import android.widget.TextView
import com.example.kasmartlab.ui.home.cup

class CupUser : AppCompatActivity() {
    @SuppressLint("MissingInflatedId")
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_cup_user)
        //29.03.2023 Калинин Арсений Олегович Описание: показ и реализация суммы заказа
        val tv = findViewById<TextView>(R.id.viewsum)
        val imb =findViewById<ImageView>(R.id.viewcard)
        val imb2 =findViewById<ImageView>(R.id.viewcard2)
        if(cup.pcr)
        {
            imb2.visibility =View.VISIBLE
        }
        if(cup.blode){
            imb.visibility =View.VISIBLE
        }
        tv.text = "${cup.sum} ₽"

    }

    fun onOrder(view: View){
        val intent = Intent(this,Order::class.java)
        startActivity(intent)
    }
    //onBack 29.03.2023 Калинин Арсений Олегович Описание: возврат в меню и обнуление данных
    fun onBack(view: View){
        val intent = Intent(this,MenuMain::class.java)
        startActivity(intent)
        cup.sum=0
        cup.bio=false
        cup.coe=false
        cup.blode=false
        cup.pcr=false
    }
    //onStop 29.03.2023 Калинин Арсений Олегович Описание: обнуление данных
    override fun onStop() {
        cup.sum=0
        cup.bio=false
        cup.coe=false
        cup.blode=false
        cup.pcr=false
        super.onStop()
    }
}
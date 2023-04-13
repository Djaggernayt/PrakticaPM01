package com.example.kasmartlab

import android.content.Intent
import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.view.View
import android.widget.Toast

class CreateCard : AppCompatActivity() {
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_create_card)
    }
    // 28.03.2023 Калинин Арсений Олегович Описание: переход в меню навигации
    fun onSkip(view: View){
        val intent = Intent(this@CreateCard,MenuMain::class.java)
        startActivity(intent)
        Toast.makeText(this,"Создание карты пропущено", Toast.LENGTH_SHORT).show()

    }
    // 28.03.2023 Калинин Арсений Олегович Описание: переход в меню навигации
    fun onCreate(view: View){
        val intent = Intent(this@CreateCard, MenuMain::class.java)
        startActivity(intent)
    }
}
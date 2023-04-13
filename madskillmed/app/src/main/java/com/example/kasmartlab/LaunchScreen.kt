package com.example.kasmartlab

import android.content.Intent
import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.os.CountDownTimer

class LaunchScreen : AppCompatActivity() {
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_launch_screen)
        onTick()
    }
    // 28.03.2023 Калинин Арсений Олегович Описание: таймер для перехода стартового экрана
    fun onTick(){
        object : CountDownTimer(3000,1000){
            override fun onTick(p0: Long) {

            }

            override fun onFinish() {
                    val intent = Intent(this@LaunchScreen, MainActivity::class.java)
                    startActivity(intent)

            }
        }.start()
    }
}
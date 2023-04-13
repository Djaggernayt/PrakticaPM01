package com.example.kasmartlab

import android.annotation.SuppressLint
import android.content.Intent
import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.os.CountDownTimer
import android.view.View
import android.widget.Button
import android.widget.ImageView
import android.widget.ProgressBar
import android.widget.TextView
import android.widget.Toast

class Pay : AppCompatActivity() {
    lateinit var tv :TextView
    lateinit var pb: ProgressBar
    @SuppressLint("MissingInflatedId")
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_pay)
        tv = findViewById<TextView>(R.id.tvbank)
        pb = findViewById<ProgressBar>(R.id.progressBar)
        onTick()
        onTicks()
        //30.03.2023 Калинин Арсений Олегович Описание: возврат в меню
        findViewById<Button>(R.id.bmain).setOnClickListener {
            startActivity(Intent(this,MenuMain::class.java))
        }
    }


    //30.03.2023 Калинин Арсений Олегович Описание: таймер
    fun onTick(){
        object : CountDownTimer(5000,1000){
            override fun onTick(p0: Long) {

            }

            override fun onFinish() {
                tv.text = "Производим оплату..."

            }
        }.start()
    }

    //30.03.2023 Калинин Арсений Олегович Описание: второй таймер
    fun onTicks(){
        object : CountDownTimer(10000,1000){
            override fun onTick(p0: Long) {

            }

            override fun onFinish() {
                tv.visibility = View.GONE
                pb.visibility = View.GONE

                findViewById<ImageView>(R.id.bottle).visibility = View.VISIBLE
                findViewById<TextView>(R.id.tbtit2).visibility = View.VISIBLE
                findViewById<TextView>(R.id.tbtit3).visibility = View.VISIBLE
                findViewById<TextView>(R.id.textTitle2).visibility = View.VISIBLE
                findViewById<Button>(R.id.bmain).visibility = View.VISIBLE
                findViewById<Button>(R.id.bmain2).visibility = View.VISIBLE
            }
        }.start()
    }

}
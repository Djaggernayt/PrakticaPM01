package com.example.kasmartlab

import android.content.Intent
import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.view.View
import android.widget.EditText
import android.widget.Toast
import retrofit2.Response
import retrofit2.Retrofit
import retrofit2.converter.gson.GsonConverterFactory
import retrofit2.http.Header
import retrofit2.http.Headers
import retrofit2.http.POST

class SingInAndLogin : AppCompatActivity() {
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_sing_in_and_login)
    }

    //28.03.2023 Калинин Арсений Олегович Описание: отправка на APi запроса
    fun onLogin(view:View){
        var login = findViewById<EditText>(R.id.enterlogin)
        var ret = Retrofit.Builder().baseUrl("https://medic.madskill.ru/")
            .addConverterFactory(GsonConverterFactory.create())
            .build()
            .create(ApiInterface::class.java)
        val intent = Intent(this,password::class.java)
        startActivity(intent)
       //ret.sendCode(login.text.toString())
        Toast.makeText(this,"Код успешно отправлен", Toast.LENGTH_SHORT).show()
    }
}
//28.03.2023 Калинин Арсений Олегович Описание:Классы для транспортировки данных
data class User(
    var email:String
)

data class Message(
    var message:String
)
//28.03.2023 Калинин Арсений Олегович Описание: интерфейс API
interface ApiInterface {

    @Headers("Cotent-Type:application/json")
    @POST("api/sendCode")
    fun sendCode(@Header("email") email: String)

}



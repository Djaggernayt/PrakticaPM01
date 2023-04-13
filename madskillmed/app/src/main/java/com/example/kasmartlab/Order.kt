package com.example.kasmartlab

import android.annotation.SuppressLint
import android.app.AlertDialog
import android.app.DatePickerDialog
import android.app.Dialog
import android.app.TimePickerDialog
import android.content.DialogInterface
import android.content.Intent
import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.text.format.DateFormat
import android.view.LayoutInflater
import android.view.View
import android.widget.Button
import android.widget.DatePicker
import android.widget.EditText
import android.widget.TextView
import android.widget.TimePicker
import androidx.fragment.app.DialogFragment
import com.example.kasmartlab.ui.home.cup
import java.util.*

class Order : AppCompatActivity() {

    @SuppressLint("MissingInflatedId")
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_order)
        //30.03.2023 Калинин Арсений Олегович Описание: создание диалога добавления адреса
        var ad = findViewById<Button>(R.id.badress)
        ad.setOnClickListener {
            var a = LayoutInflater.from(this).inflate(R.layout.adress,null)
            var b = AlertDialog.Builder(this).setView(a)
            var c = b.show()
            var d = a.findViewById<Button>(R.id.baccess)
            d.setOnClickListener {
                ad.text = a.findViewById<EditText>(R.id.editstreet).text.toString()+", кв. " + a.findViewById<EditText>(R.id.editTextNuber).text.toString()
                c.dismiss()
            }
        }
        //30.03.2023 Калинин Арсений Олегович Описание: создание диалога добавления даты
        var addDate = findViewById<Button>(R.id.bdate)
        addDate.setOnClickListener {
            var a = LayoutInflater.from(this).inflate(R.layout.date_time,null)
            var b = AlertDialog.Builder(this).setView(a)
            var c = b.show()
            var d = a.findViewById<Button>(R.id.baccessd)
            var date = a.findViewById<Button>(R.id.baccessd2)
            date.setOnClickListener {
                val newFragment = DatePickerFragment()
                newFragment.show(supportFragmentManager, "datePicker")
                date.text = Date.day+ ". " + Date.month+ ". " + Date.year +" 16:00"

            }
            d.setOnClickListener {
                c.dismiss()
                addDate.text = Date.day+ ". " + Date.month+ ". " + Date.year +" 16:00"
            }
        }
        //30.03.2023 Калинин Арсений Олегович Описание: переход на страницу подтверждения оплаты
        findViewById<Button>(R.id.border).setOnClickListener {
            startActivity(Intent(this,Pay::class.java))
        }

        var sum = findViewById<TextView>(R.id.tvsun)
        sum.text = cup.sum.toString()
    }
    //DatePickerFragment 30.03.2023 Калинин Арсений Олегович Описание: класс предназначен для формирования диалога выбора даты
    class DatePickerFragment : DialogFragment(), DatePickerDialog.OnDateSetListener {

        var year = 0
        var month = 0
        var day = 0
        override fun onCreateDialog(savedInstanceState: Bundle?): Dialog {

            val c = Calendar.getInstance()
            year = c.get(Calendar.YEAR)
            month = c.get(Calendar.MONTH)
            day = c.get(Calendar.DAY_OF_MONTH)
            Date.year = c.get(Calendar.YEAR).toString()
            Date.month = c.get(Calendar.MONTH).toString()
            Date.day = c.get(Calendar.DAY_OF_MONTH).toString()

            return DatePickerDialog(requireContext(), this, year, month, day)

        }

        override fun onStop() {
            super.onStop()
        }
        override fun onCancel(dialog: DialogInterface) {

            super.onCancel(dialog)
        }

        override fun onDateSet(view: DatePicker, year: Int, month: Int, day: Int) {

        }
    }
    //30.03.2023 Калинин Арсений Олегович Описание: возврат на предыдущую страницу
    fun onBack(view: View){
        val intent = Intent(this,CupUser::class.java)
        startActivity(intent)
    }

}
//Date 30.03.2023 Калинин Арсений Олегович Описание: объект предназначен для хранения данных
object Date{
    var year = ""
    var month = ""
    var day = ""
}
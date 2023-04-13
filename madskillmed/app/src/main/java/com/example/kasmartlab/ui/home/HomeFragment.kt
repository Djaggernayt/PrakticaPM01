package com.example.kasmartlab.ui.home

import android.annotation.SuppressLint
import android.app.AlertDialog
import android.content.Intent
import android.os.Bundle
import android.view.LayoutInflater
import android.view.View
import android.view.ViewGroup
import android.widget.Button
import android.widget.TextView
import androidx.fragment.app.Fragment
import androidx.lifecycle.ViewModelProvider
import com.example.kasmartlab.CupUser
import com.example.kasmartlab.R
import com.example.kasmartlab.databinding.FragmentHomeBinding

class HomeFragment : Fragment() {

    private var _binding: FragmentHomeBinding? = null

    // This property is only valid between onCreateView and
    // onDestroyView.
    private val binding get() = _binding!!

    //onCreateView 29.03.2023 Калинин Арсений Олегович Описание: класс создания view элемента
    @SuppressLint("MissingInflatedId")
    override fun onCreateView(
        inflater: LayoutInflater,
        container: ViewGroup?,
        savedInstanceState: Bundle?
    ): View {

        val homeViewModel =
            ViewModelProvider(this).get(HomeViewModel::class.java)

        _binding = FragmentHomeBinding.inflate(inflater, container, false)
        val root: View = binding.root
        //29.03.2023 Калинин Арсений Олегович Описание: создание слушателя нажатитий для добавалнеия заказа
        binding.balizblod.setOnClickListener{
            var a = LayoutInflater.from(this.context).inflate(R.layout.pcr,null)
            var b = AlertDialog.Builder(this.context).setView(a)
            var d = a.findViewById<Button>(R.id.bpcr)
                if(cup.blode)
                {
                    cup.sum-=690
                    binding.balizblod.setBackgroundResource(R.drawable.card2)
                    binding.cups.text = "В корзину ${cup.sum} ₽"
                    if(cup.sum==0)
                    {
                        binding.frame.visibility = View.GONE
                        binding.cups.visibility = View.GONE

                    }
                    cup.blode = false
                }
                else{
                    var c = b.show()
                    d.setOnClickListener {
                        c.dismiss()
                        cup.sum+=690
                        binding.balizblod.setBackgroundResource(R.drawable.cardadd2)
                        binding.frame.visibility = View.VISIBLE
                        binding.cups.visibility = View.VISIBLE
                        binding.cups.text = "В корзину ${cup.sum} ₽"
                        cup.blode=true
                    }

                }




        }

        //29.03.2023 Калинин Арсений Олегович Описание: создание слушателя нажатитий для добавалнеия заказа
        binding.imageBPCR.setOnClickListener {
            var a = LayoutInflater.from(this.context).inflate(R.layout.pcr, null)
            var b = AlertDialog.Builder(this.context).setView(a)
            var td1 = a.findViewById<TextView>(R.id.td1)
            var td2 = a.findViewById<TextView>(R.id.td2)
            var td3 = a.findViewById<TextView>(R.id.td3)
            var td4 = a.findViewById<TextView>(R.id.td4)
            var td5 = a.findViewById<TextView>(R.id.td5)
            var td6 = a.findViewById<TextView>(R.id.td6)
            var td7 = a.findViewById<TextView>(R.id.td7)
            var tv = a.findViewById<TextView>(R.id.textVie)
            var d = a.findViewById<Button>(R.id.bpcr)
            td1.text = "ПЦР-тест на определение РНК коронавируса стандартный"
            td3.visibility = View.INVISIBLE
            td5.visibility = View.INVISIBLE
            td6.visibility = View.INVISIBLE
            td7.text = "Слюна"
            tv.text = "2 дня"
            d.text = "Добавить за 1800 ₽"
            if (cup.pcr) {
                cup.pcr = false
                cup.sum -= 1800
                binding.imageBPCR.setBackgroundResource(R.drawable.card1)
                binding.cups.text = "В корзину ${cup.sum} ₽"
                if (cup.sum == 0) {
                    binding.frame.visibility = View.GONE
                    binding.cups.visibility = View.GONE

                }
            } else {
                var c = b.show()
                d.setOnClickListener {
                    c.dismiss()
                    cup.sum += 1800
                    binding.imageBPCR.setBackgroundResource(R.drawable.cardadd1)
                    binding.frame.visibility = View.VISIBLE
                    binding.cups.visibility = View.VISIBLE
                    binding.cups.text = "В корзину ${cup.sum} ₽"
                    cup.pcr = true
                }


            }
        }
        //29.03.2023 Калинин Арсений Олегович Описание: создание слушателя нажатитий для добавалнеия заказа
            binding.biob.setOnClickListener{
                var a = LayoutInflater.from(this.context).inflate(R.layout.pcr,null)
                var b = AlertDialog.Builder(this.context).setView(a)
                var td1 = a.findViewById<TextView>(R.id.td1)
                var td2 = a.findViewById<TextView>(R.id.td2)
                var td3 = a.findViewById<TextView>(R.id.td3)
                var td4 = a.findViewById<TextView>(R.id.td4)
                var td5 = a.findViewById<TextView>(R.id.td5)
                var td6 = a.findViewById<TextView>(R.id.td6)
                var td7 = a.findViewById<TextView>(R.id.td7)
                var d = a.findViewById<Button>(R.id.bpcr)
                td1.text = "Биохимический анализ крови, базовый"
                td3.visibility = View.INVISIBLE

                d.text = "Добавить за 2440 ₽"
                if(cup.bio)
                {
                    cup.bio = false
                    cup.sum-=2440
                    binding.cups.text = "В корзину ${cup.sum} ₽"
                    if(cup.sum==0)
                    {
                        binding.frame.visibility = View.GONE
                        binding.cups.visibility = View.GONE

                    }
                }
                else{
                    var c = b.show()
                    d.setOnClickListener {
                        c.dismiss()
                        cup.sum+=2440
                        binding.frame.visibility = View.VISIBLE
                        binding.cups.visibility = View.VISIBLE
                        binding.cups.text = "В корзину ${cup.sum} ₽"
                        cup.bio=true}


                }
        }

        //29.03.2023 Калинин Арсений Олегович Описание: создание слушателя нажатитий для добавалнеия заказа
        binding.coeb.setOnClickListener{
            var a = LayoutInflater.from(this.context).inflate(R.layout.pcr,null)
            var b = AlertDialog.Builder(this.context).setView(a)
            var td1 = a.findViewById<TextView>(R.id.td1)
            var td2 = a.findViewById<TextView>(R.id.td2)
            var td3 = a.findViewById<TextView>(R.id.td3)
            var td4 = a.findViewById<TextView>(R.id.td4)
            var td5 = a.findViewById<TextView>(R.id.td5)
            var td6 = a.findViewById<TextView>(R.id.td6)
            var td7 = a.findViewById<TextView>(R.id.td7)
            var d = a.findViewById<Button>(R.id.bpcr)
            td1.text = "СОЭ (венозная кровь)"
            td3.visibility = View.INVISIBLE
            d.text = "Добавить за 240 ₽"
            if(cup.coe)
            {
                cup.coe = false
                cup.sum-=240
                binding.cups.text = "В корзину ${cup.sum} ₽"
                if(cup.sum==0)
                {
                    binding.frame.visibility = View.GONE
                    binding.cups.visibility = View.GONE
                }
            }
            else{
                var c = b.show()
                d.setOnClickListener {
                    c.dismiss()
                    cup.sum+=240
                    binding.frame.visibility = View.VISIBLE
                    binding.cups.visibility = View.VISIBLE
                    binding.cups.text = "В корзину ${cup.sum} ₽"
                    cup.coe=true}
            }
        }
        //29.03.2023 Калинин Арсений Олегович Описание: создание слушателя нажатитий для прехода в корзину
        binding.cups.setOnClickListener {
            val intent = Intent(this.context,CupUser::class.java)
            startActivity(intent)
        }
        return root
    }

    override fun onDestroyView() {
        super.onDestroyView()
        _binding = null
    }
}
//object cup 29.03.2023 Калинин Арсений Олегович Описание: объект предназначен для хранения данных
object cup{
    var sum = 0
    var pcr = false
    var blode = false
    var bio = false
    var coe = false
}
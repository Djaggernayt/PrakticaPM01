package com.example.kasmartlab

import androidx.test.platform.app.InstrumentationRegistry
import androidx.test.ext.junit.runners.AndroidJUnit4

import org.junit.Test
import org.junit.runner.RunWith

import org.junit.Assert.*

/**
 * Instrumented test, which will execute on an Android device.
 *
 * See [testing documentation](http://d.android.com/tools/testing).
 */
@RunWith(AndroidJUnit4::class)
class ExampleInstrumentedTest {
    @Test
    fun useAppContext() {
        // Context of the app under test.
        val appContext = InstrumentationRegistry.getInstrumentation().targetContext
        assertEquals("com.example.kasmartlab", appContext.packageName)
    }
    @Test
    fun ontest1(){
        val intetn = 2
        assertEquals(intetn,3)
    }
    @Test
    fun ontest2(){
        val intetn = 2
        assertEquals(intetn,2)
    }
    @Test
    fun ontest3(){
        val intetn = 2
        assertEquals(intetn,2)
    }
    @Test
    fun ontest4(){
        val intetn = 2
        assertEquals(intetn,2)
    }
    @Test
    fun ontest5(){
        val intetn = 2
        assertEquals(intetn,2)
    }
}
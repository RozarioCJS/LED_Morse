using System;
using System.Diagnostics;
using System.Threading;
using System.Device.Gpio;
using System.Collections;

namespace LED_Morse
{
    public class Program
    {
        public static void Main()
        {
            int LED_GPIO = 5; //Set Gpio pin for LED
            GpioController gpio = new GpioController();
            GpioPin led = gpio.OpenPin(LED_GPIO, PinMode.Output);

            string name = "Hello"; //Message for the LED to blink in morse code
            name = name.ToUpper();
            while (true)
            {
                foreach (char l in name)
                {
                    switch (l)
                    {
                        case 'A':
                            Dit(led);
                            Dash(led);
                            break;
                        case 'B':
                            Dash(led);
                            Dit(led);
                            Dit(led);
                            Dit(led);
                            break;
                        case 'C':
                            Dash(led);
                            Dit(led);
                            Dash(led);
                            Dit(led);
                            break;
                        case 'D':
                            Dash(led);
                            Dit(led);
                            Dit(led);
                            break;
                        case 'E':
                            Dit(led);
                            break;
                        case 'F':
                            Dit(led);
                            Dit(led);
                            Dash(led);
                            Dit(led);
                            break;
                        case 'G':
                            Dash(led);
                            Dash(led);
                            Dit(led);
                            break;
                        case 'H':
                            Dit(led);
                            Dit(led);
                            Dit(led);
                            Dit(led);
                            break;
                        case 'I':
                            Dit(led);
                            Dit(led);
                            break;
                        case 'J':
                            Dit(led);
                            Dash(led);
                            Dash(led);
                            Dash(led);
                            break;
                        case 'K':
                            Dash(led);
                            Dit(led);
                            Dash(led);
                            break;
                        case 'L':
                            Dit(led);
                            Dash(led);
                            Dit(led);
                            Dit(led);
                            break;
                        case 'M':
                            Dash(led);
                            Dash(led);
                            break;
                        case 'N':
                            Dash(led);
                            Dit(led);
                            break;
                        case 'O':
                            Dash(led);
                            Dash(led);
                            Dash(led);
                            break;
                        case 'P':
                            Dit(led);
                            Dash(led);
                            Dash(led);
                            Dit(led);
                            break;
                        case 'Q':
                            Dash(led);
                            Dash(led);
                            Dit(led);
                            Dash(led);
                            break;
                        case 'R':
                            Dit(led);
                            Dash(led);
                            Dit(led);
                            break;
                        case 'S':
                            Dit(led);
                            Dit(led);
                            Dit(led);
                            break;
                        case 'T':
                            Dash(led);
                            break;
                        case 'U':
                            Dit(led);
                            Dit(led);
                            Dash(led);
                            break;
                        case 'V':
                            Dit(led);
                            Dit(led);
                            Dit(led);
                            Dash(led);
                            break;
                        case 'W':
                            Dit(led);
                            Dash(led);
                            Dash(led);
                            break;
                        case 'X':
                            Dash(led);
                            Dit(led);
                            Dit(led);
                            Dash(led);
                            break;
                        case 'Y':
                            Dash(led);
                            Dit(led);
                            Dash(led);
                            Dash(led);
                            break;
                        case 'Z':
                            Dash(led);
                            Dash(led);
                            Dit(led);
                            Dit(led);
                            break;
                    }
                }
            }
            
            
        }

        public static void Dit(GpioPin led) //Dit is 1 time unit
        {
            led.Toggle();
            Thread.Sleep(300);
            led.Toggle();
            Thread.Sleep(300);
        }
        public static void Dash(GpioPin led) //Dash is 3 time units
        {
            led.Toggle();
            Thread.Sleep(900);
            led.Toggle();
            Thread.Sleep(300);
        }
    }
}

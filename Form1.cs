﻿using System;
using System.Net;
using System.Linq;
using System.Windows.Forms;

namespace besteFarben
{
    public partial class Form1 : Form
    {
        public string[] data = new string[]
        {
            "Белый сочетается со всеми цветами. Наилучшее сочетание с синим, красным и черным.",
            "Бежевый сочетается с голубым, коричневым, изумрудным, черным, красным.",
            "Серый сочетается с \"капризными\" цветами: фуксия, красный, фиолетовый, розовый, синий.",
            "Розовый сочетается с коричневым, зеленой мятой, оливковым, серым, бирюзовым, светло-голубым.",
            "Фуксия сочетается с серым, желто-коричневым, зеленым лаймом, зеленой мятой, коричневым.",
            "Красный сочетается с желтым, бурым, зеленым, синим, черным.",
            "Томатно–красный сочетается с голубым, зеленой мятой, песочным, сливочно–белым, серым.",
            "Вишнево-красный сочетается с лазурным, серым, светло-оранжевым, песочным, бледно-желтым, бежевым.",
            "Малиново-красный сочетается с белым, черным и дамасской розой.",
            "Коричневый сочетается с ярко-голубым, кремовым, розовым, палевым, зеленым, бежевым.",
            "Светло-коричневый сочетается с бледно-желтым, кремовым, синим, зеленым, пурпурным, красным.",
            "Темно-коричневый сочетается с лимонно-желтым, голубым, зеленой мятой, пурпурно-розовым, зеленым лаймом.",
            "Рыжевато-коричневый сочетается с розовым, темно-коричневым, синим, зеленым, пурпурным.",
            "Оранжевый сочетается с голубым, синим, лиловым, фиолетовым.",
            "Светло–оранжевый сочетается с серым, коричневым, оливковым.",
            "Темно–оранжевый сочетается с бледно–желтым, оливковым, коричневым, вишнёвым.",
            "Желтый сочетается с синим, лиловым, светло-голубым, фиолетовым, серым, черным.",
            "Лимонно-желтый сочетается с вишнево-красным, коричневым, синим, серым.",
            "Бледно-желтый сочетается с фуксией, серым, коричневым, красным, желтовато-коричневым, синим, пурпурным.",
            "Золотисто-желтый сочетается с серым, коричневым, лазурным, красным.",
            "Оливковый сочетается с апельсиновым, светло-коричневым, коричневым.",
            "Зеленый сочетается с золотисто-коричневым, оранжевым, салатовым, желтым, коричневым, серым, кремовым, черным, сливочно-белым.",
            "Салатовый цвет сочетается с коричневым, желтовато-коричневым, палевым, серым, темно-синим, красным.",
            "Бирюзовый сочетается с фуксией, вишнево-красным, желтым, коричневым, кремовым, темно-фиолетовым.",
            "Электрик сочетается с золотисто-желтым, коричневым, светло-коричневым, серым, серебряным.",
            "Голубой сочетается с красным, серым, коричневым, оранжевым, розовым, желтым.",
            "Темно-синий сочетается с светло-лиловым, голубым, желтовато-зеленым, коричневым, серым, бледно-желтым, оранжевым, зеленым, красным.",
            "Лиловый сочетается с оранжевым, розовым, темно-фиолетовым, оливковым, серым, желтым.",
            "Темно-фиолетовый сочетается с золотисто-коричневым, бледно-желтым, серым, бирюзовым, зеленой мятой, светло-оранжевым.",
            "Черный сочетается со всеми цветами. Наилучшее сочетание с оранжевым, розовым, салатовым, красным, сиреневым, желтым, белым."


        };
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string trueFarbe = textBoxFarbe.Text.ToLower()[0].ToString().ToUpper() + textBoxFarbe.Text.ToLower().Substring(1);
            try
            {
                textBoxResult.Text = data.First(m => m.StartsWith(trueFarbe));
            }
            catch (Exception)
            {
                var neededData = data.Where(m => m.Contains(trueFarbe.ToLower().Substring(0,trueFarbe.Length-2)));
                string neededString = string.Empty;
                foreach(var item in neededData)
                {
                    neededString += $"\n{item.Split(' ')[0].ToLower()}";
                }
                textBoxResult.Text = $"К цвету \"{trueFarbe.ToLower()}\" подходят: "+neededString;
            }
        }
    }
}

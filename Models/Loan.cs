using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace AnnuitetCalculator.Models
{
    public class Loan
    {
        [Required(ErrorMessage = "Небходимое поле")]
        [Range(1, 1000000, ErrorMessage = "Сумма должна быть от {1} до {2} руб")]
        public int Sum { get; set; }

        [Required(ErrorMessage = "Небходимое поле")]
        [Range(1, 365 * 10, ErrorMessage = "Срок должен быть от {1} до {2} дней")]
        [Divison("Step", ErrorMessage ="Срок должен без остатка делиться на шаг")]
        public short Time { get; set; }

        [Required(ErrorMessage = "Небходимое поле")]
        [Range(1, 100, ErrorMessage = "Ставка должна быть от {1} % до {2} %")]
        public byte Rate { get; set; }

        [Required(ErrorMessage = "Небходимое поле")]
        [Range(1, 365, ErrorMessage = "Шаг должен быть от {1} до {2} дней")]
        public short Step { get; set; }

        private Pay[] Pays;
        private double Overpay;

        public Pay[] getPays()
        {
            if (this.Pays == null)
            {
                CalculatPays();
            }

            return this.Pays;
        }

        public double getOverpay()
        {
            if (this.Pays == null)
            {
                CalculatPays();
            }

            return this.Overpay;
        }

        public void CalculatPays()
        {
            double i = Rate / 100.0 * Step;
            int n = Time / Step;
            double payment = i * Math.Pow(1 + i, n) / (Math.Pow(1 + i, n) - 1) * Sum;
            double S = Sum;
            double overpay = 0;

            Pay[] pays = new Pay[n];
            for (byte j = 0; j < n; j++)
            {
                double p = S * i;
                overpay += p;
                double s = payment - p;
                S -= s;
                Pay pay = new Pay((byte)(j + 1), DateTime.Now.AddDays((j + 1) * Step).Date, Math.Round(payment, 2), Math.Round(s, 2), Math.Round(p, 2), Math.Abs(Math.Round(S, 2)));
                pays[j] = pay;
            }

            this.Pays = pays;
            this.Overpay = Math.Round(overpay, 2);
        }
    }
}

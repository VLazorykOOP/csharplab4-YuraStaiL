using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Lab4CSharp
{
    internal class Money
    {
        private int nominal;
        private int num;

        public Money(int nominal, int num)
        {
            this.nominal = nominal;
            this.num = num;
        }

        public int this[int i]
        {
            get
            {
                if (i == 0)
                {
                    return nominal;
                }

                if (i == 1)
                {
                    return num;
                }

                throw new Exception("Index out of range");
            }
        }

        public static Money operator ++(Money money)
        {
            Money copy = new Money(money.nominal, money.num);
            copy.Nominal++;
            copy.Num++;

            return copy;
        }

        public static Money operator --(Money money)
        {
            Money copy = new Money(money.nominal, money.num);
            copy.Nominal--;
            copy.Num--;

            return copy;
        }

        public static bool operator !(Money money)
        {
            if (money.Num != 0)
            {
                return true;
            }

            return false;
        }

        public static Money operator +(Money money, int num)
        {
            Money copy = new Money(money.nominal, money.num);
            copy.Num += num;

            return copy;
        }

        public static implicit operator string(Money m) => m.ToString();
        public static explicit operator Money(string str) => new Money(Int32.Parse(str.Split(',')[0]), Int32.Parse(str.Split(',')[1]));

        public override string ToString()
        {

            return $"Nominal: {this.nominal.ToString()}, count {this.num.ToString()}";
        }

        public bool IsEnough(int cost)
        {
            return this.TotalBalance >= cost;
        }

        public int CalculateAmount(int cost)
        {
            return (int)this.TotalBalance / cost;
        }

        public int Nominal { get => this.nominal; set => this.nominal = value; }
        public int Num { get => this.num; set => this.num = value; }

        public int TotalBalance
        {
            get => this.nominal * this.num;
        }
    }
}

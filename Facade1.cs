using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_pr6._2
{
    class ClassOrder
    {
        public void MakeOrder(string dishes, int price)
        {
            Form Order = new Order(dishes, price);
            Order.Show();
        }
        public void ConfirmOrder()
        {
            Form Delivery = new Delivery();
            Delivery.Show();
        }
        public void RejectOrder() //отказ
        {
            MessageBox.Show("Вы отменили заказ", "Отмена", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public void TransferToKitchen()
        {
            MessageBox.Show("Ваш заказ передан на кухню", "Подтверждение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void Cooking()
        {
            MessageBox.Show("Готовим ваш заказ", "В процессе", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        public void HungryCook()
        {
            MessageBox.Show("Повар съел ваш заказ", "A, ой", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

    }
    class ClassDelivery
    {
        public void TransferToCourier()
        {
            MessageBox.Show("Передаем ваш заказ курьеру", "Передача", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void Delivered()
        {
            MessageBox.Show("Открывайте дверь, курьер под дверью", "Прибыл", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        public void NoDelivery()
        {
            MessageBox.Show("Мы не доставляем за пределами города", "Извините", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }
    }
    internal class Facade1
    {
        ClassOrder order;
        ClassDelivery delivery;
        public Facade1(ClassOrder _order, ClassDelivery _delivery)
        {
            order = _order;
            delivery = _delivery;
        }
        public void MakeOrder(string dishes, int price)
        {
            order.MakeOrder(dishes, price);
        }
        public void ConfirmOrder()
        {
            order.ConfirmOrder();
        }
        public void RejectOrder()
        {
            order.RejectOrder();
        }
        public void Process()
        {
            order.TransferToKitchen();
            Random rand = new Random();
            int r = rand.Next(1, 3);
            if (r == 1)
            {
                order.Cooking();
                delivery.TransferToCourier();
                delivery.Delivered();
            }
            else
            {
                order.HungryCook();
            }
        }
        public void NoDelivery()
        {
            delivery.NoDelivery();
        }
    }
}

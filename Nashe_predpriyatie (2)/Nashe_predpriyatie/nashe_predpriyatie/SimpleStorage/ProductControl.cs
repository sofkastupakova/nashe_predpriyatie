using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleStorage
{
    public partial class ProductControl : UserControl
    {
        public ProductControl()
        {
            InitializeComponent();
        }

        public void Clear()
        {
            textBoxName.Text = "";
            textBoxManufacturer.Text = "";
            textBoxPrice.Text = "";
        }

        public Product GetProduct()
        {
            if (textBoxName.Text.Length < 3)
                throw new Exception("Укажите корректное ФИО.");

            if (textBoxManufacturer.Text.Length < 3)
                throw new Exception("Укажите корректное наименование секции.");

            if (double.TryParse(textBoxPrice.Text, out double price))
            {
                if (price <= 0)
                    throw new Exception("Укажите коррктную дату (например, 7.05 - 7 мая).");

                return new Product(
                    textBoxName.Text,
                    textBoxManufacturer.Text,
                    price);
            }


            throw new Exception("Укажите коррктную дату (например, 7.05 - 7 мая).");
        }
    }
}

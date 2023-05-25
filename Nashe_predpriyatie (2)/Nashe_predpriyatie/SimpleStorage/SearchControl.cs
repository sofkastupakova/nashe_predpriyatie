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
    public partial class SearchControl : UserControl
    {
        public event EventHandler<SearchEventArgs> Search;

        public SearchControl()
        {
            InitializeComponent();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text.Length >= (checkBoxProce.Checked ? 0 : 1) && textBoxName.Text.Length < 3)
            {
                MessageBox.Show("Укажите корректное наименование товара.",
                        "Мой склад", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            if (checkBoxProce.Checked)
            {
                if (double.TryParse(textBoxPriceFrom.Text, out double priceFrom))
                {
                    if (priceFrom < 0)
                    {
                        MessageBox.Show("Начальная цена товара должна быть больше или равна нулю.",
                            "Мой склад", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Начальная цена товара указана некорректно.",
                            "Мой склад", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;

                }
                if (double.TryParse(textBoxPriceTo.Text, out double priceTo))
                {
                    if (priceTo <= 0)
                    {
                        MessageBox.Show("Конечная цена товара должна быть больше нуля.",
                            "Мой склад", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Конечная цена товара указана некорректно.",
                            "Мой склад", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (Search != null)
                    Search.Invoke(this, new SearchEventArgs(textBoxName.Text, true, priceFrom, priceTo));

            }
            else if (Search != null)
                Search.Invoke(this, new SearchEventArgs(textBoxName.Text));
        }
    }

    public class SearchEventArgs : EventArgs
    {
        private string _name;
        private bool _searchByPrice;
        private double _priceFrom;
        private double _priceTo;

        public string Name { get { return _name; } }
        public bool SearchByPrice { get { return _searchByPrice; } }
        public double PriceFrom { get { return _priceFrom; } }
        public double PriceTo { get { return _priceTo; } }

        public SearchEventArgs(string name)
        {
            _name = name;
            _searchByPrice = false;
            _priceFrom = 0;
            _priceTo = 0;
        }

        public SearchEventArgs(string name, bool price, double priceFrom, double priceTo)
        {
            _name = name;
            _searchByPrice = price;
            _priceFrom = priceFrom;
            _priceTo = priceTo;
        }
    }
}

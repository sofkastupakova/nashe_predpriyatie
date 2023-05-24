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
    public partial class Main : Form
    {

        private FileStorage _storage;
        private SearchEventArgs _lastSearchParams;

        public Main()
        {
            InitializeComponent();
            searchControl.Search += OnSearch;
        }

        private void OnSearch(object sender, SearchEventArgs e)
        {
            _lastSearchParams = e;
            if (_storage == null)
            {
                MessageBox.Show("Для начала, создайте или откройте файл базы данных поступающих.",
                        "Список поступающих в детский дом творчества ''Союз''", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            listViewProducts.Items.Clear();
            if (e.SearchByPrice)
            {
                List<ListViewItem> list = new List<ListViewItem>();
                IEnumerable<Product> products = _storage.Find(e.Name, e.PriceFrom, e.PriceTo);
                foreach (var product in products)
                {
                    ListViewItem item = new ListViewItem
                    {
                        Tag = product,
                        Text = product.Name,
                        SubItems = { product.ManufacturerName, product.Price.ToString("c") }
                    };
                    list.Add(item);
                }
                listViewProducts.Items.AddRange(list.ToArray());


            }
            else
            {
                listViewProducts.Items.AddRange(
                    _storage.Find(e.Name).Select(item => new ListViewItem
                    {
                        Tag = item,
                        Text = item.Name,
                        SubItems = { item.ManufacturerName, item.Price.ToString("c") }
                    }).ToArray());
            }
        }

        private void toolStripMenuItemExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void toolStripMenuItemCreate_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                _storage = new FileStorage(saveFileDialog.FileName);
                Text = $"Список поступающих в детский дом творчества ''Союз'' [{_storage.FileName}]";
            }
        }

        private void toolStripMenuItemOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog(); 
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    _storage = new FileStorage(openFileDialog.FileName);
                    _storage.Load();
                    Text = $"Список поступающих в детский дом творчества ''Союз'' [{_storage.FileName}]";
                }
                catch
                {
                    MessageBox.Show("Не удалось открыть файл базы данных поступающих. Возможно, файл поврежден.",
                        "Список поступающих в детский дом творчества ''Союз''", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void toolStripMenuItemClose_Click(object sender, EventArgs e)
        {
            _storage = null;
            Text = "Список поступающих в детский дом творчества ''Союз'' ";
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (_storage == null)
            {
                MessageBox.Show("Для начала, создайте или откройте файл базы данных поступающих.",
                        "Список поступающих в детский дом творчества ''Союз''", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                _storage.Add(productControl.GetProduct());
                MessageBox.Show("Объект успешно добавлен в список!", "Список поступающих в детский дом творчества ''Союз''");
                productControl.Clear();
            }
            catch (Exception exception)
            {
                MessageBox.Show($"Невозможно добавить новый объект.\n{exception.Message}",
                        "Список поступающих в детский дом творчества ''Союз''", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }



        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (_storage == null)
            {
                MessageBox.Show("Для начала, создайте или откройте файл базы данных поступающих.",
                        "Список поступающих в детский дом творчества ''Союз''", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (listViewProducts.SelectedItems != null && listViewProducts.SelectedItems.Count > 0)
            {
                if (MessageBox.Show("Вы действительно желаете удалить объект?", "Список поступающих в детский дом творчества ''Союз''",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    _storage.Remove((Product)listViewProducts.SelectedItems[0].Tag);
                    OnSearch(this, _lastSearchParams);
                }
            }
            else
                MessageBox.Show("Выберите объект.", "Список поступающих в детский дом творчества ''Союз''", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

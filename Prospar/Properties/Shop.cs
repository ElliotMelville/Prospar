using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prospar.Properties
{
    public partial class Shop : Form
    {
        //enum Items
        //{
        //    Achievement, //0
        //    EdhelFeather, //1
        //    Grindstone, //2
        //    KingsInterest, //3
        //    LuckyPendant, //4
        //    MirtincBoots, //5
        //    TravellingMerchant, //6
        //}

        private List<ShopItem> itemsInUse = new List<ShopItem>();
        private List<ShopItem> items = new List<ShopItem>();

        public Shop()
        {
            InitializeComponent();
            CreateItems();
            SelectItems();
            DisplayItems();
            btnShopItem1.Parent = pictureBox1;
            btnShopItem2.Parent = pictureBox1;
            btnShopItem3.Parent = pictureBox1;
        }

        private void CreateItems()
        {
            CreateItem("Achievement", Properties.Resources.Achievement_affordable, Properties.Resources.Achievement_unaffordable, Properties.Resources.Achievement_selected);
            CreateItem("EdhelFeather", Properties.Resources.EdhelFeather_affordable, Properties.Resources.EdhelFeather_unaffordable, Properties.Resources.EdhelFeather_selected);
            CreateItem("Grindstone", Properties.Resources.Grindstone_affordable, Properties.Resources.Grindstone_unaffordable, Properties.Resources.Grindstone_selected);
            CreateItem("KingsInterest", Properties.Resources.KingsInterest_affordable, Properties.Resources.KingsInterest_unaffordable, Properties.Resources.KingsInterest_selected);
            CreateItem("LuckyPendant", Properties.Resources.LuckyPendant_affordable, Properties.Resources.LuckyPendant_unaffordable, Properties.Resources.LuckyPendant_selected);
            CreateItem("MirtincBoots", Properties.Resources.MirtincBoots_affordable, Properties.Resources.MirtincBoots_unaffordable, Properties.Resources.MirtincBoots_selected);
            CreateItem("TravellingMerchant", Properties.Resources.TravellingMerchant_affordable, Properties.Resources.TravellingMerchant_unaffordable, Properties.Resources.TravellingMerchant_selected);
        }

        private void CreateItem(string name, Bitmap affordable, Bitmap unaffordable, Bitmap selected)
        {
            ShopItem item = new ShopItem();
            item.name = name;
            item.imageAffordable = affordable;
            item.imageUnaffordable = unaffordable;
            item.imageSelected = selected;
            items.Add(item);
        }

        private void SelectItems()
        {
            Random random = new Random();
            int index;

            while(itemsInUse.Count <= 3)
            {
                index = random.Next(0, items.Count());
                ShopItem item = items.ElementAt(index);

                if (!itemsInUse.Contains(item))
                {
                    itemsInUse.Add(item);
                }
            }
        }
        public void DisplayItems()
        {
            btnShopItem1.Image = itemsInUse.ElementAt(1).imageAffordable;
            btnShopItem2.Image = itemsInUse.ElementAt(2).imageAffordable;
            btnShopItem3.Image = itemsInUse.ElementAt(3).imageAffordable;
        }
    }
}

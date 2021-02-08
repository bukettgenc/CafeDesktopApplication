using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeApp
{
    public partial class Table : Form
    {
        private int tableNu = 0;

        public Table(int? table)
        {
            tableNu = (int) table;
            InitializeComponent();
        }

        private void Table_Load(object sender, EventArgs e)
        {

            Model1 db = new Model1();
            var additionList = db.Addition.Where(x => x.TableNu == tableNu).ToList();
            var drinksList = db.Items.Where(x => x.ItemGroup == 1).ToList();
            var dessertList = db.Items.Where(x => x.ItemGroup == 2).ToList();
            var pizzaList = db.Items.Where(x => x.ItemGroup == 3).ToList();
            int y = 0;
            int z = 0;
            int t = 0;
            int k = 0;
            int p = 0;
            foreach (var addition in additionList)
            {
                var name = db.Items.Where(x => x.Item == addition.Item).SingleOrDefault();
                if (name != null)
                {
                    orders.Items.Add(name.ItemName + "(" + addition.Count + " adet) ");
                    orders.Items.Add("");
                    Button buttonminus = new Button();
                    buttonminus.Text = "-";
                    buttonminus.Name = "minus";
                    buttonminus.Size = new Size(18, 18);
                    buttonminus.Location = new Point(100, 2 + y);
                    orders.Controls.Add(buttonminus);
                    Button buttonplus = new Button();
                    buttonplus.Text = "+";
                    buttonplus.Name =k.ToString();
                    k++;
                    buttonplus.Size = new Size(18, 18);
                    buttonplus.Location = new Point(117, 2 + y);
                    y += 25;
                    orders.Controls.Add(buttonplus);

                    buttonplus.Click += (sender2, args) =>
                    {
                        {
                            var increase = db.Addition.Where(x => x.Item == addition.Item && x.TableNu == tableNu).SingleOrDefault();
                            increase.Count++;
                            db.SaveChanges();

                            orders.Items[(Int32.Parse(buttonplus.Name)*2)] = name.ItemName + "(" + addition.Count + " adet) ";
                            orders.Refresh();
                            orders.Update();
                        }
            };
                    buttonminus.Click += (sender2, args) =>
                    {
                        {
                            var increase = db.Addition.Where(x => x.Item == addition.Item && x.TableNu == tableNu).SingleOrDefault();
                            if (increase.Count > 1)
                            {
                                increase.Count--;
                                db.SaveChanges();

                                orders.Items[(Int32.Parse(buttonplus.Name) * 2)] = name.ItemName + "(" + addition.Count + " adet) ";
                                orders.Refresh();
                                orders.Update();
                            }
                            else
                            {
                                var deleted = db.Addition.Where(x => x.Item == addition.Item && x.TableNu == tableNu).SingleOrDefault();
                                db.Addition.Remove(deleted);
                                db.SaveChanges();
                                //orders.Items.RemoveAt((Int32.Parse(buttonplus.Name) * 2)+1);
                                //orders.Items.RemoveAt(Int32.Parse(buttonplus.Name) * 2);
                                //orders.Controls.RemoveAt(Int32.Parse(buttonplus.Name) * 2);
                                //orders.Controls.RemoveAt(Int32.Parse(buttonplus.Name) * 2);
                                orders.Refresh();
                                orders.Update();
                            }
                        }
                    };
                }
            }

            foreach (var items in drinksList)
            {

                Button addButton = new Button();
                addButton.Text = "Ekle";
                addButton.Name = "addButton";
                addButton.Size = new Size(40, 20);
                addButton.Location = new Point(100, 0 + z);
                z += 25;
                listBoxDrinks.Controls.Add(addButton);

                listBoxDrinks.Items.Add(items.ItemName + "(" + items.Price + " Tl )");
                listBoxDrinks.Items.Add("");
                addButton.Click += (sender2, args) =>
                {
                    {

                        var list = db.Addition.Where(x => x.Item == items.Item && x.TableNu == tableNu)
                            .SingleOrDefault();
                        if (list == null)
                        {
                            Addition addition = new Addition();
                            addition.Count = 1;
                            addition.Item = items.Item;
                            addition.TableNu = tableNu;
                            db.Addition.Add(addition);
                            db.SaveChanges();
                            var additionList2 = db.Addition.Where(x => x.TableNu == tableNu).ToList();

                            orders.Items.Clear();
                            int y1 = 0;
                            int i = 0;
                            foreach (var addition2 in additionList2)
                            {
                                var name = db.Items.Where(x => x.Item == addition2.Item).SingleOrDefault();
                                if (name != null)
                                {
                                    orders.Items.Add(name.ItemName + "(" + addition2.Count + " adet) ");
                                    orders.Items.Add("");
                                    Button buttonminus = new Button();
                                    buttonminus.Text = "-";
                                    buttonminus.Name = "1";
                                    buttonminus.Size = new Size(18, 18);
                                    buttonminus.Location = new Point(100, 2 + y1);
                                    orders.Controls.Add(buttonminus);
                                    Button buttonplus = new Button();
                                    buttonplus.Text = "+";
                                    buttonplus.Name = i.ToString();
                                    i++;
                                    buttonplus.Size = new Size(18, 18);
                                    buttonplus.Location = new Point(117, 2 + y1);
                                    y1 += 25;
                                    orders.Controls.Add(buttonplus);
                                    buttonplus.Click += (sender3, args1) =>
                                    {
                                        {
                                            var increase = db.Addition.Where(x => x.Item == addition.Item && x.TableNu==addition.TableNu).SingleOrDefault();
                                            increase.Count++;  
                                            db.SaveChanges();

                                            orders.Items[Int32.Parse(buttonplus.Name)*2] = name.ItemName + "(" + addition.Count + " adet) ";
                                            orders.Refresh();
                                            orders.Update();
                                        }
                                    };
                                    buttonminus.Click += (s,a) =>
                                    {
                                        {
                                            var increase = db.Addition.Where(x => x.Item == addition.Item && x.TableNu == tableNu).SingleOrDefault();
                                            if (increase.Count>1)
                                            {
                                                increase.Count--;
                                                db.SaveChanges();

                                                orders.Items[(Int32.Parse(buttonplus.Name) * 2)] = name.ItemName + "(" + addition.Count + " adet) ";
                                                orders.Refresh();
                                                orders.Update();
                                            }
                                            else
                                            {
                                                //orders.Items.RemoveAt((Int32.Parse(buttonplus.Name) * 2)-1);
                                                orders.Items.RemoveAt(0);
                                                orders.Refresh();
                                                orders.Update();
                                            }
                                        }
                                    };
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("zaten siparişlerinizde var");
                        }
                    }
                };

            }
            foreach (var items in dessertList)
            {
                Button addButton = new Button();
                addButton.Text = "Ekle";
                addButton.Name = "addButton";
                addButton.Size = new Size(40, 20);
                addButton.Location = new Point(100, 0 + t);
                t += 25;
                listBoxDessert.Controls.Add(addButton);
                listBoxDessert.Items.Add(items.ItemName + "(" + items.Price + " Tl )");
                listBoxDessert.Items.Add("");
                addButton.Click += (senderr, args) =>
                {
                    {

                        var list = db.Addition.Where(x => x.Item == items.Item && x.TableNu == tableNu)
                            .SingleOrDefault();
                        if (list == null)
                        {
                            Addition addition = new Addition();
                            addition.Count = 1;
                            addition.Item = items.Item;
                            addition.TableNu = tableNu;
                            db.Addition.Add(addition);
                            db.SaveChanges();
                            var additionList2 = db.Addition.Where(x => x.TableNu == tableNu).ToList();

                            orders.Items.Clear();
                            int y1 = 0;
                            int i = 0;
                            foreach (var addition2 in additionList2)
                            {
                                var name = db.Items.Where(x => x.Item == addition2.Item).SingleOrDefault();
                                if (name != null)
                                {
                                    orders.Items.Add(name.ItemName + "(" + addition2.Count + " adet) ");
                                    orders.Items.Add("");
                                    Button buttonminus = new Button();
                                    buttonminus.Text = "-";
                                    buttonminus.Name = "1";
                                    buttonminus.Size = new Size(18, 18);
                                    buttonminus.Location = new Point(100, 2 + y1);
                                    orders.Controls.Add(buttonminus);
                                    Button buttonplus = new Button();
                                    buttonplus.Text = "+";
                                    buttonplus.Name = i.ToString();
                                    i++;
                                    buttonplus.Size = new Size(18, 18);
                                    buttonplus.Location = new Point(117, 2 + y1);
                                    y1 += 25;
                                    orders.Controls.Add(buttonplus);
                                    buttonplus.Click += (sender3, args1) =>
                                    {
                                        {
                                            var increase = db.Addition.Where(x => x.Item == addition.Item && x.TableNu == addition.TableNu).SingleOrDefault();
                                            increase.Count++;
                                            db.SaveChanges();

                                            orders.Items[Int32.Parse(buttonplus.Name) * 2] = name.ItemName + "(" + addition.Count + " adet) ";
                                            orders.Refresh();
                                            orders.Update();
                                        }
                                    };
                                    buttonminus.Click += (s, a) =>
                                    {
                                        {
                                            var increase = db.Addition.Where(x => x.Item == addition.Item && x.TableNu == tableNu).SingleOrDefault();
                                            increase.Count--;
                                            db.SaveChanges();

                                            orders.Items[(Int32.Parse(buttonplus.Name) * 2)] = name.ItemName + "(" + addition.Count + " adet) ";
                                            orders.Refresh();
                                            orders.Update();
                                        }
                                    };
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("zaten siparişlerinizde var");
                        }
                    }
                };

            }

            foreach (var items in pizzaList)
            {
                Button addButton = new Button();
                addButton.Text = "Ekle";
                addButton.Name = "addButton";
                addButton.Size = new Size(40, 20);
                addButton.Location = new Point(100, 0 + p);
                p += 25;

                listBoxPizzas.Controls.Add(addButton);
                listBoxPizzas.Items.Add(items.ItemName + "(" + items.Price + " Tl )");
                listBoxPizzas.Items.Add("");
                addButton.Click += (senderr, args) =>
                {
                    {

                        var list = db.Addition.Where(x => x.Item == items.Item && x.TableNu == tableNu)
                            .SingleOrDefault();
                        if (list == null)
                        {
                            Addition addition = new Addition();
                            addition.Count = 1;
                            addition.Item = items.Item;
                            addition.TableNu = tableNu;
                            db.Addition.Add(addition);
                            db.SaveChanges();
                            var additionList2 = db.Addition.Where(x => x.TableNu == tableNu).ToList();

                            orders.Items.Clear();
                            int y1 = 0;
                            int i = 0;
                            foreach (var addition2 in additionList2)
                            {
                                var name = db.Items.Where(x => x.Item == addition2.Item).SingleOrDefault();
                                if (name != null)
                                {
                                    orders.Items.Add(name.ItemName + "(" + addition2.Count + " adet) ");
                                    orders.Items.Add("");
                                    Button buttonminus = new Button();
                                    buttonminus.Text = "-";
                                    buttonminus.Name = "1";
                                    buttonminus.Size = new Size(18, 18);
                                    buttonminus.Location = new Point(100, 2 + y1);
                                    orders.Controls.Add(buttonminus);
                                    Button buttonplus = new Button();
                                    buttonplus.Text = "+";
                                    buttonplus.Name = i.ToString();
                                    i++;
                                    buttonplus.Size = new Size(18, 18);
                                    buttonplus.Location = new Point(117, 2 + y1);
                                    y1 += 25;
                                    orders.Controls.Add(buttonplus);
                                    buttonplus.Click += (sender3, args1) =>
                                    {
                                        {
                                            var increase = db.Addition.Where(x => x.Item == addition.Item && x.TableNu == addition.TableNu).SingleOrDefault();
                                            increase.Count++;
                                            db.SaveChanges();

                                            orders.Items[Int32.Parse(buttonplus.Name) * 2] = name.ItemName + "(" + addition.Count + " adet) ";
                                            orders.Refresh();
                                            orders.Update();
                                        }
                                    };
                                    buttonminus.Click += (s, a) =>
                                    {
                                        {
                                            var increase = db.Addition.Where(x => x.Item == addition.Item && x.TableNu == tableNu).SingleOrDefault();
                                            if (increase.Count > 1)
                                            {
                                                increase.Count--;
                                                db.SaveChanges();

                                                orders.Items[(Int32.Parse(buttonplus.Name) * 2)] = name.ItemName + "(" + addition.Count + " adet) ";
                                                orders.Refresh();
                                                orders.Update();
                                            }
                                            else
                                            {
                                                //orders.Items.RemoveAt((Int32.Parse(buttonplus.Name) * 2)-1);
                                                orders.Items.RemoveAt(Int32.Parse(buttonplus.Name) * 2);
                                                orders.Refresh();
                                                orders.Update();
                                            }
                                        }
                                    };
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("zaten siparişlerinizde var");
                        }
                    }
                };

            }

        }

    }
}


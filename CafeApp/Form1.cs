using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CafeApp.Models;

namespace CafeApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
            Model1 db=new Model1();
            var tableList = db.Tables.ToList();
            int x = 0;
            int y = 1;
            foreach (var table in tableList)
            {
                    Button button=new Button();
                    button.Text = "Masa" + table.TableNu;
                    button.Name = "Masa" + table.TableNu;
                    button.Size=new Size(55,35);
                    button.Location=new Point(100*(x+1),60*y);
                    x++;
                    if (x>3)
                    {
                        y++;
                        x = 0;
                    }
                    Controls.Add(button);
                    button.Click += (sender, args) =>
                    {
                        {
                            Table objUI = new Table(table.TableNu);
                            objUI.Show();
                        }
                    };
            }
            
        }
     
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

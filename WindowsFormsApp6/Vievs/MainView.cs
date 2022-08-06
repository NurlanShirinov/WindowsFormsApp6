using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp6.Vievs;

namespace WindowsFormsApp6
{
    public partial class MainView : Form,IMainInterface
    {
        public MainView()
        {
            InitializeComponent();
        }

        public string NameText { get => NameTxtb.Text; set => NameTxtb.Text=value; }
        public string SurnameText { get => SurnameTxtB.Text; set => SurnameTxtB.Text=value; }
        public EventHandler<EventArgs> SaveButton { get ; set; }
         private void SaveBtn_Click(object sender, EventArgs e)
        {
            SaveButton.Invoke(sender, e);
        }
    }
}

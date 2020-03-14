using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            List<Person> list = new List<Person>()
            {
                new Person(){Name = "Trung", Age = 20},
                new Person(){Name = "Minh", Age = 19 },
                new Person(){Name = "Nam", Age = 21}
            };
            cb1.DataSource = list;
            cb1.DisplayMember = "Name";
            AddBinding();

            List<Class> classes = new List<Class>()
            {
                new Class(){ClassName = "12A6", ListStudent = new List<string>(){
                                "Trung", "Minh", "Nam" }
                },

                new Class(){ClassName = "12A5", ListStudent = new List<string>(){
                                "Huy", "Cường", "Tiến" }
                }
            };
            cb3.DataSource = classes;
            cb3.DisplayMember = "ClassName";
        }

        void AddBinding()
        {
            cb2.DataBindings.Add(new Binding("Text", cb1.DataSource, "Age"));
        }

        public class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }
        }

        public class Class
        {
            public string ClassName { get; set; }
            public List<string> ListStudent { get; set; }
        }

        private void cb3_SelectedValueChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            if(cb.SelectedValue != null)
            {
                Class cl = cb.SelectedValue as Class;
                cb4.DataSource = cl.ListStudent;
            }
        }
    }
}

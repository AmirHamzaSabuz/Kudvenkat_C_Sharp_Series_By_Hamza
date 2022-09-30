using System;

using System.Reflection;
using System.Reflection.Metadata;
using System.Runtime.Remoting;

namespace Part_054_Reflection_WinForm_Example
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowTypeNameAndComponentName();


        }

        private void txtTypeName_MouseEnter(object sender, EventArgs e)
        {
        }

        private void ShowTypeNameAndComponentName()
        {
            string TypeName = txtTypeName.Text;
            Type T = Type.GetType(TypeName);

            lstMethods.Items.Clear();
            lstProperties.Items.Clear();
            lstConstructors.Items.Clear();           
            lblEx.Hide();

            if (T == null)
            {
                lblEx.Show();
            }

            else
            {
                lblEx.Hide();
                MethodInfo[] methods = T.GetMethods();
                foreach (MethodInfo method in methods)
                {
                    lstMethods.Items.Add(method.ReturnType.Name + ", " + method.Name);
                }
                PropertyInfo[] properties = T.GetProperties();
                foreach (PropertyInfo property in properties)
                {
                    lstProperties.Items.Add(property.PropertyType.Name + " " + property.Name);
                }
                ConstructorInfo[] constructors = T.GetConstructors();
                foreach (ConstructorInfo constructor in constructors)
                {
                    lstConstructors.Items.Add(constructor.ToString());
                }
            }
        }

        private void txtTypeName_Enter(object sender, EventArgs e)
        {


        }

        private void txtTypeName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTypeName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                //button1.PerformClick();
                ShowTypeNameAndComponentName();
        }//Class

        private void Form1_Load(object sender, EventArgs e)
        {
            lblEx.Hide();
        }
    }
}
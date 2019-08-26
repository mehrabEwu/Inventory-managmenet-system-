/*
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;
using System.Xml;
using System.Xml.Linq;
using System.Reflection;
using RuFramework;

namespace InventorySystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Default file name
            string filename = "PhoneBook.xml";

            // Create phonebook
            PhoneBook phoneBook = new PhoneBook();

            // Create phonenumber
            Number numberRemove = new Number();

            // Add number to phonebook
            Number number = new Number();
            number.Type = "mobil";
            number.Value = "01781111111111";
            phoneBook.Add(number);

            // Add number to phonebook
            number = new Number();
            number.Type = "mobil";
            number.Value = "01782222222222";
            numberRemove = number;
            phoneBook.Add(number);

            // Add number to phonebook
            number = new Number();
            number.Type = "mobil";
            number.Value = "01783333333333";
            phoneBook.Add(number);

            // Add number to phonebook
            phoneBook.Add(new Number("fax", "02241666666"));

            // Delete phone number by number
            // phoneBook.Remove(numberRemove);

            // Delete phone number by index
            // phoneBook.Remove(1);

            // Write to XML file with SaveFileDialog
            RuXML.Write_XML<PhoneBook>(phoneBook, filename, true);

            // Read from XML file with OpenFileDialog
            phoneBook = RuXML.Read_XML<PhoneBook>(filename, true);

            // Display phonebook items
            foreach (Number n in phoneBook.number)
            {
                Console.WriteLine("Type: {0} Value: {1}", n.Type, n.Value);
            }

        }
        [XmlType(TypeName = "phoneBook")]
        public class PhoneBook
        {
            #region Elemets
            [XmlAttribute("nid")]
            public int Nid { get; set; }
            [XmlElement]
            public Number[] number;// { get; set; }
            #endregion

            #region Add/Remove

            public void Add(Number item)
            {
                List<Number> list = new List<Number>();
                if (this.number != null)
                {
                    list = new List<Number>(this.number);
                }
                list.Add(item);
                this.number = list.ToArray();
                this.Nid++;
            }
            public void Remove(Number item)
            {
                if (this.number != null)
                {
                    List<Number> list = new List<Number>(this.number);
                    int index = 0;
                    foreach (Number n in this.number)
                    {
                        if (n == item)
                        {
                            list.RemoveAt(index);
                            this.number = list.ToArray();
                            this.Nid--;
                        }
                        index++;
                    }
                }
            }
            public void Remove(int index)
            {
                if (this.number != null & index < this.Nid)
                {
                    List<Number> list = new List<Number>(this.number);
                    list.RemoveAt(index);
                    this.number = list.ToArray();
                    this.Nid--;
                }
            }
            #endregion
        }

        [XmlType(TypeName = "number")]
        public class Number
        {
            #region Init
            public Number()
            {

            }
            public Number(string type, string value)
            {
                Type = type;
                Value = value;
            }
            #endregion

            #region Element
            [XmlAttribute("type")]
            public string Type { get; set; }

            [XmlAttribute("id")]

            [XmlText]
            public string Value { get; set; }
            #endregion
        }

    }
}
*/
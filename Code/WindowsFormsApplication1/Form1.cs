using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using System.Net;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //When Form initialize, load org types
        private void Form1_Load(object sender, EventArgs e)
        {
            GetOrgTypes();
            cmbState_SelectedIndexChanged(null, null);
        }


        //Get the Orginization type from the URI provided below 
        private void GetOrgTypes()
        {
            // the uri – uniform resource identifier
            string uri = @"http://simon.ist.rit.edu:8080/Services/resources/ESD/OrgTypes";


            // Connect to the web request for the resource you want
            // (In other words - create a socket with the uri)
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(uri);

            // Indicate that you will READ only (thus the GET)
            req.Method = "GET";

            try
            {
                // Get and Store the response and convert it into a usable stream
                HttpWebResponse res = (HttpWebResponse)req.GetResponse();
                Stream str = res.GetResponseStream();

                // Read the stream as an XML object
                XmlReader xr = XmlReader.Create(str);

                // Clear the Combo box before you load it
                cmbOrgType.Items.Clear();

                //add the org types to the combobox
                while (xr.Read())
                {
                    if (xr.Value != "")
                    {
                        xr.ReadToFollowing("type");
                        cmbOrgType.Items.Add(xr.ReadElementContentAsString());
                    }

                }
                // Close the connection to the resource
                res.Close();

            }
            catch
            {
                Console.Write("Error");
            }
            

        }

        private void cmbState_SelectedIndexChanged(object sender, EventArgs e)
        {
            Object selectedItem = cmbState.SelectedItem;
            //get the cities and counties based on the state that the user just selected 
            getCities(selectedItem.ToString());
            getCounties();

            



        }
        //NEED HELP WITH URL!!!!!
        private void getCities(string witchCity)
        {

            if (witchCity == "")
            {
                MessageBox.Show("No Cities Found!");
            }
            else
            {
                // the uri – uniform resource identifier
                string uri = @"http://simon.ist.rit.edu:8080/Services/resources/ESD/Cities?state=" + witchCity;


                // Connect to the web request for the resource you want
                // (In other words - create a socket with the uri)
                HttpWebRequest req = (HttpWebRequest)WebRequest.Create(uri);

                // Indicate that you will READ only (thus the GET)
                req.Method = "GET";

                try
                {
                    // Get and Store the response and convert it into a usable stream
                    HttpWebResponse res = (HttpWebResponse)req.GetResponse();
                    Stream str = res.GetResponseStream();

                    // Read the stream as an XML object
                    XmlReader xr = XmlReader.Create(str);

                    // Clear the Combo box before you load it
                    cmbCity.Items.Clear();

                    //add the org types to the combobox
                    while (xr.Read())
                    {
                        if (xr.Value != "")
                        {
                            xr.ReadToFollowing("city");
                            cmbCity.Items.Add(xr.ReadElementContentAsString());
                        }

                    }
                    // Close the connection to the resource
                    res.Close();

                }
                catch
                {
                    Console.Write("Error");
                }
            


            }
         
        }

        private void getCounties()
        {
        }


        private void Search_Click(object sender, EventArgs e)
        {
            //clear out any data in table
            progressBar.Value = 0;
            //The base URI (ALL organizations)
            string uri = @"http://simon.ist.rit.edu:8080/Services/resources/ESD/Organizations?";
            // add parameters per the search form:

            //Parameters: ".../ESD/Organizations?type= &name= &town= &state= &zip= &county=
            if (cmbOrgType.Text != "")
            { uri = uri + "&type=" + cmbOrgType.Text; }

            if (txbName.Text != "")
            { uri = uri + "&name=" + txbName.Text; }

            if (cmbCity.Text != "" )
            { uri = uri + "&town=" + cmbCity.Text; }

            if (cmbState.Text != "")
            { uri = uri + "&state=" + cmbState.Text; }

            if (cmbCounty.Text != "")
            { uri = uri + "&county=" + cmbCounty.Text; }




            //XML Reader

            // Connect to the web request for the resource you want
            // (In other words - create a socket with the uri)
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(uri);
            
            // Indicate that you will READ only (thus the GET)
            req.Method = "GET";

            try
            {
                // Get and Store the response and convert it into a usable stream

                progressBar.Value = 25;
                HttpWebResponse res = (HttpWebResponse)req.GetResponse();
                Stream str = res.GetResponseStream();
                // Read the stream as an XML object
                XmlReader xr = XmlReader.Create(str);
               
                // Clear the Combo box before you load it
                table.Rows.Clear();

                
                //fill in the data grid
                int row = 0;
                int col = 0;

                while (xr.Read())
                {
                    if (xr.NodeType == XmlNodeType.Element && xr.Name == "row")
                    {
                        row = table.Rows.Add();
                        col = 0;         
                    }
                    else if(xr.NodeType == XmlNodeType.Text)
                    {
                        table.Rows[row].Cells[col].Value = xr.Value;
                        col++;
                    }


                }
                progressBar.Value = 100;
                // Close the connection to the resource
                res.Close();
            }
            catch
            {
                Console.Write("Error");
            }            
        }

        //when the user click on the datagridview 
        private void table_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string OrgID = "";
            DataGridViewRow row = table.Rows[e.RowIndex];
            if (row.Cells[0].Value != null)
            {  
                 OrgID = row.Cells[0].Value.ToString();
                 //Display the tab form
                 tabs tab = new tabs(OrgID);
                 tab.Show();

            }
         }
    }
}

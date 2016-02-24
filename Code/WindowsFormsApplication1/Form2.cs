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
    public partial class tabs : Form
    {
        public tabs(String orginizationID)
        {
            InitializeComponent();
            getGeneral(orginizationID);
            getLocation(orginizationID);
            getTraining(orginizationID);
            getTreatment(orginizationID);      
            getFacilits(orginizationID);
            getEquipment(orginizationID);
            getPhysicians(orginizationID);
            getPeople(orginizationID);

        }

        private void getGeneral(String id)
        {
            // the uri – uniform resource identifier
            string uri = @"http://simon.ist.rit.edu:8080/Services/resources/ESD/"+id+"/General";


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
                dataView.Rows.Clear();
                dataView.Rows.Add();
                for (int i = 0; i < 5; i++)
                {
                    dataView.Rows[0].Cells[i].Style.ForeColor = Color.Red;
                    dataView.Rows[0].Cells[i].Value = "No data found";
                }
                //add the org types to the combobox
                string tagName = "";
                while (xr.Read())
                {
                    if (xr.NodeType == XmlNodeType.Element)
                    {
                        tagName = xr.Name;
                    }
                    else if (xr.NodeType == XmlNodeType.Text)
                    {
                        if (xr.Value != "null") {
                            switch (tagName)
                            {
                                case "name" :
                                    dataView.Rows[0].Cells[0].Value = xr.Value;
                                    dataView.Rows[0].Cells[0].Style.ForeColor = Color.Black;
                                    break;
                                case "description":
                                    dataView.Rows[0].Cells[1].Value = xr.Value;
                                    dataView.Rows[0].Cells[1].Style.ForeColor = Color.Black;
                                    break;
                                case "email":
                                    dataView.Rows[0].Cells[2].Value = xr.Value;
                                    dataView.Rows[0].Cells[2].Style.ForeColor = Color.Black;
                                    break;
                                case "website":
                                    dataView.Rows[0].Cells[3].Value = xr.Value;
                                    dataView.Rows[0].Cells[3].Style.ForeColor = Color.Black;
                                    break;
                                case "nummembers":
                                    dataView.Rows[0].Cells[4].Value = xr.Value;
                                    dataView.Rows[0].Cells[4].Style.ForeColor = Color.Black;
                                    break;
                                case "numcalls":
                                    dataView.Rows[0].Cells[5].Value = xr.Value;
                                    dataView.Rows[0].Cells[5].Style.ForeColor = Color.Black;
                                    break;
                            }
                        }
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

        private void getLocation(String id)
        {
            // the uri – uniform resource identifier
            string uri = @"http://simon.ist.rit.edu:8080/Services/resources/ESD/" + id + "/Locations";


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
                locationDataView.Rows.Clear();
              

                //add the org types to the combobox
                string tagName = "";
                int row = 0;
                while (xr.Read())
                {
                    if (xr.Name == "location" && xr.NodeType == XmlNodeType.Element)
                    {
                        row = locationDataView.Rows.Add();
                        for (int i = 0; i < 14; i++)
                        {
                            locationDataView.Rows[row].Cells[i].Style.ForeColor = Color.Red;
                            locationDataView.Rows[row].Cells[i].Value = "No data found";
                        }
                    }
                     if (xr.NodeType == XmlNodeType.Element)
                    {
                        tagName = xr.Name;
                    }
                    else if (xr.NodeType == XmlNodeType.Text)
                    {
                        if (xr.Value != "null")
                        {
                            switch (tagName)
                            {                                     
                                case "type":
                                    locationDataView.Rows[row].Cells[0].Value = xr.Value;
                                    locationDataView.Rows[row].Cells[0].Style.ForeColor = Color.Black;
                                    break;
                                case "address1":
                                    locationDataView.Rows[row].Cells[1].Value = xr.Value;
                                    locationDataView.Rows[row].Cells[1].Style.ForeColor = Color.Black;
                                    break;
                                case "address2":
                                    locationDataView.Rows[row].Cells[2].Value = xr.Value;
                                    locationDataView.Rows[row].Cells[2].Style.ForeColor = Color.Black;
                                    break;
                                case "city":
                                    locationDataView.Rows[row].Cells[3].Value = xr.Value;
                                    locationDataView.Rows[row].Cells[3].Style.ForeColor = Color.Black;
                                    break;
                                case "state":
                                    locationDataView.Rows[row].Cells[4].Value = xr.Value;
                                    locationDataView.Rows[row].Cells[4].Style.ForeColor = Color.Black;
                                    break;
                                case "zip":
                                    locationDataView.Rows[row].Cells[5].Value = xr.Value;
                                    locationDataView.Rows[row].Cells[5].Style.ForeColor = Color.Black;
                                    break;
                                case "phone":
                                    locationDataView.Rows[row].Cells[6].Value = xr.Value;
                                    locationDataView.Rows[row].Cells[6].Style.ForeColor = Color.Black;
                                    break;
                                case "ttyPhone":
                                    locationDataView.Rows[row].Cells[7].Value = xr.Value;
                                    locationDataView.Rows[row].Cells[7].Style.ForeColor = Color.Black;
                                    break;
                                case "fax":
                                    locationDataView.Rows[row].Cells[8].Value = xr.Value;
                                    locationDataView.Rows[row].Cells[8].Style.ForeColor = Color.Black;
                                    break;
                                case "latitude":
                                    locationDataView.Rows[row].Cells[9].Value = xr.Value;
                                    locationDataView.Rows[row].Cells[9].Style.ForeColor = Color.Black;
                                    break;
                                case "longitude":
                                    locationDataView.Rows[row].Cells[10].Value = xr.Value;
                                    locationDataView.Rows[row].Cells[10].Style.ForeColor = Color.Black;
                                    break;
                                case "countyId":
                                    locationDataView.Rows[row].Cells[11].Value = xr.Value;
                                    locationDataView.Rows[row].Cells[11].Style.ForeColor = Color.Black;
                                    break;
                                case "countyName":
                                    locationDataView.Rows[row].Cells[12].Value = xr.Value;
                                    locationDataView.Rows[row].Cells[12].Style.ForeColor = Color.Black;
                                    break;
                                case "siteId":
                                    locationDataView.Rows[row].Cells[13].Value = xr.Value;
                                    locationDataView.Rows[row].Cells[13].Style.ForeColor = Color.Black;
                                    break;
                            }
                        }
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

        private void getTraining(String id)
        {
            // the uri – uniform resource identifier
            string uri = @"http://simon.ist.rit.edu:8080/Services/resources/ESD/" + id + "/Training";


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
                TrainingDataView.Rows.Clear();

                //add the org types to the combobox
                int row = 0;
                string tagName = "";
                while (xr.Read())
                {
                    if (xr.Name == "training" && xr.NodeType == XmlNodeType.Element)
                    {
                        row = TrainingDataView.Rows.Add();
                        for (int i = 0; i < 3; i++)
                        {
                            TrainingDataView.Rows[row].Cells[i].Style.ForeColor = Color.Red;
                            TrainingDataView.Rows[row].Cells[i].Value = "No data found";
                        }
                    }
                    if (xr.NodeType == XmlNodeType.Element)
                    {
                        tagName = xr.Name;
                    }
                    else if (xr.NodeType == XmlNodeType.Text)
                    {
                        if (xr.Value != "null")
                        {
                            switch (tagName)
                            {
                                case "typeId":
                                    TrainingDataView.Rows[row].Cells[0].Value = xr.Value;
                                    TrainingDataView.Rows[row].Cells[0].Style.ForeColor = Color.Black;
                                    break;
                                case "type":
                                    TrainingDataView.Rows[row].Cells[1].Value = xr.Value;
                                    TrainingDataView.Rows[row].Cells[1].Style.ForeColor = Color.Black;
                                    break;
                                case "abbreviation":
                                    TrainingDataView.Rows[row].Cells[2].Value = xr.Value;
                                    TrainingDataView.Rows[row].Cells[2].Style.ForeColor = Color.Black;
                                    break;
                            }
                        }
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

        private void getTreatment(String id)
        {
            // the uri – uniform resource identifier
            string uri = @"http://simon.ist.rit.edu:8080/Services/resources/ESD/" + id + "/Treatments";


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
                TreatmentDataView.Rows.Clear();

                //add the org types to the combobox
                int row = 0;
                string tagName = "";
                while (xr.Read())
                {
                    if (xr.Name == "treatment" && xr.NodeType == XmlNodeType.Element)
                    {
                        row = TreatmentDataView.Rows.Add();
                        for (int i = 0; i < 3; i++)
                        {
                            TreatmentDataView.Rows[row].Cells[i].Style.ForeColor = Color.Red;
                            TreatmentDataView.Rows[row].Cells[i].Value = "No data found";
                        }
                    }
                    if (xr.NodeType == XmlNodeType.Element)
                    {
                        tagName = xr.Name;
                    }
                    else if (xr.NodeType == XmlNodeType.Text)
                    {
                        if (xr.Value != "null")
                        {
                            switch (tagName)
                            {
                                case "typeId":
                                    TreatmentDataView.Rows[row].Cells[0].Value = xr.Value;
                                    TreatmentDataView.Rows[row].Cells[0].Style.ForeColor = Color.Black;
                                    break;
                                case "type":
                                    TreatmentDataView.Rows[row].Cells[1].Value = xr.Value;
                                    TreatmentDataView.Rows[row].Cells[1].Style.ForeColor = Color.Black;
                                    break;
                                case "abbreviation":
                                    TreatmentDataView.Rows[row].Cells[2].Value = xr.Value;
                                    TreatmentDataView.Rows[row].Cells[2].Style.ForeColor = Color.Black;
                                    break;
                            }
                        }
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

        private void getFacilits(String id)
        {
            // the uri – uniform resource identifier
            string uri = @"http://simon.ist.rit.edu:8080/Services/resources/ESD/" + id + "/Facilities";


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
                FacilitieDataGridVIew.Rows.Clear();

                //add the org types to the combobox
                int row = 0;
                string tagName = "";
                while (xr.Read())
                {
                    if (xr.Name == "facility" && xr.NodeType == XmlNodeType.Element)
                    {
                        row = FacilitieDataGridVIew.Rows.Add();
                        for (int i = 0; i < 4; i++)
                        {
                            FacilitieDataGridVIew.Rows[row].Cells[i].Style.ForeColor = Color.Red;
                            FacilitieDataGridVIew.Rows[row].Cells[i].Value = "No data found";
                        }
                    }
                    if (xr.NodeType == XmlNodeType.Element)
                    {
                        tagName = xr.Name;
                    }
                    else if (xr.NodeType == XmlNodeType.Text)
                    {
                        if (xr.Value != "null")
                        {
                            switch (tagName)
                            {
                                case "typeId":
                                    FacilitieDataGridVIew.Rows[row].Cells[0].Value = xr.Value;
                                    FacilitieDataGridVIew.Rows[row].Cells[0].Style.ForeColor = Color.Black;
                                    break;
                                case "type":
                                    FacilitieDataGridVIew.Rows[row].Cells[1].Value = xr.Value;
                                    FacilitieDataGridVIew.Rows[row].Cells[1].Style.ForeColor = Color.Black;
                                    break;
                                case "quantity":
                                    FacilitieDataGridVIew.Rows[row].Cells[2].Value = xr.Value;
                                    FacilitieDataGridVIew.Rows[row].Cells[2].Style.ForeColor = Color.Black;
                                    break;
                                case "description":
                                    FacilitieDataGridVIew.Rows[row].Cells[3].Value = xr.Value;
                                    FacilitieDataGridVIew.Rows[row].Cells[3].Style.ForeColor = Color.Black;
                                    break;
                            }
                        }
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


        private void getEquipment(String id)
        {
            // the uri – uniform resource identifier
            string uri = @"http://simon.ist.rit.edu:8080/Services/resources/ESD/" + id + "/Equipment";


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
                dataGridView5.Rows.Clear();

                //add the org types to the combobox
                int row = 0;
                string tagName = "";
                while (xr.Read())
                {
                    if (xr.Name == "equipment" && xr.NodeType == XmlNodeType.Element)
                    {
                        row = dataGridView5.Rows.Add();
                        for (int i = 0; i < 4; i++)
                        {
                            dataGridView5.Rows[row].Cells[i].Style.ForeColor = Color.Red;
                            dataGridView5.Rows[row].Cells[i].Value = "No data found";
                        }
                    }
                    if (xr.NodeType == XmlNodeType.Element)
                    {
                        tagName = xr.Name;
                    }
                    else if (xr.NodeType == XmlNodeType.Text)
                    {
                        if (xr.Value != "null")
                        {
                            switch (tagName)
                            {
                                case "typeId":
                                    dataGridView5.Rows[row].Cells[0].Value = xr.Value;
                                    dataGridView5.Rows[row].Cells[0].Style.ForeColor = Color.Black;
                                    break;
                                case "type":
                                    dataGridView5.Rows[row].Cells[1].Value = xr.Value;
                                    dataGridView5.Rows[row].Cells[1].Style.ForeColor = Color.Black;
                                    break;
                                case "quantity":
                                    dataGridView5.Rows[row].Cells[2].Value = xr.Value;
                                    dataGridView5.Rows[row].Cells[2].Style.ForeColor = Color.Black;
                                    break;
                                case "description":
                                    dataGridView5.Rows[row].Cells[3].Value = xr.Value;
                                    dataGridView5.Rows[row].Cells[3].Style.ForeColor = Color.Black;
                                    break;
                            }
                        }
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


        private void getPhysicians(String id)
        {
            // the uri – uniform resource identifier
            string uri = @"http://simon.ist.rit.edu:8080/Services/resources/ESD/" + id + "/Physicians";


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
                dataGridView6.Rows.Clear();

                //add the org types to the combobox
                int row = 0;
                string tagName = "";
                while (xr.Read())
                {
                    if (xr.Name == "physician" && xr.NodeType == XmlNodeType.Element)
                    {
                        row = dataGridView6.Rows.Add();
                        for (int i = 0; i < 6; i++)
                        {
                            dataGridView6.Rows[row].Cells[i].Style.ForeColor = Color.Red;
                            dataGridView6.Rows[row].Cells[i].Value = "No data found";
                        }
                    }
                    if (xr.NodeType == XmlNodeType.Element)
                    {
                        tagName = xr.Name;
                    }
                    else if (xr.NodeType == XmlNodeType.Text)
                    {
                        if (xr.Value != "null")
                        {
                            switch (tagName)
                            {
                                case "personId":
                                    dataGridView6.Rows[row].Cells[0].Value = xr.Value;
                                    dataGridView6.Rows[row].Cells[0].Style.ForeColor = Color.Black;
                                    break;
                                case "fName":
                                    dataGridView6.Rows[row].Cells[1].Value = xr.Value;
                                    dataGridView6.Rows[row].Cells[1].Style.ForeColor = Color.Black;
                                    break;
                                case "mName":
                                    dataGridView6.Rows[row].Cells[2].Value = xr.Value;
                                    dataGridView6.Rows[row].Cells[2].Style.ForeColor = Color.Black;
                                    break;
                                case "lName":
                                    dataGridView6.Rows[row].Cells[3].Value = xr.Value;
                                    dataGridView6.Rows[row].Cells[3].Style.ForeColor = Color.Black;
                                    break;
                                case "suffix":
                                    dataGridView6.Rows[row].Cells[4].Value = xr.Value;
                                    dataGridView6.Rows[row].Cells[4].Style.ForeColor = Color.Black;
                                    break;
                                case "phone":
                                    dataGridView6.Rows[row].Cells[5].Value = xr.Value;
                                    dataGridView6.Rows[row].Cells[5].Style.ForeColor = Color.Black;
                                    break;
                                case "license":
                                    dataGridView6.Rows[row].Cells[6].Value = xr.Value;
                                    dataGridView6.Rows[row].Cells[6].Style.ForeColor = Color.Black;
                                    break;
                            }
                        }
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


        private void getPeople(String id)
        {
            // the uri – uniform resource identifier
            string uri = @"http://simon.ist.rit.edu:8080/Services/resources/ESD/" + id + "/People";


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
                peopleDataView.Rows.Clear();
                
                //add the org types to the combobox
                //int row = 0;
                //int col = 0;
                ListView lv = new ListView();
                int row = 0;
                string tagName = "";
                while (xr.Read())
                {

                    if (xr.Name == "site" && xr.NodeType == XmlNodeType.Element)
                    {
                        row = peopleDataView.Rows.Add();
                        row = peopleDataView.Rows.Add();
                        xr.MoveToAttribute("address");
                        peopleDataView.Rows[row].Cells[0].Value = xr.Value;
                        for (int i = 0; i < 8; i++)
                        {
                            peopleDataView.Rows[row].Cells[i].Style.BackColor = Color.Gainsboro;
                        }
                    }
                    if (xr.Name == "person" && xr.NodeType == XmlNodeType.Element)
                    {
                        row = peopleDataView.Rows.Add();
                        for (int i = 0; i < 7; i++)
                        {
                            peopleDataView.Rows[row].Cells[i].Style.ForeColor = Color.Red;
                            peopleDataView.Rows[row].Cells[i].Value = "No data found";
                        }
                    }
                    if (xr.NodeType == XmlNodeType.Element)
                    {
                        tagName = xr.Name;
                    }
                    else if (xr.NodeType == XmlNodeType.Text)
                    {
                        if (xr.Value != "null")
                        {
                            switch (tagName)
                            {
                                case "personId":
                                    peopleDataView.Rows[row].Cells[0].Value = xr.Value;
                                    peopleDataView.Rows[row].Cells[0].Style.ForeColor = Color.Black;
                                    break;
                                case "honorific":
                                    peopleDataView.Rows[row].Cells[1].Value = xr.Value;
                                    peopleDataView.Rows[row].Cells[1].Style.ForeColor = Color.Black;
                                    break;
                                case "fName":
                                    peopleDataView.Rows[row].Cells[2].Value = xr.Value;
                                    peopleDataView.Rows[row].Cells[2].Style.ForeColor = Color.Black;
                                    break;
                                case "mName":
                                    peopleDataView.Rows[row].Cells[3].Value = xr.Value;
                                    peopleDataView.Rows[row].Cells[3].Style.ForeColor = Color.Black;
                                    break;
                                case "lName":
                                    peopleDataView.Rows[row].Cells[4].Value = xr.Value;
                                    peopleDataView.Rows[row].Cells[4].Style.ForeColor = Color.Black;
                                    break;
                                case "suffix":
                                    peopleDataView.Rows[row].Cells[5].Value = xr.Value;
                                    peopleDataView.Rows[row].Cells[5].Style.ForeColor = Color.Black;
                                    break;
                                case "role":
                                    peopleDataView.Rows[row].Cells[6].Value = xr.Value;
                                    peopleDataView.Rows[row].Cells[6].Style.ForeColor = Color.Black;
                                    break;
                                case "contactmethods":
                                    peopleDataView.Rows[row].Cells[7].Value = xr.Value;
                                    peopleDataView.Rows[row].Cells[7].Style.ForeColor = Color.Black;
                                    break;
                            }
                        }
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

        private void locationDataView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {   
            DataGridViewRow row = locationDataView.Rows[e.RowIndex];
            string lat = row.Cells[9].Value.ToString();
            string log = row.Cells[10].Value.ToString();
            webBrowser.Navigate("http://dev.virtualearth.net/embeddedMap/v1/ajax/road?zoomLevel=15&center=" + lat + "_" + log + "&pushpins=" + lat + "_" + log);
            webBrowser.Visible = true;
            
        }



    }//End of Public Main
}

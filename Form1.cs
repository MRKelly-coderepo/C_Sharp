using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Driver;
using MongoDB.Bson;

namespace UserInformationBase
{
    public partial class Form1 : Form
    {
        public bool connected = false;
        public Form1()
        {
            InitializeComponent();
        }
        public BsonDocument queryDB(object hostAddr, object hostPort)
        {
            var dbClient = new MongoClient();
            var user_list = new BsonDocument();
            if (!connected)
            {
                try
                {
                    dbClient = new MongoClient("mongodb://" + hostAddr + ":" + hostPort);
                    toolStripStatusLabel1.Text = "CONNECTED TO: " + hostAddr;
                    connected = true;
                }
                catch
                {
                    toolStripStatusLabel1.Text = "ERROR CONNECTING TO: " + hostAddr;
                }
                IMongoDatabase db = dbClient.GetDatabase("users");
                var users = db.GetCollection<BsonDocument>("users");
                var user_data = users.Find(new BsonDocument()).ToList();
                foreach (var user in user_data)
                {
                    MessageBox.Show(user.ToString());
                    MessageBox.Show(user.GetType().ToString());
                }
            }
            return user_list;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            var numUsers = 0;
            var user_list = queryDB("127.0.0.1", "27016");
            var user_data = new BsonDocument();
            user_data = user_list.ToBsonDocument();
            var elements = new List<string>();
            foreach (var obj in user_list)
            {
                //{ "_id" : ObjectId("620b0ea75eb84aebf316ce77"), "ID" : 1, "fName" : "John", "lName" : "Doe" }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

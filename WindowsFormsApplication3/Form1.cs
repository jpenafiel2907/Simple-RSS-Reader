using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.ServiceModel.Syndication;
using System.Collections;
using System.Web;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        List<Uri> links;
        List<string> feedSummary;
        
        public Uri uri;
        int index = -1;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            readXML("http://rss.cnn.com/rss/edition.rss");
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            index = listBox1.SelectedIndex;
            webBrowser1.ScriptErrorsSuppressed = true;
            summaryText.Text = feedSummary[index];
            webBrowser1.Navigate(links[index]);
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            readXML("http://feeds.news.com.au/public/rss/2.0/news_national_3354.xml");
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            readXML("http://sbs.feedsportal.com/c/34692/f/637303/index.rss");
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            readXML("http://feeds.reuters.com/reuters/topNews");
            
        }

     

        private void button5_Click(object sender, EventArgs e)
        {
  
            readXML("http://feeds.bbci.co.uk/news/rss.xml");
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            readXML("http://rss.nytimes.com/services/xml/rss/nyt/InternationalHome.xml");
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            readXML("http://www.abs-cbnnews.com/nation/feed");
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            readXML("http://www.gmanetwork.com/news/rss/news");
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            readXML("http://www.inquirer.net/fullfeed");
           
        }

        private void button10_Click(object sender, EventArgs e)
        {
            readXML("http://www.philstar.com/rss/headlines");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            readXML("http://www.mb.com.ph/feed/");
        }

        public void readXML(string rssLink)
        {
            
            XmlReader reader = XmlReader.Create(rssLink);
            SyndicationFeed feed = SyndicationFeed.Load(reader);
            ArrayList myList = new ArrayList();
            links = new List<Uri>();
            feedSummary = new List<string>();

            foreach (SyndicationItem feeds in feed.Items)
            {
                uri = feeds.Links.FirstOrDefault().Uri;
                myList.Add(feeds.Title.Text);
                feedSummary.Add(feeds.Summary.Text);
                links.Add(uri);
            }
            listBox1.DataSource = myList;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (panel1.Visible == false)
            {
                panel1.Visible = true;
                button1.Text = "Hide Browser";
            }
            else 
            {
                panel1.Visible = false;
                button1.Text = "Read More";
            }
        }

        }
    }


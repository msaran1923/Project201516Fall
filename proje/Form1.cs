using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TweetSharp;
using System.Data.SqlClient;

using Word=Microsoft.Office.Interop.Word;
using System.Reflection;

using System.Text.RegularExpressions;


namespace proje
{
    
    public partial class Form1 : Form
    {
        TwitterService servis;

        public Form1()
        {
            InitializeComponent();

           
           

            servis = new TwitterService("0zerSTiym0HQcSz9IOqb4yPX1", "h9DWvLAqoLNlVXQBr1rIPwQCyEboGUyYj0aKOf9BWc5Lkt8Q62", "4003525943-TXBjlpMU9ePC2ClPvXzvpfbPgv6QGjbLMaK3yGO", "4vMJAKX8btRsA7iAJXhid9QwKGlJqepGYPkhKTXZkiW81");

        }

        //SqlConnection connection = new SqlConnection("Data Source=PC;Initial Catalog = proje; Integrated Security=True;");

        Database2DataContext db = new Database2DataContext();

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

       
        private void btnAra_Click(object sender, EventArgs e)
        { 
            int count = 0;
            lstTweets.Items.Clear();
            if (!String.IsNullOrEmpty(txtAra.Text))
            {
                if (rbtnHashtag.Checked)
                {
                    string aranan = "#" + txtAra.Text;
                   var AramaAyari = new SearchOptions
                   { Q = aranan, Count = 20, Lang ="tr"};
                   var Ara = servis.Search(AramaAyari);


                    /* for (int i = 0; i < 5; i++)
                     {
                         var statusTweets = (from tweet in twitterCtx.Status
                                             where tweet.Type == StatusType.User &&
                                             tweet.Count == 200 &&
                                             tweet.ScreenName == "username" &&
                                             tweet.Page == i
                                             select tweet)
                                             linqtosql
                      }*/
                    //twitter4j tweets more than 100 


                    foreach (var i in Ara.Statuses)
                    {
                        
                     
                        count++;
                        //string s = i.Language;
                        var Tweets = String.Format("{0}: {1}. tweet: '{2}'",i.CreatedDate.AddHours(3), count, i.Text);
                        lstTweets.Items.Add(Tweets);
                        
                    }

                    //txtspellcheck.Text += Tweets+"\n";
                    //fSpellCheck(txtspellcheck, label2);
                }

                else if (rbtnKelime.Checked)
                {
                    string aranan = txtAra.Text;
                    var AramaAyari = new SearchOptions { Q = aranan, Count = 20 };
                    var Ara = servis.Search(AramaAyari);
                    foreach (var i in Ara.Statuses)
                    {
                        count++;
                        var Tweets = String.Format("{0}. tweet: '{1}'", count, i.Text);
                        lstTweets.Items.Add(Tweets);

                    }
                }
                else
                {
                    MessageBox.Show("Ne ile arama yapacağınızı seçin lütfen", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Arayacağınız kelimeyi girin lütfen", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {

        }


       private void btn_kaydet_Click(object sender, EventArgs e)
        {
           
            // List<tweet> twt = new List<tweet>();
            
            for (int i = 0; i < lstTweets.Items.Count; i++)
            {
                
                tweet t = new tweet();
                
                t.text = lstTweets.Items[i].ToString();
                t.kategori_id = 3;
                //t.kurumId = user.kurumId
                db.tweets.InsertOnSubmit(t);
            }
            db.SubmitChanges();
            
            //tweet t = new tweet();
            //t.text =lstTweets.Items.ToString();
            //t.kategori_id = '3';
            //db.tweets.InsertOnSubmit(t);
            //db.SubmitChanges();
            //MessageBox.Show("Tweetler kaydedildi");

            /*cankayaüniversitesi'ni hashtag tablosuna mı eklememiz gerekiyor?cankayaüniversitesi ile ilgili tweetleri
            Database'e kaydederken hangi hashtag veya kelimenin tweetleri olduğunu nasıl belirleyecegiz.*/

            /*for (int i = 0; i < lstTweets.Items.Count; i++)
           {
               t.text = lstTweets.Items[i].ToString();
               twt.Add(t);
           }*/

        }

        private void lstTweets_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //public void fSpellCheck(TextBox tBox, Label lLbl)
        //{
        //    int iErrorCount = 0;
        //    Word.Application app = new Word.Application();
        //    if (tBox.Text.Length > 0)
        //    {
        //        app.Visible = false;
        //        // Setting these variables is comparable
        //        // to passing null to the function. 
        //        // This is necessary because the C# null
        //        // cannot be passed by reference. 
        //        object template = Missing.Value;
        //        object newTemplate = Missing.Value;
        //        object documentType = Missing.Value;
        //        object visible = true;
        //        object optional = Missing.Value;

        //        var doc = app.Documents.Add(ref template,
        //           ref newTemplate, ref documentType, ref visible);
        //        doc.Words.First.InsertBefore(tBox.Text);
        //        Word.ProofreadingErrors we = doc.SpellingErrors;
        //        iErrorCount = we.Count;
        //        doc.CheckSpelling(ref optional, ref optional, ref optional,
        //            ref optional, ref optional, ref optional, ref optional,
        //            ref optional, ref optional, ref optional,
        //            ref optional, ref optional);
        //        if (iErrorCount == 0)
        //            lLbl.Text = "Spelling OK. No errors corrected ";
        //        else if (iErrorCount == 1)
        //            lLbl.Text = "Spelling OK. 1 error corrected ";
        //        else
        //            lLbl.Text = "Spelling OK. " + iErrorCount +
        //                                    " errors corrected ";
        //        object first = 0;
        //        object last = doc.Characters.Count - 1;
        //        tBox.Text = doc.Range(ref first, ref last).Text;
        //    }
        //    else
        //        lLbl.Text = "Textbox is empty";
        //    object saveChanges = false;
        //    object originalFormat = Missing.Value;
        //    object routeDocument = Missing.Value;
        //    app.Quit(ref saveChanges, ref originalFormat, ref routeDocument);
        //}
    }
}

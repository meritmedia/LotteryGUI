/*
 * Name: Charles Pecot
 * Date: Sept 29, 2015
 * Project: Exercise 4.9
 * If else logic, switches, and booleans
 */
using System;
using System.Configuration;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Diagnostics;


namespace LotteryGUI
{


    public partial class frmLotto : Form
    {// initialize Random, generate lotto numbers

        string meritmedia = ConfigurationManager.ConnectionStrings["meritmedia"].ConnectionString;
        static Random rnd = new Random();
        int[] LottoNums = new int[3];
        //int bank = 0, lastWin=0;
        const int bet = -15;
        const int MAXNUM = 9;
        const int MAXCHANCES = 3;
        int[] RULESHEIGHT = { 25, 170 };
        int chances = MAXCHANCES;
        string[,] winText = new string[5, 2];
        DateTime winningDateTime = DateTime.Now;
        static Random ticketIDRnd = new Random();
        string ticketID = ticketIDRnd.Next(1, 100000).ToString("00000");

        enum winType
        {
            MATCH4 = 0, MATCH3, MATCH2, MATCH1, NOWIN
        }
        enum winAmount
        {
            MATCH4 = 10000, MATCH3 = 1000, MATCH2 = 100, MATCH1 = 10, NOWIN = 0
        }
        private void GetData()
        {
            try {
                DataSet ds = new DataSet();

                SqlConnection connectStr = new SqlConnection(meritmedia);
                //String query = "select top 3 * from slb_scratcherPrizes_v";
                String query = "exec slbTop3_p";
                var slbDataAdapter = new SqlDataAdapter(query, connectStr);
                SqlCommandBuilder slbCommandBuilder = new SqlCommandBuilder(slbDataAdapter);
                slbDataAdapter.Fill(ds, "slbData");
                EnumerableRowCollection<DataRow> slbQuery = from row in ds.Tables["slbData"].AsEnumerable()
                                                            select row;
                DataTable myData = slbQuery.CopyToDataTable<DataRow>();
                DataView view = new DataView(myData);

                createWinLabels(myData);


            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void PostData(string match, string prize, string myTicketID)
        {
            DataSet dsUpdate = new DataSet();

            System.TimeSpan duration = new System.TimeSpan(2, 0, 0, 0);
            System.DateTime expires = winningDateTime.Add(duration);
            SqlConnection connectionStr = new SqlConnection(meritmedia);
            SqlCommand command = new SqlCommand("select top 1 from slb_bands", connectionStr);
            command.Connection.Open();
            string queryStr = "insert into slb_winningTickets(ticketID, match, prize, expires) " +
                "values ('" + ticketID + "','" + match + "','" + prize + "','" + expires + "');";

            SqlCommand query = new SqlCommand(queryStr, connectionStr);
            query.ExecuteNonQuery();
            command.Connection.Close();
            WriteIt(ticketID);
        }
        public frmLotto()
        {
            InitializeComponent();

            btnTryAgainKeepNumbers.Enabled = false;
            //  lblMatch1x2.Visible = false;

            txtTicketID.Text = ticketID;
            lblInstruction1.Text = "Pick 3 numbers between 1 and " + MAXNUM + ".";
            lblErrorMsg.Text = "";
            GetData();
            winText[0, 0] = "No Match";
            winText[1, 0] = "Any one matching";
            winText[2, 0] = "Two matching";
            winText[3, 0] = "Three matching, not in order";
            winText[4, 0] = "Three matching, in exact order";
            btnTryAgainKeepNumbers.Visible = false;
            panel1.Height = RULESHEIGHT[0];
        }

        public void createWinLabels(DataTable myData)
        {
            winText[0, 1] = "Try again.";
            winText[1, 1] = myData.Rows[0]["matchPrize1"].ToString();
            winText[2, 1] = myData.Rows[0]["matchPrize2"].ToString();
            winText[3, 1] = myData.Rows[0]["matchPrize3"].ToString();
            winText[4, 1] = myData.Rows[0]["matchPrize4"].ToString();

            lblInfo.Text = myData.Rows[0]["dba"].ToString() + "\n" +
                myData.Rows[0]["address"].ToString() + "\n" +
                myData.Rows[0]["phone"].ToString();

            LinkLabel.Link link1 = new LinkLabel.Link();
            LinkLabel.Link link2 = new LinkLabel.Link();
            LinkLabel.Link link3 = new LinkLabel.Link();

            llblFacebook.Text = "Facebook";
            link1.LinkData = "https://www.facebook.com/" + myData.Rows[0]["Facebook"].ToString();
            llblFacebook.Links.Add(link1);

            llblTwitter.Text = "Twitter";
            link2.LinkData = "http://www.twitter.com/" + myData.Rows[0]["twitter"].ToString();
            llblTwitter.Links.Add(link2);

            llblWebsite.Text = "Website";
            link3.LinkData = myData.Rows[0]["website"].ToString();
            llblWebsite.Links.Add(link3);

            lblRules.Text = "Rules (click here):" + Environment.NewLine + Environment.NewLine +
                "\u2022 One winning ticket per customer per day." + Environment.NewLine +
                "\u2022 Prizes subject to change." + Environment.NewLine +
                "\u2022 To claim your prize: click 'Edit', enter the winning ticket ID, " +
                "then click 'Claim ticket' and show the ticket to the bartender." + Environment.NewLine +
                "\u2022 Winning tickets are not accumulated. Only the last winning ticket is valid.";




            lblEvents.Text = "This Week's Events\n";
            lblEvents.Text += Convert.ToDateTime(myData.Rows[0]["booked_date"]).ToString("ddd") + ": " +
                 myData.Rows[0]["band_name"].ToString() + "\n";
            lblEvents.Text += Convert.ToDateTime(myData.Rows[1]["booked_date"]).ToString("ddd") + ": " +
                 myData.Rows[1]["band_name"].ToString() + "\n";
            lblEvents.Text += Convert.ToDateTime(myData.Rows[2]["booked_date"]).ToString("ddd") + ": " +
                 myData.Rows[2]["band_name"].ToString() + "\n";
        }

        public void getLottoNums() {
            lblErrorMsg.Text = "";
            for (int element = 0; element < 3; ++element)
            {
                LottoNums[element] = rnd.Next(1, MAXNUM);
            }
            txtLotto1.Text = LottoNums[0].ToString();
            txtLotto2.Text = LottoNums[1].ToString();
            txtLotto3.Text = LottoNums[2].ToString();
        }

        private void btnReveal_Click(object sender, EventArgs e)
        { // check the guess numbers entered 
            btnTryAgainKeepNumbers.Visible = true;
            if ((txtGuess1.Text != "") && (txtGuess2.Text != "") && (txtGuess3.Text != ""))
            {
                int[] myGuesses = new int[3] {
                 Convert.ToInt16(txtGuess1.Text),
                 Convert.ToInt16(txtGuess2.Text),
                 Convert.ToInt16(txtGuess3.Text)
            }; // check for range
                if ((myGuesses[0] <= MAXNUM && myGuesses[1] <= MAXNUM && myGuesses[2] <= MAXNUM &&
                    myGuesses[0] > 0 && myGuesses[1] > 0 && myGuesses[2] > 0)
                     )
                { // disable the input fields because we're generating the lotto numbers
                    txtGuess1.Enabled = false;
                    txtGuess2.Enabled = false;
                    txtGuess3.Enabled = false;
                    getLottoNums();

                    // the logic to find winners starts here ****************************************
                    string LottoNumsStr = txtLotto1.Text + txtLotto2.Text + txtLotto3.Text;
                    string[] match = new string[] {
                          txtGuess1.Text + txtGuess2.Text + txtGuess3.Text,
                          txtGuess1.Text + txtGuess2.Text,
                          txtGuess2.Text + txtGuess3.Text,
                          txtGuess1.Text,
                          txtGuess2.Text,
                          txtGuess3.Text};
                    int whichMatch = (int)winType.NOWIN;
                    if (LottoNumsStr == match[0])
                    { whichMatch = (int)winType.MATCH4;
                        txtGuess1.BackColor = System.Drawing.Color.LightGreen;
                        txtGuess2.BackColor = System.Drawing.Color.LightGreen;
                        txtGuess3.BackColor = System.Drawing.Color.LightGreen;
                    }
                    else
                    if (countChars(match[3], match[0]) == countChars(match[3], LottoNumsStr) &&
                        countChars(match[4], match[0]) == countChars(match[4], LottoNumsStr) &&
                        countChars(match[5], match[0]) == countChars(match[5], LottoNumsStr))
                    { whichMatch = (int)winType.MATCH3;
                        txtGuess1.BackColor = System.Drawing.Color.LightGreen;
                        txtGuess2.BackColor = System.Drawing.Color.LightGreen;
                        txtGuess3.BackColor = System.Drawing.Color.LightGreen;
                    }
                    else
                    if (LottoNumsStr.Substring(0, 2) == match[1])
                    { whichMatch = (int)winType.MATCH2;
                        txtGuess1.BackColor = System.Drawing.Color.LightGreen;
                        txtGuess2.BackColor = System.Drawing.Color.LightGreen;
                    }
                    else
                    if (LottoNumsStr.Substring(1, 2) == match[2])
                    { whichMatch = (int)winType.MATCH2;
                        txtGuess2.BackColor = System.Drawing.Color.LightGreen;
                        txtGuess3.BackColor = System.Drawing.Color.LightGreen;
                    }

                    int winFactor = 0;

                    if ((winType)whichMatch == winType.NOWIN)
                    {
                        if (countChars(match[3], LottoNumsStr) >= 1)
                        { ++winFactor;
                            txtGuess1.BackColor = System.Drawing.Color.LightGreen;
                        }

                        if (match[4] == match[3] && countChars(match[4], LottoNumsStr) >= 2)
                        { ++winFactor; txtGuess2.BackColor = System.Drawing.Color.LightGreen; }

                        if (match[4] != match[3] && countChars(match[4], LottoNumsStr) >= 1)
                        { ++winFactor; txtGuess2.BackColor = System.Drawing.Color.LightGreen; }

                        if ((match[5] == match[4] || match[5] == match[3]) &&
                            countChars(match[5], match[0]) == 2 &&
                            countChars(match[5], LottoNumsStr) >= 2)
                        { ++winFactor; txtGuess3.BackColor = System.Drawing.Color.LightGreen;

                        }

                        if (countChars(match[5], match[0]) == 1 && countChars(match[5], LottoNumsStr) >= 1)
                        { ++winFactor; txtGuess3.BackColor = Color.LightGreen; }

                        if (winFactor > 0) whichMatch = (int)winType.MATCH1;
                    }
                    // End of tests ************************************************************
                    System.TimeSpan duration = new System.TimeSpan(2, 0, 0, 0);
                    System.DateTime expires = winningDateTime.Add(duration);

                    switch ((winType)whichMatch)
                    {
                        case winType.MATCH4:

                            btnTryAgainKeepNumbers.Text = "Winning Ticket ID: " + ticketID +
                                Environment.NewLine +
                                winText[4, 0] + ": " + winText[4, 1] + Environment.NewLine +
                                "Expires: " + expires;
                            chances = 0;
                            PostData(winText[4, 0], winText[4, 1], ticketID);
                            break;
                        case winType.MATCH3:

                            btnTryAgainKeepNumbers.Text = "Winning Ticket ID: " + ticketID +
                                Environment.NewLine +
                                winText[3, 0] + ": " + winText[3, 1] + Environment.NewLine +
                                "Expires: " + expires; ;
                            chances = 0;
                            PostData(winText[3, 0], winText[3, 1], ticketID);
                            break;
                        case winType.MATCH2:

                            btnTryAgainKeepNumbers.Text = "Winning Ticket ID: " + ticketID +
                                Environment.NewLine +
                                winText[2, 0] + ": " + winText[2, 1] + Environment.NewLine +
                                "Expires: " + expires;
                            chances = 0;
                            PostData(winText[2, 0], winText[2, 1], ticketID);
                            break;
                        case winType.MATCH1:

                            chances = 0;

                            if (winFactor > 1)
                            {

                                btnTryAgainKeepNumbers.Text = "Winning Ticket ID: " + ticketID +
                                    Environment.NewLine +
                                    winText[1, 0] + ": " + winText[1, 1] + " X2" + Environment.NewLine +
                                "Expires: " + expires;

                                PostData(winText[1, 0], winText[1, 1] + " X2", ticketID);
                            } else
                            {
                                btnTryAgainKeepNumbers.Text = "Winning Ticket ID: " + ticketID +
                                    Environment.NewLine +
                                    winText[1, 0] + ": " + winText[1, 1] + Environment.NewLine +
                                "Expires: " + expires;
                                PostData(winText[1, 0], winText[1, 1], ticketID);
                            }
                            break;
                        case winType.NOWIN:

                            --chances;
                            btnTryAgainKeepNumbers.Text = winText[0, 0] + 
                                Environment.NewLine + chances + " chances left";

                            break;
                        default:
                            break;
                    }


                    btnReveal.Enabled = false;
                    if (chances > 0)
                    {
                        btnTryAgainKeepNumbers.Visible = true;
                        btnTryAgainKeepNumbers.Enabled = true;
                    }
                    else
                    {
                        btnClaimTicket.Visible = true;
                        btnTryAgainKeepNumbers.BackColor = Color.Yellow;
                    }
                } else {
                    lblErrorMsg.Text = "The numbers must be between 1 and " + MAXNUM + "!";
                    txtGuess1.Focus();
                }
            }
            else
            {
                lblErrorMsg.Text = "You first need to pick 3 numbers between 1 and " + MAXNUM + "!";
            }
        }
        private static int countChars(string myChar, string myString)
        {
            int freq = 0;
            for (int x = 0; x < myString.Length; ++x)
            { if (myChar == myString.Substring(x, 1)) ++freq; }
            return freq;
        }

        private void reset()
        {
            btnReveal.Enabled = true;
            btnTryAgainKeepNumbers.Visible = false;
            txtGuess1.BackColor = System.Drawing.Color.White;
            txtGuess2.BackColor = System.Drawing.Color.White;
            txtGuess3.BackColor = System.Drawing.Color.White;
            txtLotto1.Text = "?";
            txtLotto2.Text = "?";
            txtLotto3.Text = "?";
            btnTryAgainKeepNumbers.Enabled = false;
            txtGuess1.Enabled = true;
            txtGuess2.Enabled = true;
            txtGuess3.Enabled = true;
            txtGuess1.Focus();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void btnTryAgainKeepNumbers_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void llblFacebook_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(e.Link.LinkData as string);
        }

        private void llblTwitter_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(e.Link.LinkData as string);
        }

        private void llblWebsite_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(e.Link.LinkData as string);
        }

        private void btnClaimTicket_Click(object sender, EventArgs e)
        {
            btnTryAgainKeepNumbers.Visible = true;
            txtTicketID.Enabled = false;
            if (txtTicketID.Text.Length != 5) { txtTicketID.Text = ticketID; }
            try
            {
                DataSet dsWinner = new DataSet();

                SqlConnection connectStr = new SqlConnection(meritmedia);
                String query = "exec slb_getWinningTicket_p '" +
                    txtTicketID.Text + "'";

                var slbDataAdapter = new SqlDataAdapter(query, connectStr);
                SqlCommandBuilder slbCommandBuilder = new SqlCommandBuilder(slbDataAdapter);
                slbDataAdapter.Fill(dsWinner, "slbWinner");
                EnumerableRowCollection<DataRow> slbQuery = from row in dsWinner.Tables["slbWinner"].AsEnumerable()
                                                            select row;
                DataTable myWinData = slbQuery.CopyToDataTable<DataRow>();
                DataView view = new DataView(myWinData);
                GetWindata(myWinData);
            }
            catch (SqlException ex)
            {
                lblErrorMsg.Text = ex.Message;
            }
            btnClaimTicket.Visible = false;
            txtGuess1.Enabled = false;
            txtGuess2.Enabled = false;
            txtGuess3.Enabled = false;
        }

        private void btnEditTicket_Click(object sender, EventArgs e)
        {
            string myTicketID = System.IO.File.ReadAllText(@"slbScratcher\ticketID.txt");
            txtTicketID.Enabled = true;
            txtTicketID.Text = myTicketID;
            ticketID = myTicketID;
            btnClaimTicket.Visible = true;
            txtTicketID.Focus();
        }
        private void GetWindata(DataTable myWinData)
        {
            string ticketID = myWinData.Rows[0]["ticketID"].ToString();
            string match = myWinData.Rows[0]["match"].ToString();
            string prize = myWinData.Rows[0]["prize"].ToString();
            DateTime expires = Convert.ToDateTime(myWinData.Rows[0]["expires"].ToString());
            btnTryAgainKeepNumbers.Text = "Ticket ID: " + ticketID + Environment.NewLine +
                match + ": " + prize + Environment.NewLine +
                "Expires: " + expires;
            btnTryAgainKeepNumbers.BackColor = Color.White;
            btnReveal.Enabled = false;
            btnGetNewTicket.Enabled = true;
        }

        private void btnGetNewTicket_Click(object sender, EventArgs e)
        {
            ticketID = ticketIDRnd.Next(1, 100000).ToString("00000");
            txtTicketID.Text = ticketID;
            txtGuess1.Text = "";
            txtGuess2.Text = "";
            txtGuess3.Text = "";
            reset();
            btnGetNewTicket.Enabled = false;
        }

        public static string GnirtsEsrever(string s)
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }

        private void txtGuess1_TextChanged(object sender, EventArgs e)
        {
            ZeroTest(txtGuess1.Text);
            txtGuess1.Focus();
        }

        private void txtGuess2_TextChanged(object sender, EventArgs e)
        {
            ZeroTest(txtGuess2.Text);
            txtGuess2.Focus();
        }

        private void ZeroTest(string zero)
        {
            if (zero == "0") {
                lblErrorMsg.Text = "Your number must be between 1 and 9!";
            }
            else
            {
                lblErrorMsg.Text = "";
            }
        }

        private void txtGuess3_TextChanged(object sender, EventArgs e)
        {
            ZeroTest(txtGuess3.Text);
            txtGuess3.Focus();
        }

        private void btnClaimTicket_Leave(object sender, EventArgs e)
        {
            btnClaimTicket.Visible = false;
        }

        private void btnEditTicket_Leave(object sender, EventArgs e)
        {
            // btnClaimTicket.Visible = false;
        }

        private void frmLotto_Load(object sender, EventArgs e)
        {

        }

        private void SaveTicketID(string winningID)
        {
           // System.IO.File.WriteAllText(@"C:\Users\Public\TestFolder\WriteLines.txt", winningID);
        }


        public static void WriteIt(string myTicketID)
        {
            //string path = @"c:\users\user\slbScratcher\ticketID.txt";
            string path = @"slbScratcher\ticketID.txt";
            System.IO.FileInfo file = new System.IO.FileInfo(path);
            file.Directory.Create(); // If the directory already exists, this method does nothing.
            System.IO.File.WriteAllText(file.FullName, myTicketID);
        }

        
        private void panel1_Paint(object sender, PaintEventArgs e)

        {
            
        }
        private void lblRules_Click(object sender, EventArgs e)
        {
        if (panel1.Height == RULESHEIGHT[0])
            { 
            panel1.Height = RULESHEIGHT[1];
            }
            else { panel1.Height = RULESHEIGHT[0]; }
        }

        private void lblEvents_Click(object sender, EventArgs e)
        {

        }
        //*****************************************************************************
    }
}

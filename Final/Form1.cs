using System.Data.SqlClient;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Drawing.Text;
using System.Diagnostics;

namespace Final
{
    public partial class Form1 : Form
    {
        private List<string> descriptionList = new List<string>();
        private List<string> partNoList = new List<string>();
        private List<string> barcodeList = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void button_execute_Click(object sender, EventArgs e)
        {
            SqlConnection connection = null;
            descriptionList.Clear();
            partNoList.Clear();
            barcodeList.Clear();
            comboBox_rowSelect.Items.Clear();
            comboBox_rowSelect.Text = "";
            richTextBox_description.Clear();
            richTextBox_barcode.Clear();
            textBox_partno.Clear();
            label_queryRow.Text = "Get 0 rows from DB";

            try
            {
                connection = new SqlConnection(textBox_connectionStr.Text);
                connection.Open();
            }catch (Exception ex)
            {
                MessageBox.Show("Can't open database with current connection String. Error:" + ex.Message);
                return;
            }
            try
            {
                SqlCommand cmd = new SqlCommand(richTextBox_query.Text,connection);
                SqlDataReader reader = cmd.ExecuteReader();
                int rowNum = 0;
                while (reader.Read())
                {
                    descriptionList.Add(reader["description"].ToString());
                    partNoList.Add(reader["partNo"].ToString());
                    barcodeList.Add(reader["barcode"].ToString());
                    comboBox_rowSelect.Items.Add(++rowNum);
                }
                comboBox_rowSelect.SelectedIndex = 0;
                label_queryRow.Text = String.Format("Get {0} rows from DB",rowNum);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error in executing query. Error : " + ex.Message);
            }
        }

        private void comboBox_rowSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = comboBox_rowSelect.SelectedIndex;
            richTextBox_description.Text = descriptionList[index];
            richTextBox_barcode.Text = barcodeList[index];
            textBox_partno.Text = partNoList[index];
        }

        private void button_generate_Click(object sender, EventArgs e)
        {
            //Font font = new Font("Times new Roman",16);
            //Color fontColor = Color.Blue;
            //int width = 300;
            //int height = 100;
            //int maxWidth = 200;
            //Image image = new Bitmap(width, height);

            //Graphics graphics = Graphics.FromImage(image);

            //Image image1 = Bitmap.FromFile("logo.png");
            //graphics.DrawImage(image1, new Rectangle(0, 0, image1.Width, image1.Height));

            //SizeF textSize = graphics.MeasureString(richTextBox_description.Text, font, maxWidth);
            //StringFormat sf = new StringFormat();
            //sf.Trimming = StringTrimming.Word;
            //graphics.CompositingQuality = CompositingQuality.HighQuality;
            //graphics.InterpolationMode = InterpolationMode.HighQualityBilinear;
            //graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
            //graphics.SmoothingMode = SmoothingMode.HighQuality;
            //graphics.TextRenderingHint = TextRenderingHint.AntiAliasGridFit;

            //Brush textBrush = new SolidBrush(fontColor);

            //graphics.DrawString(richTextBox_description.Text, font, textBrush, new RectangleF(50, 50, textSize.Width, textSize.Height), sf);



            //graphics.Save();

            //textBrush.Dispose();

            //pictureBox_preview.Image = image;
            generate();

        }

        private void generate()
        {
            try
            {
                string[] settings = richTextBox_setting.Text.Split("\n");
                // width, height
                int imgWidth = getValue(settings[0]);
                int imgHeight = getValue(settings[1]);
                Image image = new Bitmap(imgWidth, imgHeight);

                Graphics graphics = Graphics.FromImage(image);
                graphics.Clear(Color.White);

                // outline
                int outlineMargin = getValue(settings[2]);
                int outlineMarginTop = getValue(settings[3]);
                graphics.DrawRectangle(new Pen(Color.Black), outlineMargin, outlineMarginTop,
                    imgWidth - 2 * outlineMargin, imgHeight - outlineMargin - outlineMarginTop);

                // logoImage
                int logoStx = getValue(settings[4]);
                int logoSty = getValue(settings[5]);
                int logoWidth = getValue(settings[6]);
                int logoHeight = getValue(settings[7]);
                if (pictureBox_logo.Image != null && pictureBox_logo.Image.Width > 1)
                    graphics.DrawImage(pictureBox_logo.Image, logoStx, logoSty, logoWidth, logoHeight);

                // Description
                int descstx = getValue(settings[8]);
                int descsty = getValue(settings[9]);
                string fontFamily = getString(settings[10]);
                int fontSize = getValue(settings[11]);
                int maxWidth = getValue(settings[12]);


                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBilinear;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.TextRenderingHint = TextRenderingHint.AntiAliasGridFit;
                StringFormat sf = new StringFormat();
                sf.Trimming = StringTrimming.Word;
                Brush textBrush = new SolidBrush(Color.Black);

                SizeF textSize = graphics.MeasureString(richTextBox_description.Text, new Font(fontFamily, fontSize), maxWidth);
                graphics.DrawString(richTextBox_description.Text, new Font(fontFamily, fontSize), textBrush, new RectangleF(descstx, descsty, textSize.Width, textSize.Height), sf);

                int partNostx = getValue(settings[13]);
                int partNosty = getValue(settings[14]);
                int partNoFontSize = getValue(settings[15]);
                int partNoMaxWidth = getValue(settings[16]);
                textSize = graphics.MeasureString(textBox_partno.Text, new Font(fontFamily, partNoFontSize), partNoMaxWidth);
                graphics.DrawString(textBox_partno.Text, new Font(fontFamily, partNoFontSize), textBrush, new RectangleF(partNostx, partNosty, textSize.Width, textSize.Height), sf);

                int barcodestx = getValue(settings[17]);
                int barcodesty = getValue(settings[18]);
                int barcodewidth = getValue(settings[19]);
                int barcodeheight = getValue(settings[20]);
                if (pictureBox_barcode.Image != null && pictureBox_barcode.Image.Width > 1)
                    graphics.DrawImage(pictureBox_barcode.Image, barcodestx, barcodesty, barcodewidth, barcodeheight);

                graphics.Save();
                pictureBox_preview.Image = image;
            }
            catch(Exception ex)
            {
                MessageBox.Show("please input the setting correctly!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private int getValue(string str)
        {
            if (str == "") return 0;
            string[] strs = str.Split(':');
            return int.Parse(strs[strs.Length - 1]);
        }

        private string getString(string str)
        {
            if (str == "") return "";
            string[] strs = str.Split(':');
            return strs[strs.Length - 1];
        }

        private void button_logo_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox_logo.Image = Bitmap.FromFile(openFileDialog1.FileName);
            }
        }

        private void button_logoRemove_Click(object sender, EventArgs e)
        {
            pictureBox_logo.Image = new Bitmap(1, 1);
        }

        private void button_barcodeGen_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("node/setting.ini", FileMode.OpenOrCreate, FileAccess.Write);
            fs.SetLength(0);
            StreamWriter sw = new StreamWriter(fs);
            
            if (radioButton_barcode.Checked)
            {
                sw.WriteLine("b");
            }
            else
            {
                sw.WriteLine("q");
            }
            string fileName = DateTime.Now.ToFileTime().ToString() + ".png";
            sw.WriteLine(fileName);
            sw.WriteLine(richTextBox_barcode.Text);
            sw.Flush();
            sw.Close();
            fs.Close();

            Process p = new Process();
            p.StartInfo.WorkingDirectory = System.Environment.CurrentDirectory + "\\node";
            p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            p.StartInfo.FileName = "cmd.exe";
            p.StartInfo.Arguments = "/c node index.js";
            p.Start();

            Thread.Sleep(1000);

            pictureBox_barcode.Image = Bitmap.FromFile(@"./node/barcodes/" + fileName);
        }

        private void button_barcodeRem_Click(object sender, EventArgs e)
        {
            pictureBox_barcode.Image = new Bitmap(1, 1);
        }

        private void button_open_Click(object sender, EventArgs e)
        {
            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox_preview.Image.Save(saveFileDialog1.FileName, ImageFormat.Png);
            }
        }
    }
}
namespace WefghDrawing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // LoadFont();
        }
        private void LoadFont()
        {
            try
            {
                var fonts = FontLoader.LoadEmbeddedFont("WefghDrawing.Assets.Fonts.Vazirmatn-Regular.ttf");
                // this.Font = new Font(fonts.Families[0], 10f); // برای کل فرم
                //MessageBox.Show(fonts.Families.Length + "");
                foreach (Control control in this.Controls)
                {
                    control.Font = new Font(fonts.Families[0], 10f);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Font error");
                throw;
            }
        }
        private void btnCalculator_Click(object sender, EventArgs e)
        {
            var rakNumber = AbjadKabir.Calculate(richTBRak.Text);
            var rafdNumber = AbjadKabir.Calculate(richTBRafd.Text);

            lblResult_Rak.Text = (rakNumber + numericRak.Value).ToString() + " :عدد ابجد + رک ";
            lblResult_Rafd.Text = (rafdNumber + numericRafd.Value).ToString() + " :عدد ابجد + رفد ";
            lblResult_Sum_Col_Row.Text = ((rakNumber + numericRak.Value) + (rafdNumber + numericRafd.Value)).ToString() + " :جمع سطر و ستون ها ";

            var RakMeftah = ComputeMeftah((int)(rakNumber + numericRak.Value));
            lblResult_RakMeftah.Text = RakMeftah.ToString() + " :عدد مفتاح طالب ";

            var RafdMeftah = ComputeMeftah((int)(rafdNumber + numericRafd.Value));
            lblResult_RafdMeftah.Text = RafdMeftah.ToString() + " :عدد مفتاح مطلوب ";

            var isRakZoj = (rakNumber + numericRak.Value) % 2 == 0;
            var isRafdZoj = (rafdNumber + numericRafd.Value) % 2 == 0;

            FillTableType1(RakMeftah, isRakZoj, RafdMeftah, isRafdZoj);
            //FillTableType2(RakMeftah, isRakZoj, RafdMeftah, isRafdZoj);

        }

        private void FillTableType2(int meftahRak, bool isZojRak, int meftahRafd, bool isZojRafd)
        {
            List<Control> lableListRak = new List<Control>(8);
            List<Control> lableListRafd = new List<Control>(8);

            foreach (Control control in tableLayoutPanel3.Controls)
            {
                if (control is Label && control.Name.StartsWith("lblTable_Rak_Type2"))
                {
                    lableListRak.Add(control);
                }
                if (control is Label && control.Name.StartsWith("lblTable_Rafd_Type2"))
                {
                    lableListRafd.Add(control);
                }
            }

            lableListRak.Sort((a, b) => string.Compare(a.Name, b.Name, StringComparison.OrdinalIgnoreCase));
            lableListRafd.Sort((a, b) => string.Compare(a.Name, b.Name, StringComparison.OrdinalIgnoreCase));

            for (int i = 0; i < lableListRak.Count; i++)
            {
                if (isZojRak == true)
                {
                    if (i == 4)
                    {
                        meftahRak += 1;
                        lableListRak[i].Text = meftahRak + "";
                    }
                    else
                    {
                        lableListRak[i].Text = meftahRak + "";
                        meftahRak++;
                    }
                }
                else
                {
                    lableListRak[i].Text = meftahRak + "";
                    meftahRak++;
                }
            }

            for (int i = 0; i < lableListRafd.Count; i++)
            {
                if (isZojRafd == true)
                {
                    if (i == 4)
                    {
                        meftahRafd += 1;
                        lableListRafd[i].Text = meftahRafd + "";
                        meftahRafd++;
                    }
                    else
                    {
                        lableListRafd[i].Text = meftahRafd + "";
                        meftahRafd++;
                    }
                }
                else
                {
                    lableListRafd[i].Text = meftahRafd + "";
                    meftahRafd++;
                }
            }

        }

        private void FillTableType1(int meftahRak, bool isZojRak, int meftahRafd, bool isZojRafd)
        {
            List<Control> lableListRak = new List<Control>(8);
            List<Control> lableListRafd = new List<Control>(8);

            foreach (Control control in tableLayoutPanel2.Controls)
            {
                if (control is Label && control.Name.StartsWith("lblTable_Rak_"))
                {
                    lableListRak.Add(control);
                }
                if (control is Label && control.Name.StartsWith("lblTable_Rafd_"))
                {
                    lableListRafd.Add(control);
                }
            }



            lableListRak.Sort((a, b) => string.Compare(a.Name, b.Name, StringComparison.OrdinalIgnoreCase));
            lableListRafd.Sort((a, b) => string.Compare(a.Name, b.Name, StringComparison.OrdinalIgnoreCase));

            if (isZojRak == false && isZojRafd == false)
            {
                meftahRak -= 3;
                meftahRafd -= 4;
            }
            else if (isZojRak == true && isZojRafd == true)
            {
                meftahRak -= 4;
                meftahRafd -= 3;
            }
            else if (isZojRak == false && isZojRafd == true)
            {
                meftahRak -= 4;
                meftahRafd -= 3;

            }
            else if (isZojRak == true && isZojRafd == false)
            {
                meftahRak -= 3;
                meftahRafd -= 4;
            }

            for (int i = 0; i < lableListRak.Count; i++)
            {
                if (isZojRak == false && isZojRafd == true)
                {
                    if (i == 4)
                    {
                        meftahRak += 1;
                        lableListRak[i].Text = meftahRak + "";
                    }
                    else
                    {
                        lableListRak[i].Text = meftahRak + "";
                        meftahRak++;
                    }
                }
                else
                {
                    lableListRak[i].Text = meftahRak + "";
                    meftahRak++;
                }
            }

            for (int i = 0; i < lableListRafd.Count; i++)
            {
                if (isZojRak == true && isZojRafd == false)
                {
                    if (i == 4)
                    {
                        meftahRafd += 1;
                        lableListRafd[i].Text = meftahRafd + "";
                        meftahRafd++;
                    }
                    else
                    {
                        lableListRafd[i].Text = meftahRafd + "";
                        meftahRafd++;
                    }
                }
                else
                {
                    lableListRafd[i].Text = meftahRafd + "";
                    meftahRafd++;
                }
            }

        }

        // محاسبه عدد مفتاح وفق
        private int ComputeMeftah(int abjad)
        {
            return abjad / 2;

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            numericRak.Value = Properties.Settings.Default.RakNumber;
            numericRafd.Value = Properties.Settings.Default.RafdNumber;


        }

        private void btnConfigSave_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.RakNumber = (long)numericRak.Value;
            Properties.Settings.Default.RafdNumber = (long)numericRafd.Value;
            Properties.Settings.Default.Save();

        }

    }
}

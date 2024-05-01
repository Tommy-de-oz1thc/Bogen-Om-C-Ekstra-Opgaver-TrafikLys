using System.Collections.Generic;
using System.Drawing.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace BackGammon
{
    public partial class Start : Form
    {
        enum Turn { White, Black }

        Random random = new();

        Settings set = new();
        private bool run = false;
        SetCordinates setCor = new();
        private List<Terning> _rafleList = new();
        public RafleBæger rafle = new RafleBæger(2);
        private bool terning_1_is_used = false, terning_2_is_used = false;
        private Turn currentTurn;
        private Random rand = new Random();
        List<Bricks> brickList = new List<Bricks>();

        int barBlack = 0;
        int barWhite = 0;
        Point point1, point2, point3, point4, point5, point6, point7, point8, point9, point10, point11, point12, point13, point14, point15,
            point16, point17, point18, point19, point20, point21, point22, point23, point24, point25, point26, point27, point28, point29, point30;
        int i = 0;
        public Start()
        {
            set.Cordinates();
            SetBricks setBricks = new(); ;

            Settings.field1.colorBricksonField = Bricks.BrickColor.White;
            Settings.field12.colorBricksonField = Bricks.BrickColor.White;
            Settings.field17.colorBricksonField = Bricks.BrickColor.White;
            Settings.field19.colorBricksonField = Bricks.BrickColor.White;
            Settings.field6.colorBricksonField = Bricks.BrickColor.Black;
            Settings.field8.colorBricksonField = Bricks.BrickColor.Black;
            Settings.field13.colorBricksonField = Bricks.BrickColor.Black;
            Settings.field24.colorBricksonField = Bricks.BrickColor.Black;
            _rafleList = rafle.getRafleList();

            InitializeComponent();
            SetPictureBox();


        }

        private void Terninger()
        {

            _rafleList[0].Ryst();
            _rafleList[1].Ryst();
            _rafleList = rafle.getRafleList();
            btnTerning_1.Text = _rafleList[0].GetTerning().ToString();
            btnTerning_2.Text = _rafleList[1].GetTerning().ToString();


        }

        private void SetPictureBox()
        {
            pictureBoxWhite_1.Image = Image.FromFile("images/white.jpg");
            pictureBoxWhite_2.Image = Image.FromFile("images/white.jpg");
            pictureBoxWhite_3.Image = Image.FromFile("images/white.jpg");
            pictureBoxWhite_4.Image = Image.FromFile("images/white.jpg");
            pictureBoxWhite_5.Image = Image.FromFile("images/white.jpg");
            pictureBoxWhite_6.Image = Image.FromFile("images/white.jpg");
            pictureBoxWhite_7.Image = Image.FromFile("images/white.jpg");
            pictureBoxWhite_8.Image = Image.FromFile("images/white.jpg");
            pictureBoxWhite_9.Image = Image.FromFile("images/white.jpg");
            pictureBoxWhite_10.Image = Image.FromFile("images/white.jpg");
            pictureBoxWhite_11.Image = Image.FromFile("images/white.jpg");
            pictureBoxWhite_12.Image = Image.FromFile("images/white.jpg");
            pictureBoxWhite_13.Image = Image.FromFile("images/white.jpg");
            pictureBoxWhite_14.Image = Image.FromFile("images/white.jpg");
            pictureBoxWhite_15.Image = Image.FromFile("images/white.jpg");

            pictureBoxBlack_1.Image = Image.FromFile("images/black.jpg");
            pictureBoxBlack_2.Image = Image.FromFile("images/black.jpg");
            pictureBoxBlack_3.Image = Image.FromFile("images/black.jpg");
            pictureBoxBlack_4.Image = Image.FromFile("images/black.jpg");
            pictureBoxBlack_5.Image = Image.FromFile("images/black.jpg");
            pictureBoxBlack_6.Image = Image.FromFile("images/black.jpg");
            pictureBoxBlack_7.Image = Image.FromFile("images/black.jpg");
            pictureBoxBlack_8.Image = Image.FromFile("images/black.jpg");
            pictureBoxBlack_9.Image = Image.FromFile("images/black.jpg");
            pictureBoxBlack_10.Image = Image.FromFile("images/black.jpg");
            pictureBoxBlack_11.Image = Image.FromFile("images/black.jpg");
            pictureBoxBlack_12.Image = Image.FromFile("images/black.jpg");
            pictureBoxBlack_13.Image = Image.FromFile("images/black.jpg");
            pictureBoxBlack_14.Image = Image.FromFile("images/black.jpg");
            pictureBoxBlack_15.Image = Image.FromFile("images/black.jpg");

            pictureBoxTurnWhite.Image = Image.FromFile("images/white.jpg");
            pictureBoxTurnBlack.Image = Image.FromFile("images/black.jpg");

        }
        private void setLocationPictureBox()
        {

            point1 = new Point(Settings.brick1.X, Settings.brick1.Y + Settings.y_heigh[0]);
            point2 = new Point(Settings.brick2.X, Settings.brick2.Y + Settings.y_heigh[0]);
            point3 = new Point(Settings.brick3.X, Settings.brick3.Y + Settings.y_heigh[0]);
            point4 = new Point(Settings.brick4.X, Settings.brick4.Y + Settings.y_heigh[0]);
            point5 = new Point(Settings.brick5.X, Settings.brick5.Y + Settings.y_heigh[0]);
            point6 = new Point(Settings.brick6.X, Settings.brick6.Y + Settings.y_heigh[0]);
            point7 = new Point(Settings.brick7.X, Settings.brick7.Y + Settings.y_heigh[0]);
            point8 = new Point(Settings.brick8.X, Settings.brick8.Y + Settings.y_heigh[0]);
            point9 = new Point(Settings.brick9.X, Settings.brick9.Y + Settings.y_heigh[0]);
            point10 = new Point(Settings.brick10.X, Settings.brick10.Y + Settings.y_heigh[0]);
            point11 = new Point(Settings.brick11.X, Settings.brick11.Y + Settings.y_heigh[0]);
            point12 = new Point(Settings.brick12.X, Settings.brick12.Y + Settings.y_heigh[0]);
            point13 = new Point(Settings.brick12.X, Settings.brick13.Y + Settings.y_heigh[0]);
            point14 = new Point(Settings.brick14.X, Settings.brick14.Y + Settings.y_heigh[0]);
            point15 = new Point(Settings.brick15.X, Settings.brick15.Y + Settings.y_heigh[0]);

            point16 = new Point(Settings.brick16.X, Settings.brick16.Y + Settings.y_heigh[0]);
            point17 = new Point(Settings.brick17.X, Settings.brick17.Y + Settings.y_heigh[0]);
            point18 = new Point(Settings.brick18.X, Settings.brick18.Y + Settings.y_heigh[0]);
            point19 = new Point(Settings.brick19.X, Settings.brick19.Y + Settings.y_heigh[0]);
            point20 = new Point(Settings.brick20.X, Settings.brick20.Y + Settings.y_heigh[0]);
            point21 = new Point(Settings.brick21.X, Settings.brick21.Y - Settings.y_heigh[0]);
            point22 = new Point(Settings.brick22.X, Settings.brick22.Y - Settings.y_heigh[0]);
            point23 = new Point(Settings.brick23.X, Settings.brick23.Y - Settings.y_heigh[0]);
            point24 = new Point(Settings.brick24.X, Settings.brick24.Y - Settings.y_heigh[0]);
            point25 = new Point(Settings.brick25.X, Settings.brick25.Y - Settings.y_heigh[0]);
            point26 = new Point(Settings.brick26.X, Settings.brick26.Y - Settings.y_heigh[0]);
            point27 = new Point(Settings.brick27.X, Settings.brick27.Y - Settings.y_heigh[0]);
            point28 = new Point(Settings.brick28.X, Settings.brick28.Y - Settings.y_heigh[0]);
            point29 = new Point(Settings.brick29.X, Settings.brick29.Y - Settings.y_heigh[0]);
            point30 = new Point(Settings.brick30.X, Settings.brick30.Y - Settings.y_heigh[0]);

            pictureBoxWhite_1.Location = point1;
            pictureBoxWhite_2.Location = point2;
            pictureBoxWhite_3.Location = point3;
            pictureBoxWhite_4.Location = point4;
            pictureBoxWhite_5.Location = point5;
            pictureBoxWhite_6.Location = point6;
            pictureBoxWhite_7.Location = point7;
            pictureBoxWhite_8.Location = point8;
            pictureBoxWhite_9.Location = point9;
            pictureBoxWhite_10.Location = point10;
            pictureBoxWhite_11.Location = point11;
            pictureBoxWhite_12.Location = point12;
            pictureBoxWhite_13.Location = point13;
            pictureBoxWhite_14.Location = point14;
            pictureBoxWhite_15.Location = point15;

            pictureBoxBlack_1.Location = point16;
            pictureBoxBlack_2.Location = point17;
            pictureBoxBlack_3.Location = point18;
            pictureBoxBlack_4.Location = point19;
            pictureBoxBlack_5.Location = point20;
            pictureBoxBlack_6.Location = point21;
            pictureBoxBlack_7.Location = point22;
            pictureBoxBlack_8.Location = point23;
            pictureBoxBlack_9.Location = point24;
            pictureBoxBlack_10.Location = point25;
            pictureBoxBlack_11.Location = point26;
            pictureBoxBlack_12.Location = point27;
            pictureBoxBlack_13.Location = point28;
            pictureBoxBlack_14.Location = point29;
            pictureBoxBlack_15.Location = point30;


            labelBlackBar.Text = barBlack.ToString();
            labelWhiteBar.Text = barWhite.ToString();
        }




        private void btnStart_Click(object sender, EventArgs e)
        {
            currentTurn = (Turn)rand.Next(2);
            if (currentTurn == Turn.White)
            {
                pictureBoxTurnBlack.Visible = false;
                pictureBoxTurnWhite.Visible = true;
            }
            else
            {
                pictureBoxTurnBlack.Visible = true;
                pictureBoxTurnWhite.Visible = false;
            }

            Terninger();

            setLocationPictureBox();
        }

        private void btnTerning_1_Click(object sender, EventArgs e)
        {
            terning_1_is_used = true;
            btnTerning_1.Enabled = false;
            CheckChangeTurn();
        }

        private void btnTerning_2_Click(object sender, EventArgs e)
        {
            terning_2_is_used = true;
            btnTerning_2.Enabled = false;
            CheckChangeTurn();
        }

        private void CheckChangeTurn()
        {
            if (terning_1_is_used && terning_2_is_used)
            {

                btnTerning_1.Enabled = true;
                btnTerning_2.Enabled = true;
                terning_1_is_used = false;
                terning_2_is_used = false;
                if (currentTurn == Turn.White)
                {
                    pictureBoxTurnBlack.Visible = false;
                    pictureBoxTurnWhite.Visible = true;
                    currentTurn = Turn.Black;
                }
                else
                {
                    pictureBoxTurnBlack.Visible = true;
                    pictureBoxTurnWhite.Visible = false;
                    currentTurn = Turn.White;
                }

                Terninger();
            }
        }


        private bool CanMoveBrick(int fieldNumber, Bricks brick, List<Bricks> brickList)
        {
           

            // Tjek om der er nogen brikker på feltet
            if (brickList.Count > 0)
            {
                // Hent den sidste brik på feltet
                Bricks lastBrick = brickList[brickList.Count - 1];

                // Tjek om den sidste brik er den samme som den aktuelle brik
                if (lastBrick.BrickNr == brick.BrickNr)
                {
                    MessageBox.Show("You can move.");
                    return true; // Brikken må flyttes, da den er den sidste på feltet
                }
            }
            MessageBox.Show("You can not move");
            return false; // Brikken må ikke flyttes
        }



        private void pictureBoxWhite_1_Click(object sender, EventArgs e)
        {
          
            int fieldnr = Settings.brick1.Field;
         
            if (fieldnr == 0)
            {
                brickList = Settings.field0.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick1.Field.ToString() + " " + CanMoveBrick(0, Settings.brick1, brickList));
            }
            if (fieldnr == 1)
            {
                List<Bricks> brickList = Settings.field1.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick1.Field.ToString() + " " + CanMoveBrick(1, Settings.brick1, brickList));
            }
            if (fieldnr == 2)
            {
                brickList = Settings.field2.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick1.Field.ToString() + " " + CanMoveBrick(2, Settings.brick1, brickList));
            }
            if (fieldnr == 3)
            {
                brickList = Settings.field3.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick1.Field.ToString() + " " + CanMoveBrick(3, Settings.brick1, brickList));
            }
            if (fieldnr == 4)
            {
                brickList = Settings.field4.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick1.Field.ToString() + " " + CanMoveBrick(4, Settings.brick1, brickList));
            }
            if (fieldnr == 5)
            {
                brickList = Settings.field5.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick1.Field.ToString() + " " + CanMoveBrick(5, Settings.brick1, brickList));
            }
            if (fieldnr == 6)
            {
                brickList = Settings.field6.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick1.Field.ToString() + " " + CanMoveBrick(6, Settings.brick1, brickList));
            }
            if (fieldnr == 7)
            {
                brickList = Settings.field7.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick1.Field.ToString() + " " + CanMoveBrick(7, Settings.brick1, brickList));
            }
            if (fieldnr == 8)
            {
                brickList = Settings.field8.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick1.Field.ToString() + " " + CanMoveBrick(8, Settings.brick1, brickList));
            }
            if (fieldnr == 9)
            {
                brickList = Settings.field9.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick1.Field.ToString() + " " + CanMoveBrick(9, Settings.brick1, brickList));
            }
            if (fieldnr == 10)
            {
                brickList = Settings.field10.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick1.Field.ToString() + " " + CanMoveBrick(10, Settings.brick1, brickList));
            }
            if (fieldnr == 11)
            {
                brickList = Settings.field11.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick1.Field.ToString() + " " + CanMoveBrick(11, Settings.brick1, brickList));
            }
            if (fieldnr == 12)
            {
                brickList = Settings.field12.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick1.Field.ToString() + " " + CanMoveBrick(12, Settings.brick1, brickList));
            }
            if (fieldnr == 13)
            {
                brickList = Settings.field13.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick1.Field.ToString() + " " + CanMoveBrick(13, Settings.brick1, brickList));
            }
            if (fieldnr == 14)
            {
                brickList = Settings.field14.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick1.Field.ToString() + " " + CanMoveBrick(14, Settings.brick1, brickList));
            }
            if (fieldnr == 15)
            {
                brickList = Settings.field15.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick1.Field.ToString() + " " + CanMoveBrick(15, Settings.brick1, brickList));
            }
            if (fieldnr == 16)
            {
                brickList = Settings.field16.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick1.Field.ToString() + " " + CanMoveBrick(16, Settings.brick1, brickList));
            }
            if (fieldnr == 17)
            {
                brickList = Settings.field17.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick1.Field.ToString() + " " + CanMoveBrick(17, Settings.brick1, brickList));
            }
            if (fieldnr == 18)
            {
                brickList = Settings.field18.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick1.Field.ToString() + " " + CanMoveBrick(18, Settings.brick1, brickList));
            }
            if (fieldnr == 19)
            {
                brickList = Settings.field19.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick1.Field.ToString() + " " + CanMoveBrick(19, Settings.brick1, brickList));
            }
            if (fieldnr == 20)
            {
                brickList = Settings.field20.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick1.Field.ToString() + " " + CanMoveBrick(202, Settings.brick1, brickList));
            }
            if (fieldnr == 21)
            {
                brickList = Settings.field21.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick1.Field.ToString() + " " + CanMoveBrick(21, Settings.brick1, brickList));
            }
            if (fieldnr == 22)
            {
                brickList = Settings.field22.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick1.Field.ToString() + " " + CanMoveBrick(22, Settings.brick1, brickList));
            }
            if (fieldnr == 23)
            {
                brickList = Settings.field23.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick1.Field.ToString() + " " + CanMoveBrick(23, Settings.brick1, brickList));
            }
            if (fieldnr == 24)
            {
                brickList = Settings.field24.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick1.Field.ToString() + " " + CanMoveBrick(24, Settings.brick1, brickList));
            }
            if (fieldnr == 25)
            {
                brickList = Settings.field25.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick1.Field.ToString() + " " + CanMoveBrick(25, Settings.brick1, brickList));
            }
            if (fieldnr == 26)
            {
                brickList = Settings.field26.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick1.Field.ToString() + " " + CanMoveBrick(26, Settings.brick1, brickList));
            }
            if (fieldnr == 27)
            {
                brickList = Settings.field27.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick1.Field.ToString() + " " + CanMoveBrick(27, Settings.brick1, brickList));
            }
           
            

        }
        private void pictureBoxWhite_2_Click(object sender, EventArgs e)
        {
            int fieldnr = Settings.brick2.Field;
            if (fieldnr == 0)
            {
                brickList = Settings.field0.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick2.Field.ToString() + " " + CanMoveBrick(0, Settings.brick2, brickList));
            }
            if (fieldnr == 1)
            {
                List<Bricks> brickList = Settings.field1.GetListBricks();

                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick2.Field.ToString() + " " + CanMoveBrick(1, Settings.brick2, brickList));

            }
            if (fieldnr == 2)
            {
                brickList = Settings.field2.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick2.Field.ToString() + " " + CanMoveBrick(2, Settings.brick2, brickList));
            }
            if (fieldnr == 3)
            {
                brickList = Settings.field3.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick2.Field.ToString() + " " + CanMoveBrick(3, Settings.brick2, brickList));
            }
            if (fieldnr == 4)
            {
                brickList = Settings.field4.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick2.Field.ToString() + " " + CanMoveBrick(4, Settings.brick2, brickList));
            }
            if (fieldnr == 5)
            {
                brickList = Settings.field5.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick2.Field.ToString() + " " + CanMoveBrick(5, Settings.brick2, brickList));
            }
            if (fieldnr == 6)
            {
                brickList = Settings.field6.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick2.Field.ToString() + " " + CanMoveBrick(6, Settings.brick2, brickList));
            }
            if (fieldnr == 7)
            {
                brickList = Settings.field7.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick2.Field.ToString() + " " + CanMoveBrick(7, Settings.brick2, brickList));
            }
            if (fieldnr == 8)
            {
                brickList = Settings.field8.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick2.Field.ToString() + " " + CanMoveBrick(8, Settings.brick2, brickList));
            }
            if (fieldnr == 9)
            {
                brickList = Settings.field9.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick2.Field.ToString() + " " + CanMoveBrick(9, Settings.brick2, brickList));
            }
            if (fieldnr == 10)
            {
                brickList = Settings.field10.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick2.Field.ToString() + " " + CanMoveBrick(10, Settings.brick2, brickList));
            }
            if (fieldnr == 11)
            {
                brickList = Settings.field11.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick2.Field.ToString() + " " + CanMoveBrick(11, Settings.brick2, brickList));
            }
            if (fieldnr == 12)
            {
                brickList = Settings.field12.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick2.Field.ToString() + " " + CanMoveBrick(12, Settings.brick2, brickList));
            }
            if (fieldnr == 13)
            {
                brickList = Settings.field13.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick2.Field.ToString() + " " + CanMoveBrick(13, Settings.brick2, brickList));
            }
            if (fieldnr == 14)
            {
                brickList = Settings.field14.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick2.Field.ToString() + " " + CanMoveBrick(14, Settings.brick2, brickList));
            }
            if (fieldnr == 15)
            {
                brickList = Settings.field15.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick2.Field.ToString() + " " + CanMoveBrick(52, Settings.brick2, brickList));
            }
            if (fieldnr == 16)
            {
                brickList = Settings.field16.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick2.Field.ToString() + " " + CanMoveBrick(16, Settings.brick2, brickList));
            }
            if (fieldnr == 17)
            {
                brickList = Settings.field17.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick2.Field.ToString() + " " + CanMoveBrick(17, Settings.brick2, brickList));
            }
            if (fieldnr == 18)
            {
                brickList = Settings.field18.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick2.Field.ToString() + " " + CanMoveBrick(18, Settings.brick2, brickList));
            }
            if (fieldnr == 19)
            {
                brickList = Settings.field19.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick2.Field.ToString() + " " + CanMoveBrick(19, Settings.brick2, brickList));
            }
            if (fieldnr == 20)
            {
                brickList = Settings.field20.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick2.Field.ToString() + " " + CanMoveBrick(20, Settings.brick2, brickList));
            }
            if (fieldnr == 21)
            {
                brickList = Settings.field21.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick2.Field.ToString() + " " + CanMoveBrick(21, Settings.brick2, brickList));
            }
            if (fieldnr == 22)
            {
                brickList = Settings.field22.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick2.Field.ToString() + " " + CanMoveBrick(22, Settings.brick2, brickList));
            }
            if (fieldnr == 23)
            {
                brickList = Settings.field23.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick2.Field.ToString() + " " + CanMoveBrick(23, Settings.brick2, brickList));
            }
            if (fieldnr == 24)
            {
                brickList = Settings.field24.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick2.Field.ToString() + " " + CanMoveBrick(24, Settings.brick2, brickList));
            }
            if (fieldnr == 25)
            {
                brickList = Settings.field25.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick2.Field.ToString() + " " + CanMoveBrick(25, Settings.brick2, brickList));
            }
            if (fieldnr == 26)
            {
                brickList = Settings.field26.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick2.Field.ToString() + " " + CanMoveBrick(26, Settings.brick2, brickList));
            }
            if (fieldnr == 27)
            {
                brickList = Settings.field27.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick2.Field.ToString() + " " + CanMoveBrick(27, Settings.brick2, brickList));
            }

        }


        private void pictureBoxWhite_3_Click(object sender, EventArgs e)
        {

            int fieldnr = Settings.brick3.Field;
            if (fieldnr == 0)
            {
                brickList = Settings.field0.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick3.Field.ToString() + " " + CanMoveBrick(0, Settings.brick3, brickList));
            }
            if (fieldnr == 1)
            {
                brickList = Settings.field1.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick3.Field.ToString() + " " + CanMoveBrick(1, Settings.brick3, brickList));
            }
            if (fieldnr == 2)
            {
                brickList = Settings.field2.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick3.Field.ToString() + " " + CanMoveBrick(2, Settings.brick3, brickList));
            }
            if (fieldnr == 3)
            {
                brickList = Settings.field3.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick3.Field.ToString() + " " + CanMoveBrick(3, Settings.brick3, brickList));
            }
            if (fieldnr == 4)
            {
                brickList = Settings.field4.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick3.Field.ToString() + " " + CanMoveBrick(4, Settings.brick3, brickList));
            }
            if (fieldnr == 5)
            {
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick3.Field.ToString() + " " + CanMoveBrick(5, Settings.brick3, brickList));
            }
            if (fieldnr == 6)
            {
                brickList = Settings.field6.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick3.Field.ToString() + " " + CanMoveBrick(6, Settings.brick3, brickList));
            }
            if (fieldnr == 7)
            {
                brickList = Settings.field7.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick3.Field.ToString() + " " + CanMoveBrick(7, Settings.brick3, brickList));
            }
            if (fieldnr == 8)
            {
                brickList = Settings.field8.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick3.Field.ToString() + " " + CanMoveBrick(8, Settings.brick3, brickList));
            }
            if (fieldnr == 9)
            {
                brickList = Settings.field9.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick3.Field.ToString() + " " + CanMoveBrick(9, Settings.brick3, brickList));
            }
            if (fieldnr == 10)
            {
                brickList = Settings.field10.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick3.Field.ToString() + " " + CanMoveBrick(10, Settings.brick3, brickList));
            }
            if (fieldnr == 11)
            {
                brickList = Settings.field11.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick3.Field.ToString() + " " + CanMoveBrick(11, Settings.brick3, brickList));
            }
            if (fieldnr == 12)
            {
                brickList = Settings.field12.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick3.Field.ToString() + " " + CanMoveBrick(12, Settings.brick3, brickList));
            }
            if (fieldnr == 13)
            {
                brickList = Settings.field13.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick3.Field.ToString() + " " + CanMoveBrick(13, Settings.brick3, brickList));
            }
            if (fieldnr == 14)
            {
                brickList = Settings.field14.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick3.Field.ToString() + " " + CanMoveBrick(14, Settings.brick3, brickList));
            }
            if (fieldnr == 15)
            {
                brickList = Settings.field15.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick3.Field.ToString() + " " + CanMoveBrick(15, Settings.brick3, brickList));
            }
            if (fieldnr == 16)
            {
                brickList = Settings.field16.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick3.Field.ToString() + " " + CanMoveBrick(16, Settings.brick3, brickList));
            }
            if (fieldnr == 17)
            {
                brickList = Settings.field17.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick3.Field.ToString() + " " + CanMoveBrick(17, Settings.brick3, brickList));
            }
            if (fieldnr == 18)
            {
                brickList = Settings.field18.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick3.Field.ToString() + " " + CanMoveBrick(18, Settings.brick3, brickList));
            }
            if (fieldnr == 19)
            {
                brickList = Settings.field19.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick3.Field.ToString() + " " + CanMoveBrick(19, Settings.brick3, brickList));
            }
            if (fieldnr == 20)
            {
                brickList = Settings.field20.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick3.Field.ToString() + " " + CanMoveBrick(20, Settings.brick3, brickList));
            }
            if (fieldnr == 21)
            {
                brickList = Settings.field21.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick3.Field.ToString() + " " + CanMoveBrick(21, Settings.brick3, brickList));
            }
            if (fieldnr == 22)
            {
                brickList = Settings.field22.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick3.Field.ToString() + " " + CanMoveBrick(22, Settings.brick3, brickList));
            }
            if (fieldnr == 23)
            {
                brickList = Settings.field23.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick3.Field.ToString() + " " + CanMoveBrick(23, Settings.brick3, brickList));
            }
            if (fieldnr == 24)
            {
                brickList = Settings.field24.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick3.Field.ToString() + " " + CanMoveBrick(24, Settings.brick3, brickList));
            }
            if (fieldnr == 25)
            {
                brickList = Settings.field25.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick3.Field.ToString() + " " + CanMoveBrick(24, Settings.brick3, brickList));
            }
            if (fieldnr == 26)
            {
                brickList = Settings.field26.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick3.Field.ToString() + " " + CanMoveBrick(26, Settings.brick3, brickList));
            }
            if (fieldnr == 27)
            {
                brickList = Settings.field27.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick3.Field.ToString() + " " + CanMoveBrick(27, Settings.brick3, brickList));
            }
        }

        private void pictureBoxWhite_4_Click(object sender, EventArgs e)
        {

            int fieldnr = Settings.brick4.Field;
            if (fieldnr == 0)
            {
                brickList = Settings.field0.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick4.Field.ToString() + " " + CanMoveBrick(0, Settings.brick4, brickList));
            }
            if (fieldnr == 1)
            {
                brickList = Settings.field1.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick4.Field.ToString() + " " + CanMoveBrick(1, Settings.brick4, brickList));
            }
            if (fieldnr == 2)
            {
                brickList = Settings.field2.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick4.Field.ToString() + " " + CanMoveBrick(2, Settings.brick4, brickList));
            }
            if (fieldnr == 3)
            {
                brickList = Settings.field3.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick4.Field.ToString() + " " + CanMoveBrick(3, Settings.brick4, brickList));
            }
            if (fieldnr == 4)
            {
                brickList = Settings.field4.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick4.Field.ToString() + " " + CanMoveBrick(4, Settings.brick4, brickList));
            }
            if (fieldnr == 5)
            {
                brickList = Settings.field5.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick4.Field.ToString() + " " + CanMoveBrick(5, Settings.brick4, brickList));
            }
            if (fieldnr == 6)
            {
                brickList = Settings.field6.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick4.Field.ToString() + " " + CanMoveBrick(6, Settings.brick4, brickList));
            }
            if (fieldnr == 7)
            {
                brickList = Settings.field7.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick4.Field.ToString() + " " + CanMoveBrick(7, Settings.brick4, brickList));
            }
            if (fieldnr == 8)
            {
                brickList = Settings.field8.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick4.Field.ToString() + " " + CanMoveBrick(8, Settings.brick4, brickList));
            }
            if (fieldnr == 9)
            {
                brickList = Settings.field9.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick4.Field.ToString() + " " + CanMoveBrick(9, Settings.brick4, brickList));
            }
            if (fieldnr == 10)
            {
                brickList = Settings.field10.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick4.Field.ToString() + " " + CanMoveBrick(10, Settings.brick4, brickList));
            }
            if (fieldnr == 11)
            {
                brickList = Settings.field11.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick4.Field.ToString() + " " + CanMoveBrick(11, Settings.brick4, brickList));
            }
            if (fieldnr == 12)
            {
                brickList = Settings.field12.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick4.Field.ToString() + " " + CanMoveBrick(12, Settings.brick4, brickList));
            }
            if (fieldnr == 13)
            {
                brickList = Settings.field13.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick4.Field.ToString() + " " + CanMoveBrick(13, Settings.brick4, brickList));
            }
            if (fieldnr == 14)
            {
                brickList = Settings.field14.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick4.Field.ToString() + " " + CanMoveBrick(14, Settings.brick4, brickList));
            }
            if (fieldnr == 15)
            {
                brickList = Settings.field15.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick4.Field.ToString() + " " + CanMoveBrick(15, Settings.brick4, brickList));
            }
            if (fieldnr == 16)
            {
                brickList = Settings.field16.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick4.Field.ToString() + " " + CanMoveBrick(16, Settings.brick4, brickList));
            }
            if (fieldnr == 17)
            {
                brickList = Settings.field17.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick4.Field.ToString() + " " + CanMoveBrick(17, Settings.brick4, brickList));
            }
            if (fieldnr == 18)
            {
                brickList = Settings.field18.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick4.Field.ToString() + " " + CanMoveBrick(18, Settings.brick4, brickList));
            }
            if (fieldnr == 19)
            {
                brickList = Settings.field19.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick4.Field.ToString() + " " + CanMoveBrick(19, Settings.brick4, brickList));
            }
            if (fieldnr == 20)
            {
                brickList = Settings.field20.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick4.Field.ToString() + " " + CanMoveBrick(20, Settings.brick4, brickList));
            }
            if (fieldnr == 21)
            {
                brickList = Settings.field21.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick4.Field.ToString() + " " + CanMoveBrick(21, Settings.brick4, brickList));
            }
            if (fieldnr == 22)
            {
                brickList = Settings.field22.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick4.Field.ToString() + " " + CanMoveBrick(22, Settings.brick4, brickList));
            }
            if (fieldnr == 23)
            {
                brickList = Settings.field23.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick4.Field.ToString() + " " + CanMoveBrick(23, Settings.brick4, brickList));
            }
            if (fieldnr == 24)
            {
                brickList = Settings.field24.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick4.Field.ToString() + " " + CanMoveBrick(24, Settings.brick4, brickList));
            }
            if (fieldnr == 25)
            {
                brickList = Settings.field25.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick4.Field.ToString() + " " + CanMoveBrick(25, Settings.brick4, brickList));
            }
            if (fieldnr == 26)
            {
                brickList = Settings.field26.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick4.Field.ToString() + " " + CanMoveBrick(26, Settings.brick4, brickList));
            }
            if (fieldnr == 27)
            {
                brickList = Settings.field27.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick4.Field.ToString() + " " + CanMoveBrick(27, Settings.brick4, brickList));
            }
        }

        private void pictureBoxWhite_5_Click(object sender, EventArgs e)
        {

            int fieldnr = Settings.brick5.Field;
            if (fieldnr == 0)
            {
                brickList = Settings.field0.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick5.Field.ToString() + " " + CanMoveBrick(0, Settings.brick5, brickList));
            }
            if (fieldnr == 1)
            {
                brickList = Settings.field1.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick5.Field.ToString() + " " + CanMoveBrick(1, Settings.brick5, brickList));
            }
            if (fieldnr == 2)
            {
                brickList = Settings.field2.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick5.Field.ToString() + " " + CanMoveBrick(2, Settings.brick5, brickList));
            }
            if (fieldnr == 3)
            {
                brickList = Settings.field3.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick5.Field.ToString() + " " + CanMoveBrick(3, Settings.brick5, brickList));
            }
            if (fieldnr == 4)
            {
                brickList = Settings.field4.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick5.Field.ToString() + " " + CanMoveBrick(4, Settings.brick5, brickList));
            }
            if (fieldnr == 5)
            {
                brickList = Settings.field5.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick5.Field.ToString() + " " + CanMoveBrick(5, Settings.brick5, brickList));
            }
            if (fieldnr == 6)
            {
                brickList = Settings.field6.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick5.Field.ToString() + " " + CanMoveBrick(6, Settings.brick5, brickList));
            }
            if (fieldnr == 7)
            {
                brickList = Settings.field7.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick5.Field.ToString() + " " + CanMoveBrick(7, Settings.brick5, brickList));
            }
            if (fieldnr == 8)
            {
                brickList = Settings.field8.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick5.Field.ToString() + " " + CanMoveBrick(8, Settings.brick5, brickList));
            }
            if (fieldnr == 9)
            {
                brickList = Settings.field9.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick5.Field.ToString() + " " + CanMoveBrick(9, Settings.brick5, brickList));
            }
            if (fieldnr == 10)
            {
                brickList = Settings.field10.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick5.Field.ToString() + " " + CanMoveBrick(10, Settings.brick5, brickList));
            }
            if (fieldnr == 11)
            {
                brickList = Settings.field11.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick5.Field.ToString() + " " + CanMoveBrick(11, Settings.brick5, brickList));
            }
            if (fieldnr == 12)
            {
                brickList = Settings.field12.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick5.Field.ToString() + " " + CanMoveBrick(12, Settings.brick5, brickList));
            }
            if (fieldnr == 13)
            {
                brickList = Settings.field13.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick5.Field.ToString() + " " + CanMoveBrick(13, Settings.brick5, brickList));
            }
            if (fieldnr == 14)
            {
                brickList = Settings.field14.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick5.Field.ToString() + " " + CanMoveBrick(14, Settings.brick5, brickList));
            }
            if (fieldnr == 15)
            {
                brickList = Settings.field15.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick5.Field.ToString() + " " + CanMoveBrick(15, Settings.brick5, brickList));
            }
            if (fieldnr == 16)
            {
                brickList = Settings.field16.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick5.Field.ToString() + " " + CanMoveBrick(16, Settings.brick5, brickList));
            }
            if (fieldnr == 17)
            {
                brickList = Settings.field17.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick5.Field.ToString() + " " + CanMoveBrick(17, Settings.brick5, brickList));
            }
            if (fieldnr == 18)
            {
                brickList = Settings.field18.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick5.Field.ToString() + " " + CanMoveBrick(18, Settings.brick5, brickList));
            }
            if (fieldnr == 19)
            {
                brickList = Settings.field19.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick5.Field.ToString() + " " + CanMoveBrick(19, Settings.brick5, brickList));
            }
            if (fieldnr == 20)
            {
                brickList = Settings.field20.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick5.Field.ToString() + " " + CanMoveBrick(20, Settings.brick5, brickList));
            }
            if (fieldnr == 21)
            {
                brickList = Settings.field21.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick5.Field.ToString() + " " + CanMoveBrick(21, Settings.brick5, brickList));
            }
            if (fieldnr == 22)
            {
                brickList = Settings.field22.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick5.Field.ToString() + " " + CanMoveBrick(22, Settings.brick5, brickList));
            }
            if (fieldnr == 23)
            {
                brickList = Settings.field23.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick5.Field.ToString() + " " + CanMoveBrick(23, Settings.brick5, brickList));
            }
            if (fieldnr == 24)
            {
                brickList = Settings.field24.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick5.Field.ToString() + " " + CanMoveBrick(24, Settings.brick5, brickList));
            }
            if (fieldnr == 25)
            {
                brickList = Settings.field25.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick5.Field.ToString() + " " + CanMoveBrick(25, Settings.brick5, brickList));
            }
            if (fieldnr == 26)
            {
                brickList = Settings.field26.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick5.Field.ToString() + " " + CanMoveBrick(26, Settings.brick5, brickList));
            }
            if (fieldnr == 27)
            {
                brickList = Settings.field27.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick5.Field.ToString() + " " + CanMoveBrick(27, Settings.brick5, brickList));
            }
        }

        private void pictureBoxWhite_6_Click(object sender, EventArgs e)
        {

            int fieldnr = Settings.brick6.Field;
            if (fieldnr == 0)
            {
                brickList = Settings.field0.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick6.Field.ToString() + " " + CanMoveBrick(0, Settings.brick6, brickList));
            }
            if (fieldnr == 1)
            {
                brickList = Settings.field1.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick6.Field.ToString() + " " + CanMoveBrick(1, Settings.brick6, brickList));
            }
            if (fieldnr == 2)
            {
                brickList = Settings.field2.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick6.Field.ToString() + " " + CanMoveBrick(2, Settings.brick6, brickList));
            }
            if (fieldnr == 3)
            {
                brickList = Settings.field3.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick6.Field.ToString() + " " + CanMoveBrick(3, Settings.brick6, brickList));
            }
            if (fieldnr == 4)
            {
                brickList = Settings.field4.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick6.Field.ToString() + " " + CanMoveBrick(4, Settings.brick6, brickList));
            }
            if (fieldnr == 5)
            {
                brickList = Settings.field5.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick6.Field.ToString() + " " + CanMoveBrick(5, Settings.brick6, brickList));
            }
            if (fieldnr == 6)
            {
                brickList = Settings.field6.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick6.Field.ToString() + " " + CanMoveBrick(6, Settings.brick6, brickList));
            }
            if (fieldnr == 7)
            {
                brickList = Settings.field7.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick6.Field.ToString() + " " + CanMoveBrick(7, Settings.brick6, brickList));
            }
            if (fieldnr == 8)
            {
                brickList = Settings.field8.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick6.Field.ToString() + " " + CanMoveBrick(8, Settings.brick6, brickList));
            }
            if (fieldnr == 9)
            {
                brickList = Settings.field9.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick6.Field.ToString() + " " + CanMoveBrick(9, Settings.brick6, brickList));
            }
            if (fieldnr == 10)
            {
                brickList = Settings.field10.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick6.Field.ToString() + " " + CanMoveBrick(10, Settings.brick6, brickList));
            }
            if (fieldnr == 11)
            {
                brickList = Settings.field11.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick6.Field.ToString() + " " + CanMoveBrick(11, Settings.brick6, brickList));
            }
            if (fieldnr == 12)
            {
                brickList = Settings.field12.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick6.Field.ToString() + " " + CanMoveBrick(12, Settings.brick6, brickList));
            }
            if (fieldnr == 13)
            {
                brickList = Settings.field13.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick6.Field.ToString() + " " + CanMoveBrick(13, Settings.brick6, brickList));
            }
            if (fieldnr == 14)
            {
                brickList = Settings.field14.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick6.Field.ToString() + " " + CanMoveBrick(14, Settings.brick6, brickList));
            }
            if (fieldnr == 15)
            {
                brickList = Settings.field15.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick6.Field.ToString() + " " + CanMoveBrick(15, Settings.brick6, brickList));
            }
            if (fieldnr == 16)
            {
                brickList = Settings.field16.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick6.Field.ToString() + " " + CanMoveBrick(16, Settings.brick6, brickList));
            }
            if (fieldnr == 17)
            {
                brickList = Settings.field17.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick6.Field.ToString() + " " + CanMoveBrick(17, Settings.brick6, brickList));
            }
            if (fieldnr == 18)
            {
                brickList = Settings.field18.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick6.Field.ToString() + " " + CanMoveBrick(18, Settings.brick6, brickList));
            }
            if (fieldnr == 19)
            {
                brickList = Settings.field19.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick6.Field.ToString() + " " + CanMoveBrick(19, Settings.brick6, brickList));
            }
            if (fieldnr == 20)
            {
                brickList = Settings.field20.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick6.Field.ToString() + " " + CanMoveBrick(20, Settings.brick6, brickList));
            }
            if (fieldnr == 21)
            {
                brickList = Settings.field21.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick6.Field.ToString() + " " + CanMoveBrick(21, Settings.brick6, brickList));
            }
            if (fieldnr == 22)
            {
                brickList = Settings.field22.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick6.Field.ToString() + " " + CanMoveBrick(22, Settings.brick6, brickList));
            }
            if (fieldnr == 23)
            {
                brickList = Settings.field23.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick6.Field.ToString() + " " + CanMoveBrick(23, Settings.brick6, brickList));
            }
            if (fieldnr == 24)
            {
                brickList = Settings.field24.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick6.Field.ToString() + " " + CanMoveBrick(24, Settings.brick6, brickList));
            }
            if (fieldnr == 25)
            {
                brickList = Settings.field25.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick6.Field.ToString() + " " + CanMoveBrick(25, Settings.brick6, brickList));
                
            }
            if (fieldnr == 26)
            {
                brickList = Settings.field26.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick6.Field.ToString() + " " + CanMoveBrick(26, Settings.brick6, brickList));
            } 
            if (fieldnr == 27)
            {
                brickList = Settings.field27.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick6.Field.ToString() + " " + CanMoveBrick(27, Settings.brick6, brickList));
            }



        }

        private void pictureBoxWhite_7_Click(object sender, EventArgs e)
        {

            int fieldnr = Settings.brick7.Field;
            if (fieldnr == 0)
            {
                brickList = Settings.field0.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick7.Field.ToString() + " " + CanMoveBrick(0, Settings.brick7, brickList));
            }
            if (fieldnr == 1)
            {
                brickList = Settings.field1.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick7.Field.ToString() + " " + CanMoveBrick(1, Settings.brick7, brickList));
            }
            if (fieldnr == 2)
            {
                brickList = Settings.field2.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick7.Field.ToString() + " " + CanMoveBrick(2, Settings.brick7, brickList));
            }
            if (fieldnr == 3)
            {
                brickList = Settings.field3.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick7.Field.ToString() + " " + CanMoveBrick(3, Settings.brick7, brickList));
            }
            if (fieldnr == 4)
            {
                brickList = Settings.field4.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick7.Field.ToString() + " " + CanMoveBrick(4, Settings.brick7, brickList));
            }
            if (fieldnr == 5)
            {
                brickList = Settings.field5.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick7.Field.ToString() + " " + CanMoveBrick(5, Settings.brick7, brickList));
            }
            if (fieldnr == 6)
            {
                brickList = Settings.field6.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick7.Field.ToString() + " " + CanMoveBrick(6, Settings.brick7, brickList));
            }
            if (fieldnr == 7)
            {
                brickList = Settings.field7.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick7.Field.ToString() + " " + CanMoveBrick(7, Settings.brick7, brickList));
            }
            if (fieldnr == 8)
            {
                brickList = Settings.field8.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick7.Field.ToString() + " " + CanMoveBrick(8, Settings.brick7, brickList));
            }
            if (fieldnr == 9)
            {
                brickList = Settings.field9.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick7.Field.ToString() + " " + CanMoveBrick(9, Settings.brick7, brickList));
            }
            if (fieldnr == 10)
            {
                brickList = Settings.field10.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick7.Field.ToString() + " " + CanMoveBrick(10, Settings.brick7, brickList));
            }
            if (fieldnr == 11)
            {
                brickList = Settings.field11.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick7.Field.ToString() + " " + CanMoveBrick(11, Settings.brick7, brickList));
            }
            if (fieldnr == 12)
            {
                brickList = Settings.field12.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick7.Field.ToString() + " " + CanMoveBrick(12, Settings.brick7, brickList));
            }
            if (fieldnr == 13)
            {
                brickList = Settings.field13.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick7.Field.ToString() + " " + CanMoveBrick(13, Settings.brick7, brickList));
            }
            if (fieldnr == 14)
            {
                brickList = Settings.field14.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick7.Field.ToString() + " " + CanMoveBrick(14, Settings.brick7, brickList));
            }
            if (fieldnr == 15)
            {
                brickList = Settings.field15.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick7.Field.ToString() + " " + CanMoveBrick(15, Settings.brick7, brickList));
            }
            if (fieldnr == 16)
            {
                brickList = Settings.field16.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick7.Field.ToString() + " " + CanMoveBrick(16, Settings.brick7, brickList));
            }
            if (fieldnr == 17)
            {
                brickList = Settings.field17.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick7.Field.ToString() + " " + CanMoveBrick(17, Settings.brick7, brickList));
            }
            if (fieldnr == 18)
            {
                brickList = Settings.field18.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick7.Field.ToString() + " " + CanMoveBrick(18, Settings.brick7, brickList));
            }
            if (fieldnr == 19)
            {
                brickList = Settings.field19.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick7.Field.ToString() + " " + CanMoveBrick(19, Settings.brick7, brickList));
            }
            if (fieldnr == 20)
            {
                brickList = Settings.field20.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick7.Field.ToString() + " " + CanMoveBrick(20, Settings.brick7, brickList));
            }
            if (fieldnr == 21)
            {
                brickList = Settings.field21.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick7.Field.ToString() + " " + CanMoveBrick(21, Settings.brick7, brickList));
            }
            if (fieldnr == 22)
            {
                brickList = Settings.field22.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick7.Field.ToString() + " " + CanMoveBrick(22, Settings.brick7, brickList));
            }
            if (fieldnr == 23)
            {
                brickList = Settings.field23.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick7.Field.ToString() + " " + CanMoveBrick(23, Settings.brick7, brickList));
            }
            if (fieldnr == 24)
            {
                brickList = Settings.field24.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick7.Field.ToString() + " " + CanMoveBrick(24, Settings.brick7, brickList));
            }
            if (fieldnr == 25)
            {
                brickList = Settings.field25.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick7.Field.ToString() + " " + CanMoveBrick(25, Settings.brick7, brickList));
            }
            if (fieldnr == 26)
            {
                brickList = Settings.field26.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick7.Field.ToString() + " " + CanMoveBrick(26, Settings.brick7, brickList));
            }
            if (fieldnr == 27)
            {
                brickList = Settings.field27.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick7.Field.ToString() + " " + CanMoveBrick(27, Settings.brick7, brickList));
            }
        }

        private void pictureBoxWhite_8_Click(object sender, EventArgs e)
        {

            int fieldnr = Settings.brick8.Field;
            if (fieldnr == 0)
            {
                brickList = Settings.field0.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick8.Field.ToString() + " " + CanMoveBrick(0, Settings.brick8, brickList));
            }
            if (fieldnr == 1)
            {
                brickList = Settings.field1.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick8.Field.ToString() + " " + CanMoveBrick(1, Settings.brick8, brickList));
            }
            if (fieldnr == 2)
            {
                brickList = Settings.field2.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick8.Field.ToString() + " " + CanMoveBrick(2, Settings.brick8, brickList));
            }
            if (fieldnr == 3)
            {
                brickList = Settings.field3.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick8.Field.ToString() + " " + CanMoveBrick(3, Settings.brick8, brickList));
            }
            if (fieldnr == 4)
            {
                brickList = Settings.field4.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick8.Field.ToString() + " " + CanMoveBrick(4, Settings.brick8, brickList));
            }
            if (fieldnr == 5)
            {
                brickList = Settings.field5.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick8.Field.ToString() + " " + CanMoveBrick(5, Settings.brick8, brickList));
            }
            if (fieldnr == 6)
            {
                brickList = Settings.field6.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick8.Field.ToString() + " " + CanMoveBrick(6, Settings.brick8, brickList));
            }
            if (fieldnr == 7)
            {
                brickList = Settings.field7.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick8.Field.ToString() + " " + CanMoveBrick(7, Settings.brick8, brickList));
            }
            if (fieldnr == 8)
            {
                brickList = Settings.field8.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick8.Field.ToString() + " " + CanMoveBrick(8, Settings.brick8, brickList));
            }
            if (fieldnr == 9)
            {
                brickList = Settings.field9.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick8.Field.ToString() + " " + CanMoveBrick(9, Settings.brick8, brickList));
            }
            if (fieldnr == 10)
            {
                brickList = Settings.field10.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick8.Field.ToString() + " " + CanMoveBrick(10, Settings.brick8, brickList));
            }
            if (fieldnr == 11)
            {
                brickList = Settings.field11.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick8.Field.ToString() + " " + CanMoveBrick(11, Settings.brick8, brickList));
            }
            if (fieldnr == 12)
            {
                brickList = Settings.field12.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick8.Field.ToString() + " " + CanMoveBrick(12, Settings.brick8, brickList));
            }
            if (fieldnr == 13)
            {
                brickList = Settings.field13.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick8.Field.ToString() + " " + CanMoveBrick(13, Settings.brick8, brickList));
            }
            if (fieldnr == 14)
            {
                brickList = Settings.field14.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick8.Field.ToString() + " " + CanMoveBrick(14, Settings.brick8, brickList));
            }
            if (fieldnr == 15)
            {
                brickList = Settings.field15.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick8.Field.ToString() + " " + CanMoveBrick(15, Settings.brick8, brickList));
            }
            if (fieldnr == 16)
            {
                brickList = Settings.field16.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick8.Field.ToString() + " " + CanMoveBrick(16, Settings.brick8, brickList));
            }
            if (fieldnr == 17)
            {
                brickList = Settings.field17.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick8.Field.ToString() + " " + CanMoveBrick(17, Settings.brick8, brickList));
            }
            if (fieldnr == 18)
            {
                brickList = Settings.field18.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick8.Field.ToString() + " " + CanMoveBrick(18, Settings.brick8, brickList));
            }
            if (fieldnr == 19)
            {
                brickList = Settings.field19.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick8.Field.ToString() + " " + CanMoveBrick(19, Settings.brick8, brickList));
            }
            if (fieldnr == 20)
            {
                brickList = Settings.field20.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick8.Field.ToString() + " " + CanMoveBrick(20, Settings.brick8, brickList));
            }
            if (fieldnr == 21)
            {
                brickList = Settings.field21.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick8.Field.ToString() + " " + CanMoveBrick(21, Settings.brick8, brickList));
            }
            if (fieldnr == 22)
            {
                brickList = Settings.field22.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick8.Field.ToString() + " " + CanMoveBrick(22, Settings.brick8, brickList));
            }
            if (fieldnr == 23)
            {
                brickList = Settings.field23.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick8.Field.ToString() + " " + CanMoveBrick(23, Settings.brick8, brickList));
            }
            if (fieldnr == 24)
            {
                brickList = Settings.field24.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick8.Field.ToString() + " " + CanMoveBrick(24, Settings.brick8, brickList));
            }
            if (fieldnr == 25)
            {
                brickList = Settings.field25.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick8.Field.ToString() + " " + CanMoveBrick(25, Settings.brick8, brickList));
            }
            if (fieldnr == 26)
            {
                brickList = Settings.field26.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick8.Field.ToString() + " " + CanMoveBrick(26, Settings.brick8, brickList));
            }
            if (fieldnr == 27)
            {
                brickList = Settings.field27.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick8.Field.ToString() + " " + CanMoveBrick(27, Settings.brick8, brickList));
            }
        }

        private void pictureBoxWhite_9_Click(object sender, EventArgs e)
        {

            int fieldnr = Settings.brick9.Field;
            if (fieldnr == 0)
            {
                brickList = Settings.field0.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick9.Field.ToString() + " " + CanMoveBrick(0, Settings.brick9, brickList));
            }
            if (fieldnr == 1)
            {
                brickList = Settings.field1.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick9.Field.ToString() + " " + CanMoveBrick(1, Settings.brick9, brickList));
            }
            if (fieldnr == 2)
            {
                brickList = Settings.field2.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick9.Field.ToString() + " " + CanMoveBrick(2, Settings.brick9, brickList));
            }
            if (fieldnr == 3)
            {
                brickList = Settings.field3.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick9.Field.ToString() + " " + CanMoveBrick(3, Settings.brick9, brickList));
            }
            if (fieldnr == 4)
            {
                brickList = Settings.field4.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick9.Field.ToString() + " " + CanMoveBrick(4, Settings.brick9, brickList));
            }
            if (fieldnr == 5)
            {
                brickList = Settings.field5.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick9.Field.ToString() + " " + CanMoveBrick(5, Settings.brick9, brickList));
            }
            if (fieldnr == 6)
            {
                brickList = Settings.field6.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick9.Field.ToString() + " " + CanMoveBrick(6, Settings.brick9, brickList));
            }
            if (fieldnr == 7)
            {
                brickList = Settings.field7.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick9.Field.ToString() + " " + CanMoveBrick(7, Settings.brick9, brickList));
            }
            if (fieldnr == 8)
            {
                brickList = Settings.field8.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick9.Field.ToString() + " " + CanMoveBrick(8, Settings.brick9, brickList));
            }
            if (fieldnr == 9)
            {
                brickList = Settings.field9.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick9.Field.ToString() + " " + CanMoveBrick(9, Settings.brick9, brickList));
            }
            if (fieldnr == 10)
            {
                brickList = Settings.field10.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick9.Field.ToString() + " " + CanMoveBrick(10, Settings.brick9, brickList));
            }
            if (fieldnr == 11)
            {
                brickList = Settings.field11.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick9.Field.ToString() + " " + CanMoveBrick(11, Settings.brick9, brickList));
            }
            if (fieldnr == 12)
            {
                brickList = Settings.field12.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick9.Field.ToString() + " " + CanMoveBrick(12, Settings.brick9, brickList));
            }
            if (fieldnr == 13)
            {
                brickList = Settings.field13.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick9.Field.ToString() + " " + CanMoveBrick(13, Settings.brick9, brickList));
            }
            if (fieldnr == 14)
            {
                brickList = Settings.field14.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick9.Field.ToString() + " " + CanMoveBrick(14, Settings.brick9, brickList));
            }
            if (fieldnr == 15)
            {
                brickList = Settings.field15.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick9.Field.ToString() + " " + CanMoveBrick(15, Settings.brick9, brickList));
            }
            if (fieldnr == 16)
            {
                brickList = Settings.field16.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick9.Field.ToString() + " " + CanMoveBrick(16, Settings.brick9, brickList));
            }
            if (fieldnr == 17)
            {
                brickList = Settings.field17.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick9.Field.ToString() + " " + CanMoveBrick(17, Settings.brick9, brickList));
            }
            if (fieldnr == 18)
            {
                brickList = Settings.field18.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick9.Field.ToString() + " " + CanMoveBrick(18, Settings.brick9, brickList));
            }
            if (fieldnr == 19)
            {
                brickList = Settings.field19.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick9.Field.ToString() + " " + CanMoveBrick(19, Settings.brick9, brickList));
            }
            if (fieldnr == 20)
            {
                brickList = Settings.field20.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick9.Field.ToString() + " " + CanMoveBrick(20, Settings.brick9, brickList));
            }
            if (fieldnr == 21)
            {
                brickList = Settings.field21.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick9.Field.ToString() + " " + CanMoveBrick(21, Settings.brick9, brickList));
            }
            if (fieldnr == 22)
            {
                brickList = Settings.field22.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick9.Field.ToString() + " " + CanMoveBrick(22, Settings.brick9, brickList));
            }
            if (fieldnr == 23)
            {
                brickList = Settings.field23.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick9.Field.ToString() + " " + CanMoveBrick(23, Settings.brick9, brickList));
            }
            if (fieldnr == 24)
            {
                brickList = Settings.field24.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick9.Field.ToString() + " " + CanMoveBrick(24, Settings.brick9, brickList));
            }
            if (fieldnr == 25)
            {
                brickList = Settings.field25.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick9.Field.ToString() + " " + CanMoveBrick(25, Settings.brick9, brickList));
            }
            if (fieldnr == 26)
            {
                brickList = Settings.field26.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick9.Field.ToString() + " " + CanMoveBrick(26, Settings.brick9, brickList));
            }
            if (fieldnr == 27)
            {
                brickList = Settings.field27.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick9.Field.ToString() + " " + CanMoveBrick(27, Settings.brick9, brickList));
            }
        }

        private void pictureBoxWhite_10_Click(object sender, EventArgs e)
        {

            int fieldnr = Settings.brick10.Field;
            if (fieldnr == 0)
            {
                brickList = Settings.field0.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick10.Field.ToString() + " " + CanMoveBrick(0, Settings.brick10, brickList));
            }
            if (fieldnr == 1)
            {
                brickList = Settings.field1.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick10.Field.ToString() + " " + CanMoveBrick(1, Settings.brick10, brickList));
            }
            if (fieldnr == 2)
            {
                brickList = Settings.field2.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick10.Field.ToString() + " " + CanMoveBrick(2, Settings.brick10, brickList));
            }
            if (fieldnr == 3)
            {
                brickList = Settings.field3.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick10.Field.ToString() + " " + CanMoveBrick(3, Settings.brick10, brickList));
            }
            if (fieldnr == 4)
            {
                brickList = Settings.field4.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick10.Field.ToString() + " " + CanMoveBrick(4, Settings.brick10, brickList));
            }
            if (fieldnr == 5)
            {
                brickList = Settings.field5.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick10.Field.ToString() + " " + CanMoveBrick(5, Settings.brick10, brickList));
            }
            if (fieldnr == 6)
            {
                brickList = Settings.field6.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick10.Field.ToString() + " " + CanMoveBrick(6, Settings.brick10, brickList));
            }
            if (fieldnr == 7)
            {
                brickList = Settings.field7.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick10.Field.ToString() + " " + CanMoveBrick(7, Settings.brick10, brickList));
            }
            if (fieldnr == 8)
            {
                brickList = Settings.field8.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick10.Field.ToString() + " " + CanMoveBrick(8, Settings.brick10, brickList));
            }
            if (fieldnr == 9)
            {
                brickList = Settings.field9.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick10.Field.ToString() + " " + CanMoveBrick(9, Settings.brick10, brickList));
            }
            if (fieldnr == 10)
            {
                brickList = Settings.field10.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick10.Field.ToString() + " " + CanMoveBrick(10, Settings.brick10, brickList));
            }
            if (fieldnr == 11)
            {
                brickList = Settings.field11.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick10.Field.ToString() + " " + CanMoveBrick(11, Settings.brick10, brickList));
            }
            if (fieldnr == 12)
            {
                brickList = Settings.field12.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick10.Field.ToString() + " " + CanMoveBrick(12, Settings.brick10, brickList));
            }
            if (fieldnr == 13)
            {
                brickList = Settings.field13.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick10.Field.ToString() + " " + CanMoveBrick(13, Settings.brick10, brickList));
            }
            if (fieldnr == 14)
            {
                brickList = Settings.field14.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick10.Field.ToString() + " " + CanMoveBrick(14, Settings.brick10, brickList));
            }
            if (fieldnr == 15)
            {
                brickList = Settings.field15.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick10.Field.ToString() + " " + CanMoveBrick(15, Settings.brick10, brickList));
            }
            if (fieldnr == 16)
            {
                brickList = Settings.field16.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick10.Field.ToString() + " " + CanMoveBrick(16, Settings.brick10, brickList));
            }
            if (fieldnr == 17)
            {
                brickList = Settings.field17.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick10.Field.ToString() + " " + CanMoveBrick(17, Settings.brick10, brickList));
            }
            if (fieldnr == 18)
            {
                brickList = Settings.field18.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick10.Field.ToString() + " " + CanMoveBrick(18, Settings.brick10, brickList));
            }
            if (fieldnr == 19)
            {
                brickList = Settings.field19.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick10.Field.ToString() + " " + CanMoveBrick(19, Settings.brick10, brickList));
            }
            if (fieldnr == 20)
            {
                brickList = Settings.field20.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick10.Field.ToString() + " " + CanMoveBrick(20, Settings.brick10, brickList));
            }
            if (fieldnr == 21)
            {
                brickList = Settings.field21.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick10.Field.ToString() + " " + CanMoveBrick(21, Settings.brick10, brickList));
            }
            if (fieldnr == 22)
            {
                brickList = Settings.field22.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick10.Field.ToString() + " " + CanMoveBrick(22, Settings.brick10, brickList));
            }
            if (fieldnr == 23)
            {
                brickList = Settings.field23.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick10.Field.ToString() + " " + CanMoveBrick(23, Settings.brick10, brickList));
            }
            if (fieldnr == 24)
            {
                brickList = Settings.field24.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick10.Field.ToString() + " " + CanMoveBrick(24, Settings.brick10, brickList));
            }
            if (fieldnr == 25)
            {
                brickList = Settings.field25.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick10.Field.ToString() + " " + CanMoveBrick(25, Settings.brick10, brickList));
            }
            if (fieldnr == 26)
            {
                brickList = Settings.field26.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick10.Field.ToString() + " " + CanMoveBrick(26, Settings.brick10, brickList));
            }
             if (fieldnr == 27)
            {
                brickList = Settings.field27.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick10.Field.ToString() + " " + CanMoveBrick(27, Settings.brick10, brickList));
            }
        }

        private void pictureBoxWhite_11_Click(object sender, EventArgs e)
        {

            int fieldnr = Settings.brick11.Field;
            if (fieldnr == 0)
            {
                brickList = Settings.field0.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick11.Field.ToString() + " " + CanMoveBrick(0, Settings.brick11, brickList));
            }
            if (fieldnr == 1)
            {
                brickList = Settings.field1.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick11.Field.ToString() + " " + CanMoveBrick(1, Settings.brick11, brickList));
            }
            if (fieldnr == 2)
            {
                brickList = Settings.field2.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick11.Field.ToString() + " " + CanMoveBrick(2, Settings.brick11, brickList));
            }
            if (fieldnr == 3)
            {
                brickList = Settings.field3.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick11.Field.ToString() + " " + CanMoveBrick(3, Settings.brick11, brickList));
            }
            if (fieldnr == 4)
            {
                brickList = Settings.field4.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick11.Field.ToString() + " " + CanMoveBrick(4, Settings.brick11, brickList));
            }
            if (fieldnr == 5)
            {
                brickList = Settings.field5.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick11.Field.ToString() + " " + CanMoveBrick(5, Settings.brick11, brickList));
            }
            if (fieldnr == 6)
            {
                brickList = Settings.field6.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick11.Field.ToString() + " " + CanMoveBrick(6, Settings.brick11, brickList));
            }
            if (fieldnr == 7)
            {
                brickList = Settings.field7.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick11.Field.ToString() + " " + CanMoveBrick(7, Settings.brick11, brickList));
            }
            if (fieldnr == 8)
            {
                brickList = Settings.field8.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick11.Field.ToString() + " " + CanMoveBrick(8, Settings.brick11, brickList));
            }
            if (fieldnr == 9)
            {
                brickList = Settings.field9.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick11.Field.ToString() + " " + CanMoveBrick(9, Settings.brick11, brickList));
            }
            if (fieldnr == 10)
            {
                brickList = Settings.field10.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick11.Field.ToString() + " " + CanMoveBrick(10, Settings.brick11, brickList));
            }
            if (fieldnr == 11)
            {
                brickList = Settings.field11.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick11.Field.ToString() + " " + CanMoveBrick(11, Settings.brick11, brickList));
            }
            if (fieldnr == 12)
            {
                brickList = Settings.field12.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick11.Field.ToString() + " " + CanMoveBrick(12, Settings.brick11, brickList));
            }
            if (fieldnr == 13)
            {
                brickList = Settings.field13.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick11.Field.ToString() + " " + CanMoveBrick(13, Settings.brick11, brickList));
            }
            if (fieldnr == 14)
            {
                brickList = Settings.field14.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick11.Field.ToString() + " " + CanMoveBrick(14, Settings.brick11, brickList));
            }
            if (fieldnr == 15)
            {
                brickList = Settings.field15.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick11.Field.ToString() + " " + CanMoveBrick(15, Settings.brick11, brickList));
            }
            if (fieldnr == 16)
            {
                brickList = Settings.field16.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick11.Field.ToString() + " " + CanMoveBrick(16, Settings.brick11, brickList));
            }
            if (fieldnr == 17)
            {
                brickList = Settings.field17.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick11.Field.ToString() + " " + CanMoveBrick(17, Settings.brick11, brickList));
            }
            if (fieldnr == 18)
            {
                brickList = Settings.field18.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick11.Field.ToString() + " " + CanMoveBrick(18, Settings.brick11, brickList));
            }
            if (fieldnr == 19)
            {
                brickList = Settings.field19.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick11.Field.ToString() + " " + CanMoveBrick(19, Settings.brick11, brickList));
            }
            if (fieldnr == 20)
            {
                brickList = Settings.field20.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick11.Field.ToString() + " " + CanMoveBrick(20, Settings.brick11, brickList));
            }
            if (fieldnr == 21)
            {
                brickList = Settings.field21.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick11.Field.ToString() + " " + CanMoveBrick(21, Settings.brick11, brickList));
            }
            if (fieldnr == 22)
            {
                brickList = Settings.field22.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick11.Field.ToString() + " " + CanMoveBrick(22, Settings.brick11, brickList));
            }
            if (fieldnr == 23)
            {
                brickList = Settings.field23.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick11.Field.ToString() + " " + CanMoveBrick(23, Settings.brick11, brickList));
            }
            if (fieldnr == 24)
            {
                brickList = Settings.field24.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick11.Field.ToString() + " " + CanMoveBrick(24, Settings.brick11, brickList));
            }
            if (fieldnr == 25)
            {
                brickList = Settings.field25.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick11.Field.ToString() + " " + CanMoveBrick(25, Settings.brick11, brickList));
            }
            if (fieldnr == 26)
            {
                brickList = Settings.field26.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick11.Field.ToString() + " " + CanMoveBrick(26, Settings.brick11, brickList));
            }
            if (fieldnr == 27)
            {
                brickList = Settings.field27.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick11.Field.ToString() + " " + CanMoveBrick(27, Settings.brick11, brickList));
            }
        }

        private void pictureBoxWhite_12_Click(object sender, EventArgs e)
        {

            int fieldnr = Settings.brick12.Field;
            if (fieldnr == 0)
            {
                brickList = Settings.field0.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick12.Field.ToString() + " " + CanMoveBrick(0, Settings.brick12, brickList));
            }
            if (fieldnr == 1)
            {
                brickList = Settings.field1.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick12.Field.ToString() + " " + CanMoveBrick(1, Settings.brick12, brickList));
            }
            if (fieldnr == 2)
            {
                brickList = Settings.field2.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick12.Field.ToString() + " " + CanMoveBrick(2, Settings.brick12, brickList));
            }
            if (fieldnr == 3)
            {
                brickList = Settings.field3.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick12.Field.ToString() + " " + CanMoveBrick(3, Settings.brick12, brickList));
            }
            if (fieldnr == 4)
            {
                brickList = Settings.field4.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick12.Field.ToString() + " " + CanMoveBrick(4, Settings.brick12, brickList));
            }
            if (fieldnr == 5)
            {
                brickList = Settings.field5.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick12.Field.ToString() + " " + CanMoveBrick(5, Settings.brick12, brickList));
            }
            if (fieldnr == 6)
            {
                brickList = Settings.field6.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick12.Field.ToString() + " " + CanMoveBrick(6, Settings.brick12, brickList));
            }
            if (fieldnr == 7)
            {
                brickList = Settings.field7.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick12.Field.ToString() + " " + CanMoveBrick(7, Settings.brick12, brickList));
            }
            if (fieldnr == 8)
            {
                brickList = Settings.field8.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick12.Field.ToString() + " " + CanMoveBrick(8, Settings.brick12, brickList));
            }
            if (fieldnr == 9)
            {
                brickList = Settings.field9.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick12.Field.ToString() + " " + CanMoveBrick(9, Settings.brick12, brickList));
            }
            if (fieldnr == 10)
            {
                brickList = Settings.field10.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick12.Field.ToString() + " " + CanMoveBrick(10, Settings.brick12, brickList));
            }
            if (fieldnr == 11)
            {
                brickList = Settings.field11.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick12.Field.ToString() + " " + CanMoveBrick(11, Settings.brick12, brickList));
            }
            if (fieldnr == 12)
            {
                brickList = Settings.field12.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick12.Field.ToString() + " " + CanMoveBrick(12, Settings.brick12, brickList));
            }
            if (fieldnr == 13)
            {
                brickList = Settings.field13.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick12.Field.ToString() + " " + CanMoveBrick(13, Settings.brick12, brickList));
            }
            if (fieldnr == 14)
            {
                brickList = Settings.field14.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick12.Field.ToString() + " " + CanMoveBrick(14, Settings.brick12, brickList));
            }
            if (fieldnr == 15)
            {
                brickList = Settings.field15.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick12.Field.ToString() + " " + CanMoveBrick(15, Settings.brick12, brickList));
            }
            if (fieldnr == 16)
            {
                brickList = Settings.field16.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick12.Field.ToString() + " " + CanMoveBrick(16, Settings.brick12, brickList));
            }
            if (fieldnr == 17)
            {
                brickList = Settings.field17.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick12.Field.ToString() + " " + CanMoveBrick(17, Settings.brick12, brickList));
            }
            if (fieldnr == 18)
            {
                brickList = Settings.field18.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick12.Field.ToString() + " " + CanMoveBrick(18, Settings.brick12, brickList));
            }
            if (fieldnr == 19)
            {
                brickList = Settings.field19.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick12.Field.ToString() + " " + CanMoveBrick(19, Settings.brick12, brickList));
            }
            if (fieldnr == 20)
            {
                brickList = Settings.field20.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick12.Field.ToString() + " " + CanMoveBrick(20, Settings.brick12, brickList));
            }
            if (fieldnr == 21)
            {
                brickList = Settings.field21.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick12.Field.ToString() + " " + CanMoveBrick(21, Settings.brick12, brickList));
            }
            if (fieldnr == 22)
            {
                brickList = Settings.field22.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick12.Field.ToString() + " " + CanMoveBrick(22, Settings.brick12, brickList));
            }
            if (fieldnr == 23)
            {
                brickList = Settings.field23.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick12.Field.ToString() + " " + CanMoveBrick(23, Settings.brick12, brickList));
            }
            if (fieldnr == 24)
            {
                brickList = Settings.field24.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick12.Field.ToString() + " " + CanMoveBrick(24, Settings.brick12, brickList));
            }
            if (fieldnr == 25)
            {
                brickList = Settings.field25.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick12.Field.ToString() + " " + CanMoveBrick(25, Settings.brick12, brickList));
            }
             if (fieldnr == 26)
            {
                brickList = Settings.field26.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick12.Field.ToString() + " " + CanMoveBrick(26, Settings.brick12, brickList));
            }
            if (fieldnr == 27)
            {
                brickList = Settings.field27.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick12.Field.ToString() + " " + CanMoveBrick(27, Settings.brick12, brickList));
            }
        }

        private void pictureBoxWhite_13_Click(object sender, EventArgs e)
        {

            int fieldnr = Settings.brick13.Field;
            if (fieldnr == 0)
            {
                brickList = Settings.field0.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick13.Field.ToString() + " " + CanMoveBrick(0, Settings.brick13, brickList));
            }
            if (fieldnr == 1)
            {
                brickList = Settings.field1.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick13.Field.ToString() + " " + CanMoveBrick(1, Settings.brick13, brickList));
            }
            if (fieldnr == 2)
            {
                brickList = Settings.field2.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick13.Field.ToString() + " " + CanMoveBrick(2, Settings.brick13, brickList));
            }
            if (fieldnr == 3)
            {
                brickList = Settings.field3.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick13.Field.ToString() + " " + CanMoveBrick(3, Settings.brick13, brickList));
            }
            if (fieldnr == 4)
            {
                brickList = Settings.field4.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick13.Field.ToString() + " " + CanMoveBrick(4, Settings.brick13, brickList));
            }
            if (fieldnr == 5)
            {
                brickList = Settings.field5.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick13.Field.ToString() + " " + CanMoveBrick(5, Settings.brick13, brickList));
            }
            if (fieldnr == 6)
            {
                brickList = Settings.field6.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick13.Field.ToString() + " " + CanMoveBrick(6, Settings.brick13, brickList));
            }
            if (fieldnr == 7)
            {
                brickList = Settings.field7.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick13.Field.ToString() + " " + CanMoveBrick(7, Settings.brick13, brickList));
            }
            if (fieldnr == 8)
            {
                brickList = Settings.field8.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick13.Field.ToString() + " " + CanMoveBrick(8, Settings.brick13, brickList));
            }
            if (fieldnr == 9)
            {
                brickList = Settings.field9.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick13.Field.ToString() + " " + CanMoveBrick(9, Settings.brick13, brickList));
            }
            if (fieldnr == 10)
            {
                brickList = Settings.field10.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick13.Field.ToString() + " " + CanMoveBrick(10, Settings.brick13, brickList));
            }
            if (fieldnr == 11)
            {
                brickList = Settings.field11.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick13.Field.ToString() + " " + CanMoveBrick(11, Settings.brick13, brickList));
            }
            if (fieldnr == 12)
            {
                brickList = Settings.field12.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick13.Field.ToString() + " " + CanMoveBrick(12, Settings.brick13, brickList));
            }
            if (fieldnr == 13)
            {
                brickList = Settings.field13.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick13.Field.ToString() + " " + CanMoveBrick(13, Settings.brick13, brickList));
            }
            if (fieldnr == 14)
            {
                brickList = Settings.field14.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick13.Field.ToString() + " " + CanMoveBrick(14, Settings.brick13, brickList));
            }
            if (fieldnr == 15)
            {
                brickList = Settings.field15.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick13.Field.ToString() + " " + CanMoveBrick(15, Settings.brick13, brickList));
            }
            if (fieldnr == 16)
            {
                brickList = Settings.field16.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick13.Field.ToString() + " " + CanMoveBrick(16, Settings.brick13, brickList));
            }
            if (fieldnr == 17)
            {
                brickList = Settings.field17.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick13.Field.ToString() + " " + CanMoveBrick(17, Settings.brick13, brickList));
            }
            if (fieldnr == 18)
            {
                brickList = Settings.field18.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick13.Field.ToString() + " " + CanMoveBrick(18, Settings.brick13, brickList));
            }
            if (fieldnr == 19)
            {
                brickList = Settings.field19.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick13.Field.ToString() + " " + CanMoveBrick(19, Settings.brick13, brickList));
            }
            if (fieldnr == 20)
            {
                brickList = Settings.field20.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick13.Field.ToString() + " " + CanMoveBrick(20, Settings.brick13, brickList));
            }
            if (fieldnr == 21)
            {
                brickList = Settings.field21.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick13.Field.ToString() + " " + CanMoveBrick(21, Settings.brick13, brickList));
            }
            if (fieldnr == 22)
            {
                brickList = Settings.field22.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick13.Field.ToString() + " " + CanMoveBrick(22, Settings.brick13, brickList));
            }
            if (fieldnr == 23)
            {
                brickList = Settings.field23.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick13.Field.ToString() + " " + CanMoveBrick(23, Settings.brick13, brickList));
            }
            if (fieldnr == 24)
            {
                brickList = Settings.field24.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick13.Field.ToString() + " " + CanMoveBrick(24, Settings.brick13, brickList));
            }
            if (fieldnr == 25)
            {
                brickList = Settings.field25.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick13.Field.ToString() + " " + CanMoveBrick(25, Settings.brick13, brickList));
            }
            if (fieldnr == 26)
            {
                brickList = Settings.field26.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick13.Field.ToString() + " " + CanMoveBrick(26, Settings.brick13, brickList));
            }
            if (fieldnr == 27)
            {
                brickList = Settings.field27.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick13.Field.ToString() + " " + CanMoveBrick(27, Settings.brick13, brickList));
            }
        }

        private void pictureBoxWhite_14_Click(object sender, EventArgs e)
        {

            int fieldnr = Settings.brick14.Field;
            if (fieldnr == 0)
            {
                brickList = Settings.field0.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick14.Field.ToString() + " " + CanMoveBrick(0, Settings.brick14, brickList));
            }
            if (fieldnr == 1)
            {
                brickList = Settings.field1.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick14.Field.ToString() + " " + CanMoveBrick(1, Settings.brick14, brickList));
            }
            if (fieldnr == 2)
            {
                brickList = Settings.field2.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick14.Field.ToString() + " " + CanMoveBrick(2, Settings.brick14, brickList));
            }
            if (fieldnr == 3)
            {
                brickList = Settings.field3.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick14.Field.ToString() + " " + CanMoveBrick(3, Settings.brick14, brickList));
            }
            if (fieldnr == 4)
            {
                brickList = Settings.field4.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick14.Field.ToString() + " " + CanMoveBrick(4, Settings.brick14, brickList));
            }
            if (fieldnr == 5)
            {
                brickList = Settings.field5.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick14.Field.ToString() + " " + CanMoveBrick(5, Settings.brick14, brickList));
            }
            if (fieldnr == 6)
            {
                brickList = Settings.field6.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick14.Field.ToString() + " " + CanMoveBrick(6, Settings.brick14, brickList));
            }
            if (fieldnr == 7)
            {
                brickList = Settings.field7.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick14.Field.ToString() + " " + CanMoveBrick(7, Settings.brick14, brickList));
            }
            if (fieldnr == 8)
            {
                brickList = Settings.field8.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick14.Field.ToString() + " " + CanMoveBrick(8, Settings.brick14, brickList));
            }
            if (fieldnr == 9)
            {
                brickList = Settings.field9.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick14.Field.ToString() + " " + CanMoveBrick(9, Settings.brick14, brickList));
            }
            if (fieldnr == 10)
            {
                brickList = Settings.field10.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick14.Field.ToString() + " " + CanMoveBrick(10, Settings.brick14, brickList));
            }
            if (fieldnr == 11)
            {
                brickList = Settings.field11.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick14.Field.ToString() + " " + CanMoveBrick(11, Settings.brick14, brickList));
            }
            if (fieldnr == 12)
            {
                brickList = Settings.field12.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick14.Field.ToString() + " " + CanMoveBrick(12, Settings.brick14, brickList));
            }
            if (fieldnr == 13)
            {
                brickList = Settings.field13.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick14.Field.ToString() + " " + CanMoveBrick(13, Settings.brick14, brickList));
            }
            if (fieldnr == 14)
            {
                brickList = Settings.field14.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick14.Field.ToString() + " " + CanMoveBrick(14, Settings.brick14, brickList));
            }
            if (fieldnr == 15)
            {
                brickList = Settings.field15.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick14.Field.ToString() + " " + CanMoveBrick(15, Settings.brick14, brickList));
            }
            if (fieldnr == 16)
            {
                brickList = Settings.field16.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick14.Field.ToString() + " " + CanMoveBrick(16, Settings.brick14, brickList));
            }
            if (fieldnr == 17)
            {
                brickList = Settings.field17.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick14.Field.ToString() + " " + CanMoveBrick(17, Settings.brick14, brickList));
            }
            if (fieldnr == 18)
            {
                brickList = Settings.field18.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick14.Field.ToString() + " " + CanMoveBrick(18, Settings.brick14, brickList));
            }
            if (fieldnr == 19)
            {
                brickList = Settings.field19.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick14.Field.ToString() + " " + CanMoveBrick(19, Settings.brick14, brickList));
            }
            if (fieldnr == 20)
            {
                brickList = Settings.field20.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick14.Field.ToString() + " " + CanMoveBrick(20, Settings.brick14, brickList));
            }
            if (fieldnr == 21)
            {
                brickList = Settings.field21.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick14.Field.ToString() + " " + CanMoveBrick(21, Settings.brick14, brickList));
            }
            if (fieldnr == 22)
            {
                brickList = Settings.field22.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick14.Field.ToString() + " " + CanMoveBrick(22, Settings.brick14, brickList));
            }
            if (fieldnr == 23)
            {
                brickList = Settings.field23.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick14.Field.ToString() + " " + CanMoveBrick(23, Settings.brick14, brickList));
            }
            if (fieldnr == 24)
            {
                brickList = Settings.field24.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick14.Field.ToString() + " " + CanMoveBrick(24, Settings.brick14, brickList));
            }
            if (fieldnr == 25)
            {
                brickList = Settings.field25.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick14.Field.ToString() + " " + CanMoveBrick(25, Settings.brick14, brickList));
            }
            if (fieldnr == 26)
            {
                brickList = Settings.field26.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick14.Field.ToString() + " " + CanMoveBrick(26, Settings.brick14, brickList));
            }
            if (fieldnr == 27)
            {
                brickList = Settings.field27.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick14.Field.ToString() + " " + CanMoveBrick(27, Settings.brick14, brickList));
            }
        }

        private void pictureBoxWhite_15_Click(object sender, EventArgs e)
        {

            int fieldnr = Settings.brick15.Field;
            if (fieldnr == 0)
            {
                brickList = Settings.field0.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick15.Field.ToString() + " " + CanMoveBrick(0, Settings.brick15, brickList));
            }
            if (fieldnr == 1)
            {
                brickList = Settings.field1.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick15.Field.ToString() + " " + CanMoveBrick(1, Settings.brick15, brickList));
            }
            if (fieldnr == 2)
            {
                brickList = Settings.field2.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick15.Field.ToString() + " " + CanMoveBrick(2, Settings.brick15, brickList));
            }
            if (fieldnr == 3)
            {
                brickList = Settings.field3.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick15.Field.ToString() + " " + CanMoveBrick(3, Settings.brick15, brickList));
            }
            if (fieldnr == 4)
            {
                brickList = Settings.field4.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick15.Field.ToString() + " " + CanMoveBrick(4, Settings.brick15, brickList));
            }
            if (fieldnr == 5)
            {
                brickList = Settings.field5.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick15.Field.ToString() + " " + CanMoveBrick(5, Settings.brick15, brickList));
            }
            if (fieldnr == 6)
            {
                brickList = Settings.field6.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick15.Field.ToString() + " " + CanMoveBrick(6, Settings.brick15, brickList));
            }
            if (fieldnr == 7)
            {
                brickList = Settings.field7.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick15.Field.ToString() + " " + CanMoveBrick(7, Settings.brick15, brickList));
            }
            if (fieldnr == 8)
            {
                brickList = Settings.field8.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick15.Field.ToString() + " " + CanMoveBrick(8, Settings.brick15, brickList));
            }
            if (fieldnr == 9)
            {
                brickList = Settings.field9.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick15.Field.ToString() + " " + CanMoveBrick(9, Settings.brick15, brickList));
            }
            if (fieldnr == 10)
            {
                brickList = Settings.field10.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick15.Field.ToString() + " " + CanMoveBrick(10, Settings.brick15, brickList));
            }
            if (fieldnr == 11)
            {
                brickList = Settings.field11.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick15.Field.ToString() + " " + CanMoveBrick(11, Settings.brick15, brickList));
            }
            if (fieldnr == 12)
            {
                brickList = Settings.field12.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick15.Field.ToString() + " " + CanMoveBrick(12, Settings.brick15, brickList));
            }
            if (fieldnr == 13)
            {
                brickList = Settings.field13.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick15.Field.ToString() + " " + CanMoveBrick(13, Settings.brick15, brickList));
            }
            if (fieldnr == 14)
            {
                brickList = Settings.field14.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick15.Field.ToString() + " " + CanMoveBrick(14, Settings.brick15, brickList));
            }
            if (fieldnr == 15)
            {
                brickList = Settings.field15.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick15.Field.ToString() + " " + CanMoveBrick(15, Settings.brick15, brickList));
            }
            if (fieldnr == 16)
            {
                brickList = Settings.field16.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick15.Field.ToString() + " " + CanMoveBrick(16, Settings.brick15, brickList));
            }
            if (fieldnr == 17)
            {
                brickList = Settings.field17.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick15.Field.ToString() + " " + CanMoveBrick(17, Settings.brick15, brickList));
            }
            if (fieldnr == 18)
            {
                brickList = Settings.field18.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick15.Field.ToString() + " " + CanMoveBrick(18, Settings.brick15, brickList));
            }
            if (fieldnr == 19)
            {
                brickList = Settings.field19.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick15.Field.ToString() + " " + CanMoveBrick(19, Settings.brick15, brickList));
            }
            if (fieldnr == 20)
            {
                brickList = Settings.field20.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick15.Field.ToString() + " " + CanMoveBrick(20, Settings.brick15, brickList));
            }
            if (fieldnr == 21)
            {
                brickList = Settings.field21.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick15.Field.ToString() + " " + CanMoveBrick(21, Settings.brick15, brickList));
            }
            if (fieldnr == 22)
            {
                brickList = Settings.field22.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick15.Field.ToString() + " " + CanMoveBrick(22, Settings.brick15, brickList));
            }
            if (fieldnr == 23)
            {
                brickList = Settings.field23.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick15.Field.ToString() + " " + CanMoveBrick(23, Settings.brick15, brickList));
            }
            if (fieldnr == 24)
            {
                brickList = Settings.field24.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick15.Field.ToString() + " " + CanMoveBrick(24, Settings.brick15, brickList));
            }
            if (fieldnr == 25)
            {
                brickList = Settings.field25.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick15.Field.ToString() + " " + CanMoveBrick(25, Settings.brick15, brickList));
            }
            if (fieldnr == 26)
            {
                brickList = Settings.field26.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick15.Field.ToString() + " " + CanMoveBrick(26, Settings.brick15, brickList));
            }
            if (fieldnr == 27)
            {
                brickList = Settings.field27.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick15.Field.ToString() + " " + CanMoveBrick(27, Settings.brick15, brickList));
            }
        }

        private void pictureBoxBlack_1_Click(object sender, EventArgs e)
        {

            int fieldnr = Settings.brick16.Field;
            if (fieldnr == 0)
            {
                brickList = Settings.field0.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick16.Field.ToString() + " " + CanMoveBrick(0, Settings.brick16, brickList));
            }
            if (fieldnr == 1)
            {
                brickList = Settings.field1.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick16.Field.ToString() + " " + CanMoveBrick(1, Settings.brick16, brickList));
            }
            if (fieldnr == 2)
            {
                brickList = Settings.field2.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick16.Field.ToString() + " " + CanMoveBrick(2, Settings.brick16, brickList));
            }
            if (fieldnr == 3)
            {
                brickList = Settings.field3.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick16.Field.ToString() + " " + CanMoveBrick(3, Settings.brick16, brickList));
            }
            if (fieldnr == 4)
            {
                brickList = Settings.field4.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick16.Field.ToString() + " " + CanMoveBrick(4, Settings.brick16, brickList));
            }
            if (fieldnr == 5)
            {
                brickList = Settings.field5.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick16.Field.ToString() + " " + CanMoveBrick(5, Settings.brick16, brickList));
            }
            if (fieldnr == 6)
            {
                brickList = Settings.field6.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick16.Field.ToString() + " " + CanMoveBrick(6, Settings.brick16, brickList));
            }
            if (fieldnr == 7)
            {
                brickList = Settings.field7.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick16.Field.ToString() + " " + CanMoveBrick(7, Settings.brick16, brickList));
            }
            if (fieldnr == 8)
            {
                brickList = Settings.field8.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick16.Field.ToString() + " " + CanMoveBrick(8, Settings.brick16, brickList));
            }
            if (fieldnr == 9)
            {
                brickList = Settings.field9.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick16.Field.ToString() + " " + CanMoveBrick(9, Settings.brick16, brickList));
            }
            if (fieldnr == 10)
            {
                brickList = Settings.field10.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick16.Field.ToString() + " " + CanMoveBrick(10, Settings.brick16, brickList));
            }
            if (fieldnr == 11)
            {
                brickList = Settings.field11.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick16.Field.ToString() + " " + CanMoveBrick(11, Settings.brick16, brickList));
            }
            if (fieldnr == 12)
            {
                brickList = Settings.field12.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick16.Field.ToString() + " " + CanMoveBrick(12, Settings.brick16, brickList));
            }
            if (fieldnr == 13)
            {
                brickList = Settings.field13.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick16.Field.ToString() + " " + CanMoveBrick(13, Settings.brick16, brickList));
            }
            if (fieldnr == 14)
            {
                brickList = Settings.field14.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick16.Field.ToString() + " " + CanMoveBrick(14, Settings.brick16, brickList));
            }
            if (fieldnr == 15)
            {
                brickList = Settings.field15.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick16.Field.ToString() + " " + CanMoveBrick(15, Settings.brick16, brickList));
            }
            if (fieldnr == 16)
            {
                brickList = Settings.field16.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick16.Field.ToString() + " " + CanMoveBrick(16, Settings.brick16, brickList));
            }
            if (fieldnr == 17)
            {
                brickList = Settings.field17.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick16.Field.ToString() + " " + CanMoveBrick(17, Settings.brick16, brickList));
            }
            if (fieldnr == 18)
            {
                brickList = Settings.field18.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick16.Field.ToString() + " " + CanMoveBrick(18, Settings.brick16, brickList));
            }
            if (fieldnr == 19)
            {
                brickList = Settings.field19.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick16.Field.ToString() + " " + CanMoveBrick(19, Settings.brick16, brickList));
            }
            if (fieldnr == 20)
            {
                brickList = Settings.field20.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick16.Field.ToString() + " " + CanMoveBrick(20, Settings.brick16, brickList));
            }
            if (fieldnr == 21)
            {
                brickList = Settings.field21.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick16.Field.ToString() + " " + CanMoveBrick(21, Settings.brick16, brickList));
            }
            if (fieldnr == 22)
            {
                brickList = Settings.field22.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick16.Field.ToString() + " " + CanMoveBrick(22, Settings.brick16, brickList));
            }
            if (fieldnr == 23)
            {
                brickList = Settings.field23.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick16.Field.ToString() + " " + CanMoveBrick(23, Settings.brick16, brickList));
            }
            if (fieldnr == 24)
            {
                brickList = Settings.field24.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick16.Field.ToString() + " " + CanMoveBrick(24, Settings.brick16, brickList));
            }
            if (fieldnr == 25)
            {
                brickList = Settings.field25.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick16.Field.ToString() + " " + CanMoveBrick(25, Settings.brick16, brickList));
            }
            if (fieldnr == 26)
            {
                brickList = Settings.field26.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick16.Field.ToString() + " " + CanMoveBrick(26, Settings.brick16, brickList));
            }
            if (fieldnr == 27)
            {
                brickList = Settings.field27.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick16.Field.ToString() + " " + CanMoveBrick(27, Settings.brick16, brickList));
            }
        }

        private void pictureBoxBlack_2_Click(object sender, EventArgs e)
        {

            int fieldnr = Settings.brick17.Field;
            if (fieldnr == 0)
            {
                brickList = Settings.field0.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick17.Field.ToString() + " " + CanMoveBrick(0, Settings.brick17, brickList));
            }
            if (fieldnr == 1)
            {
                brickList = Settings.field1.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick17.Field.ToString() + " " + CanMoveBrick(1, Settings.brick17, brickList));
            }
            if (fieldnr == 2)
            {
                brickList = Settings.field2.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick17.Field.ToString() + " " + CanMoveBrick(2, Settings.brick17, brickList));
            }
            if (fieldnr == 3)
            {
                brickList = Settings.field3.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick17.Field.ToString() + " " + CanMoveBrick(3, Settings.brick17, brickList));
            }
            if (fieldnr == 4)
            {
                brickList = Settings.field4.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick17.Field.ToString() + " " + CanMoveBrick(4, Settings.brick17, brickList));
            }
            if (fieldnr == 5)
            {
                brickList = Settings.field5.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick17.Field.ToString() + " " + CanMoveBrick(5, Settings.brick17, brickList));
            }
            if (fieldnr == 6)
            {
                brickList = Settings.field6.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick17.Field.ToString() + " " + CanMoveBrick(6, Settings.brick17, brickList));
            }
            if (fieldnr == 7)
            {
                brickList = Settings.field7.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick17.Field.ToString() + " " + CanMoveBrick(7, Settings.brick17, brickList));
            }
            if (fieldnr == 8)
            {
                brickList = Settings.field8.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick17.Field.ToString() + " " + CanMoveBrick(8, Settings.brick17, brickList));
            }
            if (fieldnr == 9)
            {
                brickList = Settings.field9.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick17.Field.ToString() + " " + CanMoveBrick(9, Settings.brick17, brickList));
            }
            if (fieldnr == 10)
            {
                brickList = Settings.field10.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick17.Field.ToString() + " " + CanMoveBrick(10, Settings.brick17, brickList));
            }
            if (fieldnr == 11)
            {
                brickList = Settings.field11.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick17.Field.ToString() + " " + CanMoveBrick(11, Settings.brick17, brickList));
            }
            if (fieldnr == 12)
            {
                brickList = Settings.field12.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick17.Field.ToString() + " " + CanMoveBrick(12, Settings.brick17, brickList));
            }
            if (fieldnr == 13)
            {
                brickList = Settings.field13.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick17.Field.ToString() + " " + CanMoveBrick(13, Settings.brick17, brickList));
            }
            if (fieldnr == 14)
            {
                brickList = Settings.field14.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick17.Field.ToString() + " " + CanMoveBrick(14, Settings.brick17, brickList));
            }
            if (fieldnr == 15)
            {
                brickList = Settings.field15.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick17.Field.ToString() + " " + CanMoveBrick(15, Settings.brick17, brickList));
            }
            if (fieldnr == 16)
            {
                brickList = Settings.field16.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick17.Field.ToString() + " " + CanMoveBrick(16, Settings.brick17, brickList));
            }
            if (fieldnr == 17)
            {
                brickList = Settings.field17.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick17.Field.ToString() + " " + CanMoveBrick(17, Settings.brick17, brickList));
            }
            if (fieldnr == 18)
            {
                brickList = Settings.field18.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick17.Field.ToString() + " " + CanMoveBrick(18, Settings.brick17, brickList));
            }
            if (fieldnr == 19)
            {
                brickList = Settings.field19.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick17.Field.ToString() + " " + CanMoveBrick(19, Settings.brick17, brickList));
            }
            if (fieldnr == 20)
            {
                brickList = Settings.field20.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick17.Field.ToString() + " " + CanMoveBrick(20, Settings.brick17, brickList));
            }
            if (fieldnr == 21)
            {
                brickList = Settings.field21.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick17.Field.ToString() + " " + CanMoveBrick(21, Settings.brick17, brickList));
            }
            if (fieldnr == 22)
            {
                brickList = Settings.field22.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick17.Field.ToString() + " " + CanMoveBrick(22, Settings.brick17, brickList));
            }
            if (fieldnr == 23)
            {
                brickList = Settings.field23.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick17.Field.ToString() + " " + CanMoveBrick(23, Settings.brick17, brickList));
            }
            if (fieldnr == 24)
            {
                brickList = Settings.field24.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick17.Field.ToString() + " " + CanMoveBrick(24, Settings.brick17, brickList));
            }
            if (fieldnr == 25)
            {
                brickList = Settings.field25.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick17.Field.ToString() + " " + CanMoveBrick(25, Settings.brick17, brickList));
            }
            if (fieldnr == 26)
            {
                brickList = Settings.field26.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick17.Field.ToString() + " " + CanMoveBrick(26, Settings.brick17, brickList));
            }
            if (fieldnr == 27)
            {
                brickList = Settings.field27.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick17.Field.ToString() + " " + CanMoveBrick(27, Settings.brick17, brickList));
            }
        }

        private void pictureBoxBlack_3_Click(object sender, EventArgs e)
        {

            int fieldnr = Settings.brick18.Field;
            if (fieldnr == 0)
            {
                brickList = Settings.field0.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick18.Field.ToString() + " " + CanMoveBrick(0, Settings.brick18, brickList));
            }
            if (fieldnr == 1)
            {
                brickList = Settings.field1.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick18.Field.ToString() + " " + CanMoveBrick(1, Settings.brick18, brickList));
            }    
            if (fieldnr == 2)
            {
                brickList = Settings.field2.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick18.Field.ToString() + " " + CanMoveBrick(2, Settings.brick18, brickList));
            }
            if (fieldnr == 3)
            {
                brickList = Settings.field3.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick18.Field.ToString() + " " + CanMoveBrick(3, Settings.brick18, brickList));
            }
            if (fieldnr == 4)
            {
                brickList = Settings.field4.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick18.Field.ToString() + " " + CanMoveBrick(4, Settings.brick18, brickList));
            }
            if (fieldnr == 5)
            {
                brickList = Settings.field5.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick18.Field.ToString() + " " + CanMoveBrick(5, Settings.brick18, brickList));
            }
            if (fieldnr == 6)
            {
                brickList = Settings.field6.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick18.Field.ToString() + " " + CanMoveBrick(6, Settings.brick18, brickList));
            }
            if (fieldnr == 7)
            {
                brickList = Settings.field7.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick18.Field.ToString() + " " + CanMoveBrick(7, Settings.brick18, brickList));
            }
            if (fieldnr == 8)
            {
                brickList = Settings.field8.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick18.Field.ToString() + " " + CanMoveBrick(8, Settings.brick18, brickList));
            }
            if (fieldnr == 9)
            {
                brickList = Settings.field9.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick18.Field.ToString() + " " + CanMoveBrick(9, Settings.brick18, brickList));
            }
            if (fieldnr == 10)
            {
                brickList = Settings.field10.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick18.Field.ToString() + " " + CanMoveBrick(10, Settings.brick18, brickList));
            }
            if (fieldnr == 11)
            {
                brickList = Settings.field11.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick18.Field.ToString() + " " + CanMoveBrick(11, Settings.brick18, brickList));
            }
            if (fieldnr == 12)
            {
                brickList = Settings.field12.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick18.Field.ToString() + " " + CanMoveBrick(12, Settings.brick18, brickList));
            }
            if (fieldnr == 13)
            {
                brickList = Settings.field13.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick18.Field.ToString() + " " + CanMoveBrick(13, Settings.brick18, brickList));
            }
            if (fieldnr == 14)
            {
                brickList = Settings.field14.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick18.Field.ToString() + " " + CanMoveBrick(14, Settings.brick18, brickList));
            }
            if (fieldnr == 15)
            {
                brickList = Settings.field15.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick18.Field.ToString() + " " + CanMoveBrick(15, Settings.brick18, brickList));
            }
            if (fieldnr == 16)
            {
                brickList = Settings.field16.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick18.Field.ToString() + " " + CanMoveBrick(16, Settings.brick18, brickList));
            }
            if (fieldnr == 17)
            {
                brickList = Settings.field17.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick18.Field.ToString() + " " + CanMoveBrick(17, Settings.brick18, brickList));
            }
            if (fieldnr == 18)
            {
                brickList = Settings.field18.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick18.Field.ToString() + " " + CanMoveBrick(18, Settings.brick18, brickList));
            }
            if (fieldnr == 19)
            {
                brickList = Settings.field19.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick18.Field.ToString() + " " + CanMoveBrick(19, Settings.brick18, brickList));
            }
            if (fieldnr == 20)
            {
                brickList = Settings.field20.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick18.Field.ToString() + " " + CanMoveBrick(20, Settings.brick18, brickList));
            }
            if (fieldnr == 21)
            {
                brickList = Settings.field21.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick18.Field.ToString() + " " + CanMoveBrick(21, Settings.brick18, brickList));
            }
            if (fieldnr == 22)
            {
                brickList = Settings.field22.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick18.Field.ToString() + " " + CanMoveBrick(22, Settings.brick18, brickList));
            }
            if (fieldnr == 23)
            {
                brickList = Settings.field23.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick18.Field.ToString() + " " + CanMoveBrick(23, Settings.brick18, brickList));
            }
            if (fieldnr == 24)
            {
                brickList = Settings.field24.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick18.Field.ToString() + " " + CanMoveBrick(24, Settings.brick18, brickList));
            }
            if (fieldnr == 25)
            {
                brickList = Settings.field25.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick18.Field.ToString() + " " + CanMoveBrick(25, Settings.brick18, brickList));
            }
            if (fieldnr == 26)
            {
                brickList = Settings.field26.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick18.Field.ToString() + " " + CanMoveBrick(26, Settings.brick18, brickList));
            }
            if (fieldnr == 27)
            {
                brickList = Settings.field27.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick18.Field.ToString() + " " + CanMoveBrick(27, Settings.brick18, brickList));
            }
        }

        private void pictureBoxBlack_4_Click(object sender, EventArgs e)
        {

            int fieldnr = Settings.brick19.Field;
            if (fieldnr == 0)
            {
                brickList = Settings.field0.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick19.Field.ToString() + " " + CanMoveBrick(0, Settings.brick19, brickList));
            }
            if (fieldnr == 1)
            {
                brickList = Settings.field1.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick19.Field.ToString() + " " + CanMoveBrick(1, Settings.brick19, brickList));
            }
            if (fieldnr == 2)
            {
                brickList = Settings.field2.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick19.Field.ToString() + " " + CanMoveBrick(2, Settings.brick19, brickList));
            }
            if (fieldnr == 3)
            {
                brickList = Settings.field3.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick19.Field.ToString() + " " + CanMoveBrick(3, Settings.brick19, brickList));
            }
            if (fieldnr == 4)
            {
                brickList = Settings.field4.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick19.Field.ToString() + " " + CanMoveBrick(4, Settings.brick19, brickList));
            }
            if (fieldnr == 5)
            {
                brickList = Settings.field5.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick19.Field.ToString() + " " + CanMoveBrick(5, Settings.brick19, brickList));
            }
            if (fieldnr == 6)
            {
                brickList = Settings.field6.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick19.Field.ToString() + " " + CanMoveBrick(6, Settings.brick19, brickList));
            }
            if (fieldnr == 7)
            {
                brickList = Settings.field7.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick19.Field.ToString() + " " + CanMoveBrick(7, Settings.brick19, brickList));
            }
            if (fieldnr == 8)
            {
                brickList = Settings.field8.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick19.Field.ToString() + " " + CanMoveBrick(8, Settings.brick19, brickList));
            }
            if (fieldnr == 9)
            {
                brickList = Settings.field9.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick19.Field.ToString() + " " + CanMoveBrick(9, Settings.brick19, brickList));
            }
            if (fieldnr == 10)
            {
                brickList = Settings.field10.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick19.Field.ToString() + " " + CanMoveBrick(10, Settings.brick19, brickList));
            }
            if (fieldnr == 11)
            {
                brickList = Settings.field11.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick19.Field.ToString() + " " + CanMoveBrick(11, Settings.brick19, brickList));
            }
            if (fieldnr == 12)
            {
                brickList = Settings.field12.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick19.Field.ToString() + " " + CanMoveBrick(12, Settings.brick19, brickList));
            }
            if (fieldnr == 13)
            {
                brickList = Settings.field13.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick19.Field.ToString() + " " + CanMoveBrick(13, Settings.brick19, brickList));
            }
            if (fieldnr == 14)
            {
                brickList = Settings.field14.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick19.Field.ToString() + " " + CanMoveBrick(14, Settings.brick19, brickList));
            }
            if (fieldnr == 15)
            {
                brickList = Settings.field15.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick19.Field.ToString() + " " + CanMoveBrick(15, Settings.brick19, brickList));
            }
            if (fieldnr == 16)
            {
                brickList = Settings.field16.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick19.Field.ToString() + " " + CanMoveBrick(16, Settings.brick19, brickList));
            }
            if (fieldnr == 17)
            {
                brickList = Settings.field17.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick19.Field.ToString() + " " + CanMoveBrick(17, Settings.brick19, brickList));
            }
            if (fieldnr == 18)
            {
                brickList = Settings.field18.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick19.Field.ToString() + " " + CanMoveBrick(18, Settings.brick19, brickList));
            }
            if (fieldnr == 19)
            {
                brickList = Settings.field19.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick19.Field.ToString() + " " + CanMoveBrick(19, Settings.brick19, brickList));
            }
            if (fieldnr == 20)
            {
                brickList = Settings.field20.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick19.Field.ToString() + " " + CanMoveBrick(20, Settings.brick19, brickList));
            }
            if (fieldnr == 21)
            {
                brickList = Settings.field21.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick19.Field.ToString() + " " + CanMoveBrick(21, Settings.brick19, brickList));
            }
            if (fieldnr == 22)
            {
                brickList = Settings.field22.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick19.Field.ToString() + " " + CanMoveBrick(22, Settings.brick19, brickList));
            }
            if (fieldnr == 23)
            {
                brickList = Settings.field23.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick19.Field.ToString() + " " + CanMoveBrick(23, Settings.brick19, brickList));
            }
            if (fieldnr == 24)
            {
                brickList = Settings.field24.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick19.Field.ToString() + " " + CanMoveBrick(24, Settings.brick19, brickList));
            }
            if (fieldnr == 25)
            {
                brickList = Settings.field25.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick19.Field.ToString() + " " + CanMoveBrick(25, Settings.brick19, brickList));
            }
            if (fieldnr == 26)
            {
                brickList = Settings.field26.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick19.Field.ToString() + " " + CanMoveBrick(26, Settings.brick19, brickList));
            }
            if (fieldnr == 27)
            {
                brickList = Settings.field27.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick19.Field.ToString() + " " + CanMoveBrick(27, Settings.brick19, brickList));
            }
        }

        private void pictureBoxBlack_5_Click(object sender, EventArgs e)
        {

            int fieldnr = Settings.brick20.Field;
            if (fieldnr == 0)
            {
                brickList = Settings.field0.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick20.Field.ToString() + " " + CanMoveBrick(0, Settings.brick20, brickList));
            }
            if (fieldnr == 1)
            {
                brickList = Settings.field1.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick20.Field.ToString() + " " + CanMoveBrick(1, Settings.brick20, brickList));
            }
            if (fieldnr == 2)
            {
                brickList = Settings.field2.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick20.Field.ToString() + " " + CanMoveBrick(2, Settings.brick20, brickList));
            }
            if (fieldnr == 3)
            {
                brickList = Settings.field3.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick20.Field.ToString() + " " + CanMoveBrick(3, Settings.brick20, brickList));
            }
            if (fieldnr == 4)
            {
                brickList = Settings.field4.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick20.Field.ToString() + " " + CanMoveBrick(4, Settings.brick20, brickList));
            }
            if (fieldnr == 5)
            {
                brickList = Settings.field5.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick20.Field.ToString() + " " + CanMoveBrick(5, Settings.brick20, brickList));
            }
            if (fieldnr == 6)
            {
                brickList = Settings.field6.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick20.Field.ToString() + " " + CanMoveBrick(6, Settings.brick20, brickList));
            }
            if (fieldnr == 7)
            {
                brickList = Settings.field7.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick20.Field.ToString() + " " + CanMoveBrick(7, Settings.brick20, brickList));
            }
            if (fieldnr == 8)
            {
                brickList = Settings.field8.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick20.Field.ToString() + " " + CanMoveBrick(8, Settings.brick20, brickList));
            }
            if (fieldnr == 9)
            {
                brickList = Settings.field9.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick20.Field.ToString() + " " + CanMoveBrick(9, Settings.brick20, brickList));
            }
            if (fieldnr == 10)
            {
                brickList = Settings.field10.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick20.Field.ToString() + " " + CanMoveBrick(10, Settings.brick20, brickList));
            }
            if (fieldnr == 11)
            {
                brickList = Settings.field11.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick20.Field.ToString() + " " + CanMoveBrick(11, Settings.brick20, brickList));
            }
            if (fieldnr == 12)
            {
                brickList = Settings.field12.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick20.Field.ToString() + " " + CanMoveBrick(12, Settings.brick20, brickList));
            }
            if (fieldnr == 13)
            {
                brickList = Settings.field13.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick20.Field.ToString() + " " + CanMoveBrick(13, Settings.brick20, brickList));
            }
            if (fieldnr == 14)
            {
                brickList = Settings.field14.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick20.Field.ToString() + " " + CanMoveBrick(14, Settings.brick20, brickList));
            }
            if (fieldnr == 15)
            {
                brickList = Settings.field15.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick20.Field.ToString() + " " + CanMoveBrick(15, Settings.brick20, brickList));
            }
            if (fieldnr == 16)
            {
                brickList = Settings.field16.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick20.Field.ToString() + " " + CanMoveBrick(16, Settings.brick20, brickList));
            }
            if (fieldnr == 17)
            {
                brickList = Settings.field17.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick20.Field.ToString() + " " + CanMoveBrick(17, Settings.brick20, brickList));
            }
            if (fieldnr == 18)
            {
                brickList = Settings.field18.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick20.Field.ToString() + " " + CanMoveBrick(18, Settings.brick20, brickList));
            }
            if (fieldnr == 19)
            {
                brickList = Settings.field19.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick20.Field.ToString() + " " + CanMoveBrick(19, Settings.brick20, brickList));
            }
            if (fieldnr == 20)
            {
                brickList = Settings.field20.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick20.Field.ToString() + " " + CanMoveBrick(20, Settings.brick20, brickList));
            }
            if (fieldnr == 21)
            {
                brickList = Settings.field21.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick20.Field.ToString() + " " + CanMoveBrick(21, Settings.brick20, brickList));
            }
            if (fieldnr == 22)
            {
                brickList = Settings.field22.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick20.Field.ToString() + " " + CanMoveBrick(22, Settings.brick20, brickList));
            }
            if (fieldnr == 23)
            {
                brickList = Settings.field23.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick20.Field.ToString() + " " + CanMoveBrick(23, Settings.brick20, brickList));
            }
            if (fieldnr == 24)
            {
                brickList = Settings.field24.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick20.Field.ToString() + " " + CanMoveBrick(24, Settings.brick20, brickList));
            }
            if (fieldnr == 25)
            {
                brickList = Settings.field25.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick20.Field.ToString() + " " + CanMoveBrick(25, Settings.brick20, brickList));
            }
            if (fieldnr == 26)
            {
                brickList = Settings.field26.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick20.Field.ToString() + " " + CanMoveBrick(26, Settings.brick20, brickList));
            }
            if (fieldnr == 27)
            {
                brickList = Settings.field27.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick20.Field.ToString() + " " + CanMoveBrick(27, Settings.brick20, brickList));
            }
        }

        private void pictureBoxBlack_6_Click(object sender, EventArgs e)
        {

            int fieldnr = Settings.brick21.Field;
            if (fieldnr == 0)
            {
                brickList = Settings.field0.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick21.Field.ToString() + " " + CanMoveBrick(0, Settings.brick21, brickList));
            }
            if (fieldnr == 1)
            {
                brickList = Settings.field1.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick21.Field.ToString() + " " + CanMoveBrick(1, Settings.brick21, brickList));
            }
            if (fieldnr == 2)
            {
                brickList = Settings.field2.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick21.Field.ToString() + " " + CanMoveBrick(2, Settings.brick21, brickList));
            }
            if (fieldnr == 3)
            {
                brickList = Settings.field3.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick21.Field.ToString() + " " + CanMoveBrick(3, Settings.brick21, brickList));
            }
            if (fieldnr == 4)
            {
                brickList = Settings.field4.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick21.Field.ToString() + " " + CanMoveBrick(4, Settings.brick21, brickList));
            }
            if (fieldnr == 5)
            {
                brickList = Settings.field5.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick21.Field.ToString() + " " + CanMoveBrick(5, Settings.brick21, brickList));
            }
            if (fieldnr == 6)
            {
                brickList = Settings.field6.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick21.Field.ToString() + " " + CanMoveBrick(6, Settings.brick21, brickList));
            }
            if (fieldnr == 7)
            {
                brickList = Settings.field7.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick21.Field.ToString() + " " + CanMoveBrick(7, Settings.brick21, brickList));
            }
            if (fieldnr == 8)
            {
                brickList = Settings.field8.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick21.Field.ToString() + " " + CanMoveBrick(8, Settings.brick21, brickList));
            }
            if (fieldnr == 9)
            {
                brickList = Settings.field9.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick21.Field.ToString() + " " + CanMoveBrick(9, Settings.brick21, brickList));
            }
            if (fieldnr == 10)
            {
                brickList = Settings.field10.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick21.Field.ToString() + " " + CanMoveBrick(10, Settings.brick21, brickList));
            }
            if (fieldnr == 11)
            {
                brickList = Settings.field11.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick21.Field.ToString() + " " + CanMoveBrick(11, Settings.brick21, brickList));
            }
            if (fieldnr == 12)
            {
                brickList = Settings.field12.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick21.Field.ToString() + " " + CanMoveBrick(12, Settings.brick21, brickList));
            }
            if (fieldnr == 13)
            {
                brickList = Settings.field13.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick21.Field.ToString() + " " + CanMoveBrick(13, Settings.brick21, brickList));
            }
            if (fieldnr == 14)
            {
                brickList = Settings.field14.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick21.Field.ToString() + " " + CanMoveBrick(14, Settings.brick21, brickList));
            }
            if (fieldnr == 15)
            {
                brickList = Settings.field15.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick21.Field.ToString() + " " + CanMoveBrick(15, Settings.brick21, brickList));
            }
            if (fieldnr == 16)
            {
                brickList = Settings.field16.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick21.Field.ToString() + " " + CanMoveBrick(16, Settings.brick21, brickList));
            }
            if (fieldnr == 17)
            {
                brickList = Settings.field17.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick21.Field.ToString() + " " + CanMoveBrick(17, Settings.brick21, brickList));
            }
            if (fieldnr == 18)
            {
                brickList = Settings.field18.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick21.Field.ToString() + " " + CanMoveBrick(18, Settings.brick21, brickList));
            }
            if (fieldnr == 19)
            {
                brickList = Settings.field19.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick21.Field.ToString() + " " + CanMoveBrick(19, Settings.brick21, brickList));
            }
            if (fieldnr == 20)
            {
                brickList = Settings.field20.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick21.Field.ToString() + " " + CanMoveBrick(20, Settings.brick21, brickList));
            }
            if (fieldnr == 21)
            {
                brickList = Settings.field21.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick21.Field.ToString() + " " + CanMoveBrick(21, Settings.brick21, brickList));
            }
            if (fieldnr == 22)
            {
                brickList = Settings.field22.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick21.Field.ToString() + " " + CanMoveBrick(22, Settings.brick21, brickList));
            }
            if (fieldnr == 23)
            {
                brickList = Settings.field23.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick21.Field.ToString() + " " + CanMoveBrick(23, Settings.brick21, brickList));
            }
            if (fieldnr == 24)
            {
                brickList = Settings.field24.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick21.Field.ToString() + " " + CanMoveBrick(24, Settings.brick21, brickList));
            }
            if (fieldnr == 25)
            {
                brickList = Settings.field25.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick21.Field.ToString() + " " + CanMoveBrick(25, Settings.brick21, brickList));
            }
            if (fieldnr == 26)
            {
                brickList = Settings.field26.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick21.Field.ToString() + " " + CanMoveBrick(26, Settings.brick21, brickList));
            }
            if (fieldnr == 27)
            {
                brickList = Settings.field27.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick21.Field.ToString() + " " + CanMoveBrick(27, Settings.brick21, brickList));
            }
        }

        private void pictureBoxBlack_7_Click(object sender, EventArgs e)
        {

            int fieldnr = Settings.brick22.Field;
            if (fieldnr == 0)
            {
                brickList = Settings.field0.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick22.Field.ToString() + " " + CanMoveBrick(0, Settings.brick22, brickList));
            }
            if (fieldnr == 1)
            {
                brickList = Settings.field1.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick22.Field.ToString() + " " + CanMoveBrick(1, Settings.brick22, brickList));
            }
            if (fieldnr == 2)
            {
                brickList = Settings.field2.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick22.Field.ToString() + " " + CanMoveBrick(2, Settings.brick22, brickList));
            }
            if (fieldnr == 3)
            {
                brickList = Settings.field3.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick22.Field.ToString() + " " + CanMoveBrick(3, Settings.brick22, brickList));
            }
            if (fieldnr == 4)
            {
                brickList = Settings.field4.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick22.Field.ToString() + " " + CanMoveBrick(4, Settings.brick22, brickList));
            }
            if (fieldnr == 5)
            {
                brickList = Settings.field5.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick22.Field.ToString() + " " + CanMoveBrick(5, Settings.brick22, brickList));
            }
            if (fieldnr == 6)
            {
                brickList = Settings.field6.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick22.Field.ToString() + " " + CanMoveBrick(6, Settings.brick22, brickList));
            }
            if (fieldnr == 7)
            {
                brickList = Settings.field7.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick22.Field.ToString() + " " + CanMoveBrick(7, Settings.brick22, brickList));
            }
            if (fieldnr == 8)
            {
                brickList = Settings.field8.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick22.Field.ToString() + " " + CanMoveBrick(8, Settings.brick22, brickList));
            }
            if (fieldnr == 9)
            {
                brickList = Settings.field9.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick22.Field.ToString() + " " + CanMoveBrick(9, Settings.brick22, brickList));
            }
            if (fieldnr == 10)
            {
                brickList = Settings.field10.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick22.Field.ToString() + " " + CanMoveBrick(10, Settings.brick22, brickList));
            }
            if (fieldnr == 11)
            {
                brickList = Settings.field11.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick22.Field.ToString() + " " + CanMoveBrick(11, Settings.brick22, brickList));
            }
            if (fieldnr == 12)
            {
                brickList = Settings.field12.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick22.Field.ToString() + " " + CanMoveBrick(12, Settings.brick22, brickList));
            }
            if (fieldnr == 13)
            {
                brickList = Settings.field13.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick22.Field.ToString() + " " + CanMoveBrick(13, Settings.brick22, brickList));
            }
            if (fieldnr == 14)
            {
                brickList = Settings.field14.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick22.Field.ToString() + " " + CanMoveBrick(14, Settings.brick22, brickList));
            }
            if (fieldnr == 15)
            {
                brickList = Settings.field15.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick22.Field.ToString() + " " + CanMoveBrick(15, Settings.brick22, brickList));
            }
            if (fieldnr == 16)
            {
                brickList = Settings.field16.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick22.Field.ToString() + " " + CanMoveBrick(16, Settings.brick22, brickList));
            }
            if (fieldnr == 17)
            {
                brickList = Settings.field17.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick22.Field.ToString() + " " + CanMoveBrick(17, Settings.brick22, brickList));
            }
            if (fieldnr == 18)
            {
                brickList = Settings.field18.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick22.Field.ToString() + " " + CanMoveBrick(18, Settings.brick22, brickList));
            }
            if (fieldnr == 19)
            {
                brickList = Settings.field19.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick22.Field.ToString() + " " + CanMoveBrick(19, Settings.brick22, brickList));
            }
            if (fieldnr == 20)
            {
                brickList = Settings.field20.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick22.Field.ToString() + " " + CanMoveBrick(20, Settings.brick22, brickList));
            }
            if (fieldnr == 21)
            {
                brickList = Settings.field21.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick22.Field.ToString() + " " + CanMoveBrick(21, Settings.brick22, brickList));
            }
            if (fieldnr == 22)
            {
                brickList = Settings.field22.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick22.Field.ToString() + " " + CanMoveBrick(22, Settings.brick22, brickList));
            }
            if (fieldnr == 23)
            {
                brickList = Settings.field23.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick22.Field.ToString() + " " + CanMoveBrick(23, Settings.brick22, brickList));
            }
            if (fieldnr == 24)
            {
                brickList = Settings.field24.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick22.Field.ToString() + " " + CanMoveBrick(24, Settings.brick22, brickList));
            }
            if (fieldnr == 25)
            {
                brickList = Settings.field25.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick22.Field.ToString() + " " + CanMoveBrick(25, Settings.brick22, brickList));
            }
            if (fieldnr == 26)
            {
                brickList = Settings.field26.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick22.Field.ToString() + " " + CanMoveBrick(26, Settings.brick22, brickList));
            }
            if (fieldnr == 27)
            {
                brickList = Settings.field27.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick22.Field.ToString() + " " + CanMoveBrick(27, Settings.brick22, brickList));
            }
        }

        private void pictureBoxBlack_8_Click(object sender, EventArgs e)
        {

            int fieldnr = Settings.brick23.Field;
            if (fieldnr == 0)
            {
                brickList = Settings.field0.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick23.Field.ToString() + " " + CanMoveBrick(0, Settings.brick23, brickList));
            }
            if (fieldnr == 1)
            {
                brickList = Settings.field1.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick23.Field.ToString() + " " + CanMoveBrick(1, Settings.brick23, brickList));
            }
            if (fieldnr == 2)
            {
                brickList = Settings.field2.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick23.Field.ToString() + " " + CanMoveBrick(2, Settings.brick23, brickList));
            }
            if (fieldnr == 3)
            {
                brickList = Settings.field3.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick23.Field.ToString() + " " + CanMoveBrick(3, Settings.brick23, brickList));
            }
            if (fieldnr == 4)
            {
                brickList = Settings.field4.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick23.Field.ToString() + " " + CanMoveBrick(4, Settings.brick23, brickList));
            }
            if (fieldnr == 5)
            {
                brickList = Settings.field5.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick23.Field.ToString() + " " + CanMoveBrick(5, Settings.brick23, brickList));
            }
            if (fieldnr == 6)
            {
                brickList = Settings.field6.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick23.Field.ToString() + " " + CanMoveBrick(6, Settings.brick23, brickList));
            }
            if (fieldnr == 7)
            {
                brickList = Settings.field7.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick23.Field.ToString() + " " + CanMoveBrick(7, Settings.brick23, brickList));
            }
            if (fieldnr == 8)
            {
                brickList = Settings.field8.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick23.Field.ToString() + " " + CanMoveBrick(8, Settings.brick23, brickList));
            }
            if (fieldnr == 9)
            {
                brickList = Settings.field9.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick23.Field.ToString() + " " + CanMoveBrick(9, Settings.brick23, brickList));
            }
            if (fieldnr == 10)
            {
                brickList = Settings.field10.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick23.Field.ToString() + " " + CanMoveBrick(10, Settings.brick23, brickList));
            }
            if (fieldnr == 11)
            {
                brickList = Settings.field11.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick23.Field.ToString() + " " + CanMoveBrick(11, Settings.brick23, brickList));
            }
            if (fieldnr == 12)
            {
                brickList = Settings.field12.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick23.Field.ToString() + " " + CanMoveBrick(12, Settings.brick23, brickList));
            }
            if (fieldnr == 13)
            {
                brickList = Settings.field13.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick23.Field.ToString() + " " + CanMoveBrick(13, Settings.brick23, brickList));
            }
            if (fieldnr == 14)
            {
                brickList = Settings.field14.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick23.Field.ToString() + " " + CanMoveBrick(14, Settings.brick23, brickList));
            }
            if (fieldnr == 15)
            {
                brickList = Settings.field15.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick23.Field.ToString() + " " + CanMoveBrick(15, Settings.brick23, brickList));
            }
            if (fieldnr == 16)
            {
                brickList = Settings.field16.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick23.Field.ToString() + " " + CanMoveBrick(16, Settings.brick23, brickList));
            }
            if (fieldnr == 17)
            {
                brickList = Settings.field17.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick23.Field.ToString() + " " + CanMoveBrick(17, Settings.brick23, brickList));
            }
            if (fieldnr == 18)
            {
                brickList = Settings.field18.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick23.Field.ToString() + " " + CanMoveBrick(18, Settings.brick23, brickList));
            }
            if (fieldnr == 19)
            {
                brickList = Settings.field19.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick23.Field.ToString() + " " + CanMoveBrick(19, Settings.brick23, brickList));
            }
            if (fieldnr == 20)
            {
                brickList = Settings.field20.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick23.Field.ToString() + " " + CanMoveBrick(20, Settings.brick23, brickList));
            }
            if (fieldnr == 21)
            {
                brickList = Settings.field21.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick23.Field.ToString() + " " + CanMoveBrick(21, Settings.brick23, brickList));
            }
            if (fieldnr == 22)
            {
                brickList = Settings.field22.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick23.Field.ToString() + " " + CanMoveBrick(22, Settings.brick23, brickList));
            }
            if (fieldnr == 23)
            {
                brickList = Settings.field23.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick23.Field.ToString() + " " + CanMoveBrick(23, Settings.brick23, brickList));
            }
            if (fieldnr == 24)
            {
                brickList = Settings.field24.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick23.Field.ToString() + " " + CanMoveBrick(24, Settings.brick23, brickList));
            }
            if (fieldnr == 25)
            {
                brickList = Settings.field25.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick23.Field.ToString() + " " + CanMoveBrick(25, Settings.brick23, brickList));
            }
            if (fieldnr == 26)
            {
                brickList = Settings.field26.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick23.Field.ToString() + " " + CanMoveBrick(26, Settings.brick23, brickList));
            }
            if (fieldnr == 27)
            {
                brickList = Settings.field27.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick23.Field.ToString() + " " + CanMoveBrick(27, Settings.brick23, brickList));
            }
        }

        private void pictureBoxBlack_9_Click(object sender, EventArgs e)
        {

            int fieldnr = Settings.brick24.Field;
            if (fieldnr == 0)
            {
                brickList = Settings.field0.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick24.Field.ToString() + " " + CanMoveBrick(0, Settings.brick24, brickList));
            }
            if (fieldnr == 1)
            {
                brickList = Settings.field1.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick24.Field.ToString() + " " + CanMoveBrick(1, Settings.brick24, brickList));
            }
            if (fieldnr == 2)
            {
                brickList = Settings.field2.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick24.Field.ToString() + " " + CanMoveBrick(2, Settings.brick24, brickList));
            }
            if (fieldnr == 3)
            {
                brickList = Settings.field3.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick24.Field.ToString() + " " + CanMoveBrick(3, Settings.brick24, brickList));
            }
            if (fieldnr == 4)
            {
                brickList = Settings.field4.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick24.Field.ToString() + " " + CanMoveBrick(4, Settings.brick24, brickList));
            }
            if (fieldnr == 5)
            {
                brickList = Settings.field5.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick24.Field.ToString() + " " + CanMoveBrick(5, Settings.brick24, brickList));
            }
            if (fieldnr == 6)
            {
                brickList = Settings.field6.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick24.Field.ToString() + " " + CanMoveBrick(6, Settings.brick24, brickList));
            }
            if (fieldnr == 7)
            {
                brickList = Settings.field7.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick24.Field.ToString() + " " + CanMoveBrick(7, Settings.brick24, brickList));
            }
            if (fieldnr == 8)
            {
                brickList = Settings.field8.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick24.Field.ToString() + " " + CanMoveBrick(8, Settings.brick24, brickList));
            }
            if (fieldnr == 9)
            {
                brickList = Settings.field9.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick24.Field.ToString() + " " + CanMoveBrick(9, Settings.brick24, brickList));
            }
            if (fieldnr == 10)
            {
                brickList = Settings.field10.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick24.Field.ToString() + " " + CanMoveBrick(10, Settings.brick24, brickList));
            }
            if (fieldnr == 11)
            {
                brickList = Settings.field11.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick24.Field.ToString() + " " + CanMoveBrick(11, Settings.brick24, brickList));
            }
            if (fieldnr == 12)
            {
                brickList = Settings.field12.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick24.Field.ToString() + " " + CanMoveBrick(12, Settings.brick24, brickList));
            }
            if (fieldnr == 13)
            {
                brickList = Settings.field13.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick24.Field.ToString() + " " + CanMoveBrick(13, Settings.brick24, brickList));
            }
            if (fieldnr == 14)
            {
                brickList = Settings.field14.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick24.Field.ToString() + " " + CanMoveBrick(14, Settings.brick24, brickList));
            }
            if (fieldnr == 15)
            {
                brickList = Settings.field15.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick24.Field.ToString() + " " + CanMoveBrick(15, Settings.brick24, brickList));
            }
            if (fieldnr == 16)
            {
                brickList = Settings.field16.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick24.Field.ToString() + " " + CanMoveBrick(16, Settings.brick24, brickList));
            }
            if (fieldnr == 17)
            {
                brickList = Settings.field17.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick24.Field.ToString() + " " + CanMoveBrick(17, Settings.brick24, brickList));
            }
            if (fieldnr == 18)
            {
                brickList = Settings.field18.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick24.Field.ToString() + " " + CanMoveBrick(18, Settings.brick24, brickList));
            }
            if (fieldnr == 19)
            {
                brickList = Settings.field19.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick24.Field.ToString() + " " + CanMoveBrick(19, Settings.brick24, brickList));
            }
            if (fieldnr == 20)
            {
                brickList = Settings.field20.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick24.Field.ToString() + " " + CanMoveBrick(20, Settings.brick24, brickList));
            }
            if (fieldnr == 21)
            {
                brickList = Settings.field21.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick24.Field.ToString() + " " + CanMoveBrick(21, Settings.brick24, brickList));
            }
            if (fieldnr == 22)
            {
                brickList = Settings.field22.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick24.Field.ToString() + " " + CanMoveBrick(22, Settings.brick24, brickList));
            }
            if (fieldnr == 23)
            {
                brickList = Settings.field23.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick24.Field.ToString() + " " + CanMoveBrick(23, Settings.brick24, brickList));
            }
            if (fieldnr == 24)
            {
                brickList = Settings.field24.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick24.Field.ToString() + " " + CanMoveBrick(24, Settings.brick24, brickList));
            }
            if (fieldnr == 25)
            {
                brickList = Settings.field25.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick24.Field.ToString() + " " + CanMoveBrick(25, Settings.brick24, brickList));
            }
            if (fieldnr == 26)
            {
                brickList = Settings.field26.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick24.Field.ToString() + " " + CanMoveBrick(26, Settings.brick24, brickList));
            }
            if (fieldnr == 27)
            {
                brickList = Settings.field27.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick24.Field.ToString() + " " + CanMoveBrick(27, Settings.brick24, brickList));
            }
        }

        private void pictureBoxBlack_10_Click(object sender, EventArgs e)
        {

            int fieldnr = Settings.brick25.Field;
            if (fieldnr == 0)
            {
                brickList = Settings.field0.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick25.Field.ToString() + " " + CanMoveBrick(0, Settings.brick25, brickList));
            }
            if (fieldnr == 1)
            {
                brickList = Settings.field1.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick25.Field.ToString() + " " + CanMoveBrick(1, Settings.brick25, brickList));
            }
            if (fieldnr == 2)
            {
                brickList = Settings.field2.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick25.Field.ToString() + " " + CanMoveBrick(2, Settings.brick25, brickList));
            }
            if (fieldnr == 3)
            {
                brickList = Settings.field3.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick25.Field.ToString() + " " + CanMoveBrick(3, Settings.brick25, brickList));
            }
            if (fieldnr == 4)
            {
                brickList = Settings.field4.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick25.Field.ToString() + " " + CanMoveBrick(4, Settings.brick25, brickList));
            }
            if (fieldnr == 5)
            {
                brickList = Settings.field5.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick25.Field.ToString() + " " + CanMoveBrick(5, Settings.brick25, brickList));
            }
            if (fieldnr == 6)
            {
                brickList = Settings.field6.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick25.Field.ToString() + " " + CanMoveBrick(6, Settings.brick25, brickList));
            }
            if (fieldnr == 7)
            {
                brickList = Settings.field7.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick25.Field.ToString() + " " + CanMoveBrick(7, Settings.brick25, brickList));
            }
            if (fieldnr == 8)
            {
                brickList = Settings.field8.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick25.Field.ToString() + " " + CanMoveBrick(8, Settings.brick25, brickList));
            }
            if (fieldnr == 9)
            {
                brickList = Settings.field9.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick25.Field.ToString() + " " + CanMoveBrick(9, Settings.brick25, brickList));
            }
            if (fieldnr == 10)
            {
                brickList = Settings.field10.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick25.Field.ToString() + " " + CanMoveBrick(10, Settings.brick25, brickList));
            }
            if (fieldnr == 11)
            {
                brickList = Settings.field11.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick25.Field.ToString() + " " + CanMoveBrick(11, Settings.brick25, brickList));
            }
            if (fieldnr == 12)
            {
                brickList = Settings.field12.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick25.Field.ToString() + " " + CanMoveBrick(12, Settings.brick25, brickList));
            }
            if (fieldnr == 13)
            {
                brickList = Settings.field13.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick25.Field.ToString() + " " + CanMoveBrick(13, Settings.brick25, brickList));
            }
            if (fieldnr == 14)
            {
                brickList = Settings.field14.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick25.Field.ToString() + " " + CanMoveBrick(14, Settings.brick25, brickList));
            }
            if (fieldnr == 15)
            {
                brickList = Settings.field15.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick25.Field.ToString() + " " + CanMoveBrick(15, Settings.brick25, brickList));
            }
            if (fieldnr == 16)
            {
                brickList = Settings.field16.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick25.Field.ToString() + " " + CanMoveBrick(16, Settings.brick25, brickList));
            }
            if (fieldnr == 17)
            {
                brickList = Settings.field17.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick25.Field.ToString() + " " + CanMoveBrick(17, Settings.brick25, brickList));
            }
            if (fieldnr == 18)
            {
                brickList = Settings.field18.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick25.Field.ToString() + " " + CanMoveBrick(18, Settings.brick25, brickList));
            }
            if (fieldnr == 19)
            {
                brickList = Settings.field19.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick25.Field.ToString() + " " + CanMoveBrick(19, Settings.brick25, brickList));
            }
            if (fieldnr == 20)
            {
                brickList = Settings.field20.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick25.Field.ToString() + " " + CanMoveBrick(20, Settings.brick25, brickList));
            }
            if (fieldnr == 21)
            {
                brickList = Settings.field21.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick25.Field.ToString() + " " + CanMoveBrick(21, Settings.brick25, brickList));
            }
            if (fieldnr == 22)
            {
                brickList = Settings.field22.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick25.Field.ToString() + " " + CanMoveBrick(22, Settings.brick25, brickList));
            }
            if (fieldnr == 23)
            {
                brickList = Settings.field23.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick25.Field.ToString() + " " + CanMoveBrick(23, Settings.brick25, brickList));
            }
            if (fieldnr == 24)
            {
                brickList = Settings.field24.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick25.Field.ToString() + " " + CanMoveBrick(24, Settings.brick25, brickList));
            }
            if (fieldnr == 25)
            {
                brickList = Settings.field25.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick25.Field.ToString() + " " + CanMoveBrick(24, Settings.brick25, brickList));
            }
            if (fieldnr == 26)
            {
                brickList = Settings.field26.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick25.Field.ToString() + " " + CanMoveBrick(26, Settings.brick25, brickList));
            }
            if (fieldnr == 27)
            {
                brickList = Settings.field27.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick25.Field.ToString() + " " + CanMoveBrick(27, Settings.brick25, brickList));
            }
        }

        private void pictureBoxBlack_11_Click(object sender, EventArgs e)
        {

            int fieldnr = Settings.brick26.Field;
            if (fieldnr == 0)
            {
                brickList = Settings.field0.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick26.Field.ToString() + " " + CanMoveBrick(0, Settings.brick26, brickList));
            }
            if (fieldnr == 1)
            {
                brickList = Settings.field1.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick26.Field.ToString() + " " + CanMoveBrick(1, Settings.brick26, brickList));
            }
            if (fieldnr == 2)
            {
                brickList = Settings.field2.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick26.Field.ToString() + " " + CanMoveBrick(2, Settings.brick26, brickList));
            }
            if (fieldnr == 3)
            {
                brickList = Settings.field3.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick26.Field.ToString() + " " + CanMoveBrick(3, Settings.brick26, brickList));
            }
            if (fieldnr == 4)
            {
                brickList = Settings.field4.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick26.Field.ToString() + " " + CanMoveBrick(4, Settings.brick26, brickList));
            }
            if (fieldnr == 5)
            {
                brickList = Settings.field5.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick26.Field.ToString() + " " + CanMoveBrick(5, Settings.brick26, brickList));
            }
            if (fieldnr == 6)
            {
                brickList = Settings.field6.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick26.Field.ToString() + " " + CanMoveBrick(6, Settings.brick26, brickList));
            }
            if (fieldnr == 7)
            {
                brickList = Settings.field7.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick26.Field.ToString() + " " + CanMoveBrick(7, Settings.brick26, brickList));
            }
            if (fieldnr == 8)
            {
                brickList = Settings.field8.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick26.Field.ToString() + " " + CanMoveBrick(8, Settings.brick26, brickList));
            }
            if (fieldnr == 9)
            {
                brickList = Settings.field9.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick26.Field.ToString() + " " + CanMoveBrick(9, Settings.brick26, brickList));
            }
            if (fieldnr == 10)
            {
                brickList = Settings.field10.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick26.Field.ToString() + " " + CanMoveBrick(10, Settings.brick26, brickList));
            }
            if (fieldnr == 11)
            {
                brickList = Settings.field11.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick26.Field.ToString() + " " + CanMoveBrick(11, Settings.brick26, brickList));
            }
            if (fieldnr == 12)
            {
                brickList = Settings.field12.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick26.Field.ToString() + " " + CanMoveBrick(12, Settings.brick26, brickList));
            }
            if (fieldnr == 13)
            {
                brickList = Settings.field13.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick26.Field.ToString() + " " + CanMoveBrick(13, Settings.brick26, brickList));
            }
            if (fieldnr == 14)
            {
                brickList = Settings.field14.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick26.Field.ToString() + " " + CanMoveBrick(14, Settings.brick26, brickList));
            }
            if (fieldnr == 15)
            {
                brickList = Settings.field15.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick26.Field.ToString() + " " + CanMoveBrick(15, Settings.brick26, brickList));
            }
            if (fieldnr == 16)
            {
                brickList = Settings.field16.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick26.Field.ToString() + " " + CanMoveBrick(16, Settings.brick26, brickList));
            }
            if (fieldnr == 17)
            {
                brickList = Settings.field17.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick26.Field.ToString() + " " + CanMoveBrick(17, Settings.brick26, brickList));
            }
            if (fieldnr == 18)
            {
                brickList = Settings.field18.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick26.Field.ToString() + " " + CanMoveBrick(18, Settings.brick26, brickList));
            }
            if (fieldnr == 19)
            {
                brickList = Settings.field19.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick26.Field.ToString() + " " + CanMoveBrick(19, Settings.brick26, brickList));
            }
            if (fieldnr == 20)
            {
                brickList = Settings.field20.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick26.Field.ToString() + " " + CanMoveBrick(20, Settings.brick26, brickList));
            }
            if (fieldnr == 21)
            {
                brickList = Settings.field21.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick26.Field.ToString() + " " + CanMoveBrick(21, Settings.brick26, brickList));
            }
            if (fieldnr == 22)
            {
                brickList = Settings.field22.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick26.Field.ToString() + " " + CanMoveBrick(22, Settings.brick26, brickList));
            }
            if (fieldnr == 23)
            {
                brickList = Settings.field23.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick26.Field.ToString() + " " + CanMoveBrick(23, Settings.brick26, brickList));
            }
            if (fieldnr == 24)
            {
                brickList = Settings.field24.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick26.Field.ToString() + " " + CanMoveBrick(24, Settings.brick26, brickList));
            }
            if (fieldnr == 25)
            {
                brickList = Settings.field25.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick26.Field.ToString() + " " + CanMoveBrick(25, Settings.brick26, brickList));
            }
            if (fieldnr == 26)
            {
                brickList = Settings.field26.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick26.Field.ToString() + " " + CanMoveBrick(26, Settings.brick26, brickList));
            }
            if (fieldnr == 27)
            {
                brickList = Settings.field27.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick26.Field.ToString() + " " + CanMoveBrick(27, Settings.brick26, brickList));
            }
        }

        private void pictureBoxBlack_12_Click(object sender, EventArgs e)
        {

            int fieldnr = Settings.brick27.Field;
            if (fieldnr == 0)
            {
                brickList = Settings.field0.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick27.Field.ToString() + " " + CanMoveBrick(0, Settings.brick27, brickList));
            }
            if (fieldnr == 1)
            {
                brickList = Settings.field1.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick27.Field.ToString() + " " + CanMoveBrick(1, Settings.brick27, brickList));
            }
            if (fieldnr == 2)
            {
                brickList = Settings.field2.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick27.Field.ToString() + " " + CanMoveBrick(2, Settings.brick27, brickList));
            }
            if (fieldnr == 3)
            {
                brickList = Settings.field3.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick27.Field.ToString() + " " + CanMoveBrick(3, Settings.brick27, brickList));
            }
            if (fieldnr == 4)
            {
                brickList = Settings.field4.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick27.Field.ToString() + " " + CanMoveBrick(4, Settings.brick27, brickList));
            }
            if (fieldnr == 5)
            {
                brickList = Settings.field5.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick27.Field.ToString() + " " + CanMoveBrick(5, Settings.brick27, brickList));
            }
            if (fieldnr == 6)
            {
                brickList = Settings.field6.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick27.Field.ToString() + " " + CanMoveBrick(6, Settings.brick27, brickList));
            }
            if (fieldnr == 7)
            {
                brickList = Settings.field7.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick27.Field.ToString() + " " + CanMoveBrick(7, Settings.brick27, brickList));
            }
            if (fieldnr == 8)
            {
                brickList = Settings.field8.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick27.Field.ToString() + " " + CanMoveBrick(8, Settings.brick27, brickList));
            }
            if (fieldnr == 9)
            {
                brickList = Settings.field9.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick27.Field.ToString() + " " + CanMoveBrick(9, Settings.brick27, brickList));
            }
            if (fieldnr == 10)
            {
                brickList = Settings.field10.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick27.Field.ToString() + " " + CanMoveBrick(10, Settings.brick27, brickList));
            }
            if (fieldnr == 11)
            {
                brickList = Settings.field11.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick27.Field.ToString() + " " + CanMoveBrick(11, Settings.brick27, brickList));
            }
            if (fieldnr == 12)
            {
                brickList = Settings.field12.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick27.Field.ToString() + " " + CanMoveBrick(12, Settings.brick27, brickList));
            }
            if (fieldnr == 13)
            {
                brickList = Settings.field13.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick27.Field.ToString() + " " + CanMoveBrick(13, Settings.brick27, brickList));
            }
            if (fieldnr == 14)
            {
                brickList = Settings.field14.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick27.Field.ToString() + " " + CanMoveBrick(14, Settings.brick27, brickList));
            }
            if (fieldnr == 15)
            {
                brickList = Settings.field15.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick27.Field.ToString() + " " + CanMoveBrick(15, Settings.brick27, brickList));
            }
            if (fieldnr == 16)
            {
                brickList = Settings.field16.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick27.Field.ToString() + " " + CanMoveBrick(16, Settings.brick27, brickList));
            }
            if (fieldnr == 17)
            {
                brickList = Settings.field17.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick27.Field.ToString() + " " + CanMoveBrick(17, Settings.brick27, brickList));
            }
            if (fieldnr == 18)
            {
                brickList = Settings.field18.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick27.Field.ToString() + " " + CanMoveBrick(18, Settings.brick27, brickList));
            }
            if (fieldnr == 19)
            {
                brickList = Settings.field19.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick27.Field.ToString() + " " + CanMoveBrick(19, Settings.brick27, brickList));
            }
            if (fieldnr == 20)
            {
                brickList = Settings.field20.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick27.Field.ToString() + " " + CanMoveBrick(20, Settings.brick27, brickList));
            }
            if (fieldnr == 21)
            {
                brickList = Settings.field21.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick27.Field.ToString() + " " + CanMoveBrick(21, Settings.brick27, brickList));
            }
            if (fieldnr == 22)
            {
                brickList = Settings.field22.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick27.Field.ToString() + " " + CanMoveBrick(22, Settings.brick27, brickList));
            }
            if (fieldnr == 23)
            {
                brickList = Settings.field23.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick27.Field.ToString() + " " + CanMoveBrick(23, Settings.brick27, brickList));
            }
            if (fieldnr == 24)
            {
                brickList = Settings.field24.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick27.Field.ToString() + " " + CanMoveBrick(24, Settings.brick27, brickList));
            }
            if (fieldnr == 25)
            {
                brickList = Settings.field25.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick27.Field.ToString() + " " + CanMoveBrick(25, Settings.brick27, brickList));
            }
            if (fieldnr == 26)
            {
                brickList = Settings.field26.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick27.Field.ToString() + " " + CanMoveBrick(26, Settings.brick27, brickList));
            }
            if (fieldnr == 27)
            {
                brickList = Settings.field27.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick27.Field.ToString() + " " + CanMoveBrick(27, Settings.brick27, brickList));
            }
        }

        private void pictureBoxBlack_13_Click(object sender, EventArgs e)
        {

            int fieldnr = Settings.brick28.Field;
            if (fieldnr == 0)
            {
                brickList = Settings.field0.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick28.Field.ToString() + " " + CanMoveBrick(0, Settings.brick28, brickList));
            }
            if (fieldnr == 1)
            {
                brickList = Settings.field1.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick28.Field.ToString() + " " + CanMoveBrick(1, Settings.brick28, brickList));
            }
            if (fieldnr == 2)
            {
                brickList = Settings.field2.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick28.Field.ToString() + " " + CanMoveBrick(2, Settings.brick28, brickList));
            }
            if (fieldnr == 3)
            {
                brickList = Settings.field3.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick28.Field.ToString() + " " + CanMoveBrick(3, Settings.brick28, brickList));
            }
            if (fieldnr == 4)
            {
                brickList = Settings.field4.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick28.Field.ToString() + " " + CanMoveBrick(4, Settings.brick28, brickList));
            }
            if (fieldnr == 5)
            {
                brickList = Settings.field5.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick28.Field.ToString() + " " + CanMoveBrick(5, Settings.brick28, brickList));
            }
            if (fieldnr == 6)
            {
                brickList = Settings.field6.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick28.Field.ToString() + " " + CanMoveBrick(6, Settings.brick28, brickList));
            }
            if (fieldnr == 7)
            {
                brickList = Settings.field7.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick28.Field.ToString() + " " + CanMoveBrick(7, Settings.brick28, brickList));
            }
            if (fieldnr == 8)
            {
                brickList = Settings.field8.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick28.Field.ToString() + " " + CanMoveBrick(8, Settings.brick28, brickList));
            }
            if (fieldnr == 9)
            {
                brickList = Settings.field9.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick28.Field.ToString() + " " + CanMoveBrick(9, Settings.brick28, brickList));
            }
            if (fieldnr == 10)
            {
                brickList = Settings.field10.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick28.Field.ToString() + " " + CanMoveBrick(10, Settings.brick28, brickList));
            }
            if (fieldnr == 11)
            {
                brickList = Settings.field11.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick28.Field.ToString() + " " + CanMoveBrick(11, Settings.brick28, brickList));
            }
            if (fieldnr == 12)
            {
                brickList = Settings.field12.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick28.Field.ToString() + " " + CanMoveBrick(12, Settings.brick28, brickList));
            }
            if (fieldnr == 13)
            {
                brickList = Settings.field13.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick28.Field.ToString() + " " + CanMoveBrick(13, Settings.brick28, brickList));
            }
            if (fieldnr == 14)
            {
                brickList = Settings.field14.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick28.Field.ToString() + " " + CanMoveBrick(14, Settings.brick28, brickList));
            }
            if (fieldnr == 15)
            {
                brickList = Settings.field15.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick28.Field.ToString() + " " + CanMoveBrick(15, Settings.brick28, brickList));
            }
            if (fieldnr == 16)
            {
                brickList = Settings.field16.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick28.Field.ToString() + " " + CanMoveBrick(16, Settings.brick28, brickList));
            }
            if (fieldnr == 17)
            {
                brickList = Settings.field17.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick28.Field.ToString() + " " + CanMoveBrick(17, Settings.brick28, brickList));
            }
            if (fieldnr == 18)
            {
                brickList = Settings.field18.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick28.Field.ToString() + " " + CanMoveBrick(18, Settings.brick28, brickList));
            }
            if (fieldnr == 19)
            {
                brickList = Settings.field19.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick28.Field.ToString() + " " + CanMoveBrick(19, Settings.brick28, brickList));
            }
            if (fieldnr == 20)
            {
                brickList = Settings.field20.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick28.Field.ToString() + " " + CanMoveBrick(20, Settings.brick28, brickList));
            }
            if (fieldnr == 21)
            {
                brickList = Settings.field21.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick28.Field.ToString() + " " + CanMoveBrick(21, Settings.brick28, brickList));
            }
            if (fieldnr == 22)
            {
                brickList = Settings.field22.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick28.Field.ToString() + " " + CanMoveBrick(22, Settings.brick28, brickList));
            }
            if (fieldnr == 23)
            {
                brickList = Settings.field23.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick28.Field.ToString() + " " + CanMoveBrick(23, Settings.brick28, brickList));
            }
            if (fieldnr == 24)
            {
                brickList = Settings.field24.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick28.Field.ToString() + " " + CanMoveBrick(24, Settings.brick28, brickList));
            }
            if (fieldnr == 25)
            {
                brickList = Settings.field25.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick28.Field.ToString() + " " + CanMoveBrick(25, Settings.brick28, brickList));
            }
            if (fieldnr == 26)
            {
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick28.Field.ToString() + " " + CanMoveBrick(26, Settings.brick28, brickList));
            }
            if (fieldnr == 27)
            {
                brickList = Settings.field27.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick28.Field.ToString() + " " + CanMoveBrick(27, Settings.brick28, brickList));
            }
        }

        private void pictureBoxBlack_14_Click(object sender, EventArgs e)
        {

            int fieldnr = Settings.brick29.Field;
            if (fieldnr == 0)
            {
                brickList = Settings.field0.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick29.Field.ToString() + " " + CanMoveBrick(0, Settings.brick29, brickList));
            }
            if (fieldnr == 1)
            {
                brickList = Settings.field1.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick29.Field.ToString() + " " + CanMoveBrick(1, Settings.brick29, brickList));
            }
            if (fieldnr == 2)
            {
                brickList = Settings.field2.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick29.Field.ToString() + " " + CanMoveBrick(2, Settings.brick29, brickList));
            }
            if (fieldnr == 3)
            {
                brickList = Settings.field3.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick29.Field.ToString() + " " + CanMoveBrick(3, Settings.brick29, brickList));
            }
            if (fieldnr == 4)
            {
                brickList = Settings.field4.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick29.Field.ToString() + " " + CanMoveBrick(4, Settings.brick29, brickList));
            }
            if (fieldnr == 5)
            {
                brickList = Settings.field5.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick29.Field.ToString() + " " + CanMoveBrick(5, Settings.brick29, brickList));
            }
            if (fieldnr == 6)
            {
                brickList = Settings.field6.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick29.Field.ToString() + " " + CanMoveBrick(6, Settings.brick29, brickList));
            }
            if (fieldnr == 7)
            {
                brickList = Settings.field7.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick29.Field.ToString() + " " + CanMoveBrick(7, Settings.brick29, brickList));
            }
            if (fieldnr == 8)
            {
                brickList = Settings.field8.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick29.Field.ToString() + " " + CanMoveBrick(8, Settings.brick29, brickList));
            }
            if (fieldnr == 9)
            {
                brickList = Settings.field9.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick29.Field.ToString() + " " + CanMoveBrick(9, Settings.brick29, brickList));
            }
            if (fieldnr == 10)
            {
                brickList = Settings.field10.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick29.Field.ToString() + " " + CanMoveBrick(10, Settings.brick29, brickList));
            }
            if (fieldnr == 11)
            {
                brickList = Settings.field11.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick29.Field.ToString() + " " + CanMoveBrick(11, Settings.brick29, brickList));
            }
            if (fieldnr == 12)
            {
                brickList = Settings.field12.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick29.Field.ToString() + " " + CanMoveBrick(12, Settings.brick29, brickList));
            }
            if (fieldnr == 13)
            {
                brickList = Settings.field13.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick29.Field.ToString() + " " + CanMoveBrick(13, Settings.brick29, brickList));
            }
            if (fieldnr == 14)
            {
                brickList = Settings.field14.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick29.Field.ToString() + " " + CanMoveBrick(14, Settings.brick29, brickList));
            }
            if (fieldnr == 15)
            {
                brickList = Settings.field15.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick29.Field.ToString() + " " + CanMoveBrick(15, Settings.brick29, brickList));
            }
            if (fieldnr == 16)
            {
                brickList = Settings.field16.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick29.Field.ToString() + " " + CanMoveBrick(16, Settings.brick29, brickList));
            }
            if (fieldnr == 17)
            {
                brickList = Settings.field17.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick29.Field.ToString() + " " + CanMoveBrick(17, Settings.brick29, brickList));
            }
            if (fieldnr == 18)
            {
                brickList = Settings.field18.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick29.Field.ToString() + " " + CanMoveBrick(18, Settings.brick29, brickList));
            }
            if (fieldnr == 19)
            {
                brickList = Settings.field19.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick29.Field.ToString() + " " + CanMoveBrick(19, Settings.brick29, brickList));
            }
            if (fieldnr == 20)
            {
                brickList = Settings.field20.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick29.Field.ToString() + " " + CanMoveBrick(20, Settings.brick29, brickList));
            }
            if (fieldnr == 21)
            {
                brickList = Settings.field21.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick29.Field.ToString() + " " + CanMoveBrick(21, Settings.brick29, brickList));
            }
            if (fieldnr == 22)
            {
                brickList = Settings.field22.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick29.Field.ToString() + " " + CanMoveBrick(22, Settings.brick29, brickList));
            }
            if (fieldnr == 23)
            {
                brickList = Settings.field23.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick29.Field.ToString() + " " + CanMoveBrick(23, Settings.brick29, brickList));
            }
            if (fieldnr == 24)
            {
                brickList = Settings.field24.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick29.Field.ToString() + " " + CanMoveBrick(24, Settings.brick29, brickList));
            }
            if (fieldnr == 25)
            {
                brickList = Settings.field25.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick29.Field.ToString() + " " + CanMoveBrick(25, Settings.brick29, brickList));
            }
            if (fieldnr == 26)
            {
                brickList = Settings.field26.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick29.Field.ToString() + " " + CanMoveBrick(26, Settings.brick29, brickList));
            }
            if (fieldnr == 27)
            {
                brickList = Settings.field27.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick29.Field.ToString() + " " + CanMoveBrick(27, Settings.brick29, brickList));
            }
        }

        private void pictureBoxBlack_15_Click(object sender, EventArgs e)
        {

            int fieldnr = Settings.brick30.Field;
            if (fieldnr == 0)
            {
                brickList = Settings.field0.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick30.Field.ToString() + " " + CanMoveBrick(0, Settings.brick30, brickList));
            }
            if (fieldnr == 1)
            {
                brickList = Settings.field1.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick30.Field.ToString() + " " + CanMoveBrick(1, Settings.brick30, brickList));
            }
            if (fieldnr == 2)
            {
                brickList = Settings.field2.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick30.Field.ToString() + " " + CanMoveBrick(2, Settings.brick30, brickList));
            }
            if (fieldnr == 3)
            {
                brickList = Settings.field3.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick30.Field.ToString() + " " + CanMoveBrick(3, Settings.brick30, brickList));
            }
            if (fieldnr == 4)
            {
                brickList = Settings.field4.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick30.Field.ToString() + " " + CanMoveBrick(4, Settings.brick30, brickList));
            }
            if (fieldnr == 5)
            {
                brickList = Settings.field5.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick30.Field.ToString() + " " + CanMoveBrick(5, Settings.brick30, brickList));
            }
            if (fieldnr == 6)
            {
                brickList = Settings.field6.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick30.Field.ToString() + " " + CanMoveBrick(6, Settings.brick30, brickList));
            }
            if (fieldnr == 7)
            {
                brickList = Settings.field7.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick30.Field.ToString() + " " + CanMoveBrick(7, Settings.brick30, brickList));
            }
            if (fieldnr == 8)
            {
                brickList = Settings.field8.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick30.Field.ToString() + " " + CanMoveBrick(8, Settings.brick30, brickList));
            }
            if (fieldnr == 9)
            {
                brickList = Settings.field9.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick30.Field.ToString() + " " + CanMoveBrick(9, Settings.brick30, brickList));
            }
            if (fieldnr == 10)
            {
                brickList = Settings.field10.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick30.Field.ToString() + " " + CanMoveBrick(10, Settings.brick30, brickList));
            }
            if (fieldnr == 11)
            {
                brickList = Settings.field11.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick30.Field.ToString() + " " + CanMoveBrick(11, Settings.brick30, brickList));
            }
            if (fieldnr == 12)
            {
                brickList = Settings.field12.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick30.Field.ToString() + " " + CanMoveBrick(12, Settings.brick30, brickList));
            }
            if (fieldnr == 13)
            {
                brickList = Settings.field13.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick30.Field.ToString() + " " + CanMoveBrick(13, Settings.brick30, brickList));
            }
            if (fieldnr == 14)
            {
                brickList = Settings.field14.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick30.Field.ToString() + " " + CanMoveBrick(14, Settings.brick30, brickList));
            }
            if (fieldnr == 15)
            {
                brickList = Settings.field15.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick30.Field.ToString() + " " + CanMoveBrick(15, Settings.brick30, brickList));
            }
            if (fieldnr == 16)
            {
                brickList = Settings.field16.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick30.Field.ToString() + " " + CanMoveBrick(16, Settings.brick30, brickList));
            }
            if (fieldnr == 17)
            {
                brickList = Settings.field17.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick30.Field.ToString() + " " + CanMoveBrick(17, Settings.brick30, brickList));
            }
            if (fieldnr == 18)
            {
                brickList = Settings.field18.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick30.Field.ToString() + " " + CanMoveBrick(18, Settings.brick30, brickList));
            }
            if (fieldnr == 19)
            {
                brickList = Settings.field19.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick30.Field.ToString() + " " + CanMoveBrick(19, Settings.brick30, brickList));
            }
            if (fieldnr == 20)
            {
                brickList = Settings.field20.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick30.Field.ToString() + " " + CanMoveBrick(20, Settings.brick30, brickList));
            }
            if (fieldnr == 21)
            {
                brickList = Settings.field21.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick30.Field.ToString() + " " + CanMoveBrick(21, Settings.brick30, brickList));
            }
            if (fieldnr == 22)
            {
                brickList = Settings.field22.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick30.Field.ToString() + " " + CanMoveBrick(22, Settings.brick30, brickList));
            }
            if (fieldnr == 23)
            {
                brickList = Settings.field23.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick30.Field.ToString() + " " + CanMoveBrick(23, Settings.brick30, brickList));
            }
            if (fieldnr == 24)
            {
                brickList = Settings.field24.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick30.Field.ToString() + " " + CanMoveBrick(24, Settings.brick30, brickList));
            }
            if (fieldnr == 25)
            {
                brickList = Settings.field25.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick30.Field.ToString() + " " + CanMoveBrick(25, Settings.brick30, brickList));
            }
            if (fieldnr == 26)
            {
                brickList = Settings.field26.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick30.Field.ToString() + " " + CanMoveBrick(26, Settings.brick30, brickList));
            }
            if (fieldnr == 27)
            {
                brickList = Settings.field27.GetListBricks();
                MessageBox.Show(brickList.Count.ToString() + " " + Settings.brick30.Field.ToString() + " " + CanMoveBrick(27, Settings.brick30, brickList));
            }
        }
    }
}

                
using System.Drawing.Text;
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





        private void pictureBoxWhite_1_Click(object sender, EventArgs e)
        {
          
            int fieldknr = Settings.brick1.Field;
            if (fieldknr == 0)
            {
                brickList = Settings.field0.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick1.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 1)
            {
                 brickList = Settings.field1.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick1.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 2)
            {
                brickList = Settings.field2.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick1.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 3)
            {
                brickList = Settings.field3.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick1.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 4)
            {
                brickList = Settings.field4.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick1.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 5)
            {
                brickList = Settings.field5.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick1.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 6)
            {
                brickList = Settings.field6.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick1.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 7)
            {
                brickList = Settings.field7.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick1.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 8)
            {
                brickList = Settings.field8.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick1.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 9)
            {
                brickList = Settings.field9.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick1.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 10)
            {
                brickList = Settings.field10.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick1.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 11)
            {
                brickList = Settings.field11.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick1.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 12)
            {
                brickList = Settings.field12.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick1.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 13)
            {
                brickList = Settings.field13.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick1.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 14)
            {
                brickList = Settings.field14.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick1.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 15)
            {
                brickList = Settings.field15.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick1.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 16)
            {
                brickList = Settings.field16.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick1.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 17)
            {
                brickList = Settings.field17.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick1.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 18)
            {
                brickList = Settings.field18.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick1.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 19)
            {
                brickList = Settings.field19.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick1.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 20)
            {
                brickList = Settings.field20.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick1.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 21)
            {
                brickList = Settings.field21.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick1.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 22)
            {
                brickList = Settings.field22.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick1.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 23)
            {
                brickList = Settings.field23.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick1.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 24)
            {
                brickList = Settings.field24.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick1.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 25)
            {
                brickList = Settings.field25.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick1.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 26)
            {
                brickList = Settings.field26.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick1.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 27)
            {
                brickList = Settings.field27.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick1.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
           
            

        }
        private void pictureBoxWhite_2_Click(object sender, EventArgs e)
        {
            int fieldknr = Settings.brick2.Field;
            if (fieldknr == 0)
            {
                brickList = Settings.field0.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick1.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 1)
            {
                List<Bricks> brickList = Settings.field1.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick2.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 2)
            {
                brickList = Settings.field2.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick2.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 3)
            {
                brickList = Settings.field3.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick2.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 4)
            {
                brickList = Settings.field4.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick2.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 5)
            {
                brickList = Settings.field5.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick2.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 6)
            {
                brickList = Settings.field6.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick2.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 7)
            {
                brickList = Settings.field7.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick2.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 8)
            {
                brickList = Settings.field8.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick2.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 9)
            {
                brickList = Settings.field9.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick2.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 10)
            {
                brickList = Settings.field10.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick2.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 11)
            {
                brickList = Settings.field11.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick2.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 12)
            {
                brickList = Settings.field12.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick2.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 13)
            {
                brickList = Settings.field13.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick2.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 14)
            {
                brickList = Settings.field14.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick2.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 15)
            {
                brickList = Settings.field15.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick2.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 16)
            {
                brickList = Settings.field16.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick2.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 17)
            {
                brickList = Settings.field17.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick2.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 18)
            {
                brickList = Settings.field18.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick2.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 19)
            {
                brickList = Settings.field19.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick2.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 20)
            {
                brickList = Settings.field20.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick2.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 21)
            {
                brickList = Settings.field21.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick2.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 22)
            {
                brickList = Settings.field22.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick2.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 23)
            {
                brickList = Settings.field23.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick2.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 24)
            {
                brickList = Settings.field24.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick2.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 25)
            {
                brickList = Settings.field25.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick2.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 26)
            {
                brickList = Settings.field26.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick2.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 27)
            {
                brickList = Settings.field27.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick2.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }

        }






        private void pictureBoxWhite_3_Click(object sender, EventArgs e)
        {

            int fieldknr = Settings.brick1.Field;
            if (fieldknr == 0)
            {
                brickList = Settings.field0.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick3.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 1)
            {
                brickList = Settings.field1.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick3.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 2)
            {
                brickList = Settings.field2.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick3.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 3)
            {
                brickList = Settings.field3.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick3.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 4)
            {
                brickList = Settings.field4.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick3.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 5)
            {
                brickList = Settings.field5.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick3.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 6)
            {
                brickList = Settings.field6.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick3.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 7)
            {
                brickList = Settings.field7.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick3.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 8)
            {
                brickList = Settings.field8.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick3.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 9)
            {
                brickList = Settings.field9.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick3.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 10)
            {
                brickList = Settings.field10.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick3.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 11)
            {
                brickList = Settings.field11.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick3.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 12)
            {
                brickList = Settings.field12.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick3.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 13)
            {
                brickList = Settings.field13.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick3.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 14)
            {
                brickList = Settings.field14.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick3.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 15)
            {
                brickList = Settings.field15.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick3.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 16)
            {
                brickList = Settings.field16.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick3.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 17)
            {
                brickList = Settings.field17.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick3.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 18)
            {
                brickList = Settings.field18.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick3.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 19)
            {
                brickList = Settings.field19.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick3.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 20)
            {
                brickList = Settings.field20.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick3.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 21)
            {
                brickList = Settings.field21.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick3.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 22)
            {
                brickList = Settings.field22.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick3.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 23)
            {
                brickList = Settings.field23.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick3.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 24)
            {
                brickList = Settings.field24.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick3.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 25)
            {
                brickList = Settings.field25.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick3.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 26)
            {
                brickList = Settings.field26.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick3.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 27)
            {
                brickList = Settings.field27.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick3.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }



        }

        private void pictureBoxWhite_4_Click(object sender, EventArgs e)
        {

            int fieldknr = Settings.brick1.Field;
            if (fieldknr == 0)
            {
                brickList = Settings.field0.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick4.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 1)
            {
                brickList = Settings.field1.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick4.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 2)
            {
                brickList = Settings.field2.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick4.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 3)
            {
                brickList = Settings.field3.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick4.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 4)
            {
                brickList = Settings.field4.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick4.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 5)
            {
                brickList = Settings.field5.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick4.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 6)
            {
                brickList = Settings.field6.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick4.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 7)
            {
                brickList = Settings.field7.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick4.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 8)
            {
                brickList = Settings.field8.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick4.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 9)
            {
                brickList = Settings.field9.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick4.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 10)
            {
                brickList = Settings.field10.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick4.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 11)
            {
                brickList = Settings.field11.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick4.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 12)
            {
                brickList = Settings.field12.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick4.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 13)
            {
                brickList = Settings.field13.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick4.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 14)
            {
                brickList = Settings.field14.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick4.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 15)
            {
                brickList = Settings.field15.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick4.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 16)
            {
                brickList = Settings.field16.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick4.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 17)
            {
                brickList = Settings.field17.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick4.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 18)
            {
                brickList = Settings.field18.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick4.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 19)
            {
                brickList = Settings.field19.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick4.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 20)
            {
                brickList = Settings.field20.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick4.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 21)
            {
                brickList = Settings.field21.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick4.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 22)
            {
                brickList = Settings.field22.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick4.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 23)
            {
                brickList = Settings.field23.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick4.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 24)
            {
                brickList = Settings.field24.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick4.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 25)
            {
                brickList = Settings.field25.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick4.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 26)
            {
                brickList = Settings.field26.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick4.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 27)
            {
                brickList = Settings.field27.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick4.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }



        }

        private void pictureBoxWhite_5_Click(object sender, EventArgs e)
        {

            int fieldknr = Settings.brick1.Field;
            if (fieldknr == 0)
            {
                brickList = Settings.field0.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick5.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 1)
            {
                brickList = Settings.field1.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick5.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 2)
            {
                brickList = Settings.field2.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick5.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 3)
            {
                brickList = Settings.field3.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick5.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 4)
            {
                brickList = Settings.field4.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick5.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 5)
            {
                brickList = Settings.field5.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick5.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 6)
            {
                brickList = Settings.field6.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick5.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 7)
            {
                brickList = Settings.field7.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick5.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 8)
            {
                brickList = Settings.field8.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick5.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 9)
            {
                brickList = Settings.field9.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick5.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 10)
            {
                brickList = Settings.field10.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick5.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 11)
            {
                brickList = Settings.field11.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick5.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 12)
            {
                brickList = Settings.field12.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick5.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 13)
            {
                brickList = Settings.field13.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick5.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 14)
            {
                brickList = Settings.field14.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick5.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 15)
            {
                brickList = Settings.field15.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick5.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 16)
            {
                brickList = Settings.field16.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick5.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 17)
            {
                brickList = Settings.field17.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick5.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 18)
            {
                brickList = Settings.field18.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick5.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 19)
            {
                brickList = Settings.field19.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick5.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 20)
            {
                brickList = Settings.field20.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick5.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 21)
            {
                brickList = Settings.field21.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick5.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 22)
            {
                brickList = Settings.field22.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick5.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 23)
            {
                brickList = Settings.field23.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick5.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 24)
            {
                brickList = Settings.field24.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick5.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 25)
            {
                brickList = Settings.field25.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick5.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 26)
            {
                brickList = Settings.field26.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick5.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 27)
            {
                brickList = Settings.field27.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick5.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }



        }

        private void pictureBoxWhite_6_Click(object sender, EventArgs e)
        {

            int fieldknr = Settings.brick1.Field;
            if (fieldknr == 0)
            {
                brickList = Settings.field0.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick6.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 1)
            {
                brickList = Settings.field1.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick6.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 2)
            {
                brickList = Settings.field2.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick6.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 3)
            {
                brickList = Settings.field3.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick6.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 4)
            {
                brickList = Settings.field4.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick6.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 5)
            {
                brickList = Settings.field5.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick6.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 6)
            {
                brickList = Settings.field6.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick6.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 7)
            {
                brickList = Settings.field7.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick6.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 8)
            {
                brickList = Settings.field8.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick6.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 9)
            {
                brickList = Settings.field9.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick6.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 10)
            {
                brickList = Settings.field10.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick6.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 11)
            {
                brickList = Settings.field11.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick6.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 12)
            {
                brickList = Settings.field12.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick6.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 13)
            {
                brickList = Settings.field13.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick6.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 14)
            {
                brickList = Settings.field14.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick6.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 15)
            {
                brickList = Settings.field15.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick6.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 16)
            {
                brickList = Settings.field16.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick6.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 17)
            {
                brickList = Settings.field17.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick6.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 18)
            {
                brickList = Settings.field18.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick6.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 19)
            {
                brickList = Settings.field19.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick6.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 20)
            {
                brickList = Settings.field20.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick6.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 21)
            {
                brickList = Settings.field21.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick6.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 22)
            {
                brickList = Settings.field22.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick6.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 23)
            {
                brickList = Settings.field23.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick6.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 24)
            {
                brickList = Settings.field24.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick6.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 25)
            {
                brickList = Settings.field25.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick6.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 26)
            {
                brickList = Settings.field26.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick6.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 27)
            {
                brickList = Settings.field27.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick6.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }



        }

        private void pictureBoxWhite_7_Click(object sender, EventArgs e)
        {

            int fieldknr = Settings.brick1.Field;
            if (fieldknr == 0)
            {
                brickList = Settings.field0.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick7.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 1)
            {
                brickList = Settings.field1.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick7.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 2)
            {
                brickList = Settings.field2.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick7.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 3)
            {
                brickList = Settings.field3.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick7.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 4)
            {
                brickList = Settings.field4.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick7.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 5)
            {
                brickList = Settings.field5.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick7.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 6)
            {
                brickList = Settings.field6.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick7.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 7)
            {
                brickList = Settings.field7.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick7.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 8)
            {
                brickList = Settings.field8.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick7.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 9)
            {
                brickList = Settings.field9.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick7.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 10)
            {
                brickList = Settings.field10.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick7.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 11)
            {
                brickList = Settings.field11.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick7.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 12)
            {
                brickList = Settings.field12.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick7.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 13)
            {
                brickList = Settings.field13.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick7.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 14)
            {
                brickList = Settings.field14.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick7.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 15)
            {
                brickList = Settings.field15.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick7.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 16)
            {
                brickList = Settings.field16.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick7.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 17)
            {
                brickList = Settings.field17.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick7.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 18)
            {
                brickList = Settings.field18.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick7.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 19)
            {
                brickList = Settings.field19.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick7.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 20)
            {
                brickList = Settings.field20.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick7.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 21)
            {
                brickList = Settings.field21.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick7.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 22)
            {
                brickList = Settings.field22.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick7.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 23)
            {
                brickList = Settings.field23.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick7.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 24)
            {
                brickList = Settings.field24.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick7.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 25)
            {
                brickList = Settings.field25.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick7.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 26)
            {
                brickList = Settings.field26.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick7.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 27)
            {
                brickList = Settings.field27.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick7.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }



        }

        private void pictureBoxWhite_8_Click(object sender, EventArgs e)
        {

            int fieldknr = Settings.brick1.Field;
            if (fieldknr == 0)
            {
                brickList = Settings.field0.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick8.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 1)
            {
                brickList = Settings.field1.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick8.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 2)
            {
                brickList = Settings.field2.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick8.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 3)
            {
                brickList = Settings.field3.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick8.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 4)
            {
                brickList = Settings.field4.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick8.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 5)
            {
                brickList = Settings.field5.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick8.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 6)
            {
                brickList = Settings.field6.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick8.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 7)
            {
                brickList = Settings.field7.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick8.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 8)
            {
                brickList = Settings.field8.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick8.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 9)
            {
                brickList = Settings.field9.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick8.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 10)
            {
                brickList = Settings.field10.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick8.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 11)
            {
                brickList = Settings.field11.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick8.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 12)
            {
                brickList = Settings.field12.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick8.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 13)
            {
                brickList = Settings.field13.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick8.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 14)
            {
                brickList = Settings.field14.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick8.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 15)
            {
                brickList = Settings.field15.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick8.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 16)
            {
                brickList = Settings.field16.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick8.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 17)
            {
                brickList = Settings.field17.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick8.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 18)
            {
                brickList = Settings.field18.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick8.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 19)
            {
                brickList = Settings.field19.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick8.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 20)
            {
                brickList = Settings.field20.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick8.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 21)
            {
                brickList = Settings.field21.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick8.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 22)
            {
                brickList = Settings.field22.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick8.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 23)
            {
                brickList = Settings.field23.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick8.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 24)
            {
                brickList = Settings.field24.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick8.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 25)
            {
                brickList = Settings.field25.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick8.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 26)
            {
                brickList = Settings.field26.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick8.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 27)
            {
                brickList = Settings.field27.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick8.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }



        }

        private void pictureBoxWhite_9_Click(object sender, EventArgs e)
        {

            int fieldknr = Settings.brick1.Field;
            if (fieldknr == 0)
            {
                brickList = Settings.field0.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick9.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 1)
            {
                brickList = Settings.field1.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick9.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 2)
            {
                brickList = Settings.field2.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick9.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 3)
            {
                brickList = Settings.field3.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick9.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 4)
            {
                brickList = Settings.field4.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick9.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 5)
            {
                brickList = Settings.field5.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick9.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 6)
            {
                brickList = Settings.field6.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick9.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 7)
            {
                brickList = Settings.field7.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick9.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 8)
            {
                brickList = Settings.field8.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick9.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 9)
            {
                brickList = Settings.field9.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick9.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 10)
            {
                brickList = Settings.field10.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick9.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 11)
            {
                brickList = Settings.field11.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick9.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 12)
            {
                brickList = Settings.field12.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick9.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 13)
            {
                brickList = Settings.field13.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick9.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 14)
            {
                brickList = Settings.field14.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick9.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 15)
            {
                brickList = Settings.field15.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick9.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 16)
            {
                brickList = Settings.field16.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick9.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 17)
            {
                brickList = Settings.field17.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick9.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 18)
            {
                brickList = Settings.field18.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick9.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 19)
            {
                brickList = Settings.field19.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick9.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 20)
            {
                brickList = Settings.field20.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick9.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 21)
            {
                brickList = Settings.field21.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick9.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 22)
            {
                brickList = Settings.field22.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick9.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 23)
            {
                brickList = Settings.field23.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick9.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 24)
            {
                brickList = Settings.field24.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick9.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 25)
            {
                brickList = Settings.field25.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick9.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 26)
            {
                brickList = Settings.field26.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick9.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 27)
            {
                brickList = Settings.field27.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick9.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }



        }

        private void pictureBoxWhite_10_Click(object sender, EventArgs e)
        {

            int fieldknr = Settings.brick1.Field;
            if (fieldknr == 0)
            {
                brickList = Settings.field0.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick10.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 1)
            {
                brickList = Settings.field1.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick10.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 2)
            {
                brickList = Settings.field2.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick10.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 3)
            {
                brickList = Settings.field3.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick10.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 4)
            {
                brickList = Settings.field4.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick10.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 5)
            {
                brickList = Settings.field5.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick10.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 6)
            {
                brickList = Settings.field6.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick10.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 7)
            {
                brickList = Settings.field7.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick10.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 8)
            {
                brickList = Settings.field8.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick10.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 9)
            {
                brickList = Settings.field9.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick10.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 10)
            {
                brickList = Settings.field10.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick10.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 11)
            {
                brickList = Settings.field11.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 10];
                    if (brick.BrickNr.ToString() == Settings.brick10.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 12)
            {
                brickList = Settings.field12.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick10.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 13)
            {
                brickList = Settings.field13.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick10.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 14)
            {
                brickList = Settings.field14.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick10.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 15)
            {
                brickList = Settings.field15.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick10.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 16)
            {
                brickList = Settings.field16.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick10.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 17)
            {
                brickList = Settings.field17.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick10.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 18)
            {
                brickList = Settings.field18.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick10.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 19)
            {
                brickList = Settings.field19.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick10.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 20)
            {
                brickList = Settings.field20.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick10.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 21)
            {
                brickList = Settings.field21.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick10.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 22)
            {
                brickList = Settings.field22.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick10.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 23)
            {
                brickList = Settings.field23.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick10.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 24)
            {
                brickList = Settings.field24.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick10.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 25)
            {
                brickList = Settings.field25.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick10.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 26)
            {
                brickList = Settings.field26.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick10.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
             if (fieldknr == 27)
            {
                brickList = Settings.field27.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick10.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }



        }
        private void pictureBoxWhite_11_Click(object sender, EventArgs e)
        {

            int fieldknr = Settings.brick1.Field;
            if (fieldknr == 0)
            {
                brickList = Settings.field0.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick11.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 1)
            {
                brickList = Settings.field1.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick11.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 2)
            {
                brickList = Settings.field2.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick11.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 3)
            {
                brickList = Settings.field3.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick11.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 4)
            {
                brickList = Settings.field4.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick11.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 5)
            {
                brickList = Settings.field5.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick11.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 6)
            {
                brickList = Settings.field6.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick11.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 7)
            {
                brickList = Settings.field7.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick11.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 8)
            {
                brickList = Settings.field8.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick11.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 9)
            {
                brickList = Settings.field9.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick11.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 10)
            {
                brickList = Settings.field10.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick11.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 11)
            {
                brickList = Settings.field11.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick11.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 12)
            {
                brickList = Settings.field12.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick11.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 13)
            {
                brickList = Settings.field13.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick11.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 14)
            {
                brickList = Settings.field14.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick11.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 15)
            {
                brickList = Settings.field15.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick11.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 16)
            {
                brickList = Settings.field16.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick11.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 17)
            {
                brickList = Settings.field17.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick11.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 18)
            {
                brickList = Settings.field18.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick11.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 19)
            {
                brickList = Settings.field19.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick11.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 20)
            {
                brickList = Settings.field20.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick11.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 21)
            {
                brickList = Settings.field21.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick11.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 22)
            {
                brickList = Settings.field22.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick11.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 23)
            {
                brickList = Settings.field23.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick11.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 24)
            {
                brickList = Settings.field24.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick11.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 25)
            {
                brickList = Settings.field25.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick11.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 26)
            {
                brickList = Settings.field26.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick11.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 27)
            {
                brickList = Settings.field27.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick11.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }



        }

        private void pictureBoxWhite_12_Click(object sender, EventArgs e)
        {

            int fieldknr = Settings.brick1.Field;
            if (fieldknr == 0)
            {
                brickList = Settings.field0.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick12.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 1)
            {
                brickList = Settings.field1.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick12.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 2)
            {
                brickList = Settings.field2.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick12.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 3)
            {
                brickList = Settings.field3.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick12.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 4)
            {
                brickList = Settings.field4.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick12.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 5)
            {
                brickList = Settings.field5.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick12.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 6)
            {
                brickList = Settings.field6.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick12.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 7)
            {
                brickList = Settings.field7.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick12.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 8)
            {
                brickList = Settings.field8.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick12.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 9)
            {
                brickList = Settings.field9.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick12.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 10)
            {
                brickList = Settings.field10.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick12.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 11)
            {
                brickList = Settings.field11.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick12.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 12)
            {
                brickList = Settings.field12.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick12.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 13)
            {
                brickList = Settings.field13.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick12.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 14)
            {
                brickList = Settings.field14.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick12.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 15)
            {
                brickList = Settings.field15.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick12.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 16)
            {
                brickList = Settings.field16.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick12.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 17)
            {
                brickList = Settings.field17.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick12.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 18)
            {
                brickList = Settings.field18.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick12.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 19)
            {
                brickList = Settings.field19.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick12.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 20)
            {
                brickList = Settings.field20.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick12.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 21)
            {
                brickList = Settings.field21.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick12.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 22)
            {
                brickList = Settings.field22.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick12.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 23)
            {
                brickList = Settings.field23.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick12.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 24)
            {
                brickList = Settings.field24.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick12.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 25)
            {
                brickList = Settings.field25.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick12.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
             if (fieldknr == 26)
            {
                brickList = Settings.field26.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick12.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 27)
            {
                brickList = Settings.field27.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick12.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }



        }
        private void pictureBoxWhite_13_Click(object sender, EventArgs e)
        {

            int fieldknr = Settings.brick1.Field;
            if (fieldknr == 0)
            {
                brickList = Settings.field0.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick13.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 1)
            {
                brickList = Settings.field1.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick13.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 2)
            {
                brickList = Settings.field2.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick13.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 3)
            {
                brickList = Settings.field3.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick13.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 4)
            {
                brickList = Settings.field4.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick13.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 5)
            {
                brickList = Settings.field5.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick13.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 6)
            {
                brickList = Settings.field6.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick13.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 7)
            {
                brickList = Settings.field7.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick13.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 8)
            {
                brickList = Settings.field8.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick13.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 9)
            {
                brickList = Settings.field9.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick13.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 10)
            {
                brickList = Settings.field10.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick13.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 11)
            {
                brickList = Settings.field11.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick13.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 12)
            {
                brickList = Settings.field12.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick13.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 13)
            {
                brickList = Settings.field13.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick13.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 14)
            {
                brickList = Settings.field14.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick13.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 15)
            {
                brickList = Settings.field15.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick13.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 16)
            {
                brickList = Settings.field16.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick13.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 17)
            {
                brickList = Settings.field17.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick13.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 18)
            {
                brickList = Settings.field18.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick13.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 19)
            {
                brickList = Settings.field19.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick13.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 20)
            {
                brickList = Settings.field20.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick13.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 21)
            {
                brickList = Settings.field21.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick13.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 22)
            {
                brickList = Settings.field22.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick13.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 23)
            {
                brickList = Settings.field23.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick13.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 24)
            {
                brickList = Settings.field24.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick13.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 25)
            {
                brickList = Settings.field25.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick13.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 26)
            {
                brickList = Settings.field26.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick13.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 27)
            {
                brickList = Settings.field27.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick13.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }



        }

        private void pictureBoxWhite_14_Click(object sender, EventArgs e)
        {

            int fieldknr = Settings.brick1.Field;
            if (fieldknr == 0)
            {
                brickList = Settings.field0.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick14.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 1)
            {
                brickList = Settings.field1.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick14.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 2)
            {
                brickList = Settings.field2.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick14.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 3)
            {
                brickList = Settings.field3.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick14.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 4)
            {
                brickList = Settings.field4.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick14.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 5)
            {
                brickList = Settings.field5.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick14.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 6)
            {
                brickList = Settings.field6.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick14.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 7)
            {
                brickList = Settings.field7.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick14.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 8)
            {
                brickList = Settings.field8.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick14.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 9)
            {
                brickList = Settings.field9.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick14.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 10)
            {
                brickList = Settings.field10.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick14.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 11)
            {
                brickList = Settings.field11.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick14.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 12)
            {
                brickList = Settings.field12.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick14.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 13)
            {
                brickList = Settings.field13.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick14.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 14)
            {
                brickList = Settings.field14.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick14.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 15)
            {
                brickList = Settings.field15.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick14.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 16)
            {
                brickList = Settings.field16.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick14.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 17)
            {
                brickList = Settings.field17.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick14.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 18)
            {
                brickList = Settings.field18.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick14.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 19)
            {
                brickList = Settings.field19.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick14.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 20)
            {
                brickList = Settings.field20.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick14.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 21)
            {
                brickList = Settings.field21.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick14.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 22)
            {
                brickList = Settings.field22.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick14.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 23)
            {
                brickList = Settings.field23.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick14.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 24)
            {
                brickList = Settings.field24.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick14.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 25)
            {
                brickList = Settings.field25.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick14.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 26)
            {
                brickList = Settings.field26.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick14.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 27)
            {
                brickList = Settings.field27.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick14.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }



        }

        private void pictureBoxWhite_15_Click(object sender, EventArgs e)
        {

            int fieldknr = Settings.brick1.Field;
            if (fieldknr == 0)
            {
                brickList = Settings.field0.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick15.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 1)
            {
                brickList = Settings.field1.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick15.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 2)
            {
                brickList = Settings.field2.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick15.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 3)
            {
                brickList = Settings.field3.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick15.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 4)
            {
                brickList = Settings.field4.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick15.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 5)
            {
                brickList = Settings.field5.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick15.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 6)
            {
                brickList = Settings.field6.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick15.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 7)
            {
                brickList = Settings.field7.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick15.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 8)
            {
                brickList = Settings.field8.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick15.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 9)
            {
                brickList = Settings.field9.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick15.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 10)
            {
                brickList = Settings.field10.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick15.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 11)
            {
                brickList = Settings.field11.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick15.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 12)
            {
                brickList = Settings.field12.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick15.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 13)
            {
                brickList = Settings.field13.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick15.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 14)
            {
                brickList = Settings.field14.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick15.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 15)
            {
                brickList = Settings.field15.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick15.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 16)
            {
                brickList = Settings.field16.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick15.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 17)
            {
                brickList = Settings.field17.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick15.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 18)
            {
                brickList = Settings.field18.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick15.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 19)
            {
                brickList = Settings.field19.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick15.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 20)
            {
                brickList = Settings.field20.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick15.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 21)
            {
                brickList = Settings.field21.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick15.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 22)
            {
                brickList = Settings.field22.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick15.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 23)
            {
                brickList = Settings.field23.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick15.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 24)
            {
                brickList = Settings.field24.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick15.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 25)
            {
                brickList = Settings.field25.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick15.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 26)
            {
                brickList = Settings.field26.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick15.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 27)
            {
                brickList = Settings.field27.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick15.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }



        }

        private void pictureBoxBlack_1_Click(object sender, EventArgs e)
        {

            int fieldknr = Settings.brick1.Field;
            if (fieldknr == 0)
            {
                brickList = Settings.field0.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick16.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 1)
            {
                brickList = Settings.field1.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick16.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 2)
            {
                brickList = Settings.field2.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick16.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 3)
            {
                brickList = Settings.field3.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick16.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 4)
            {
                brickList = Settings.field4.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick16.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 5)
            {
                brickList = Settings.field5.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick16.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 6)
            {
                brickList = Settings.field6.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick16.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 7)
            {
                brickList = Settings.field7.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick16.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 8)
            {
                brickList = Settings.field8.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick16.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 9)
            {
                brickList = Settings.field9.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick16.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 10)
            {
                brickList = Settings.field10.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick16.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 11)
            {
                brickList = Settings.field11.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick16.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 12)
            {
                brickList = Settings.field12.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick16.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 13)
            {
                brickList = Settings.field13.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick16.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 14)
            {
                brickList = Settings.field14.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick16.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 15)
            {
                brickList = Settings.field15.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick16.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 16)
            {
                brickList = Settings.field16.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick16.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 17)
            {
                brickList = Settings.field17.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick16.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 18)
            {
                brickList = Settings.field18.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick16.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 19)
            {
                brickList = Settings.field19.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick16.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 20)
            {
                brickList = Settings.field20.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick16.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 21)
            {
                brickList = Settings.field21.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick16.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 22)
            {
                brickList = Settings.field22.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick16.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 23)
            {
                brickList = Settings.field23.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick16.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 24)
            {
                brickList = Settings.field24.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick16.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 25)
            {
                brickList = Settings.field25.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick16.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 26)
            {
                brickList = Settings.field26.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick16.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 27)
            {
                brickList = Settings.field27.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick16.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }



        }

        private void pictureBoxBlack_2_Click(object sender, EventArgs e)
        {

            int fieldknr = Settings.brick1.Field;
            if (fieldknr == 0)
            {
                brickList = Settings.field0.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick17.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 1)
            {
                brickList = Settings.field1.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick17.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 2)
            {
                brickList = Settings.field2.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick17.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 3)
            {
                brickList = Settings.field3.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick17.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 4)
            {
                brickList = Settings.field4.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick17.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 5)
            {
                brickList = Settings.field5.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick17.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 6)
            {
                brickList = Settings.field6.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick17.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 7)
            {
                brickList = Settings.field7.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick17.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 8)
            {
                brickList = Settings.field8.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick17.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 9)
            {
                brickList = Settings.field9.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick17.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 10)
            {
                brickList = Settings.field10.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick17.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 11)
            {
                brickList = Settings.field11.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick17.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 12)
            {
                brickList = Settings.field12.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick17.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 13)
            {
                brickList = Settings.field13.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick17.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 14)
            {
                brickList = Settings.field14.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick17.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 15)
            {
                brickList = Settings.field15.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick17.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 16)
            {
                brickList = Settings.field16.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick17.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 17)
            {
                brickList = Settings.field17.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick17.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 18)
            {
                brickList = Settings.field18.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick17.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 19)
            {
                brickList = Settings.field19.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick17.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 20)
            {
                brickList = Settings.field20.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick17.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 21)
            {
                brickList = Settings.field21.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick17.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 22)
            {
                brickList = Settings.field22.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick17.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 23)
            {
                brickList = Settings.field23.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick17.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 24)
            {
                brickList = Settings.field24.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick17.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 25)
            {
                brickList = Settings.field25.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick17.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 26)
            {
                brickList = Settings.field26.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick17.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 27)
            {
                brickList = Settings.field27.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick17.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }



        }

        private void pictureBoxBlack_3_Click(object sender, EventArgs e)
        {

            int fieldknr = Settings.brick1.Field;
            if (fieldknr == 0)
            {
                brickList = Settings.field0.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick1.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 1)
            {
                brickList = Settings.field1.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick18.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 2)
            {
                brickList = Settings.field2.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick18.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 3)
            {
                brickList = Settings.field3.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick18.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 4)
            {
                brickList = Settings.field4.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick18.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 5)
            {
                brickList = Settings.field5.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick18.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 6)
            {
                brickList = Settings.field6.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick18.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 7)
            {
                brickList = Settings.field7.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick18.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 8)
            {
                brickList = Settings.field8.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick18.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 9)
            {
                brickList = Settings.field9.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick18.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 10)
            {
                brickList = Settings.field10.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick18.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 11)
            {
                brickList = Settings.field11.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick18.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 12)
            {
                brickList = Settings.field12.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick18.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 13)
            {
                brickList = Settings.field13.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick18.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 14)
            {
                brickList = Settings.field14.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick18.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 15)
            {
                brickList = Settings.field15.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick18.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 16)
            {
                brickList = Settings.field16.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick18.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 17)
            {
                brickList = Settings.field17.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick18.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 18)
            {
                brickList = Settings.field18.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick18.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 19)
            {
                brickList = Settings.field19.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick18.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 20)
            {
                brickList = Settings.field20.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick18.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 21)
            {
                brickList = Settings.field21.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick18.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 22)
            {
                brickList = Settings.field22.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick18.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 23)
            {
                brickList = Settings.field23.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick18.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 24)
            {
                brickList = Settings.field24.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick18.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 25)
            {
                brickList = Settings.field25.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick18.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 26)
            {
                brickList = Settings.field26.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick18.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 27)
            {
                brickList = Settings.field27.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick18.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }



        }

        private void pictureBoxBlack_4_Click(object sender, EventArgs e)
        {

            int fieldknr = Settings.brick1.Field;
            if (fieldknr == 0)
            {
                brickList = Settings.field0.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick19.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 1)
            {
                brickList = Settings.field1.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick19.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 2)
            {
                brickList = Settings.field2.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick19.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 3)
            {
                brickList = Settings.field3.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick19.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 4)
            {
                brickList = Settings.field4.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick19.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 5)
            {
                brickList = Settings.field5.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick19.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 6)
            {
                brickList = Settings.field6.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick19.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 7)
            {
                brickList = Settings.field7.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick19.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 8)
            {
                brickList = Settings.field8.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick19.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 9)
            {
                brickList = Settings.field9.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick19.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 10)
            {
                brickList = Settings.field10.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick19.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 11)
            {
                brickList = Settings.field11.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick19.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 12)
            {
                brickList = Settings.field12.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick19.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 13)
            {
                brickList = Settings.field13.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick19.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 14)
            {
                brickList = Settings.field14.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick19.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 15)
            {
                brickList = Settings.field15.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick19.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 16)
            {
                brickList = Settings.field16.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick19.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 17)
            {
                brickList = Settings.field17.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick19.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 18)
            {
                brickList = Settings.field18.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick19.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 19)
            {
                brickList = Settings.field19.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick19.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 20)
            {
                brickList = Settings.field20.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick19.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 21)
            {
                brickList = Settings.field21.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick19.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 22)
            {
                brickList = Settings.field22.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick19.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 23)
            {
                brickList = Settings.field23.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick19.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 24)
            {
                brickList = Settings.field24.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick19.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 25)
            {
                brickList = Settings.field25.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick19.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 26)
            {
                brickList = Settings.field26.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick19.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 27)
            {
                brickList = Settings.field27.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick19.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }



        }

        private void pictureBoxBlack_5_Click(object sender, EventArgs e)
        {

            int fieldknr = Settings.brick1.Field;
            if (fieldknr == 0)
            {
                brickList = Settings.field0.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick1.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 1)
            {
                brickList = Settings.field1.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick20.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 2)
            {
                brickList = Settings.field2.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick20.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 3)
            {
                brickList = Settings.field3.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick20.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 4)
            {
                brickList = Settings.field4.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick20.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 5)
            {
                brickList = Settings.field5.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick20.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 6)
            {
                brickList = Settings.field6.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick20.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 7)
            {
                brickList = Settings.field7.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick20.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 8)
            {
                brickList = Settings.field8.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick20.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 9)
            {
                brickList = Settings.field9.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick20.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 10)
            {
                brickList = Settings.field10.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick20.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 11)
            {
                brickList = Settings.field11.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick20.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 12)
            {
                brickList = Settings.field12.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick20.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 13)
            {
                brickList = Settings.field13.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick20.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 14)
            {
                brickList = Settings.field14.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick20.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 15)
            {
                brickList = Settings.field15.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick20.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 16)
            {
                brickList = Settings.field16.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick20.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 17)
            {
                brickList = Settings.field17.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick20.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 18)
            {
                brickList = Settings.field18.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick20.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 19)
            {
                brickList = Settings.field19.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick20.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 20)
            {
                brickList = Settings.field20.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick20.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 21)
            {
                brickList = Settings.field21.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick20.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 22)
            {
                brickList = Settings.field22.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick20.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 23)
            {
                brickList = Settings.field23.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick20.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 24)
            {
                brickList = Settings.field24.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick20.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 25)
            {
                brickList = Settings.field25.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick20.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 26)
            {
                brickList = Settings.field26.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick20.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 27)
            {
                brickList = Settings.field27.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick20.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }



        }

        private void pictureBoxBlack_6_Click(object sender, EventArgs e)
        {

            int fieldknr = Settings.brick1.Field;
            if (fieldknr == 0)
            {
                brickList = Settings.field0.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick21.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 1)
            {
                brickList = Settings.field1.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick21.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 2)
            {
                brickList = Settings.field2.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick21.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 3)
            {
                brickList = Settings.field3.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick21.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 4)
            {
                brickList = Settings.field4.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick21.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 5)
            {
                brickList = Settings.field5.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick21.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 6)
            {
                brickList = Settings.field6.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick21.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 7)
            {
                brickList = Settings.field7.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick21.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 8)
            {
                brickList = Settings.field8.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick21.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 9)
            {
                brickList = Settings.field9.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick21.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 10)
            {
                brickList = Settings.field10.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick21.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 11)
            {
                brickList = Settings.field11.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick21.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 12)
            {
                brickList = Settings.field12.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick21.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 13)
            {
                brickList = Settings.field13.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick21.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 14)
            {
                brickList = Settings.field14.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick21.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 15)
            {
                brickList = Settings.field15.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick21.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 16)
            {
                brickList = Settings.field16.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick21.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 17)
            {
                brickList = Settings.field17.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick21.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 18)
            {
                brickList = Settings.field18.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick21.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 19)
            {
                brickList = Settings.field19.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick21.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 20)
            {
                brickList = Settings.field20.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick21.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 21)
            {
                brickList = Settings.field21.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick21.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 22)
            {
                brickList = Settings.field22.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick21.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 23)
            {
                brickList = Settings.field23.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick21.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 24)
            {
                brickList = Settings.field24.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick21.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 25)
            {
                brickList = Settings.field25.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick21.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 26)
            {
                brickList = Settings.field26.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick21.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 27)
            {
                brickList = Settings.field27.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick21.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }



        }

        private void pictureBoxBlack_7_Click(object sender, EventArgs e)
        {

            int fieldknr = Settings.brick1.Field;
            if (fieldknr == 0)
            {
                brickList = Settings.field0.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick22.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 1)
            {
                brickList = Settings.field1.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick22.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 2)
            {
                brickList = Settings.field2.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick22.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 3)
            {
                brickList = Settings.field3.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick22.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 4)
            {
                brickList = Settings.field4.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick22.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 5)
            {
                brickList = Settings.field5.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick22.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 6)
            {
                brickList = Settings.field6.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick22.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 7)
            {
                brickList = Settings.field7.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick21.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 8)
            {
                brickList = Settings.field8.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick21.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 9)
            {
                brickList = Settings.field9.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick21.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 10)
            {
                brickList = Settings.field10.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick21.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 11)
            {
                brickList = Settings.field11.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick21.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 12)
            {
                brickList = Settings.field12.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick21.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 13)
            {
                brickList = Settings.field13.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick21.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 14)
            {
                brickList = Settings.field14.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick21.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 15)
            {
                brickList = Settings.field15.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick21.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 16)
            {
                brickList = Settings.field16.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick21.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 17)
            {
                brickList = Settings.field17.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick21.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 18)
            {
                brickList = Settings.field18.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick21.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 19)
            {
                brickList = Settings.field19.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick21.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 20)
            {
                brickList = Settings.field20.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick21.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 21)
            {
                brickList = Settings.field21.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick21.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 22)
            {
                brickList = Settings.field22.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick21.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 23)
            {
                brickList = Settings.field23.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick21.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 24)
            {
                brickList = Settings.field24.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick21.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 25)
            {
                brickList = Settings.field25.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick21.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 26)
            {
                brickList = Settings.field26.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick21.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 27)
            {
                brickList = Settings.field27.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick21.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }



        }

        private void pictureBoxBlack_8_Click(object sender, EventArgs e)
        {

            int fieldknr = Settings.brick1.Field;
            if (fieldknr == 0)
            {
                brickList = Settings.field0.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick22.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 1)
            {
                brickList = Settings.field1.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick22.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 2)
            {
                brickList = Settings.field2.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick22.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 3)
            {
                brickList = Settings.field3.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick22.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 4)
            {
                brickList = Settings.field4.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick22.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 5)
            {
                brickList = Settings.field5.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick22.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 6)
            {
                brickList = Settings.field6.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick22.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 7)
            {
                brickList = Settings.field7.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick22.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 8)
            {
                brickList = Settings.field8.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick22.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 9)
            {
                brickList = Settings.field9.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick1.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 10)
            {
                brickList = Settings.field10.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick22.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 11)
            {
                brickList = Settings.field11.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick1.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 12)
            {
                brickList = Settings.field12.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick22.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 13)
            {
                brickList = Settings.field13.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick22.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 14)
            {
                brickList = Settings.field14.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick22.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 15)
            {
                brickList = Settings.field15.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick22.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 16)
            {
                brickList = Settings.field16.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick22.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 17)
            {
                brickList = Settings.field17.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick22.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 18)
            {
                brickList = Settings.field18.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick22.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 19)
            {
                brickList = Settings.field19.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick22.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 20)
            {
                brickList = Settings.field20.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick22.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 21)
            {
                brickList = Settings.field21.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick22.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 22)
            {
                brickList = Settings.field22.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick22.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 23)
            {
                brickList = Settings.field23.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick22.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 24)
            {
                brickList = Settings.field24.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick22.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 25)
            {
                brickList = Settings.field25.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick22.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 26)
            {
                brickList = Settings.field26.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick22.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 27)
            {
                brickList = Settings.field27.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick22.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }



        }

        private void pictureBoxBlack_9_Click(object sender, EventArgs e)
        {

            int fieldknr = Settings.brick1.Field;
            if (fieldknr == 0)
            {
                brickList = Settings.field0.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick23.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 1)
            {
                brickList = Settings.field1.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick23.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 2)
            {
                brickList = Settings.field2.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick23.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 3)
            {
                brickList = Settings.field3.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick23.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 4)
            {
                brickList = Settings.field4.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick23.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 5)
            {
                brickList = Settings.field5.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick23.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 6)
            {
                brickList = Settings.field6.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick23.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 7)
            {
                brickList = Settings.field7.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick23.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 8)
            {
                brickList = Settings.field8.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick23.BrickNr.ToString())                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 9)
            {
                brickList = Settings.field9.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick23.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 10)
            {
                brickList = Settings.field10.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick23.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 11)
            {
                brickList = Settings.field11.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick23.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 12)
            {
                brickList = Settings.field12.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick23.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 13)
            {
                brickList = Settings.field13.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick23.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 14)
            {
                brickList = Settings.field14.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick23.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 15)
            {
                brickList = Settings.field15.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick23.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 16)
            {
                brickList = Settings.field16.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick23.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 17)
            {
                brickList = Settings.field17.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick23.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 18)
            {
                brickList = Settings.field18.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick23.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 19)
            {
                brickList = Settings.field19.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick23.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 20)
            {
                brickList = Settings.field20.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick23.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 21)
            {
                brickList = Settings.field21.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick23.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 22)
            {
                brickList = Settings.field22.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick23.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 23)
            {
                brickList = Settings.field23.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick23.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 24)
            {
                brickList = Settings.field24.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick23.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 25)
            {
                brickList = Settings.field25.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick23.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 26)
            {
                brickList = Settings.field26.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick23.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 27)
            {
                brickList = Settings.field27.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick23.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }



        }

        private void pictureBoxBlack_10_Click(object sender, EventArgs e)
        {

            int fieldknr = Settings.brick1.Field;
            if (fieldknr == 0)
            {
                brickList = Settings.field0.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick24.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 1)
            {
                brickList = Settings.field1.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick24.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 2)
            {
                brickList = Settings.field2.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick24.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 3)
            {
                brickList = Settings.field3.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick24.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 4)
            {
                brickList = Settings.field4.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick24.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 5)
            {
                brickList = Settings.field5.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick24.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 6)
            {
                brickList = Settings.field6.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick24.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 7)
            {
                brickList = Settings.field7.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick24.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 8)
            {
                brickList = Settings.field8.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick24.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 9)
            {
                brickList = Settings.field9.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick24.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 10)
            {
                brickList = Settings.field10.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick24.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 11)
            {
                brickList = Settings.field11.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick24.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 12)
            {
                brickList = Settings.field12.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick24.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 13)
            {
                brickList = Settings.field13.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick24.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 14)
            {
                brickList = Settings.field14.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick24.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 15)
            {
                brickList = Settings.field15.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick24.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 16)
            {
                brickList = Settings.field16.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick24.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 17)
            {
                brickList = Settings.field17.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick1.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 18)
            {
                brickList = Settings.field18.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick24.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 19)
            {
                brickList = Settings.field19.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick24.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 20)
            {
                brickList = Settings.field20.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick24.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 21)
            {
                brickList = Settings.field21.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick24.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 22)
            {
                brickList = Settings.field22.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick24.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 23)
            {
                brickList = Settings.field23.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick24.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 24)
            {
                brickList = Settings.field24.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick24.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 25)
            {
                brickList = Settings.field25.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick24.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 26)
            {
                brickList = Settings.field26.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick24.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 27)
            {
                brickList = Settings.field27.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick24.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }



        }

        private void pictureBoxBlack_11_Click(object sender, EventArgs e)
        {

            int fieldknr = Settings.brick1.Field;
            if (fieldknr == 0)
            {
                brickList = Settings.field0.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick25.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 1)
            {
                brickList = Settings.field1.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick25.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 2)
            {
                brickList = Settings.field2.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick25.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 3)
            {
                brickList = Settings.field3.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick25.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 4)
            {
                brickList = Settings.field4.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick25.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 5)
            {
                brickList = Settings.field5.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick25.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 6)
            {
                brickList = Settings.field6.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick25.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 7)
            {
                brickList = Settings.field7.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick25.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 8)
            {
                brickList = Settings.field8.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick25.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 9)
            {
                brickList = Settings.field9.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick25.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 10)
            {
                brickList = Settings.field10.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick25.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 11)
            {
                brickList = Settings.field11.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick25.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 12)
            {
                brickList = Settings.field12.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick25.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 13)
            {
                brickList = Settings.field13.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick25.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 14)
            {
                brickList = Settings.field14.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick25.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 15)
            {
                brickList = Settings.field15.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick25.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 16)
            {
                brickList = Settings.field16.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick25.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 17)
            {
                brickList = Settings.field17.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick25.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 18)
            {
                brickList = Settings.field18.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick25.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 19)
            {
                brickList = Settings.field19.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick25.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 20)
            {
                brickList = Settings.field20.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick25.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 21)
            {
                brickList = Settings.field21.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick25.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 22)
            {
                brickList = Settings.field22.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick25.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 23)
            {
                brickList = Settings.field23.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick25.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 24)
            {
                brickList = Settings.field24.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick25.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 25)
            {
                brickList = Settings.field25.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick25.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 26)
            {
                brickList = Settings.field26.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick25.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 27)
            {
                brickList = Settings.field27.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick25.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }



        }

        private void pictureBoxBlack_12_Click(object sender, EventArgs e)
        {

            int fieldknr = Settings.brick1.Field;
            if (fieldknr == 0)
            {
                brickList = Settings.field0.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick26.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 1)
            {
                brickList = Settings.field1.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick26.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 2)
            {
                brickList = Settings.field2.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick26.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 3)
            {
                brickList = Settings.field3.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick26.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 4)
            {
                brickList = Settings.field4.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick26.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 5)
            {
                brickList = Settings.field5.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick26.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 6)
            {
                brickList = Settings.field6.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick26.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 7)
            {
                brickList = Settings.field7.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick26.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 8)
            {
                brickList = Settings.field8.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick26.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 9)
            {
                brickList = Settings.field9.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick26.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 10)
            {
                brickList = Settings.field10.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick26.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 11)
            {
                brickList = Settings.field11.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick26.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 12)
            {
                brickList = Settings.field12.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick26.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 13)
            {
                brickList = Settings.field13.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick26.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 14)
            {
                brickList = Settings.field14.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick26.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 15)
            {
                brickList = Settings.field15.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick26.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 16)
            {
                brickList = Settings.field16.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick26.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 17)
            {
                brickList = Settings.field17.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick26.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 18)
            {
                brickList = Settings.field18.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick26.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 19)
            {
                brickList = Settings.field19.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick26.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 20)
            {
                brickList = Settings.field20.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick26.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 21)
            {
                brickList = Settings.field21.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick26.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 22)
            {
                brickList = Settings.field22.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick26.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 23)
            {
                brickList = Settings.field23.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick26.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 24)
            {
                brickList = Settings.field24.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick26.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 25)
            {
                brickList = Settings.field25.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick26.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 26)
            {
                brickList = Settings.field26.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick26.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 27)
            {
                brickList = Settings.field27.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick26.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }



        }

        private void pictureBoxBlack_13_Click(object sender, EventArgs e)
        {

            int fieldknr = Settings.brick1.Field;
            if (fieldknr == 0)
            {
                brickList = Settings.field0.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick27.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 1)
            {
                brickList = Settings.field1.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick27.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 2)
            {
                brickList = Settings.field2.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick27.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 3)
            {
                brickList = Settings.field3.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick27.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 4)
            {
                brickList = Settings.field4.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick27.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 5)
            {
                brickList = Settings.field5.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick1.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 6)
            {
                brickList = Settings.field6.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick27.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 7)
            {
                brickList = Settings.field7.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick27.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 8)
            {
                brickList = Settings.field8.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick27.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 9)
            {
                brickList = Settings.field9.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick27.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 10)
            {
                brickList = Settings.field10.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick27.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 11)
            {
                brickList = Settings.field11.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick27.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 12)
            {
                brickList = Settings.field12.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick27.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 13)
            {
                brickList = Settings.field13.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick27.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 14)
            {
                brickList = Settings.field14.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick27.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 15)
            {
                brickList = Settings.field15.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick27.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 16)
            {
                brickList = Settings.field16.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick27.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 17)
            {
                brickList = Settings.field17.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick27.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 18)
            {
                brickList = Settings.field18.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick27.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 19)
            {
                brickList = Settings.field19.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick27.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 20)
            {
                brickList = Settings.field20.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick27.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 21)
            {
                brickList = Settings.field21.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick27.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 22)
            {
                brickList = Settings.field22.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick27.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 23)
            {
                brickList = Settings.field23.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick27.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 24)
            {
                brickList = Settings.field24.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick1.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 25)
            {
                brickList = Settings.field25.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick27.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 26)
            {
                brickList = Settings.field26.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick27.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 27)
            {
                brickList = Settings.field27.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick27.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }



        }

        private void pictureBoxBlack_14_Click(object sender, EventArgs e)
        {

            int fieldknr = Settings.brick1.Field;
            if (fieldknr == 0)
            {
                brickList = Settings.field0.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick27.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 1)
            {
                brickList = Settings.field1.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick27.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 2)
            {
                brickList = Settings.field2.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick27.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 3)
            {
                brickList = Settings.field3.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick27.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 4)
            {
                brickList = Settings.field4.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick27.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 5)
            {
                brickList = Settings.field5.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick27.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 6)
            {
                brickList = Settings.field6.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick27.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 7)
            {
                brickList = Settings.field7.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick27.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 8)
            {
                brickList = Settings.field8.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick27.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 9)
            {
                brickList = Settings.field9.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick27.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 10)
            {
                brickList = Settings.field10.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick27.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 11)
            {
                brickList = Settings.field11.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick27.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 12)
            {
                brickList = Settings.field12.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick27.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 13)
            {
                brickList = Settings.field13.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick27.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 14)
            {
                brickList = Settings.field14.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick27.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 15)
            {
                brickList = Settings.field15.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick27.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 16)
            {
                brickList = Settings.field16.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick27.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 17)
            {
                brickList = Settings.field17.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick27.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 18)
            {
                brickList = Settings.field18.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick27.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 19)
            {
                brickList = Settings.field19.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick27.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 20)
            {
                brickList = Settings.field20.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick27.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 21)
            {
                brickList = Settings.field21.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick27.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 22)
            {
                brickList = Settings.field22.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick27.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 23)
            {
                brickList = Settings.field23.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick27.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 24)
            {
                brickList = Settings.field24.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick27.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 25)
            {
                brickList = Settings.field25.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick27.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 26)
            {
                brickList = Settings.field26.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick27.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 27)
            {
                brickList = Settings.field27.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick2.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }



        }

        private void pictureBoxBlack_15_Click(object sender, EventArgs e)
        {

            int fieldknr = Settings.brick1.Field;
            if (fieldknr == 0)
            {
                brickList = Settings.field0.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick28.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 1)
            {
                brickList = Settings.field1.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick28.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 2)
            {
                brickList = Settings.field2.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick28.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 3)
            {
                brickList = Settings.field3.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick28.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 4)
            {
                brickList = Settings.field4.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick28.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 5)
            {
                brickList = Settings.field5.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick28.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 6)
            {
                brickList = Settings.field6.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick28.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 7)
            {
                brickList = Settings.field7.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick28.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 8)
            {
                brickList = Settings.field8.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick28.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 9)
            {
                brickList = Settings.field9.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick28.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 10)
            {
                brickList = Settings.field10.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick28.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 11)
            {
                brickList = Settings.field11.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick28.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 12)
            {
                brickList = Settings.field12.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick28.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 13)
            {
                brickList = Settings.field13.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick28.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 14)
            {
                brickList = Settings.field14.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick28.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 15)
            {
                brickList = Settings.field15.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick28.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 16)
            {
                brickList = Settings.field16.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick28.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 17)
            {
                brickList = Settings.field17.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick1.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 18)
            {
                brickList = Settings.field18.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick1.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 19)
            {
                brickList = Settings.field19.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick28.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 20)
            {
                brickList = Settings.field20.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick28.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 21)
            {
                brickList = Settings.field21.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick28.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 22)
            {
                brickList = Settings.field22.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick28.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 23)
            {
                brickList = Settings.field23.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick28.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 24)
            {
                brickList = Settings.field24.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick28.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 25)
            {
                brickList = Settings.field25.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick28.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 26)
            {
                brickList = Settings.field26.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick28.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }
            if (fieldknr == 27)
            {
                brickList = Settings.field27.GetListBricks();
                int numberofBricksonfield = brickList.Count();

                if (numberofBricksonfield != 0)
                {
                    Bricks brick = brickList[numberofBricksonfield - 1];
                    if (brick.BrickNr.ToString() == Settings.brick28.BrickNr.ToString())
                    {
                        MessageBox.Show("You can move");
                    }
                    else
                    {
                        MessageBox.Show("You can not move");
                    }
                }
            }



        }

    }
}

                
using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace BackGammon
{
    public partial class GameLogic : Form
    {
        enum Turn { White, Black }

        Random random = new Random();
        GameManager gameManager = new GameManager();
        Settings set = new();
        private bool run = false;
        SetCordinates setCor = new();

        private bool terning_1_is_used = false, terning_2_is_used = false;
        private Turn currentTurn;
        private Random rand = new Random();
        List<Bricks> brickList = new List<Bricks>();
        private int aktuelTerning = 0;
        private bool brick_is_moved = false;
        private bool show_PictureBox = true;
        private bool show_possible_Moves = true;
        private bool show_on_Bar = true;
        private bool show_Can_Move = true;
        public static bool show_terninger = true;
        int usedterninger = 0;
        int barBlack = 0;
        int barWhite = 0;
        Point point1, point2, point3, point4, point5, point6, point7, point8, point9, point10, point11, point12, point13, point14, point15,
            point16, point17, point18, point19, point20, point21, point22, point23, point24, point25, point26, point27, point28, point29, point30;

        int i = 0;

        public GameLogic()
        {
            set.Cordinates();


            InitializeComponent();
            SetPictureBox();


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
        public void setLocationPictureBox()
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

        private void Terninger()
        {
            gameManager.Terninger();
            List<Terning> _rafleList = gameManager.getRafleList();
            btnTerning_1.Text = _rafleList[0].GetTerning().ToString();
            btnTerning_2.Text = _rafleList[1].GetTerning().ToString();
            var (rafletotal, dice1, dice2) = gameManager.GetPossibleMoves(currentTurn.ToString());
            if (show_possible_Moves) { MessageBox.Show($"Total possible moves: {rafletotal.Count}, Dice 1 moves: {dice1.Count}, Dice 2 moves: {dice2.Count}"); }
            if (rafletotal.Count == 0)
            {
                terning_1_is_used = true;
                terning_2_is_used = true;
                brick_is_moved = true;
                gameManager.set_is_terning_double(false);
                CheckChangeTurn();
            }
        }


        private void btnStart_Click(object sender, EventArgs e)
        {
            SetBricks setBricks = new();
            currentTurn = Turn.Black;//(Turn)rand.Next(2);
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
            set = new();
            brick_is_moved = true;
            Terninger();
            btnTerning_1.Enabled = true;
            btnTerning_2.Enabled = true;
            setLocationPictureBox();


            if (checkBoxPC.Checked)
            { PC pc = new PC(this); }

        }

        private void btnTerning_1_Click(object sender, EventArgs e)
        {

            if (brick_is_moved)
            {
                List<Terning> terning = gameManager.getRafleList();
                aktuelTerning = terning[0].GetTerning();
                terning_1_is_used = true;
                btnTerning_1.Enabled = false;
                brick_is_moved = false;

            }
        }

        private void btnTerning_2_Click(object sender, EventArgs e)
        {
            if (brick_is_moved)
            {
                List<Terning> terning = gameManager.getRafleList();
                aktuelTerning = terning[1].GetTerning();
                terning_2_is_used = true;
                btnTerning_2.Enabled = false;
                brick_is_moved = false;

            }
        }

        private void CheckChangeTurn()
        {
            if ((terning_1_is_used && terning_2_is_used) && brick_is_moved)
            {
                btnTerning_1.Enabled = true;
                btnTerning_2.Enabled = true;
                terning_1_is_used = false;
                terning_2_is_used = false;
                usedterninger++;
                if (Settings.field0.GetListBricks().Count == 15)
                {
                    if (show_on_Bar) { MessageBox.Show("Black is the Winder!"); }
                }
                if (Settings.field27.GetListBricks().Count == 15)
                {
                    if (show_on_Bar) { MessageBox.Show("White is the Winder"!); }
                }
                if (usedterninger == 2)
                {
                    gameManager.set_is_terning_double(false);
                    usedterninger = 0;
                }
                if (!gameManager.get_is_terning_double())
                {
                    if (currentTurn == Turn.White)
                    {
                        pictureBoxTurnBlack.Visible = true;
                        pictureBoxTurnWhite.Visible = false;
                        currentTurn = Turn.Black;
                        Terninger();
                    }
                }
                else
                {
                    pictureBoxTurnBlack.Visible = false;
                    pictureBoxTurnWhite.Visible = true;
                    currentTurn = Turn.White;
                    Terninger();
                }
            }
        }



        public Bricks MoveBrick(Fields fromField, Fields toField, Bricks brick, List<Bricks> brickList)
        {
            // Get the field numbers
            int fromFieldnr = fromField.NR;
            int toFieldnr = toField.NR;



            // Remove the brick from the starting field
            fromField.RemoveListBricks();
            if (toFieldnr <= 0)
            {
                Settings.field0.AddListBricks(brick);
                brick.X = Settings.cordinates[0].x;
                brick.Y = Settings.cordinates[0].y;
                return brick;

            }
            if (toFieldnr >= 25)
            {
                Settings.field27.AddListBricks(brick);
                brick.X = Settings.cordinates[27].x;
                brick.Y = Settings.cordinates[27].y;
                return brick;
            }
            // Update brick's field and coordinates
            brick.Field = toFieldnr;

            // Check if there is already a brick on the destination field
            List<Bricks> listBricks = toField.GetListBricks();
            if (listBricks.Count == 1)
            {
                // Get the existing brick on the destination field
                Bricks existingBrick = listBricks[0];
                toField.RemoveListBricks(); // Remove the existing brick from the field
                if (existingBrick.Color != brick.Color)
                {


                    // Add the existing brick to the appropriate captured field
                    if (existingBrick.Color == Bricks.BrickColor.White)
                    {
                        Settings.field25.AddListBricks(existingBrick);
                        int tal = existingBrick.BrickNr;
                        switch (tal)
                        {
                            case 1:
                                Settings.brick1.X = Settings.cordinates[Settings.field25.NR].x;
                                Settings.brick1.Y = Settings.cordinates[Settings.field25.NR].y;
                                break;
                            case 2:
                                Settings.brick2.X = Settings.cordinates[Settings.field25.NR].x;
                                Settings.brick2.Y = Settings.cordinates[Settings.field25.NR].y;
                                break;
                            case 3:
                                Settings.brick3.X = Settings.cordinates[Settings.field25.NR].x;
                                Settings.brick3.Y = Settings.cordinates[Settings.field25.NR].y;
                                break;
                            case 4:
                                Settings.brick4.X = Settings.cordinates[Settings.field25.NR].x;
                                Settings.brick4.Y = Settings.cordinates[Settings.field25.NR].y;
                                break;
                            case 5:
                                Settings.brick5.X = Settings.cordinates[Settings.field25.NR].x;
                                Settings.brick5.Y = Settings.cordinates[Settings.field25.NR].y;
                                break;
                            case 6:
                                Settings.brick6.X = Settings.cordinates[Settings.field25.NR].x;
                                Settings.brick6.Y = Settings.cordinates[Settings.field25.NR].y;
                                break;
                            case 7:
                                Settings.brick7.X = Settings.cordinates[Settings.field25.NR].x;
                                Settings.brick7.Y = Settings.cordinates[Settings.field25.NR].y;
                                break;
                            case 8:
                                Settings.brick8.X = Settings.cordinates[Settings.field25.NR].x;
                                Settings.brick8.Y = Settings.cordinates[Settings.field25.NR].y;
                                break;
                            case 9:
                                Settings.brick9.X = Settings.cordinates[Settings.field25.NR].x;
                                Settings.brick9.Y = Settings.cordinates[Settings.field25.NR].y;
                                break;
                            case 10:
                                Settings.brick10.X = Settings.cordinates[Settings.field25.NR].x;
                                Settings.brick10.Y = Settings.cordinates[Settings.field25.NR].y;
                                break;
                            case 11:
                                Settings.brick11.X = Settings.cordinates[Settings.field25.NR].x;
                                Settings.brick11.Y = Settings.cordinates[Settings.field25.NR].y;
                                break;
                            case 12:
                                Settings.brick12.X = Settings.cordinates[Settings.field25.NR].x;
                                Settings.brick12.Y = Settings.cordinates[Settings.field25.NR].y;
                                break;
                            case 13:
                                Settings.brick13.X = Settings.cordinates[Settings.field25.NR].x;
                                Settings.brick13.Y = Settings.cordinates[Settings.field25.NR].y;
                                break;
                            case 14:
                                Settings.brick14.X = Settings.cordinates[Settings.field25.NR].x;
                                Settings.brick14.Y = Settings.cordinates[Settings.field25.NR].y;
                                break;
                            case 15:
                                Settings.brick15.X = Settings.cordinates[Settings.field25.NR].x;
                                Settings.brick15.Y = Settings.cordinates[Settings.field25.NR].y;
                                break;
                        }
                    }
                    else
                    {
                        Settings.field26.AddListBricks(existingBrick);
                        // Update coordinates for the existing brick
                        int tal = existingBrick.BrickNr;
                        switch (tal)
                        {
                            case 16:
                                Settings.brick16.X = Settings.cordinates[Settings.field26.NR].x;
                                Settings.brick16.Y = Settings.cordinates[Settings.field26.NR].y;
                                break;
                            case 17:
                                Settings.brick17.X = Settings.cordinates[Settings.field26.NR].x;
                                Settings.brick17.Y = Settings.cordinates[Settings.field26.NR].y;
                                break;
                            case 18:
                                Settings.brick18.X = Settings.cordinates[Settings.field26.NR].x;
                                Settings.brick18.Y = Settings.cordinates[Settings.field26.NR].y;
                                break;
                            case 19:
                                Settings.brick19.X = Settings.cordinates[Settings.field26.NR].x;
                                Settings.brick19.Y = Settings.cordinates[Settings.field26.NR].y;
                                break;
                            case 20:
                                Settings.brick20.X = Settings.cordinates[Settings.field26.NR].x;
                                Settings.brick20.Y = Settings.cordinates[Settings.field26.NR].y;
                                break;
                            case 21:
                                Settings.brick21.X = Settings.cordinates[Settings.field26.NR].x;
                                Settings.brick21.Y = Settings.cordinates[Settings.field26.NR].y;
                                break;
                            case 22:
                                Settings.brick22.X = Settings.cordinates[Settings.field26.NR].x;
                                Settings.brick22.Y = Settings.cordinates[Settings.field26.NR].y;
                                break;
                            case 23:
                                Settings.brick23.X = Settings.cordinates[Settings.field26.NR].x;
                                Settings.brick23.Y = Settings.cordinates[Settings.field26.NR].y;
                                break;
                            case 24:
                                Settings.brick24.X = Settings.cordinates[Settings.field26.NR].x;
                                Settings.brick24.Y = Settings.cordinates[Settings.field26.NR].y;
                                break;
                            case 25:
                                Settings.brick25.X = Settings.cordinates[Settings.field26.NR].x;
                                Settings.brick25.Y = Settings.cordinates[Settings.field26.NR].y;
                                break;
                            case 26:
                                Settings.brick26.X = Settings.cordinates[Settings.field26.NR].x;
                                Settings.brick26.Y = Settings.cordinates[Settings.field26.NR].y;
                                break;
                            case 27:
                                Settings.brick27.X = Settings.cordinates[Settings.field26.NR].x;
                                Settings.brick27.Y = Settings.cordinates[Settings.field26.NR].y;
                                break;
                            case 28:
                                Settings.brick28.X = Settings.cordinates[Settings.field26.NR].x;
                                Settings.brick28.Y = Settings.cordinates[Settings.field26.NR].y;
                                break;
                            case 29:
                                Settings.brick29.X = Settings.cordinates[Settings.field26.NR].x;
                                Settings.brick29.Y = Settings.cordinates[Settings.field26.NR].y;
                                break;
                            case 30:
                                Settings.brick30.X = Settings.cordinates[Settings.field26.NR].x;
                                Settings.brick30.Y = Settings.cordinates[Settings.field26.NR].y;
                                break;
                        }
                        existingBrick.X = Settings.cordinates[Settings.field26.NR].x;
                        existingBrick.Y = Settings.cordinates[Settings.field26.NR].y;
                    }
                }
            }
            // Get the height for y-coordinate adjustment
            int y = getYHieght(toField);
            brick.X = Settings.cordinates[toFieldnr].x;
            brick.Y = Settings.cordinates[toFieldnr].y + y;
            // Add the moved brick to the destination field
            toField.AddListBricks(brick);
            CheckChangeTurn();
            return brick;
        }


        private int getYHieght(Fields toField)
        {
            int y_hieght = 0;
            List<Bricks> listBricks = toField.GetListBricks();
            int num = listBricks.Count();
            y_hieght = Settings.y_heigh[num];
            return y_hieght;
        }


        private Fields getToField(int fromField, Bricks brick)
        {
            Fields toField = new Fields();


            int newField = 0;
            if (brick.Color == Bricks.BrickColor.White)
            {
                newField = fromField + aktuelTerning; // Beregner det nye felt baseret på terningens værdi
            }
            else
            {
                newField = fromField - aktuelTerning;
            }
            toField = gameManager.GetField(newField);


            return toField;
        }
        private bool field_is_blocked(Bricks brick)
        {
            bool is_blocked = false;

            // Get the destination field for the brick
            Fields toField = getToField(brick.Field, brick);
            List<Bricks> listbricks = toField.GetListBricks();

            // Check if the destination field is blocked
            if (listbricks.Count >= 2 && listbricks[0].Color != brick.Color)
            {
                is_blocked = true;
            }

            return is_blocked;
        }

        public bool is_on_bar(Bricks brick)
        {
            bool bar = false;
            if (brick.Color == Bricks.BrickColor.White)
            {
                if (Settings.field25.GetListBricks().Count > 0)
                { MessageBox.Show("You have to move out of Bars before moving other bricks."); return true; }
            }
            else
            {
                if (Settings.field26.GetListBricks().Count > 0)
                { MessageBox.Show("You have to move out of Bars before moving other bricks."); return true; }
            }
            return false;
        }

        public bool CantakeoutBrick(Fields fromField, Bricks brick)
        {

            if ((brick.Color == Bricks.BrickColor.White) && (fromField.NR + aktuelTerning > 24))
            {

                if (Settings.field1.GetListBricks().Any())
                {
                    if (Settings.field1.GetListBricks()[0].Color == brick.Color)
                    {
                        return false;
                    }
                }


                if (Settings.field2.GetListBricks().Any())
                {
                    if (Settings.field2.GetListBricks()[0].Color == brick.Color)
                    {
                        return false;
                    }
                }

                if (Settings.field3.GetListBricks().Any())
                {
                    if (Settings.field3.GetListBricks()[0].Color == brick.Color)
                    {
                        return false;
                    }
                }

                if (Settings.field4.GetListBricks().Any())
                {
                    if (Settings.field4.GetListBricks()[0].Color == brick.Color)
                    {
                        return false;
                    }
                }

                if (Settings.field5.GetListBricks().Any())
                {
                    if (Settings.field5.GetListBricks()[0].Color == brick.Color)
                    {
                        return false;
                    }
                }

                if (Settings.field6.GetListBricks().Any())
                {
                    if (Settings.field6.GetListBricks()[0].Color == brick.Color)
                    {
                        return false;
                    }
                }

                if (Settings.field7.GetListBricks().Any())
                {
                    if (Settings.field7.GetListBricks()[0].Color == brick.Color)
                    {
                        return false;
                    }
                }

                if (Settings.field8.GetListBricks().Any())
                {
                    if (Settings.field8.GetListBricks()[0].Color == brick.Color)
                    {
                        return false;
                    }
                }


                if (Settings.field9.GetListBricks().Any())
                {
                    if (Settings.field9.GetListBricks()[0].Color == brick.Color)
                    {
                        return false;
                    }
                }


                if (Settings.field10.GetListBricks().Any())
                {
                    if (Settings.field10.GetListBricks()[0].Color == brick.Color)
                    {
                        return false;
                    }
                }


                if (Settings.field11.GetListBricks().Any())
                {
                    if (Settings.field11.GetListBricks()[0].Color == brick.Color)
                    {
                        return false;
                    }
                }


                if (Settings.field12.GetListBricks().Any())
                {
                    if (Settings.field12.GetListBricks()[0].Color == brick.Color)
                    {
                        return false;
                    }
                }


                if (Settings.field13.GetListBricks().Any())
                {
                    if (Settings.field13.GetListBricks()[0].Color == brick.Color)
                    {
                        return false;
                    }
                }


                if (Settings.field14.GetListBricks().Any())
                {
                    if (Settings.field14.GetListBricks()[0].Color == brick.Color)
                    {
                        return false;
                    }
                }


                if (Settings.field15.GetListBricks().Any())
                {
                    if (Settings.field15.GetListBricks()[0].Color == brick.Color)
                    {
                        return false;
                    }
                }


                if (Settings.field16.GetListBricks().Any())
                {
                    if (Settings.field16.GetListBricks()[0].Color == brick.Color)
                    {
                        return false;
                    }
                }


                if (Settings.field17.GetListBricks().Any())
                {
                    if (Settings.field17.GetListBricks()[0].Color == brick.Color)
                    {
                        return false;
                    }
                }


                if (Settings.field18.GetListBricks().Any())
                {
                    if (Settings.field18.GetListBricks()[0].Color == brick.Color)
                    {
                        return false;
                    }
                }
            }

            if ((brick.Color == Bricks.BrickColor.Black) && (fromField.NR + aktuelTerning < 0))
            {
                if (Settings.field7.GetListBricks().Any())
                {
                    if (Settings.field7.GetListBricks()[0].Color == brick.Color)
                    {
                        return false;
                    }
                }

                if (Settings.field8.GetListBricks().Any())
                {
                    if (Settings.field8.GetListBricks()[0].Color == brick.Color)
                    {
                        return false;
                    }
                }


                if (Settings.field9.GetListBricks().Any())
                {
                    if (Settings.field9.GetListBricks()[0].Color == brick.Color)
                    {
                        return false;
                    }
                }

                if (Settings.field10.GetListBricks().Any())
                {
                    if (Settings.field10.GetListBricks()[0].Color == brick.Color)
                    {
                        return false;
                    }
                }

                if (Settings.field11.GetListBricks().Any())
                {
                    if (Settings.field11.GetListBricks()[0].Color == brick.Color)
                    {
                        return false;
                    }
                }

                if (Settings.field12.GetListBricks().Any())
                {
                    if (Settings.field12.GetListBricks()[0].Color == brick.Color)
                    {
                        return false;
                    }
                }

                if (Settings.field13.GetListBricks().Any())
                {
                    if (Settings.field13.GetListBricks()[0].Color == brick.Color)
                    {
                        return false;
                    }
                }

                if (Settings.field14.GetListBricks().Any())
                {
                    if (Settings.field14.GetListBricks()[0].Color == brick.Color)
                    {
                        return false;
                    }
                }

                if (Settings.field15.GetListBricks().Any())
                {
                    if (Settings.field15.GetListBricks()[0].Color == brick.Color)
                    {
                        return false;
                    }
                }


                if (Settings.field16.GetListBricks().Any())
                {
                    if (Settings.field16.GetListBricks()[0].Color == brick.Color)
                    {
                        return false;
                    }
                }


                if (Settings.field17.GetListBricks().Any())
                {
                    if (Settings.field17.GetListBricks()[0].Color == brick.Color)
                    {
                        return false;
                    }
                }


                if (Settings.field18.GetListBricks().Any())
                {
                    if (Settings.field18.GetListBricks()[0].Color == brick.Color)
                    {
                        return false;
                    }
                }


                if (Settings.field19.GetListBricks().Any())
                {
                    if (Settings.field19.GetListBricks()[0].Color == brick.Color)
                    {
                        return false;
                    }
                }


                if (Settings.field20.GetListBricks().Any())
                {
                    if (Settings.field20.GetListBricks()[0].Color == brick.Color)
                    {
                        return false;
                    }
                }


                if (Settings.field21.GetListBricks().Any())
                {
                    if (Settings.field21.GetListBricks()[0].Color == brick.Color)
                    {
                        return false;
                    }
                }


                if (Settings.field22.GetListBricks().Any())
                {
                    if (Settings.field22.GetListBricks()[0].Color == brick.Color)
                    {
                        return false;
                    }
                }


                if (Settings.field23.GetListBricks().Any())
                {
                    if (Settings.field23.GetListBricks()[0].Color == brick.Color)
                    {
                        return false;
                    }
                }


                if (Settings.field24.GetListBricks().Any())
                {
                    if (Settings.field24.GetListBricks()[0].Color == brick.Color)
                    {
                        return false;
                    }
                }


            }

            return true;
        }

        public bool CanMoveBrick(int fieldNumber, Bricks brick, List<Bricks> brickList)
        {
            // Tjek om der er nogen brikker på feltet
            if ((brickList.Count > 0) && (brick_is_moved == false) && ((terning_1_is_used) || (terning_2_is_used)))
            {
                // Hent den sidste brik på feltet
                Bricks lastBrick = brickList[brickList.Count - 1];

                // Tjek om den sidste brik er den samme som den aktuelle brik
                if ((lastBrick.BrickNr == brick.BrickNr) && (currentTurn.ToString() == brick.Color.ToString()))
                {
                    try
                    {

                        bool is_blocked = field_is_blocked(brick);
                        if (is_blocked) { if (show_Can_Move) { MessageBox.Show("You can not move " + brickList.Count() + " " + fieldNumber + " " + brick.BrickNr.ToString()); }; return false; }
                        Fields fromField = gameManager.GetField(fieldNumber);
                        Fields toField = getToField(fieldNumber, brick);
                        bool cantakeoutBrick = CantakeoutBrick(fromField, brick);

                        bool bar = is_on_bar(brick);
                        if (bar) { return false; }
                        brick_is_moved = true;
                        if (show_Can_Move)
                        {
                            MessageBox.Show("You can move. ToFieldNr" + toField.NR + " Current Turn is: " + currentTurn + " brickListCount: " + brickList.Count() + " FieldNr: " + fieldNumber + " BrickNr: " + brick.BrickNr.ToString());
                        }

                        return true; // Brikken må flyttes, da den er den sidste på feltet
                    }
                    catch (Exception e) { return false; }
                }
            }
            if (show_Can_Move)
            {
                MessageBox.Show("You can not move " + brickList.Count() + " " + fieldNumber + " " + brick.BrickNr.ToString());
            }
            return false; // Brikken må ikke flyttes
        }


        #region White PictureBox
        private void pictureBoxWhite_1_Click(object sender, EventArgs e)
        {

            int fieldnr = Settings.brick1.Field;

            if (fieldnr == 0)
            {
                brickList = Settings.field0.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick1.Field.ToString()); }

                var canMoveResult = CanMoveBrick(0, Settings.brick1, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick1);
                    Settings.brick1 = MoveBrick(fromField, toField, Settings.brick1, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 1)
            {
                List<Bricks> brickList = Settings.field1.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick1.Field.ToString()); }


                var canMoveResult = CanMoveBrick(1, Settings.brick1, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {

                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick1);
                    Settings.brick1 = MoveBrick(fromField, toField, Settings.brick1, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 2)
            {
                brickList = Settings.field2.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick1.Field.ToString()); }

                var canMoveResult = CanMoveBrick(2, Settings.brick1, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick1);
                    Settings.brick1 = MoveBrick(fromField, toField, Settings.brick1, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 3)
            {
                brickList = Settings.field3.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick1.Field.ToString()); }

                var canMoveResult = CanMoveBrick(3, Settings.brick1, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick1);
                    Settings.brick1 = MoveBrick(fromField, toField, Settings.brick1, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 4)
            {
                brickList = Settings.field4.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick1.Field.ToString()); }

                var canMoveResult = CanMoveBrick(4, Settings.brick1, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick1);
                    Settings.brick1 = MoveBrick(fromField, toField, Settings.brick1, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 5)
            {
                brickList = Settings.field5.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick1.Field.ToString()); }

                var canMoveResult = CanMoveBrick(5, Settings.brick1, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick1);
                    Settings.brick1 = MoveBrick(fromField, toField, Settings.brick1, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 6)
            {
                brickList = Settings.field6.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick1.Field.ToString()); }

                var canMoveResult = CanMoveBrick(6, Settings.brick1, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick1);
                    Settings.brick1 = MoveBrick(fromField, toField, Settings.brick1, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 7)
            {
                brickList = Settings.field7.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick1.Field.ToString()); }

                var canMoveResult = CanMoveBrick(7, Settings.brick1, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick1);
                    Settings.brick1 = MoveBrick(fromField, toField, Settings.brick1, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 8)
            {
                brickList = Settings.field8.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick1.Field.ToString()); }

                var canMoveResult = CanMoveBrick(7, Settings.brick1, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick1);
                    Settings.brick1 = MoveBrick(fromField, toField, Settings.brick1, brickList);


                    setLocationPictureBox();
                }
            }
            if (fieldnr == 9)
            {
                brickList = Settings.field9.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick1.Field.ToString()); }

                var canMoveResult = CanMoveBrick(9, Settings.brick1, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick1);
                    Settings.brick1 = MoveBrick(fromField, toField, Settings.brick1, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 10)
            {
                brickList = Settings.field10.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick1.Field.ToString()); }

                var canMoveResult = CanMoveBrick(10, Settings.brick1, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick1);
                    Settings.brick1 = MoveBrick(fromField, toField, Settings.brick1, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 11)
            {
                brickList = Settings.field11.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick1.Field.ToString()); }

                var canMoveResult = CanMoveBrick(11, Settings.brick1, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick1);
                    Settings.brick1 = MoveBrick(fromField, toField, Settings.brick1, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 12)
            {
                brickList = Settings.field12.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick1.Field.ToString()); }

                var canMoveResult = CanMoveBrick(12, Settings.brick1, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {

                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick1);
                    Settings.brick1 = MoveBrick(fromField, toField, Settings.brick1, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 13)
            {
                brickList = Settings.field13.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick1.Field.ToString()); }

                var canMoveResult = CanMoveBrick(13, Settings.brick1, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick1);
                    Settings.brick1 = MoveBrick(fromField, toField, Settings.brick1, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 14)
            {
                brickList = Settings.field14.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick1.Field.ToString()); }

                var canMoveResult = CanMoveBrick(14, Settings.brick1, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick1);
                    Settings.brick1 = MoveBrick(fromField, toField, Settings.brick1, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 15)
            {
                brickList = Settings.field15.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick1.Field.ToString()); }

                var canMoveResult = CanMoveBrick(15, Settings.brick1, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick1);
                    Settings.brick1 = MoveBrick(fromField, toField, Settings.brick1, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 16)
            {
                brickList = Settings.field16.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick1.Field.ToString()); }

                var canMoveResult = CanMoveBrick(16, Settings.brick1, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick1);
                    Settings.brick1 = MoveBrick(fromField, toField, Settings.brick1, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 17)
            {
                brickList = Settings.field17.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick1.Field.ToString()); }

                var canMoveResult = CanMoveBrick(17, Settings.brick1, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick1);
                    Settings.brick1 = MoveBrick(fromField, toField, Settings.brick1, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 18)
            {
                brickList = Settings.field18.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick1.Field.ToString()); }

                var canMoveResult = CanMoveBrick(18, Settings.brick1, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick1);
                    Settings.brick1 = MoveBrick(fromField, toField, Settings.brick1, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 19)
            {
                brickList = Settings.field19.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick1.Field.ToString()); }

                var canMoveResult = CanMoveBrick(19, Settings.brick1, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick1);
                    Settings.brick1 = MoveBrick(fromField, toField, Settings.brick1, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 20)
            {
                brickList = Settings.field20.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick1.Field.ToString()); }

                var canMoveResult = CanMoveBrick(20, Settings.brick1, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick1);
                    Settings.brick1 = MoveBrick(fromField, toField, Settings.brick1, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 21)
            {
                brickList = Settings.field21.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick1.Field.ToString()); }

                var canMoveResult = CanMoveBrick(21, Settings.brick1, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick1);
                    Settings.brick1 = MoveBrick(fromField, toField, Settings.brick1, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 22)
            {
                brickList = Settings.field22.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick1.Field.ToString()); }

                var canMoveResult = CanMoveBrick(22, Settings.brick1, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick1);
                    Settings.brick1 = MoveBrick(fromField, toField, Settings.brick1, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 23)
            {
                brickList = Settings.field23.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick1.Field.ToString()); }

                var canMoveResult = CanMoveBrick(23, Settings.brick1, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick1);
                    Settings.brick1 = MoveBrick(fromField, toField, Settings.brick1, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 24)
            {
                brickList = Settings.field24.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick1.Field.ToString()); }

                var canMoveResult = CanMoveBrick(24, Settings.brick1, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick1);
                    Settings.brick1 = MoveBrick(fromField, toField, Settings.brick1, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 25)
            {
                brickList = Settings.field25.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick1.Field.ToString()); }

                var canMoveResult = CanMoveBrick(25, Settings.brick1, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick1);
                    Settings.brick1 = MoveBrick(fromField, toField, Settings.brick1, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 26)
            {
                brickList = Settings.field26.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick1.Field.ToString()); }

                var canMoveResult = CanMoveBrick(26, Settings.brick1, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick1);
                    Settings.brick1 = MoveBrick(fromField, toField, Settings.brick1, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 27)
            {
                brickList = Settings.field27.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick1.Field.ToString()); }

                var canMoveResult = CanMoveBrick(27, Settings.brick1, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick1);
                    Settings.brick1 = MoveBrick(fromField, toField, Settings.brick1, brickList);

                    setLocationPictureBox();
                }
            }
        }

        private void pictureBoxWhite_2_Click(object sender, EventArgs e)
        {
            int fieldnr = Settings.brick2.Field;
            if (fieldnr == 0)
            {
                brickList = Settings.field0.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick2.Field.ToString()); }

                var canMoveResult = CanMoveBrick(0, Settings.brick2, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {

                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick2);
                    Settings.brick2 = MoveBrick(fromField, toField, Settings.brick2, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 1)
            {
                List<Bricks> brickList = Settings.field1.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick2.Field.ToString()); }


                var canMoveResult = CanMoveBrick(1, Settings.brick2, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {

                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick2);
                    Settings.brick2 = MoveBrick(fromField, toField, Settings.brick2, brickList);

                    setLocationPictureBox();
                }

            }
            if (fieldnr == 2)
            {
                brickList = Settings.field2.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick2.Field.ToString()); }


                var canMoveResult = CanMoveBrick(2, Settings.brick2, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {

                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick2);
                    Settings.brick2 = MoveBrick(fromField, toField, Settings.brick2, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 3)
            {
                brickList = Settings.field3.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick2.Field.ToString()); }

                var canMoveResult = CanMoveBrick(3, Settings.brick2, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick2);
                    Settings.brick2 = MoveBrick(fromField, toField, Settings.brick2, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 4)
            {
                brickList = Settings.field4.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick2.Field.ToString()); }

                var canMoveResult = CanMoveBrick(4, Settings.brick2, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick2);
                    Settings.brick2 = MoveBrick(fromField, toField, Settings.brick2, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 5)
            {
                brickList = Settings.field5.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick2.Field.ToString()); }

                var canMoveResult = CanMoveBrick(5, Settings.brick2, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick2);
                    Settings.brick2 = MoveBrick(fromField, toField, Settings.brick2, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 6)
            {
                brickList = Settings.field6.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick2.Field.ToString()); }

                var canMoveResult = CanMoveBrick(6, Settings.brick2, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick2);
                    Settings.brick2 = MoveBrick(fromField, toField, Settings.brick2, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 7)
            {
                brickList = Settings.field7.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick2.Field.ToString()); }

                var canMoveResult = CanMoveBrick(7, Settings.brick2, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick2);
                    Settings.brick2 = MoveBrick(fromField, toField, Settings.brick2, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 8)
            {
                brickList = Settings.field8.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick2.Field.ToString()); }

                var canMoveResult = CanMoveBrick(8, Settings.brick2, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick2);
                    Settings.brick2 = MoveBrick(fromField, toField, Settings.brick2, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 9)
            {
                brickList = Settings.field9.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick2.Field.ToString()); }

                var canMoveResult = CanMoveBrick(9, Settings.brick2, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick2);
                    Settings.brick2 = MoveBrick(fromField, toField, Settings.brick2, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 10)
            {
                brickList = Settings.field10.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick2.Field.ToString()); }

                var canMoveResult = CanMoveBrick(10, Settings.brick2, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick2);
                    Settings.brick2 = MoveBrick(fromField, toField, Settings.brick2, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 11)
            {
                brickList = Settings.field11.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick2.Field.ToString()); }

                var canMoveResult = CanMoveBrick(11, Settings.brick2, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick2);
                    Settings.brick2 = MoveBrick(fromField, toField, Settings.brick2, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 12)
            {
                brickList = Settings.field12.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick2.Field.ToString()); }

                var canMoveResult = CanMoveBrick(12, Settings.brick2, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick2);
                    Settings.brick2 = MoveBrick(fromField, toField, Settings.brick2, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 13)
            {
                brickList = Settings.field13.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick2.Field.ToString()); }

                var canMoveResult = CanMoveBrick(13, Settings.brick2, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick2);
                    Settings.brick2 = MoveBrick(fromField, toField, Settings.brick2, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 14)
            {
                brickList = Settings.field14.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick2.Field.ToString()); }

                var canMoveResult = CanMoveBrick(14, Settings.brick2, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick2);
                    Settings.brick2 = MoveBrick(fromField, toField, Settings.brick2, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 15)
            {
                brickList = Settings.field15.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick2.Field.ToString()); }

                var canMoveResult = CanMoveBrick(15, Settings.brick2, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick2);
                    Settings.brick2 = MoveBrick(fromField, toField, Settings.brick2, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 16)
            {
                brickList = Settings.field16.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick2.Field.ToString()); }

                var canMoveResult = CanMoveBrick(16, Settings.brick2, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick2);
                    Settings.brick2 = MoveBrick(fromField, toField, Settings.brick2, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 17)
            {
                brickList = Settings.field17.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick2.Field.ToString()); }

                var canMoveResult = CanMoveBrick(17, Settings.brick2, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick2);
                    Settings.brick2 = MoveBrick(fromField, toField, Settings.brick2, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 18)
            {
                brickList = Settings.field18.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick2.Field.ToString()); }

                var canMoveResult = CanMoveBrick(18, Settings.brick2, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick2);
                    Settings.brick2 = MoveBrick(fromField, toField, Settings.brick2, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 19)
            {
                brickList = Settings.field19.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick2.Field.ToString()); }

                var canMoveResult = CanMoveBrick(19, Settings.brick2, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick2);
                    Settings.brick2 = MoveBrick(fromField, toField, Settings.brick2, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 20)
            {
                brickList = Settings.field20.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick2.Field.ToString()); }

                var canMoveResult = CanMoveBrick(20, Settings.brick2, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick2);
                    Settings.brick2 = MoveBrick(fromField, toField, Settings.brick2, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 21)
            {
                brickList = Settings.field21.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick2.Field.ToString()); }

                var canMoveResult = CanMoveBrick(21, Settings.brick2, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick2);
                    Settings.brick2 = MoveBrick(fromField, toField, Settings.brick2, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 22)
            {
                brickList = Settings.field22.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick2.Field.ToString()); }

                var canMoveResult = CanMoveBrick(22, Settings.brick2, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick2);
                    Settings.brick2 = MoveBrick(fromField, toField, Settings.brick2, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 23)
            {
                brickList = Settings.field23.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick2.Field.ToString()); }

                var canMoveResult = CanMoveBrick(23, Settings.brick2, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick2);
                    Settings.brick2 = MoveBrick(fromField, toField, Settings.brick2, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 24)
            {
                brickList = Settings.field24.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick2.Field.ToString()); }

                var canMoveResult = CanMoveBrick(24, Settings.brick2, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick2);
                    Settings.brick2 = MoveBrick(fromField, toField, Settings.brick2, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 25)
            {
                brickList = Settings.field25.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick2.Field.ToString()); }

                var canMoveResult = CanMoveBrick(25, Settings.brick2, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick2);
                    Settings.brick2 = MoveBrick(fromField, toField, Settings.brick2, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 26)
            {
                brickList = Settings.field26.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick2.Field.ToString()); }

                var canMoveResult = CanMoveBrick(26, Settings.brick2, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick2);
                    Settings.brick2 = MoveBrick(fromField, toField, Settings.brick2, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 27)
            {
                brickList = Settings.field27.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick2.Field.ToString()); }

                var canMoveResult = CanMoveBrick(27, Settings.brick2, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick2);
                    Settings.brick2 = MoveBrick(fromField, toField, Settings.brick2, brickList);

                    setLocationPictureBox();
                }
            }

        }

        private void pictureBoxWhite_3_Click(object sender, EventArgs e)
        {

            int fieldnr = Settings.brick3.Field;
            if (fieldnr == 0)
            {
                brickList = Settings.field0.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick3.Field.ToString()); }

                var canMoveResult = CanMoveBrick(0, Settings.brick3, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick3);
                    Settings.brick3 = MoveBrick(fromField, toField, Settings.brick3, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 1)
            {
                brickList = Settings.field1.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick3.Field.ToString()); }

                var canMoveResult = CanMoveBrick(1, Settings.brick3, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick3);
                    Settings.brick3 = MoveBrick(fromField, toField, Settings.brick3, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 2)
            {
                brickList = Settings.field2.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick3.Field.ToString()); }

                var canMoveResult = CanMoveBrick(2, Settings.brick3, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick3);
                    Settings.brick3 = MoveBrick(fromField, toField, Settings.brick3, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 3)
            {
                brickList = Settings.field3.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick3.Field.ToString()); }

                var canMoveResult = CanMoveBrick(3, Settings.brick3, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick3);
                    Settings.brick3 = MoveBrick(fromField, toField, Settings.brick3, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 4)
            {
                brickList = Settings.field4.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick3.Field.ToString()); }

                var canMoveResult = CanMoveBrick(4, Settings.brick3, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick3);
                    Settings.brick3 = MoveBrick(fromField, toField, Settings.brick3, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 5)
            {
                brickList = Settings.field5.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick3.Field.ToString()); }

                var canMoveResult = CanMoveBrick(5, Settings.brick3, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick3);
                    Settings.brick3 = MoveBrick(fromField, toField, Settings.brick3, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 6)
            {
                brickList = Settings.field6.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick3.Field.ToString()); }

                var canMoveResult = CanMoveBrick(6, Settings.brick3, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick3);
                    Settings.brick3 = MoveBrick(fromField, toField, Settings.brick3, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 7)
            {
                brickList = Settings.field7.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick3.Field.ToString()); }

                var canMoveResult = CanMoveBrick(7, Settings.brick3, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick3);
                    Settings.brick3 = MoveBrick(fromField, toField, Settings.brick3, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 8)
            {
                brickList = Settings.field8.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick3.Field.ToString()); }

                var canMoveResult = CanMoveBrick(8, Settings.brick3, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick3);
                    Settings.brick3 = MoveBrick(fromField, toField, Settings.brick3, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 9)
            {
                brickList = Settings.field9.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick3.Field.ToString()); }

                var canMoveResult = CanMoveBrick(9, Settings.brick3, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick3);
                    Settings.brick3 = MoveBrick(fromField, toField, Settings.brick3, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 10)
            {
                brickList = Settings.field10.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick3.Field.ToString()); }

                var canMoveResult = CanMoveBrick(10, Settings.brick3, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick3);
                    Settings.brick3 = MoveBrick(fromField, toField, Settings.brick3, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 11)
            {
                brickList = Settings.field11.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick3.Field.ToString()); }

                var canMoveResult = CanMoveBrick(11, Settings.brick3, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick3);
                    Settings.brick3 = MoveBrick(fromField, toField, Settings.brick3, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 12)
            {
                brickList = Settings.field12.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick3.Field.ToString()); }

                var canMoveResult = CanMoveBrick(12, Settings.brick3, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick3);
                    Settings.brick3 = MoveBrick(fromField, toField, Settings.brick3, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 13)
            {
                brickList = Settings.field13.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick3.Field.ToString()); }

                var canMoveResult = CanMoveBrick(13, Settings.brick3, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick3);
                    Settings.brick3 = MoveBrick(fromField, toField, Settings.brick3, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 14)
            {
                brickList = Settings.field14.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick3.Field.ToString()); }

                var canMoveResult = CanMoveBrick(14, Settings.brick3, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick3);
                    Settings.brick3 = MoveBrick(fromField, toField, Settings.brick3, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 15)
            {
                brickList = Settings.field15.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick3.Field.ToString()); }

                var canMoveResult = CanMoveBrick(15, Settings.brick3, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick3);
                    Settings.brick3 = MoveBrick(fromField, toField, Settings.brick3, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 16)
            {
                brickList = Settings.field16.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick3.Field.ToString()); }

                var canMoveResult = CanMoveBrick(16, Settings.brick3, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick3);
                    Settings.brick3 = MoveBrick(fromField, toField, Settings.brick3, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 17)
            {
                brickList = Settings.field17.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick3.Field.ToString()); }

                var canMoveResult = CanMoveBrick(17, Settings.brick3, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick3);
                    Settings.brick3 = MoveBrick(fromField, toField, Settings.brick3, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 18)
            {
                brickList = Settings.field18.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick3.Field.ToString()); }

                var canMoveResult = CanMoveBrick(18, Settings.brick3, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick3);
                    Settings.brick3 = MoveBrick(fromField, toField, Settings.brick3, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 19)
            {
                brickList = Settings.field19.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick3.Field.ToString()); }

                var canMoveResult = CanMoveBrick(19, Settings.brick3, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick3);
                    Settings.brick3 = MoveBrick(fromField, toField, Settings.brick3, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 20)
            {
                brickList = Settings.field20.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick3.Field.ToString()); }

                var canMoveResult = CanMoveBrick(20, Settings.brick3, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick3);
                    Settings.brick3 = MoveBrick(fromField, toField, Settings.brick3, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 21)
            {
                brickList = Settings.field21.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick3.Field.ToString()); }

                var canMoveResult = CanMoveBrick(21, Settings.brick3, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick3);
                    Settings.brick3 = MoveBrick(fromField, toField, Settings.brick3, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 22)
            {
                brickList = Settings.field22.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick3.Field.ToString()); }

                var canMoveResult = CanMoveBrick(22, Settings.brick3, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick3);
                    Settings.brick3 = MoveBrick(fromField, toField, Settings.brick3, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 23)
            {
                brickList = Settings.field23.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick3.Field.ToString()); }

                var canMoveResult = CanMoveBrick(23, Settings.brick3, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick3);
                    Settings.brick3 = MoveBrick(fromField, toField, Settings.brick3, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 24)
            {
                brickList = Settings.field24.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick3.Field.ToString()); }

                var canMoveResult = CanMoveBrick(24, Settings.brick3, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick3);
                    Settings.brick3 = MoveBrick(fromField, toField, Settings.brick3, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 25)
            {
                brickList = Settings.field25.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick3.Field.ToString()); }

                var canMoveResult = CanMoveBrick(25, Settings.brick3, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick3);
                    Settings.brick3 = MoveBrick(fromField, toField, Settings.brick3, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 26)
            {
                brickList = Settings.field26.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick3.Field.ToString()); }

                var canMoveResult = CanMoveBrick(26, Settings.brick3, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick3);
                    Settings.brick3 = MoveBrick(fromField, toField, Settings.brick3, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 27)
            {
                brickList = Settings.field27.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick3.Field.ToString()); }

                var canMoveResult = CanMoveBrick(27, Settings.brick3, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick3);
                    Settings.brick3 = MoveBrick(fromField, toField, Settings.brick3, brickList);

                    setLocationPictureBox();
                }
            }
        }

        private void pictureBoxWhite_4_Click(object sender, EventArgs e)
        {

            int fieldnr = Settings.brick4.Field;
            if (fieldnr == 0)
            {
                brickList = Settings.field0.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick4.Field.ToString()); }

                var canMoveResult = CanMoveBrick(0, Settings.brick4, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick4);
                    Settings.brick4 = MoveBrick(fromField, toField, Settings.brick4, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 1)
            {
                brickList = Settings.field1.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick4.Field.ToString()); }

                var canMoveResult = CanMoveBrick(1, Settings.brick4, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick4);
                    Settings.brick4 = MoveBrick(fromField, toField, Settings.brick4, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 2)
            {
                brickList = Settings.field2.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick4.Field.ToString()); }

                var canMoveResult = CanMoveBrick(2, Settings.brick4, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick4);
                    Settings.brick4 = MoveBrick(fromField, toField, Settings.brick4, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 3)
            {
                brickList = Settings.field3.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick4.Field.ToString()); }

                var canMoveResult = CanMoveBrick(3, Settings.brick4, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick4);
                    Settings.brick4 = MoveBrick(fromField, toField, Settings.brick4, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 4)
            {
                brickList = Settings.field4.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick4.Field.ToString()); }

                var canMoveResult = CanMoveBrick(4, Settings.brick4, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick4);
                    Settings.brick4 = MoveBrick(fromField, toField, Settings.brick4, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 5)
            {
                brickList = Settings.field5.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick4.Field.ToString()); }

                var canMoveResult = CanMoveBrick(5, Settings.brick4, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick4);
                    Settings.brick4 = MoveBrick(fromField, toField, Settings.brick4, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 6)
            {
                brickList = Settings.field6.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick4.Field.ToString()); }

                var canMoveResult = CanMoveBrick(6, Settings.brick4, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick4);
                    Settings.brick4 = MoveBrick(fromField, toField, Settings.brick4, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 7)
            {
                brickList = Settings.field7.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick4.Field.ToString()); }

                var canMoveResult = CanMoveBrick(7, Settings.brick4, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick4);
                    Settings.brick4 = MoveBrick(fromField, toField, Settings.brick4, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 8)
            {
                brickList = Settings.field8.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick4.Field.ToString()); }

                var canMoveResult = CanMoveBrick(8, Settings.brick4, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick4);
                    Settings.brick4 = MoveBrick(fromField, toField, Settings.brick4, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 9)
            {
                brickList = Settings.field9.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick4.Field.ToString()); }

                var canMoveResult = CanMoveBrick(9, Settings.brick4, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick4);
                    Settings.brick4 = MoveBrick(fromField, toField, Settings.brick4, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 10)
            {
                brickList = Settings.field10.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick4.Field.ToString()); }

                var canMoveResult = CanMoveBrick(10, Settings.brick4, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick4);
                    Settings.brick4 = MoveBrick(fromField, toField, Settings.brick4, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 11)
            {
                brickList = Settings.field11.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick4.Field.ToString()); }

                var canMoveResult = CanMoveBrick(11, Settings.brick4, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick4);
                    Settings.brick4 = MoveBrick(fromField, toField, Settings.brick4, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 12)
            {
                brickList = Settings.field12.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick4.Field.ToString()); }

                var canMoveResult = CanMoveBrick(12, Settings.brick4, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick4);
                    Settings.brick4 = MoveBrick(fromField, toField, Settings.brick4, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 13)
            {
                brickList = Settings.field13.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick4.Field.ToString()); }

                var canMoveResult = CanMoveBrick(13, Settings.brick4, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick4);
                    Settings.brick4 = MoveBrick(fromField, toField, Settings.brick4, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 14)
            {
                brickList = Settings.field14.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick4.Field.ToString()); }

                var canMoveResult = CanMoveBrick(14, Settings.brick4, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick4);
                    Settings.brick4 = MoveBrick(fromField, toField, Settings.brick4, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 15)
            {
                brickList = Settings.field15.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick4.Field.ToString()); }

                var canMoveResult = CanMoveBrick(15, Settings.brick4, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick4);
                    Settings.brick4 = MoveBrick(fromField, toField, Settings.brick4, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 16)
            {
                brickList = Settings.field16.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick4.Field.ToString()); }

                var canMoveResult = CanMoveBrick(16, Settings.brick4, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick4);
                    Settings.brick4 = MoveBrick(fromField, toField, Settings.brick4, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 17)
            {
                brickList = Settings.field17.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick4.Field.ToString()); }

                var canMoveResult = CanMoveBrick(17, Settings.brick4, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick4);
                    Settings.brick4 = MoveBrick(fromField, toField, Settings.brick4, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 18)
            {
                brickList = Settings.field18.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick4.Field.ToString()); }

                var canMoveResult = CanMoveBrick(18, Settings.brick4, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick4);
                    Settings.brick4 = MoveBrick(fromField, toField, Settings.brick4, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 19)
            {
                brickList = Settings.field19.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick4.Field.ToString()); }

                var canMoveResult = CanMoveBrick(19, Settings.brick4, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick4);
                    Settings.brick4 = MoveBrick(fromField, toField, Settings.brick4, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 20)
            {
                brickList = Settings.field20.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick4.Field.ToString()); }

                var canMoveResult = CanMoveBrick(20, Settings.brick4, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick4);
                    Settings.brick4 = MoveBrick(fromField, toField, Settings.brick4, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 21)
            {
                brickList = Settings.field21.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick4.Field.ToString()); }

                var canMoveResult = CanMoveBrick(21, Settings.brick4, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick4);
                    Settings.brick4 = MoveBrick(fromField, toField, Settings.brick4, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 22)
            {
                brickList = Settings.field22.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick4.Field.ToString()); }

                var canMoveResult = CanMoveBrick(22, Settings.brick4, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick4);
                    Settings.brick4 = MoveBrick(fromField, toField, Settings.brick4, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 23)
            {
                brickList = Settings.field23.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick4.Field.ToString()); }

                var canMoveResult = CanMoveBrick(23, Settings.brick4, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick4);
                    Settings.brick4 = MoveBrick(fromField, toField, Settings.brick4, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 24)
            {
                brickList = Settings.field24.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick4.Field.ToString()); }

                var canMoveResult = CanMoveBrick(24, Settings.brick4, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick4);
                    Settings.brick4 = MoveBrick(fromField, toField, Settings.brick4, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 25)
            {
                brickList = Settings.field25.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick4.Field.ToString()); }

                var canMoveResult = CanMoveBrick(25, Settings.brick4, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick4);
                    Settings.brick4 = MoveBrick(fromField, toField, Settings.brick4, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 26)
            {
                brickList = Settings.field26.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick4.Field.ToString()); }

                var canMoveResult = CanMoveBrick(26, Settings.brick4, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick4);
                    Settings.brick4 = MoveBrick(fromField, toField, Settings.brick4, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 27)
            {
                brickList = Settings.field27.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick4.Field.ToString()); }

                var canMoveResult = CanMoveBrick(27, Settings.brick4, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick4);
                    Settings.brick4 = MoveBrick(fromField, toField, Settings.brick4, brickList);

                    setLocationPictureBox();
                }
            }
        }

        private void pictureBoxWhite_5_Click(object sender, EventArgs e)
        {

            int fieldnr = Settings.brick5.Field;
            if (fieldnr == 0)
            {
                brickList = Settings.field0.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick5.Field.ToString()); }

                var canMoveResult = CanMoveBrick(0, Settings.brick5, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick5);
                    Settings.brick5 = MoveBrick(fromField, toField, Settings.brick5, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 1)
            {
                brickList = Settings.field1.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick5.Field.ToString()); }

                var canMoveResult = CanMoveBrick(1, Settings.brick5, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick5);
                    Settings.brick5 = MoveBrick(fromField, toField, Settings.brick5, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 2)
            {
                brickList = Settings.field2.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick5.Field.ToString()); }

                var canMoveResult = CanMoveBrick(2, Settings.brick5, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick5);
                    Settings.brick5 = MoveBrick(fromField, toField, Settings.brick5, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 3)
            {
                brickList = Settings.field3.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick5.Field.ToString()); }

                var canMoveResult = CanMoveBrick(3, Settings.brick5, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick5);
                    Settings.brick5 = MoveBrick(fromField, toField, Settings.brick5, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 4)
            {
                brickList = Settings.field4.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick5.Field.ToString()); }

                var canMoveResult = CanMoveBrick(4, Settings.brick5, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick5);
                    Settings.brick5 = MoveBrick(fromField, toField, Settings.brick5, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 5)
            {
                brickList = Settings.field5.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick5.Field.ToString()); }

                var canMoveResult = CanMoveBrick(5, Settings.brick5, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick5);
                    Settings.brick5 = MoveBrick(fromField, toField, Settings.brick5, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 6)
            {
                brickList = Settings.field6.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick5.Field.ToString()); }

                var canMoveResult = CanMoveBrick(6, Settings.brick5, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick5);
                    Settings.brick5 = MoveBrick(fromField, toField, Settings.brick5, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 7)
            {
                brickList = Settings.field7.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick5.Field.ToString()); }

                var canMoveResult = CanMoveBrick(7, Settings.brick5, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick5);
                    Settings.brick5 = MoveBrick(fromField, toField, Settings.brick5, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 8)
            {
                brickList = Settings.field8.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick5.Field.ToString()); }

                var canMoveResult = CanMoveBrick(8, Settings.brick5, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick5);
                    Settings.brick5 = MoveBrick(fromField, toField, Settings.brick5, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 9)
            {
                brickList = Settings.field9.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick5.Field.ToString()); }

                var canMoveResult = CanMoveBrick(9, Settings.brick5, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick5);
                    Settings.brick5 = MoveBrick(fromField, toField, Settings.brick5, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 10)
            {
                brickList = Settings.field10.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick5.Field.ToString()); }

                var canMoveResult = CanMoveBrick(10, Settings.brick5, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick5);
                    Settings.brick5 = MoveBrick(fromField, toField, Settings.brick5, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 11)
            {
                brickList = Settings.field11.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick5.Field.ToString()); }

                var canMoveResult = CanMoveBrick(11, Settings.brick5, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick5);
                    Settings.brick5 = MoveBrick(fromField, toField, Settings.brick5, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 12)
            {
                brickList = Settings.field12.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick5.Field.ToString()); }

                var canMoveResult = CanMoveBrick(12, Settings.brick5, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick5);
                    Settings.brick5 = MoveBrick(fromField, toField, Settings.brick5, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 13)
            {
                brickList = Settings.field13.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick5.Field.ToString()); }

                var canMoveResult = CanMoveBrick(13, Settings.brick5, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick5);
                    Settings.brick5 = MoveBrick(fromField, toField, Settings.brick5, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 14)
            {
                brickList = Settings.field14.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick5.Field.ToString()); }

                var canMoveResult = CanMoveBrick(14, Settings.brick5, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick5);
                    Settings.brick5 = MoveBrick(fromField, toField, Settings.brick5, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 15)
            {
                brickList = Settings.field15.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick5.Field.ToString()); }

                var canMoveResult = CanMoveBrick(15, Settings.brick5, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick5);
                    Settings.brick5 = MoveBrick(fromField, toField, Settings.brick5, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 16)
            {
                brickList = Settings.field16.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick5.Field.ToString()); }

                var canMoveResult = CanMoveBrick(16, Settings.brick5, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick5);
                    Settings.brick5 = MoveBrick(fromField, toField, Settings.brick5, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 17)
            {
                brickList = Settings.field17.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick5.Field.ToString()); }

                var canMoveResult = CanMoveBrick(17, Settings.brick5, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick5);
                    Settings.brick5 = MoveBrick(fromField, toField, Settings.brick5, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 18)
            {
                brickList = Settings.field18.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick5.Field.ToString()); }

                var canMoveResult = CanMoveBrick(18, Settings.brick5, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick5);
                    Settings.brick5 = MoveBrick(fromField, toField, Settings.brick5, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 19)
            {
                brickList = Settings.field19.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick5.Field.ToString()); }
                var canMoveResult = CanMoveBrick(19, Settings.brick5, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick5);
                    Settings.brick5 = MoveBrick(fromField, toField, Settings.brick5, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 20)
            {
                brickList = Settings.field20.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick5.Field.ToString()); }

                var canMoveResult = CanMoveBrick(20, Settings.brick5, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick5);
                    Settings.brick5 = MoveBrick(fromField, toField, Settings.brick5, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 21)
            {
                brickList = Settings.field21.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick5.Field.ToString()); }

                var canMoveResult = CanMoveBrick(21, Settings.brick5, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick5);
                    Settings.brick5 = MoveBrick(fromField, toField, Settings.brick5, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 22)
            {
                brickList = Settings.field22.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick5.Field.ToString()); }

                var canMoveResult = CanMoveBrick(22, Settings.brick5, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick5);
                    Settings.brick5 = MoveBrick(fromField, toField, Settings.brick5, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 23)
            {
                brickList = Settings.field23.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick5.Field.ToString()); }

                var canMoveResult = CanMoveBrick(23, Settings.brick5, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick5);
                    Settings.brick5 = MoveBrick(fromField, toField, Settings.brick5, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 24)
            {
                brickList = Settings.field24.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick5.Field.ToString()); }

                var canMoveResult = CanMoveBrick(24, Settings.brick5, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick5);
                    Settings.brick5 = MoveBrick(fromField, toField, Settings.brick5, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 25)
            {
                brickList = Settings.field25.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick5.Field.ToString()); }

                var canMoveResult = CanMoveBrick(25, Settings.brick5, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick5);
                    Settings.brick5 = MoveBrick(fromField, toField, Settings.brick5, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 26)
            {
                brickList = Settings.field26.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick5.Field.ToString()); }

                var canMoveResult = CanMoveBrick(26, Settings.brick5, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick5);
                    Settings.brick5 = MoveBrick(fromField, toField, Settings.brick5, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 27)
            {
                brickList = Settings.field27.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick5.Field.ToString()); }

                var canMoveResult = CanMoveBrick(27, Settings.brick5, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick5);
                    Settings.brick5 = MoveBrick(fromField, toField, Settings.brick5, brickList);

                    setLocationPictureBox();
                }
            }
        }

        private void pictureBoxWhite_6_Click(object sender, EventArgs e)
        {

            int fieldnr = Settings.brick6.Field;
            if (fieldnr == 0)
            {
                brickList = Settings.field0.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick6.Field.ToString()); }

                var canMoveResult = CanMoveBrick(0, Settings.brick6, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick6);
                    Settings.brick6 = MoveBrick(fromField, toField, Settings.brick6, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 1)
            {
                brickList = Settings.field1.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick6.Field.ToString()); }

                var canMoveResult = CanMoveBrick(1, Settings.brick6, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick6);
                    Settings.brick6 = MoveBrick(fromField, toField, Settings.brick6, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 2)
            {
                brickList = Settings.field2.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick6.Field.ToString()); }

                var canMoveResult = CanMoveBrick(2, Settings.brick6, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick6);
                    Settings.brick6 = MoveBrick(fromField, toField, Settings.brick6, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 3)
            {
                brickList = Settings.field3.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick6.Field.ToString()); }

                var canMoveResult = CanMoveBrick(3, Settings.brick6, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick6);
                    Settings.brick6 = MoveBrick(fromField, toField, Settings.brick6, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 4)
            {
                brickList = Settings.field4.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick6.Field.ToString()); }

                var canMoveResult = CanMoveBrick(4, Settings.brick6, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick6);
                    Settings.brick6 = MoveBrick(fromField, toField, Settings.brick6, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 5)
            {
                brickList = Settings.field5.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick6.Field.ToString()); }

                var canMoveResult = CanMoveBrick(5, Settings.brick6, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick6);
                    Settings.brick6 = MoveBrick(fromField, toField, Settings.brick6, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 6)
            {
                brickList = Settings.field6.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick6.Field.ToString()); }

                var canMoveResult = CanMoveBrick(6, Settings.brick6, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick6);
                    Settings.brick6 = MoveBrick(fromField, toField, Settings.brick6, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 7)
            {
                brickList = Settings.field7.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick6.Field.ToString()); }

                var canMoveResult = CanMoveBrick(7, Settings.brick6, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick6);
                    Settings.brick6 = MoveBrick(fromField, toField, Settings.brick6, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 8)
            {
                brickList = Settings.field8.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick6.Field.ToString()); }

                var canMoveResult = CanMoveBrick(8, Settings.brick6, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick6);
                    Settings.brick6 = MoveBrick(fromField, toField, Settings.brick6, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 9)
            {
                brickList = Settings.field9.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick6.Field.ToString()); }

                var canMoveResult = CanMoveBrick(9, Settings.brick6, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick6);
                    Settings.brick6 = MoveBrick(fromField, toField, Settings.brick6, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 10)
            {
                brickList = Settings.field10.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick6.Field.ToString()); }

                var canMoveResult = CanMoveBrick(10, Settings.brick6, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick6);
                    Settings.brick6 = MoveBrick(fromField, toField, Settings.brick6, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 11)
            {
                brickList = Settings.field11.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick6.Field.ToString()); }

                var canMoveResult = CanMoveBrick(11, Settings.brick6, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick6);
                    Settings.brick6 = MoveBrick(fromField, toField, Settings.brick6, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 12)
            {
                brickList = Settings.field12.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick6.Field.ToString()); }

                var canMoveResult = CanMoveBrick(12, Settings.brick6, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick6);
                    Settings.brick6 = MoveBrick(fromField, toField, Settings.brick6, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 13)
            {
                brickList = Settings.field13.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick6.Field.ToString()); }

                var canMoveResult = CanMoveBrick(13, Settings.brick6, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick6);
                    Settings.brick6 = MoveBrick(fromField, toField, Settings.brick6, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 14)
            {
                brickList = Settings.field14.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick6.Field.ToString()); }

                var canMoveResult = CanMoveBrick(14, Settings.brick6, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick6);
                    Settings.brick6 = MoveBrick(fromField, toField, Settings.brick6, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 15)
            {
                brickList = Settings.field15.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick6.Field.ToString()); }

                var canMoveResult = CanMoveBrick(15, Settings.brick6, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick6);
                    Settings.brick6 = MoveBrick(fromField, toField, Settings.brick6, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 16)
            {
                brickList = Settings.field16.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick6.Field.ToString()); }

                var canMoveResult = CanMoveBrick(16, Settings.brick6, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick6);
                    Settings.brick6 = MoveBrick(fromField, toField, Settings.brick6, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 17)
            {
                brickList = Settings.field17.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick6.Field.ToString()); }

                var canMoveResult = CanMoveBrick(17, Settings.brick6, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick6);
                    Settings.brick6 = MoveBrick(fromField, toField, Settings.brick6, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 18)
            {
                brickList = Settings.field18.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick6.Field.ToString()); }

                var canMoveResult = CanMoveBrick(18, Settings.brick6, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick6);
                    Settings.brick6 = MoveBrick(fromField, toField, Settings.brick6, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 19)
            {
                brickList = Settings.field19.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick6.Field.ToString()); }

                var canMoveResult = CanMoveBrick(19, Settings.brick6, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick6);
                    Settings.brick6 = MoveBrick(fromField, toField, Settings.brick6, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 20)
            {
                brickList = Settings.field20.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick6.Field.ToString()); }

                var canMoveResult = CanMoveBrick(20, Settings.brick6, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick6);
                    Settings.brick6 = MoveBrick(fromField, toField, Settings.brick6, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 21)
            {
                brickList = Settings.field21.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick6.Field.ToString()); }

                var canMoveResult = CanMoveBrick(21, Settings.brick6, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick6);
                    Settings.brick6 = MoveBrick(fromField, toField, Settings.brick6, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 22)
            {
                brickList = Settings.field22.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick6.Field.ToString()); }

                var canMoveResult = CanMoveBrick(22, Settings.brick6, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick6);
                    Settings.brick6 = MoveBrick(fromField, toField, Settings.brick6, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 23)
            {
                brickList = Settings.field23.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick6.Field.ToString()); }

                var canMoveResult = CanMoveBrick(23, Settings.brick6, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick6);
                    Settings.brick6 = MoveBrick(fromField, toField, Settings.brick6, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 24)
            {
                brickList = Settings.field24.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick6.Field.ToString()); }

                var canMoveResult = CanMoveBrick(24, Settings.brick6, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick6);
                    Settings.brick6 = MoveBrick(fromField, toField, Settings.brick6, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 25)
            {
                brickList = Settings.field25.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick6.Field.ToString()); }

                var canMoveResult = CanMoveBrick(25, Settings.brick6, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick6);
                    Settings.brick6 = MoveBrick(fromField, toField, Settings.brick6, brickList);

                    setLocationPictureBox();
                }

            }
            if (fieldnr == 26)
            {
                brickList = Settings.field26.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick6.Field.ToString()); }

                var canMoveResult = CanMoveBrick(26, Settings.brick6, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick6);
                    Settings.brick6 = MoveBrick(fromField, toField, Settings.brick6, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 27)
            {
                brickList = Settings.field27.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick6.Field.ToString()); }

                var canMoveResult = CanMoveBrick(27, Settings.brick6, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick6);
                    Settings.brick6 = MoveBrick(fromField, toField, Settings.brick6, brickList);

                    setLocationPictureBox();
                }
            }
        }

        private void pictureBoxWhite_7_Click(object sender, EventArgs e)
        {

            int fieldnr = Settings.brick7.Field;
            if (fieldnr == 0)
            {
                brickList = Settings.field0.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick7.Field.ToString()); }

                var canMoveResult = CanMoveBrick(0, Settings.brick7, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick7);
                    Settings.brick7 = MoveBrick(fromField, toField, Settings.brick7, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 1)
            {
                brickList = Settings.field1.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick7.Field.ToString()); }

                var canMoveResult = CanMoveBrick(1, Settings.brick7, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick7);
                    Settings.brick7 = MoveBrick(fromField, toField, Settings.brick7, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 2)
            {
                brickList = Settings.field2.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick7.Field.ToString()); }

                var canMoveResult = CanMoveBrick(2, Settings.brick7, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick7);
                    Settings.brick7 = MoveBrick(fromField, toField, Settings.brick7, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 3)
            {
                brickList = Settings.field3.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick7.Field.ToString()); }

                var canMoveResult = CanMoveBrick(3, Settings.brick7, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick7);
                    Settings.brick7 = MoveBrick(fromField, toField, Settings.brick7, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 4)
            {
                brickList = Settings.field4.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick7.Field.ToString()); }

                var canMoveResult = CanMoveBrick(4, Settings.brick7, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick7);
                    Settings.brick7 = MoveBrick(fromField, toField, Settings.brick7, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 5)
            {
                brickList = Settings.field5.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick7.Field.ToString()); }

                var canMoveResult = CanMoveBrick(5, Settings.brick7, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick7);
                    Settings.brick7 = MoveBrick(fromField, toField, Settings.brick7, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 6)
            {
                brickList = Settings.field6.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick7.Field.ToString()); }

                var canMoveResult = CanMoveBrick(6, Settings.brick7, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick7);
                    Settings.brick7 = MoveBrick(fromField, toField, Settings.brick7, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 7)
            {
                brickList = Settings.field7.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick7.Field.ToString()); }

                var canMoveResult = CanMoveBrick(7, Settings.brick7, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick7);
                    Settings.brick7 = MoveBrick(fromField, toField, Settings.brick7, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 8)
            {
                brickList = Settings.field8.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick7.Field.ToString()); }

                var canMoveResult = CanMoveBrick(8, Settings.brick7, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick7);
                    Settings.brick7 = MoveBrick(fromField, toField, Settings.brick7, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 9)
            {
                brickList = Settings.field9.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick7.Field.ToString()); }

                var canMoveResult = CanMoveBrick(9, Settings.brick7, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick7);
                    Settings.brick7 = MoveBrick(fromField, toField, Settings.brick7, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 10)
            {
                brickList = Settings.field10.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick7.Field.ToString()); }

                var canMoveResult = CanMoveBrick(10, Settings.brick7, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick7);
                    Settings.brick7 = MoveBrick(fromField, toField, Settings.brick7, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 11)
            {
                brickList = Settings.field11.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick7.Field.ToString()); }

                var canMoveResult = CanMoveBrick(11, Settings.brick7, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick7);
                    Settings.brick7 = MoveBrick(fromField, toField, Settings.brick7, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 12)
            {
                brickList = Settings.field12.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick7.Field.ToString()); }

                var canMoveResult = CanMoveBrick(12, Settings.brick7, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick7);
                    Settings.brick7 = MoveBrick(fromField, toField, Settings.brick7, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 13)
            {
                brickList = Settings.field13.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick7.Field.ToString()); }

                var canMoveResult = CanMoveBrick(13, Settings.brick7, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick7);
                    Settings.brick7 = MoveBrick(fromField, toField, Settings.brick7, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 14)
            {
                brickList = Settings.field14.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick7.Field.ToString()); }

                var canMoveResult = CanMoveBrick(14, Settings.brick7, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick7);
                    Settings.brick7 = MoveBrick(fromField, toField, Settings.brick7, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 15)
            {
                brickList = Settings.field15.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick7.Field.ToString()); }

                var canMoveResult = CanMoveBrick(15, Settings.brick7, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick7);
                    Settings.brick7 = MoveBrick(fromField, toField, Settings.brick7, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 16)
            {
                brickList = Settings.field16.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick7.Field.ToString()); }

                var canMoveResult = CanMoveBrick(16, Settings.brick7, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick7);
                    Settings.brick7 = MoveBrick(fromField, toField, Settings.brick7, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 17)
            {
                brickList = Settings.field17.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick7.Field.ToString()); }

                var canMoveResult = CanMoveBrick(17, Settings.brick7, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick7);
                    Settings.brick7 = MoveBrick(fromField, toField, Settings.brick7, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 18)
            {
                brickList = Settings.field18.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick7.Field.ToString()); }

                var canMoveResult = CanMoveBrick(18, Settings.brick7, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick7);
                    Settings.brick7 = MoveBrick(fromField, toField, Settings.brick7, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 19)
            {
                brickList = Settings.field19.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick7.Field.ToString()); }

                var canMoveResult = CanMoveBrick(19, Settings.brick7, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick7);
                    Settings.brick7 = MoveBrick(fromField, toField, Settings.brick7, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 20)
            {
                brickList = Settings.field20.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick7.Field.ToString()); }

                var canMoveResult = CanMoveBrick(20, Settings.brick7, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick7);
                    Settings.brick7 = MoveBrick(fromField, toField, Settings.brick7, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 21)
            {
                brickList = Settings.field21.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick7.Field.ToString()); }

                var canMoveResult = CanMoveBrick(21, Settings.brick7, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick7);
                    Settings.brick7 = MoveBrick(fromField, toField, Settings.brick7, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 22)
            {
                brickList = Settings.field22.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick7.Field.ToString()); }

                var canMoveResult = CanMoveBrick(22, Settings.brick7, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick7);
                    Settings.brick7 = MoveBrick(fromField, toField, Settings.brick7, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 23)
            {
                brickList = Settings.field23.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick7.Field.ToString()); }

                var canMoveResult = CanMoveBrick(23, Settings.brick7, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick7);
                    Settings.brick7 = MoveBrick(fromField, toField, Settings.brick7, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 24)
            {
                brickList = Settings.field24.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick7.Field.ToString()); }

                var canMoveResult = CanMoveBrick(24, Settings.brick7, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick7);
                    Settings.brick7 = MoveBrick(fromField, toField, Settings.brick7, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 25)
            {
                brickList = Settings.field25.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick7.Field.ToString()); }

                var canMoveResult = CanMoveBrick(25, Settings.brick7, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick7);
                    Settings.brick7 = MoveBrick(fromField, toField, Settings.brick7, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 26)
            {
                brickList = Settings.field26.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick7.Field.ToString()); }

                var canMoveResult = CanMoveBrick(26, Settings.brick7, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick7);
                    Settings.brick7 = MoveBrick(fromField, toField, Settings.brick7, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 27)
            {
                brickList = Settings.field27.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick7.Field.ToString()); }

                var canMoveResult = CanMoveBrick(27, Settings.brick7, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick7);
                    Settings.brick7 = MoveBrick(fromField, toField, Settings.brick7, brickList);

                    setLocationPictureBox();
                }
            }
        }

        private void pictureBoxWhite_8_Click(object sender, EventArgs e)
        {

            int fieldnr = Settings.brick8.Field;
            if (fieldnr == 0)
            {
                brickList = Settings.field0.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick8.Field.ToString()); }

                var canMoveResult = CanMoveBrick(0, Settings.brick7, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick8);
                    Settings.brick8 = MoveBrick(fromField, toField, Settings.brick8, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 1)
            {
                brickList = Settings.field1.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick8.Field.ToString()); }

                var canMoveResult = CanMoveBrick(1, Settings.brick7, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick8);
                    Settings.brick8 = MoveBrick(fromField, toField, Settings.brick8, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 2)
            {
                brickList = Settings.field2.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick8.Field.ToString()); }

                var canMoveResult = CanMoveBrick(2, Settings.brick7, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick8);
                    Settings.brick8 = MoveBrick(fromField, toField, Settings.brick8, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 3)
            {
                brickList = Settings.field3.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick8.Field.ToString()); }

                var canMoveResult = CanMoveBrick(3, Settings.brick7, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick8);
                    Settings.brick8 = MoveBrick(fromField, toField, Settings.brick8, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 4)
            {
                brickList = Settings.field4.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick8.Field.ToString()); }

                var canMoveResult = CanMoveBrick(4, Settings.brick7, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick8);
                    Settings.brick8 = MoveBrick(fromField, toField, Settings.brick8, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 5)
            {
                brickList = Settings.field5.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick8.Field.ToString()); }

                var canMoveResult = CanMoveBrick(5, Settings.brick7, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick8);
                    Settings.brick8 = MoveBrick(fromField, toField, Settings.brick8, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 6)
            {
                brickList = Settings.field6.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick8.Field.ToString()); }

                var canMoveResult = CanMoveBrick(6, Settings.brick7, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick8);
                    Settings.brick8 = MoveBrick(fromField, toField, Settings.brick8, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 7)
            {
                brickList = Settings.field7.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick8.Field.ToString()); }

                var canMoveResult = CanMoveBrick(7, Settings.brick7, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick8);
                    Settings.brick8 = MoveBrick(fromField, toField, Settings.brick8, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 8)
            {
                brickList = Settings.field8.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick8.Field.ToString()); }

                var canMoveResult = CanMoveBrick(8, Settings.brick7, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick8);
                    Settings.brick8 = MoveBrick(fromField, toField, Settings.brick8, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 9)
            {
                brickList = Settings.field9.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick8.Field.ToString()); }

                var canMoveResult = CanMoveBrick(9, Settings.brick7, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick8);
                    Settings.brick8 = MoveBrick(fromField, toField, Settings.brick8, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 10)
            {
                brickList = Settings.field10.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick8.Field.ToString()); }

                var canMoveResult = CanMoveBrick(10, Settings.brick7, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick8);
                    Settings.brick8 = MoveBrick(fromField, toField, Settings.brick8, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 11)
            {
                brickList = Settings.field11.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick8.Field.ToString()); }

                var canMoveResult = CanMoveBrick(11, Settings.brick7, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick8);
                    Settings.brick8 = MoveBrick(fromField, toField, Settings.brick8, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 12)
            {
                brickList = Settings.field12.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick8.Field.ToString()); }

                var canMoveResult = CanMoveBrick(12, Settings.brick7, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick8);
                    Settings.brick8 = MoveBrick(fromField, toField, Settings.brick8, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 13)
            {
                brickList = Settings.field13.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick8.Field.ToString()); }

                var canMoveResult = CanMoveBrick(13, Settings.brick7, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick8);
                    Settings.brick8 = MoveBrick(fromField, toField, Settings.brick8, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 14)
            {
                brickList = Settings.field14.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick8.Field.ToString()); }

                var canMoveResult = CanMoveBrick(14, Settings.brick7, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick8);
                    Settings.brick8 = MoveBrick(fromField, toField, Settings.brick8, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 15)
            {
                brickList = Settings.field15.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick8.Field.ToString()); }

                var canMoveResult = CanMoveBrick(15, Settings.brick7, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick8);
                    Settings.brick8 = MoveBrick(fromField, toField, Settings.brick8, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 16)
            {
                brickList = Settings.field16.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick8.Field.ToString()); }

                var canMoveResult = CanMoveBrick(16, Settings.brick7, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick8);
                    Settings.brick8 = MoveBrick(fromField, toField, Settings.brick8, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 17)
            {
                brickList = Settings.field17.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick8.Field.ToString()); }

                var canMoveResult = CanMoveBrick(17, Settings.brick7, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick8);
                    Settings.brick8 = MoveBrick(fromField, toField, Settings.brick8, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 18)
            {
                brickList = Settings.field18.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick8.Field.ToString()); }

                var canMoveResult = CanMoveBrick(18, Settings.brick7, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick8);
                    Settings.brick8 = MoveBrick(fromField, toField, Settings.brick8, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 19)
            {
                brickList = Settings.field19.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick8.Field.ToString()); }

                var canMoveResult = CanMoveBrick(19, Settings.brick7, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick8);
                    Settings.brick8 = MoveBrick(fromField, toField, Settings.brick8, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 20)
            {
                brickList = Settings.field20.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick8.Field.ToString()); }

                var canMoveResult = CanMoveBrick(20, Settings.brick7, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick8);
                    Settings.brick8 = MoveBrick(fromField, toField, Settings.brick8, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 21)
            {
                brickList = Settings.field21.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick8.Field.ToString()); }

                var canMoveResult = CanMoveBrick(21, Settings.brick7, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick8);
                    Settings.brick8 = MoveBrick(fromField, toField, Settings.brick8, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 22)
            {
                brickList = Settings.field22.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick8.Field.ToString()); }

                var canMoveResult = CanMoveBrick(22, Settings.brick7, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick8);
                    Settings.brick8 = MoveBrick(fromField, toField, Settings.brick8, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 23)
            {
                brickList = Settings.field23.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick8.Field.ToString()); }

                var canMoveResult = CanMoveBrick(23, Settings.brick7, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick8);
                    Settings.brick8 = MoveBrick(fromField, toField, Settings.brick8, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 24)
            {
                brickList = Settings.field24.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick8.Field.ToString()); }

                var canMoveResult = CanMoveBrick(24, Settings.brick7, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick8);
                    Settings.brick8 = MoveBrick(fromField, toField, Settings.brick8, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 25)
            {
                brickList = Settings.field25.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick8.Field.ToString()); }

                var canMoveResult = CanMoveBrick(25, Settings.brick7, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick8);
                    Settings.brick8 = MoveBrick(fromField, toField, Settings.brick8, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 26)
            {
                brickList = Settings.field26.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick8.Field.ToString()); }

                var canMoveResult = CanMoveBrick(26, Settings.brick7, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick8);
                    Settings.brick8 = MoveBrick(fromField, toField, Settings.brick8, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 27)
            {
                brickList = Settings.field27.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick8.Field.ToString()); }

                var canMoveResult = CanMoveBrick(27, Settings.brick7, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick8);
                    Settings.brick8 = MoveBrick(fromField, toField, Settings.brick8, brickList);

                    setLocationPictureBox();
                }
            }
        }

        private void pictureBoxWhite_9_Click(object sender, EventArgs e)
        {

            int fieldnr = Settings.brick9.Field;
            if (fieldnr == 0)
            {
                brickList = Settings.field0.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick9.Field.ToString()); }

                var canMoveResult = CanMoveBrick(0, Settings.brick9, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick9);
                    Settings.brick9 = MoveBrick(fromField, toField, Settings.brick9, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 1)
            {
                brickList = Settings.field1.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick9.Field.ToString()); }

                var canMoveResult = CanMoveBrick(1, Settings.brick9, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick9);
                    Settings.brick9 = MoveBrick(fromField, toField, Settings.brick9, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 2)
            {
                brickList = Settings.field2.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick9.Field.ToString()); }

                var canMoveResult = CanMoveBrick(2, Settings.brick9, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick9);
                    Settings.brick9 = MoveBrick(fromField, toField, Settings.brick9, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 3)
            {
                brickList = Settings.field3.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick9.Field.ToString()); }

                var canMoveResult = CanMoveBrick(3, Settings.brick9, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick9);
                    Settings.brick9 = MoveBrick(fromField, toField, Settings.brick9, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 4)
            {
                brickList = Settings.field4.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick9.Field.ToString()); }

                var canMoveResult = CanMoveBrick(4, Settings.brick9, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick9);
                    Settings.brick9 = MoveBrick(fromField, toField, Settings.brick9, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 5)
            {
                brickList = Settings.field5.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick9.Field.ToString()); }

                var canMoveResult = CanMoveBrick(5, Settings.brick9, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick9);
                    Settings.brick9 = MoveBrick(fromField, toField, Settings.brick9, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 6)
            {
                brickList = Settings.field6.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick9.Field.ToString()); }

                var canMoveResult = CanMoveBrick(6, Settings.brick9, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick9);
                    Settings.brick9 = MoveBrick(fromField, toField, Settings.brick9, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 7)
            {
                brickList = Settings.field7.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick9.Field.ToString()); }

                var canMoveResult = CanMoveBrick(7, Settings.brick9, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick9);
                    Settings.brick9 = MoveBrick(fromField, toField, Settings.brick9, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 8)
            {
                brickList = Settings.field8.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick9.Field.ToString()); }

                var canMoveResult = CanMoveBrick(8, Settings.brick9, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick9);
                    Settings.brick9 = MoveBrick(fromField, toField, Settings.brick9, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 9)
            {
                brickList = Settings.field9.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick9.Field.ToString()); }

                var canMoveResult = CanMoveBrick(9, Settings.brick9, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick9);
                    Settings.brick9 = MoveBrick(fromField, toField, Settings.brick9, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 10)
            {
                brickList = Settings.field10.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick9.Field.ToString()); }

                var canMoveResult = CanMoveBrick(10, Settings.brick9, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick9);
                    Settings.brick9 = MoveBrick(fromField, toField, Settings.brick9, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 11)
            {
                brickList = Settings.field11.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick9.Field.ToString()); }

                var canMoveResult = CanMoveBrick(11, Settings.brick9, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick9);
                    Settings.brick9 = MoveBrick(fromField, toField, Settings.brick9, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 12)
            {
                brickList = Settings.field12.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick9.Field.ToString()); }

                var canMoveResult = CanMoveBrick(12, Settings.brick9, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick9);
                    Settings.brick9 = MoveBrick(fromField, toField, Settings.brick9, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 13)
            {
                brickList = Settings.field13.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick9.Field.ToString()); }

                var canMoveResult = CanMoveBrick(13, Settings.brick9, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick9);
                    Settings.brick9 = MoveBrick(fromField, toField, Settings.brick9, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 14)
            {
                brickList = Settings.field14.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick9.Field.ToString()); }

                var canMoveResult = CanMoveBrick(14, Settings.brick9, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick9);
                    Settings.brick9 = MoveBrick(fromField, toField, Settings.brick9, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 15)
            {
                brickList = Settings.field15.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick9.Field.ToString()); }

                var canMoveResult = CanMoveBrick(15, Settings.brick9, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick9);
                    Settings.brick9 = MoveBrick(fromField, toField, Settings.brick9, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 16)
            {
                brickList = Settings.field16.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick9.Field.ToString()); }

                var canMoveResult = CanMoveBrick(16, Settings.brick9, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick9);
                    Settings.brick9 = MoveBrick(fromField, toField, Settings.brick9, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 17)
            {
                brickList = Settings.field17.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick9.Field.ToString()); }

                var canMoveResult = CanMoveBrick(17, Settings.brick9, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick9);
                    Settings.brick9 = MoveBrick(fromField, toField, Settings.brick9, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 18)
            {
                brickList = Settings.field18.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick9.Field.ToString()); }

                var canMoveResult = CanMoveBrick(18, Settings.brick9, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick9);
                    Settings.brick9 = MoveBrick(fromField, toField, Settings.brick9, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 19)
            {
                brickList = Settings.field19.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick9.Field.ToString()); }

                var canMoveResult = CanMoveBrick(19, Settings.brick9, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick9);
                    Settings.brick9 = MoveBrick(fromField, toField, Settings.brick9, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 20)
            {
                brickList = Settings.field20.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick9.Field.ToString()); }

                var canMoveResult = CanMoveBrick(20, Settings.brick9, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick9);
                    Settings.brick9 = MoveBrick(fromField, toField, Settings.brick9, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 21)
            {
                brickList = Settings.field21.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick9.Field.ToString()); }

                var canMoveResult = CanMoveBrick(21, Settings.brick9, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick9);
                    Settings.brick9 = MoveBrick(fromField, toField, Settings.brick9, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 22)
            {
                brickList = Settings.field22.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick9.Field.ToString()); }

                var canMoveResult = CanMoveBrick(22, Settings.brick9, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick9);
                    Settings.brick9 = MoveBrick(fromField, toField, Settings.brick9, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 23)
            {
                brickList = Settings.field23.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick9.Field.ToString()); }

                var canMoveResult = CanMoveBrick(22, Settings.brick9, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick9);
                    Settings.brick9 = MoveBrick(fromField, toField, Settings.brick9, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 24)
            {
                brickList = Settings.field24.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick9.Field.ToString()); }

                var canMoveResult = CanMoveBrick(24, Settings.brick9, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick9);
                    Settings.brick9 = MoveBrick(fromField, toField, Settings.brick9, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 25)
            {
                brickList = Settings.field25.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick9.Field.ToString()); }

                var canMoveResult = CanMoveBrick(25, Settings.brick9, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick9);
                    Settings.brick9 = MoveBrick(fromField, toField, Settings.brick9, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 26)
            {
                brickList = Settings.field26.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick9.Field.ToString()); }

                var canMoveResult = CanMoveBrick(26, Settings.brick9, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick9);
                    Settings.brick9 = MoveBrick(fromField, toField, Settings.brick9, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 27)
            {
                brickList = Settings.field27.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick9.Field.ToString()); }

                var canMoveResult = CanMoveBrick(27, Settings.brick9, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick9);
                    Settings.brick9 = MoveBrick(fromField, toField, Settings.brick9, brickList);

                    setLocationPictureBox();
                }
            }
        }

        private void pictureBoxWhite_10_Click(object sender, EventArgs e)
        {

            int fieldnr = Settings.brick10.Field;
            if (fieldnr == 0)
            {
                brickList = Settings.field0.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick10.Field.ToString()); }

                var canMoveResult = CanMoveBrick(0, Settings.brick10, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick10);
                    Settings.brick10 = MoveBrick(fromField, toField, Settings.brick10, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 1)
            {
                brickList = Settings.field1.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick10.Field.ToString()); }

                var canMoveResult = CanMoveBrick(1, Settings.brick10, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick10);
                    Settings.brick10 = MoveBrick(fromField, toField, Settings.brick10, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 2)
            {
                brickList = Settings.field2.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick10.Field.ToString()); }

                var canMoveResult = CanMoveBrick(2, Settings.brick10, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick10);
                    Settings.brick10 = MoveBrick(fromField, toField, Settings.brick10, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 3)
            {
                brickList = Settings.field3.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick10.Field.ToString()); }

                var canMoveResult = CanMoveBrick(3, Settings.brick10, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick10);
                    Settings.brick10 = MoveBrick(fromField, toField, Settings.brick10, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 4)
            {
                brickList = Settings.field4.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick10.Field.ToString()); }

                var canMoveResult = CanMoveBrick(4, Settings.brick10, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick10);
                    Settings.brick10 = MoveBrick(fromField, toField, Settings.brick10, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 5)
            {
                brickList = Settings.field5.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick10.Field.ToString()); }

                var canMoveResult = CanMoveBrick(5, Settings.brick10, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick10);
                    Settings.brick10 = MoveBrick(fromField, toField, Settings.brick10, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 6)
            {
                brickList = Settings.field6.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick10.Field.ToString()); }

                var canMoveResult = CanMoveBrick(6, Settings.brick10, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick10);
                    Settings.brick10 = MoveBrick(fromField, toField, Settings.brick10, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 7)
            {
                brickList = Settings.field7.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick10.Field.ToString()); }

                var canMoveResult = CanMoveBrick(7, Settings.brick10, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick10);
                    Settings.brick10 = MoveBrick(fromField, toField, Settings.brick10, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 8)
            {
                brickList = Settings.field8.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick10.Field.ToString()); }

                var canMoveResult = CanMoveBrick(8, Settings.brick10, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick10);
                    Settings.brick10 = MoveBrick(fromField, toField, Settings.brick10, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 9)
            {
                brickList = Settings.field9.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick10.Field.ToString()); }

                var canMoveResult = CanMoveBrick(9, Settings.brick10, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick10);
                    Settings.brick10 = MoveBrick(fromField, toField, Settings.brick10, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 10)
            {
                brickList = Settings.field10.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick10.Field.ToString()); }

                var canMoveResult = CanMoveBrick(10, Settings.brick10, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick10);
                    Settings.brick10 = MoveBrick(fromField, toField, Settings.brick10, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 11)
            {
                brickList = Settings.field11.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick10.Field.ToString()); }

                var canMoveResult = CanMoveBrick(11, Settings.brick10, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick10);
                    Settings.brick10 = MoveBrick(fromField, toField, Settings.brick10, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 12)
            {
                brickList = Settings.field12.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick10.Field.ToString()); }

                var canMoveResult = CanMoveBrick(12, Settings.brick10, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick10);
                    Settings.brick10 = MoveBrick(fromField, toField, Settings.brick10, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 13)
            {
                brickList = Settings.field13.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick10.Field.ToString()); }

                var canMoveResult = CanMoveBrick(13, Settings.brick10, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick10);
                    Settings.brick10 = MoveBrick(fromField, toField, Settings.brick10, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 14)
            {
                brickList = Settings.field14.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick10.Field.ToString()); }

                var canMoveResult = CanMoveBrick(14, Settings.brick10, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick10);
                    Settings.brick10 = MoveBrick(fromField, toField, Settings.brick10, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 15)
            {
                brickList = Settings.field15.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick10.Field.ToString()); }

                var canMoveResult = CanMoveBrick(15, Settings.brick10, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick10);
                    Settings.brick10 = MoveBrick(fromField, toField, Settings.brick10, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 16)
            {
                brickList = Settings.field16.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick10.Field.ToString()); }

                var canMoveResult = CanMoveBrick(16, Settings.brick10, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick10);
                    Settings.brick10 = MoveBrick(fromField, toField, Settings.brick10, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 17)
            {
                brickList = Settings.field17.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick10.Field.ToString()); }

                var canMoveResult = CanMoveBrick(17, Settings.brick10, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick10);
                    Settings.brick10 = MoveBrick(fromField, toField, Settings.brick10, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 18)
            {
                brickList = Settings.field18.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick10.Field.ToString()); }

                var canMoveResult = CanMoveBrick(18, Settings.brick10, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick10);
                    Settings.brick10 = MoveBrick(fromField, toField, Settings.brick10, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 19)
            {
                brickList = Settings.field19.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick10.Field.ToString()); }

                var canMoveResult = CanMoveBrick(19, Settings.brick10, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick10);
                    Settings.brick10 = MoveBrick(fromField, toField, Settings.brick10, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 20)
            {
                brickList = Settings.field20.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick10.Field.ToString()); }

                var canMoveResult = CanMoveBrick(20, Settings.brick10, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick10);
                    Settings.brick10 = MoveBrick(fromField, toField, Settings.brick10, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 21)
            {
                brickList = Settings.field21.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick10.Field.ToString()); }

                var canMoveResult = CanMoveBrick(21, Settings.brick10, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick10);
                    Settings.brick10 = MoveBrick(fromField, toField, Settings.brick10, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 22)
            {
                brickList = Settings.field22.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick10.Field.ToString()); }

                var canMoveResult = CanMoveBrick(22, Settings.brick10, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick10);
                    Settings.brick10 = MoveBrick(fromField, toField, Settings.brick10, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 23)
            {
                brickList = Settings.field23.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick10.Field.ToString()); }

                var canMoveResult = CanMoveBrick(23, Settings.brick10, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick10);
                    Settings.brick10 = MoveBrick(fromField, toField, Settings.brick10, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 24)
            {
                brickList = Settings.field24.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick10.Field.ToString()); }

                var canMoveResult = CanMoveBrick(24, Settings.brick10, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick10);
                    Settings.brick10 = MoveBrick(fromField, toField, Settings.brick10, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 25)
            {
                brickList = Settings.field25.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick10.Field.ToString()); }

                var canMoveResult = CanMoveBrick(25, Settings.brick10, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick10);
                    Settings.brick10 = MoveBrick(fromField, toField, Settings.brick10, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 26)
            {
                brickList = Settings.field26.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick10.Field.ToString()); }

                var canMoveResult = CanMoveBrick(26, Settings.brick10, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick10);
                    Settings.brick10 = MoveBrick(fromField, toField, Settings.brick10, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 27)
            {
                brickList = Settings.field27.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick10.Field.ToString()); }

                var canMoveResult = CanMoveBrick(27, Settings.brick10, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick10);
                    Settings.brick10 = MoveBrick(fromField, toField, Settings.brick10, brickList);

                    setLocationPictureBox();
                }
            }
        }

        private void pictureBoxWhite_11_Click(object sender, EventArgs e)
        {

            int fieldnr = Settings.brick11.Field;
            if (fieldnr == 0)
            {
                brickList = Settings.field0.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick11.Field.ToString()); }

                var canMoveResult = CanMoveBrick(0, Settings.brick11, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick11);
                    Settings.brick11 = MoveBrick(fromField, toField, Settings.brick11, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 1)
            {
                brickList = Settings.field1.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick11.Field.ToString()); }

                var canMoveResult = CanMoveBrick(1, Settings.brick11, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick11);
                    Settings.brick11 = MoveBrick(fromField, toField, Settings.brick11, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 2)
            {
                brickList = Settings.field2.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick11.Field.ToString()); }

                var canMoveResult = CanMoveBrick(2, Settings.brick11, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick11);
                    Settings.brick11 = MoveBrick(fromField, toField, Settings.brick11, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 3)
            {
                brickList = Settings.field3.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick11.Field.ToString()); }

                var canMoveResult = CanMoveBrick(3, Settings.brick11, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick11);
                    Settings.brick11 = MoveBrick(fromField, toField, Settings.brick11, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 4)
            {
                brickList = Settings.field4.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick11.Field.ToString()); }

                var canMoveResult = CanMoveBrick(4, Settings.brick11, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick11);
                    Settings.brick11 = MoveBrick(fromField, toField, Settings.brick11, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 5)
            {
                brickList = Settings.field5.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick11.Field.ToString()); }

                var canMoveResult = CanMoveBrick(5, Settings.brick11, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick11);
                    Settings.brick11 = MoveBrick(fromField, toField, Settings.brick11, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 6)
            {
                brickList = Settings.field6.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick11.Field.ToString()); }

                var canMoveResult = CanMoveBrick(6, Settings.brick11, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick11);
                    Settings.brick11 = MoveBrick(fromField, toField, Settings.brick11, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 7)
            {
                brickList = Settings.field7.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick11.Field.ToString()); }

                var canMoveResult = CanMoveBrick(7, Settings.brick11, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick11);
                    Settings.brick11 = MoveBrick(fromField, toField, Settings.brick11, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 8)
            {
                brickList = Settings.field8.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick11.Field.ToString()); }

                var canMoveResult = CanMoveBrick(8, Settings.brick11, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick11);
                    Settings.brick11 = MoveBrick(fromField, toField, Settings.brick11, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 9)
            {
                brickList = Settings.field9.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick11.Field.ToString()); }

                var canMoveResult = CanMoveBrick(9, Settings.brick11, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick11);
                    Settings.brick11 = MoveBrick(fromField, toField, Settings.brick11, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 10)
            {
                brickList = Settings.field10.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick11.Field.ToString()); }

                var canMoveResult = CanMoveBrick(10, Settings.brick11, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick11);
                    Settings.brick11 = MoveBrick(fromField, toField, Settings.brick11, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 11)
            {
                brickList = Settings.field11.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick11.Field.ToString()); }

                var canMoveResult = CanMoveBrick(11, Settings.brick11, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick11);
                    Settings.brick11 = MoveBrick(fromField, toField, Settings.brick11, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 12)
            {
                brickList = Settings.field12.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick11.Field.ToString()); }

                var canMoveResult = CanMoveBrick(12, Settings.brick11, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick11);
                    Settings.brick11 = MoveBrick(fromField, toField, Settings.brick11, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 13)
            {
                brickList = Settings.field13.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick11.Field.ToString()); }

                var canMoveResult = CanMoveBrick(13, Settings.brick11, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick11);
                    Settings.brick11 = MoveBrick(fromField, toField, Settings.brick11, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 14)
            {
                brickList = Settings.field14.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick11.Field.ToString()); }

                var canMoveResult = CanMoveBrick(14, Settings.brick11, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick11);
                    Settings.brick11 = MoveBrick(fromField, toField, Settings.brick11, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 15)
            {
                brickList = Settings.field15.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick11.Field.ToString()); }

                var canMoveResult = CanMoveBrick(15, Settings.brick11, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick11);
                    Settings.brick11 = MoveBrick(fromField, toField, Settings.brick11, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 16)
            {
                brickList = Settings.field16.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick11.Field.ToString()); }

                var canMoveResult = CanMoveBrick(16, Settings.brick11, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick11);
                    Settings.brick11 = MoveBrick(fromField, toField, Settings.brick11, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 17)
            {
                brickList = Settings.field17.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick11.Field.ToString()); }

                var canMoveResult = CanMoveBrick(17, Settings.brick11, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick11);
                    Settings.brick11 = MoveBrick(fromField, toField, Settings.brick11, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 18)
            {
                brickList = Settings.field18.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick11.Field.ToString()); }

                var canMoveResult = CanMoveBrick(18, Settings.brick11, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick11);
                    Settings.brick11 = MoveBrick(fromField, toField, Settings.brick11, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 19)
            {
                brickList = Settings.field19.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick11.Field.ToString()); }

                var canMoveResult = CanMoveBrick(19, Settings.brick11, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick11);
                    Settings.brick11 = MoveBrick(fromField, toField, Settings.brick11, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 20)
            {
                brickList = Settings.field20.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick11.Field.ToString()); }

                var canMoveResult = CanMoveBrick(20, Settings.brick11, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick11);
                    Settings.brick11 = MoveBrick(fromField, toField, Settings.brick11, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 21)
            {
                brickList = Settings.field21.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick11.Field.ToString()); }

                var canMoveResult = CanMoveBrick(21, Settings.brick11, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick11);
                    Settings.brick11 = MoveBrick(fromField, toField, Settings.brick11, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 22)
            {
                brickList = Settings.field22.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick11.Field.ToString()); }

                var canMoveResult = CanMoveBrick(22, Settings.brick11, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick11);
                    Settings.brick11 = MoveBrick(fromField, toField, Settings.brick11, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 23)
            {
                brickList = Settings.field23.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick11.Field.ToString()); }

                var canMoveResult = CanMoveBrick(23, Settings.brick11, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick11);
                    Settings.brick11 = MoveBrick(fromField, toField, Settings.brick11, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 24)
            {
                brickList = Settings.field24.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick11.Field.ToString()); }

                var canMoveResult = CanMoveBrick(24, Settings.brick11, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick11);
                    Settings.brick11 = MoveBrick(fromField, toField, Settings.brick11, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 25)
            {
                brickList = Settings.field25.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick11.Field.ToString()); }

                var canMoveResult = CanMoveBrick(25, Settings.brick11, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick11);
                    Settings.brick11 = MoveBrick(fromField, toField, Settings.brick11, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 26)
            {
                brickList = Settings.field26.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick11.Field.ToString()); }

                var canMoveResult = CanMoveBrick(26, Settings.brick11, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick11);
                    Settings.brick11 = MoveBrick(fromField, toField, Settings.brick11, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 27)
            {
                brickList = Settings.field27.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick11.Field.ToString()); }

                var canMoveResult = CanMoveBrick(27, Settings.brick11, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick11);
                    Settings.brick11 = MoveBrick(fromField, toField, Settings.brick11, brickList);

                    setLocationPictureBox();
                }
            }
        }

        private void pictureBoxWhite_12_Click(object sender, EventArgs e)
        {

            int fieldnr = Settings.brick12.Field;
            if (fieldnr == 0)
            {
                brickList = Settings.field0.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick12.Field.ToString()); }

                var canMoveResult = CanMoveBrick(0, Settings.brick12, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick12);
                    Settings.brick12 = MoveBrick(fromField, toField, Settings.brick12, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 1)
            {
                brickList = Settings.field1.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick12.Field.ToString()); }

                var canMoveResult = CanMoveBrick(1, Settings.brick12, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick12);
                    Settings.brick12 = MoveBrick(fromField, toField, Settings.brick12, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 2)
            {
                brickList = Settings.field2.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick12.Field.ToString()); }

                var canMoveResult = CanMoveBrick(2, Settings.brick12, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick12);
                    Settings.brick12 = MoveBrick(fromField, toField, Settings.brick12, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 3)
            {
                brickList = Settings.field3.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick12.Field.ToString()); }

                var canMoveResult = CanMoveBrick(3, Settings.brick12, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick12);
                    Settings.brick12 = MoveBrick(fromField, toField, Settings.brick12, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 4)
            {
                brickList = Settings.field4.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick12.Field.ToString()); }

                var canMoveResult = CanMoveBrick(4, Settings.brick12, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick12);
                    Settings.brick12 = MoveBrick(fromField, toField, Settings.brick12, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 5)
            {
                brickList = Settings.field5.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick12.Field.ToString()); }

                var canMoveResult = CanMoveBrick(5, Settings.brick12, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick12);
                    Settings.brick12 = MoveBrick(fromField, toField, Settings.brick12, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 6)
            {
                brickList = Settings.field6.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick12.Field.ToString()); }

                var canMoveResult = CanMoveBrick(6, Settings.brick12, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick12);
                    Settings.brick12 = MoveBrick(fromField, toField, Settings.brick12, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 7)
            {
                brickList = Settings.field7.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick12.Field.ToString()); }

                var canMoveResult = CanMoveBrick(7, Settings.brick12, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick12);
                    Settings.brick12 = MoveBrick(fromField, toField, Settings.brick12, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 8)
            {
                brickList = Settings.field8.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick12.Field.ToString()); }

                var canMoveResult = CanMoveBrick(8, Settings.brick12, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick12);
                    Settings.brick12 = MoveBrick(fromField, toField, Settings.brick12, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 9)
            {
                brickList = Settings.field9.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick12.Field.ToString()); }

                var canMoveResult = CanMoveBrick(9, Settings.brick12, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick12);
                    Settings.brick12 = MoveBrick(fromField, toField, Settings.brick12, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 10)
            {
                brickList = Settings.field10.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick12.Field.ToString()); }

                var canMoveResult = CanMoveBrick(10, Settings.brick12, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick12);
                    Settings.brick12 = MoveBrick(fromField, toField, Settings.brick12, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 11)
            {
                brickList = Settings.field11.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick12.Field.ToString()); }

                var canMoveResult = CanMoveBrick(11, Settings.brick12, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick12);
                    Settings.brick12 = MoveBrick(fromField, toField, Settings.brick12, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 12)
            {
                brickList = Settings.field12.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick12.Field.ToString()); }

                var canMoveResult = CanMoveBrick(12, Settings.brick12, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick12);
                    Settings.brick12 = MoveBrick(fromField, toField, Settings.brick12, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 13)
            {
                brickList = Settings.field13.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick12.Field.ToString()); }

                var canMoveResult = CanMoveBrick(13, Settings.brick12, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick12);
                    Settings.brick12 = MoveBrick(fromField, toField, Settings.brick12, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 14)
            {
                brickList = Settings.field14.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick12.Field.ToString()); }

                var canMoveResult = CanMoveBrick(14, Settings.brick12, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick12);
                    Settings.brick12 = MoveBrick(fromField, toField, Settings.brick12, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 15)
            {
                brickList = Settings.field15.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick12.Field.ToString()); }

                var canMoveResult = CanMoveBrick(15, Settings.brick12, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick12);
                    Settings.brick12 = MoveBrick(fromField, toField, Settings.brick12, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 16)
            {
                brickList = Settings.field16.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick12.Field.ToString()); }

                var canMoveResult = CanMoveBrick(16, Settings.brick12, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick12);
                    Settings.brick12 = MoveBrick(fromField, toField, Settings.brick12, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 17)
            {
                brickList = Settings.field17.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick12.Field.ToString()); }

                var canMoveResult = CanMoveBrick(17, Settings.brick12, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick12);
                    Settings.brick12 = MoveBrick(fromField, toField, Settings.brick12, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 18)
            {
                brickList = Settings.field18.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick12.Field.ToString()); }

                var canMoveResult = CanMoveBrick(18, Settings.brick12, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick12);
                    Settings.brick12 = MoveBrick(fromField, toField, Settings.brick12, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 19)
            {
                brickList = Settings.field19.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick12.Field.ToString()); }

                var canMoveResult = CanMoveBrick(19, Settings.brick12, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick12);
                    Settings.brick12 = MoveBrick(fromField, toField, Settings.brick12, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 20)
            {
                brickList = Settings.field20.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick12.Field.ToString()); }

                var canMoveResult = CanMoveBrick(20, Settings.brick12, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick12);
                    Settings.brick12 = MoveBrick(fromField, toField, Settings.brick12, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 21)
            {
                brickList = Settings.field21.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick12.Field.ToString()); }

                var canMoveResult = CanMoveBrick(21, Settings.brick12, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick12);
                    Settings.brick12 = MoveBrick(fromField, toField, Settings.brick12, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 22)
            {
                brickList = Settings.field22.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick12.Field.ToString()); }

                var canMoveResult = CanMoveBrick(22, Settings.brick12, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick12);
                    Settings.brick12 = MoveBrick(fromField, toField, Settings.brick12, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 23)
            {
                brickList = Settings.field23.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick12.Field.ToString()); }

                var canMoveResult = CanMoveBrick(23, Settings.brick12, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick12);
                    Settings.brick12 = MoveBrick(fromField, toField, Settings.brick12, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 24)
            {
                brickList = Settings.field24.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick12.Field.ToString()); }

                var canMoveResult = CanMoveBrick(24, Settings.brick12, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick12);
                    Settings.brick12 = MoveBrick(fromField, toField, Settings.brick12, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 25)
            {
                brickList = Settings.field25.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick12.Field.ToString()); }

                var canMoveResult = CanMoveBrick(25, Settings.brick12, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick12);
                    Settings.brick12 = MoveBrick(fromField, toField, Settings.brick12, brickList);

                    setLocationPictureBox();
                }

            }
            if (fieldnr == 26)
            {
                brickList = Settings.field26.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick12.Field.ToString()); }

                var canMoveResult = CanMoveBrick(26, Settings.brick12, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick12);
                    Settings.brick12 = MoveBrick(fromField, toField, Settings.brick12, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 27)
            {
                brickList = Settings.field27.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick12.Field.ToString()); }

                var canMoveResult = CanMoveBrick(27, Settings.brick12, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick12);
                    Settings.brick12 = MoveBrick(fromField, toField, Settings.brick12, brickList);

                    setLocationPictureBox();
                }
            }
        }

        private void pictureBoxWhite_13_Click(object sender, EventArgs e)
        {

            int fieldnr = Settings.brick13.Field;
            if (fieldnr == 0)
            {
                brickList = Settings.field0.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick13.Field.ToString()); }

                var canMoveResult = CanMoveBrick(0, Settings.brick13, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick13);
                    Settings.brick13 = MoveBrick(fromField, toField, Settings.brick13, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 1)
            {
                brickList = Settings.field1.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick13.Field.ToString()); }

                var canMoveResult = CanMoveBrick(1, Settings.brick13, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick13);
                    Settings.brick13 = MoveBrick(fromField, toField, Settings.brick13, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 2)
            {
                brickList = Settings.field2.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick13.Field.ToString()); }

                var canMoveResult = CanMoveBrick(2, Settings.brick13, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick13);
                    Settings.brick13 = MoveBrick(fromField, toField, Settings.brick13, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 3)
            {
                brickList = Settings.field3.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick13.Field.ToString()); }

                var canMoveResult = CanMoveBrick(3, Settings.brick13, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick13);
                    Settings.brick13 = MoveBrick(fromField, toField, Settings.brick13, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 4)
            {
                brickList = Settings.field4.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick13.Field.ToString()); }

                var canMoveResult = CanMoveBrick(4, Settings.brick13, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick13);
                    Settings.brick13 = MoveBrick(fromField, toField, Settings.brick13, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 5)
            {
                brickList = Settings.field5.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick13.Field.ToString()); }

                var canMoveResult = CanMoveBrick(5, Settings.brick13, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick13);
                    Settings.brick13 = MoveBrick(fromField, toField, Settings.brick13, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 6)
            {
                brickList = Settings.field6.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick13.Field.ToString()); }

                var canMoveResult = CanMoveBrick(6, Settings.brick13, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick13);
                    Settings.brick13 = MoveBrick(fromField, toField, Settings.brick13, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 7)
            {
                brickList = Settings.field7.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick13.Field.ToString()); }

                var canMoveResult = CanMoveBrick(7, Settings.brick13, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick13);
                    Settings.brick13 = MoveBrick(fromField, toField, Settings.brick13, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 8)
            {
                brickList = Settings.field8.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick13.Field.ToString()); }

                var canMoveResult = CanMoveBrick(8, Settings.brick13, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick13);
                    Settings.brick13 = MoveBrick(fromField, toField, Settings.brick13, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 9)
            {
                brickList = Settings.field9.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick13.Field.ToString()); }

                var canMoveResult = CanMoveBrick(9, Settings.brick13, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick13);
                    Settings.brick13 = MoveBrick(fromField, toField, Settings.brick13, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 10)
            {
                brickList = Settings.field10.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick13.Field.ToString()); }

                var canMoveResult = CanMoveBrick(10, Settings.brick13, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick13);
                    Settings.brick13 = MoveBrick(fromField, toField, Settings.brick13, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 11)
            {
                brickList = Settings.field11.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick13.Field.ToString()); }

                var canMoveResult = CanMoveBrick(11, Settings.brick13, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick13);
                    Settings.brick13 = MoveBrick(fromField, toField, Settings.brick13, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 12)
            {
                brickList = Settings.field12.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick13.Field.ToString()); }

                var canMoveResult = CanMoveBrick(12, Settings.brick13, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick13);
                    Settings.brick13 = MoveBrick(fromField, toField, Settings.brick13, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 13)
            {
                brickList = Settings.field13.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick13.Field.ToString()); }

                var canMoveResult = CanMoveBrick(13, Settings.brick13, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick13);
                    Settings.brick13 = MoveBrick(fromField, toField, Settings.brick13, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 14)
            {
                brickList = Settings.field14.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick13.Field.ToString()); }

                var canMoveResult = CanMoveBrick(14, Settings.brick13, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick13);
                    Settings.brick13 = MoveBrick(fromField, toField, Settings.brick13, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 15)
            {
                brickList = Settings.field15.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick13.Field.ToString()); }

                var canMoveResult = CanMoveBrick(15, Settings.brick13, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick13);
                    Settings.brick13 = MoveBrick(fromField, toField, Settings.brick13, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 16)
            {
                brickList = Settings.field16.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick13.Field.ToString()); }

                var canMoveResult = CanMoveBrick(16, Settings.brick13, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick13);
                    Settings.brick13 = MoveBrick(fromField, toField, Settings.brick13, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 17)
            {
                brickList = Settings.field17.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick13.Field.ToString()); }

                var canMoveResult = CanMoveBrick(17, Settings.brick13, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick13);
                    Settings.brick13 = MoveBrick(fromField, toField, Settings.brick13, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 18)
            {
                brickList = Settings.field18.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick13.Field.ToString()); }

                var canMoveResult = CanMoveBrick(18, Settings.brick13, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick13);
                    Settings.brick13 = MoveBrick(fromField, toField, Settings.brick13, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 19)
            {
                brickList = Settings.field19.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick13.Field.ToString()); }

                var canMoveResult = CanMoveBrick(19, Settings.brick13, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick13);
                    Settings.brick13 = MoveBrick(fromField, toField, Settings.brick13, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 20)
            {
                brickList = Settings.field20.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick13.Field.ToString()); }

                var canMoveResult = CanMoveBrick(20, Settings.brick13, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick13);
                    Settings.brick13 = MoveBrick(fromField, toField, Settings.brick13, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 21)
            {
                brickList = Settings.field21.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick13.Field.ToString()); }

                var canMoveResult = CanMoveBrick(21, Settings.brick13, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick13);
                    Settings.brick13 = MoveBrick(fromField, toField, Settings.brick13, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 22)
            {
                brickList = Settings.field22.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick13.Field.ToString()); }

                var canMoveResult = CanMoveBrick(22, Settings.brick13, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick13);
                    Settings.brick13 = MoveBrick(fromField, toField, Settings.brick13, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 23)
            {
                brickList = Settings.field23.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick13.Field.ToString()); }

                var canMoveResult = CanMoveBrick(23, Settings.brick13, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick13);
                    Settings.brick13 = MoveBrick(fromField, toField, Settings.brick13, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 24)
            {
                brickList = Settings.field24.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick13.Field.ToString()); }

                var canMoveResult = CanMoveBrick(24, Settings.brick13, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick13);
                    Settings.brick13 = MoveBrick(fromField, toField, Settings.brick13, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 25)
            {
                brickList = Settings.field25.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick13.Field.ToString()); }

                var canMoveResult = CanMoveBrick(25, Settings.brick13, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick13);
                    Settings.brick13 = MoveBrick(fromField, toField, Settings.brick13, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 26)
            {
                brickList = Settings.field26.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick13.Field.ToString()); }

                var canMoveResult = CanMoveBrick(26, Settings.brick13, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick13);
                    Settings.brick13 = MoveBrick(fromField, toField, Settings.brick13, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 27)
            {
                brickList = Settings.field27.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick13.Field.ToString()); }

                var canMoveResult = CanMoveBrick(27, Settings.brick13, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick13);
                    Settings.brick13 = MoveBrick(fromField, toField, Settings.brick13, brickList);

                    setLocationPictureBox();
                }
            }
        }

        private void pictureBoxWhite_14_Click(object sender, EventArgs e)
        {

            int fieldnr = Settings.brick14.Field;
            if (fieldnr == 0)
            {
                brickList = Settings.field0.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick14.Field.ToString()); }

                var canMoveResult = CanMoveBrick(0, Settings.brick14, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick14);
                    Settings.brick14 = MoveBrick(fromField, toField, Settings.brick14, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 1)
            {
                brickList = Settings.field1.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick14.Field.ToString()); }

                var canMoveResult = CanMoveBrick(1, Settings.brick14, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick14);
                    Settings.brick14 = MoveBrick(fromField, toField, Settings.brick14, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 2)
            {
                brickList = Settings.field2.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick14.Field.ToString()); }

                var canMoveResult = CanMoveBrick(2, Settings.brick14, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick14);
                    Settings.brick14 = MoveBrick(fromField, toField, Settings.brick14, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 3)
            {
                brickList = Settings.field3.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick14.Field.ToString()); }

                var canMoveResult = CanMoveBrick(3, Settings.brick14, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick14);
                    Settings.brick14 = MoveBrick(fromField, toField, Settings.brick14, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 4)
            {
                brickList = Settings.field4.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick14.Field.ToString()); }

                var canMoveResult = CanMoveBrick(4, Settings.brick14, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick14);
                    Settings.brick14 = MoveBrick(fromField, toField, Settings.brick14, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 5)
            {
                brickList = Settings.field5.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick14.Field.ToString()); }

                var canMoveResult = CanMoveBrick(5, Settings.brick14, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick14);
                    Settings.brick14 = MoveBrick(fromField, toField, Settings.brick14, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 6)
            {
                brickList = Settings.field6.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick14.Field.ToString()); }

                var canMoveResult = CanMoveBrick(6, Settings.brick14, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick14);
                    Settings.brick14 = MoveBrick(fromField, toField, Settings.brick14, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 7)
            {
                brickList = Settings.field7.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick14.Field.ToString()); }

                var canMoveResult = CanMoveBrick(7, Settings.brick14, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick14);
                    Settings.brick14 = MoveBrick(fromField, toField, Settings.brick14, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 8)
            {
                brickList = Settings.field8.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick14.Field.ToString()); }

                var canMoveResult = CanMoveBrick(8, Settings.brick14, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick14);
                    Settings.brick14 = MoveBrick(fromField, toField, Settings.brick14, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 9)
            {
                brickList = Settings.field9.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick14.Field.ToString()); }

                var canMoveResult = CanMoveBrick(9, Settings.brick14, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick14);
                    Settings.brick14 = MoveBrick(fromField, toField, Settings.brick14, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 10)
            {
                brickList = Settings.field10.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick14.Field.ToString()); }

                var canMoveResult = CanMoveBrick(10, Settings.brick14, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick14);
                    Settings.brick14 = MoveBrick(fromField, toField, Settings.brick14, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 11)
            {
                brickList = Settings.field11.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick14.Field.ToString()); }

                var canMoveResult = CanMoveBrick(11, Settings.brick14, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick14);
                    Settings.brick14 = MoveBrick(fromField, toField, Settings.brick14, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 12)
            {
                brickList = Settings.field12.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick14.Field.ToString()); }

                var canMoveResult = CanMoveBrick(12, Settings.brick14, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick14);
                    Settings.brick14 = MoveBrick(fromField, toField, Settings.brick14, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 13)
            {
                brickList = Settings.field13.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick14.Field.ToString()); }

                var canMoveResult = CanMoveBrick(13, Settings.brick14, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick14);
                    Settings.brick14 = MoveBrick(fromField, toField, Settings.brick14, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 14)
            {
                brickList = Settings.field14.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick14.Field.ToString()); }

                var canMoveResult = CanMoveBrick(14, Settings.brick14, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick14);
                    Settings.brick14 = MoveBrick(fromField, toField, Settings.brick14, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 15)
            {
                brickList = Settings.field15.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick14.Field.ToString()); }

                var canMoveResult = CanMoveBrick(13, Settings.brick14, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick14);
                    Settings.brick14 = MoveBrick(fromField, toField, Settings.brick14, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 16)
            {
                brickList = Settings.field16.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick14.Field.ToString()); }

                var canMoveResult = CanMoveBrick(16, Settings.brick14, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick14);
                    Settings.brick14 = MoveBrick(fromField, toField, Settings.brick14, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 17)
            {
                brickList = Settings.field17.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick14.Field.ToString()); }

                var canMoveResult = CanMoveBrick(17, Settings.brick14, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick14);
                    Settings.brick14 = MoveBrick(fromField, toField, Settings.brick14, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 18)
            {
                brickList = Settings.field18.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick14.Field.ToString()); }

                var canMoveResult = CanMoveBrick(18, Settings.brick14, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick14);
                    Settings.brick14 = MoveBrick(fromField, toField, Settings.brick14, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 19)
            {
                brickList = Settings.field19.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick14.Field.ToString()); }

                var canMoveResult = CanMoveBrick(19, Settings.brick14, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick14);
                    Settings.brick14 = MoveBrick(fromField, toField, Settings.brick14, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 20)
            {
                brickList = Settings.field20.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick14.Field.ToString()); }

                var canMoveResult = CanMoveBrick(20, Settings.brick14, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick14);
                    Settings.brick14 = MoveBrick(fromField, toField, Settings.brick14, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 21)
            {
                brickList = Settings.field21.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick14.Field.ToString()); }

                var canMoveResult = CanMoveBrick(21, Settings.brick14, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick14);
                    Settings.brick14 = MoveBrick(fromField, toField, Settings.brick14, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 22)
            {
                brickList = Settings.field22.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick14.Field.ToString()); }

                var canMoveResult = CanMoveBrick(22, Settings.brick14, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick14);
                    Settings.brick14 = MoveBrick(fromField, toField, Settings.brick14, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 23)
            {
                brickList = Settings.field23.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick14.Field.ToString()); }

                var canMoveResult = CanMoveBrick(23, Settings.brick14, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick14);
                    Settings.brick14 = MoveBrick(fromField, toField, Settings.brick14, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 24)
            {
                brickList = Settings.field24.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick14.Field.ToString()); }

                var canMoveResult = CanMoveBrick(24, Settings.brick14, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick14);
                    Settings.brick14 = MoveBrick(fromField, toField, Settings.brick14, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 25)
            {
                brickList = Settings.field25.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick14.Field.ToString()); }

                var canMoveResult = CanMoveBrick(25, Settings.brick14, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick14);
                    Settings.brick14 = MoveBrick(fromField, toField, Settings.brick14, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 26)
            {
                brickList = Settings.field26.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick14.Field.ToString()); }

                var canMoveResult = CanMoveBrick(26, Settings.brick14, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick14);
                    Settings.brick14 = MoveBrick(fromField, toField, Settings.brick14, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 27)
            {
                brickList = Settings.field27.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick14.Field.ToString()); }

                var canMoveResult = CanMoveBrick(27, Settings.brick14, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick14);
                    Settings.brick14 = MoveBrick(fromField, toField, Settings.brick14, brickList);

                    setLocationPictureBox();
                }
            }
        }

        private void pictureBoxWhite_15_Click(object sender, EventArgs e)
        {

            int fieldnr = Settings.brick15.Field;
            if (fieldnr == 0)
            {
                brickList = Settings.field0.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick15.Field.ToString()); }

                var canMoveResult = CanMoveBrick(0, Settings.brick15, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick15);
                    Settings.brick15 = MoveBrick(fromField, toField, Settings.brick15, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 1)
            {
                brickList = Settings.field1.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick15.Field.ToString()); }

                var canMoveResult = CanMoveBrick(1, Settings.brick15, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick15);
                    Settings.brick15 = MoveBrick(fromField, toField, Settings.brick15, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 2)
            {
                brickList = Settings.field2.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick15.Field.ToString()); }

                var canMoveResult = CanMoveBrick(2, Settings.brick15, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick15);
                    Settings.brick15 = MoveBrick(fromField, toField, Settings.brick15, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 3)
            {
                brickList = Settings.field3.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick15.Field.ToString()); }

                var canMoveResult = CanMoveBrick(3, Settings.brick15, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick15);
                    Settings.brick15 = MoveBrick(fromField, toField, Settings.brick15, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 4)
            {
                brickList = Settings.field4.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick15.Field.ToString()); }

                var canMoveResult = CanMoveBrick(4, Settings.brick15, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick15);
                    Settings.brick15 = MoveBrick(fromField, toField, Settings.brick15, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 5)
            {
                brickList = Settings.field5.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick15.Field.ToString()); }

                var canMoveResult = CanMoveBrick(5, Settings.brick15, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick15);
                    Settings.brick15 = MoveBrick(fromField, toField, Settings.brick15, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 6)
            {
                brickList = Settings.field6.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick15.Field.ToString()); }

                var canMoveResult = CanMoveBrick(6, Settings.brick15, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick15);
                    Settings.brick15 = MoveBrick(fromField, toField, Settings.brick15, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 7)
            {
                brickList = Settings.field7.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick15.Field.ToString()); }

                var canMoveResult = CanMoveBrick(7, Settings.brick15, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick15);
                    Settings.brick15 = MoveBrick(fromField, toField, Settings.brick15, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 8)
            {
                brickList = Settings.field8.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick15.Field.ToString()); }

                var canMoveResult = CanMoveBrick(8, Settings.brick15, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick15);
                    Settings.brick15 = MoveBrick(fromField, toField, Settings.brick15, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 9)
            {
                brickList = Settings.field9.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick15.Field.ToString()); }

                var canMoveResult = CanMoveBrick(9, Settings.brick15, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick15);
                    Settings.brick15 = MoveBrick(fromField, toField, Settings.brick15, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 10)
            {
                brickList = Settings.field10.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick15.Field.ToString()); }

                var canMoveResult = CanMoveBrick(10, Settings.brick15, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick15);
                    Settings.brick15 = MoveBrick(fromField, toField, Settings.brick15, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 11)
            {
                brickList = Settings.field11.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick15.Field.ToString()); }

                var canMoveResult = CanMoveBrick(11, Settings.brick15, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick15);
                    Settings.brick15 = MoveBrick(fromField, toField, Settings.brick15, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 12)
            {
                brickList = Settings.field12.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick15.Field.ToString()); }

                var canMoveResult = CanMoveBrick(12, Settings.brick15, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick15);
                    Settings.brick15 = MoveBrick(fromField, toField, Settings.brick15, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 13)
            {
                brickList = Settings.field13.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick15.Field.ToString()); }

                var canMoveResult = CanMoveBrick(13, Settings.brick15, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick15);
                    Settings.brick15 = MoveBrick(fromField, toField, Settings.brick15, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 14)
            {
                brickList = Settings.field14.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick15.Field.ToString()); }

                var canMoveResult = CanMoveBrick(14, Settings.brick15, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick15);
                    Settings.brick15 = MoveBrick(fromField, toField, Settings.brick15, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 15)
            {
                brickList = Settings.field15.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick15.Field.ToString()); }

                var canMoveResult = CanMoveBrick(0, Settings.brick15, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick15);
                    Settings.brick15 = MoveBrick(fromField, toField, Settings.brick15, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 16)
            {
                brickList = Settings.field16.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick15.Field.ToString()); }

                var canMoveResult = CanMoveBrick(16, Settings.brick15, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick15);
                    Settings.brick15 = MoveBrick(fromField, toField, Settings.brick15, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 17)
            {
                brickList = Settings.field17.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick15.Field.ToString()); }

                var canMoveResult = CanMoveBrick(17, Settings.brick15, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick15);
                    Settings.brick15 = MoveBrick(fromField, toField, Settings.brick15, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 18)
            {
                brickList = Settings.field18.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick15.Field.ToString()); }

                var canMoveResult = CanMoveBrick(18, Settings.brick15, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick15);
                    Settings.brick15 = MoveBrick(fromField, toField, Settings.brick15, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 19)
            {
                brickList = Settings.field19.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick15.Field.ToString()); }

                var canMoveResult = CanMoveBrick(19, Settings.brick15, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick15);
                    Settings.brick15 = MoveBrick(fromField, toField, Settings.brick15, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 20)
            {
                brickList = Settings.field20.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick15.Field.ToString()); }

                var canMoveResult = CanMoveBrick(20, Settings.brick15, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick15);
                    Settings.brick15 = MoveBrick(fromField, toField, Settings.brick15, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 21)
            {
                brickList = Settings.field21.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick15.Field.ToString()); }

                var canMoveResult = CanMoveBrick(21, Settings.brick15, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick15);
                    Settings.brick15 = MoveBrick(fromField, toField, Settings.brick15, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 22)
            {
                brickList = Settings.field22.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick15.Field.ToString()); }

                var canMoveResult = CanMoveBrick(22, Settings.brick15, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick15);
                    Settings.brick15 = MoveBrick(fromField, toField, Settings.brick15, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 23)
            {
                brickList = Settings.field23.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick15.Field.ToString()); }

                var canMoveResult = CanMoveBrick(23, Settings.brick15, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick15);
                    Settings.brick15 = MoveBrick(fromField, toField, Settings.brick15, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 24)
            {
                brickList = Settings.field24.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick15.Field.ToString()); }

                var canMoveResult = CanMoveBrick(24, Settings.brick15, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick15);
                    Settings.brick15 = MoveBrick(fromField, toField, Settings.brick15, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 25)
            {
                brickList = Settings.field25.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick15.Field.ToString()); }

                var canMoveResult = CanMoveBrick(25, Settings.brick15, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick15);
                    Settings.brick15 = MoveBrick(fromField, toField, Settings.brick15, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 26)
            {
                brickList = Settings.field26.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick15.Field.ToString()); }

                var canMoveResult = CanMoveBrick(26, Settings.brick15, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick15);
                    Settings.brick15 = MoveBrick(fromField, toField, Settings.brick15, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 27)
            {
                brickList = Settings.field27.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick15.Field.ToString()); }

                var canMoveResult = CanMoveBrick(27, Settings.brick15, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick15);
                    Settings.brick15 = MoveBrick(fromField, toField, Settings.brick15, brickList);

                    setLocationPictureBox();
                }
            }
        }
        #endregion
        #region Black PictureBox

        private void pictureBoxBlack_1_Click(object sender, EventArgs e)
        {

            int fieldnr = Settings.brick16.Field;
            if (fieldnr == 0)
            {
                brickList = Settings.field0.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick16.Field.ToString()); }

                var canMoveResult = CanMoveBrick(0, Settings.brick16, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick16);
                    Settings.brick16 = MoveBrick(fromField, toField, Settings.brick16, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 1)
            {
                brickList = Settings.field1.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick16.Field.ToString()); }

                var canMoveResult = CanMoveBrick(1, Settings.brick16, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick16);
                    Settings.brick16 = MoveBrick(fromField, toField, Settings.brick16, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 2)
            {
                brickList = Settings.field2.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick16.Field.ToString()); }

                var canMoveResult = CanMoveBrick(2, Settings.brick16, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick16);
                    Settings.brick16 = MoveBrick(fromField, toField, Settings.brick16, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 3)
            {
                brickList = Settings.field3.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick16.Field.ToString()); }

                var canMoveResult = CanMoveBrick(3, Settings.brick16, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick16);
                    Settings.brick16 = MoveBrick(fromField, toField, Settings.brick16, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 4)
            {
                brickList = Settings.field4.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick16.Field.ToString()); }

                var canMoveResult = CanMoveBrick(4, Settings.brick16, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick16);
                    Settings.brick16 = MoveBrick(fromField, toField, Settings.brick16, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 5)
            {
                brickList = Settings.field5.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick16.Field.ToString()); }

                var canMoveResult = CanMoveBrick(5, Settings.brick16, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick16);
                    Settings.brick16 = MoveBrick(fromField, toField, Settings.brick16, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 6)
            {
                brickList = Settings.field6.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick16.Field.ToString()); }

                var canMoveResult = CanMoveBrick(6, Settings.brick16, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick16);
                    Settings.brick16 = MoveBrick(fromField, toField, Settings.brick16, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 7)
            {
                brickList = Settings.field7.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick16.Field.ToString()); }

                var canMoveResult = CanMoveBrick(7, Settings.brick16, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick16);
                    Settings.brick16 = MoveBrick(fromField, toField, Settings.brick16, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 8)
            {
                brickList = Settings.field8.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick16.Field.ToString()); }

                var canMoveResult = CanMoveBrick(8, Settings.brick16, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick16);
                    Settings.brick16 = MoveBrick(fromField, toField, Settings.brick16, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 9)
            {
                brickList = Settings.field9.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick16.Field.ToString()); }

                var canMoveResult = CanMoveBrick(9, Settings.brick16, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick16);
                    Settings.brick16 = MoveBrick(fromField, toField, Settings.brick16, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 10)
            {
                brickList = Settings.field10.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick16.Field.ToString()); }

                var canMoveResult = CanMoveBrick(10, Settings.brick16, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick16);
                    Settings.brick16 = MoveBrick(fromField, toField, Settings.brick16, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 11)
            {
                brickList = Settings.field11.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick16.Field.ToString()); }

                var canMoveResult = CanMoveBrick(11, Settings.brick16, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick16);
                    Settings.brick16 = MoveBrick(fromField, toField, Settings.brick16, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 12)
            {
                brickList = Settings.field12.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick16.Field.ToString()); }

                var canMoveResult = CanMoveBrick(12, Settings.brick16, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick16);
                    Settings.brick16 = MoveBrick(fromField, toField, Settings.brick16, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 13)
            {
                brickList = Settings.field13.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick16.Field.ToString()); }

                var canMoveResult = CanMoveBrick(13, Settings.brick16, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick16);
                    Settings.brick16 = MoveBrick(fromField, toField, Settings.brick16, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 14)
            {
                brickList = Settings.field14.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick16.Field.ToString()); }

                var canMoveResult = CanMoveBrick(14, Settings.brick16, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick16);
                    Settings.brick16 = MoveBrick(fromField, toField, Settings.brick16, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 15)
            {
                brickList = Settings.field15.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick16.Field.ToString()); }

                var canMoveResult = CanMoveBrick(15, Settings.brick16, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick16);
                    Settings.brick16 = MoveBrick(fromField, toField, Settings.brick16, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 16)
            {
                brickList = Settings.field16.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick16.Field.ToString()); }

                var canMoveResult = CanMoveBrick(16, Settings.brick16, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick16);
                    Settings.brick16 = MoveBrick(fromField, toField, Settings.brick16, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 17)
            {
                brickList = Settings.field17.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick16.Field.ToString()); }

                var canMoveResult = CanMoveBrick(17, Settings.brick16, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick16);
                    Settings.brick16 = MoveBrick(fromField, toField, Settings.brick16, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 18)
            {
                brickList = Settings.field18.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick16.Field.ToString()); }

                var canMoveResult = CanMoveBrick(18, Settings.brick16, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick16);
                    Settings.brick16 = MoveBrick(fromField, toField, Settings.brick16, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 19)
            {
                brickList = Settings.field19.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick16.Field.ToString()); }

                var canMoveResult = CanMoveBrick(19, Settings.brick16, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick16);
                    Settings.brick16 = MoveBrick(fromField, toField, Settings.brick16, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 20)
            {
                brickList = Settings.field20.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick16.Field.ToString()); }

                var canMoveResult = CanMoveBrick(20, Settings.brick16, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick16);
                    Settings.brick16 = MoveBrick(fromField, toField, Settings.brick16, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 21)
            {
                brickList = Settings.field21.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick16.Field.ToString()); }

                var canMoveResult = CanMoveBrick(21, Settings.brick16, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick16);
                    Settings.brick16 = MoveBrick(fromField, toField, Settings.brick16, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 22)
            {
                brickList = Settings.field22.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick16.Field.ToString()); }

                var canMoveResult = CanMoveBrick(22, Settings.brick16, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick16);
                    Settings.brick16 = MoveBrick(fromField, toField, Settings.brick16, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 23)
            {
                brickList = Settings.field23.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick16.Field.ToString()); }

                var canMoveResult = CanMoveBrick(23, Settings.brick16, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick16);
                    Settings.brick16 = MoveBrick(fromField, toField, Settings.brick16, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 24)
            {
                brickList = Settings.field24.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick16.Field.ToString()); }

                var canMoveResult = CanMoveBrick(24, Settings.brick16, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick16);
                    Settings.brick16 = MoveBrick(fromField, toField, Settings.brick16, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 25)
            {
                brickList = Settings.field25.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick16.Field.ToString()); }

                var canMoveResult = CanMoveBrick(25, Settings.brick16, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick16);
                    Settings.brick16 = MoveBrick(fromField, toField, Settings.brick16, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 26)
            {
                brickList = Settings.field26.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick16.Field.ToString()); }

                var canMoveResult = CanMoveBrick(26, Settings.brick16, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick16);
                    Settings.brick16 = MoveBrick(fromField, toField, Settings.brick16, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 27)
            {
                brickList = Settings.field27.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick16.Field.ToString()); }

                var canMoveResult = CanMoveBrick(27, Settings.brick16, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick16);
                    Settings.brick16 = MoveBrick(fromField, toField, Settings.brick16, brickList);

                    setLocationPictureBox();
                }
            }
        }

        private void pictureBoxBlack_2_Click(object sender, EventArgs e)
        {

            int fieldnr = Settings.brick17.Field;
            if (fieldnr == 0)
            {
                brickList = Settings.field0.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick17.Field.ToString()); }

                var canMoveResult = CanMoveBrick(0, Settings.brick17, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick17);
                    Settings.brick17 = MoveBrick(fromField, toField, Settings.brick17, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 1)
            {
                brickList = Settings.field1.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick17.Field.ToString()); }

                var canMoveResult = CanMoveBrick(1, Settings.brick17, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick17);
                    Settings.brick17 = MoveBrick(fromField, toField, Settings.brick17, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 2)
            {
                brickList = Settings.field2.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick17.Field.ToString()); }

                var canMoveResult = CanMoveBrick(2, Settings.brick17, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick17);
                    Settings.brick17 = MoveBrick(fromField, toField, Settings.brick17, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 3)
            {
                brickList = Settings.field3.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick17.Field.ToString()); }

                var canMoveResult = CanMoveBrick(3, Settings.brick17, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick17);
                    Settings.brick17 = MoveBrick(fromField, toField, Settings.brick17, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 4)
            {
                brickList = Settings.field4.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick17.Field.ToString()); }

                var canMoveResult = CanMoveBrick(4, Settings.brick17, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick17);
                    Settings.brick17 = MoveBrick(fromField, toField, Settings.brick17, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 5)
            {
                brickList = Settings.field5.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick17.Field.ToString()); }

                var canMoveResult = CanMoveBrick(5, Settings.brick17, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick17);
                    Settings.brick17 = MoveBrick(fromField, toField, Settings.brick17, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 6)
            {
                brickList = Settings.field6.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick17.Field.ToString()); }

                var canMoveResult = CanMoveBrick(6, Settings.brick17, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick17);
                    Settings.brick17 = MoveBrick(fromField, toField, Settings.brick17, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 7)
            {
                brickList = Settings.field7.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick17.Field.ToString()); }

                var canMoveResult = CanMoveBrick(7, Settings.brick17, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick17);
                    Settings.brick17 = MoveBrick(fromField, toField, Settings.brick17, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 8)
            {
                brickList = Settings.field8.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick17.Field.ToString()); }

                var canMoveResult = CanMoveBrick(8, Settings.brick17, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick17);
                    Settings.brick17 = MoveBrick(fromField, toField, Settings.brick17, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 9)
            {
                brickList = Settings.field9.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick17.Field.ToString()); }

                var canMoveResult = CanMoveBrick(9, Settings.brick17, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick17);
                    Settings.brick17 = MoveBrick(fromField, toField, Settings.brick17, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 10)
            {
                brickList = Settings.field10.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick17.Field.ToString()); }

                var canMoveResult = CanMoveBrick(10, Settings.brick17, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick17);
                    Settings.brick17 = MoveBrick(fromField, toField, Settings.brick17, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 11)
            {
                brickList = Settings.field11.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick17.Field.ToString()); }

                var canMoveResult = CanMoveBrick(11, Settings.brick17, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick17);
                    Settings.brick17 = MoveBrick(fromField, toField, Settings.brick17, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 12)
            {
                brickList = Settings.field12.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick17.Field.ToString()); }

                var canMoveResult = CanMoveBrick(12, Settings.brick17, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick17);
                    Settings.brick17 = MoveBrick(fromField, toField, Settings.brick17, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 13)
            {
                brickList = Settings.field13.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick17.Field.ToString()); }

                var canMoveResult = CanMoveBrick(13, Settings.brick17, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick17);
                    Settings.brick17 = MoveBrick(fromField, toField, Settings.brick17, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 14)
            {
                brickList = Settings.field14.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick17.Field.ToString()); }

                var canMoveResult = CanMoveBrick(14, Settings.brick17, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick17);
                    Settings.brick17 = MoveBrick(fromField, toField, Settings.brick17, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 15)
            {
                brickList = Settings.field15.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick17.Field.ToString()); }

                var canMoveResult = CanMoveBrick(15, Settings.brick17, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick17);
                    Settings.brick17 = MoveBrick(fromField, toField, Settings.brick17, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 16)
            {
                brickList = Settings.field16.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick17.Field.ToString()); }

                var canMoveResult = CanMoveBrick(16, Settings.brick17, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick17);
                    Settings.brick17 = MoveBrick(fromField, toField, Settings.brick17, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 17)
            {
                brickList = Settings.field17.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick17.Field.ToString()); }

                var canMoveResult = CanMoveBrick(17, Settings.brick17, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick17);
                    Settings.brick17 = MoveBrick(fromField, toField, Settings.brick17, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 18)
            {
                brickList = Settings.field18.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick17.Field.ToString()); }

                var canMoveResult = CanMoveBrick(18, Settings.brick17, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick17);
                    Settings.brick17 = MoveBrick(fromField, toField, Settings.brick17, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 19)
            {
                brickList = Settings.field19.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick17.Field.ToString()); }

                var canMoveResult = CanMoveBrick(19, Settings.brick17, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick17);
                    Settings.brick17 = MoveBrick(fromField, toField, Settings.brick17, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 20)
            {
                brickList = Settings.field20.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick17.Field.ToString()); }

                var canMoveResult = CanMoveBrick(20, Settings.brick17, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick17);
                    Settings.brick17 = MoveBrick(fromField, toField, Settings.brick17, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 21)
            {
                brickList = Settings.field21.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick17.Field.ToString()); }

                var canMoveResult = CanMoveBrick(21, Settings.brick17, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick17);
                    Settings.brick17 = MoveBrick(fromField, toField, Settings.brick17, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 22)
            {
                brickList = Settings.field22.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick17.Field.ToString()); }

                var canMoveResult = CanMoveBrick(22, Settings.brick17, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick17);
                    Settings.brick17 = MoveBrick(fromField, toField, Settings.brick17, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 23)
            {
                brickList = Settings.field23.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick17.Field.ToString()); }

                var canMoveResult = CanMoveBrick(23, Settings.brick17, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick17);
                    Settings.brick17 = MoveBrick(fromField, toField, Settings.brick17, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 24)
            {
                brickList = Settings.field24.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick17.Field.ToString()); }

                var canMoveResult = CanMoveBrick(24, Settings.brick17, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick17);
                    Settings.brick17 = MoveBrick(fromField, toField, Settings.brick17, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 25)
            {
                brickList = Settings.field25.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick17.Field.ToString()); }

                var canMoveResult = CanMoveBrick(25, Settings.brick17, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick17);
                    Settings.brick17 = MoveBrick(fromField, toField, Settings.brick17, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 26)
            {
                brickList = Settings.field26.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick17.Field.ToString()); }

                var canMoveResult = CanMoveBrick(26, Settings.brick17, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick17);
                    Settings.brick17 = MoveBrick(fromField, toField, Settings.brick17, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 27)
            {
                brickList = Settings.field27.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick17.Field.ToString()); }

                var canMoveResult = CanMoveBrick(0, Settings.brick17, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick17);
                    Settings.brick17 = MoveBrick(fromField, toField, Settings.brick17, brickList);

                    setLocationPictureBox();
                }
            }
        }

        private void pictureBoxBlack_3_Click(object sender, EventArgs e)
        {

            int fieldnr = Settings.brick18.Field;
            if (fieldnr == 0)
            {
                brickList = Settings.field0.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick18.Field.ToString()); }

                var canMoveResult = CanMoveBrick(0, Settings.brick18, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick18);
                    Settings.brick18 = MoveBrick(fromField, toField, Settings.brick18, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 1)
            {
                brickList = Settings.field1.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick18.Field.ToString()); }

                var canMoveResult = CanMoveBrick(1, Settings.brick18, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick18);
                    Settings.brick18 = MoveBrick(fromField, toField, Settings.brick18, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 2)
            {
                brickList = Settings.field2.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick18.Field.ToString()); }

                var canMoveResult = CanMoveBrick(2, Settings.brick18, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick18);
                    Settings.brick18 = MoveBrick(fromField, toField, Settings.brick18, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 3)
            {
                brickList = Settings.field3.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick18.Field.ToString()); }

                var canMoveResult = CanMoveBrick(3, Settings.brick18, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick18);
                    Settings.brick18 = MoveBrick(fromField, toField, Settings.brick18, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 4)
            {
                brickList = Settings.field4.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick18.Field.ToString()); }

                var canMoveResult = CanMoveBrick(4, Settings.brick18, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick18);
                    Settings.brick18 = MoveBrick(fromField, toField, Settings.brick18, brickList);

                    setLocationPictureBox();
                }

            }
            if (fieldnr == 5)
            {
                brickList = Settings.field5.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick18.Field.ToString()); }

                var canMoveResult = CanMoveBrick(5, Settings.brick18, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick18);
                    Settings.brick18 = MoveBrick(fromField, toField, Settings.brick18, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 6)
            {
                brickList = Settings.field6.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick18.Field.ToString()); }

                var canMoveResult = CanMoveBrick(6, Settings.brick18, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick18);
                    Settings.brick18 = MoveBrick(fromField, toField, Settings.brick18, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 7)
            {
                brickList = Settings.field7.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick18.Field.ToString()); }

                var canMoveResult = CanMoveBrick(7, Settings.brick18, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick18);
                    Settings.brick18 = MoveBrick(fromField, toField, Settings.brick18, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 8)
            {
                brickList = Settings.field8.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick18.Field.ToString()); }

                var canMoveResult = CanMoveBrick(8, Settings.brick18, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick18);
                    Settings.brick18 = MoveBrick(fromField, toField, Settings.brick18, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 9)
            {
                brickList = Settings.field9.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick18.Field.ToString()); }

                var canMoveResult = CanMoveBrick(9, Settings.brick18, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick18);
                    Settings.brick18 = MoveBrick(fromField, toField, Settings.brick18, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 10)
            {
                brickList = Settings.field10.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick18.Field.ToString()); }

                var canMoveResult = CanMoveBrick(10, Settings.brick18, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick18);
                    Settings.brick18 = MoveBrick(fromField, toField, Settings.brick18, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 11)
            {
                brickList = Settings.field11.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick18.Field.ToString()); }

                var canMoveResult = CanMoveBrick(11, Settings.brick18, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick18);
                    Settings.brick18 = MoveBrick(fromField, toField, Settings.brick18, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 12)
            {
                brickList = Settings.field12.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick18.Field.ToString()); }

                var canMoveResult = CanMoveBrick(12, Settings.brick18, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick18);
                    Settings.brick18 = MoveBrick(fromField, toField, Settings.brick18, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 13)
            {
                brickList = Settings.field13.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick18.Field.ToString()); }

                var canMoveResult = CanMoveBrick(12, Settings.brick18, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick18);
                    Settings.brick18 = MoveBrick(fromField, toField, Settings.brick18, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 14)
            {
                brickList = Settings.field14.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick18.Field.ToString()); }

                var canMoveResult = CanMoveBrick(14, Settings.brick18, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick18);
                    Settings.brick18 = MoveBrick(fromField, toField, Settings.brick18, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 15)
            {
                brickList = Settings.field15.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick18.Field.ToString()); }

                var canMoveResult = CanMoveBrick(15, Settings.brick18, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick18);
                    Settings.brick18 = MoveBrick(fromField, toField, Settings.brick18, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 16)
            {
                brickList = Settings.field16.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick18.Field.ToString()); }

                var canMoveResult = CanMoveBrick(16, Settings.brick18, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick18);
                    Settings.brick18 = MoveBrick(fromField, toField, Settings.brick18, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 17)
            {
                brickList = Settings.field17.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick18.Field.ToString()); }

                var canMoveResult = CanMoveBrick(17, Settings.brick18, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick18);
                    Settings.brick18 = MoveBrick(fromField, toField, Settings.brick18, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 18)
            {
                brickList = Settings.field18.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick18.Field.ToString()); }

                var canMoveResult = CanMoveBrick(18, Settings.brick18, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick18);
                    Settings.brick18 = MoveBrick(fromField, toField, Settings.brick18, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 19)
            {
                brickList = Settings.field19.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick18.Field.ToString()); }

                var canMoveResult = CanMoveBrick(19, Settings.brick18, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick18);
                    Settings.brick18 = MoveBrick(fromField, toField, Settings.brick18, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 20)
            {
                brickList = Settings.field20.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick18.Field.ToString()); }

                var canMoveResult = CanMoveBrick(20, Settings.brick18, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick18);
                    Settings.brick18 = MoveBrick(fromField, toField, Settings.brick18, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 21)
            {
                brickList = Settings.field21.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick18.Field.ToString()); }

                var canMoveResult = CanMoveBrick(21, Settings.brick18, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick18);
                    Settings.brick18 = MoveBrick(fromField, toField, Settings.brick18, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 22)
            {
                brickList = Settings.field22.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick18.Field.ToString()); }

                var canMoveResult = CanMoveBrick(22, Settings.brick18, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick18);
                    Settings.brick18 = MoveBrick(fromField, toField, Settings.brick18, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 23)
            {
                brickList = Settings.field23.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick18.Field.ToString()); }

                var canMoveResult = CanMoveBrick(23, Settings.brick18, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick18);
                    Settings.brick18 = MoveBrick(fromField, toField, Settings.brick18, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 24)
            {
                brickList = Settings.field24.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick18.Field.ToString()); }

                var canMoveResult = CanMoveBrick(24, Settings.brick18, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick18);
                    Settings.brick18 = MoveBrick(fromField, toField, Settings.brick18, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 25)
            {
                brickList = Settings.field25.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick18.Field.ToString()); }

                var canMoveResult = CanMoveBrick(25, Settings.brick18, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick18);
                    Settings.brick18 = MoveBrick(fromField, toField, Settings.brick18, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 26)
            {
                brickList = Settings.field26.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick18.Field.ToString()); }

                var canMoveResult = CanMoveBrick(26, Settings.brick18, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick18);
                    Settings.brick18 = MoveBrick(fromField, toField, Settings.brick18, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 27)
            {
                brickList = Settings.field27.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick18.Field.ToString()); }

                var canMoveResult = CanMoveBrick(27, Settings.brick18, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick18);
                    Settings.brick18 = MoveBrick(fromField, toField, Settings.brick18, brickList);

                    setLocationPictureBox();
                }
            }
        }

        private void pictureBoxBlack_4_Click(object sender, EventArgs e)
        {

            int fieldnr = Settings.brick19.Field;
            if (fieldnr == 0)
            {
                brickList = Settings.field0.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick19.Field.ToString()); }

                var canMoveResult = CanMoveBrick(0, Settings.brick19, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick19);
                    Settings.brick19 = MoveBrick(fromField, toField, Settings.brick19, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 1)
            {
                brickList = Settings.field1.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick19.Field.ToString()); }

                var canMoveResult = CanMoveBrick(1, Settings.brick19, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick19);
                    Settings.brick19 = MoveBrick(fromField, toField, Settings.brick19, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 2)
            {
                brickList = Settings.field2.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick19.Field.ToString()); }

                var canMoveResult = CanMoveBrick(2, Settings.brick19, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick19);
                    Settings.brick19 = MoveBrick(fromField, toField, Settings.brick19, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 3)
            {
                brickList = Settings.field3.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick19.Field.ToString()); }

                var canMoveResult = CanMoveBrick(3, Settings.brick19, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick19);
                    Settings.brick19 = MoveBrick(fromField, toField, Settings.brick19, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 4)
            {
                brickList = Settings.field4.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick19.Field.ToString()); }

                var canMoveResult = CanMoveBrick(4, Settings.brick19, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick19);
                    Settings.brick19 = MoveBrick(fromField, toField, Settings.brick19, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 5)
            {
                brickList = Settings.field5.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick19.Field.ToString()); }

                var canMoveResult = CanMoveBrick(5, Settings.brick19, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick19);
                    Settings.brick19 = MoveBrick(fromField, toField, Settings.brick19, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 6)
            {
                brickList = Settings.field6.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick19.Field.ToString()); }

                var canMoveResult = CanMoveBrick(6, Settings.brick19, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick19);
                    Settings.brick19 = MoveBrick(fromField, toField, Settings.brick19, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 7)
            {
                brickList = Settings.field7.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick19.Field.ToString()); }

                var canMoveResult = CanMoveBrick(7, Settings.brick19, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick19);
                    Settings.brick19 = MoveBrick(fromField, toField, Settings.brick19, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 8)
            {
                brickList = Settings.field8.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick19.Field.ToString()); }

                var canMoveResult = CanMoveBrick(8, Settings.brick19, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick19);
                    Settings.brick19 = MoveBrick(fromField, toField, Settings.brick19, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 9)
            {
                brickList = Settings.field9.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick19.Field.ToString()); }

                var canMoveResult = CanMoveBrick(9, Settings.brick19, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick19);
                    Settings.brick19 = MoveBrick(fromField, toField, Settings.brick19, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 10)
            {
                brickList = Settings.field10.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick19.Field.ToString()); }

                var canMoveResult = CanMoveBrick(10, Settings.brick19, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick19);
                    Settings.brick19 = MoveBrick(fromField, toField, Settings.brick19, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 11)
            {
                brickList = Settings.field11.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick19.Field.ToString()); }

                var canMoveResult = CanMoveBrick(11, Settings.brick19, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick19);
                    Settings.brick19 = MoveBrick(fromField, toField, Settings.brick19, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 12)
            {
                brickList = Settings.field12.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick19.Field.ToString()); }

                var canMoveResult = CanMoveBrick(12, Settings.brick19, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick19);
                    Settings.brick19 = MoveBrick(fromField, toField, Settings.brick19, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 13)
            {
                brickList = Settings.field13.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick19.Field.ToString()); }

                var canMoveResult = CanMoveBrick(13, Settings.brick19, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick19);
                    Settings.brick19 = MoveBrick(fromField, toField, Settings.brick19, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 14)
            {
                brickList = Settings.field14.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick19.Field.ToString()); }

                var canMoveResult = CanMoveBrick(14, Settings.brick19, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick19);
                    Settings.brick19 = MoveBrick(fromField, toField, Settings.brick19, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 15)
            {
                brickList = Settings.field15.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick19.Field.ToString()); }

                var canMoveResult = CanMoveBrick(15, Settings.brick19, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick19);
                    Settings.brick19 = MoveBrick(fromField, toField, Settings.brick19, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 16)
            {
                brickList = Settings.field16.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick19.Field.ToString()); }

                var canMoveResult = CanMoveBrick(16, Settings.brick19, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick19);
                    Settings.brick19 = MoveBrick(fromField, toField, Settings.brick19, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 17)
            {
                brickList = Settings.field17.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick19.Field.ToString()); }

                var canMoveResult = CanMoveBrick(17, Settings.brick19, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick19);
                    Settings.brick19 = MoveBrick(fromField, toField, Settings.brick19, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 18)
            {
                brickList = Settings.field18.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick19.Field.ToString()); }

                var canMoveResult = CanMoveBrick(18, Settings.brick19, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick19);
                    Settings.brick19 = MoveBrick(fromField, toField, Settings.brick19, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 19)
            {
                brickList = Settings.field19.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick19.Field.ToString()); }

                var canMoveResult = CanMoveBrick(10, Settings.brick19, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick19);
                    Settings.brick19 = MoveBrick(fromField, toField, Settings.brick19, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 20)
            {
                brickList = Settings.field20.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick19.Field.ToString()); }

                var canMoveResult = CanMoveBrick(20, Settings.brick19, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick19);
                    Settings.brick19 = MoveBrick(fromField, toField, Settings.brick19, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 21)
            {
                brickList = Settings.field21.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick19.Field.ToString()); }

                var canMoveResult = CanMoveBrick(21, Settings.brick19, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick19);
                    Settings.brick19 = MoveBrick(fromField, toField, Settings.brick19, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 22)
            {
                brickList = Settings.field22.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick19.Field.ToString()); }

                var canMoveResult = CanMoveBrick(22, Settings.brick19, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick19);
                    Settings.brick19 = MoveBrick(fromField, toField, Settings.brick19, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 23)
            {
                brickList = Settings.field23.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick19.Field.ToString()); }

                var canMoveResult = CanMoveBrick(23, Settings.brick19, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick19);
                    Settings.brick19 = MoveBrick(fromField, toField, Settings.brick19, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 24)
            {
                brickList = Settings.field24.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick19.Field.ToString()); }

                var canMoveResult = CanMoveBrick(24, Settings.brick19, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick19);
                    Settings.brick19 = MoveBrick(fromField, toField, Settings.brick19, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 25)
            {
                brickList = Settings.field25.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick19.Field.ToString()); }

                var canMoveResult = CanMoveBrick(25, Settings.brick19, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick19);
                    Settings.brick19 = MoveBrick(fromField, toField, Settings.brick19, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 26)
            {
                brickList = Settings.field26.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick19.Field.ToString()); }

                var canMoveResult = CanMoveBrick(26, Settings.brick19, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick19);
                    Settings.brick19 = MoveBrick(fromField, toField, Settings.brick19, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 27)
            {
                brickList = Settings.field27.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick19.Field.ToString()); }

                var canMoveResult = CanMoveBrick(27, Settings.brick19, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick19);
                    Settings.brick19 = MoveBrick(fromField, toField, Settings.brick19, brickList);

                    setLocationPictureBox();
                }
            }
        }

        private void pictureBoxBlack_5_Click(object sender, EventArgs e)
        {

            int fieldnr = Settings.brick20.Field;
            if (fieldnr == 0)
            {
                brickList = Settings.field0.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick20.Field.ToString()); }

                var canMoveResult = CanMoveBrick(0, Settings.brick20, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick20);
                    Settings.brick20 = MoveBrick(fromField, toField, Settings.brick20, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 1)
            {
                brickList = Settings.field1.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick20.Field.ToString()); }

                var canMoveResult = CanMoveBrick(1, Settings.brick20, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick20);
                    Settings.brick20 = MoveBrick(fromField, toField, Settings.brick20, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 2)
            {
                brickList = Settings.field2.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick20.Field.ToString()); }

                var canMoveResult = CanMoveBrick(2, Settings.brick20, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick20);
                    Settings.brick20 = MoveBrick(fromField, toField, Settings.brick20, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 3)
            {
                brickList = Settings.field3.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick20.Field.ToString()); }

                var canMoveResult = CanMoveBrick(3, Settings.brick20, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick20);
                    Settings.brick20 = MoveBrick(fromField, toField, Settings.brick20, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 4)
            {
                brickList = Settings.field4.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick20.Field.ToString()); }

                var canMoveResult = CanMoveBrick(4, Settings.brick20, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick20);
                    Settings.brick20 = MoveBrick(fromField, toField, Settings.brick20, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 5)
            {
                brickList = Settings.field5.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick20.Field.ToString()); }

                var canMoveResult = CanMoveBrick(5, Settings.brick20, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick20);
                    Settings.brick20 = MoveBrick(fromField, toField, Settings.brick20, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 6)
            {
                brickList = Settings.field6.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick20.Field.ToString()); }

                var canMoveResult = CanMoveBrick(6, Settings.brick20, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick20);
                    Settings.brick20 = MoveBrick(fromField, toField, Settings.brick20, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 7)
            {
                brickList = Settings.field7.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick20.Field.ToString()); }

                var canMoveResult = CanMoveBrick(7, Settings.brick20, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick20);
                    Settings.brick20 = MoveBrick(fromField, toField, Settings.brick20, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 8)
            {
                brickList = Settings.field8.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick20.Field.ToString()); }

                var canMoveResult = CanMoveBrick(8, Settings.brick20, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick20);
                    Settings.brick20 = MoveBrick(fromField, toField, Settings.brick20, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 9)
            {
                brickList = Settings.field9.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick20.Field.ToString()); }

                var canMoveResult = CanMoveBrick(9, Settings.brick20, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick20);
                    Settings.brick20 = MoveBrick(fromField, toField, Settings.brick20, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 10)
            {
                brickList = Settings.field10.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick20.Field.ToString()); }

                var canMoveResult = CanMoveBrick(10, Settings.brick20, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick20);
                    Settings.brick20 = MoveBrick(fromField, toField, Settings.brick20, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 11)
            {
                brickList = Settings.field11.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick20.Field.ToString()); }

                var canMoveResult = CanMoveBrick(11, Settings.brick20, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick20);
                    Settings.brick20 = MoveBrick(fromField, toField, Settings.brick20, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 12)
            {
                brickList = Settings.field12.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick20.Field.ToString()); }

                var canMoveResult = CanMoveBrick(12, Settings.brick20, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick20);
                    Settings.brick20 = MoveBrick(fromField, toField, Settings.brick20, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 13)
            {
                brickList = Settings.field13.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick20.Field.ToString()); }

                var canMoveResult = CanMoveBrick(13, Settings.brick20, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick20);
                    Settings.brick20 = MoveBrick(fromField, toField, Settings.brick20, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 14)
            {
                brickList = Settings.field14.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick20.Field.ToString()); }

                var canMoveResult = CanMoveBrick(14, Settings.brick20, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick20);
                    Settings.brick20 = MoveBrick(fromField, toField, Settings.brick20, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 15)
            {
                brickList = Settings.field15.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick20.Field.ToString()); }

                var canMoveResult = CanMoveBrick(15, Settings.brick20, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick20);
                    Settings.brick20 = MoveBrick(fromField, toField, Settings.brick20, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 16)
            {
                brickList = Settings.field16.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick20.Field.ToString()); }

                var canMoveResult = CanMoveBrick(16, Settings.brick20, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick20);
                    Settings.brick20 = MoveBrick(fromField, toField, Settings.brick20, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 17)
            {
                brickList = Settings.field17.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick20.Field.ToString()); }

                var canMoveResult = CanMoveBrick(17, Settings.brick20, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick20);
                    Settings.brick20 = MoveBrick(fromField, toField, Settings.brick20, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 18)
            {
                brickList = Settings.field18.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick20.Field.ToString()); }

                var canMoveResult = CanMoveBrick(18, Settings.brick20, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick20);
                    Settings.brick20 = MoveBrick(fromField, toField, Settings.brick20, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 19)
            {
                brickList = Settings.field19.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick20.Field.ToString()); }

                var canMoveResult = CanMoveBrick(19, Settings.brick20, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick20);
                    Settings.brick20 = MoveBrick(fromField, toField, Settings.brick20, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 20)
            {
                brickList = Settings.field20.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick20.Field.ToString()); }

                var canMoveResult = CanMoveBrick(20, Settings.brick20, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick20);
                    Settings.brick20 = MoveBrick(fromField, toField, Settings.brick20, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 21)
            {
                brickList = Settings.field21.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick20.Field.ToString()); }

                var canMoveResult = CanMoveBrick(21, Settings.brick20, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick20);
                    Settings.brick20 = MoveBrick(fromField, toField, Settings.brick20, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 22)
            {
                brickList = Settings.field22.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick20.Field.ToString()); }

                var canMoveResult = CanMoveBrick(22, Settings.brick20, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick20);
                    Settings.brick20 = MoveBrick(fromField, toField, Settings.brick20, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 23)
            {
                brickList = Settings.field23.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick20.Field.ToString()); }

                var canMoveResult = CanMoveBrick(23, Settings.brick20, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick20);
                    Settings.brick20 = MoveBrick(fromField, toField, Settings.brick20, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 24)
            {
                brickList = Settings.field24.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick20.Field.ToString()); }

                var canMoveResult = CanMoveBrick(24, Settings.brick20, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick20);
                    Settings.brick20 = MoveBrick(fromField, toField, Settings.brick20, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 25)
            {
                brickList = Settings.field25.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick20.Field.ToString()); }

                var canMoveResult = CanMoveBrick(25, Settings.brick20, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick20);
                    Settings.brick20 = MoveBrick(fromField, toField, Settings.brick20, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 26)
            {
                brickList = Settings.field26.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick20.Field.ToString()); }

                var canMoveResult = CanMoveBrick(26, Settings.brick20, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick20);
                    Settings.brick20 = MoveBrick(fromField, toField, Settings.brick20, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 27)
            {
                brickList = Settings.field27.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick20.Field.ToString()); }

                var canMoveResult = CanMoveBrick(27, Settings.brick20, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick20);
                    Settings.brick20 = MoveBrick(fromField, toField, Settings.brick20, brickList);

                    setLocationPictureBox();
                }
            }
        }

        private void pictureBoxBlack_6_Click(object sender, EventArgs e)
        {

            int fieldnr = Settings.brick21.Field;
            if (fieldnr == 0)
            {
                brickList = Settings.field0.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick21.Field.ToString()); }

                var canMoveResult = CanMoveBrick(0, Settings.brick21, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick21);
                    Settings.brick21 = MoveBrick(fromField, toField, Settings.brick21, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 1)
            {
                brickList = Settings.field1.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick21.Field.ToString()); }

                var canMoveResult = CanMoveBrick(1, Settings.brick21, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick21);
                    Settings.brick21 = MoveBrick(fromField, toField, Settings.brick21, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 2)
            {
                brickList = Settings.field2.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick21.Field.ToString()); }

                var canMoveResult = CanMoveBrick(2, Settings.brick21, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick21);
                    Settings.brick21 = MoveBrick(fromField, toField, Settings.brick21, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 3)
            {
                brickList = Settings.field3.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick21.Field.ToString()); }

                var canMoveResult = CanMoveBrick(3, Settings.brick21, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick21);
                    Settings.brick21 = MoveBrick(fromField, toField, Settings.brick21, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 4)
            {
                brickList = Settings.field4.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick21.Field.ToString()); }

                var canMoveResult = CanMoveBrick(4, Settings.brick21, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick21);
                    Settings.brick21 = MoveBrick(fromField, toField, Settings.brick21, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 5)
            {
                brickList = Settings.field5.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick21.Field.ToString()); }

                var canMoveResult = CanMoveBrick(5, Settings.brick21, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick21);
                    Settings.brick21 = MoveBrick(fromField, toField, Settings.brick21, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 6)
            {
                brickList = Settings.field6.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick21.Field.ToString()); }

                var canMoveResult = CanMoveBrick(6, Settings.brick21, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick21);
                    Settings.brick21 = MoveBrick(fromField, toField, Settings.brick21, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 7)
            {
                brickList = Settings.field7.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick21.Field.ToString()); }

                var canMoveResult = CanMoveBrick(7, Settings.brick21, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick21);
                    Settings.brick21 = MoveBrick(fromField, toField, Settings.brick21, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 8)
            {
                brickList = Settings.field8.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick21.Field.ToString()); }

                var canMoveResult = CanMoveBrick(8, Settings.brick21, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick21);
                    Settings.brick21 = MoveBrick(fromField, toField, Settings.brick21, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 9)
            {
                brickList = Settings.field9.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick21.Field.ToString()); }

                var canMoveResult = CanMoveBrick(9, Settings.brick21, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick21);
                    Settings.brick21 = MoveBrick(fromField, toField, Settings.brick21, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 10)
            {
                brickList = Settings.field10.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick21.Field.ToString()); }

                var canMoveResult = CanMoveBrick(10, Settings.brick21, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick21);
                    Settings.brick21 = MoveBrick(fromField, toField, Settings.brick21, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 11)
            {
                brickList = Settings.field11.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick21.Field.ToString()); }

                var canMoveResult = CanMoveBrick(11, Settings.brick21, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick21);
                    Settings.brick21 = MoveBrick(fromField, toField, Settings.brick21, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 12)
            {
                brickList = Settings.field12.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick21.Field.ToString()); }

                var canMoveResult = CanMoveBrick(12, Settings.brick21, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick21);
                    Settings.brick21 = MoveBrick(fromField, toField, Settings.brick21, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 13)
            {
                brickList = Settings.field13.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick21.Field.ToString()); }

                var canMoveResult = CanMoveBrick(13, Settings.brick21, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick21);
                    Settings.brick21 = MoveBrick(fromField, toField, Settings.brick21, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 14)
            {
                brickList = Settings.field14.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick21.Field.ToString()); }

                var canMoveResult = CanMoveBrick(14, Settings.brick21, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick21);
                    Settings.brick21 = MoveBrick(fromField, toField, Settings.brick21, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 15)
            {
                brickList = Settings.field15.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick21.Field.ToString()); }

                var canMoveResult = CanMoveBrick(15, Settings.brick21, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick21);
                    Settings.brick21 = MoveBrick(fromField, toField, Settings.brick21, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 16)
            {
                brickList = Settings.field16.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick21.Field.ToString()); }

                var canMoveResult = CanMoveBrick(16, Settings.brick21, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick21);
                    Settings.brick21 = MoveBrick(fromField, toField, Settings.brick21, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 17)
            {
                brickList = Settings.field17.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick21.Field.ToString()); }

                var canMoveResult = CanMoveBrick(17, Settings.brick21, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick21);
                    Settings.brick21 = MoveBrick(fromField, toField, Settings.brick21, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 18)
            {
                brickList = Settings.field18.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick21.Field.ToString()); }

                var canMoveResult = CanMoveBrick(18, Settings.brick21, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick21);
                    Settings.brick21 = MoveBrick(fromField, toField, Settings.brick21, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 19)
            {
                brickList = Settings.field19.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick21.Field.ToString()); }

                var canMoveResult = CanMoveBrick(19, Settings.brick21, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick21);
                    Settings.brick21 = MoveBrick(fromField, toField, Settings.brick21, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 20)
            {
                brickList = Settings.field20.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick21.Field.ToString()); }

                var canMoveResult = CanMoveBrick(20, Settings.brick21, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick21);
                    Settings.brick21 = MoveBrick(fromField, toField, Settings.brick21, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 21)
            {
                brickList = Settings.field21.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick21.Field.ToString()); }

                var canMoveResult = CanMoveBrick(21, Settings.brick21, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick21);
                    Settings.brick21 = MoveBrick(fromField, toField, Settings.brick21, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 22)
            {
                brickList = Settings.field22.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick21.Field.ToString()); }

                var canMoveResult = CanMoveBrick(22, Settings.brick21, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick21);
                    Settings.brick21 = MoveBrick(fromField, toField, Settings.brick21, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 23)
            {
                brickList = Settings.field23.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick21.Field.ToString()); }

                var canMoveResult = CanMoveBrick(23, Settings.brick21, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick21);
                    Settings.brick21 = MoveBrick(fromField, toField, Settings.brick21, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 24)
            {
                brickList = Settings.field24.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick21.Field.ToString()); }

                var canMoveResult = CanMoveBrick(24, Settings.brick21, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick21);
                    Settings.brick21 = MoveBrick(fromField, toField, Settings.brick21, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 25)
            {
                brickList = Settings.field25.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick21.Field.ToString()); }

                var canMoveResult = CanMoveBrick(25, Settings.brick21, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick21);
                    Settings.brick21 = MoveBrick(fromField, toField, Settings.brick21, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 26)
            {
                brickList = Settings.field26.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick21.Field.ToString()); }

                var canMoveResult = CanMoveBrick(26, Settings.brick21, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick21);
                    Settings.brick21 = MoveBrick(fromField, toField, Settings.brick21, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 27)
            {
                brickList = Settings.field27.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick21.Field.ToString()); }

                var canMoveResult = CanMoveBrick(27, Settings.brick21, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick21);
                    Settings.brick21 = MoveBrick(fromField, toField, Settings.brick21, brickList);

                    setLocationPictureBox();
                }
            }
        }

        private void pictureBoxBlack_7_Click(object sender, EventArgs e)
        {

            int fieldnr = Settings.brick22.Field;
            if (fieldnr == 0)
            {
                brickList = Settings.field0.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick22.Field.ToString()); }

                var canMoveResult = CanMoveBrick(0, Settings.brick22, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick22);
                    Settings.brick22 = MoveBrick(fromField, toField, Settings.brick22, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 1)
            {
                brickList = Settings.field1.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick22.Field.ToString()); }

                var canMoveResult = CanMoveBrick(1, Settings.brick22, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick22);
                    Settings.brick22 = MoveBrick(fromField, toField, Settings.brick22, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 2)
            {
                brickList = Settings.field2.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick22.Field.ToString()); }

                var canMoveResult = CanMoveBrick(2, Settings.brick22, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick22);
                    Settings.brick22 = MoveBrick(fromField, toField, Settings.brick22, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 3)
            {
                brickList = Settings.field3.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick22.Field.ToString()); }

                var canMoveResult = CanMoveBrick(3, Settings.brick22, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick22);
                    Settings.brick22 = MoveBrick(fromField, toField, Settings.brick22, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 4)
            {
                brickList = Settings.field4.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick22.Field.ToString()); }

                var canMoveResult = CanMoveBrick(4, Settings.brick22, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick22);
                    Settings.brick22 = MoveBrick(fromField, toField, Settings.brick22, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 5)
            {
                brickList = Settings.field5.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick22.Field.ToString()); }

                var canMoveResult = CanMoveBrick(5, Settings.brick22, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick22);
                    Settings.brick22 = MoveBrick(fromField, toField, Settings.brick22, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 6)
            {
                brickList = Settings.field6.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick22.Field.ToString()); }

                var canMoveResult = CanMoveBrick(6, Settings.brick22, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick22);
                    Settings.brick22 = MoveBrick(fromField, toField, Settings.brick22, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 7)
            {
                brickList = Settings.field7.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick22.Field.ToString()); }

                var canMoveResult = CanMoveBrick(7, Settings.brick22, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick22);
                    Settings.brick22 = MoveBrick(fromField, toField, Settings.brick22, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 8)
            {
                brickList = Settings.field8.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick22.Field.ToString()); }

                var canMoveResult = CanMoveBrick(8, Settings.brick22, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick22);
                    Settings.brick22 = MoveBrick(fromField, toField, Settings.brick22, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 9)
            {
                brickList = Settings.field9.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick22.Field.ToString()); }

                var canMoveResult = CanMoveBrick(9, Settings.brick22, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick22);
                    Settings.brick22 = MoveBrick(fromField, toField, Settings.brick22, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 10)
            {
                brickList = Settings.field10.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick22.Field.ToString()); }

                var canMoveResult = CanMoveBrick(10, Settings.brick22, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick22);
                    Settings.brick22 = MoveBrick(fromField, toField, Settings.brick22, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 11)
            {
                brickList = Settings.field11.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick22.Field.ToString()); }

                var canMoveResult = CanMoveBrick(11, Settings.brick22, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick22);
                    Settings.brick22 = MoveBrick(fromField, toField, Settings.brick22, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 12)
            {
                brickList = Settings.field12.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick22.Field.ToString()); }

                var canMoveResult = CanMoveBrick(12, Settings.brick22, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick22);
                    Settings.brick22 = MoveBrick(fromField, toField, Settings.brick22, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 13)
            {
                brickList = Settings.field13.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick22.Field.ToString()); }

                var canMoveResult = CanMoveBrick(13, Settings.brick22, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick22);
                    Settings.brick22 = MoveBrick(fromField, toField, Settings.brick22, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 14)
            {
                brickList = Settings.field14.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick22.Field.ToString()); }

                var canMoveResult = CanMoveBrick(14, Settings.brick22, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick22);
                    Settings.brick22 = MoveBrick(fromField, toField, Settings.brick22, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 15)
            {
                brickList = Settings.field15.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick22.Field.ToString()); }

                var canMoveResult = CanMoveBrick(15, Settings.brick22, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick22);
                    Settings.brick22 = MoveBrick(fromField, toField, Settings.brick22, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 16)
            {
                brickList = Settings.field16.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick22.Field.ToString()); }

                var canMoveResult = CanMoveBrick(16, Settings.brick22, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick22);
                    Settings.brick22 = MoveBrick(fromField, toField, Settings.brick22, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 17)
            {
                brickList = Settings.field17.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick22.Field.ToString()); }

                var canMoveResult = CanMoveBrick(17, Settings.brick22, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick22);
                    Settings.brick22 = MoveBrick(fromField, toField, Settings.brick22, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 18)
            {
                brickList = Settings.field18.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick22.Field.ToString()); }

                var canMoveResult = CanMoveBrick(18, Settings.brick22, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick22);
                    Settings.brick22 = MoveBrick(fromField, toField, Settings.brick22, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 19)
            {
                brickList = Settings.field19.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick22.Field.ToString()); }

                var canMoveResult = CanMoveBrick(19, Settings.brick22, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick22);
                    Settings.brick22 = MoveBrick(fromField, toField, Settings.brick22, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 20)
            {
                brickList = Settings.field20.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick22.Field.ToString()); }

                var canMoveResult = CanMoveBrick(20, Settings.brick22, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick22);
                    Settings.brick22 = MoveBrick(fromField, toField, Settings.brick22, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 21)
            {
                brickList = Settings.field21.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick22.Field.ToString()); }

                var canMoveResult = CanMoveBrick(21, Settings.brick22, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick22);
                    Settings.brick22 = MoveBrick(fromField, toField, Settings.brick22, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 22)
            {
                brickList = Settings.field22.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick22.Field.ToString()); }

                var canMoveResult = CanMoveBrick(22, Settings.brick22, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick22);
                    Settings.brick22 = MoveBrick(fromField, toField, Settings.brick22, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 23)
            {
                brickList = Settings.field23.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick22.Field.ToString()); }

                var canMoveResult = CanMoveBrick(23, Settings.brick22, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick22);
                    Settings.brick22 = MoveBrick(fromField, toField, Settings.brick22, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 24)
            {
                brickList = Settings.field24.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick22.Field.ToString()); }

                var canMoveResult = CanMoveBrick(24, Settings.brick22, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick22);
                    Settings.brick22 = MoveBrick(fromField, toField, Settings.brick22, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 25)
            {
                brickList = Settings.field25.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick22.Field.ToString()); }

                var canMoveResult = CanMoveBrick(25, Settings.brick22, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick22);
                    Settings.brick22 = MoveBrick(fromField, toField, Settings.brick22, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 26)
            {
                brickList = Settings.field26.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick22.Field.ToString()); }

                var canMoveResult = CanMoveBrick(26, Settings.brick22, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick22);
                    Settings.brick22 = MoveBrick(fromField, toField, Settings.brick22, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 27)
            {
                brickList = Settings.field27.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick22.Field.ToString()); }

                var canMoveResult = CanMoveBrick(27, Settings.brick22, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick22);
                    Settings.brick22 = MoveBrick(fromField, toField, Settings.brick22, brickList);

                    setLocationPictureBox();
                }
            }
        }

        private void pictureBoxBlack_8_Click(object sender, EventArgs e)
        {

            int fieldnr = Settings.brick23.Field;
            if (fieldnr == 0)
            {
                brickList = Settings.field0.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick23.Field.ToString()); }

                var canMoveResult = CanMoveBrick(0, Settings.brick23, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick23);
                    Settings.brick23 = MoveBrick(fromField, toField, Settings.brick23, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 1)
            {
                brickList = Settings.field1.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick23.Field.ToString()); }

                var canMoveResult = CanMoveBrick(1, Settings.brick23, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick23);
                    Settings.brick23 = MoveBrick(fromField, toField, Settings.brick23, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 2)
            {
                brickList = Settings.field2.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick23.Field.ToString()); }

                var canMoveResult = CanMoveBrick(2, Settings.brick23, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick23);
                    Settings.brick23 = MoveBrick(fromField, toField, Settings.brick23, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 3)
            {
                brickList = Settings.field3.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick23.Field.ToString()); }

                var canMoveResult = CanMoveBrick(3, Settings.brick23, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick23);
                    Settings.brick23 = MoveBrick(fromField, toField, Settings.brick23, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 4)
            {
                brickList = Settings.field4.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick23.Field.ToString()); }

                var canMoveResult = CanMoveBrick(4, Settings.brick23, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick23);
                    Settings.brick23 = MoveBrick(fromField, toField, Settings.brick23, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 5)
            {
                brickList = Settings.field5.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick23.Field.ToString()); }

                var canMoveResult = CanMoveBrick(5, Settings.brick23, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick23);
                    Settings.brick23 = MoveBrick(fromField, toField, Settings.brick23, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 6)
            {
                brickList = Settings.field6.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick23.Field.ToString()); }

                var canMoveResult = CanMoveBrick(6, Settings.brick23, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick23);
                    Settings.brick23 = MoveBrick(fromField, toField, Settings.brick23, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 7)
            {
                brickList = Settings.field7.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick23.Field.ToString()); }

                var canMoveResult = CanMoveBrick(7, Settings.brick23, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick23);
                    Settings.brick23 = MoveBrick(fromField, toField, Settings.brick23, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 8)
            {
                brickList = Settings.field8.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick23.Field.ToString()); }

                var canMoveResult = CanMoveBrick(8, Settings.brick23, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick23);
                    Settings.brick23 = MoveBrick(fromField, toField, Settings.brick23, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 9)
            {
                brickList = Settings.field9.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick23.Field.ToString()); }

                var canMoveResult = CanMoveBrick(9, Settings.brick23, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick23);
                    Settings.brick23 = MoveBrick(fromField, toField, Settings.brick23, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 10)
            {
                brickList = Settings.field10.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick23.Field.ToString()); }

                var canMoveResult = CanMoveBrick(10, Settings.brick23, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick23);
                    Settings.brick23 = MoveBrick(fromField, toField, Settings.brick23, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 11)
            {
                brickList = Settings.field11.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick23.Field.ToString()); }

                var canMoveResult = CanMoveBrick(11, Settings.brick23, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick23);
                    Settings.brick23 = MoveBrick(fromField, toField, Settings.brick23, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 12)
            {
                brickList = Settings.field12.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick23.Field.ToString()); }

                var canMoveResult = CanMoveBrick(12, Settings.brick23, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick23);
                    Settings.brick23 = MoveBrick(fromField, toField, Settings.brick23, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 13)
            {
                brickList = Settings.field13.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick23.Field.ToString()); }

                var canMoveResult = CanMoveBrick(13, Settings.brick23, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick23);
                    Settings.brick23 = MoveBrick(fromField, toField, Settings.brick23, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 14)
            {
                brickList = Settings.field14.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick23.Field.ToString()); }

                var canMoveResult = CanMoveBrick(14, Settings.brick23, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick23);
                    Settings.brick23 = MoveBrick(fromField, toField, Settings.brick23, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 15)
            {
                brickList = Settings.field15.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick23.Field.ToString()); }

                var canMoveResult = CanMoveBrick(15, Settings.brick23, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick23);
                    Settings.brick23 = MoveBrick(fromField, toField, Settings.brick23, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 16)
            {
                brickList = Settings.field16.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick23.Field.ToString()); }

                var canMoveResult = CanMoveBrick(16, Settings.brick23, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick23);
                    Settings.brick23 = MoveBrick(fromField, toField, Settings.brick23, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 17)
            {
                brickList = Settings.field17.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick23.Field.ToString()); }

                var canMoveResult = CanMoveBrick(17, Settings.brick23, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick23);
                    Settings.brick23 = MoveBrick(fromField, toField, Settings.brick23, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 18)
            {
                brickList = Settings.field18.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick23.Field.ToString()); }

                var canMoveResult = CanMoveBrick(18, Settings.brick23, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick23);
                    Settings.brick23 = MoveBrick(fromField, toField, Settings.brick23, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 19)
            {
                brickList = Settings.field19.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick23.Field.ToString()); }

                var canMoveResult = CanMoveBrick(19, Settings.brick23, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick23);
                    Settings.brick23 = MoveBrick(fromField, toField, Settings.brick23, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 20)
            {
                brickList = Settings.field20.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick23.Field.ToString()); }

                var canMoveResult = CanMoveBrick(20, Settings.brick23, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick23);
                    Settings.brick23 = MoveBrick(fromField, toField, Settings.brick23, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 21)
            {
                brickList = Settings.field21.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick23.Field.ToString()); }

                var canMoveResult = CanMoveBrick(21, Settings.brick23, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick23);
                    Settings.brick23 = MoveBrick(fromField, toField, Settings.brick23, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 22)
            {
                brickList = Settings.field22.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick23.Field.ToString()); }

                var canMoveResult = CanMoveBrick(22, Settings.brick23, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick23);
                    Settings.brick23 = MoveBrick(fromField, toField, Settings.brick23, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 23)
            {
                brickList = Settings.field23.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick23.Field.ToString()); }

                var canMoveResult = CanMoveBrick(23, Settings.brick23, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick23);
                    Settings.brick23 = MoveBrick(fromField, toField, Settings.brick23, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 24)
            {
                brickList = Settings.field24.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick23.Field.ToString()); }

                var canMoveResult = CanMoveBrick(24, Settings.brick23, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick23);
                    Settings.brick23 = MoveBrick(fromField, toField, Settings.brick23, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 25)
            {
                brickList = Settings.field25.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick23.Field.ToString()); }

                var canMoveResult = CanMoveBrick(25, Settings.brick23, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick23);
                    Settings.brick23 = MoveBrick(fromField, toField, Settings.brick23, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 26)
            {
                brickList = Settings.field26.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick23.Field.ToString()); }

                var canMoveResult = CanMoveBrick(26, Settings.brick23, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick23);
                    Settings.brick23 = MoveBrick(fromField, toField, Settings.brick23, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 27)
            {
                brickList = Settings.field27.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick23.Field.ToString()); }

                var canMoveResult = CanMoveBrick(27, Settings.brick23, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick23);
                    Settings.brick23 = MoveBrick(fromField, toField, Settings.brick23, brickList);

                    setLocationPictureBox();
                }
            }
        }

        private void pictureBoxBlack_9_Click(object sender, EventArgs e)
        {

            int fieldnr = Settings.brick24.Field;
            if (fieldnr == 0)
            {
                brickList = Settings.field0.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick24.Field.ToString()); }

                var canMoveResult = CanMoveBrick(0, Settings.brick24, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick24);
                    Settings.brick24 = MoveBrick(fromField, toField, Settings.brick24, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 1)
            {
                brickList = Settings.field1.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick24.Field.ToString()); }

                var canMoveResult = CanMoveBrick(1, Settings.brick24, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick24);
                    Settings.brick24 = MoveBrick(fromField, toField, Settings.brick24, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 2)
            {
                brickList = Settings.field2.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick24.Field.ToString()); }

                var canMoveResult = CanMoveBrick(2, Settings.brick24, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick24);
                    Settings.brick24 = MoveBrick(fromField, toField, Settings.brick24, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 3)
            {
                brickList = Settings.field3.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick24.Field.ToString()); }

                var canMoveResult = CanMoveBrick(3, Settings.brick24, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick24);
                    Settings.brick24 = MoveBrick(fromField, toField, Settings.brick24, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 4)
            {
                brickList = Settings.field4.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick24.Field.ToString()); }

                var canMoveResult = CanMoveBrick(4, Settings.brick24, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick24);
                    Settings.brick24 = MoveBrick(fromField, toField, Settings.brick24, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 5)
            {
                brickList = Settings.field5.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick24.Field.ToString()); }

                var canMoveResult = CanMoveBrick(5, Settings.brick24, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick24);
                    Settings.brick24 = MoveBrick(fromField, toField, Settings.brick24, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 6)
            {
                brickList = Settings.field6.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick24.Field.ToString()); }

                var canMoveResult = CanMoveBrick(6, Settings.brick24, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick24);
                    Settings.brick24 = MoveBrick(fromField, toField, Settings.brick24, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 7)
            {
                brickList = Settings.field7.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick24.Field.ToString()); }

                var canMoveResult = CanMoveBrick(7, Settings.brick24, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick24);
                    Settings.brick24 = MoveBrick(fromField, toField, Settings.brick24, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 8)
            {
                brickList = Settings.field8.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick24.Field.ToString()); }

                var canMoveResult = CanMoveBrick(8, Settings.brick24, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick24);
                    Settings.brick24 = MoveBrick(fromField, toField, Settings.brick24, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 9)
            {
                brickList = Settings.field9.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick24.Field.ToString()); }

                var canMoveResult = CanMoveBrick(9, Settings.brick24, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick24);
                    Settings.brick24 = MoveBrick(fromField, toField, Settings.brick24, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 10)
            {
                brickList = Settings.field10.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick24.Field.ToString()); }

                var canMoveResult = CanMoveBrick(10, Settings.brick24, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick24);
                    Settings.brick24 = MoveBrick(fromField, toField, Settings.brick24, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 11)
            {
                brickList = Settings.field11.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick24.Field.ToString()); }

                var canMoveResult = CanMoveBrick(11, Settings.brick24, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick24);
                    Settings.brick24 = MoveBrick(fromField, toField, Settings.brick24, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 12)
            {
                brickList = Settings.field12.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick24.Field.ToString()); }

                var canMoveResult = CanMoveBrick(12, Settings.brick24, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick24);
                    Settings.brick24 = MoveBrick(fromField, toField, Settings.brick24, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 13)
            {
                brickList = Settings.field13.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick24.Field.ToString()); }

                var canMoveResult = CanMoveBrick(13, Settings.brick24, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick24);
                    Settings.brick24 = MoveBrick(fromField, toField, Settings.brick24, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 14)
            {
                brickList = Settings.field14.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick24.Field.ToString()); }

                var canMoveResult = CanMoveBrick(14, Settings.brick24, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick24);
                    Settings.brick24 = MoveBrick(fromField, toField, Settings.brick24, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 15)
            {
                brickList = Settings.field15.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick24.Field.ToString()); }

                var canMoveResult = CanMoveBrick(15, Settings.brick24, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick24);
                    Settings.brick24 = MoveBrick(fromField, toField, Settings.brick24, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 16)
            {
                brickList = Settings.field16.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick24.Field.ToString()); }

                var canMoveResult = CanMoveBrick(16, Settings.brick24, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick24);
                    Settings.brick24 = MoveBrick(fromField, toField, Settings.brick24, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 17)
            {
                brickList = Settings.field17.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick24.Field.ToString()); }

                var canMoveResult = CanMoveBrick(17, Settings.brick24, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick24);
                    Settings.brick24 = MoveBrick(fromField, toField, Settings.brick24, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 18)
            {
                brickList = Settings.field18.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick24.Field.ToString()); }

                var canMoveResult = CanMoveBrick(18, Settings.brick24, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick24);
                    Settings.brick24 = MoveBrick(fromField, toField, Settings.brick24, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 19)
            {
                brickList = Settings.field19.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick24.Field.ToString()); }

                var canMoveResult = CanMoveBrick(19, Settings.brick24, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick24);
                    Settings.brick24 = MoveBrick(fromField, toField, Settings.brick24, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 20)
            {
                brickList = Settings.field20.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick24.Field.ToString()); }

                var canMoveResult = CanMoveBrick(20, Settings.brick24, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick24);
                    Settings.brick24 = MoveBrick(fromField, toField, Settings.brick24, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 21)
            {
                brickList = Settings.field21.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick24.Field.ToString()); }

                var canMoveResult = CanMoveBrick(21, Settings.brick24, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick24);
                    Settings.brick24 = MoveBrick(fromField, toField, Settings.brick24, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 22)
            {
                brickList = Settings.field22.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick24.Field.ToString()); }

                var canMoveResult = CanMoveBrick(22, Settings.brick24, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick24);
                    Settings.brick24 = MoveBrick(fromField, toField, Settings.brick24, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 23)
            {
                brickList = Settings.field23.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick24.Field.ToString()); }

                var canMoveResult = CanMoveBrick(23, Settings.brick24, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick24);
                    Settings.brick24 = MoveBrick(fromField, toField, Settings.brick24, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 24)
            {
                brickList = Settings.field24.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick24.Field.ToString()); }

                var canMoveResult = CanMoveBrick(24, Settings.brick24, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick24);
                    Settings.brick24 = MoveBrick(fromField, toField, Settings.brick24, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 25)
            {
                brickList = Settings.field25.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick24.Field.ToString()); }

                var canMoveResult = CanMoveBrick(25, Settings.brick24, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick24);
                    Settings.brick24 = MoveBrick(fromField, toField, Settings.brick24, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 26)
            {
                brickList = Settings.field26.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick24.Field.ToString()); }

                var canMoveResult = CanMoveBrick(26, Settings.brick24, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick24);
                    Settings.brick24 = MoveBrick(fromField, toField, Settings.brick24, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 27)
            {
                brickList = Settings.field27.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick24.Field.ToString()); }

                var canMoveResult = CanMoveBrick(27, Settings.brick24, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick24);
                    Settings.brick24 = MoveBrick(fromField, toField, Settings.brick24, brickList);

                    setLocationPictureBox();
                }
            }
        }

        private void pictureBoxBlack_10_Click(object sender, EventArgs e)
        {

            int fieldnr = Settings.brick25.Field;
            if (fieldnr == 0)
            {
                brickList = Settings.field0.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick25.Field.ToString()); }

                var canMoveResult = CanMoveBrick(0, Settings.brick25, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick25);
                    Settings.brick25 = MoveBrick(fromField, toField, Settings.brick25, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 1)
            {
                brickList = Settings.field1.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick25.Field.ToString()); }

                var canMoveResult = CanMoveBrick(1, Settings.brick25, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick25);
                    Settings.brick25 = MoveBrick(fromField, toField, Settings.brick25, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 2)
            {
                brickList = Settings.field2.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick25.Field.ToString()); }

                var canMoveResult = CanMoveBrick(2, Settings.brick25, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick25);
                    Settings.brick25 = MoveBrick(fromField, toField, Settings.brick25, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 3)
            {
                brickList = Settings.field3.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick25.Field.ToString()); }

                var canMoveResult = CanMoveBrick(3, Settings.brick25, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick25);
                    Settings.brick25 = MoveBrick(fromField, toField, Settings.brick25, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 4)
            {
                brickList = Settings.field4.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick25.Field.ToString()); }

                var canMoveResult = CanMoveBrick(4, Settings.brick25, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick25);
                    Settings.brick25 = MoveBrick(fromField, toField, Settings.brick25, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 5)
            {
                brickList = Settings.field5.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick25.Field.ToString()); }

                var canMoveResult = CanMoveBrick(5, Settings.brick25, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick25);
                    Settings.brick25 = MoveBrick(fromField, toField, Settings.brick25, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 6)
            {
                brickList = Settings.field6.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick25.Field.ToString()); }

                var canMoveResult = CanMoveBrick(6, Settings.brick25, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick25);
                    Settings.brick25 = MoveBrick(fromField, toField, Settings.brick25, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 7)
            {
                brickList = Settings.field7.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick25.Field.ToString()); }

                var canMoveResult = CanMoveBrick(7, Settings.brick25, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick25);
                    Settings.brick25 = MoveBrick(fromField, toField, Settings.brick25, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 8)
            {
                brickList = Settings.field8.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick25.Field.ToString()); }

                var canMoveResult = CanMoveBrick(8, Settings.brick25, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick25);
                    Settings.brick25 = MoveBrick(fromField, toField, Settings.brick25, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 9)
            {
                brickList = Settings.field9.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick25.Field.ToString()); }

                var canMoveResult = CanMoveBrick(9, Settings.brick25, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick25);
                    Settings.brick25 = MoveBrick(fromField, toField, Settings.brick25, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 10)
            {
                brickList = Settings.field10.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick25.Field.ToString()); }

                var canMoveResult = CanMoveBrick(10, Settings.brick25, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick25);
                    Settings.brick25 = MoveBrick(fromField, toField, Settings.brick25, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 11)
            {
                brickList = Settings.field11.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick25.Field.ToString()); }

                var canMoveResult = CanMoveBrick(11, Settings.brick25, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick25);
                    Settings.brick25 = MoveBrick(fromField, toField, Settings.brick25, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 12)
            {
                brickList = Settings.field12.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick25.Field.ToString()); }

                var canMoveResult = CanMoveBrick(12, Settings.brick25, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick25);
                    Settings.brick25 = MoveBrick(fromField, toField, Settings.brick25, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 13)
            {
                brickList = Settings.field13.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick25.Field.ToString()); }

                var canMoveResult = CanMoveBrick(13, Settings.brick25, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick25);
                    Settings.brick25 = MoveBrick(fromField, toField, Settings.brick25, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 14)
            {
                brickList = Settings.field14.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick25.Field.ToString()); }

                var canMoveResult = CanMoveBrick(14, Settings.brick25, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick25);
                    Settings.brick25 = MoveBrick(fromField, toField, Settings.brick25, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 15)
            {
                brickList = Settings.field15.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick25.Field.ToString()); }

                var canMoveResult = CanMoveBrick(15, Settings.brick25, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick25);
                    Settings.brick25 = MoveBrick(fromField, toField, Settings.brick25, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 16)
            {
                brickList = Settings.field16.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick25.Field.ToString()); }

                var canMoveResult = CanMoveBrick(16, Settings.brick25, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick25);
                    Settings.brick25 = MoveBrick(fromField, toField, Settings.brick25, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 17)
            {
                brickList = Settings.field17.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick25.Field.ToString()); }

                var canMoveResult = CanMoveBrick(17, Settings.brick25, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick25);
                    Settings.brick25 = MoveBrick(fromField, toField, Settings.brick25, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 18)
            {
                brickList = Settings.field18.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick25.Field.ToString()); }

                var canMoveResult = CanMoveBrick(18, Settings.brick25, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick25);
                    Settings.brick25 = MoveBrick(fromField, toField, Settings.brick25, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 19)
            {
                brickList = Settings.field19.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick25.Field.ToString()); }

                var canMoveResult = CanMoveBrick(19, Settings.brick25, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick25);
                    Settings.brick25 = MoveBrick(fromField, toField, Settings.brick25, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 20)
            {
                brickList = Settings.field20.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick25.Field.ToString()); }

                var canMoveResult = CanMoveBrick(20, Settings.brick25, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick25);
                    Settings.brick25 = MoveBrick(fromField, toField, Settings.brick25, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 21)
            {
                brickList = Settings.field21.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick25.Field.ToString()); }

                var canMoveResult = CanMoveBrick(21, Settings.brick25, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick25);
                    Settings.brick25 = MoveBrick(fromField, toField, Settings.brick25, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 22)
            {
                brickList = Settings.field22.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick25.Field.ToString()); }

                var canMoveResult = CanMoveBrick(22, Settings.brick25, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick25);
                    Settings.brick25 = MoveBrick(fromField, toField, Settings.brick25, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 23)
            {
                brickList = Settings.field23.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick25.Field.ToString()); }

                var canMoveResult = CanMoveBrick(23, Settings.brick25, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick25);
                    Settings.brick25 = MoveBrick(fromField, toField, Settings.brick25, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 24)
            {
                brickList = Settings.field24.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick25.Field.ToString()); }

                var canMoveResult = CanMoveBrick(24, Settings.brick25, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick25);
                    Settings.brick25 = MoveBrick(fromField, toField, Settings.brick25, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 25)
            {
                brickList = Settings.field25.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick25.Field.ToString()); }

                var canMoveResult = CanMoveBrick(25, Settings.brick25, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick25);
                    Settings.brick25 = MoveBrick(fromField, toField, Settings.brick25, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 26)
            {
                brickList = Settings.field26.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick25.Field.ToString()); }

                var canMoveResult = CanMoveBrick(26, Settings.brick25, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick25);
                    Settings.brick25 = MoveBrick(fromField, toField, Settings.brick25, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 27)
            {
                brickList = Settings.field27.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick25.Field.ToString()); }

                var canMoveResult = CanMoveBrick(27, Settings.brick25, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick25);
                    Settings.brick25 = MoveBrick(fromField, toField, Settings.brick25, brickList);

                    setLocationPictureBox();
                }
            }
        }

        private void pictureBoxBlack_11_Click(object sender, EventArgs e)
        {

            int fieldnr = Settings.brick26.Field;
            if (fieldnr == 0)
            {
                brickList = Settings.field0.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick26.Field.ToString()); }

                var canMoveResult = CanMoveBrick(0, Settings.brick26, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick26);
                    Settings.brick26 = MoveBrick(fromField, toField, Settings.brick26, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 1)
            {
                brickList = Settings.field1.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick26.Field.ToString()); }

                var canMoveResult = CanMoveBrick(1, Settings.brick26, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick26);
                    Settings.brick26 = MoveBrick(fromField, toField, Settings.brick26, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 2)
            {
                brickList = Settings.field2.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick26.Field.ToString()); }

                var canMoveResult = CanMoveBrick(2, Settings.brick26, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick26);
                    Settings.brick26 = MoveBrick(fromField, toField, Settings.brick26, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 3)
            {
                brickList = Settings.field3.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick26.Field.ToString()); }

                var canMoveResult = CanMoveBrick(3, Settings.brick26, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick26);
                    Settings.brick26 = MoveBrick(fromField, toField, Settings.brick26, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 4)
            {
                brickList = Settings.field4.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick26.Field.ToString()); }

                var canMoveResult = CanMoveBrick(4, Settings.brick26, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick26);
                    Settings.brick26 = MoveBrick(fromField, toField, Settings.brick26, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 5)
            {
                brickList = Settings.field5.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick26.Field.ToString()); }

                var canMoveResult = CanMoveBrick(5, Settings.brick26, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick26);
                    Settings.brick26 = MoveBrick(fromField, toField, Settings.brick26, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 6)
            {
                brickList = Settings.field6.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick26.Field.ToString()); }

                var canMoveResult = CanMoveBrick(6, Settings.brick26, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick26);
                    Settings.brick26 = MoveBrick(fromField, toField, Settings.brick26, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 7)
            {
                brickList = Settings.field7.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick26.Field.ToString()); }

                var canMoveResult = CanMoveBrick(7, Settings.brick26, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick26);
                    Settings.brick26 = MoveBrick(fromField, toField, Settings.brick26, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 8)
            {
                brickList = Settings.field8.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick26.Field.ToString()); }

                var canMoveResult = CanMoveBrick(8, Settings.brick26, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick26);
                    Settings.brick26 = MoveBrick(fromField, toField, Settings.brick26, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 9)
            {
                brickList = Settings.field9.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick26.Field.ToString()); }

                var canMoveResult = CanMoveBrick(9, Settings.brick26, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick26);
                    Settings.brick26 = MoveBrick(fromField, toField, Settings.brick26, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 10)
            {
                brickList = Settings.field10.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick26.Field.ToString()); }

                var canMoveResult = CanMoveBrick(10, Settings.brick26, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick26);
                    Settings.brick26 = MoveBrick(fromField, toField, Settings.brick26, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 11)
            {
                brickList = Settings.field11.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick26.Field.ToString()); }

                var canMoveResult = CanMoveBrick(11, Settings.brick26, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick26);
                    Settings.brick26 = MoveBrick(fromField, toField, Settings.brick26, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 12)
            {
                brickList = Settings.field12.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick26.Field.ToString()); }

                var canMoveResult = CanMoveBrick(12, Settings.brick26, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick26);
                    Settings.brick26 = MoveBrick(fromField, toField, Settings.brick26, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 13)
            {
                brickList = Settings.field13.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick26.Field.ToString()); }

                var canMoveResult = CanMoveBrick(13, Settings.brick26, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick26);
                    Settings.brick26 = MoveBrick(fromField, toField, Settings.brick26, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 14)
            {
                brickList = Settings.field14.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick26.Field.ToString()); }

                var canMoveResult = CanMoveBrick(14, Settings.brick26, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick26);
                    Settings.brick26 = MoveBrick(fromField, toField, Settings.brick26, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 15)
            {
                brickList = Settings.field15.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick26.Field.ToString()); }

                var canMoveResult = CanMoveBrick(15, Settings.brick26, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick26);
                    Settings.brick26 = MoveBrick(fromField, toField, Settings.brick26, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 16)
            {
                brickList = Settings.field16.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick26.Field.ToString()); }

                var canMoveResult = CanMoveBrick(16, Settings.brick26, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick26);
                    Settings.brick26 = MoveBrick(fromField, toField, Settings.brick26, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 17)
            {
                brickList = Settings.field17.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick26.Field.ToString()); }

                var canMoveResult = CanMoveBrick(17, Settings.brick26, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick26);
                    Settings.brick26 = MoveBrick(fromField, toField, Settings.brick26, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 18)
            {
                brickList = Settings.field18.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick26.Field.ToString()); }

                var canMoveResult = CanMoveBrick(18, Settings.brick26, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick26);
                    Settings.brick26 = MoveBrick(fromField, toField, Settings.brick26, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 19)
            {
                brickList = Settings.field19.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick26.Field.ToString()); }

                var canMoveResult = CanMoveBrick(19, Settings.brick26, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick26);
                    Settings.brick26 = MoveBrick(fromField, toField, Settings.brick26, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 20)
            {
                brickList = Settings.field20.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick26.Field.ToString()); }

                var canMoveResult = CanMoveBrick(20, Settings.brick26, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick26);
                    Settings.brick26 = MoveBrick(fromField, toField, Settings.brick26, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 21)
            {
                brickList = Settings.field21.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick26.Field.ToString()); }

                var canMoveResult = CanMoveBrick(21, Settings.brick26, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick26);
                    Settings.brick26 = MoveBrick(fromField, toField, Settings.brick26, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 22)
            {
                brickList = Settings.field22.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick26.Field.ToString()); }

                var canMoveResult = CanMoveBrick(22, Settings.brick26, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick26);
                    Settings.brick26 = MoveBrick(fromField, toField, Settings.brick26, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 23)
            {
                brickList = Settings.field23.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick26.Field.ToString()); }

                var canMoveResult = CanMoveBrick(23, Settings.brick26, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick26);
                    Settings.brick26 = MoveBrick(fromField, toField, Settings.brick26, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 24)
            {
                brickList = Settings.field24.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick26.Field.ToString()); }

                var canMoveResult = CanMoveBrick(24, Settings.brick26, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick26);
                    Settings.brick26 = MoveBrick(fromField, toField, Settings.brick26, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 25)
            {
                brickList = Settings.field25.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick26.Field.ToString()); }

                var canMoveResult = CanMoveBrick(25, Settings.brick26, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick26);
                    Settings.brick26 = MoveBrick(fromField, toField, Settings.brick26, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 26)
            {
                brickList = Settings.field26.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick26.Field.ToString()); }

                var canMoveResult = CanMoveBrick(26, Settings.brick26, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick26);
                    Settings.brick26 = MoveBrick(fromField, toField, Settings.brick26, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 27)
            {
                brickList = Settings.field27.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick26.Field.ToString()); }

                var canMoveResult = CanMoveBrick(27, Settings.brick26, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick26);
                    Settings.brick26 = MoveBrick(fromField, toField, Settings.brick26, brickList);

                    setLocationPictureBox();
                }
            }
        }

        private void pictureBoxBlack_12_Click(object sender, EventArgs e)
        {

            int fieldnr = Settings.brick27.Field;
            if (fieldnr == 0)
            {
                brickList = Settings.field0.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick27.Field.ToString()); }

                var canMoveResult = CanMoveBrick(0, Settings.brick27, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick27);
                    Settings.brick27 = MoveBrick(fromField, toField, Settings.brick27, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 1)
            {
                brickList = Settings.field1.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick27.Field.ToString()); }

                var canMoveResult = CanMoveBrick(1, Settings.brick27, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick27);
                    Settings.brick27 = MoveBrick(fromField, toField, Settings.brick27, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 2)
            {
                brickList = Settings.field2.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick27.Field.ToString()); }

                var canMoveResult = CanMoveBrick(2, Settings.brick27, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick27);
                    Settings.brick27 = MoveBrick(fromField, toField, Settings.brick27, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 3)
            {
                brickList = Settings.field3.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick27.Field.ToString()); }

                var canMoveResult = CanMoveBrick(3, Settings.brick27, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick27);
                    Settings.brick27 = MoveBrick(fromField, toField, Settings.brick27, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 4)
            {
                brickList = Settings.field4.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick27.Field.ToString()); }

                var canMoveResult = CanMoveBrick(4, Settings.brick27, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick27);
                    Settings.brick27 = MoveBrick(fromField, toField, Settings.brick27, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 5)
            {
                brickList = Settings.field5.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick27.Field.ToString()); }

                var canMoveResult = CanMoveBrick(5, Settings.brick27, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick27);
                    Settings.brick27 = MoveBrick(fromField, toField, Settings.brick27, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 6)
            {
                brickList = Settings.field6.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick27.Field.ToString()); }

                var canMoveResult = CanMoveBrick(6, Settings.brick27, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick27);
                    Settings.brick27 = MoveBrick(fromField, toField, Settings.brick27, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 7)
            {
                brickList = Settings.field7.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick27.Field.ToString()); }

                var canMoveResult = CanMoveBrick(7, Settings.brick27, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick27);
                    Settings.brick27 = MoveBrick(fromField, toField, Settings.brick27, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 8)
            {
                brickList = Settings.field8.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick27.Field.ToString()); }

                var canMoveResult = CanMoveBrick(8, Settings.brick27, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick27);
                    Settings.brick27 = MoveBrick(fromField, toField, Settings.brick27, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 9)
            {
                brickList = Settings.field9.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick27.Field.ToString()); }

                var canMoveResult = CanMoveBrick(9, Settings.brick27, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick27);
                    Settings.brick27 = MoveBrick(fromField, toField, Settings.brick27, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 10)
            {
                brickList = Settings.field10.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick27.Field.ToString()); }

                var canMoveResult = CanMoveBrick(10, Settings.brick27, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick27);
                    Settings.brick27 = MoveBrick(fromField, toField, Settings.brick27, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 11)
            {
                brickList = Settings.field11.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick27.Field.ToString()); }

                var canMoveResult = CanMoveBrick(11, Settings.brick27, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick27);
                    Settings.brick27 = MoveBrick(fromField, toField, Settings.brick27, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 12)
            {
                brickList = Settings.field12.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick27.Field.ToString()); }

                var canMoveResult = CanMoveBrick(12, Settings.brick27, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick27);
                    Settings.brick27 = MoveBrick(fromField, toField, Settings.brick27, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 13)
            {
                brickList = Settings.field13.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick27.Field.ToString()); }

                var canMoveResult = CanMoveBrick(13, Settings.brick27, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick27);
                    Settings.brick27 = MoveBrick(fromField, toField, Settings.brick27, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 14)
            {
                brickList = Settings.field14.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick27.Field.ToString()); }

                var canMoveResult = CanMoveBrick(14, Settings.brick27, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick27);
                    Settings.brick27 = MoveBrick(fromField, toField, Settings.brick27, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 15)
            {
                brickList = Settings.field15.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick27.Field.ToString()); }

                var canMoveResult = CanMoveBrick(15, Settings.brick27, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick27);
                    Settings.brick27 = MoveBrick(fromField, toField, Settings.brick27, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 16)
            {
                brickList = Settings.field16.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick27.Field.ToString()); }

                var canMoveResult = CanMoveBrick(16, Settings.brick27, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick27);
                    Settings.brick27 = MoveBrick(fromField, toField, Settings.brick27, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 17)
            {
                brickList = Settings.field17.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick27.Field.ToString()); }

                var canMoveResult = CanMoveBrick(17, Settings.brick27, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick27);
                    Settings.brick27 = MoveBrick(fromField, toField, Settings.brick27, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 18)
            {
                brickList = Settings.field18.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick27.Field.ToString()); }

                var canMoveResult = CanMoveBrick(18, Settings.brick27, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick27);
                    Settings.brick27 = MoveBrick(fromField, toField, Settings.brick27, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 19)
            {
                brickList = Settings.field19.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick27.Field.ToString()); }

                var canMoveResult = CanMoveBrick(19, Settings.brick27, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick27);
                    Settings.brick27 = MoveBrick(fromField, toField, Settings.brick27, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 20)
            {
                brickList = Settings.field20.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick27.Field.ToString()); }

                var canMoveResult = CanMoveBrick(20, Settings.brick27, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick27);
                    Settings.brick27 = MoveBrick(fromField, toField, Settings.brick27, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 21)
            {
                brickList = Settings.field21.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick27.Field.ToString()); }

                var canMoveResult = CanMoveBrick(21, Settings.brick27, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick27);
                    Settings.brick27 = MoveBrick(fromField, toField, Settings.brick27, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 22)
            {
                brickList = Settings.field22.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick27.Field.ToString()); }

                var canMoveResult = CanMoveBrick(22, Settings.brick27, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick27);
                    Settings.brick27 = MoveBrick(fromField, toField, Settings.brick27, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 23)
            {
                brickList = Settings.field23.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick27.Field.ToString()); }

                var canMoveResult = CanMoveBrick(23, Settings.brick27, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick27);
                    Settings.brick27 = MoveBrick(fromField, toField, Settings.brick27, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 24)
            {
                brickList = Settings.field24.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick27.Field.ToString()); }

                var canMoveResult = CanMoveBrick(24, Settings.brick27, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick27);
                    Settings.brick27 = MoveBrick(fromField, toField, Settings.brick27, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 25)
            {
                brickList = Settings.field25.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick27.Field.ToString()); }

                var canMoveResult = CanMoveBrick(25, Settings.brick27, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick27);
                    Settings.brick27 = MoveBrick(fromField, toField, Settings.brick27, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 26)
            {
                brickList = Settings.field26.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick27.Field.ToString()); }

                var canMoveResult = CanMoveBrick(26, Settings.brick27, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick27);
                    Settings.brick27 = MoveBrick(fromField, toField, Settings.brick27, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 27)
            {
                brickList = Settings.field27.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick27.Field.ToString()); }

                var canMoveResult = CanMoveBrick(27, Settings.brick27, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick27);
                    Settings.brick27 = MoveBrick(fromField, toField, Settings.brick27, brickList);

                    setLocationPictureBox();
                }
            }
        }

        private void pictureBoxBlack_13_Click(object sender, EventArgs e)
        {

            int fieldnr = Settings.brick28.Field;
            if (fieldnr == 0)
            {
                brickList = Settings.field0.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick28.Field.ToString()); }

                var canMoveResult = CanMoveBrick(0, Settings.brick28, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick28);
                    Settings.brick28 = MoveBrick(fromField, toField, Settings.brick28, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 1)
            {
                brickList = Settings.field1.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick28.Field.ToString()); }

                var canMoveResult = CanMoveBrick(1, Settings.brick28, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick28);
                    Settings.brick28 = MoveBrick(fromField, toField, Settings.brick28, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 2)
            {
                brickList = Settings.field2.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick28.Field.ToString()); }

                var canMoveResult = CanMoveBrick(2, Settings.brick28, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick28);
                    Settings.brick28 = MoveBrick(fromField, toField, Settings.brick28, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 3)
            {
                brickList = Settings.field3.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick28.Field.ToString()); }

                var canMoveResult = CanMoveBrick(3, Settings.brick28, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick28);
                    Settings.brick28 = MoveBrick(fromField, toField, Settings.brick28, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 4)
            {
                brickList = Settings.field4.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick28.Field.ToString()); }

                var canMoveResult = CanMoveBrick(4, Settings.brick28, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick28);
                    Settings.brick28 = MoveBrick(fromField, toField, Settings.brick28, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 5)
            {
                brickList = Settings.field5.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick28.Field.ToString()); }

                var canMoveResult = CanMoveBrick(5, Settings.brick28, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick28);
                    Settings.brick28 = MoveBrick(fromField, toField, Settings.brick28, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 6)
            {
                brickList = Settings.field6.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick28.Field.ToString()); }

                var canMoveResult = CanMoveBrick(6, Settings.brick28, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick28);
                    Settings.brick28 = MoveBrick(fromField, toField, Settings.brick28, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 7)
            {
                brickList = Settings.field7.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick28.Field.ToString()); }

                var canMoveResult = CanMoveBrick(7, Settings.brick28, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick28);
                    Settings.brick28 = MoveBrick(fromField, toField, Settings.brick28, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 8)
            {
                brickList = Settings.field8.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick28.Field.ToString()); }

                var canMoveResult = CanMoveBrick(8, Settings.brick28, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick28);
                    Settings.brick28 = MoveBrick(fromField, toField, Settings.brick28, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 9)
            {
                brickList = Settings.field9.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick28.Field.ToString()); }

                var canMoveResult = CanMoveBrick(9, Settings.brick28, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick28);
                    Settings.brick28 = MoveBrick(fromField, toField, Settings.brick28, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 10)
            {
                brickList = Settings.field10.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick28.Field.ToString()); }

                var canMoveResult = CanMoveBrick(10, Settings.brick28, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick28);
                    Settings.brick28 = MoveBrick(fromField, toField, Settings.brick28, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 11)
            {
                brickList = Settings.field11.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick28.Field.ToString()); }

                var canMoveResult = CanMoveBrick(11, Settings.brick28, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick28);
                    Settings.brick28 = MoveBrick(fromField, toField, Settings.brick28, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 12)
            {
                brickList = Settings.field12.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick28.Field.ToString()); }

                var canMoveResult = CanMoveBrick(12, Settings.brick28, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick28);
                    Settings.brick28 = MoveBrick(fromField, toField, Settings.brick28, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 13)
            {
                brickList = Settings.field13.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick28.Field.ToString()); }

                var canMoveResult = CanMoveBrick(13, Settings.brick28, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick28);
                    Settings.brick28 = MoveBrick(fromField, toField, Settings.brick28, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 14)
            {
                brickList = Settings.field14.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick28.Field.ToString()); }

                var canMoveResult = CanMoveBrick(14, Settings.brick28, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick28);
                    Settings.brick28 = MoveBrick(fromField, toField, Settings.brick28, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 15)
            {
                brickList = Settings.field15.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick28.Field.ToString()); }

                var canMoveResult = CanMoveBrick(15, Settings.brick28, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick28);
                    Settings.brick28 = MoveBrick(fromField, toField, Settings.brick28, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 16)
            {
                brickList = Settings.field16.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick28.Field.ToString()); }

                var canMoveResult = CanMoveBrick(16, Settings.brick28, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick28);
                    Settings.brick28 = MoveBrick(fromField, toField, Settings.brick28, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 17)
            {
                brickList = Settings.field17.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick28.Field.ToString()); }

                var canMoveResult = CanMoveBrick(17, Settings.brick28, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick28);
                    Settings.brick28 = MoveBrick(fromField, toField, Settings.brick28, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 18)
            {
                brickList = Settings.field18.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick28.Field.ToString()); }

                var canMoveResult = CanMoveBrick(18, Settings.brick28, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick28);
                    Settings.brick28 = MoveBrick(fromField, toField, Settings.brick28, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 19)
            {
                brickList = Settings.field19.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick28.Field.ToString()); }

                var canMoveResult = CanMoveBrick(19, Settings.brick28, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick28);
                    Settings.brick28 = MoveBrick(fromField, toField, Settings.brick28, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 20)
            {
                brickList = Settings.field20.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick28.Field.ToString()); }

                var canMoveResult = CanMoveBrick(20, Settings.brick28, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick28);
                    Settings.brick28 = MoveBrick(fromField, toField, Settings.brick28, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 21)
            {
                brickList = Settings.field21.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick28.Field.ToString()); }

                var canMoveResult = CanMoveBrick(21, Settings.brick28, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick28);
                    Settings.brick28 = MoveBrick(fromField, toField, Settings.brick28, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 22)
            {
                brickList = Settings.field22.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick28.Field.ToString()); }

                var canMoveResult = CanMoveBrick(22, Settings.brick28, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick28);
                    Settings.brick28 = MoveBrick(fromField, toField, Settings.brick28, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 23)
            {
                brickList = Settings.field23.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick28.Field.ToString()); }

                var canMoveResult = CanMoveBrick(23, Settings.brick28, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick28);
                    Settings.brick28 = MoveBrick(fromField, toField, Settings.brick28, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 24)
            {
                brickList = Settings.field24.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick28.Field.ToString()); }

                var canMoveResult = CanMoveBrick(24, Settings.brick28, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick28);
                    Settings.brick28 = MoveBrick(fromField, toField, Settings.brick28, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 25)
            {
                brickList = Settings.field25.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick28.Field.ToString()); }

                var canMoveResult = CanMoveBrick(0, Settings.brick28, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick28);
                    Settings.brick28 = MoveBrick(fromField, toField, Settings.brick28, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 26)
            {
                brickList = Settings.field26.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick28.Field.ToString()); }

                var canMoveResult = CanMoveBrick(26, Settings.brick28, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick28);
                    Settings.brick28 = MoveBrick(fromField, toField, Settings.brick28, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 27)
            {
                brickList = Settings.field27.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick28.Field.ToString()); }

                var canMoveResult = CanMoveBrick(27, Settings.brick28, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick28);
                    Settings.brick28 = MoveBrick(fromField, toField, Settings.brick28, brickList);

                    setLocationPictureBox();
                }
            }
        }

        private void pictureBoxBlack_14_Click(object sender, EventArgs e)
        {

            int fieldnr = Settings.brick29.Field;
            if (fieldnr == 0)
            {
                brickList = Settings.field0.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick29.Field.ToString()); }

                var canMoveResult = CanMoveBrick(0, Settings.brick29, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick29);
                    Settings.brick29 = MoveBrick(fromField, toField, Settings.brick29, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 1)
            {
                brickList = Settings.field1.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick29.Field.ToString()); }

                var canMoveResult = CanMoveBrick(1, Settings.brick29, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick29);
                    Settings.brick29 = MoveBrick(fromField, toField, Settings.brick29, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 2)
            {
                brickList = Settings.field2.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick29.Field.ToString()); }

                var canMoveResult = CanMoveBrick(2, Settings.brick29, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick29);
                    Settings.brick29 = MoveBrick(fromField, toField, Settings.brick29, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 3)
            {
                brickList = Settings.field3.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick29.Field.ToString()); }

                var canMoveResult = CanMoveBrick(3, Settings.brick29, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick29);
                    Settings.brick29 = MoveBrick(fromField, toField, Settings.brick29, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 4)
            {
                brickList = Settings.field4.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick29.Field.ToString()); }

                var canMoveResult = CanMoveBrick(4, Settings.brick29, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick29);
                    Settings.brick29 = MoveBrick(fromField, toField, Settings.brick29, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 5)
            {
                brickList = Settings.field5.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick29.Field.ToString()); }

                var canMoveResult = CanMoveBrick(5, Settings.brick29, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick29);
                    Settings.brick29 = MoveBrick(fromField, toField, Settings.brick29, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 6)
            {
                brickList = Settings.field6.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick29.Field.ToString()); }

                var canMoveResult = CanMoveBrick(6, Settings.brick29, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick29);
                    Settings.brick29 = MoveBrick(fromField, toField, Settings.brick29, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 7)
            {
                brickList = Settings.field7.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick29.Field.ToString()); }

                var canMoveResult = CanMoveBrick(7, Settings.brick29, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick29);
                    Settings.brick29 = MoveBrick(fromField, toField, Settings.brick29, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 8)
            {
                brickList = Settings.field8.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick29.Field.ToString()); }

                var canMoveResult = CanMoveBrick(8, Settings.brick29, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick29);
                    Settings.brick29 = MoveBrick(fromField, toField, Settings.brick29, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 9)
            {
                brickList = Settings.field9.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick29.Field.ToString()); }

                var canMoveResult = CanMoveBrick(9, Settings.brick29, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick29);
                    Settings.brick29 = MoveBrick(fromField, toField, Settings.brick29, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 10)
            {
                brickList = Settings.field10.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick29.Field.ToString()); }

                var canMoveResult = CanMoveBrick(10, Settings.brick29, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick29);
                    Settings.brick29 = MoveBrick(fromField, toField, Settings.brick29, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 11)
            {
                brickList = Settings.field11.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick29.Field.ToString()); }

                var canMoveResult = CanMoveBrick(11, Settings.brick29, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick29);
                    Settings.brick29 = MoveBrick(fromField, toField, Settings.brick29, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 12)
            {
                brickList = Settings.field12.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick29.Field.ToString()); }

                var canMoveResult = CanMoveBrick(12, Settings.brick29, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick29);
                    Settings.brick29 = MoveBrick(fromField, toField, Settings.brick29, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 13)
            {
                brickList = Settings.field13.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick29.Field.ToString()); }

                var canMoveResult = CanMoveBrick(13, Settings.brick29, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick29);
                    Settings.brick29 = MoveBrick(fromField, toField, Settings.brick29, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 14)
            {
                brickList = Settings.field14.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick29.Field.ToString()); }

                var canMoveResult = CanMoveBrick(14, Settings.brick29, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick29);
                    Settings.brick29 = MoveBrick(fromField, toField, Settings.brick29, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 15)
            {
                brickList = Settings.field15.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick29.Field.ToString()); }

                var canMoveResult = CanMoveBrick(15, Settings.brick29, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick29);
                    Settings.brick29 = MoveBrick(fromField, toField, Settings.brick29, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 16)
            {
                brickList = Settings.field16.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick29.Field.ToString()); }

                var canMoveResult = CanMoveBrick(16, Settings.brick29, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick29);
                    Settings.brick29 = MoveBrick(fromField, toField, Settings.brick29, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 17)
            {
                brickList = Settings.field17.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick29.Field.ToString()); }

                var canMoveResult = CanMoveBrick(17, Settings.brick29, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick29);
                    Settings.brick29 = MoveBrick(fromField, toField, Settings.brick29, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 18)
            {
                brickList = Settings.field18.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick29.Field.ToString()); }

                var canMoveResult = CanMoveBrick(18, Settings.brick29, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick29);
                    Settings.brick29 = MoveBrick(fromField, toField, Settings.brick29, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 19)
            {
                brickList = Settings.field19.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick29.Field.ToString()); }

                var canMoveResult = CanMoveBrick(19, Settings.brick29, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick29);
                    Settings.brick29 = MoveBrick(fromField, toField, Settings.brick29, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 20)
            {
                brickList = Settings.field20.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick29.Field.ToString()); }

                var canMoveResult = CanMoveBrick(20, Settings.brick29, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick29);
                    Settings.brick29 = MoveBrick(fromField, toField, Settings.brick29, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 21)
            {
                brickList = Settings.field21.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick29.Field.ToString()); }

                var canMoveResult = CanMoveBrick(21, Settings.brick29, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick29);
                    Settings.brick29 = MoveBrick(fromField, toField, Settings.brick29, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 22)
            {
                brickList = Settings.field22.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick29.Field.ToString()); }

                var canMoveResult = CanMoveBrick(22, Settings.brick29, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick29);
                    Settings.brick29 = MoveBrick(fromField, toField, Settings.brick29, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 23)
            {
                brickList = Settings.field23.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick29.Field.ToString()); }

                var canMoveResult = CanMoveBrick(23, Settings.brick29, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick29);
                    Settings.brick29 = MoveBrick(fromField, toField, Settings.brick29, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 24)
            {
                brickList = Settings.field24.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick29.Field.ToString()); }

                var canMoveResult = CanMoveBrick(24, Settings.brick29, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick29);
                    Settings.brick29 = MoveBrick(fromField, toField, Settings.brick29, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 25)
            {
                brickList = Settings.field25.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick29.Field.ToString()); }

                var canMoveResult = CanMoveBrick(25, Settings.brick29, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick29);
                    Settings.brick29 = MoveBrick(fromField, toField, Settings.brick29, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 26)
            {
                brickList = Settings.field26.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick29.Field.ToString()); }

                var canMoveResult = CanMoveBrick(26, Settings.brick29, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick29);
                    Settings.brick29 = MoveBrick(fromField, toField, Settings.brick29, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 27)
            {
                brickList = Settings.field27.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick29.Field.ToString()); }

                var canMoveResult = CanMoveBrick(27, Settings.brick29, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick29);
                    Settings.brick29 = MoveBrick(fromField, toField, Settings.brick29, brickList);

                    setLocationPictureBox();
                }
            }
        }

        private void pictureBoxBlack_15_Click(object sender, EventArgs e)
        {

            int fieldnr = Settings.brick30.Field;
            if (fieldnr == 0)
            {
                brickList = Settings.field0.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick30.Field.ToString()); }

                var canMoveResult = CanMoveBrick(0, Settings.brick30, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick30);
                    Settings.brick30 = MoveBrick(fromField, toField, Settings.brick30, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 1)
            {
                brickList = Settings.field1.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick30.Field.ToString()); }

                var canMoveResult = CanMoveBrick(1, Settings.brick30, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick30);
                    Settings.brick30 = MoveBrick(fromField, toField, Settings.brick30, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 2)
            {
                brickList = Settings.field2.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick30.Field.ToString()); }

                var canMoveResult = CanMoveBrick(2, Settings.brick30, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick30);
                    Settings.brick30 = MoveBrick(fromField, toField, Settings.brick30, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 3)
            {
                brickList = Settings.field3.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick30.Field.ToString()); }

                var canMoveResult = CanMoveBrick(3, Settings.brick30, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick30);
                    Settings.brick30 = MoveBrick(fromField, toField, Settings.brick30, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 4)
            {
                brickList = Settings.field4.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick30.Field.ToString()); }

                var canMoveResult = CanMoveBrick(4, Settings.brick30, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick30);
                    Settings.brick30 = MoveBrick(fromField, toField, Settings.brick30, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 5)
            {
                brickList = Settings.field5.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick30.Field.ToString()); }

                var canMoveResult = CanMoveBrick(5, Settings.brick30, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick30);
                    Settings.brick30 = MoveBrick(fromField, toField, Settings.brick30, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 6)
            {
                brickList = Settings.field6.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick30.Field.ToString()); }

                var canMoveResult = CanMoveBrick(6, Settings.brick30, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick30);
                    Settings.brick30 = MoveBrick(fromField, toField, Settings.brick30, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 7)
            {
                brickList = Settings.field7.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick30.Field.ToString()); }

                var canMoveResult = CanMoveBrick(7, Settings.brick30, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick30);
                    Settings.brick30 = MoveBrick(fromField, toField, Settings.brick30, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 8)
            {
                brickList = Settings.field8.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick30.Field.ToString()); }

                var canMoveResult = CanMoveBrick(8, Settings.brick30, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick30);
                    Settings.brick30 = MoveBrick(fromField, toField, Settings.brick30, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 9)
            {
                brickList = Settings.field9.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick30.Field.ToString()); }

                var canMoveResult = CanMoveBrick(9, Settings.brick30, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick30);
                    Settings.brick30 = MoveBrick(fromField, toField, Settings.brick30, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 10)
            {
                brickList = Settings.field10.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick30.Field.ToString()); }

                var canMoveResult = CanMoveBrick(10, Settings.brick30, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick30);
                    Settings.brick30 = MoveBrick(fromField, toField, Settings.brick30, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 11)
            {
                brickList = Settings.field11.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick30.Field.ToString()); }

                var canMoveResult = CanMoveBrick(11, Settings.brick30, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick30);
                    Settings.brick30 = MoveBrick(fromField, toField, Settings.brick30, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 12)
            {
                brickList = Settings.field12.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick30.Field.ToString()); }

                var canMoveResult = CanMoveBrick(12, Settings.brick30, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick30);
                    Settings.brick30 = MoveBrick(fromField, toField, Settings.brick30, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 13)
            {
                brickList = Settings.field13.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick30.Field.ToString()); }

                var canMoveResult = CanMoveBrick(13, Settings.brick30, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick30);
                    Settings.brick30 = MoveBrick(fromField, toField, Settings.brick30, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 14)
            {
                brickList = Settings.field14.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick30.Field.ToString()); }

                var canMoveResult = CanMoveBrick(14, Settings.brick30, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick30);
                    Settings.brick30 = MoveBrick(fromField, toField, Settings.brick30, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 15)
            {
                brickList = Settings.field15.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick30.Field.ToString()); }

                var canMoveResult = CanMoveBrick(15, Settings.brick30, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick30);
                    Settings.brick30 = MoveBrick(fromField, toField, Settings.brick30, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 16)
            {
                brickList = Settings.field16.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick30.Field.ToString()); }

                var canMoveResult = CanMoveBrick(16, Settings.brick30, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick30);
                    Settings.brick30 = MoveBrick(fromField, toField, Settings.brick30, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 17)
            {
                brickList = Settings.field17.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick30.Field.ToString()); }

                var canMoveResult = CanMoveBrick(17, Settings.brick30, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick30);
                    Settings.brick30 = MoveBrick(fromField, toField, Settings.brick30, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 18)
            {

                brickList = Settings.field18.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick30.Field.ToString()); }

                var canMoveResult = CanMoveBrick(18, Settings.brick30, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick30);
                    Settings.brick30 = MoveBrick(fromField, toField, Settings.brick30, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 19)
            {
                brickList = Settings.field19.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick30.Field.ToString()); }

                var canMoveResult = CanMoveBrick(19, Settings.brick30, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick30);
                    Settings.brick30 = MoveBrick(fromField, toField, Settings.brick30, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 20)
            {
                brickList = Settings.field20.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick30.Field.ToString()); }

                var canMoveResult = CanMoveBrick(20, Settings.brick30, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick30);
                    Settings.brick30 = MoveBrick(fromField, toField, Settings.brick30, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 21)
            {
                brickList = Settings.field21.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick30.Field.ToString()); }

                var canMoveResult = CanMoveBrick(21, Settings.brick30, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick30);
                    Settings.brick30 = MoveBrick(fromField, toField, Settings.brick30, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 22)
            {
                brickList = Settings.field22.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick30.Field.ToString()); }

                var canMoveResult = CanMoveBrick(22, Settings.brick30, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick30);
                    Settings.brick30 = MoveBrick(fromField, toField, Settings.brick30, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 23)
            {
                brickList = Settings.field23.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick30.Field.ToString()); }

                var canMoveResult = CanMoveBrick(23, Settings.brick30, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick30);
                    Settings.brick30 = MoveBrick(fromField, toField, Settings.brick30, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 24)
            {
                brickList = Settings.field24.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick30.Field.ToString()); }

                var canMoveResult = CanMoveBrick(24, Settings.brick30, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick30);
                    Settings.brick30 = MoveBrick(fromField, toField, Settings.brick30, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 25)
            {
                brickList = Settings.field25.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick30.Field.ToString()); }

                var canMoveResult = CanMoveBrick(25, Settings.brick30, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick30);
                    Settings.brick30 = MoveBrick(fromField, toField, Settings.brick30, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 26)
            {
                brickList = Settings.field26.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick30.Field.ToString()); }

                var canMoveResult = CanMoveBrick(26, Settings.brick30, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick30);
                    Settings.brick30 = MoveBrick(fromField, toField, Settings.brick30, brickList);

                    setLocationPictureBox();
                }
            }
            if (fieldnr == 27)
            {
                brickList = Settings.field27.GetListBricks();
                if (show_PictureBox) { MessageBox.Show("brickList Count: " + brickList.Count.ToString() + " brickFieldNR: " + Settings.brick30.Field.ToString()); }

                var canMoveResult = CanMoveBrick(27, Settings.brick30, brickList);
                if (canMoveResult) // Item1 contains the boolean result
                {
                    Fields fromField = gameManager.GetField(fieldnr);
                    Fields toField = getToField(fieldnr, Settings.brick30);
                    Settings.brick30 = MoveBrick(fromField, toField, Settings.brick30, brickList);

                    setLocationPictureBox();
                }
            }
        }
        #endregion

        private void checkBoxPossibleMoves_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPossibleMoves.Checked)
            {
                show_possible_Moves = true;
            }
            else
            {
                show_possible_Moves = false;
            }
        }

        private void checkBoxAllMoves_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAllMoves.Checked)
            {
                show_terninger = true;
            }
            else
            {
                show_terninger = false;
            }
        }

        private void checkBoxPictureBox_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPictureBox.Checked)
            {
                show_PictureBox = true;
            }
            else
            {
                show_PictureBox = false;
            }
        }

        private void checkBoxCanMove_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPictureBox.Checked)
            {
                show_Can_Move = true;
            }
            else
            {
                show_Can_Move = false;
            }
        }
    }
}

                
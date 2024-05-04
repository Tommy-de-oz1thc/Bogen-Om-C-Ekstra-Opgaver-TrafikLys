using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace BackGammon
{
    public class PC
    {

        GameManager gameManager = new GameManager();
        Random random = new Random();
        public PC() 
        {
           

        }

        

        public void Game(GameLogic gameLogic,string currentTurn)
        {
           
                var numberofTurns = gameManager.GetPossibleMoves(currentTurn);
                int valgtTerning = random.Next(1, 3);
                List<Terning> _rafleList = gameManager.getRafleList();
                int terning_1 = _rafleList[0].GetTerning();
                int terning_2 = _rafleList[1].GetTerning();
                if (valgtTerning == 1)
                {
                    gameLogic.btnTerning_1_Click(null, EventArgs.Empty);
                    List<Move> list_terning_1 = numberofTurns.dice_1_Moves;
                    int randomIndex = random.Next(0, list_terning_1.Count);
                    Move aktuelMove = list_terning_1[randomIndex];
                    Fields startField = gameManager.GetField(aktuelMove.StartField);
                    Fields toField = gameLogic.getToField(aktuelMove.StartField, aktuelMove.Brick);
                    findFields_With_1_Brick(aktuelMove, toField, list_terning_1,currentTurn);
                    List<Bricks> brickList = startField.GetListBricks(); // startField.GetListBricks();
                    bool canMove = gameLogic.CanMoveBrick(aktuelMove.StartField, aktuelMove.Brick, brickList);
                    if (canMove)
                    {
                       
                        gameLogic.MoveBrick(startField, toField, aktuelMove.Brick, brickList);
                       
                        setCordinateBricks(gameLogic, aktuelMove.Brick.BrickNr, aktuelMove.EndField);
                        gameLogic.setLocationPictureBox();
                    }
                    else 
                    {
                        gameLogic.setTering_1_Enable();
                        gameLogic.setMomvedBrick();
                    }
               // MessageBox.Show(aktuelMove.Brick.BrickNr + " " + aktuelMove.StartField + " " + aktuelMove.EndField + " Can move PC: " + canMove);
                }
                else
                {
                    gameLogic.btnTerning_2_Click(null, EventArgs.Empty);
                    List<Move> list_terning_2 = numberofTurns.dice_2_Moves;
                    int randomIndex = random.Next(0, list_terning_2.Count);
                    Move aktuelMove = list_terning_2[randomIndex];
                    Fields startField = gameManager.GetField(aktuelMove.StartField);
                    Fields toField = gameLogic.getToField(aktuelMove.StartField, aktuelMove.Brick);
                    findFields_With_1_Brick(aktuelMove, toField, list_terning_2,currentTurn);
                    List<Bricks> brickList = startField.GetListBricks();
                    bool canMove = gameLogic.CanMoveBrick(aktuelMove.StartField, aktuelMove.Brick, brickList);
                    if (canMove)
                    {
                        
                        gameLogic.MoveBrick(startField, toField, aktuelMove.Brick, brickList);
                       
                        setCordinateBricks(gameLogic, aktuelMove.Brick.BrickNr, aktuelMove.EndField);
                        gameLogic.setLocationPictureBox();

                    }
                    else
                    {
                        gameLogic.setTering_2_Enable();
                        gameLogic.setMomvedBrick();
                    }
              // MessageBox.Show(aktuelMove.Brick.BrickNr + " " + aktuelMove.StartField + " " + aktuelMove.EndField + " Can move PC: " + canMove);

                }

            //MessageBox.Show("PC player: " + currentTurn + " Dice 1: " + terning_1 + " Dice 2: " + terning_2);
            gameLogic.CheckChangeTurn();
        }

        private Move findFields_With_1_Brick(Move aktuelMove,Fields toField,List<Move> listMoves,string currentTurn)
        {
            if ((toField.NR != 0) && (toField.NR != 27) && (toField.NR != 25) && (toField.NR != 26))
            {
                List<Move> moves = new List<Move>();
                foreach (Move move in listMoves)
                {
                    Fields newTofield = gameManager.GetField(move.EndField);
                    if (newTofield.GetListBricks().Count == 1)
                    {
                        moves.Add(move);
                    }
                }
                if (moves.Count > 0)
                {
                    foreach (Move move in moves)
                    {


                        Fields newTofield = gameManager.GetField(move.EndField);
                        if ((newTofield.GetListBricks().Count >= 2) && (move.Brick.Color.ToString() == currentTurn))
                        {
                            moves.Add(move);
                        }
                    }
                }
                if (moves.Count > 0)
                {
                    int randomIndex = random.Next(0, moves.Count);
                    aktuelMove = moves[randomIndex];
                }
            }
            return aktuelMove;
        }


        private void setCordinateBricks(GameLogic gameLogic, int bricknr,int tofieldnr)
        {
            Fields toField = new Fields();
            toField = gameManager.GetField(tofieldnr);
            int y = gameLogic.getYHieght(toField);

            switch (bricknr)
            {
                case 1:         
                    Settings.brick1.X = Settings.cordinates[tofieldnr].x;
                    Settings.brick1.Y = Settings.cordinates[tofieldnr].y + y;
                    break;
                case 2:
                    Settings.brick2.X = Settings.cordinates[tofieldnr].x;
                    Settings.brick2.Y = Settings.cordinates[tofieldnr].y + y;
                    break;
                case 3:
                    Settings.brick3.X = Settings.cordinates[tofieldnr].x;
                    Settings.brick3.Y = Settings.cordinates[tofieldnr].y + y;
                    break;
                case 4:
                    Settings.brick4.X = Settings.cordinates[tofieldnr].x;
                    Settings.brick4.Y = Settings.cordinates[tofieldnr].y + y;
                    break;
                case 5:
                    Settings.brick5.X = Settings.cordinates[tofieldnr].x;
                    Settings.brick5.Y = Settings.cordinates[tofieldnr].y + y;
                    break;
                case 6:
                    Settings.brick6.X = Settings.cordinates[tofieldnr].x;
                    Settings.brick6.Y = Settings.cordinates[tofieldnr].y + y;
                    break;
                case 7:
                    Settings.brick7.X = Settings.cordinates[tofieldnr].x;
                    Settings.brick7.Y = Settings.cordinates[tofieldnr].y + y;
                    break;
                case 8:
                    Settings.brick8.X = Settings.cordinates[tofieldnr].x;
                    Settings.brick8.Y = Settings.cordinates[tofieldnr].y + y;
                    break;
                case 9:
                    Settings.brick9.X = Settings.cordinates[tofieldnr].x;
                    Settings.brick9.Y = Settings.cordinates[tofieldnr].y + y;
                    break;
                case 10:
                    Settings.brick10.X = Settings.cordinates[tofieldnr].x;
                    Settings.brick10.Y = Settings.cordinates[tofieldnr].y + y;
                    break;
                case 11:
                    Settings.brick11.X = Settings.cordinates[tofieldnr].x;
                    Settings.brick11.Y = Settings.cordinates[tofieldnr].y + y;
                    break;
                case 12:
                    Settings.brick12.X = Settings.cordinates[tofieldnr].x;
                    Settings.brick12.Y = Settings.cordinates[tofieldnr].y + y;
                    break;
                case 13:
                    Settings.brick13.X = Settings.cordinates[tofieldnr].x;
                    Settings.brick13.Y = Settings.cordinates[tofieldnr].y + y;
                    break;
                case 14:
                    Settings.brick14.X = Settings.cordinates[tofieldnr].x;
                    Settings.brick14.Y = Settings.cordinates[tofieldnr].y + y;
                    break;
                case 15:
                    Settings.brick15.X = Settings.cordinates[tofieldnr].x;
                    Settings.brick15.Y = Settings.cordinates[tofieldnr].y + y;
                    break;
                case 16:
                    Settings.brick16.X = Settings.cordinates[tofieldnr].x;
                    Settings.brick16.Y = Settings.cordinates[tofieldnr].y + y;
                    break;
                case 17:
                    Settings.brick17.X = Settings.cordinates[tofieldnr].x;
                    Settings.brick17.Y = Settings.cordinates[tofieldnr].y + y;
                    break;
                case 18:
                    Settings.brick18.X = Settings.cordinates[tofieldnr].x;
                    Settings.brick18.Y = Settings.cordinates[tofieldnr].y + y;
                    break;
                case 19:
                    Settings.brick19.X = Settings.cordinates[tofieldnr].x;
                    Settings.brick19.Y = Settings.cordinates[tofieldnr].y + y;
                    break;
                case 20:
                    Settings.brick20.X = Settings.cordinates[tofieldnr].x;
                    Settings.brick20.Y = Settings.cordinates[tofieldnr].y + y;
                    break;
                case 21:
                    Settings.brick21.X = Settings.cordinates[tofieldnr].x;
                    Settings.brick21.Y = Settings.cordinates[tofieldnr].y + y;
                    break;
                case 22:
                    Settings.brick22.X = Settings.cordinates[tofieldnr].x;
                    Settings.brick22.Y = Settings.cordinates[tofieldnr].y + y;
                    break;
                case 24:
                    Settings.brick24.X = Settings.cordinates[tofieldnr].x;
                    Settings.brick24.Y = Settings.cordinates[tofieldnr].y + y;
                    break;
                case 25:
                    Settings.brick25.X = Settings.cordinates[tofieldnr].x;
                    Settings.brick25.Y = Settings.cordinates[tofieldnr].y + y;
                    break;
                case 26:
                    Settings.brick26.X = Settings.cordinates[tofieldnr].x;
                    Settings.brick26.Y = Settings.cordinates[tofieldnr].y + y;
                    break;
                case 27:
                    Settings.brick27.X = Settings.cordinates[tofieldnr].x;
                    Settings.brick27.Y = Settings.cordinates[tofieldnr].y + y;
                    break;
                case 28:
                    Settings.brick28.X = Settings.cordinates[tofieldnr].x;
                    Settings.brick28.Y = Settings.cordinates[tofieldnr].y + y;
                    break;
                case 29:
                    Settings.brick29.X = Settings.cordinates[tofieldnr].x;
                    Settings.brick29.Y = Settings.cordinates[tofieldnr].y + y;
                    break;
                case 30:
                    Settings.brick30.X = Settings.cordinates[tofieldnr].x;
                    Settings.brick30.Y = Settings.cordinates[tofieldnr].y + y;
                    break;
            }
        }
    }
}

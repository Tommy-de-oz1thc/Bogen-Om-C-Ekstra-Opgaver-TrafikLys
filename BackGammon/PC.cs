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
        List<Move> moves = new List<Move>();
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
                    try
                    {
                        int randomIndex = random.Next(0, list_terning_1.Count);
                        Move aktuelMove = list_terning_1[randomIndex];
                    
                        Fields startField = gameManager.GetField(aktuelMove.StartField);
                        Fields toField = gameLogic.getToField(aktuelMove.StartField, aktuelMove.Brick);
                        findFields_With_1_Brick(aktuelMove, toField, list_terning_1,currentTurn);
                        List<Bricks> brickList = startField.GetListBricks(); // startField.GetListBricks();
                        bool canMove = gameLogic.CanMoveBrick(aktuelMove.StartField, aktuelMove.Brick, brickList);
                        if (canMove)
                        {
                       
                            setBricks(gameLogic,startField, toField, aktuelMove, brickList);
                            gameLogic.MoveBrick(startField, toField, aktuelMove.Brick, brickList);
                            gameLogic.setLocationPictureBox();
                        }
                        else 
                        {
                            gameLogic.setTerning_1_Enable();
                            gameLogic.setMovedBrick();
                        }
                    }
                    catch (Exception ex)
                    {
                       
                    }
                // MessageBox.Show(aktuelMove.Brick.BrickNr + " " + aktuelMove.StartField + " " + aktuelMove.EndField + " Can move PC: " + canMove);
                }
                else
                {
                    gameLogic.btnTerning_2_Click(null, EventArgs.Empty);
                    List<Move> list_terning_2 = numberofTurns.dice_2_Moves;
                try
                {
                    int randomIndex = random.Next(0, list_terning_2.Count);
                    Move aktuelMove = list_terning_2[randomIndex];
                    Fields startField = gameManager.GetField(aktuelMove.StartField);
                    Fields toField = gameLogic.getToField(aktuelMove.StartField, aktuelMove.Brick);
                    findFields_With_1_Brick(aktuelMove, toField, list_terning_2, currentTurn);
                    List<Bricks> brickList = startField.GetListBricks();
                    bool canMove = gameLogic.CanMoveBrick(aktuelMove.StartField, aktuelMove.Brick, brickList);
                    if (canMove)
                    {


                        setBricks(gameLogic, startField, toField, aktuelMove, brickList);
                        gameLogic.MoveBrick(startField, toField, aktuelMove.Brick, brickList);

                        gameLogic.setLocationPictureBox();

                    }
                    else
                    {
                        gameLogic.setTerning_2_Enable();
                        gameLogic.setMovedBrick();
                    }
                }
                catch (Exception ex) 
                {

                   
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
              ;
                moves.Clear();
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

        private void setBricks(GameLogic gameLogic, Fields startField, Fields toField, Move aktuelMove, List<Bricks> brickList)
        {
            switch (aktuelMove.Brick.BrickNr)
            {
                case 1:
                    Settings.brick1 = gameLogic.MoveBrick(startField, toField, aktuelMove.Brick, brickList);
                    break;
                case 2:
                    Settings.brick2 = gameLogic.MoveBrick(startField, toField, aktuelMove.Brick, brickList);
                    break;
                case 3:
                    Settings.brick3 = gameLogic.MoveBrick(startField, toField, aktuelMove.Brick, brickList);
                    break;
                case 4:
                    Settings.brick4 = gameLogic.MoveBrick(startField, toField, aktuelMove.Brick, brickList);
                    break;
                case 5:
                    Settings.brick5 = gameLogic.MoveBrick(startField, toField, aktuelMove.Brick, brickList);
                    break;
                case 6:
                    Settings.brick6 = gameLogic.MoveBrick(startField, toField, aktuelMove.Brick, brickList);
                    break;
                case 7:
                    Settings.brick7 = gameLogic.MoveBrick(startField, toField, aktuelMove.Brick, brickList);
                    break;
                case 8:
                    Settings.brick8 = gameLogic.MoveBrick(startField, toField, aktuelMove.Brick, brickList);
                    break;
                case 9:
                    Settings.brick9 = gameLogic.MoveBrick(startField, toField, aktuelMove.Brick, brickList);
                    break;
                case 10:
                    Settings.brick10 = gameLogic.MoveBrick(startField, toField, aktuelMove.Brick, brickList);
                    break;
                case 11:
                    Settings.brick11 = gameLogic.MoveBrick(startField, toField, aktuelMove.Brick, brickList);
                    break;
                case 12:
                    Settings.brick12 = gameLogic.MoveBrick(startField, toField, aktuelMove.Brick, brickList);
                    break;
                case 13:
                    Settings.brick13 = gameLogic.MoveBrick(startField, toField, aktuelMove.Brick, brickList);
                    break;
                case 14:
                    Settings.brick14 = gameLogic.MoveBrick(startField, toField, aktuelMove.Brick, brickList);
                    break;
                case 15:
                    Settings.brick15 = gameLogic.MoveBrick(startField, toField, aktuelMove.Brick, brickList);
                    break;
                case 16:
                    Settings.brick16 = gameLogic.MoveBrick(startField, toField, aktuelMove.Brick, brickList);
                    break;
                case 17:
                    Settings.brick17 = gameLogic.MoveBrick(startField, toField, aktuelMove.Brick, brickList);
                    break;
                case 18:
                    Settings.brick18 = gameLogic.MoveBrick(startField, toField, aktuelMove.Brick, brickList);
                    break;
                case 19:
                    Settings.brick19 = gameLogic.MoveBrick(startField, toField, aktuelMove.Brick, brickList);
                    break;
                case 20:
                    Settings.brick20 = gameLogic.MoveBrick(startField, toField, aktuelMove.Brick, brickList);
                    break;
                case 21:
                    Settings.brick21 = gameLogic.MoveBrick(startField, toField, aktuelMove.Brick, brickList);
                    break;
                case 22:
                    Settings.brick22 = gameLogic.MoveBrick(startField, toField, aktuelMove.Brick, brickList);
                    break;
                case 23:
                    Settings.brick23 = gameLogic.MoveBrick(startField, toField, aktuelMove.Brick, brickList);
                    break;
                case 24:
                    Settings.brick24 = gameLogic.MoveBrick(startField, toField, aktuelMove.Brick, brickList);
                    break;
                case 25:
                    Settings.brick25 = gameLogic.MoveBrick(startField, toField, aktuelMove.Brick, brickList);
                    break;
                case 26:
                    Settings.brick26 = gameLogic.MoveBrick(startField, toField, aktuelMove.Brick, brickList);
                    break;
                case 27:
                    Settings.brick27 = gameLogic.MoveBrick(startField, toField, aktuelMove.Brick, brickList);
                    break;
                case 28:
                    Settings.brick28 = gameLogic.MoveBrick(startField, toField, aktuelMove.Brick, brickList);
                    break;
                case 29:
                    Settings.brick29 = gameLogic.MoveBrick(startField, toField, aktuelMove.Brick, brickList);
                    break;
                case 30:
                    Settings.brick30 = gameLogic.MoveBrick(startField, toField, aktuelMove.Brick, brickList);
                    break;

            }
        }
        
    }
}

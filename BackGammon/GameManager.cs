 using System;
 using System.Collections.Generic;
namespace BackGammon
{
    public class GameManager
    {
        private static List<Terning> _rafleList = new List<Terning>();
        private string currentTurn = ""; // Gem den aktuelle tur i GameManager
        private bool is_terning_double = false;
        public RafleBæger rafle = new RafleBæger(2);
        public GameManager() { }

        public (List<Move> possibleMoves, List<Move> dice_1_Moves, List<Move> dice_2_Moves) GetPossibleMoves(string currentTurn)
        {
            this.currentTurn = currentTurn;
            List<Move> possibleMoves = new List<Move>();
            List<Move> dice_1_Moves = new List<Move>();
            List<Move> dice_2_Moves = new List<Move>();

            // Loop gennem alle felter
            for (int i = 0; i <= 27; i++)
            {
                Fields currentField = GetField(i);
                List<Bricks> bricksOnField = currentField.GetListBricks();

                // Loop gennem alle brikker på det aktuelle felt
                foreach (Bricks brick in bricksOnField)
                {
                    // Generer alle mulige træk for den aktuelle brik
                    var (movesForBrick, dice_1_MovesForBrick, dice_2_MovesForBrick) = GeneratePossibleMoves(brick, i);

                    // Tilføj de genererede træk til de respektive lister
                    possibleMoves.AddRange(movesForBrick);
                    dice_1_Moves.AddRange(dice_1_MovesForBrick);
                    dice_2_Moves.AddRange(dice_2_MovesForBrick);
                }
            }

            return (possibleMoves, dice_1_Moves, dice_2_Moves);
        }

        private (List<Move> possibleMoves, List<Move> dice_1_Moves, List<Move> dice_2_Moves) GeneratePossibleMoves(Bricks brick, int currentField)
        {
            List<Move> possibleMoves = new List<Move>();
            List<Move> dice_1_Moves = new List<Move>();
            List<Move> dice_2_Moves = new List<Move>();

            // Tjek om det aktuelle felt er et gyldigt startpunkt for brikken
            if (currentField != brick.Field)
            {
                return (possibleMoves, dice_1_Moves, dice_2_Moves); // Returner en tom liste, hvis brikken ikke er på det aktuelle felt
            }

            // Loop kun gennem terningskast 2 og 4
            foreach (int dice in new[] { _rafleList[0].GetTerning(), _rafleList[1].GetTerning() })
            {
                int targetField = 0;
                if (brick.Color == Bricks.BrickColor.White)
                {
                    targetField = currentField + dice; // Beregn det målfelt, der er baseret på terningekastet
                }
                else
                {
                    targetField = currentField - dice;
                }
                // Tjek om målfeltet er inden for brættets grænser (0 til 27)
                if ((targetField <= 27) && (targetField >= 0))
                {
                    // Tjek om målfeltet er tomt eller indeholder brikker af samme farve
                    Fields targetFieldObj = GetField(targetField);
                    Fields currentFieldObj = GetField(currentField);
                    if (targetFieldObj.GetListBricks().Count < 2 || targetFieldObj.GetListBricks().All(b => b.Color == brick.Color))
                    {
                        // Tjek om den sidste brik på det aktuelle felt matcher den aktuelle brik
                        List<Bricks> currentBricks = currentFieldObj.GetListBricks();
                        if ((currentBricks.Count > 0 && currentBricks.Last().BrickNr == brick.BrickNr) && (brick.Color.ToString() == currentTurn))
                        {
                            // Tilføj et træk til listen over mulige træk
                            if (GameLogic.show_terninger)
                            {
                                MessageBox.Show("Bricknr: " + brick.BrickNr + "  CurrentField: " + currentField + " TargetField: " + targetField + " Dice: " + dice + " CurrentTurn: " + currentTurn);
                            }
                            if (dice == _rafleList[0].GetTerning())
                            {
                                dice_1_Moves.Add(new Move(brick, currentField, targetField, dice));
                                possibleMoves.Add(new Move(brick, currentField, targetField, dice));
                            }
                            if (dice == _rafleList[1].GetTerning())
                            {
                                dice_2_Moves.Add(new Move(brick, currentField, targetField, dice));
                                possibleMoves.Add(new Move(brick, currentField, targetField, dice));
                            }
                        }
                    }
                }
            }

            return (possibleMoves, dice_1_Moves, dice_2_Moves);
        }

        public List<Terning> getRafleList()
        {
            return _rafleList;
        }
        public bool get_is_terning_double()
        { return is_terning_double; }

        public void set_is_terning_double(bool set)
        { is_terning_double = set; }
        public void Terninger()
        {
            _rafleList = rafle.getRafleList();
            _rafleList[0].Ryst();
            _rafleList[1].Ryst();
            if (_rafleList[0].GetTerning() == _rafleList[1].GetTerning())
            {
                is_terning_double = true;
            }
            else
            {
                is_terning_double = false;
            }
        }


        public Fields GetField(int fieldnr)
        {
            Fields field = new Fields();

            switch (fieldnr)
            {
                case 0:
                    field = Settings.field0;
                    break;
                case 1:
                    field = Settings.field1;
                    break;
                case 2:
                    field = Settings.field2;
                    break;
                case 3:
                    field = Settings.field3;
                    break;
                case 4:
                    field = Settings.field4;
                    break;
                case 5:
                    field = Settings.field5;
                    break;
                case 6:
                    field = Settings.field6;
                    break;
                case 7:
                    field = Settings.field7;
                    break;
                case 8:
                    field = Settings.field8;
                    break;
                case 9:
                    field = Settings.field9;
                    break;
                case 10:
                    field = Settings.field10;
                    break;
                case 11:
                    field = Settings.field11;
                    break;
                case 12:
                    field = Settings.field12;
                    break;
                case 13:
                    field = Settings.field13;
                    break;
                case 14:
                    field = Settings.field14;
                    break;
                case 15:
                    field = Settings.field15;
                    break;
                case 16:
                    field = Settings.field16;
                    break;
                case 17:
                    field = Settings.field17;
                    break;
                case 18:
                    field = Settings.field18;
                    break;
                case 19:
                    field = Settings.field19;
                    break;
                case 20:
                    field = Settings.field20;
                    break;
                case 21:
                    field = Settings.field21;
                    break;
                case 22:
                    field = Settings.field22;
                    break;
                case 23:
                    field = Settings.field23;
                    break;
                case 24:
                    field = Settings.field24;
                    break;
                case 25:
                    field = Settings.field25;
                    break;
                case 26:
                    field = Settings.field26;
                    break;
                case 27:
                    field = Settings.field27;
                    break;
            }
            return field;
        }

       



    }
}



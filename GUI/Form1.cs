using Controller;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GUI
{
    public partial class Form1 : Form
    {
        //Besked fra Planken Haha

        //Message from laptop
        NodeController nodeController;
        AiController aiController;
        List<Label> allLabels = new List<Label>();
        List<Label> roundOneLabels = new List<Label>();
        List<Label> roundTwoLabels = new List<Label>();
        List<Label> roundThreeLabels = new List<Label>();
        List<Label> roundFourLabels = new List<Label>();
        List<Label> roundFiveLabels = new List<Label>();
        List<Label> roundSixLabels = new List<Label>();
        List<Label> roundSevenLabels = new List<Label>();
        List<Label> roundEightLabels = new List<Label>();
        List<Label> roundNineLabels = new List<Label>();
        List<Label> roundTenLabels = new List<Label>();
        List<GroupBox> groupBoxes = new List<GroupBox>();

        

        public Form1()
        {
            InitializeComponent();
            nodeController = new NodeController();
            aiController = new AiController();
            PopulateUI();
        }

        private void YouWin()
        {
           var result = MessageBox.Show($"Congratulations! \nYou are victorious.\nYou won after {nodeController.Round} rounds \nWould you like to play again?", "Victory", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if(result == DialogResult.Yes)
            {
                StartGame();
            }
            else
            {
                this.Close();
                base.Dispose();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            nodeController.generateList();
            Guess();
        }

        private void PopulateComboBoxes()
        {
            object[] colors = { GameNode.Color.Black, GameNode.Color.Green, GameNode.Color.Red, GameNode.Color.White, GameNode.Color.Yellow };
            cmbBoxColor1.Items.AddRange(colors);
            cmbBoxColor2.Items.AddRange(colors);
            cmbBoxColor3.Items.AddRange(colors);
            cmbBoxColor4.Items.AddRange(colors);
            cmbBoxColor1.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBoxColor2.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBoxColor3.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBoxColor4.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void Guess()
        {
            if (ReadyToProceed() && nodeController.Round < 10)
            {
                AddGuesses();
                nodeController.Round++;
                UpdateUI();

            }

            else if (!ReadyToProceed())
            {
                MessageBox.Show("Please choose a color for every node", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
               var result = MessageBox.Show("You lost.. \nWould you like to try again?", "Defeat", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
               if(result == DialogResult.Yes)
                {
                    StartGame();
                }
               else
                {
                    this.Close();
                    base.Dispose();
                }
            }
        }

        private void PopulateUI()
        {
            PopulateComboBoxes();
            PopulateLabelGuessList();
            PopulateGroupBoxes();
        }

        private void UpdateUI()
        {
            Score score;
            switch (nodeController.Round)
            {
                case 1:
                    for (int i = 0; i < roundOneLabels.Count; i++)
                    {
                        roundOneLabels[i].Text = nodeController.GuessList[i].NodeColor.ToString();
                    }
                    groupBox1.Visible = true;
                    score = nodeController.CompareGuess(aiController.ColorCombination);
                    WhiteScore1.Text = ($"White points: {score.WhitePoint}");
                    BlackScore1.Text = ($"Black points: {score.BlackPoint}");
                    CheckForVictory(score);
                    break;

                case 2:
                    for (int i = 0; i < roundTwoLabels.Count; i++)
                    {
                        roundTwoLabels[i].Text = nodeController.GuessList[i].NodeColor.ToString();
                    }
                    groupBox2.Visible = true;

                    score = nodeController.CompareGuess(aiController.ColorCombination);
                    WhiteScore2.Text = ($"White points: {score.WhitePoint}");
                    BlackScore2.Text = ($"Black points: {score.BlackPoint}");
                    CheckForVictory(score);
                    break;

                case 3:
                    for (int i = 0; i < roundThreeLabels.Count; i++)
                    {
                        roundThreeLabels[i].Text = nodeController.GuessList[i].NodeColor.ToString();
                    }
                    groupBox3.Visible = true;

                    score = nodeController.CompareGuess(aiController.ColorCombination);
                    WhiteScore3.Text = ($"White points: {score.WhitePoint}");
                    BlackScore3.Text = ($"Black points: {score.BlackPoint}");
                    CheckForVictory(score);
                    break;

                case 4:
                    for (int i = 0; i < roundFourLabels.Count; i++)
                    {
                        roundFourLabels[i].Text = nodeController.GuessList[i].NodeColor.ToString();
                    }
                    groupBox4.Visible = true;

                    score = nodeController.CompareGuess(aiController.ColorCombination);
                    WhiteScore4.Text = ($"White points: {score.WhitePoint}");
                    BlackScore4.Text = ($"Black points: {score.BlackPoint}");
                    CheckForVictory(score);
                    break;

                case 5:
                    for (int i = 0; i < roundFiveLabels.Count; i++)
                    {
                        roundFiveLabels[i].Text = nodeController.GuessList[i].NodeColor.ToString();
                    }
                    groupBox5.Visible = true;

                    score = nodeController.CompareGuess(aiController.ColorCombination);
                    WhiteScore5.Text = ($"White points: {score.WhitePoint}");
                    BlackScore5.Text = ($"Black points: {score.BlackPoint}");
                    CheckForVictory(score);
                    break;

                case 6:
                    for (int i = 0; i < roundSixLabels.Count; i++)
                    {
                        roundSixLabels[i].Text = nodeController.GuessList[i].NodeColor.ToString();
                    }
                    groupBox6.Visible = true;

                    score = nodeController.CompareGuess(aiController.ColorCombination);
                    WhiteScore6.Text = ($"White points: {score.WhitePoint}");
                    BlackScore6.Text = ($"Black points: {score.BlackPoint}");
                    CheckForVictory(score);
                    break;

                case 7:
                    for (int i = 0; i < roundSevenLabels.Count; i++)
                    {
                        roundSevenLabels[i].Text = nodeController.GuessList[i].NodeColor.ToString();
                    }
                    groupBox7.Visible = true;

                    score = nodeController.CompareGuess(aiController.ColorCombination);
                    WhiteScore7.Text = ($"White points: {score.WhitePoint}");
                    BlackScore7.Text = ($"Black points: {score.BlackPoint}");
                    CheckForVictory(score);
                    break;

                case 8:
                    for (int i = 0; i < roundEightLabels.Count; i++)
                    {
                        roundEightLabels[i].Text = nodeController.GuessList[i].NodeColor.ToString();
                    }
                    groupBox8.Visible = true;

                    score = nodeController.CompareGuess(aiController.ColorCombination);
                    WhiteScore8.Text = ($"White points: {score.WhitePoint}");
                    BlackScore8.Text = ($"Black points: {score.BlackPoint}");
                    CheckForVictory(score);
                    break;

                case 9:
                    for (int i = 0; i < roundNineLabels.Count; i++)
                    {
                        roundNineLabels[i].Text = nodeController.GuessList[i].NodeColor.ToString();
                    }
                    groupBox9.Visible = true;

                    score = nodeController.CompareGuess(aiController.ColorCombination);
                    WhiteScore9.Text = ($"White points: {score.WhitePoint}");
                    BlackScore9.Text = ($"Black points: {score.BlackPoint}");
                    CheckForVictory(score);
                    break;

                case 10:
                    for (int i = 0; i < roundTenLabels.Count; i++)
                    {
                        roundTenLabels[i].Text = nodeController.GuessList[i].NodeColor.ToString();
                    }
                    groupBox10.Visible = true;

                    score = nodeController.CompareGuess(aiController.ColorCombination);
                    WhiteScore10.Text = ($"White points: {score.WhitePoint}");
                    BlackScore10.Text = ($"Black points: {score.BlackPoint}");
                    CheckForVictory(score);
                    break;
            }
        }
        private void AddGuesses()
        {
            nodeController.AddGuess(new GameNode((GameNode.Color)cmbBoxColor1.SelectedItem, 1));
            nodeController.AddGuess(new GameNode((GameNode.Color)cmbBoxColor2.SelectedItem, 2));
            nodeController.AddGuess(new GameNode((GameNode.Color)cmbBoxColor3.SelectedItem, 3));
            nodeController.AddGuess(new GameNode((GameNode.Color)cmbBoxColor4.SelectedItem, 4));
        }
        private bool ReadyToProceed()
        {
            bool proceed = false;
            if(cmbBoxColor1.SelectedItem != null && cmbBoxColor2.SelectedItem != null && cmbBoxColor3.SelectedItem != null && cmbBoxColor4.SelectedItem != null)
            {
                proceed = true;
            }
            return proceed;
        }

        private void StartGame()
        {
            aiController = new AiController();
            nodeController.Round = 0;
            foreach (var item in allLabels)
            {
                item.Text = "";
            }
            foreach (var item in groupBoxes)
            {
                item.Visible = false;
            }

        }


        private void PopulateLabelGuessList()
        {
            roundOneLabels.Add(OneLblOne);
            roundOneLabels.Add(OneLblTwo);
            roundOneLabels.Add(OneLblThree);
            roundOneLabels.Add(OneLblFour);

            roundTwoLabels.Add(TwoLblOne);
            roundTwoLabels.Add(TwoLblTwo);
            roundTwoLabels.Add(TwoLblThree);
            roundTwoLabels.Add(TwoLblFour);

            roundThreeLabels.Add(ThreeLblOne);
            roundThreeLabels.Add(ThreeLblTwo);
            roundThreeLabels.Add(ThreeLblThree);
            roundThreeLabels.Add(ThreeLblFour);

            roundFourLabels.Add(FourLblOne);
            roundFourLabels.Add(FourLblTwo);
            roundFourLabels.Add(FourLblThree);
            roundFourLabels.Add(FourLblFour);

            roundFiveLabels.Add(FiveLblOne);
            roundFiveLabels.Add(FiveLblTwo);
            roundFiveLabels.Add(FiveLblThree);
            roundFiveLabels.Add(FiveLblFour);

            roundSixLabels.Add(SixLblOne);
            roundSixLabels.Add(SixLblTwo);
            roundSixLabels.Add(SixLblThree);
            roundSixLabels.Add(SixLblFour);

            roundSevenLabels.Add(SevenLblOne);
            roundSevenLabels.Add(SevenLblTwo);
            roundSevenLabels.Add(SevenLblThree);
            roundSevenLabels.Add(SevenLblFour);

            roundEightLabels.Add(EightLblOne);
            roundEightLabels.Add(EightLblTwo);
            roundEightLabels.Add(EightLblThree);
            roundEightLabels.Add(EightLblFour);

            roundNineLabels.Add(NineLblOne);
            roundNineLabels.Add(NineLblTwo);
            roundNineLabels.Add(NineLblThree);
            roundNineLabels.Add(NineLblFour);

            roundTenLabels.Add(TenLblOne);
            roundTenLabels.Add(TenLblTwo);
            roundTenLabels.Add(TenLblThree);
            roundTenLabels.Add(TenLblFour);

            allLabels.AddRange(roundOneLabels);
            allLabels.AddRange(roundTwoLabels);
            allLabels.AddRange(roundThreeLabels);
            allLabels.AddRange(roundFourLabels);
            allLabels.AddRange(roundFiveLabels);
            allLabels.AddRange(roundSixLabels);
            allLabels.AddRange(roundSevenLabels);
            allLabels.AddRange(roundEightLabels);
            allLabels.AddRange(roundNineLabels);
            allLabels.AddRange(roundTenLabels);

            allLabels.Add(BlackScore1);
            allLabels.Add(BlackScore2);
            allLabels.Add(BlackScore3);
            allLabels.Add(BlackScore4);
            allLabels.Add(BlackScore5);
            allLabels.Add(BlackScore6);
            allLabels.Add(BlackScore7);
            allLabels.Add(BlackScore8);
            allLabels.Add(BlackScore9);
            allLabels.Add(BlackScore10);

            allLabels.Add(WhiteScore1);
            allLabels.Add(WhiteScore2);
            allLabels.Add(WhiteScore3);
            allLabels.Add(WhiteScore4);
            allLabels.Add(WhiteScore5);
            allLabels.Add(WhiteScore6);
            allLabels.Add(WhiteScore7);
            allLabels.Add(WhiteScore8);
            allLabels.Add(WhiteScore9);
            allLabels.Add(WhiteScore10);
        }

        private void PopulateGroupBoxes()
        {
            groupBoxes.Add(groupBox1);
            groupBoxes.Add(groupBox2);
            groupBoxes.Add(groupBox3);
            groupBoxes.Add(groupBox4);
            groupBoxes.Add(groupBox5);
            groupBoxes.Add(groupBox6);
            groupBoxes.Add(groupBox7);
            groupBoxes.Add(groupBox8);
            groupBoxes.Add(groupBox9);
            groupBoxes.Add(groupBox10);
        }

        private void CheckForVictory(Score score)
        {
            if(score.BlackPoint == 4)
            {
                YouWin();
            }
        }
    }
}

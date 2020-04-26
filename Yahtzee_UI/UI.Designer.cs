using System.Windows.Controls;

namespace Yahtzee_UI
{
    partial class UI 
    {

        public int rollCounter;
        public int maxAttemps = 3;
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UI));
            this.title = new System.Windows.Forms.Label();
            this.dicePicture2 = new System.Windows.Forms.PictureBox();
            this.dicePicture5 = new System.Windows.Forms.PictureBox();
            this.dicePicture4 = new System.Windows.Forms.PictureBox();
            this.dicePicture3 = new System.Windows.Forms.PictureBox();
            this.dicePicture1 = new System.Windows.Forms.PictureBox();
            this.gameCardPanel = new System.Windows.Forms.Panel();
            this.gameCardLoadPicture = new System.Windows.Forms.PictureBox();
            this.gamecardLowerSection = new System.Windows.Forms.TableLayoutPanel();
            this.grandTotalDesc = new System.Windows.Forms.Label();
            this.threeOfKindTitle = new System.Windows.Forms.Label();
            this.fourOfKindTitle = new System.Windows.Forms.Label();
            this.fullHouseTitle = new System.Windows.Forms.Label();
            this.threeOfKindDesc = new System.Windows.Forms.Label();
            this.fourOfKindDesc = new System.Windows.Forms.Label();
            this.fullHouseDesc = new System.Windows.Forms.Label();
            this.smallStreetTitle = new System.Windows.Forms.Label();
            this.largeStreetTitle = new System.Windows.Forms.Label();
            this.smallStreetDesc = new System.Windows.Forms.Label();
            this.largeStreetDesc = new System.Windows.Forms.Label();
            this.yahtzeeTitle = new System.Windows.Forms.Label();
            this.yahtzeeDesc = new System.Windows.Forms.Label();
            this.chanceTitle = new System.Windows.Forms.Label();
            this.chanceDesc = new System.Windows.Forms.Label();
            this.totalLowerTitle = new System.Windows.Forms.Label();
            this.totalUpperTitle = new System.Windows.Forms.Label();
            this.grandTotalTitle = new System.Windows.Forms.Label();
            this.totalLowerDesc = new System.Windows.Forms.Label();
            this.totalUpperDesc = new System.Windows.Forms.Label();
            this.lowerSectionTitle = new System.Windows.Forms.Label();
            this.gamecardUpperSection = new System.Windows.Forms.TableLayoutPanel();
            this.twosTitle = new System.Windows.Forms.Label();
            this.foursTitle = new System.Windows.Forms.Label();
            this.fivesTitle = new System.Windows.Forms.Label();
            this.sixesTitle = new System.Windows.Forms.Label();
            this.threesTitle = new System.Windows.Forms.Label();
            this.totalScoreTitle = new System.Windows.Forms.Label();
            this.bonusTitle = new System.Windows.Forms.Label();
            this.totalTitle = new System.Windows.Forms.Label();
            this.acesTitle = new System.Windows.Forms.Label();
            this.acesDesc = new System.Windows.Forms.Label();
            this.twosDesc = new System.Windows.Forms.Label();
            this.threesDesc = new System.Windows.Forms.Label();
            this.foursDesc = new System.Windows.Forms.Label();
            this.fivesDesc = new System.Windows.Forms.Label();
            this.sixesDesc = new System.Windows.Forms.Label();
            this.totalScoreDesc = new System.Windows.Forms.Label();
            this.bonusDesc = new System.Windows.Forms.Label();
            this.totalDesc = new System.Windows.Forms.Label();
            this.howToScoreLabel = new System.Windows.Forms.Label();
            this.upperSectionTitle = new System.Windows.Forms.Label();
            this.threeOfKindValueGame1 = new System.Windows.Forms.Label();
            this.threeOfKindValueGame2 = new System.Windows.Forms.Label();
            this.threeOfKindValueGame3 = new System.Windows.Forms.Label();
            this.threeOfKindValueGame4 = new System.Windows.Forms.Label();
            this.fourOfKindValueGame1 = new System.Windows.Forms.Label();
            this.fourOfKindValueGame2 = new System.Windows.Forms.Label();
            this.fourOfKindValueGame3 = new System.Windows.Forms.Label();
            this.fourOfKindValueGame4 = new System.Windows.Forms.Label();
            this.fullHouseValueGame1 = new System.Windows.Forms.Label();
            this.fullHouseValueGame2 = new System.Windows.Forms.Label();
            this.fullHouseValueGame3 = new System.Windows.Forms.Label();
            this.fullHouseValueGame4 = new System.Windows.Forms.Label();
            this.smallStreetValueGame1 = new System.Windows.Forms.Label();
            this.smallStreetValueGame2 = new System.Windows.Forms.Label();
            this.smallStreetValueGame3 = new System.Windows.Forms.Label();
            this.smallStreetValueGame4 = new System.Windows.Forms.Label();
            this.largeStreetValueGame1 = new System.Windows.Forms.Label();
            this.largeStreetValueGame2 = new System.Windows.Forms.Label();
            this.largeStreetValueGame3 = new System.Windows.Forms.Label();
            this.largeStreetValueGame4 = new System.Windows.Forms.Label();
            this.yahtzeeValueGame1 = new System.Windows.Forms.Label();
            this.yahtzeeValueGame2 = new System.Windows.Forms.Label();
            this.yahtzeeValueGame3 = new System.Windows.Forms.Label();
            this.yahtzeeValueGame4 = new System.Windows.Forms.Label();
            this.chanceValueGame1 = new System.Windows.Forms.Label();
            this.chanceValueGame2 = new System.Windows.Forms.Label();
            this.chanceValueGame3 = new System.Windows.Forms.Label();
            this.chanceValueGame4 = new System.Windows.Forms.Label();
            this.totalLowerValueGame1 = new System.Windows.Forms.Label();
            this.totalLowerValueGame2 = new System.Windows.Forms.Label();
            this.totalLowerValueGame3 = new System.Windows.Forms.Label();
            this.totalLowerValueGame4 = new System.Windows.Forms.Label();
            this.totalUpperValueGame1 = new System.Windows.Forms.Label();
            this.totalUpperValueGame2 = new System.Windows.Forms.Label();
            this.totalUpperValueGame3 = new System.Windows.Forms.Label();
            this.totalUpperValueGame4 = new System.Windows.Forms.Label();
            this.grandTotalValueGame1 = new System.Windows.Forms.Label();
            this.grandTotalValueGame2 = new System.Windows.Forms.Label();
            this.grandTotalValueGame3 = new System.Windows.Forms.Label();
            this.grandTotalValueGame4 = new System.Windows.Forms.Label();
            this.game1Label = new System.Windows.Forms.Label();
            this.game2Label = new System.Windows.Forms.Label();
            this.game3Label = new System.Windows.Forms.Label();
            this.game4Label = new System.Windows.Forms.Label();
            this.acesValueGame1 = new System.Windows.Forms.Label();
            this.acesValueGame2 = new System.Windows.Forms.Label();
            this.acesValueGame3 = new System.Windows.Forms.Label();
            this.acesValueGame4 = new System.Windows.Forms.Label();
            this.twosValueGame1 = new System.Windows.Forms.Label();
            this.twosValueGame2 = new System.Windows.Forms.Label();
            this.twosValueGame3 = new System.Windows.Forms.Label();
            this.twosValueGame4 = new System.Windows.Forms.Label();
            this.threesValueGame1 = new System.Windows.Forms.Label();
            this.threesValueGame2 = new System.Windows.Forms.Label();
            this.threesValueGame3 = new System.Windows.Forms.Label();
            this.threesValueGame4 = new System.Windows.Forms.Label();
            this.foursValueGame1 = new System.Windows.Forms.Label();
            this.foursValueGame2 = new System.Windows.Forms.Label();
            this.foursValueGame3 = new System.Windows.Forms.Label();
            this.foursValueGame4 = new System.Windows.Forms.Label();
            this.fivesValueGame1 = new System.Windows.Forms.Label();
            this.fivesValueGame2 = new System.Windows.Forms.Label();
            this.fivesValueGame3 = new System.Windows.Forms.Label();
            this.fivesValueGame4 = new System.Windows.Forms.Label();
            this.sixesValueGame1 = new System.Windows.Forms.Label();
            this.sixesValueGame2 = new System.Windows.Forms.Label();
            this.sixesValueGame3 = new System.Windows.Forms.Label();
            this.sixesValueGame4 = new System.Windows.Forms.Label();
            this.totalScoreValueGame1 = new System.Windows.Forms.Label();
            this.totalScoreValueGame2 = new System.Windows.Forms.Label();
            this.totalScoreValueGame3 = new System.Windows.Forms.Label();
            this.totalScoreValueGame4 = new System.Windows.Forms.Label();
            this.bonusValueGame1 = new System.Windows.Forms.Label();
            this.bonusValueGame2 = new System.Windows.Forms.Label();
            this.bonusValueGame3 = new System.Windows.Forms.Label();
            this.bonusValueGame4 = new System.Windows.Forms.Label();
            this.totalValueGame1 = new System.Windows.Forms.Label();
            this.totalValueGame2 = new System.Windows.Forms.Label();
            this.totalValueGame3 = new System.Windows.Forms.Label();
            this.totalValueGame4 = new System.Windows.Forms.Label();
            this.Gamecard = new System.Windows.Forms.Label();
            this.rollDiceButton = new System.Windows.Forms.Button();
            this.stopDiceButton = new System.Windows.Forms.Button();
            this.resultChoiceSelect = new System.Windows.Forms.ComboBox();
            this.resultChoiceButton = new System.Windows.Forms.Button();
            this.resultChoiceDesc = new System.Windows.Forms.Label();
            this.crossOutBoxSelect = new System.Windows.Forms.ComboBox();
            this.crossOutButton = new System.Windows.Forms.Button();
            this.resultChoiceGameSelect = new System.Windows.Forms.ComboBox();
            this.resultChoiceInLabel = new System.Windows.Forms.Label();
            this.actionPanel = new System.Windows.Forms.Panel();
            this.dicePanel = new System.Windows.Forms.Panel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.nbGamesLabel = new System.Windows.Forms.Label();
            this.nbGamesSelect = new System.Windows.Forms.ComboBox();
            this.nbGamesPanel = new System.Windows.Forms.Panel();
            this.startButton = new System.Windows.Forms.Button();
            this.scoreButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dicePicture2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dicePicture5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dicePicture4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dicePicture3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dicePicture1)).BeginInit();
            this.gameCardPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gameCardLoadPicture)).BeginInit();
            this.gamecardLowerSection.SuspendLayout();
            this.gamecardUpperSection.SuspendLayout();
            this.actionPanel.SuspendLayout();
            this.dicePanel.SuspendLayout();
            this.nbGamesPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.Color.Coral;
            this.title.Font = new System.Drawing.Font("Minerva", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.title.Location = new System.Drawing.Point(504, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(165, 50);
            this.title.TabIndex = 0;
            this.title.Text = "YAHTZEE";
            // 
            // dicePicture2
            // 
            this.dicePicture2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.dicePicture2.Location = new System.Drawing.Point(404, 59);
            this.dicePicture2.Name = "dicePicture2";
            this.dicePicture2.Size = new System.Drawing.Size(140, 140);
            this.dicePicture2.TabIndex = 5;
            this.dicePicture2.TabStop = false;
            this.dicePicture2.Click += new System.EventHandler(this.dicePicture2_Click);
            // 
            // dicePicture5
            // 
            this.dicePicture5.BackColor = System.Drawing.SystemColors.ControlLight;
            this.dicePicture5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.dicePicture5.Location = new System.Drawing.Point(507, 253);
            this.dicePicture5.Name = "dicePicture5";
            this.dicePicture5.Size = new System.Drawing.Size(140, 140);
            this.dicePicture5.TabIndex = 4;
            this.dicePicture5.TabStop = false;
            this.dicePicture5.Click += new System.EventHandler(this.dicePicture5_Click);
            // 
            // dicePicture4
            // 
            this.dicePicture4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.dicePicture4.Location = new System.Drawing.Point(273, 253);
            this.dicePicture4.Name = "dicePicture4";
            this.dicePicture4.Size = new System.Drawing.Size(140, 140);
            this.dicePicture4.TabIndex = 3;
            this.dicePicture4.TabStop = false;
            this.dicePicture4.Click += new System.EventHandler(this.dicePicture4_Click);
            // 
            // dicePicture3
            // 
            this.dicePicture3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.dicePicture3.Location = new System.Drawing.Point(39, 253);
            this.dicePicture3.Name = "dicePicture3";
            this.dicePicture3.Size = new System.Drawing.Size(140, 140);
            this.dicePicture3.TabIndex = 2;
            this.dicePicture3.TabStop = false;
            this.dicePicture3.Click += new System.EventHandler(this.dicePicture3_Click);
            // 
            // dicePicture1
            // 
            this.dicePicture1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.dicePicture1.Location = new System.Drawing.Point(138, 59);
            this.dicePicture1.Name = "dicePicture1";
            this.dicePicture1.Size = new System.Drawing.Size(140, 140);
            this.dicePicture1.TabIndex = 0;
            this.dicePicture1.TabStop = false;
            this.dicePicture1.Click += new System.EventHandler(this.dicePicture1_Click);
            // 
            // gameCardPanel
            // 
            this.gameCardPanel.Controls.Add(this.gameCardLoadPicture);
            this.gameCardPanel.Controls.Add(this.gamecardLowerSection);
            this.gameCardPanel.Controls.Add(this.gamecardUpperSection);
            this.gameCardPanel.Location = new System.Drawing.Point(741, 75);
            this.gameCardPanel.Name = "gameCardPanel";
            this.gameCardPanel.Size = new System.Drawing.Size(470, 480);
            this.gameCardPanel.TabIndex = 1;
            this.gameCardPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.gameCardPanel_Paint);
            // 
            // gameCardLoadPicture
            // 
            this.gameCardLoadPicture.Location = new System.Drawing.Point(0, 0);
            this.gameCardLoadPicture.Name = "gameCardLoadPicture";
            this.gameCardLoadPicture.Size = new System.Drawing.Size(467, 477);
            this.gameCardLoadPicture.TabIndex = 3;
            this.gameCardLoadPicture.TabStop = false;
            // 
            // gamecardLowerSection
            // 
            this.gamecardLowerSection.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gamecardLowerSection.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.gamecardLowerSection.ColumnCount = 2;
            this.gamecardLowerSection.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 115F));
            this.gamecardLowerSection.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.gamecardLowerSection.Controls.Add(this.grandTotalDesc, 1, 10);
            this.gamecardLowerSection.Controls.Add(this.threeOfKindTitle, 0, 1);
            this.gamecardLowerSection.Controls.Add(this.fourOfKindTitle, 0, 2);
            this.gamecardLowerSection.Controls.Add(this.fullHouseTitle, 0, 3);
            this.gamecardLowerSection.Controls.Add(this.threeOfKindDesc, 1, 1);
            this.gamecardLowerSection.Controls.Add(this.fourOfKindDesc, 1, 2);
            this.gamecardLowerSection.Controls.Add(this.fullHouseDesc, 1, 3);
            this.gamecardLowerSection.Controls.Add(this.smallStreetTitle, 0, 4);
            this.gamecardLowerSection.Controls.Add(this.largeStreetTitle, 0, 5);
            this.gamecardLowerSection.Controls.Add(this.smallStreetDesc, 1, 4);
            this.gamecardLowerSection.Controls.Add(this.largeStreetDesc, 1, 5);
            this.gamecardLowerSection.Controls.Add(this.yahtzeeTitle, 0, 6);
            this.gamecardLowerSection.Controls.Add(this.yahtzeeDesc, 1, 6);
            this.gamecardLowerSection.Controls.Add(this.chanceTitle, 0, 7);
            this.gamecardLowerSection.Controls.Add(this.chanceDesc, 1, 7);
            this.gamecardLowerSection.Controls.Add(this.totalLowerTitle, 0, 8);
            this.gamecardLowerSection.Controls.Add(this.totalUpperTitle, 0, 9);
            this.gamecardLowerSection.Controls.Add(this.grandTotalTitle, 0, 10);
            this.gamecardLowerSection.Controls.Add(this.totalLowerDesc, 1, 8);
            this.gamecardLowerSection.Controls.Add(this.totalUpperDesc, 1, 9);
            this.gamecardLowerSection.Controls.Add(this.lowerSectionTitle, 0, 0);
            this.gamecardLowerSection.Font = new System.Drawing.Font("Raleway", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gamecardLowerSection.Location = new System.Drawing.Point(19, 230);
            this.gamecardLowerSection.Name = "gamecardLowerSection";
            this.gamecardLowerSection.RowCount = 11;
            this.gamecardLowerSection.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.gamecardLowerSection.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.gamecardLowerSection.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.gamecardLowerSection.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.gamecardLowerSection.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.gamecardLowerSection.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.gamecardLowerSection.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.gamecardLowerSection.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.gamecardLowerSection.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.gamecardLowerSection.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.gamecardLowerSection.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.gamecardLowerSection.Size = new System.Drawing.Size(205, 237);
            this.gamecardLowerSection.TabIndex = 2;
            this.gamecardLowerSection.Visible = false;
            this.gamecardLowerSection.Paint += new System.Windows.Forms.PaintEventHandler(this.gamecardLowerSection_Paint);
            // 
            // grandTotalDesc
            // 
            this.grandTotalDesc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grandTotalDesc.AutoSize = true;
            this.grandTotalDesc.Location = new System.Drawing.Point(135, 215);
            this.grandTotalDesc.Name = "grandTotalDesc";
            this.grandTotalDesc.Size = new System.Drawing.Size(63, 16);
            this.grandTotalDesc.TabIndex = 2;
            this.grandTotalDesc.Text = "-------->";
            // 
            // threeOfKindTitle
            // 
            this.threeOfKindTitle.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.threeOfKindTitle.AutoSize = true;
            this.threeOfKindTitle.Location = new System.Drawing.Point(4, 24);
            this.threeOfKindTitle.Name = "threeOfKindTitle";
            this.threeOfKindTitle.Size = new System.Drawing.Size(75, 16);
            this.threeOfKindTitle.TabIndex = 0;
            this.threeOfKindTitle.Text = "3 of a kind";
            // 
            // fourOfKindTitle
            // 
            this.fourOfKindTitle.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.fourOfKindTitle.AutoSize = true;
            this.fourOfKindTitle.Location = new System.Drawing.Point(4, 45);
            this.fourOfKindTitle.Name = "fourOfKindTitle";
            this.fourOfKindTitle.Size = new System.Drawing.Size(76, 16);
            this.fourOfKindTitle.TabIndex = 1;
            this.fourOfKindTitle.Text = "4 of a kind";
            // 
            // fullHouseTitle
            // 
            this.fullHouseTitle.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.fullHouseTitle.AutoSize = true;
            this.fullHouseTitle.Location = new System.Drawing.Point(4, 66);
            this.fullHouseTitle.Name = "fullHouseTitle";
            this.fullHouseTitle.Size = new System.Drawing.Size(77, 16);
            this.fullHouseTitle.TabIndex = 4;
            this.fullHouseTitle.Text = "Full House";
            // 
            // threeOfKindDesc
            // 
            this.threeOfKindDesc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.threeOfKindDesc.AutoSize = true;
            this.threeOfKindDesc.Font = new System.Drawing.Font("Raleway", 6.5F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.threeOfKindDesc.Location = new System.Drawing.Point(130, 27);
            this.threeOfKindDesc.Name = "threeOfKindDesc";
            this.threeOfKindDesc.Size = new System.Drawing.Size(74, 10);
            this.threeOfKindDesc.TabIndex = 5;
            this.threeOfKindDesc.Text = "Add Total All Dice";
            // 
            // fourOfKindDesc
            // 
            this.fourOfKindDesc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fourOfKindDesc.AutoSize = true;
            this.fourOfKindDesc.Font = new System.Drawing.Font("Raleway", 6.5F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fourOfKindDesc.Location = new System.Drawing.Point(130, 48);
            this.fourOfKindDesc.Name = "fourOfKindDesc";
            this.fourOfKindDesc.Size = new System.Drawing.Size(74, 10);
            this.fourOfKindDesc.TabIndex = 6;
            this.fourOfKindDesc.Text = "Add Total All Dice";
            // 
            // fullHouseDesc
            // 
            this.fullHouseDesc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fullHouseDesc.AutoSize = true;
            this.fullHouseDesc.Font = new System.Drawing.Font("Roboto Light", 6.5F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullHouseDesc.Location = new System.Drawing.Point(144, 68);
            this.fullHouseDesc.Name = "fullHouseDesc";
            this.fullHouseDesc.Size = new System.Drawing.Size(45, 11);
            this.fullHouseDesc.TabIndex = 7;
            this.fullHouseDesc.Text = "SCORE 25";
            // 
            // smallStreetTitle
            // 
            this.smallStreetTitle.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.smallStreetTitle.AutoSize = true;
            this.smallStreetTitle.Location = new System.Drawing.Point(4, 87);
            this.smallStreetTitle.Name = "smallStreetTitle";
            this.smallStreetTitle.Size = new System.Drawing.Size(90, 16);
            this.smallStreetTitle.TabIndex = 9;
            this.smallStreetTitle.Text = "Small Street";
            // 
            // largeStreetTitle
            // 
            this.largeStreetTitle.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.largeStreetTitle.AutoSize = true;
            this.largeStreetTitle.Location = new System.Drawing.Point(4, 108);
            this.largeStreetTitle.Name = "largeStreetTitle";
            this.largeStreetTitle.Size = new System.Drawing.Size(90, 16);
            this.largeStreetTitle.TabIndex = 10;
            this.largeStreetTitle.Text = "Large Street";
            // 
            // smallStreetDesc
            // 
            this.smallStreetDesc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.smallStreetDesc.AutoSize = true;
            this.smallStreetDesc.Font = new System.Drawing.Font("Roboto Light", 6.5F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smallStreetDesc.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.smallStreetDesc.Location = new System.Drawing.Point(144, 89);
            this.smallStreetDesc.Name = "smallStreetDesc";
            this.smallStreetDesc.Size = new System.Drawing.Size(45, 11);
            this.smallStreetDesc.TabIndex = 11;
            this.smallStreetDesc.Text = "SCORE 30";
            // 
            // largeStreetDesc
            // 
            this.largeStreetDesc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.largeStreetDesc.AutoSize = true;
            this.largeStreetDesc.Font = new System.Drawing.Font("Roboto Light", 6.5F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.largeStreetDesc.Location = new System.Drawing.Point(144, 110);
            this.largeStreetDesc.Name = "largeStreetDesc";
            this.largeStreetDesc.Size = new System.Drawing.Size(45, 11);
            this.largeStreetDesc.TabIndex = 12;
            this.largeStreetDesc.Text = "SCORE 40";
            // 
            // yahtzeeTitle
            // 
            this.yahtzeeTitle.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.yahtzeeTitle.AutoSize = true;
            this.yahtzeeTitle.Location = new System.Drawing.Point(4, 129);
            this.yahtzeeTitle.Name = "yahtzeeTitle";
            this.yahtzeeTitle.Size = new System.Drawing.Size(60, 16);
            this.yahtzeeTitle.TabIndex = 15;
            this.yahtzeeTitle.Text = "Yahtzee";
            // 
            // yahtzeeDesc
            // 
            this.yahtzeeDesc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.yahtzeeDesc.AutoSize = true;
            this.yahtzeeDesc.Font = new System.Drawing.Font("Roboto Light", 6.5F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yahtzeeDesc.Location = new System.Drawing.Point(144, 131);
            this.yahtzeeDesc.Name = "yahtzeeDesc";
            this.yahtzeeDesc.Size = new System.Drawing.Size(45, 11);
            this.yahtzeeDesc.TabIndex = 17;
            this.yahtzeeDesc.Text = "SCORE 50";
            // 
            // chanceTitle
            // 
            this.chanceTitle.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chanceTitle.AutoSize = true;
            this.chanceTitle.Location = new System.Drawing.Point(4, 150);
            this.chanceTitle.Name = "chanceTitle";
            this.chanceTitle.Size = new System.Drawing.Size(58, 16);
            this.chanceTitle.TabIndex = 18;
            this.chanceTitle.Text = "Chance";
            // 
            // chanceDesc
            // 
            this.chanceDesc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chanceDesc.AutoSize = true;
            this.chanceDesc.Font = new System.Drawing.Font("Raleway", 6.5F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chanceDesc.Location = new System.Drawing.Point(139, 153);
            this.chanceDesc.Name = "chanceDesc";
            this.chanceDesc.Size = new System.Drawing.Size(56, 10);
            this.chanceDesc.TabIndex = 20;
            this.chanceDesc.Text = "Total All Dice";
            // 
            // totalLowerTitle
            // 
            this.totalLowerTitle.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.totalLowerTitle.AutoSize = true;
            this.totalLowerTitle.Location = new System.Drawing.Point(4, 171);
            this.totalLowerTitle.Name = "totalLowerTitle";
            this.totalLowerTitle.Size = new System.Drawing.Size(105, 16);
            this.totalLowerTitle.TabIndex = 21;
            this.totalLowerTitle.Text = "TOTAL (Lower)";
            // 
            // totalUpperTitle
            // 
            this.totalUpperTitle.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.totalUpperTitle.AutoSize = true;
            this.totalUpperTitle.Location = new System.Drawing.Point(4, 192);
            this.totalUpperTitle.Name = "totalUpperTitle";
            this.totalUpperTitle.Size = new System.Drawing.Size(107, 16);
            this.totalUpperTitle.TabIndex = 22;
            this.totalUpperTitle.Text = "TOTAL (Upper)";
            // 
            // grandTotalTitle
            // 
            this.grandTotalTitle.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.grandTotalTitle.AutoSize = true;
            this.grandTotalTitle.Font = new System.Drawing.Font("Raleway", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grandTotalTitle.Location = new System.Drawing.Point(4, 215);
            this.grandTotalTitle.Name = "grandTotalTitle";
            this.grandTotalTitle.Size = new System.Drawing.Size(105, 16);
            this.grandTotalTitle.TabIndex = 23;
            this.grandTotalTitle.Text = "GRAND TOTAL";
            // 
            // totalLowerDesc
            // 
            this.totalLowerDesc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.totalLowerDesc.AutoSize = true;
            this.totalLowerDesc.Location = new System.Drawing.Point(135, 171);
            this.totalLowerDesc.Name = "totalLowerDesc";
            this.totalLowerDesc.Size = new System.Drawing.Size(63, 16);
            this.totalLowerDesc.TabIndex = 24;
            this.totalLowerDesc.Text = "-------->";
            // 
            // totalUpperDesc
            // 
            this.totalUpperDesc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.totalUpperDesc.AutoSize = true;
            this.totalUpperDesc.Location = new System.Drawing.Point(135, 192);
            this.totalUpperDesc.Name = "totalUpperDesc";
            this.totalUpperDesc.Size = new System.Drawing.Size(63, 16);
            this.totalUpperDesc.TabIndex = 25;
            this.totalUpperDesc.Text = "-------->";
            // 
            // lowerSectionTitle
            // 
            this.lowerSectionTitle.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lowerSectionTitle.AutoSize = true;
            this.lowerSectionTitle.Font = new System.Drawing.Font("Raleway", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lowerSectionTitle.Location = new System.Drawing.Point(4, 4);
            this.lowerSectionTitle.Name = "lowerSectionTitle";
            this.lowerSectionTitle.Size = new System.Drawing.Size(103, 14);
            this.lowerSectionTitle.TabIndex = 29;
            this.lowerSectionTitle.Text = "LOWER SECTION";
            // 
            // gamecardUpperSection
            // 
            this.gamecardUpperSection.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gamecardUpperSection.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.gamecardUpperSection.ColumnCount = 2;
            this.gamecardUpperSection.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 115F));
            this.gamecardUpperSection.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.gamecardUpperSection.Controls.Add(this.twosTitle, 0, 2);
            this.gamecardUpperSection.Controls.Add(this.foursTitle, 0, 4);
            this.gamecardUpperSection.Controls.Add(this.fivesTitle, 0, 5);
            this.gamecardUpperSection.Controls.Add(this.sixesTitle, 0, 6);
            this.gamecardUpperSection.Controls.Add(this.threesTitle, 0, 3);
            this.gamecardUpperSection.Controls.Add(this.totalScoreTitle, 0, 7);
            this.gamecardUpperSection.Controls.Add(this.bonusTitle, 0, 8);
            this.gamecardUpperSection.Controls.Add(this.totalTitle, 0, 9);
            this.gamecardUpperSection.Controls.Add(this.acesTitle, 0, 1);
            this.gamecardUpperSection.Controls.Add(this.acesDesc, 1, 1);
            this.gamecardUpperSection.Controls.Add(this.twosDesc, 1, 2);
            this.gamecardUpperSection.Controls.Add(this.threesDesc, 1, 3);
            this.gamecardUpperSection.Controls.Add(this.foursDesc, 1, 4);
            this.gamecardUpperSection.Controls.Add(this.fivesDesc, 1, 5);
            this.gamecardUpperSection.Controls.Add(this.sixesDesc, 1, 6);
            this.gamecardUpperSection.Controls.Add(this.totalScoreDesc, 1, 7);
            this.gamecardUpperSection.Controls.Add(this.bonusDesc, 1, 8);
            this.gamecardUpperSection.Controls.Add(this.totalDesc, 1, 9);
            this.gamecardUpperSection.Controls.Add(this.howToScoreLabel, 1, 0);
            this.gamecardUpperSection.Controls.Add(this.upperSectionTitle, 0, 0);
            this.gamecardUpperSection.Font = new System.Drawing.Font("Raleway", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gamecardUpperSection.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.gamecardUpperSection.Location = new System.Drawing.Point(19, 10);
            this.gamecardUpperSection.Name = "gamecardUpperSection";
            this.gamecardUpperSection.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gamecardUpperSection.RowCount = 10;
            this.gamecardUpperSection.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.gamecardUpperSection.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.gamecardUpperSection.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.gamecardUpperSection.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.gamecardUpperSection.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.gamecardUpperSection.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.gamecardUpperSection.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.gamecardUpperSection.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.gamecardUpperSection.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.gamecardUpperSection.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.gamecardUpperSection.Size = new System.Drawing.Size(205, 212);
            this.gamecardUpperSection.TabIndex = 1;
            this.gamecardUpperSection.Visible = false;
            this.gamecardUpperSection.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // twosTitle
            // 
            this.twosTitle.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.twosTitle.AutoSize = true;
            this.twosTitle.Location = new System.Drawing.Point(4, 45);
            this.twosTitle.Name = "twosTitle";
            this.twosTitle.Size = new System.Drawing.Size(42, 16);
            this.twosTitle.TabIndex = 1;
            this.twosTitle.Text = "Twos";
            // 
            // foursTitle
            // 
            this.foursTitle.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.foursTitle.AutoSize = true;
            this.foursTitle.Location = new System.Drawing.Point(4, 87);
            this.foursTitle.Name = "foursTitle";
            this.foursTitle.Size = new System.Drawing.Size(44, 16);
            this.foursTitle.TabIndex = 5;
            this.foursTitle.Text = "Fours";
            // 
            // fivesTitle
            // 
            this.fivesTitle.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.fivesTitle.AutoSize = true;
            this.fivesTitle.Location = new System.Drawing.Point(4, 108);
            this.fivesTitle.Name = "fivesTitle";
            this.fivesTitle.Size = new System.Drawing.Size(41, 16);
            this.fivesTitle.TabIndex = 6;
            this.fivesTitle.Text = "Fives";
            // 
            // sixesTitle
            // 
            this.sixesTitle.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.sixesTitle.AutoSize = true;
            this.sixesTitle.Location = new System.Drawing.Point(4, 129);
            this.sixesTitle.Name = "sixesTitle";
            this.sixesTitle.Size = new System.Drawing.Size(42, 16);
            this.sixesTitle.TabIndex = 7;
            this.sixesTitle.Text = "Sixes";
            // 
            // threesTitle
            // 
            this.threesTitle.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.threesTitle.AutoSize = true;
            this.threesTitle.Location = new System.Drawing.Point(4, 66);
            this.threesTitle.Name = "threesTitle";
            this.threesTitle.Size = new System.Drawing.Size(53, 16);
            this.threesTitle.TabIndex = 4;
            this.threesTitle.Text = "Threes";
            // 
            // totalScoreTitle
            // 
            this.totalScoreTitle.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.totalScoreTitle.AutoSize = true;
            this.totalScoreTitle.Location = new System.Drawing.Point(4, 150);
            this.totalScoreTitle.Name = "totalScoreTitle";
            this.totalScoreTitle.Size = new System.Drawing.Size(105, 16);
            this.totalScoreTitle.TabIndex = 12;
            this.totalScoreTitle.Text = "TOTAL SCORE";
            // 
            // bonusTitle
            // 
            this.bonusTitle.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.bonusTitle.AutoSize = true;
            this.bonusTitle.Location = new System.Drawing.Point(4, 171);
            this.bonusTitle.Name = "bonusTitle";
            this.bonusTitle.Size = new System.Drawing.Size(59, 16);
            this.bonusTitle.TabIndex = 13;
            this.bonusTitle.Text = "BONUS";
            // 
            // totalTitle
            // 
            this.totalTitle.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.totalTitle.AutoSize = true;
            this.totalTitle.Location = new System.Drawing.Point(4, 192);
            this.totalTitle.Name = "totalTitle";
            this.totalTitle.Size = new System.Drawing.Size(53, 16);
            this.totalTitle.TabIndex = 14;
            this.totalTitle.Text = "TOTAL";
            // 
            // acesTitle
            // 
            this.acesTitle.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.acesTitle.AutoSize = true;
            this.acesTitle.Location = new System.Drawing.Point(4, 24);
            this.acesTitle.Name = "acesTitle";
            this.acesTitle.Size = new System.Drawing.Size(40, 16);
            this.acesTitle.TabIndex = 0;
            this.acesTitle.Text = "Aces";
            this.acesTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.acesTitle.Click += new System.EventHandler(this.label1_Click);
            // 
            // acesDesc
            // 
            this.acesDesc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.acesDesc.AutoSize = true;
            this.acesDesc.Font = new System.Drawing.Font("Raleway", 6.5F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acesDesc.Location = new System.Drawing.Point(131, 27);
            this.acesDesc.Name = "acesDesc";
            this.acesDesc.Size = new System.Drawing.Size(71, 10);
            this.acesDesc.TabIndex = 18;
            this.acesDesc.Text = "Count Only Aces";
            // 
            // twosDesc
            // 
            this.twosDesc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.twosDesc.AutoSize = true;
            this.twosDesc.Font = new System.Drawing.Font("Raleway", 6.5F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.twosDesc.Location = new System.Drawing.Point(131, 48);
            this.twosDesc.Name = "twosDesc";
            this.twosDesc.Size = new System.Drawing.Size(71, 10);
            this.twosDesc.TabIndex = 19;
            this.twosDesc.Text = "Count Only Twos";
            // 
            // threesDesc
            // 
            this.threesDesc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.threesDesc.AutoSize = true;
            this.threesDesc.Font = new System.Drawing.Font("Raleway", 6.5F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.threesDesc.Location = new System.Drawing.Point(128, 69);
            this.threesDesc.Name = "threesDesc";
            this.threesDesc.Size = new System.Drawing.Size(78, 10);
            this.threesDesc.TabIndex = 20;
            this.threesDesc.Text = "Count Only Threes";
            // 
            // foursDesc
            // 
            this.foursDesc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.foursDesc.AutoSize = true;
            this.foursDesc.Font = new System.Drawing.Font("Raleway", 6.5F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foursDesc.Location = new System.Drawing.Point(130, 90);
            this.foursDesc.Name = "foursDesc";
            this.foursDesc.Size = new System.Drawing.Size(73, 10);
            this.foursDesc.TabIndex = 21;
            this.foursDesc.Text = "Count Only Fours";
            // 
            // fivesDesc
            // 
            this.fivesDesc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fivesDesc.AutoSize = true;
            this.fivesDesc.Font = new System.Drawing.Font("Raleway", 6.5F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fivesDesc.Location = new System.Drawing.Point(131, 111);
            this.fivesDesc.Name = "fivesDesc";
            this.fivesDesc.Size = new System.Drawing.Size(71, 10);
            this.fivesDesc.TabIndex = 22;
            this.fivesDesc.Text = "Count Only Fives";
            // 
            // sixesDesc
            // 
            this.sixesDesc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sixesDesc.AutoSize = true;
            this.sixesDesc.Font = new System.Drawing.Font("Raleway", 6.5F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sixesDesc.Location = new System.Drawing.Point(131, 132);
            this.sixesDesc.Name = "sixesDesc";
            this.sixesDesc.Size = new System.Drawing.Size(71, 10);
            this.sixesDesc.TabIndex = 23;
            this.sixesDesc.Text = "Count Only Sixes";
            // 
            // totalScoreDesc
            // 
            this.totalScoreDesc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.totalScoreDesc.AutoSize = true;
            this.totalScoreDesc.Location = new System.Drawing.Point(135, 150);
            this.totalScoreDesc.Name = "totalScoreDesc";
            this.totalScoreDesc.Size = new System.Drawing.Size(63, 16);
            this.totalScoreDesc.TabIndex = 24;
            this.totalScoreDesc.Text = "-------->";
            // 
            // bonusDesc
            // 
            this.bonusDesc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bonusDesc.AutoSize = true;
            this.bonusDesc.Font = new System.Drawing.Font("Roboto Light", 6.5F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bonusDesc.Location = new System.Drawing.Point(144, 173);
            this.bonusDesc.Name = "bonusDesc";
            this.bonusDesc.Size = new System.Drawing.Size(45, 11);
            this.bonusDesc.TabIndex = 25;
            this.bonusDesc.Text = "SCORE 35";
            // 
            // totalDesc
            // 
            this.totalDesc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.totalDesc.AutoSize = true;
            this.totalDesc.Location = new System.Drawing.Point(135, 192);
            this.totalDesc.Name = "totalDesc";
            this.totalDesc.Size = new System.Drawing.Size(63, 16);
            this.totalDesc.TabIndex = 26;
            this.totalDesc.Text = "-------->";
            // 
            // howToScoreLabel
            // 
            this.howToScoreLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.howToScoreLabel.AutoSize = true;
            this.howToScoreLabel.Font = new System.Drawing.Font("Raleway", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.howToScoreLabel.Location = new System.Drawing.Point(129, 6);
            this.howToScoreLabel.Name = "howToScoreLabel";
            this.howToScoreLabel.Size = new System.Drawing.Size(75, 10);
            this.howToScoreLabel.TabIndex = 28;
            this.howToScoreLabel.Text = "HOW TO SCORE";
            // 
            // upperSectionTitle
            // 
            this.upperSectionTitle.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.upperSectionTitle.AutoSize = true;
            this.upperSectionTitle.Font = new System.Drawing.Font("Raleway", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upperSectionTitle.Location = new System.Drawing.Point(4, 4);
            this.upperSectionTitle.Name = "upperSectionTitle";
            this.upperSectionTitle.Size = new System.Drawing.Size(98, 14);
            this.upperSectionTitle.TabIndex = 27;
            this.upperSectionTitle.Text = "UPPER SECTION";
            // 
            // threeOfKindValueGame1
            // 
            this.threeOfKindValueGame1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.threeOfKindValueGame1.AutoSize = true;
            this.threeOfKindValueGame1.Location = new System.Drawing.Point(0, 0);
            this.threeOfKindValueGame1.Name = "threeOfKindValueGame1";
            this.threeOfKindValueGame1.Size = new System.Drawing.Size(16, 17);
            this.threeOfKindValueGame1.TabIndex = 2;
            // 
            // threeOfKindValueGame2
            // 
            this.threeOfKindValueGame2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.threeOfKindValueGame2.AutoSize = true;
            this.threeOfKindValueGame2.Location = new System.Drawing.Point(0, 0);
            this.threeOfKindValueGame2.Name = "threeOfKindValueGame2";
            this.threeOfKindValueGame2.Size = new System.Drawing.Size(16, 17);
            this.threeOfKindValueGame2.TabIndex = 2;
            // 
            // threeOfKindValueGame3
            // 
            this.threeOfKindValueGame3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.threeOfKindValueGame3.AutoSize = true;
            this.threeOfKindValueGame3.Location = new System.Drawing.Point(0, 0);
            this.threeOfKindValueGame3.Name = "threeOfKindValueGame3";
            this.threeOfKindValueGame3.Size = new System.Drawing.Size(16, 17);
            this.threeOfKindValueGame3.TabIndex = 2;
            // 
            // threeOfKindValueGame4
            // 
            this.threeOfKindValueGame4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.threeOfKindValueGame4.AutoSize = true;
            this.threeOfKindValueGame4.Location = new System.Drawing.Point(0, 0);
            this.threeOfKindValueGame4.Name = "threeOfKindValueGame4";
            this.threeOfKindValueGame4.Size = new System.Drawing.Size(16, 17);
            this.threeOfKindValueGame4.TabIndex = 2;
            // 
            // fourOfKindValueGame1
            // 
            this.fourOfKindValueGame1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fourOfKindValueGame1.AutoSize = true;
            this.fourOfKindValueGame1.Location = new System.Drawing.Point(0, 0);
            this.fourOfKindValueGame1.Name = "fourOfKindValueGame1";
            this.fourOfKindValueGame1.Size = new System.Drawing.Size(16, 17);
            this.fourOfKindValueGame1.TabIndex = 3;
            // 
            // fourOfKindValueGame2
            // 
            this.fourOfKindValueGame2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fourOfKindValueGame2.AutoSize = true;
            this.fourOfKindValueGame2.Location = new System.Drawing.Point(0, 0);
            this.fourOfKindValueGame2.Name = "fourOfKindValueGame2";
            this.fourOfKindValueGame2.Size = new System.Drawing.Size(16, 17);
            this.fourOfKindValueGame2.TabIndex = 3;
            // 
            // fourOfKindValueGame3
            // 
            this.fourOfKindValueGame3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fourOfKindValueGame3.AutoSize = true;
            this.fourOfKindValueGame3.Location = new System.Drawing.Point(0, 0);
            this.fourOfKindValueGame3.Name = "fourOfKindValueGame3";
            this.fourOfKindValueGame3.Size = new System.Drawing.Size(16, 17);
            this.fourOfKindValueGame3.TabIndex = 3;
            // 
            // fourOfKindValueGame4
            // 
            this.fourOfKindValueGame4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fourOfKindValueGame4.AutoSize = true;
            this.fourOfKindValueGame4.Location = new System.Drawing.Point(0, 0);
            this.fourOfKindValueGame4.Name = "fourOfKindValueGame4";
            this.fourOfKindValueGame4.Size = new System.Drawing.Size(16, 17);
            this.fourOfKindValueGame4.TabIndex = 3;
            // 
            // fullHouseValueGame1
            // 
            this.fullHouseValueGame1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fullHouseValueGame1.AutoSize = true;
            this.fullHouseValueGame1.Location = new System.Drawing.Point(0, 0);
            this.fullHouseValueGame1.Name = "fullHouseValueGame1";
            this.fullHouseValueGame1.Size = new System.Drawing.Size(16, 17);
            this.fullHouseValueGame1.TabIndex = 8;
            // 
            // fullHouseValueGame2
            // 
            this.fullHouseValueGame2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fullHouseValueGame2.AutoSize = true;
            this.fullHouseValueGame2.Location = new System.Drawing.Point(0, 0);
            this.fullHouseValueGame2.Name = "fullHouseValueGame2";
            this.fullHouseValueGame2.Size = new System.Drawing.Size(16, 17);
            this.fullHouseValueGame2.TabIndex = 8;
            // 
            // fullHouseValueGame3
            // 
            this.fullHouseValueGame3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fullHouseValueGame3.AutoSize = true;
            this.fullHouseValueGame3.Location = new System.Drawing.Point(0, 0);
            this.fullHouseValueGame3.Name = "fullHouseValueGame3";
            this.fullHouseValueGame3.Size = new System.Drawing.Size(16, 17);
            this.fullHouseValueGame3.TabIndex = 8;
            // 
            // fullHouseValueGame4
            // 
            this.fullHouseValueGame4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fullHouseValueGame4.AutoSize = true;
            this.fullHouseValueGame4.Location = new System.Drawing.Point(0, 0);
            this.fullHouseValueGame4.Name = "fullHouseValueGame4";
            this.fullHouseValueGame4.Size = new System.Drawing.Size(16, 17);
            this.fullHouseValueGame4.TabIndex = 8;
            // 
            // smallStreetValueGame1
            // 
            this.smallStreetValueGame1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.smallStreetValueGame1.AutoSize = true;
            this.smallStreetValueGame1.Location = new System.Drawing.Point(0, 0);
            this.smallStreetValueGame1.Name = "smallStreetValueGame1";
            this.smallStreetValueGame1.Size = new System.Drawing.Size(16, 17);
            this.smallStreetValueGame1.TabIndex = 13;
            // 
            // smallStreetValueGame2
            // 
            this.smallStreetValueGame2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.smallStreetValueGame2.AutoSize = true;
            this.smallStreetValueGame2.Location = new System.Drawing.Point(0, 0);
            this.smallStreetValueGame2.Name = "smallStreetValueGame2";
            this.smallStreetValueGame2.Size = new System.Drawing.Size(16, 17);
            this.smallStreetValueGame2.TabIndex = 13;
            // 
            // smallStreetValueGame3
            // 
            this.smallStreetValueGame3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.smallStreetValueGame3.AutoSize = true;
            this.smallStreetValueGame3.Location = new System.Drawing.Point(0, 0);
            this.smallStreetValueGame3.Name = "smallStreetValueGame3";
            this.smallStreetValueGame3.Size = new System.Drawing.Size(16, 17);
            this.smallStreetValueGame3.TabIndex = 13;
            // 
            // smallStreetValueGame4
            // 
            this.smallStreetValueGame4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.smallStreetValueGame4.AutoSize = true;
            this.smallStreetValueGame4.Location = new System.Drawing.Point(0, 0);
            this.smallStreetValueGame4.Name = "smallStreetValueGame4";
            this.smallStreetValueGame4.Size = new System.Drawing.Size(16, 17);
            this.smallStreetValueGame4.TabIndex = 13;
            // 
            // largeStreetValueGame1
            // 
            this.largeStreetValueGame1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.largeStreetValueGame1.AutoSize = true;
            this.largeStreetValueGame1.Location = new System.Drawing.Point(0, 0);
            this.largeStreetValueGame1.Name = "largeStreetValueGame1";
            this.largeStreetValueGame1.Size = new System.Drawing.Size(16, 17);
            this.largeStreetValueGame1.TabIndex = 14;
            // 
            // largeStreetValueGame2
            // 
            this.largeStreetValueGame2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.largeStreetValueGame2.AutoSize = true;
            this.largeStreetValueGame2.Location = new System.Drawing.Point(0, 0);
            this.largeStreetValueGame2.Name = "largeStreetValueGame2";
            this.largeStreetValueGame2.Size = new System.Drawing.Size(16, 17);
            this.largeStreetValueGame2.TabIndex = 14;
            // 
            // largeStreetValueGame3
            // 
            this.largeStreetValueGame3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.largeStreetValueGame3.AutoSize = true;
            this.largeStreetValueGame3.Location = new System.Drawing.Point(0, 0);
            this.largeStreetValueGame3.Name = "largeStreetValueGame3";
            this.largeStreetValueGame3.Size = new System.Drawing.Size(16, 17);
            this.largeStreetValueGame3.TabIndex = 14;
            // 
            // largeStreetValueGame4
            // 
            this.largeStreetValueGame4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.largeStreetValueGame4.AutoSize = true;
            this.largeStreetValueGame4.Location = new System.Drawing.Point(0, 0);
            this.largeStreetValueGame4.Name = "largeStreetValueGame4";
            this.largeStreetValueGame4.Size = new System.Drawing.Size(16, 17);
            this.largeStreetValueGame4.TabIndex = 14;
            // 
            // yahtzeeValueGame1
            // 
            this.yahtzeeValueGame1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.yahtzeeValueGame1.AutoSize = true;
            this.yahtzeeValueGame1.Location = new System.Drawing.Point(0, 0);
            this.yahtzeeValueGame1.Name = "yahtzeeValueGame1";
            this.yahtzeeValueGame1.Size = new System.Drawing.Size(16, 17);
            this.yahtzeeValueGame1.TabIndex = 16;
            // 
            // yahtzeeValueGame2
            // 
            this.yahtzeeValueGame2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.yahtzeeValueGame2.AutoSize = true;
            this.yahtzeeValueGame2.Location = new System.Drawing.Point(0, 0);
            this.yahtzeeValueGame2.Name = "yahtzeeValueGame2";
            this.yahtzeeValueGame2.Size = new System.Drawing.Size(16, 17);
            this.yahtzeeValueGame2.TabIndex = 16;
            // 
            // yahtzeeValueGame3
            // 
            this.yahtzeeValueGame3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.yahtzeeValueGame3.AutoSize = true;
            this.yahtzeeValueGame3.Location = new System.Drawing.Point(0, 0);
            this.yahtzeeValueGame3.Name = "yahtzeeValueGame3";
            this.yahtzeeValueGame3.Size = new System.Drawing.Size(16, 17);
            this.yahtzeeValueGame3.TabIndex = 16;
            // 
            // yahtzeeValueGame4
            // 
            this.yahtzeeValueGame4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.yahtzeeValueGame4.AutoSize = true;
            this.yahtzeeValueGame4.Location = new System.Drawing.Point(0, 0);
            this.yahtzeeValueGame4.Name = "yahtzeeValueGame4";
            this.yahtzeeValueGame4.Size = new System.Drawing.Size(16, 17);
            this.yahtzeeValueGame4.TabIndex = 16;
            // 
            // chanceValueGame1
            // 
            this.chanceValueGame1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chanceValueGame1.AutoSize = true;
            this.chanceValueGame1.Location = new System.Drawing.Point(0, 0);
            this.chanceValueGame1.Name = "chanceValueGame1";
            this.chanceValueGame1.Size = new System.Drawing.Size(16, 17);
            this.chanceValueGame1.TabIndex = 19;
            // 
            // chanceValueGame2
            // 
            this.chanceValueGame2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chanceValueGame2.AutoSize = true;
            this.chanceValueGame2.Location = new System.Drawing.Point(0, 0);
            this.chanceValueGame2.Name = "chanceValueGame2";
            this.chanceValueGame2.Size = new System.Drawing.Size(16, 17);
            this.chanceValueGame2.TabIndex = 19;
            // 
            // chanceValueGame3
            // 
            this.chanceValueGame3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chanceValueGame3.AutoSize = true;
            this.chanceValueGame3.Location = new System.Drawing.Point(0, 0);
            this.chanceValueGame3.Name = "chanceValueGame3";
            this.chanceValueGame3.Size = new System.Drawing.Size(16, 17);
            this.chanceValueGame3.TabIndex = 19;
            // 
            // chanceValueGame4
            // 
            this.chanceValueGame4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chanceValueGame4.AutoSize = true;
            this.chanceValueGame4.Location = new System.Drawing.Point(0, 0);
            this.chanceValueGame4.Name = "chanceValueGame4";
            this.chanceValueGame4.Size = new System.Drawing.Size(16, 17);
            this.chanceValueGame4.TabIndex = 19;
            // 
            // totalLowerValueGame1
            // 
            this.totalLowerValueGame1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.totalLowerValueGame1.AutoSize = true;
            this.totalLowerValueGame1.Location = new System.Drawing.Point(0, 0);
            this.totalLowerValueGame1.Name = "totalLowerValueGame1";
            this.totalLowerValueGame1.Size = new System.Drawing.Size(16, 17);
            this.totalLowerValueGame1.TabIndex = 26;
            this.totalLowerValueGame1.Text = "0";
            // 
            // totalLowerValueGame2
            // 
            this.totalLowerValueGame2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.totalLowerValueGame2.AutoSize = true;
            this.totalLowerValueGame2.Location = new System.Drawing.Point(0, 0);
            this.totalLowerValueGame2.Name = "totalLowerValueGame2";
            this.totalLowerValueGame2.Size = new System.Drawing.Size(16, 17);
            this.totalLowerValueGame2.TabIndex = 26;
            this.totalLowerValueGame2.Text = "0";
            // 
            // totalLowerValueGame3
            // 
            this.totalLowerValueGame3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.totalLowerValueGame3.AutoSize = true;
            this.totalLowerValueGame3.Location = new System.Drawing.Point(0, 0);
            this.totalLowerValueGame3.Name = "totalLowerValueGame3";
            this.totalLowerValueGame3.Size = new System.Drawing.Size(16, 17);
            this.totalLowerValueGame3.TabIndex = 26;
            this.totalLowerValueGame3.Text = "0";
            // 
            // totalLowerValueGame4
            // 
            this.totalLowerValueGame4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.totalLowerValueGame4.AutoSize = true;
            this.totalLowerValueGame4.Location = new System.Drawing.Point(0, 0);
            this.totalLowerValueGame4.Name = "totalLowerValueGame4";
            this.totalLowerValueGame4.Size = new System.Drawing.Size(16, 17);
            this.totalLowerValueGame4.TabIndex = 26;
            this.totalLowerValueGame4.Text = "0";
            // 
            // totalUpperValueGame1
            // 
            this.totalUpperValueGame1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.totalUpperValueGame1.AutoSize = true;
            this.totalUpperValueGame1.Location = new System.Drawing.Point(0, 0);
            this.totalUpperValueGame1.Name = "totalUpperValueGame1";
            this.totalUpperValueGame1.Size = new System.Drawing.Size(16, 17);
            this.totalUpperValueGame1.TabIndex = 27;
            this.totalUpperValueGame1.Text = "0";
            // 
            // totalUpperValueGame2
            // 
            this.totalUpperValueGame2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.totalUpperValueGame2.AutoSize = true;
            this.totalUpperValueGame2.Location = new System.Drawing.Point(0, 0);
            this.totalUpperValueGame2.Name = "totalUpperValueGame2";
            this.totalUpperValueGame2.Size = new System.Drawing.Size(16, 17);
            this.totalUpperValueGame2.TabIndex = 27;
            this.totalUpperValueGame2.Text = "0";
            // 
            // totalUpperValueGame3
            // 
            this.totalUpperValueGame3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.totalUpperValueGame3.AutoSize = true;
            this.totalUpperValueGame3.Location = new System.Drawing.Point(0, 0);
            this.totalUpperValueGame3.Name = "totalUpperValueGame3";
            this.totalUpperValueGame3.Size = new System.Drawing.Size(16, 17);
            this.totalUpperValueGame3.TabIndex = 27;
            this.totalUpperValueGame3.Text = "0";
            // 
            // totalUpperValueGame4
            // 
            this.totalUpperValueGame4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.totalUpperValueGame4.AutoSize = true;
            this.totalUpperValueGame4.Location = new System.Drawing.Point(0, 0);
            this.totalUpperValueGame4.Name = "totalUpperValueGame4";
            this.totalUpperValueGame4.Size = new System.Drawing.Size(16, 17);
            this.totalUpperValueGame4.TabIndex = 27;
            this.totalUpperValueGame4.Text = "0";
            // 
            // grandTotalValueGame1
            // 
            this.grandTotalValueGame1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grandTotalValueGame1.AutoSize = true;
            this.grandTotalValueGame1.Font = new System.Drawing.Font("Raleway", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grandTotalValueGame1.Location = new System.Drawing.Point(0, 0);
            this.grandTotalValueGame1.Name = "grandTotalValueGame1";
            this.grandTotalValueGame1.Size = new System.Drawing.Size(16, 17);
            this.grandTotalValueGame1.TabIndex = 28;
            this.grandTotalValueGame1.Text = "0";
            // 
            // grandTotalValueGame2
            // 
            this.grandTotalValueGame2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grandTotalValueGame2.AutoSize = true;
            this.grandTotalValueGame2.Font = new System.Drawing.Font("Raleway", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grandTotalValueGame2.Location = new System.Drawing.Point(0, 0);
            this.grandTotalValueGame2.Name = "grandTotalValueGame2";
            this.grandTotalValueGame2.Size = new System.Drawing.Size(16, 17);
            this.grandTotalValueGame2.TabIndex = 28;
            this.grandTotalValueGame2.Text = "0";
            // 
            // grandTotalValueGame3
            // 
            this.grandTotalValueGame3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grandTotalValueGame3.AutoSize = true;
            this.grandTotalValueGame3.Font = new System.Drawing.Font("Raleway", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grandTotalValueGame3.Location = new System.Drawing.Point(0, 0);
            this.grandTotalValueGame3.Name = "grandTotalValueGame3";
            this.grandTotalValueGame3.Size = new System.Drawing.Size(16, 17);
            this.grandTotalValueGame3.TabIndex = 28;
            this.grandTotalValueGame3.Text = "0";
            // 
            // grandTotalValueGame4
            // 
            this.grandTotalValueGame4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grandTotalValueGame4.AutoSize = true;
            this.grandTotalValueGame4.Font = new System.Drawing.Font("Raleway", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grandTotalValueGame4.Location = new System.Drawing.Point(0, 0);
            this.grandTotalValueGame4.Name = "grandTotalValueGame4";
            this.grandTotalValueGame4.Size = new System.Drawing.Size(16, 17);
            this.grandTotalValueGame4.TabIndex = 28;
            this.grandTotalValueGame4.Text = "0";
            // 
            // game1Label
            // 
            this.game1Label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.game1Label.AutoSize = true;
            this.game1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.game1Label.Location = new System.Drawing.Point(0, 0);
            this.game1Label.Name = "game1Label";
            this.game1Label.Size = new System.Drawing.Size(57, 13);
            this.game1Label.TabIndex = 29;
            this.game1Label.Text = "Game #1";
            // 
            // game2Label
            // 
            this.game2Label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.game2Label.AutoSize = true;
            this.game2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.game2Label.Location = new System.Drawing.Point(0, 0);
            this.game2Label.Name = "game2Label";
            this.game2Label.Size = new System.Drawing.Size(57, 13);
            this.game2Label.TabIndex = 29;
            this.game2Label.Text = "Game #2";
            // 
            // game3Label
            // 
            this.game3Label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.game3Label.AutoSize = true;
            this.game3Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.game3Label.Location = new System.Drawing.Point(0, 0);
            this.game3Label.Name = "game3Label";
            this.game3Label.Size = new System.Drawing.Size(57, 13);
            this.game3Label.TabIndex = 29;
            this.game3Label.Text = "Game #3";
            // 
            // game4Label
            // 
            this.game4Label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.game4Label.AutoSize = true;
            this.game4Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.game4Label.Location = new System.Drawing.Point(0, 0);
            this.game4Label.Name = "game4Label";
            this.game4Label.Size = new System.Drawing.Size(57, 13);
            this.game4Label.TabIndex = 29;
            this.game4Label.Text = "Game #4";
            // 
            // acesValueGame1
            // 
            this.acesValueGame1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.acesValueGame1.AutoSize = true;
            this.acesValueGame1.Location = new System.Drawing.Point(0, 0);
            this.acesValueGame1.Name = "acesValueGame1";
            this.acesValueGame1.Size = new System.Drawing.Size(16, 17);
            this.acesValueGame1.TabIndex = 2;
            // 
            // acesValueGame2
            // 
            this.acesValueGame2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.acesValueGame2.AutoSize = true;
            this.acesValueGame2.Location = new System.Drawing.Point(0, 0);
            this.acesValueGame2.Name = "acesValueGame2";
            this.acesValueGame2.Size = new System.Drawing.Size(16, 17);
            this.acesValueGame2.TabIndex = 2;
            // 
            // acesValueGame3
            // 
            this.acesValueGame3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.acesValueGame3.AutoSize = true;
            this.acesValueGame3.Location = new System.Drawing.Point(0, 0);
            this.acesValueGame3.Name = "acesValueGame3";
            this.acesValueGame3.Size = new System.Drawing.Size(16, 17);
            this.acesValueGame3.TabIndex = 2;
            // 
            // acesValueGame4
            // 
            this.acesValueGame4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.acesValueGame4.AutoSize = true;
            this.acesValueGame4.Location = new System.Drawing.Point(0, 0);
            this.acesValueGame4.Name = "acesValueGame4";
            this.acesValueGame4.Size = new System.Drawing.Size(16, 17);
            this.acesValueGame4.TabIndex = 2;
            // 
            // twosValueGame1
            // 
            this.twosValueGame1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.twosValueGame1.AutoSize = true;
            this.twosValueGame1.Location = new System.Drawing.Point(0, 0);
            this.twosValueGame1.Name = "twosValueGame1";
            this.twosValueGame1.Size = new System.Drawing.Size(16, 17);
            this.twosValueGame1.TabIndex = 3;
            // 
            // twosValueGame2
            // 
            this.twosValueGame2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.twosValueGame2.AutoSize = true;
            this.twosValueGame2.Location = new System.Drawing.Point(0, 0);
            this.twosValueGame2.Name = "twosValueGame2";
            this.twosValueGame2.Size = new System.Drawing.Size(16, 17);
            this.twosValueGame2.TabIndex = 3;
            // 
            // twosValueGame3
            // 
            this.twosValueGame3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.twosValueGame3.AutoSize = true;
            this.twosValueGame3.Location = new System.Drawing.Point(0, 0);
            this.twosValueGame3.Name = "twosValueGame3";
            this.twosValueGame3.Size = new System.Drawing.Size(16, 17);
            this.twosValueGame3.TabIndex = 3;
            // 
            // twosValueGame4
            // 
            this.twosValueGame4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.twosValueGame4.AutoSize = true;
            this.twosValueGame4.Location = new System.Drawing.Point(0, 0);
            this.twosValueGame4.Name = "twosValueGame4";
            this.twosValueGame4.Size = new System.Drawing.Size(16, 17);
            this.twosValueGame4.TabIndex = 3;
            // 
            // threesValueGame1
            // 
            this.threesValueGame1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.threesValueGame1.AutoSize = true;
            this.threesValueGame1.Location = new System.Drawing.Point(0, 0);
            this.threesValueGame1.Name = "threesValueGame1";
            this.threesValueGame1.Size = new System.Drawing.Size(16, 17);
            this.threesValueGame1.TabIndex = 8;
            // 
            // threesValueGame2
            // 
            this.threesValueGame2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.threesValueGame2.AutoSize = true;
            this.threesValueGame2.Location = new System.Drawing.Point(0, 0);
            this.threesValueGame2.Name = "threesValueGame2";
            this.threesValueGame2.Size = new System.Drawing.Size(16, 17);
            this.threesValueGame2.TabIndex = 8;
            // 
            // threesValueGame3
            // 
            this.threesValueGame3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.threesValueGame3.AutoSize = true;
            this.threesValueGame3.Location = new System.Drawing.Point(0, 0);
            this.threesValueGame3.Name = "threesValueGame3";
            this.threesValueGame3.Size = new System.Drawing.Size(16, 17);
            this.threesValueGame3.TabIndex = 8;
            // 
            // threesValueGame4
            // 
            this.threesValueGame4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.threesValueGame4.AutoSize = true;
            this.threesValueGame4.Location = new System.Drawing.Point(0, 0);
            this.threesValueGame4.Name = "threesValueGame4";
            this.threesValueGame4.Size = new System.Drawing.Size(16, 17);
            this.threesValueGame4.TabIndex = 8;
            // 
            // foursValueGame1
            // 
            this.foursValueGame1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.foursValueGame1.AutoSize = true;
            this.foursValueGame1.Location = new System.Drawing.Point(0, 0);
            this.foursValueGame1.Name = "foursValueGame1";
            this.foursValueGame1.Size = new System.Drawing.Size(16, 17);
            this.foursValueGame1.TabIndex = 9;
            // 
            // foursValueGame2
            // 
            this.foursValueGame2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.foursValueGame2.AutoSize = true;
            this.foursValueGame2.Location = new System.Drawing.Point(0, 0);
            this.foursValueGame2.Name = "foursValueGame2";
            this.foursValueGame2.Size = new System.Drawing.Size(100, 23);
            this.foursValueGame2.TabIndex = 9;
            // 
            // foursValueGame3
            // 
            this.foursValueGame3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.foursValueGame3.AutoSize = true;
            this.foursValueGame3.Location = new System.Drawing.Point(0, 0);
            this.foursValueGame3.Name = "foursValueGame3";
            this.foursValueGame3.Size = new System.Drawing.Size(16, 17);
            this.foursValueGame3.TabIndex = 9;
            // 
            // foursValueGame4
            // 
            this.foursValueGame4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.foursValueGame4.AutoSize = true;
            this.foursValueGame4.Location = new System.Drawing.Point(0, 0);
            this.foursValueGame4.Name = "foursValueGame4";
            this.foursValueGame4.Size = new System.Drawing.Size(16, 17);
            this.foursValueGame4.TabIndex = 9;
            // 
            // fivesValueGame1
            // 
            this.fivesValueGame1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fivesValueGame1.AutoSize = true;
            this.fivesValueGame1.Location = new System.Drawing.Point(0, 0);
            this.fivesValueGame1.Name = "fivesValueGame1";
            this.fivesValueGame1.Size = new System.Drawing.Size(16, 17);
            this.fivesValueGame1.TabIndex = 10;
            // 
            // fivesValueGame2
            // 
            this.fivesValueGame2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fivesValueGame2.AutoSize = true;
            this.fivesValueGame2.Location = new System.Drawing.Point(0, 0);
            this.fivesValueGame2.Name = "fivesValueGame2";
            this.fivesValueGame2.Size = new System.Drawing.Size(16, 17);
            this.fivesValueGame2.TabIndex = 10;
            // 
            // fivesValueGame3
            // 
            this.fivesValueGame3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fivesValueGame3.AutoSize = true;
            this.fivesValueGame3.Location = new System.Drawing.Point(0, 0);
            this.fivesValueGame3.Name = "fivesValueGame3";
            this.fivesValueGame3.Size = new System.Drawing.Size(16, 17);
            this.fivesValueGame3.TabIndex = 10;
            // 
            // fivesValueGame4
            // 
            this.fivesValueGame4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fivesValueGame4.AutoSize = true;
            this.fivesValueGame4.Location = new System.Drawing.Point(0, 0);
            this.fivesValueGame4.Name = "fivesValueGame4";
            this.fivesValueGame4.Size = new System.Drawing.Size(16, 17);
            this.fivesValueGame4.TabIndex = 10;
            // 
            // sixesValueGame1
            // 
            this.sixesValueGame1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sixesValueGame1.AutoSize = true;
            this.sixesValueGame1.Location = new System.Drawing.Point(0, 0);
            this.sixesValueGame1.Name = "sixesValueGame1";
            this.sixesValueGame1.Size = new System.Drawing.Size(16, 17);
            this.sixesValueGame1.TabIndex = 11;
            // 
            // sixesValueGame2
            // 
            this.sixesValueGame2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sixesValueGame2.AutoSize = true;
            this.sixesValueGame2.Location = new System.Drawing.Point(0, 0);
            this.sixesValueGame2.Name = "sixesValueGame2";
            this.sixesValueGame2.Size = new System.Drawing.Size(16, 17);
            this.sixesValueGame2.TabIndex = 11;
            // 
            // sixesValueGame3
            // 
            this.sixesValueGame3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sixesValueGame3.AutoSize = true;
            this.sixesValueGame3.Location = new System.Drawing.Point(0, 0);
            this.sixesValueGame3.Name = "sixesValueGame3";
            this.sixesValueGame3.Size = new System.Drawing.Size(16, 17);
            this.sixesValueGame3.TabIndex = 11;
            // 
            // sixesValueGame4
            // 
            this.sixesValueGame4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sixesValueGame4.AutoSize = true;
            this.sixesValueGame4.Location = new System.Drawing.Point(0, 0);
            this.sixesValueGame4.Name = "sixesValueGame4";
            this.sixesValueGame4.Size = new System.Drawing.Size(16, 17);
            this.sixesValueGame4.TabIndex = 11;
            // 
            // totalScoreValueGame1
            // 
            this.totalScoreValueGame1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.totalScoreValueGame1.AutoSize = true;
            this.totalScoreValueGame1.Location = new System.Drawing.Point(0, 0);
            this.totalScoreValueGame1.Name = "totalScoreValueGame1";
            this.totalScoreValueGame1.Size = new System.Drawing.Size(16, 17);
            this.totalScoreValueGame1.TabIndex = 15;
            this.totalScoreValueGame1.Text = "0";
            // 
            // totalScoreValueGame2
            // 
            this.totalScoreValueGame2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.totalScoreValueGame2.AutoSize = true;
            this.totalScoreValueGame2.Location = new System.Drawing.Point(0, 0);
            this.totalScoreValueGame2.Name = "totalScoreValueGame2";
            this.totalScoreValueGame2.Size = new System.Drawing.Size(16, 17);
            this.totalScoreValueGame2.TabIndex = 15;
            this.totalScoreValueGame2.Text = "0";
            // 
            // totalScoreValueGame3
            // 
            this.totalScoreValueGame3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.totalScoreValueGame3.AutoSize = true;
            this.totalScoreValueGame3.Location = new System.Drawing.Point(0, 0);
            this.totalScoreValueGame3.Name = "totalScoreValueGame3";
            this.totalScoreValueGame3.Size = new System.Drawing.Size(16, 17);
            this.totalScoreValueGame3.TabIndex = 15;
            this.totalScoreValueGame3.Text = "0";
            // 
            // totalScoreValueGame4
            // 
            this.totalScoreValueGame4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.totalScoreValueGame4.AutoSize = true;
            this.totalScoreValueGame4.Location = new System.Drawing.Point(0, 0);
            this.totalScoreValueGame4.Name = "totalScoreValueGame4";
            this.totalScoreValueGame4.Size = new System.Drawing.Size(16, 17);
            this.totalScoreValueGame4.TabIndex = 15;
            this.totalScoreValueGame4.Text = "0";
            // 
            // bonusValueGame1
            // 
            this.bonusValueGame1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bonusValueGame1.AutoSize = true;
            this.bonusValueGame1.Location = new System.Drawing.Point(0, 0);
            this.bonusValueGame1.Name = "bonusValueGame1";
            this.bonusValueGame1.Size = new System.Drawing.Size(16, 17);
            this.bonusValueGame1.TabIndex = 16;
            // 
            // bonusValueGame2
            // 
            this.bonusValueGame2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bonusValueGame2.AutoSize = true;
            this.bonusValueGame2.Location = new System.Drawing.Point(0, 0);
            this.bonusValueGame2.Name = "bonusValueGame2";
            this.bonusValueGame2.Size = new System.Drawing.Size(16, 17);
            this.bonusValueGame2.TabIndex = 16;
            // 
            // bonusValueGame3
            // 
            this.bonusValueGame3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bonusValueGame3.AutoSize = true;
            this.bonusValueGame3.Location = new System.Drawing.Point(0, 0);
            this.bonusValueGame3.Name = "bonusValueGame3";
            this.bonusValueGame3.Size = new System.Drawing.Size(16, 17);
            this.bonusValueGame3.TabIndex = 16;
            // 
            // bonusValueGame4
            // 
            this.bonusValueGame4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bonusValueGame4.AutoSize = true;
            this.bonusValueGame4.Location = new System.Drawing.Point(0, 0);
            this.bonusValueGame4.Name = "bonusValueGame4";
            this.bonusValueGame4.Size = new System.Drawing.Size(16, 17);
            this.bonusValueGame4.TabIndex = 16;
            // 
            // totalValueGame1
            // 
            this.totalValueGame1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.totalValueGame1.AutoSize = true;
            this.totalValueGame1.Location = new System.Drawing.Point(0, 0);
            this.totalValueGame1.Name = "totalValueGame1";
            this.totalValueGame1.Size = new System.Drawing.Size(16, 17);
            this.totalValueGame1.TabIndex = 17;
            this.totalValueGame1.Text = "0";
            // 
            // totalValueGame2
            // 
            this.totalValueGame2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.totalValueGame2.AutoSize = true;
            this.totalValueGame2.Location = new System.Drawing.Point(0, 0);
            this.totalValueGame2.Name = "totalValueGame2";
            this.totalValueGame2.Size = new System.Drawing.Size(16, 17);
            this.totalValueGame2.TabIndex = 17;
            this.totalValueGame2.Text = "0";
            // 
            // totalValueGame3
            // 
            this.totalValueGame3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.totalValueGame3.AutoSize = true;
            this.totalValueGame3.Location = new System.Drawing.Point(0, 0);
            this.totalValueGame3.Name = "totalValueGame3";
            this.totalValueGame3.Size = new System.Drawing.Size(16, 17);
            this.totalValueGame3.TabIndex = 17;
            this.totalValueGame3.Text = "0";
            // 
            // totalValueGame4
            // 
            this.totalValueGame4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.totalValueGame4.AutoSize = true;
            this.totalValueGame4.Location = new System.Drawing.Point(0, 0);
            this.totalValueGame4.Name = "totalValueGame4";
            this.totalValueGame4.Size = new System.Drawing.Size(16, 17);
            this.totalValueGame4.TabIndex = 17;
            this.totalValueGame4.Text = "0";
            // 
            // Gamecard
            // 
            this.Gamecard.AutoSize = true;
            this.Gamecard.Font = new System.Drawing.Font("MelodBold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gamecard.Location = new System.Drawing.Point(839, 38);
            this.Gamecard.Name = "Gamecard";
            this.Gamecard.Size = new System.Drawing.Size(163, 34);
            this.Gamecard.TabIndex = 0;
            this.Gamecard.Text = "Gamecard";
            this.Gamecard.Click += new System.EventHandler(this.Gamecard_Click);
            // 
            // rollDiceButton
            // 
            this.rollDiceButton.Enabled = false;
            this.rollDiceButton.Font = new System.Drawing.Font("Raleway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rollDiceButton.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.rollDiceButton.Location = new System.Drawing.Point(36, 17);
            this.rollDiceButton.Name = "rollDiceButton";
            this.rollDiceButton.Size = new System.Drawing.Size(256, 51);
            this.rollDiceButton.TabIndex = 2;
            this.rollDiceButton.Text = "Roll the dice";
            this.rollDiceButton.UseVisualStyleBackColor = true;
            this.rollDiceButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // stopDiceButton
            // 
            this.stopDiceButton.Enabled = false;
            this.stopDiceButton.Font = new System.Drawing.Font("Raleway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopDiceButton.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.stopDiceButton.Location = new System.Drawing.Point(335, 17);
            this.stopDiceButton.Name = "stopDiceButton";
            this.stopDiceButton.Size = new System.Drawing.Size(209, 51);
            this.stopDiceButton.TabIndex = 3;
            this.stopDiceButton.Text = "Stop";
            this.stopDiceButton.UseVisualStyleBackColor = true;
            this.stopDiceButton.Click += new System.EventHandler(this.stopDiceButton_Click);
            // 
            // resultChoiceSelect
            // 
            this.resultChoiceSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.resultChoiceSelect.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.resultChoiceSelect.Font = new System.Drawing.Font("Raleway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultChoiceSelect.Location = new System.Drawing.Point(737, 18);
            this.resultChoiceSelect.MaxDropDownItems = 12;
            this.resultChoiceSelect.Name = "resultChoiceSelect";
            this.resultChoiceSelect.Size = new System.Drawing.Size(178, 27);
            this.resultChoiceSelect.TabIndex = 4;
            this.resultChoiceSelect.Visible = false;
            this.resultChoiceSelect.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // resultChoiceButton
            // 
            this.resultChoiceButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.resultChoiceButton.Font = new System.Drawing.Font("Raleway", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultChoiceButton.Location = new System.Drawing.Point(1102, 18);
            this.resultChoiceButton.Name = "resultChoiceButton";
            this.resultChoiceButton.Size = new System.Drawing.Size(40, 27);
            this.resultChoiceButton.TabIndex = 5;
            this.resultChoiceButton.Text = "OK";
            this.resultChoiceButton.UseVisualStyleBackColor = true;
            this.resultChoiceButton.Visible = false;
            this.resultChoiceButton.Click += new System.EventHandler(this.resultChoiceButton_Click);
            // 
            // resultChoiceDesc
            // 
            this.resultChoiceDesc.AutoSize = true;
            this.resultChoiceDesc.Font = new System.Drawing.Font("Raleway", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultChoiceDesc.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.resultChoiceDesc.Location = new System.Drawing.Point(588, 24);
            this.resultChoiceDesc.Name = "resultChoiceDesc";
            this.resultChoiceDesc.Size = new System.Drawing.Size(134, 16);
            this.resultChoiceDesc.TabIndex = 6;
            this.resultChoiceDesc.Text = "Insert your result ➔";
            this.resultChoiceDesc.Visible = false;
            // 
            // crossOutBoxSelect
            // 
            this.crossOutBoxSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.crossOutBoxSelect.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.crossOutBoxSelect.Font = new System.Drawing.Font("Raleway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crossOutBoxSelect.FormattingEnabled = true;
            this.crossOutBoxSelect.Location = new System.Drawing.Point(737, 58);
            this.crossOutBoxSelect.Name = "crossOutBoxSelect";
            this.crossOutBoxSelect.Size = new System.Drawing.Size(178, 27);
            this.crossOutBoxSelect.TabIndex = 7;
            this.crossOutBoxSelect.Visible = false;
            // 
            // crossOutButton
            // 
            this.crossOutButton.Font = new System.Drawing.Font("Raleway", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crossOutButton.Location = new System.Drawing.Point(925, 58);
            this.crossOutButton.Name = "crossOutButton";
            this.crossOutButton.Size = new System.Drawing.Size(40, 27);
            this.crossOutButton.TabIndex = 8;
            this.crossOutButton.Text = "OK";
            this.crossOutButton.UseVisualStyleBackColor = true;
            this.crossOutButton.Visible = false;
            this.crossOutButton.Click += new System.EventHandler(this.crossOutButton_Click);
            // 
            // resultChoiceGameSelect
            // 
            this.resultChoiceGameSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.resultChoiceGameSelect.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.resultChoiceGameSelect.Font = new System.Drawing.Font("Raleway", 12F);
            this.resultChoiceGameSelect.FormattingEnabled = true;
            this.resultChoiceGameSelect.Location = new System.Drawing.Point(970, 18);
            this.resultChoiceGameSelect.Name = "resultChoiceGameSelect";
            this.resultChoiceGameSelect.Size = new System.Drawing.Size(121, 27);
            this.resultChoiceGameSelect.TabIndex = 9;
            this.resultChoiceGameSelect.Visible = false;
            this.resultChoiceGameSelect.SelectedIndexChanged += new System.EventHandler(this.resultChoiceGameSelect_SelectedIndexChanged);
            // 
            // resultChoiceInLabel
            // 
            this.resultChoiceInLabel.AutoSize = true;
            this.resultChoiceInLabel.Font = new System.Drawing.Font("Raleway", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultChoiceInLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.resultChoiceInLabel.Location = new System.Drawing.Point(933, 22);
            this.resultChoiceInLabel.Name = "resultChoiceInLabel";
            this.resultChoiceInLabel.Size = new System.Drawing.Size(21, 19);
            this.resultChoiceInLabel.TabIndex = 10;
            this.resultChoiceInLabel.Text = "in";
            this.resultChoiceInLabel.Visible = false;
            this.resultChoiceInLabel.Click += new System.EventHandler(this.label4_Click);
            // 
            // actionPanel
            // 
            this.actionPanel.Controls.Add(this.rollDiceButton);
            this.actionPanel.Controls.Add(this.stopDiceButton);
            this.actionPanel.Controls.Add(this.resultChoiceSelect);
            this.actionPanel.Controls.Add(this.resultChoiceInLabel);
            this.actionPanel.Controls.Add(this.resultChoiceButton);
            this.actionPanel.Controls.Add(this.resultChoiceGameSelect);
            this.actionPanel.Controls.Add(this.resultChoiceDesc);
            this.actionPanel.Controls.Add(this.crossOutButton);
            this.actionPanel.Controls.Add(this.crossOutBoxSelect);
            this.actionPanel.Location = new System.Drawing.Point(37, 570);
            this.actionPanel.Name = "actionPanel";
            this.actionPanel.Size = new System.Drawing.Size(1174, 97);
            this.actionPanel.TabIndex = 13;
            this.actionPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.actionPanel_Paint);
            // 
            // dicePanel
            // 
            this.dicePanel.Controls.Add(this.dicePicture2);
            this.dicePanel.Controls.Add(this.dicePicture1);
            this.dicePanel.Controls.Add(this.dicePicture5);
            this.dicePanel.Controls.Add(this.dicePicture3);
            this.dicePanel.Controls.Add(this.dicePicture4);
            this.dicePanel.Location = new System.Drawing.Point(37, 75);
            this.dicePanel.Name = "dicePanel";
            this.dicePanel.Size = new System.Drawing.Size(685, 480);
            this.dicePanel.TabIndex = 6;
            // 
            // nbGamesLabel
            // 
            this.nbGamesLabel.AutoSize = true;
            this.nbGamesLabel.Font = new System.Drawing.Font("Raleway", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nbGamesLabel.Location = new System.Drawing.Point(3, 10);
            this.nbGamesLabel.Name = "nbGamesLabel";
            this.nbGamesLabel.Size = new System.Drawing.Size(131, 16);
            this.nbGamesLabel.TabIndex = 14;
            this.nbGamesLabel.Text = "Number of games:";
            this.nbGamesLabel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // nbGamesSelect
            // 
            this.nbGamesSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.nbGamesSelect.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.nbGamesSelect.Font = new System.Drawing.Font("Raleway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nbGamesSelect.FormattingEnabled = true;
            this.nbGamesSelect.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.nbGamesSelect.Location = new System.Drawing.Point(137, 5);
            this.nbGamesSelect.Name = "nbGamesSelect";
            this.nbGamesSelect.Size = new System.Drawing.Size(53, 27);
            this.nbGamesSelect.TabIndex = 15;
            this.nbGamesSelect.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // nbGamesPanel
            // 
            this.nbGamesPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nbGamesPanel.Controls.Add(this.nbGamesLabel);
            this.nbGamesPanel.Controls.Add(this.nbGamesSelect);
            this.nbGamesPanel.Location = new System.Drawing.Point(37, 22);
            this.nbGamesPanel.Name = "nbGamesPanel";
            this.nbGamesPanel.Size = new System.Drawing.Size(201, 37);
            this.nbGamesPanel.TabIndex = 16;
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("Raleway", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.ForeColor = System.Drawing.Color.DarkBlue;
            this.startButton.Location = new System.Drawing.Point(244, 22);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(85, 37);
            this.startButton.TabIndex = 17;
            this.startButton.Text = "PLAY";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // scoreButton
            // 
            this.scoreButton.Font = new System.Drawing.Font("Raleway", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreButton.Location = new System.Drawing.Point(1136, 12);
            this.scoreButton.Name = "scoreButton";
            this.scoreButton.Size = new System.Drawing.Size(75, 23);
            this.scoreButton.TabIndex = 18;
            this.scoreButton.Text = "Score";
            this.scoreButton.UseVisualStyleBackColor = true;
            this.scoreButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1223, 694);
            this.Controls.Add(this.scoreButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.nbGamesPanel);
            this.Controls.Add(this.gameCardPanel);
            this.Controls.Add(this.dicePanel);
            this.Controls.Add(this.actionPanel);
            this.Controls.Add(this.Gamecard);
            this.Controls.Add(this.title);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YAHTZEE - (Janos Falke 2020)";
            this.Load += new System.EventHandler(this.UI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dicePicture2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dicePicture5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dicePicture4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dicePicture3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dicePicture1)).EndInit();
            this.gameCardPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gameCardLoadPicture)).EndInit();
            this.gamecardLowerSection.ResumeLayout(false);
            this.gamecardLowerSection.PerformLayout();
            this.gamecardUpperSection.ResumeLayout(false);
            this.gamecardUpperSection.PerformLayout();
            this.actionPanel.ResumeLayout(false);
            this.actionPanel.PerformLayout();
            this.dicePanel.ResumeLayout(false);
            this.nbGamesPanel.ResumeLayout(false);
            this.nbGamesPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.PictureBox dicePicture5;
        private System.Windows.Forms.PictureBox dicePicture4;
        private System.Windows.Forms.PictureBox dicePicture3;
        private System.Windows.Forms.PictureBox dicePicture1;
        private System.Windows.Forms.Button rollDiceButton;
        private System.Windows.Forms.Button stopDiceButton;
        private System.Windows.Forms.PictureBox dicePicture2;
        private System.Windows.Forms.Label Gamecard;
        private System.Windows.Forms.TableLayoutPanel gamecardUpperSection;
        private System.Windows.Forms.Label acesTitle;
        private System.Windows.Forms.Label twosTitle;
        private System.Windows.Forms.Label acesValueGame1;
        private System.Windows.Forms.Label acesValueGame2;
        private System.Windows.Forms.Label acesValueGame3;
        private System.Windows.Forms.Label acesValueGame4;
        private System.Windows.Forms.Label twosValueGame1;
        private System.Windows.Forms.Label twosValueGame2;
        private System.Windows.Forms.Label twosValueGame3;
        private System.Windows.Forms.Label twosValueGame4;
        private System.Windows.Forms.Label threesTitle;
        private System.Windows.Forms.Label foursTitle;
        private System.Windows.Forms.Label fivesTitle;
        private System.Windows.Forms.Label sixesTitle;
        private System.Windows.Forms.Label threesValueGame1;
        private System.Windows.Forms.Label threesValueGame2;
        private System.Windows.Forms.Label threesValueGame3;
        private System.Windows.Forms.Label threesValueGame4;
        private System.Windows.Forms.Label foursValueGame1;
        private System.Windows.Forms.Label foursValueGame2;
        private System.Windows.Forms.Label foursValueGame3;
        private System.Windows.Forms.Label foursValueGame4;
        private System.Windows.Forms.Label fivesValueGame1;
        private System.Windows.Forms.Label fivesValueGame2;
        private System.Windows.Forms.Label fivesValueGame3;
        private System.Windows.Forms.Label fivesValueGame4;
        private System.Windows.Forms.Label sixesValueGame1;
        private System.Windows.Forms.Label sixesValueGame2;
        private System.Windows.Forms.Label sixesValueGame3;
        private System.Windows.Forms.Label sixesValueGame4;
        private System.Windows.Forms.Label totalScoreTitle;
        private System.Windows.Forms.Label bonusTitle;
        private System.Windows.Forms.Label totalTitle;
        private System.Windows.Forms.Label totalScoreValueGame1;
        private System.Windows.Forms.Label totalScoreValueGame2;
        private System.Windows.Forms.Label totalScoreValueGame3;
        private System.Windows.Forms.Label totalScoreValueGame4;
        private System.Windows.Forms.Label bonusValueGame1;
        private System.Windows.Forms.Label bonusValueGame2;
        private System.Windows.Forms.Label bonusValueGame3;
        private System.Windows.Forms.Label bonusValueGame4;
        private System.Windows.Forms.Label totalValueGame1;
        private System.Windows.Forms.Label totalValueGame2;
        private System.Windows.Forms.Label totalValueGame3;
        private System.Windows.Forms.Label totalValueGame4;
        private System.Windows.Forms.Panel gameCardPanel;
        private System.Windows.Forms.TableLayoutPanel gamecardLowerSection;
        private System.Windows.Forms.Label threeOfKindTitle;
        private System.Windows.Forms.Label fourOfKindTitle;
        private System.Windows.Forms.Label threeOfKindValueGame1;
        private System.Windows.Forms.Label threeOfKindValueGame2;
        private System.Windows.Forms.Label threeOfKindValueGame3;
        private System.Windows.Forms.Label threeOfKindValueGame4;
        private System.Windows.Forms.Label fourOfKindValueGame1;
        private System.Windows.Forms.Label fourOfKindValueGame2;
        private System.Windows.Forms.Label fourOfKindValueGame3;
        private System.Windows.Forms.Label fourOfKindValueGame4;
        private System.Windows.Forms.Label fullHouseTitle;
        private System.Windows.Forms.Label acesDesc;
        private System.Windows.Forms.Label twosDesc;
        private System.Windows.Forms.Label threesDesc;
        private System.Windows.Forms.Label foursDesc;
        private System.Windows.Forms.Label fivesDesc;
        private System.Windows.Forms.Label sixesDesc;
        private System.Windows.Forms.Label totalScoreDesc;
        private System.Windows.Forms.Label bonusDesc;
        private System.Windows.Forms.Label totalDesc;
        private System.Windows.Forms.Label threeOfKindDesc;
        private System.Windows.Forms.Label fourOfKindDesc;
        private System.Windows.Forms.Label fullHouseDesc;
        private System.Windows.Forms.Label fullHouseValueGame1;
        private System.Windows.Forms.Label fullHouseValueGame2;
        private System.Windows.Forms.Label fullHouseValueGame3;
        private System.Windows.Forms.Label fullHouseValueGame4;
        private System.Windows.Forms.Label smallStreetTitle;
        private System.Windows.Forms.Label largeStreetTitle;
        private System.Windows.Forms.Label smallStreetDesc;
        private System.Windows.Forms.Label largeStreetDesc;
        private System.Windows.Forms.Label smallStreetValueGame1;
        private System.Windows.Forms.Label smallStreetValueGame2;
        private System.Windows.Forms.Label smallStreetValueGame3;
        private System.Windows.Forms.Label smallStreetValueGame4;
        private System.Windows.Forms.Label largeStreetValueGame1;
        private System.Windows.Forms.Label largeStreetValueGame2;
        private System.Windows.Forms.Label largeStreetValueGame3;
        private System.Windows.Forms.Label largeStreetValueGame4;
        private System.Windows.Forms.Label yahtzeeTitle;
        private System.Windows.Forms.Label yahtzeeValueGame1;
        private System.Windows.Forms.Label yahtzeeValueGame2;
        private System.Windows.Forms.Label yahtzeeValueGame3;
        private System.Windows.Forms.Label yahtzeeValueGame4;
        private System.Windows.Forms.Label yahtzeeDesc;
        private System.Windows.Forms.Label chanceTitle;
        private System.Windows.Forms.Label chanceValueGame1;
        private System.Windows.Forms.Label chanceValueGame2;
        private System.Windows.Forms.Label chanceValueGame3;
        private System.Windows.Forms.Label chanceValueGame4;
        private System.Windows.Forms.Label chanceDesc;
        private System.Windows.Forms.Label totalLowerTitle;
        private System.Windows.Forms.Label totalUpperTitle;
        private System.Windows.Forms.Label grandTotalTitle;
        private System.Windows.Forms.Label grandTotalDesc;
        private System.Windows.Forms.Label totalLowerDesc;
        private System.Windows.Forms.Label totalUpperDesc;
        private System.Windows.Forms.Label totalLowerValueGame1;
        private System.Windows.Forms.Label totalLowerValueGame2;
        private System.Windows.Forms.Label totalLowerValueGame3;
        private System.Windows.Forms.Label totalLowerValueGame4;
        private System.Windows.Forms.Label totalUpperValueGame1;
        private System.Windows.Forms.Label totalUpperValueGame2;
        private System.Windows.Forms.Label totalUpperValueGame3;
        private System.Windows.Forms.Label totalUpperValueGame4;
        private System.Windows.Forms.Label grandTotalValueGame1;
        private System.Windows.Forms.Label grandTotalValueGame2;
        private System.Windows.Forms.Label grandTotalValueGame3;
        private System.Windows.Forms.Label grandTotalValueGame4;
        private System.Windows.Forms.ComboBox resultChoiceSelect;
        private System.Windows.Forms.Button resultChoiceButton;
        private System.Windows.Forms.Label resultChoiceDesc;
        private System.Windows.Forms.ComboBox crossOutBoxSelect;
        private System.Windows.Forms.Button crossOutButton;
        private System.Windows.Forms.Label upperSectionTitle;
        private System.Windows.Forms.Label howToScoreLabel;
        private System.Windows.Forms.Label game1Label;
        private System.Windows.Forms.Label game2Label;
        private System.Windows.Forms.Label game3Label;
        private System.Windows.Forms.Label game4Label;
        private System.Windows.Forms.ComboBox resultChoiceGameSelect;
        private System.Windows.Forms.Label resultChoiceInLabel;
        private System.Windows.Forms.Panel actionPanel;
        private System.Windows.Forms.Panel dicePanel;
        private System.Windows.Forms.Label lowerSectionTitle;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label nbGamesLabel;
        private System.Windows.Forms.ComboBox nbGamesSelect;
        private System.Windows.Forms.Panel nbGamesPanel;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.PictureBox gameCardLoadPicture;
        private System.Windows.Forms.Button scoreButton;
    }
}


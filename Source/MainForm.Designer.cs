using MaterialSkin.Controls;

namespace eft_dma_radar
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components is not null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            colDialog = new ColorDialog();
            toolTip = new ToolTip(components);
            sldrZoomDistance = new MaterialSlider();
            sldrUIScale = new MaterialSlider();
            sldrAimlineLength = new MaterialSlider();
            swExfilNames = new MaterialSwitch();
            swQuestHelper = new MaterialSwitch();
            swHoverArmor = new MaterialSwitch();
            swNames = new MaterialSwitch();
            swAimview = new MaterialSwitch();
            swShowLoot = new MaterialSwitch();
            btnRestartRadar = new MaterialButton();
            btnToggleMap = new MaterialButton();
            swMapHelper = new MaterialSwitch();
            swMasterSwitch = new MaterialSwitch();
            swInfiniteStamina = new MaterialSwitch();
            sldrJumpStrength = new MaterialSlider();
            sldrThrowStrength = new MaterialSlider();
            sldrTimeOfDay = new MaterialSlider();
            swExtendedReach = new MaterialSwitch();
            swFreezeTime = new MaterialSwitch();
            swChams = new MaterialSwitch();
            swNightVision = new MaterialSwitch();
            swOpticalThermal = new MaterialSwitch();
            swThermalVision = new MaterialSwitch();
            sldrMagDrillsSpeed = new MaterialSlider();
            swNoVisor = new MaterialSwitch();
            swInstantADS = new MaterialSwitch();
            swNoRecoilSway = new MaterialSwitch();
            cboThermalColorScheme = new MaterialComboBox();
            cboThermalType = new MaterialComboBox();
            sldrMinCorpse = new MaterialSlider();
            sldrMinRegularLoot = new MaterialSlider();
            swCorpses = new MaterialSwitch();
            swFilteredOnly = new MaterialSwitch();
            swSubItems = new MaterialSwitch();
            swItemValue = new MaterialSwitch();
            swAutoRefresh = new MaterialSwitch();
            btnRefreshLoot = new MaterialButton();
            cboAutoRefreshMap = new MaterialComboBox();
            sldrAutoRefreshDelay = new MaterialSlider();
            sldrMinSubItems = new MaterialSlider();
            sldrMinImportantLoot = new MaterialSlider();
            btnAddFaction = new MaterialButton();
            btnRemoveFaction = new MaterialButton();
            btnAddFactionEntry = new MaterialButton();
            btnRemoveFactionEntry = new MaterialButton();
            txtTeammateID = new MaterialTextBox2();
            txtFactionEntryName = new MaterialTextBox2();
            txtFactionName = new MaterialTextBox2();
            cboFactionType = new MaterialComboBox();
            btnResetTheme = new MaterialButton();
            btnMapSetupApply = new MaterialButton();
            txtMapSetupScale = new MaterialTextBox2();
            txtMapSetupY = new MaterialTextBox2();
            txtMapSetupX = new MaterialTextBox2();
            btnToggleMapFree = new MaterialButton();
            btnRemoveWatchlistEntry = new MaterialButton();
            txtWatchlistAccountID = new MaterialTextBox2();
            txtWatchlistProfileName = new MaterialTextBox2();
            btnAddWatchlistEntry = new MaterialButton();
            btnAddWatchlistProfile = new MaterialButton();
            btnRemoveWatchlistProfile = new MaterialButton();
            txtWatchlistTag = new MaterialTextBox2();
            txtWatchlistPlatformUsername = new MaterialTextBox2();
            rdbYoutube = new MaterialRadioButton();
            rdbTwitch = new MaterialRadioButton();
            swWatchlistIsStreamer = new MaterialSwitch();
            btnResetPlayerlist = new MaterialButton();
            cboLootFilterItemsToAdd = new MaterialComboBox();
            txtLootFilterItemToSearch = new MaterialTextBox2();
            btnAddLootFilterItem = new MaterialButton();
            btnRemoveLootFilterItem = new MaterialButton();
            txtLootFilterName = new MaterialTextBox2();
            swLootFilterActive = new MaterialSwitch();
            btnAddFilter = new MaterialButton();
            btnRemoveFilter = new MaterialButton();
            swMaxEndurance = new MaterialSwitch();
            swMaxStrength = new MaterialSwitch();
            swMaxVitality = new MaterialSwitch();
            swMaxHealth = new MaterialSwitch();
            swMaxStressResistance = new MaterialSwitch();
            swMaxMetabolism = new MaterialSwitch();
            swMaxImmunity = new MaterialSwitch();
            swMaxPerception = new MaterialSwitch();
            swMaxIntellect = new MaterialSwitch();
            swMaxThrowables = new MaterialSwitch();
            swMaxSurgery = new MaterialSwitch();
            swMaxCovertMovement = new MaterialSwitch();
            swMaxSearch = new MaterialSwitch();
            swMaxMagDrills = new MaterialSwitch();
            swMaxLightVests = new MaterialSwitch();
            swMaxHeavyVests = new MaterialSwitch();
            swMaxAttention = new MaterialSwitch();
            swProcessLoot = new MaterialSwitch();
            swRadarStats = new MaterialSwitch();
            swRadarVsync = new MaterialSwitch();
            swRadarEnemyCount = new MaterialSwitch();
            sldrFontSize = new MaterialSlider();
            cboFont = new MaterialComboBox();
            swUnknownQuestItems = new MaterialSwitch();
            sldrThermalColorCoefficient = new MaterialSlider();
            sldrMinTemperature = new MaterialSlider();
            sldrThermalRampShift = new MaterialSlider();
            tabControlMain = new MaterialTabControl();
            tabRadar = new TabPage();
            mcRadarEnemyStats = new MaterialCard();
            lblRadarBossesValue = new MaterialLabel();
            lblRadarPlayerScavsValue = new MaterialLabel();
            lblRadarBosses = new MaterialLabel();
            lblRadarPlayerScavs = new MaterialLabel();
            lblRadarRoguesValue = new MaterialLabel();
            lblRadarAIScavsValue = new MaterialLabel();
            lblRadarPMCsValue = new MaterialLabel();
            lblRadarRogues = new MaterialLabel();
            lblRadarAIScavs = new MaterialLabel();
            lblRadarPMCs = new MaterialLabel();
            mcRadarStats = new MaterialCard();
            lblRadarCorpsesValue = new MaterialLabel();
            lblRadarCorpses = new MaterialLabel();
            lblRadarMemSValue = new MaterialLabel();
            lblRadarMemS = new MaterialLabel();
            lblRadarContainersValue = new MaterialLabel();
            lblRadarLooseLootValue = new MaterialLabel();
            lblRadarFPSValue = new MaterialLabel();
            lblRadarContainers = new MaterialLabel();
            lblRadarLooseLoot = new MaterialLabel();
            lblRadarFPS = new MaterialLabel();
            mcRadarSettings = new MaterialCard();
            mcRadarMapSetup = new MaterialCard();
            lblRadarMapSetup = new MaterialLabel();
            skMapCanvas = new SkiaSharp.Views.Desktop.SKGLControl();
            tabSettings = new TabPage();
            tabSelector = new MaterialTabSelector();
            tabControlSettings = new MaterialTabControl();
            tabSettingsGeneral = new TabPage();
            mcSettingsGeneralUI = new MaterialCard();
            lblSettingsGeneralUI = new MaterialLabel();
            mcSettingsGeneralRadar = new MaterialCard();
            lblSettingsGeneralRadar = new MaterialLabel();
            tabSettingsMemoryWriting = new TabPage();
            mcSettingsMemoryWritingSkillBuffs = new MaterialCard();
            lblSettingsMemoryWritingSkills = new MaterialLabel();
            mcSettingsMemoryWritingThermal = new MaterialCard();
            lblSettingsMemoryWritingThermal = new MaterialLabel();
            mcSettingsMemoryWritingGlobal = new MaterialCard();
            lblSettingsMemoryWritingGlobal = new MaterialLabel();
            mcSettingsMemoryWritingGear = new MaterialCard();
            lblSettingsMemoryWritingGear = new MaterialLabel();
            tabSettingsLoot = new TabPage();
            mcSettingsLootMinRubleValue = new MaterialCard();
            lblSettingsLootMinRubleValues = new MaterialLabel();
            mcSettingsLootGeneral = new MaterialCard();
            lblSettingsLootGeneral = new MaterialLabel();
            tabSettingsAIFactions = new TabPage();
            lstFactionEntries = new MaterialListView();
            colFactionsAIName = new ColumnHeader();
            mcSettingsAIFactionsEntryManagement = new MaterialCard();
            lblSettingsAIFactionsEntryManagement = new MaterialLabel();
            mcSettingsAIFactionsFactions = new MaterialCard();
            lstFactions = new MaterialListView();
            colFactionName = new ColumnHeader();
            lblSettingsAIFactionsFactions = new MaterialLabel();
            tabSettingsColors = new TabPage();
            mcSettingsColorsOther = new MaterialCard();
            picOtherAccent = new PictureBox();
            lblSettingsOtherAccent = new MaterialLabel();
            picOtherPrimaryLight = new PictureBox();
            lblSettingsOtherPrimaryLight = new MaterialLabel();
            picOtherPrimaryDark = new PictureBox();
            lblSettingsOtherPrimaryDark = new MaterialLabel();
            picOtherPrimary = new PictureBox();
            lblSettingsOtherPrimary = new MaterialLabel();
            picOtherChams = new PictureBox();
            lblSettingsOtherChams = new MaterialLabel();
            picOtherDeathMarker = new PictureBox();
            lblSettingsOtherDeathMarker = new MaterialLabel();
            picOtherTextOutline = new PictureBox();
            lblSettingsOtherTextOutline = new MaterialLabel();
            lblSettingsColorsOther = new MaterialLabel();
            mcSettingsColorsLootAndQuests = new MaterialCard();
            picQuestZone = new PictureBox();
            lblSettingsQuestZones = new MaterialLabel();
            picQuestItem = new PictureBox();
            lblSettingsQuestItems = new MaterialLabel();
            picLootImportant = new PictureBox();
            lblSettingsLootImportant = new MaterialLabel();
            picLootRegular = new PictureBox();
            lblSettingsLootRegular = new MaterialLabel();
            lblSettingsColorsLootQuests = new MaterialLabel();
            mcSettingsColorsExfiltration = new MaterialCard();
            picExfilClosedIcon = new PictureBox();
            lblSettingsColorsExfilClosedIcon = new MaterialLabel();
            picExfilClosedText = new PictureBox();
            lblSettingsColorsExfilClosedText = new MaterialLabel();
            picExfilPendingIcon = new PictureBox();
            lblSettingsColorsExfilPendingIcon = new MaterialLabel();
            picExfilPendingText = new PictureBox();
            lblSettingsColorsExfilPendingText = new MaterialLabel();
            picExfilActiveIcon = new PictureBox();
            lblSettingsColorsExfilActiveIcon = new MaterialLabel();
            picExfilActiveText = new PictureBox();
            lblSettingsColorsExfilActiveText = new MaterialLabel();
            lblSettingsColorsExfiltration = new MaterialLabel();
            mcSettingsColorsPlayers = new MaterialCard();
            picPlayersSpecial = new PictureBox();
            lblSettingsColorsPlayersSpecial = new MaterialLabel();
            picPlayersTeamHover = new PictureBox();
            lblSettingsColorsPlayersTeamHover = new MaterialLabel();
            picPlayersTeammate = new PictureBox();
            lblSettingsColorsPlayersTeammate = new MaterialLabel();
            picPlayersLocalPlayer = new PictureBox();
            lblSettingsColorsPlayersLocalPlayer = new MaterialLabel();
            picPlayersScav = new PictureBox();
            lblSettingsColorsPlayersScav = new MaterialLabel();
            picPlayersBEAR = new PictureBox();
            lblSettingsColorsPlayersBEAR = new MaterialLabel();
            picPlayersUSEC = new PictureBox();
            lblSettingsColorsPlayersUSEC = new MaterialLabel();
            lblSettingsColorsPlayers = new MaterialLabel();
            mcSettingsColorsAI = new MaterialCard();
            picAIOther = new PictureBox();
            lblSettingsColorsAIOther = new MaterialLabel();
            picAIScav = new PictureBox();
            lblSettingsColorsAIScav = new MaterialLabel();
            picAIFollowerOfMorana = new PictureBox();
            lblSettingsColorsAIMoranaFollower = new MaterialLabel();
            picAICultist = new PictureBox();
            lblSettingsColorsAICultists = new MaterialLabel();
            picAIRogue = new PictureBox();
            lblSettingsColorsAIRogues = new MaterialLabel();
            picAIRaider = new PictureBox();
            lblSettingsColorsAIRaiders = new MaterialLabel();
            picAIBossFollower = new PictureBox();
            lblSettingsColorsAIBossFollower = new MaterialLabel();
            picAIBossGuard = new PictureBox();
            lblSettingsColorsAIBossGuard = new MaterialLabel();
            picAIBoss = new PictureBox();
            lblSettingsColorsAIBoss = new MaterialLabel();
            lblSettingsColorsAI = new MaterialLabel();
            tabPlayerLoadouts = new TabPage();
            mcPlayerLoadoutsAI = new MaterialCard();
            lblPlayerLoadoutsAI = new MaterialLabel();
            flpPlayerLoadoutsAI = new FlowLayoutPanel();
            mcPlayerLoadoutsPlayers = new MaterialCard();
            lblPlayerLoadoutsPlayers = new MaterialLabel();
            flpPlayerLoadoutsPlayers = new FlowLayoutPanel();
            tabWatchlist = new TabPage();
            mcWatchlistPlayerlist = new MaterialCard();
            lstWatchlistPlayerList = new MaterialListView();
            colPlayerlistName = new ColumnHeader();
            lblWatchlistPlayerlist = new MaterialLabel();
            mcWatchlistProfiles = new MaterialCard();
            lstWatchlistProfiles = new MaterialListView();
            colWatchlistProfileName = new ColumnHeader();
            lblWatchlistProfiles = new MaterialLabel();
            mcWatchlistPlayerManagement = new MaterialCard();
            lblWatchlistPlayerManagement = new MaterialLabel();
            lstWatchlistEntries = new MaterialListView();
            colWatchlistAccID = new ColumnHeader();
            colWatchlistTag = new ColumnHeader();
            colWatchlistUsername = new ColumnHeader();
            tabLootFilter = new TabPage();
            mcLootFilterFilters = new MaterialCard();
            lstLootFilters = new MaterialListView();
            colLootFilterName = new ColumnHeader();
            lblSettingsLootFilters = new MaterialLabel();
            picLootFilterColor = new PictureBox();
            btnFilterPriorityUp = new MaterialButton();
            lblSettingsLootFilterColor = new MaterialLabel();
            btnFilterPriorityDown = new MaterialButton();
            mcLootFilterItemManagement = new MaterialCard();
            lblLootFilterItemManagement = new MaterialLabel();
            lstLootFilterEntries = new MaterialListView();
            colLootFilterItemName = new ColumnHeader();
            colLootFilterItemValue = new ColumnHeader();
            tabPageLootList = new TabPage();
            lootListListView = new MaterialListView();
            columnName1 = new ColumnHeader();
            columnValue1 = new ColumnHeader();
            iconList = new ImageList(components);
            materialLabel1 = new MaterialLabel();
            tabControlMain.SuspendLayout();
            tabRadar.SuspendLayout();
            mcRadarEnemyStats.SuspendLayout();
            mcRadarStats.SuspendLayout();
            mcRadarSettings.SuspendLayout();
            mcRadarMapSetup.SuspendLayout();
            tabSettings.SuspendLayout();
            tabControlSettings.SuspendLayout();
            tabSettingsGeneral.SuspendLayout();
            mcSettingsGeneralUI.SuspendLayout();
            mcSettingsGeneralRadar.SuspendLayout();
            tabSettingsMemoryWriting.SuspendLayout();
            mcSettingsMemoryWritingSkillBuffs.SuspendLayout();
            mcSettingsMemoryWritingThermal.SuspendLayout();
            mcSettingsMemoryWritingGlobal.SuspendLayout();
            mcSettingsMemoryWritingGear.SuspendLayout();
            tabSettingsLoot.SuspendLayout();
            mcSettingsLootMinRubleValue.SuspendLayout();
            mcSettingsLootGeneral.SuspendLayout();
            tabSettingsAIFactions.SuspendLayout();
            mcSettingsAIFactionsEntryManagement.SuspendLayout();
            mcSettingsAIFactionsFactions.SuspendLayout();
            tabSettingsColors.SuspendLayout();
            mcSettingsColorsOther.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picOtherAccent).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picOtherPrimaryLight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picOtherPrimaryDark).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picOtherPrimary).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picOtherChams).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picOtherDeathMarker).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picOtherTextOutline).BeginInit();
            mcSettingsColorsLootAndQuests.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picQuestZone).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picQuestItem).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picLootImportant).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picLootRegular).BeginInit();
            mcSettingsColorsExfiltration.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picExfilClosedIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picExfilClosedText).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picExfilPendingIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picExfilPendingText).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picExfilActiveIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picExfilActiveText).BeginInit();
            mcSettingsColorsPlayers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picPlayersSpecial).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picPlayersTeamHover).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picPlayersTeammate).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picPlayersLocalPlayer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picPlayersScav).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picPlayersBEAR).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picPlayersUSEC).BeginInit();
            mcSettingsColorsAI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picAIOther).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picAIScav).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picAIFollowerOfMorana).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picAICultist).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picAIRogue).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picAIRaider).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picAIBossFollower).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picAIBossGuard).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picAIBoss).BeginInit();
            tabPlayerLoadouts.SuspendLayout();
            mcPlayerLoadoutsAI.SuspendLayout();
            mcPlayerLoadoutsPlayers.SuspendLayout();
            tabWatchlist.SuspendLayout();
            mcWatchlistPlayerlist.SuspendLayout();
            mcWatchlistProfiles.SuspendLayout();
            mcWatchlistPlayerManagement.SuspendLayout();
            tabLootFilter.SuspendLayout();
            mcLootFilterFilters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLootFilterColor).BeginInit();
            mcLootFilterItemManagement.SuspendLayout();
            tabPageLootList.SuspendLayout();
            SuspendLayout();
            // 
            // colDialog
            // 
            colDialog.FullOpen = true;
            // 
            // sldrZoomDistance
            // 
            sldrZoomDistance.Depth = 0;
            sldrZoomDistance.ForeColor = Color.Black;
            sldrZoomDistance.Location = new Point(17, 187);
            sldrZoomDistance.MouseState = MaterialSkin.MouseState.HOVER;
            sldrZoomDistance.Name = "sldrZoomDistance";
            sldrZoomDistance.RangeMax = 200;
            sldrZoomDistance.RangeMin = 10;
            sldrZoomDistance.Size = new Size(351, 40);
            sldrZoomDistance.TabIndex = 32;
            sldrZoomDistance.Text = "缩放距离";
            toolTip.SetToolTip(sldrZoomDistance, "The map zoom distance (also controlled with mouse scrolling)");
            sldrZoomDistance.UseAccentColor = true;
            sldrZoomDistance.Value = 100;
            sldrZoomDistance.ValueMax = 200;
            sldrZoomDistance.ValueSuffix = "%";
            sldrZoomDistance.onValueChanged += sldrZoomDistance_onValueChanged;
            // 
            // sldrUIScale
            // 
            sldrUIScale.Depth = 0;
            sldrUIScale.ForeColor = Color.Black;
            sldrUIScale.Location = new Point(439, 142);
            sldrUIScale.MouseState = MaterialSkin.MouseState.HOVER;
            sldrUIScale.Name = "sldrUIScale";
            sldrUIScale.RangeMax = 200;
            sldrUIScale.RangeMin = 10;
            sldrUIScale.Size = new Size(275, 40);
            sldrUIScale.TabIndex = 31;
            sldrUIScale.Text = "UI 比例";
            toolTip.SetToolTip(sldrUIScale, "Scales the UI fonts etc, useful for larger screen resolutions");
            sldrUIScale.UseAccentColor = true;
            sldrUIScale.Value = 100;
            sldrUIScale.ValueMax = 200;
            sldrUIScale.ValueSuffix = "%";
            sldrUIScale.onValueChanged += sldrUIScale_onValueChanged;
            // 
            // sldrAimlineLength
            // 
            sldrAimlineLength.Depth = 0;
            sldrAimlineLength.ForeColor = Color.Black;
            sldrAimlineLength.Location = new Point(17, 142);
            sldrAimlineLength.MouseState = MaterialSkin.MouseState.HOVER;
            sldrAimlineLength.Name = "sldrAimlineLength";
            sldrAimlineLength.RangeMax = 1000;
            sldrAimlineLength.RangeMin = 10;
            sldrAimlineLength.Size = new Size(347, 40);
            sldrAimlineLength.TabIndex = 30;
            sldrAimlineLength.Text = "瞄准线长度";
            toolTip.SetToolTip(sldrAimlineLength, "Length of the 'bar' or 'aim line' on the localplayer");
            sldrAimlineLength.UseAccentColor = true;
            sldrAimlineLength.Value = 500;
            sldrAimlineLength.ValueMax = 1000;
            sldrAimlineLength.ValueSuffix = "m";
            // 
            // swExfilNames
            // 
            swExfilNames.Depth = 0;
            swExfilNames.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            swExfilNames.Location = new Point(17, 96);
            swExfilNames.Margin = new Padding(0);
            swExfilNames.MouseLocation = new Point(-1, -1);
            swExfilNames.MouseState = MaterialSkin.MouseState.HOVER;
            swExfilNames.Name = "swExfilNames";
            swExfilNames.Ripple = true;
            swExfilNames.Size = new Size(167, 31);
            swExfilNames.TabIndex = 6;
            swExfilNames.Text = "文本轮廓";
            toolTip.SetToolTip(swExfilNames, "Shows exfiltration point names on radar");
            swExfilNames.UseVisualStyleBackColor = true;
            swExfilNames.CheckedChanged += swExfilNames_CheckedChanged;
            // 
            // swQuestHelper
            // 
            swQuestHelper.Depth = 0;
            swQuestHelper.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            swQuestHelper.Location = new Point(197, 106);
            swQuestHelper.Margin = new Padding(0);
            swQuestHelper.MouseLocation = new Point(-1, -1);
            swQuestHelper.MouseState = MaterialSkin.MouseState.HOVER;
            swQuestHelper.Name = "swQuestHelper";
            swQuestHelper.Ripple = true;
            swQuestHelper.Size = new Size(174, 31);
            swQuestHelper.TabIndex = 5;
            swQuestHelper.Text = "显示撤离点";
            toolTip.SetToolTip(swQuestHelper, "Displays all active quest tasks/items on the map. Must use 'Show Loot' to display quest items.");
            swQuestHelper.UseVisualStyleBackColor = true;
            swQuestHelper.CheckedChanged += swQuestHelper_CheckedChanged;
            // 
            // swHoverArmor
            // 
            swHoverArmor.Depth = 0;
            swHoverArmor.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            swHoverArmor.Location = new Point(197, 51);
            swHoverArmor.Margin = new Padding(0);
            swHoverArmor.MouseLocation = new Point(-1, -1);
            swHoverArmor.MouseState = MaterialSkin.MouseState.HOVER;
            swHoverArmor.Name = "swHoverArmor";
            swHoverArmor.Ripple = true;
            swHoverArmor.Size = new Size(174, 31);
            swHoverArmor.TabIndex = 4;
            swHoverArmor.Text = "悬停显示";
            toolTip.SetToolTip(swHoverArmor, "Show current gear pieces when hovering over a player");
            swHoverArmor.UseVisualStyleBackColor = true;
            swHoverArmor.CheckedChanged += swHoverArmor_CheckedChanged;
            // 
            // swNames
            // 
            swNames.Depth = 0;
            swNames.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            swNames.Location = new Point(555, 50);
            swNames.Margin = new Padding(0);
            swNames.MouseLocation = new Point(-1, -1);
            swNames.MouseState = MaterialSkin.MouseState.HOVER;
            swNames.Name = "swNames";
            swNames.Ripple = true;
            swNames.Size = new Size(160, 31);
            swNames.TabIndex = 3;
            swNames.Text = "显示玩家ID(F6)";
            toolTip.SetToolTip(swNames, "Shows player names on the radar");
            swNames.UseVisualStyleBackColor = true;
            swNames.CheckedChanged += swNames_CheckedChanged;
            // 
            // swAimview
            // 
            swAimview.Depth = 0;
            swAimview.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            swAimview.Location = new Point(374, 50);
            swAimview.Margin = new Padding(0);
            swAimview.MouseLocation = new Point(-1, -1);
            swAimview.MouseState = MaterialSkin.MouseState.HOVER;
            swAimview.Name = "swAimview";
            swAimview.Ripple = true;
            swAimview.Size = new Size(182, 31);
            swAimview.TabIndex = 2;
            swAimview.Text = "三维目标 (F4)";
            toolTip.SetToolTip(swAimview, "Displays the 3D aimview");
            swAimview.UseVisualStyleBackColor = true;
            swAimview.CheckedChanged += swAimview_CheckedChanged;
            // 
            // swShowLoot
            // 
            swShowLoot.Depth = 0;
            swShowLoot.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            swShowLoot.Location = new Point(17, 51);
            swShowLoot.Margin = new Padding(0);
            swShowLoot.MouseLocation = new Point(-1, -1);
            swShowLoot.MouseState = MaterialSkin.MouseState.HOVER;
            swShowLoot.Name = "swShowLoot";
            swShowLoot.Ripple = true;
            swShowLoot.Size = new Size(152, 31);
            swShowLoot.TabIndex = 1;
            swShowLoot.Text = "物资 (F3)";
            toolTip.SetToolTip(swShowLoot, "Displays loose loot & lootable items on corpses/cointainers");
            swShowLoot.UseVisualStyleBackColor = true;
            swShowLoot.CheckedChanged += swShowLoot_CheckedChanged;
            // 
            // btnRestartRadar
            // 
            btnRestartRadar.AutoSize = false;
            btnRestartRadar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnRestartRadar.Density = MaterialButton.MaterialButtonDensity.Default;
            btnRestartRadar.Depth = 0;
            btnRestartRadar.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            btnRestartRadar.HighEmphasis = true;
            btnRestartRadar.Icon = null;
            btnRestartRadar.Location = new Point(502, 41);
            btnRestartRadar.Margin = new Padding(5, 7, 5, 7);
            btnRestartRadar.MouseState = MaterialSkin.MouseState.HOVER;
            btnRestartRadar.Name = "btnRestartRadar";
            btnRestartRadar.NoAccentTextColor = Color.Empty;
            btnRestartRadar.Size = new Size(163, 41);
            btnRestartRadar.TabIndex = 2;
            btnRestartRadar.Text = "重启雷达";
            toolTip.SetToolTip(btnRestartRadar, "Manually triggers radar restart");
            btnRestartRadar.Type = MaterialButton.MaterialButtonType.Contained;
            btnRestartRadar.UseAccentColor = true;
            btnRestartRadar.UseVisualStyleBackColor = true;
            btnRestartRadar.Click += btnRestartRadar_Click;
            // 
            // btnToggleMap
            // 
            btnToggleMap.AutoSize = false;
            btnToggleMap.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnToggleMap.Density = MaterialButton.MaterialButtonDensity.Default;
            btnToggleMap.Depth = 0;
            btnToggleMap.HighEmphasis = true;
            btnToggleMap.Icon = null;
            btnToggleMap.Location = new Point(502, 96);
            btnToggleMap.Margin = new Padding(5, 7, 5, 7);
            btnToggleMap.MouseState = MaterialSkin.MouseState.HOVER;
            btnToggleMap.Name = "btnToggleMap";
            btnToggleMap.NoAccentTextColor = Color.Empty;
            btnToggleMap.Size = new Size(163, 41);
            btnToggleMap.TabIndex = 1;
            btnToggleMap.Text = "切换Map (F5)";
            toolTip.SetToolTip(btnToggleMap, "Manually toggles active map");
            btnToggleMap.Type = MaterialButton.MaterialButtonType.Contained;
            btnToggleMap.UseAccentColor = true;
            btnToggleMap.UseVisualStyleBackColor = true;
            btnToggleMap.Click += btnToggleMap_Click;
            // 
            // swMapHelper
            // 
            swMapHelper.Depth = 0;
            swMapHelper.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            swMapHelper.Location = new Point(17, 51);
            swMapHelper.Margin = new Padding(0);
            swMapHelper.MouseLocation = new Point(-1, -1);
            swMapHelper.MouseState = MaterialSkin.MouseState.HOVER;
            swMapHelper.Name = "swMapHelper";
            swMapHelper.Ripple = true;
            swMapHelper.Size = new Size(167, 31);
            swMapHelper.TabIndex = 0;
            swMapHelper.Text = "地图帮助";
            toolTip.SetToolTip(swMapHelper, "Shows the 'Map Setup' panel");
            swMapHelper.UseVisualStyleBackColor = true;
            swMapHelper.CheckedChanged += swMapHelper_CheckedChanged;
            // 
            // swMasterSwitch
            // 
            swMasterSwitch.Depth = 0;
            swMasterSwitch.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            swMasterSwitch.Location = new Point(17, 16);
            swMasterSwitch.Margin = new Padding(0);
            swMasterSwitch.MouseLocation = new Point(-1, -1);
            swMasterSwitch.MouseState = MaterialSkin.MouseState.HOVER;
            swMasterSwitch.Name = "swMasterSwitch";
            swMasterSwitch.Ripple = true;
            swMasterSwitch.Size = new Size(182, 31);
            swMasterSwitch.TabIndex = 36;
            swMasterSwitch.Text = "内存总开关";
            toolTip.SetToolTip(swMasterSwitch, "Shows exfiltration point names on radar");
            swMasterSwitch.UseVisualStyleBackColor = true;
            swMasterSwitch.CheckedChanged += swMasterSwitch_CheckedChanged;
            // 
            // swInfiniteStamina
            // 
            swInfiniteStamina.Depth = 0;
            swInfiniteStamina.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            swInfiniteStamina.Location = new Point(157, 51);
            swInfiniteStamina.Margin = new Padding(0);
            swInfiniteStamina.MouseLocation = new Point(-1, -1);
            swInfiniteStamina.MouseState = MaterialSkin.MouseState.HOVER;
            swInfiniteStamina.Name = "swInfiniteStamina";
            swInfiniteStamina.Ripple = true;
            swInfiniteStamina.Size = new Size(203, 31);
            swInfiniteStamina.TabIndex = 38;
            swInfiniteStamina.Text = "无限耐力";
            toolTip.SetToolTip(swInfiniteStamina, "Allows you to run forever");
            swInfiniteStamina.UseVisualStyleBackColor = true;
            swInfiniteStamina.CheckedChanged += swInfiniteStamina_CheckedChanged;
            // 
            // sldrJumpStrength
            // 
            sldrJumpStrength.Depth = 0;
            sldrJumpStrength.ForeColor = Color.Black;
            sldrJumpStrength.Location = new Point(17, 357);
            sldrJumpStrength.MouseState = MaterialSkin.MouseState.HOVER;
            sldrJumpStrength.Name = "sldrJumpStrength";
            sldrJumpStrength.RangeMax = 5;
            sldrJumpStrength.Size = new Size(263, 40);
            sldrJumpStrength.TabIndex = 35;
            sldrJumpStrength.Text = "高跳";
            toolTip.SetToolTip(sldrJumpStrength, "The 'strength' of jumping");
            sldrJumpStrength.UseAccentColor = true;
            sldrJumpStrength.Value = 0;
            sldrJumpStrength.ValueMax = 5;
            sldrJumpStrength.Visible = false;
            sldrJumpStrength.onValueChanged += sldrJumpStrength_onValueChanged;
            // 
            // sldrThrowStrength
            // 
            sldrThrowStrength.Depth = 0;
            sldrThrowStrength.ForeColor = Color.Black;
            sldrThrowStrength.Location = new Point(329, 317);
            sldrThrowStrength.MouseState = MaterialSkin.MouseState.HOVER;
            sldrThrowStrength.Name = "sldrThrowStrength";
            sldrThrowStrength.RangeMin = 1;
            sldrThrowStrength.Size = new Size(263, 40);
            sldrThrowStrength.TabIndex = 30;
            sldrThrowStrength.Text = "投掷力量";
            toolTip.SetToolTip(sldrThrowStrength, "The 'strength' of the throwing grenades");
            sldrThrowStrength.UseAccentColor = true;
            sldrThrowStrength.ValueMax = 100;
            sldrThrowStrength.ValueSuffix = "%";
            sldrThrowStrength.Visible = false;
            sldrThrowStrength.onValueChanged += sldrThrowStrength_onValueChanged;
            // 
            // sldrTimeOfDay
            // 
            sldrTimeOfDay.Depth = 0;
            sldrTimeOfDay.ForeColor = Color.Black;
            sldrTimeOfDay.Location = new Point(197, 91);
            sldrTimeOfDay.MouseState = MaterialSkin.MouseState.HOVER;
            sldrTimeOfDay.Name = "sldrTimeOfDay";
            sldrTimeOfDay.RangeMax = 24;
            sldrTimeOfDay.RangeMin = 1;
            sldrTimeOfDay.Size = new Size(272, 40);
            sldrTimeOfDay.TabIndex = 30;
            sldrTimeOfDay.Text = "时间切换";
            toolTip.SetToolTip(sldrTimeOfDay, "The time of the in-game day to set");
            sldrTimeOfDay.UseAccentColor = true;
            sldrTimeOfDay.Value = 12;
            sldrTimeOfDay.ValueMax = 24;
            sldrTimeOfDay.Visible = false;
            sldrTimeOfDay.onValueChanged += sldrTimeOfDay_onValueChanged;
            // 
            // swExtendedReach
            // 
            swExtendedReach.Depth = 0;
            swExtendedReach.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            swExtendedReach.Location = new Point(381, 51);
            swExtendedReach.Margin = new Padding(0);
            swExtendedReach.MouseLocation = new Point(-1, -1);
            swExtendedReach.MouseState = MaterialSkin.MouseState.HOVER;
            swExtendedReach.Name = "swExtendedReach";
            swExtendedReach.Ripple = true;
            swExtendedReach.Size = new Size(200, 31);
            swExtendedReach.TabIndex = 7;
            swExtendedReach.Text = "隔空取物";
            toolTip.SetToolTip(swExtendedReach, "Increases maximum loot/door interaction distance");
            swExtendedReach.UseVisualStyleBackColor = true;
            swExtendedReach.CheckedChanged += swExtendedReach_CheckedChanged;
            // 
            // swFreezeTime
            // 
            swFreezeTime.Depth = 0;
            swFreezeTime.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            swFreezeTime.Location = new Point(17, 96);
            swFreezeTime.Margin = new Padding(0);
            swFreezeTime.MouseLocation = new Point(-1, -1);
            swFreezeTime.MouseState = MaterialSkin.MouseState.HOVER;
            swFreezeTime.Name = "swFreezeTime";
            swFreezeTime.Ripple = true;
            swFreezeTime.Size = new Size(174, 31);
            swFreezeTime.TabIndex = 5;
            swFreezeTime.Text = "冻结时间";
            toolTip.SetToolTip(swFreezeTime, "Freeze the in-game time of the day");
            swFreezeTime.UseVisualStyleBackColor = true;
            swFreezeTime.CheckedChanged += swFreezeTime_CheckedChanged;
            // 
            // swChams
            // 
            swChams.Depth = 0;
            swChams.Enabled = false;
            swChams.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            swChams.Location = new Point(17, 51);
            swChams.Margin = new Padding(0);
            swChams.MouseLocation = new Point(-1, -1);
            swChams.MouseState = MaterialSkin.MouseState.HOVER;
            swChams.Name = "swChams";
            swChams.Ripple = true;
            swChams.Size = new Size(130, 31);
            swChams.TabIndex = 1;
            swChams.Text = "Chams";
            toolTip.SetToolTip(swChams, "Displays loose loot & lootable items on corpses/cointainers");
            swChams.UseVisualStyleBackColor = true;
            swChams.CheckedChanged += swChams_CheckedChanged;
            // 
            // swNightVision
            // 
            swNightVision.Depth = 0;
            swNightVision.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            swNightVision.Location = new Point(435, 96);
            swNightVision.Margin = new Padding(0);
            swNightVision.MouseLocation = new Point(-1, -1);
            swNightVision.MouseState = MaterialSkin.MouseState.HOVER;
            swNightVision.Name = "swNightVision";
            swNightVision.Ripple = true;
            swNightVision.Size = new Size(166, 31);
            swNightVision.TabIndex = 36;
            swNightVision.Text = "夜视";
            toolTip.SetToolTip(swNightVision, "Enables 'bug eye' night vision");
            swNightVision.UseVisualStyleBackColor = true;
            swNightVision.CheckedChanged += swNightVision_CheckedChanged;
            // 
            // swOpticalThermal
            // 
            swOpticalThermal.Depth = 0;
            swOpticalThermal.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            swOpticalThermal.Location = new Point(222, 96);
            swOpticalThermal.Margin = new Padding(0);
            swOpticalThermal.MouseLocation = new Point(-1, -1);
            swOpticalThermal.MouseState = MaterialSkin.MouseState.HOVER;
            swOpticalThermal.Name = "swOpticalThermal";
            swOpticalThermal.Ripple = true;
            swOpticalThermal.Size = new Size(202, 31);
            swOpticalThermal.TabIndex = 35;
            swOpticalThermal.Text = "热能";
            toolTip.SetToolTip(swOpticalThermal, "Turns optics into thermals");
            swOpticalThermal.UseVisualStyleBackColor = true;
            swOpticalThermal.CheckedChanged += swOpticalThermal_CheckedChanged;
            // 
            // swThermalVision
            // 
            swThermalVision.Depth = 0;
            swThermalVision.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            swThermalVision.Location = new Point(16, 96);
            swThermalVision.Margin = new Padding(0);
            swThermalVision.MouseLocation = new Point(-1, -1);
            swThermalVision.MouseState = MaterialSkin.MouseState.HOVER;
            swThermalVision.Name = "swThermalVision";
            swThermalVision.Ripple = true;
            swThermalVision.Size = new Size(202, 31);
            swThermalVision.TabIndex = 34;
            swThermalVision.Text = "热成像";
            toolTip.SetToolTip(swThermalVision, "Enables T-7 thermal vision");
            swThermalVision.UseVisualStyleBackColor = true;
            swThermalVision.CheckedChanged += swThermalVision_CheckedChanged;
            // 
            // sldrMagDrillsSpeed
            // 
            sldrMagDrillsSpeed.Depth = 0;
            sldrMagDrillsSpeed.ForeColor = Color.Black;
            sldrMagDrillsSpeed.Location = new Point(17, 317);
            sldrMagDrillsSpeed.MouseState = MaterialSkin.MouseState.HOVER;
            sldrMagDrillsSpeed.Name = "sldrMagDrillsSpeed";
            sldrMagDrillsSpeed.RangeMax = 70;
            sldrMagDrillsSpeed.RangeMin = 1;
            sldrMagDrillsSpeed.Size = new Size(263, 40);
            sldrMagDrillsSpeed.TabIndex = 30;
            sldrMagDrillsSpeed.Text = "加速上弹";
            toolTip.SetToolTip(sldrMagDrillsSpeed, "Speed of un/packing ammunition from a magazine");
            sldrMagDrillsSpeed.UseAccentColor = true;
            sldrMagDrillsSpeed.Value = 30;
            sldrMagDrillsSpeed.ValueMax = 70;
            sldrMagDrillsSpeed.Visible = false;
            sldrMagDrillsSpeed.onValueChanged += sldrMagDrillsSpeed_onValueChanged;
            // 
            // swNoVisor
            // 
            swNoVisor.Depth = 0;
            swNoVisor.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            swNoVisor.Location = new Point(435, 51);
            swNoVisor.Margin = new Padding(0);
            swNoVisor.MouseLocation = new Point(-1, -1);
            swNoVisor.MouseState = MaterialSkin.MouseState.HOVER;
            swNoVisor.Name = "swNoVisor";
            swNoVisor.Ripple = true;
            swNoVisor.Size = new Size(145, 31);
            swNoVisor.TabIndex = 7;
            swNoVisor.Text = "移除面具";
            toolTip.SetToolTip(swNoVisor, "Removes visual visor effect");
            swNoVisor.UseVisualStyleBackColor = true;
            swNoVisor.CheckedChanged += swNoVisor_CheckedChanged;
            // 
            // swInstantADS
            // 
            swInstantADS.Depth = 0;
            swInstantADS.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            swInstantADS.Location = new Point(222, 51);
            swInstantADS.Margin = new Padding(0);
            swInstantADS.MouseLocation = new Point(-1, -1);
            swInstantADS.MouseState = MaterialSkin.MouseState.HOVER;
            swInstantADS.Name = "swInstantADS";
            swInstantADS.Ripple = true;
            swInstantADS.Size = new Size(173, 31);
            swInstantADS.TabIndex = 2;
            swInstantADS.Text = "上弹加速";
            toolTip.SetToolTip(swInstantADS, "Increases ADS speed to be near instantaneous");
            swInstantADS.UseVisualStyleBackColor = true;
            swInstantADS.CheckedChanged += swInstantADS_CheckedChanged;
            // 
            // swNoRecoilSway
            // 
            swNoRecoilSway.Depth = 0;
            swNoRecoilSway.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            swNoRecoilSway.Location = new Point(17, 51);
            swNoRecoilSway.Margin = new Padding(0);
            swNoRecoilSway.MouseLocation = new Point(-1, -1);
            swNoRecoilSway.MouseState = MaterialSkin.MouseState.HOVER;
            swNoRecoilSway.Name = "swNoRecoilSway";
            swNoRecoilSway.Ripple = true;
            swNoRecoilSway.Size = new Size(202, 31);
            swNoRecoilSway.TabIndex = 1;
            swNoRecoilSway.Text = "无反冲/摆动";
            toolTip.SetToolTip(swNoRecoilSway, "Removes weapon recoil & sway");
            swNoRecoilSway.UseVisualStyleBackColor = true;
            swNoRecoilSway.CheckedChanged += swNoRecoilSway_CheckedChanged;
            // 
            // cboThermalColorScheme
            // 
            cboThermalColorScheme.AutoResize = false;
            cboThermalColorScheme.BackColor = Color.FromArgb(255, 255, 255);
            cboThermalColorScheme.Depth = 0;
            cboThermalColorScheme.DrawMode = DrawMode.OwnerDrawVariable;
            cboThermalColorScheme.DropDownHeight = 118;
            cboThermalColorScheme.DropDownStyle = ComboBoxStyle.DropDownList;
            cboThermalColorScheme.DropDownWidth = 121;
            cboThermalColorScheme.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboThermalColorScheme.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboThermalColorScheme.FormattingEnabled = true;
            cboThermalColorScheme.Hint = "Color Scheme";
            cboThermalColorScheme.IntegralHeight = false;
            cboThermalColorScheme.ItemHeight = 29;
            cboThermalColorScheme.Items.AddRange(new object[] { "Fusion", "Rainbow", "White Hot", "Black Hot" });
            cboThermalColorScheme.Location = new Point(17, 96);
            cboThermalColorScheme.MaxDropDownItems = 4;
            cboThermalColorScheme.MouseState = MaterialSkin.MouseState.OUT;
            cboThermalColorScheme.Name = "cboThermalColorScheme";
            cboThermalColorScheme.Size = new Size(195, 35);
            cboThermalColorScheme.StartIndex = 0;
            cboThermalColorScheme.TabIndex = 38;
            toolTip.SetToolTip(cboThermalColorScheme, "The color scheme/preset to edit");
            cboThermalColorScheme.UseTallSize = false;
            cboThermalColorScheme.SelectedIndexChanged += cboThermalColorScheme_SelectedIndexChanged_1;
            // 
            // cboThermalType
            // 
            cboThermalType.AutoResize = false;
            cboThermalType.BackColor = Color.FromArgb(255, 255, 255);
            cboThermalType.Depth = 0;
            cboThermalType.DrawMode = DrawMode.OwnerDrawVariable;
            cboThermalType.DropDownHeight = 118;
            cboThermalType.DropDownStyle = ComboBoxStyle.DropDownList;
            cboThermalType.DropDownWidth = 121;
            cboThermalType.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboThermalType.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboThermalType.FormattingEnabled = true;
            cboThermalType.Hint = "Type";
            cboThermalType.IntegralHeight = false;
            cboThermalType.ItemHeight = 29;
            cboThermalType.Items.AddRange(new object[] { "Main", "Optic" });
            cboThermalType.Location = new Point(17, 51);
            cboThermalType.MaxDropDownItems = 4;
            cboThermalType.MouseState = MaterialSkin.MouseState.OUT;
            cboThermalType.Name = "cboThermalType";
            cboThermalType.Size = new Size(195, 35);
            cboThermalType.StartIndex = 0;
            cboThermalType.TabIndex = 37;
            toolTip.SetToolTip(cboThermalType, "The type of thermal to edit");
            cboThermalType.UseTallSize = false;
            cboThermalType.SelectedIndexChanged += cboThermalType_SelectedIndexChanged_1;
            // 
            // sldrMinCorpse
            // 
            sldrMinCorpse.Depth = 0;
            sldrMinCorpse.ForeColor = Color.Black;
            sldrMinCorpse.Location = new Point(390, 45);
            sldrMinCorpse.MouseState = MaterialSkin.MouseState.HOVER;
            sldrMinCorpse.Name = "sldrMinCorpse";
            sldrMinCorpse.RangeMax = 800;
            sldrMinCorpse.RangeMin = 10;
            sldrMinCorpse.Size = new Size(275, 40);
            sldrMinCorpse.TabIndex = 31;
            sldrMinCorpse.Text = "尸体";
            toolTip.SetToolTip(sldrMinCorpse, "The minimum value for a corpse to be shown");
            sldrMinCorpse.UseAccentColor = true;
            sldrMinCorpse.Value = 200;
            sldrMinCorpse.ValueMax = 800;
            sldrMinCorpse.ValueSuffix = "k";
            sldrMinCorpse.onValueChanged += sldrMinCorpse_onValueChanged;
            // 
            // sldrMinRegularLoot
            // 
            sldrMinRegularLoot.Depth = 0;
            sldrMinRegularLoot.ForeColor = Color.Black;
            sldrMinRegularLoot.Location = new Point(17, 45);
            sldrMinRegularLoot.MouseState = MaterialSkin.MouseState.HOVER;
            sldrMinRegularLoot.Name = "sldrMinRegularLoot";
            sldrMinRegularLoot.RangeMax = 249;
            sldrMinRegularLoot.RangeMin = 10;
            sldrMinRegularLoot.Size = new Size(347, 40);
            sldrMinRegularLoot.TabIndex = 30;
            sldrMinRegularLoot.Text = "普通物资";
            toolTip.SetToolTip(sldrMinRegularLoot, "The minimum value for loot to be displayed");
            sldrMinRegularLoot.UseAccentColor = true;
            sldrMinRegularLoot.Value = 85;
            sldrMinRegularLoot.ValueMax = 249;
            sldrMinRegularLoot.ValueSuffix = "k";
            sldrMinRegularLoot.onValueChanged += sldrMinRegularLoot_onValueChanged;
            // 
            // swCorpses
            // 
            swCorpses.Depth = 0;
            swCorpses.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            swCorpses.Location = new Point(17, 96);
            swCorpses.Margin = new Padding(0);
            swCorpses.MouseLocation = new Point(-1, -1);
            swCorpses.MouseState = MaterialSkin.MouseState.HOVER;
            swCorpses.Name = "swCorpses";
            swCorpses.Ripple = true;
            swCorpses.Size = new Size(143, 31);
            swCorpses.TabIndex = 0;
            swCorpses.Text = "尸体";
            toolTip.SetToolTip(swCorpses, "Shows player/scav/boss etc corpses");
            swCorpses.UseVisualStyleBackColor = true;
            swCorpses.CheckedChanged += swCorpses_CheckedChanged;
            // 
            // swFilteredOnly
            // 
            swFilteredOnly.Depth = 0;
            swFilteredOnly.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            swFilteredOnly.Location = new Point(202, 51);
            swFilteredOnly.Margin = new Padding(0);
            swFilteredOnly.MouseLocation = new Point(-1, -1);
            swFilteredOnly.MouseState = MaterialSkin.MouseState.HOVER;
            swFilteredOnly.Name = "swFilteredOnly";
            swFilteredOnly.Ripple = true;
            swFilteredOnly.Size = new Size(175, 31);
            swFilteredOnly.TabIndex = 31;
            swFilteredOnly.Text = "显示筛选物品";
            toolTip.SetToolTip(swFilteredOnly, "Only shows items considered 'important' or ones in a filter");
            swFilteredOnly.UseVisualStyleBackColor = true;
            swFilteredOnly.CheckedChanged += swFilteredOnly_CheckedChanged;
            // 
            // swSubItems
            // 
            swSubItems.Depth = 0;
            swSubItems.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            swSubItems.Location = new Point(410, 96);
            swSubItems.Margin = new Padding(0);
            swSubItems.MouseLocation = new Point(-1, -1);
            swSubItems.MouseState = MaterialSkin.MouseState.HOVER;
            swSubItems.Name = "swSubItems";
            swSubItems.Ripple = true;
            swSubItems.Size = new Size(152, 31);
            swSubItems.TabIndex = 32;
            swSubItems.Text = "显示子物资";
            toolTip.SetToolTip(swSubItems, "Shows sub-items within a container/corpse");
            swSubItems.UseVisualStyleBackColor = true;
            swSubItems.CheckedChanged += swSubItems_CheckedChanged;
            // 
            // swItemValue
            // 
            swItemValue.Depth = 0;
            swItemValue.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            swItemValue.Location = new Point(202, 96);
            swItemValue.Margin = new Padding(0);
            swItemValue.MouseLocation = new Point(-1, -1);
            swItemValue.MouseState = MaterialSkin.MouseState.HOVER;
            swItemValue.Name = "swItemValue";
            swItemValue.Ripple = true;
            swItemValue.Size = new Size(170, 31);
            swItemValue.TabIndex = 33;
            swItemValue.Text = "项目";
            toolTip.SetToolTip(swItemValue, "Shows item value");
            swItemValue.UseVisualStyleBackColor = true;
            swItemValue.CheckedChanged += swItemValue_CheckedChanged;
            // 
            // swAutoRefresh
            // 
            swAutoRefresh.Depth = 0;
            swAutoRefresh.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            swAutoRefresh.Location = new Point(17, 143);
            swAutoRefresh.Margin = new Padding(0);
            swAutoRefresh.MouseLocation = new Point(-1, -1);
            swAutoRefresh.MouseState = MaterialSkin.MouseState.HOVER;
            swAutoRefresh.Name = "swAutoRefresh";
            swAutoRefresh.Ripple = true;
            swAutoRefresh.Size = new Size(176, 31);
            swAutoRefresh.TabIndex = 34;
            swAutoRefresh.Text = "自动刷新地图";
            toolTip.SetToolTip(swAutoRefresh, "Automatically refreshes loot on the map");
            swAutoRefresh.UseVisualStyleBackColor = true;
            swAutoRefresh.CheckedChanged += swAutoRefresh_CheckedChanged;
            // 
            // btnRefreshLoot
            // 
            btnRefreshLoot.AutoSize = false;
            btnRefreshLoot.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnRefreshLoot.Density = MaterialButton.MaterialButtonDensity.Default;
            btnRefreshLoot.Depth = 0;
            btnRefreshLoot.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            btnRefreshLoot.HighEmphasis = true;
            btnRefreshLoot.Icon = null;
            btnRefreshLoot.Location = new Point(410, 41);
            btnRefreshLoot.Margin = new Padding(5, 7, 5, 7);
            btnRefreshLoot.MouseState = MaterialSkin.MouseState.HOVER;
            btnRefreshLoot.Name = "btnRefreshLoot";
            btnRefreshLoot.NoAccentTextColor = Color.Empty;
            btnRefreshLoot.Size = new Size(133, 41);
            btnRefreshLoot.TabIndex = 35;
            btnRefreshLoot.Text = "手动刷新物资";
            toolTip.SetToolTip(btnRefreshLoot, "Manually triggers radar restart");
            btnRefreshLoot.Type = MaterialButton.MaterialButtonType.Contained;
            btnRefreshLoot.UseAccentColor = true;
            btnRefreshLoot.UseVisualStyleBackColor = true;
            btnRefreshLoot.Click += btnRefreshLoot_Click;
            // 
            // cboAutoRefreshMap
            // 
            cboAutoRefreshMap.AutoResize = false;
            cboAutoRefreshMap.BackColor = Color.FromArgb(255, 255, 255);
            cboAutoRefreshMap.Depth = 0;
            cboAutoRefreshMap.DrawMode = DrawMode.OwnerDrawVariable;
            cboAutoRefreshMap.DropDownHeight = 118;
            cboAutoRefreshMap.DropDownStyle = ComboBoxStyle.DropDownList;
            cboAutoRefreshMap.DropDownWidth = 121;
            cboAutoRefreshMap.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboAutoRefreshMap.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboAutoRefreshMap.FormattingEnabled = true;
            cboAutoRefreshMap.Hint = "Map";
            cboAutoRefreshMap.IntegralHeight = false;
            cboAutoRefreshMap.ItemHeight = 29;
            cboAutoRefreshMap.Location = new Point(199, 139);
            cboAutoRefreshMap.MaxDropDownItems = 4;
            cboAutoRefreshMap.MouseState = MaterialSkin.MouseState.OUT;
            cboAutoRefreshMap.Name = "cboAutoRefreshMap";
            cboAutoRefreshMap.Size = new Size(175, 35);
            cboAutoRefreshMap.StartIndex = 0;
            cboAutoRefreshMap.TabIndex = 39;
            toolTip.SetToolTip(cboAutoRefreshMap, "The map to adjust the auto refresh delay on");
            cboAutoRefreshMap.UseTallSize = false;
            cboAutoRefreshMap.Visible = false;
            cboAutoRefreshMap.SelectedIndexChanged += cboAutoRefreshMap_SelectedIndexChanged;
            // 
            // sldrAutoRefreshDelay
            // 
            sldrAutoRefreshDelay.Depth = 0;
            sldrAutoRefreshDelay.ForeColor = Color.Black;
            sldrAutoRefreshDelay.Location = new Point(382, 139);
            sldrAutoRefreshDelay.MouseState = MaterialSkin.MouseState.HOVER;
            sldrAutoRefreshDelay.Name = "sldrAutoRefreshDelay";
            sldrAutoRefreshDelay.RangeMax = 90;
            sldrAutoRefreshDelay.RangeMin = 1;
            sldrAutoRefreshDelay.Size = new Size(195, 40);
            sldrAutoRefreshDelay.TabIndex = 38;
            sldrAutoRefreshDelay.Text = "延迟";
            toolTip.SetToolTip(sldrAutoRefreshDelay, "The delay in seconds to automatically refresh loot");
            sldrAutoRefreshDelay.UseAccentColor = true;
            sldrAutoRefreshDelay.Value = 30;
            sldrAutoRefreshDelay.ValueMax = 90;
            sldrAutoRefreshDelay.ValueSuffix = "s";
            sldrAutoRefreshDelay.Visible = false;
            sldrAutoRefreshDelay.onValueChanged += sldrAutoRefreshDelay_onValueChanged;
            // 
            // sldrMinSubItems
            // 
            sldrMinSubItems.Depth = 0;
            sldrMinSubItems.ForeColor = Color.Black;
            sldrMinSubItems.Location = new Point(390, 91);
            sldrMinSubItems.MouseState = MaterialSkin.MouseState.HOVER;
            sldrMinSubItems.Name = "sldrMinSubItems";
            sldrMinSubItems.RangeMax = 200;
            sldrMinSubItems.RangeMin = 5;
            sldrMinSubItems.Size = new Size(275, 40);
            sldrMinSubItems.TabIndex = 34;
            sldrMinSubItems.Text = "显示子物资";
            toolTip.SetToolTip(sldrMinSubItems, "The minimum value for sub-items to be shown (eg mods on a weapon)");
            sldrMinSubItems.UseAccentColor = true;
            sldrMinSubItems.Value = 100;
            sldrMinSubItems.ValueMax = 200;
            sldrMinSubItems.ValueSuffix = "k";
            sldrMinSubItems.onValueChanged += sldrMinSubItems_onValueChanged;
            // 
            // sldrMinImportantLoot
            // 
            sldrMinImportantLoot.Depth = 0;
            sldrMinImportantLoot.ForeColor = Color.Black;
            sldrMinImportantLoot.Location = new Point(17, 91);
            sldrMinImportantLoot.MouseState = MaterialSkin.MouseState.HOVER;
            sldrMinImportantLoot.Name = "sldrMinImportantLoot";
            sldrMinImportantLoot.RangeMax = 600;
            sldrMinImportantLoot.RangeMin = 10;
            sldrMinImportantLoot.Size = new Size(347, 40);
            sldrMinImportantLoot.TabIndex = 35;
            sldrMinImportantLoot.Text = "重要物资";
            toolTip.SetToolTip(sldrMinImportantLoot, "The minimum value for loot to be considered 'important'");
            sldrMinImportantLoot.UseAccentColor = true;
            sldrMinImportantLoot.Value = 250;
            sldrMinImportantLoot.ValueMax = 600;
            sldrMinImportantLoot.ValueSuffix = "k";
            sldrMinImportantLoot.onValueChanged += sldrMinImportantLoot_onValueChanged;
            // 
            // btnAddFaction
            // 
            btnAddFaction.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAddFaction.Density = MaterialButton.MaterialButtonDensity.Default;
            btnAddFaction.Depth = 0;
            btnAddFaction.HighEmphasis = true;
            btnAddFaction.Icon = (Image)resources.GetObject("btnAddFaction.Icon");
            btnAddFaction.Location = new Point(263, 351);
            btnAddFaction.Margin = new Padding(5, 7, 5, 7);
            btnAddFaction.MouseState = MaterialSkin.MouseState.HOVER;
            btnAddFaction.Name = "btnAddFaction";
            btnAddFaction.NoAccentTextColor = Color.Empty;
            btnAddFaction.Size = new Size(81, 36);
            btnAddFaction.TabIndex = 39;
            btnAddFaction.Text = "添加";
            toolTip.SetToolTip(btnAddFaction, "Creates a new loot filter profile");
            btnAddFaction.Type = MaterialButton.MaterialButtonType.Contained;
            btnAddFaction.UseAccentColor = true;
            btnAddFaction.UseVisualStyleBackColor = true;
            btnAddFaction.Click += btnAddFaction_Click;
            // 
            // btnRemoveFaction
            // 
            btnRemoveFaction.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnRemoveFaction.Density = MaterialButton.MaterialButtonDensity.Default;
            btnRemoveFaction.Depth = 0;
            btnRemoveFaction.HighEmphasis = true;
            btnRemoveFaction.Icon = (Image)resources.GetObject("btnRemoveFaction.Icon");
            btnRemoveFaction.Location = new Point(263, 411);
            btnRemoveFaction.Margin = new Padding(5, 7, 5, 7);
            btnRemoveFaction.MouseState = MaterialSkin.MouseState.HOVER;
            btnRemoveFaction.Name = "btnRemoveFaction";
            btnRemoveFaction.NoAccentTextColor = Color.Empty;
            btnRemoveFaction.Size = new Size(81, 36);
            btnRemoveFaction.TabIndex = 40;
            btnRemoveFaction.Text = "移除";
            toolTip.SetToolTip(btnRemoveFaction, "Removes the selected loot filter profile");
            btnRemoveFaction.Type = MaterialButton.MaterialButtonType.Outlined;
            btnRemoveFaction.UseAccentColor = true;
            btnRemoveFaction.UseVisualStyleBackColor = true;
            btnRemoveFaction.Click += btnRemoveFaction_Click;
            // 
            // btnAddFactionEntry
            // 
            btnAddFactionEntry.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAddFactionEntry.Density = MaterialButton.MaterialButtonDensity.Default;
            btnAddFactionEntry.Depth = 0;
            btnAddFactionEntry.HighEmphasis = true;
            btnAddFactionEntry.Icon = (Image)resources.GetObject("btnAddFactionEntry.Icon");
            btnAddFactionEntry.Location = new Point(331, 147);
            btnAddFactionEntry.Margin = new Padding(5, 7, 5, 7);
            btnAddFactionEntry.MouseState = MaterialSkin.MouseState.HOVER;
            btnAddFactionEntry.Name = "btnAddFactionEntry";
            btnAddFactionEntry.NoAccentTextColor = Color.Empty;
            btnAddFactionEntry.Size = new Size(113, 36);
            btnAddFactionEntry.TabIndex = 46;
            btnAddFactionEntry.Text = "添加名单";
            toolTip.SetToolTip(btnAddFactionEntry, "Creates a new loot filter profile");
            btnAddFactionEntry.Type = MaterialButton.MaterialButtonType.Contained;
            btnAddFactionEntry.UseAccentColor = true;
            btnAddFactionEntry.UseVisualStyleBackColor = true;
            btnAddFactionEntry.Click += btnAddFactionEntry_Click;
            // 
            // btnRemoveFactionEntry
            // 
            btnRemoveFactionEntry.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnRemoveFactionEntry.Density = MaterialButton.MaterialButtonDensity.Default;
            btnRemoveFactionEntry.Depth = 0;
            btnRemoveFactionEntry.HighEmphasis = true;
            btnRemoveFactionEntry.Icon = (Image)resources.GetObject("btnRemoveFactionEntry.Icon");
            btnRemoveFactionEntry.Location = new Point(331, 63);
            btnRemoveFactionEntry.Margin = new Padding(5, 7, 5, 7);
            btnRemoveFactionEntry.MouseState = MaterialSkin.MouseState.HOVER;
            btnRemoveFactionEntry.Name = "btnRemoveFactionEntry";
            btnRemoveFactionEntry.NoAccentTextColor = Color.Empty;
            btnRemoveFactionEntry.Size = new Size(81, 36);
            btnRemoveFactionEntry.TabIndex = 48;
            btnRemoveFactionEntry.Text = "移除";
            toolTip.SetToolTip(btnRemoveFactionEntry, "Removes the selected loot filter profile");
            btnRemoveFactionEntry.Type = MaterialButton.MaterialButtonType.Outlined;
            btnRemoveFactionEntry.UseAccentColor = true;
            btnRemoveFactionEntry.UseVisualStyleBackColor = true;
            btnRemoveFactionEntry.Click += btnRemoveFactionEntry_Click;
            // 
            // txtTeammateID
            // 
            txtTeammateID.AnimateReadOnly = false;
            txtTeammateID.BackgroundImageLayout = ImageLayout.None;
            txtTeammateID.CharacterCasing = CharacterCasing.Normal;
            txtTeammateID.Depth = 0;
            txtTeammateID.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtTeammateID.HideSelection = true;
            txtTeammateID.Hint = "队友ID";
            txtTeammateID.LeadingIcon = null;
            txtTeammateID.Location = new Point(429, 191);
            txtTeammateID.MaxLength = 32767;
            txtTeammateID.MouseState = MaterialSkin.MouseState.OUT;
            txtTeammateID.Name = "txtTeammateID";
            txtTeammateID.PasswordChar = '\0';
            txtTeammateID.PrefixSuffixText = null;
            txtTeammateID.ReadOnly = false;
            txtTeammateID.RightToLeft = RightToLeft.No;
            txtTeammateID.SelectedText = "";
            txtTeammateID.SelectionLength = 0;
            txtTeammateID.SelectionStart = 0;
            txtTeammateID.ShortcutsEnabled = true;
            txtTeammateID.Size = new Size(275, 36);
            txtTeammateID.TabIndex = 32;
            txtTeammateID.TabStop = false;
            txtTeammateID.TextAlign = HorizontalAlignment.Left;
            toolTip.SetToolTip(txtTeammateID, "Primary teammate ID for friendly aimview");
            txtTeammateID.TrailingIcon = null;
            txtTeammateID.UseSystemPasswordChar = false;
            txtTeammateID.UseTallSize = false;
            // 
            // txtFactionEntryName
            // 
            txtFactionEntryName.AnimateReadOnly = false;
            txtFactionEntryName.BackgroundImageLayout = ImageLayout.None;
            txtFactionEntryName.CharacterCasing = CharacterCasing.Normal;
            txtFactionEntryName.Depth = 0;
            txtFactionEntryName.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtFactionEntryName.HideSelection = true;
            txtFactionEntryName.Hint = "ID";
            txtFactionEntryName.LeadingIcon = null;
            txtFactionEntryName.Location = new Point(17, 51);
            txtFactionEntryName.MaxLength = 32767;
            txtFactionEntryName.MouseState = MaterialSkin.MouseState.OUT;
            txtFactionEntryName.Name = "txtFactionEntryName";
            txtFactionEntryName.PasswordChar = '\0';
            txtFactionEntryName.PrefixSuffixText = null;
            txtFactionEntryName.ReadOnly = false;
            txtFactionEntryName.RightToLeft = RightToLeft.No;
            txtFactionEntryName.SelectedText = "";
            txtFactionEntryName.SelectionLength = 0;
            txtFactionEntryName.SelectionStart = 0;
            txtFactionEntryName.ShortcutsEnabled = true;
            txtFactionEntryName.Size = new Size(213, 36);
            txtFactionEntryName.TabIndex = 44;
            txtFactionEntryName.TabStop = false;
            txtFactionEntryName.TextAlign = HorizontalAlignment.Left;
            toolTip.SetToolTip(txtFactionEntryName, "The name of the faction entry (ai name)");
            txtFactionEntryName.TrailingIcon = null;
            txtFactionEntryName.UseSystemPasswordChar = false;
            txtFactionEntryName.UseTallSize = false;
            txtFactionEntryName.KeyDown += txtFactionEntryName_KeyDown;
            // 
            // txtFactionName
            // 
            txtFactionName.AnimateReadOnly = false;
            txtFactionName.BackgroundImageLayout = ImageLayout.None;
            txtFactionName.CharacterCasing = CharacterCasing.Normal;
            txtFactionName.Depth = 0;
            txtFactionName.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtFactionName.HideSelection = true;
            txtFactionName.Hint = "Faction Name";
            txtFactionName.LeadingIcon = null;
            txtFactionName.Location = new Point(241, 51);
            txtFactionName.MaxLength = 32767;
            txtFactionName.MouseState = MaterialSkin.MouseState.OUT;
            txtFactionName.Name = "txtFactionName";
            txtFactionName.PasswordChar = '\0';
            txtFactionName.PrefixSuffixText = null;
            txtFactionName.ReadOnly = false;
            txtFactionName.RightToLeft = RightToLeft.No;
            txtFactionName.SelectedText = "";
            txtFactionName.SelectionLength = 0;
            txtFactionName.SelectionStart = 0;
            txtFactionName.ShortcutsEnabled = true;
            txtFactionName.Size = new Size(247, 36);
            txtFactionName.TabIndex = 45;
            txtFactionName.TabStop = false;
            txtFactionName.TextAlign = HorizontalAlignment.Left;
            toolTip.SetToolTip(txtFactionName, "The name of the faction");
            txtFactionName.TrailingIcon = null;
            txtFactionName.UseSystemPasswordChar = false;
            txtFactionName.UseTallSize = false;
            txtFactionName.KeyDown += txtFactionName_KeyDown;
            // 
            // cboFactionType
            // 
            cboFactionType.AutoResize = false;
            cboFactionType.BackColor = Color.FromArgb(255, 255, 255);
            cboFactionType.Depth = 0;
            cboFactionType.DrawMode = DrawMode.OwnerDrawVariable;
            cboFactionType.DropDownHeight = 118;
            cboFactionType.DropDownStyle = ComboBoxStyle.DropDownList;
            cboFactionType.DropDownWidth = 121;
            cboFactionType.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboFactionType.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboFactionType.FormattingEnabled = true;
            cboFactionType.Hint = "Faction Type";
            cboFactionType.IntegralHeight = false;
            cboFactionType.ItemHeight = 29;
            cboFactionType.Location = new Point(241, 102);
            cboFactionType.MaxDropDownItems = 4;
            cboFactionType.MouseState = MaterialSkin.MouseState.OUT;
            cboFactionType.Name = "cboFactionType";
            cboFactionType.Size = new Size(246, 35);
            cboFactionType.StartIndex = 0;
            cboFactionType.TabIndex = 44;
            toolTip.SetToolTip(cboFactionType, "The type of faction it is");
            cboFactionType.UseTallSize = false;
            cboFactionType.SelectedIndexChanged += cboFactionType_SelectedIndexChanged;
            // 
            // btnResetTheme
            // 
            btnResetTheme.AutoSize = false;
            btnResetTheme.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnResetTheme.Density = MaterialButton.MaterialButtonDensity.Default;
            btnResetTheme.Depth = 0;
            btnResetTheme.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            btnResetTheme.HighEmphasis = true;
            btnResetTheme.Icon = null;
            btnResetTheme.Location = new Point(85, 309);
            btnResetTheme.Margin = new Padding(5, 7, 5, 7);
            btnResetTheme.MouseState = MaterialSkin.MouseState.HOVER;
            btnResetTheme.Name = "btnResetTheme";
            btnResetTheme.NoAccentTextColor = Color.Empty;
            btnResetTheme.Size = new Size(120, 41);
            btnResetTheme.TabIndex = 59;
            btnResetTheme.Text = "重置主题";
            toolTip.SetToolTip(btnResetTheme, "Manually triggers radar restart");
            btnResetTheme.Type = MaterialButton.MaterialButtonType.Contained;
            btnResetTheme.UseAccentColor = true;
            btnResetTheme.UseVisualStyleBackColor = true;
            btnResetTheme.Click += btnResetTheme_Click;
            // 
            // btnMapSetupApply
            // 
            btnMapSetupApply.AutoSize = false;
            btnMapSetupApply.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnMapSetupApply.Density = MaterialButton.MaterialButtonDensity.Default;
            btnMapSetupApply.Depth = 0;
            btnMapSetupApply.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            btnMapSetupApply.HighEmphasis = true;
            btnMapSetupApply.Icon = null;
            btnMapSetupApply.Location = new Point(293, 17);
            btnMapSetupApply.Margin = new Padding(5, 7, 5, 7);
            btnMapSetupApply.MouseState = MaterialSkin.MouseState.HOVER;
            btnMapSetupApply.Name = "btnMapSetupApply";
            btnMapSetupApply.NoAccentTextColor = Color.Empty;
            btnMapSetupApply.Size = new Size(65, 41);
            btnMapSetupApply.TabIndex = 35;
            btnMapSetupApply.Text = "应用";
            toolTip.SetToolTip(btnMapSetupApply, "Manually triggers radar restart");
            btnMapSetupApply.Type = MaterialButton.MaterialButtonType.Contained;
            btnMapSetupApply.UseAccentColor = true;
            btnMapSetupApply.UseVisualStyleBackColor = true;
            btnMapSetupApply.Click += btnMapSetupApply_Click;
            // 
            // txtMapSetupScale
            // 
            txtMapSetupScale.AnimateReadOnly = false;
            txtMapSetupScale.BackgroundImageLayout = ImageLayout.None;
            txtMapSetupScale.CharacterCasing = CharacterCasing.Normal;
            txtMapSetupScale.Depth = 0;
            txtMapSetupScale.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtMapSetupScale.HelperText = "Scale";
            txtMapSetupScale.HideSelection = true;
            txtMapSetupScale.Hint = "Scale";
            txtMapSetupScale.LeadingIcon = null;
            txtMapSetupScale.Location = new Point(195, 20);
            txtMapSetupScale.MaxLength = 32767;
            txtMapSetupScale.MouseState = MaterialSkin.MouseState.OUT;
            txtMapSetupScale.Name = "txtMapSetupScale";
            txtMapSetupScale.PasswordChar = '\0';
            txtMapSetupScale.PrefixSuffixText = null;
            txtMapSetupScale.ReadOnly = false;
            txtMapSetupScale.RightToLeft = RightToLeft.No;
            txtMapSetupScale.SelectedText = "";
            txtMapSetupScale.SelectionLength = 0;
            txtMapSetupScale.SelectionStart = 0;
            txtMapSetupScale.ShortcutsEnabled = true;
            txtMapSetupScale.Size = new Size(89, 36);
            txtMapSetupScale.TabIndex = 34;
            txtMapSetupScale.TabStop = false;
            txtMapSetupScale.TextAlign = HorizontalAlignment.Left;
            toolTip.SetToolTip(txtMapSetupScale, "The scale");
            txtMapSetupScale.TrailingIcon = null;
            txtMapSetupScale.UseSystemPasswordChar = false;
            txtMapSetupScale.UseTallSize = false;
            // 
            // txtMapSetupY
            // 
            txtMapSetupY.AnimateReadOnly = false;
            txtMapSetupY.BackgroundImageLayout = ImageLayout.None;
            txtMapSetupY.CharacterCasing = CharacterCasing.Normal;
            txtMapSetupY.Depth = 0;
            txtMapSetupY.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtMapSetupY.HelperText = "Y";
            txtMapSetupY.HideSelection = true;
            txtMapSetupY.Hint = "Y";
            txtMapSetupY.LeadingIcon = null;
            txtMapSetupY.Location = new Point(99, 20);
            txtMapSetupY.MaxLength = 32767;
            txtMapSetupY.MouseState = MaterialSkin.MouseState.OUT;
            txtMapSetupY.Name = "txtMapSetupY";
            txtMapSetupY.PasswordChar = '\0';
            txtMapSetupY.PrefixSuffixText = null;
            txtMapSetupY.ReadOnly = false;
            txtMapSetupY.RightToLeft = RightToLeft.No;
            txtMapSetupY.SelectedText = "";
            txtMapSetupY.SelectionLength = 0;
            txtMapSetupY.SelectionStart = 0;
            txtMapSetupY.ShortcutsEnabled = true;
            txtMapSetupY.Size = new Size(89, 36);
            txtMapSetupY.TabIndex = 33;
            txtMapSetupY.TabStop = false;
            txtMapSetupY.TextAlign = HorizontalAlignment.Left;
            toolTip.SetToolTip(txtMapSetupY, "The Y coordinate");
            txtMapSetupY.TrailingIcon = null;
            txtMapSetupY.UseSystemPasswordChar = false;
            txtMapSetupY.UseTallSize = false;
            // 
            // txtMapSetupX
            // 
            txtMapSetupX.AnimateReadOnly = false;
            txtMapSetupX.BackgroundImageLayout = ImageLayout.None;
            txtMapSetupX.CharacterCasing = CharacterCasing.Normal;
            txtMapSetupX.Depth = 0;
            txtMapSetupX.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtMapSetupX.HelperText = "X";
            txtMapSetupX.HideSelection = true;
            txtMapSetupX.Hint = "X";
            txtMapSetupX.LeadingIcon = null;
            txtMapSetupX.Location = new Point(3, 20);
            txtMapSetupX.MaxLength = 32767;
            txtMapSetupX.MouseState = MaterialSkin.MouseState.OUT;
            txtMapSetupX.Name = "txtMapSetupX";
            txtMapSetupX.PasswordChar = '\0';
            txtMapSetupX.PrefixSuffixText = null;
            txtMapSetupX.ReadOnly = false;
            txtMapSetupX.RightToLeft = RightToLeft.No;
            txtMapSetupX.SelectedText = "";
            txtMapSetupX.SelectionLength = 0;
            txtMapSetupX.SelectionStart = 0;
            txtMapSetupX.ShortcutsEnabled = true;
            txtMapSetupX.Size = new Size(89, 36);
            txtMapSetupX.TabIndex = 32;
            txtMapSetupX.TabStop = false;
            txtMapSetupX.TextAlign = HorizontalAlignment.Left;
            toolTip.SetToolTip(txtMapSetupX, "The X coordinate");
            txtMapSetupX.TrailingIcon = null;
            txtMapSetupX.UseSystemPasswordChar = false;
            txtMapSetupX.UseTallSize = false;
            // 
            // btnToggleMapFree
            // 
            btnToggleMapFree.AutoSize = false;
            btnToggleMapFree.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnToggleMapFree.Density = MaterialButton.MaterialButtonDensity.Default;
            btnToggleMapFree.Depth = 0;
            btnToggleMapFree.HighEmphasis = true;
            btnToggleMapFree.Icon = Properties.Resources.tick;
            btnToggleMapFree.Location = new Point(7, 6);
            btnToggleMapFree.Margin = new Padding(5, 7, 5, 7);
            btnToggleMapFree.MouseState = MaterialSkin.MouseState.HOVER;
            btnToggleMapFree.Name = "btnToggleMapFree";
            btnToggleMapFree.NoAccentTextColor = Color.Empty;
            btnToggleMapFree.Size = new Size(122, 41);
            btnToggleMapFree.TabIndex = 47;
            btnToggleMapFree.Text = "视角跟随";
            toolTip.SetToolTip(btnToggleMapFree, "Toggles radar following functionality");
            btnToggleMapFree.Type = MaterialButton.MaterialButtonType.Text;
            btnToggleMapFree.UseAccentColor = true;
            btnToggleMapFree.UseVisualStyleBackColor = true;
            btnToggleMapFree.Click += btnToggleMapFree_Click;
            // 
            // btnRemoveWatchlistEntry
            // 
            btnRemoveWatchlistEntry.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnRemoveWatchlistEntry.Density = MaterialButton.MaterialButtonDensity.Default;
            btnRemoveWatchlistEntry.Depth = 0;
            btnRemoveWatchlistEntry.HighEmphasis = true;
            btnRemoveWatchlistEntry.Icon = (Image)resources.GetObject("btnRemoveWatchlistEntry.Icon");
            btnRemoveWatchlistEntry.Location = new Point(408, 51);
            btnRemoveWatchlistEntry.Margin = new Padding(5, 7, 5, 7);
            btnRemoveWatchlistEntry.MouseState = MaterialSkin.MouseState.HOVER;
            btnRemoveWatchlistEntry.Name = "btnRemoveWatchlistEntry";
            btnRemoveWatchlistEntry.NoAccentTextColor = Color.Empty;
            btnRemoveWatchlistEntry.Size = new Size(81, 36);
            btnRemoveWatchlistEntry.TabIndex = 48;
            btnRemoveWatchlistEntry.Text = "移除";
            toolTip.SetToolTip(btnRemoveWatchlistEntry, "Removes the selected entry from the active watchlist profile");
            btnRemoveWatchlistEntry.Type = MaterialButton.MaterialButtonType.Outlined;
            btnRemoveWatchlistEntry.UseAccentColor = true;
            btnRemoveWatchlistEntry.UseVisualStyleBackColor = true;
            btnRemoveWatchlistEntry.Click += btnRemoveWatchlistEntry_Click;
            // 
            // txtWatchlistAccountID
            // 
            txtWatchlistAccountID.AnimateReadOnly = false;
            txtWatchlistAccountID.BackgroundImageLayout = ImageLayout.None;
            txtWatchlistAccountID.CharacterCasing = CharacterCasing.Normal;
            txtWatchlistAccountID.Depth = 0;
            txtWatchlistAccountID.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtWatchlistAccountID.HideSelection = true;
            txtWatchlistAccountID.Hint = "Account ID";
            txtWatchlistAccountID.LeadingIcon = null;
            txtWatchlistAccountID.Location = new Point(17, 51);
            txtWatchlistAccountID.MaxLength = 32767;
            txtWatchlistAccountID.MouseState = MaterialSkin.MouseState.OUT;
            txtWatchlistAccountID.Name = "txtWatchlistAccountID";
            txtWatchlistAccountID.PasswordChar = '\0';
            txtWatchlistAccountID.PrefixSuffixText = null;
            txtWatchlistAccountID.ReadOnly = false;
            txtWatchlistAccountID.RightToLeft = RightToLeft.No;
            txtWatchlistAccountID.SelectedText = "";
            txtWatchlistAccountID.SelectionLength = 0;
            txtWatchlistAccountID.SelectionStart = 0;
            txtWatchlistAccountID.ShortcutsEnabled = true;
            txtWatchlistAccountID.Size = new Size(211, 36);
            txtWatchlistAccountID.TabIndex = 44;
            txtWatchlistAccountID.TabStop = false;
            txtWatchlistAccountID.TextAlign = HorizontalAlignment.Left;
            toolTip.SetToolTip(txtWatchlistAccountID, "The AccountID (AID) of the user to add");
            txtWatchlistAccountID.TrailingIcon = null;
            txtWatchlistAccountID.UseSystemPasswordChar = false;
            txtWatchlistAccountID.UseTallSize = false;
            txtWatchlistAccountID.KeyDown += txtWatchlistAccountID_KeyDown;
            // 
            // txtWatchlistProfileName
            // 
            txtWatchlistProfileName.AnimateReadOnly = false;
            txtWatchlistProfileName.BackgroundImageLayout = ImageLayout.None;
            txtWatchlistProfileName.CharacterCasing = CharacterCasing.Normal;
            txtWatchlistProfileName.Depth = 0;
            txtWatchlistProfileName.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtWatchlistProfileName.HideSelection = true;
            txtWatchlistProfileName.Hint = "Profile Name";
            txtWatchlistProfileName.LeadingIcon = null;
            txtWatchlistProfileName.Location = new Point(285, 51);
            txtWatchlistProfileName.MaxLength = 32767;
            txtWatchlistProfileName.MouseState = MaterialSkin.MouseState.OUT;
            txtWatchlistProfileName.Name = "txtWatchlistProfileName";
            txtWatchlistProfileName.PasswordChar = '\0';
            txtWatchlistProfileName.PrefixSuffixText = null;
            txtWatchlistProfileName.ReadOnly = false;
            txtWatchlistProfileName.RightToLeft = RightToLeft.No;
            txtWatchlistProfileName.SelectedText = "";
            txtWatchlistProfileName.SelectionLength = 0;
            txtWatchlistProfileName.SelectionStart = 0;
            txtWatchlistProfileName.ShortcutsEnabled = true;
            txtWatchlistProfileName.Size = new Size(247, 36);
            txtWatchlistProfileName.TabIndex = 45;
            txtWatchlistProfileName.TabStop = false;
            txtWatchlistProfileName.TextAlign = HorizontalAlignment.Left;
            toolTip.SetToolTip(txtWatchlistProfileName, "The name of the watchlist profile");
            txtWatchlistProfileName.TrailingIcon = null;
            txtWatchlistProfileName.UseSystemPasswordChar = false;
            txtWatchlistProfileName.UseTallSize = false;
            txtWatchlistProfileName.KeyDown += txtWatchlistProfileName_KeyDown;
            // 
            // btnAddWatchlistEntry
            // 
            btnAddWatchlistEntry.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAddWatchlistEntry.Density = MaterialButton.MaterialButtonDensity.Default;
            btnAddWatchlistEntry.Depth = 0;
            btnAddWatchlistEntry.HighEmphasis = true;
            btnAddWatchlistEntry.Icon = (Image)resources.GetObject("btnAddWatchlistEntry.Icon");
            btnAddWatchlistEntry.Location = new Point(423, 102);
            btnAddWatchlistEntry.Margin = new Padding(5, 7, 5, 7);
            btnAddWatchlistEntry.MouseState = MaterialSkin.MouseState.HOVER;
            btnAddWatchlistEntry.Name = "btnAddWatchlistEntry";
            btnAddWatchlistEntry.NoAccentTextColor = Color.Empty;
            btnAddWatchlistEntry.Size = new Size(81, 36);
            btnAddWatchlistEntry.TabIndex = 46;
            btnAddWatchlistEntry.Text = "添加";
            toolTip.SetToolTip(btnAddWatchlistEntry, "Adds a new entry to the active watchlist profile");
            btnAddWatchlistEntry.Type = MaterialButton.MaterialButtonType.Contained;
            btnAddWatchlistEntry.UseAccentColor = true;
            btnAddWatchlistEntry.UseVisualStyleBackColor = true;
            btnAddWatchlistEntry.Click += btnAddWatchlistEntry_Click;
            // 
            // btnAddWatchlistProfile
            // 
            btnAddWatchlistProfile.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAddWatchlistProfile.Density = MaterialButton.MaterialButtonDensity.Default;
            btnAddWatchlistProfile.Depth = 0;
            btnAddWatchlistProfile.HighEmphasis = true;
            btnAddWatchlistProfile.Icon = (Image)resources.GetObject("btnAddWatchlistProfile.Icon");
            btnAddWatchlistProfile.Location = new Point(239, 371);
            btnAddWatchlistProfile.Margin = new Padding(5, 7, 5, 7);
            btnAddWatchlistProfile.MouseState = MaterialSkin.MouseState.HOVER;
            btnAddWatchlistProfile.Name = "btnAddWatchlistProfile";
            btnAddWatchlistProfile.NoAccentTextColor = Color.Empty;
            btnAddWatchlistProfile.Size = new Size(81, 36);
            btnAddWatchlistProfile.TabIndex = 39;
            btnAddWatchlistProfile.Text = "添加";
            toolTip.SetToolTip(btnAddWatchlistProfile, "Creates a new watchlist profile");
            btnAddWatchlistProfile.Type = MaterialButton.MaterialButtonType.Contained;
            btnAddWatchlistProfile.UseAccentColor = true;
            btnAddWatchlistProfile.UseVisualStyleBackColor = true;
            btnAddWatchlistProfile.Click += btnAddWatchlistProfile_Click;
            // 
            // btnRemoveWatchlistProfile
            // 
            btnRemoveWatchlistProfile.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnRemoveWatchlistProfile.Density = MaterialButton.MaterialButtonDensity.Default;
            btnRemoveWatchlistProfile.Depth = 0;
            btnRemoveWatchlistProfile.HighEmphasis = true;
            btnRemoveWatchlistProfile.Icon = (Image)resources.GetObject("btnRemoveWatchlistProfile.Icon");
            btnRemoveWatchlistProfile.Location = new Point(239, 425);
            btnRemoveWatchlistProfile.Margin = new Padding(5, 7, 5, 7);
            btnRemoveWatchlistProfile.MouseState = MaterialSkin.MouseState.HOVER;
            btnRemoveWatchlistProfile.Name = "btnRemoveWatchlistProfile";
            btnRemoveWatchlistProfile.NoAccentTextColor = Color.Empty;
            btnRemoveWatchlistProfile.Size = new Size(81, 36);
            btnRemoveWatchlistProfile.TabIndex = 40;
            btnRemoveWatchlistProfile.Text = "移除";
            toolTip.SetToolTip(btnRemoveWatchlistProfile, "Removes the selected watchlist profile");
            btnRemoveWatchlistProfile.Type = MaterialButton.MaterialButtonType.Outlined;
            btnRemoveWatchlistProfile.UseAccentColor = true;
            btnRemoveWatchlistProfile.UseVisualStyleBackColor = true;
            btnRemoveWatchlistProfile.Click += btnRemoveWatchlistProfile_Click;
            // 
            // txtWatchlistTag
            // 
            txtWatchlistTag.AnimateReadOnly = false;
            txtWatchlistTag.BackgroundImageLayout = ImageLayout.None;
            txtWatchlistTag.CharacterCasing = CharacterCasing.Normal;
            txtWatchlistTag.Depth = 0;
            txtWatchlistTag.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtWatchlistTag.HideSelection = true;
            txtWatchlistTag.Hint = "Tag";
            txtWatchlistTag.LeadingIcon = null;
            txtWatchlistTag.Location = new Point(17, 102);
            txtWatchlistTag.MaxLength = 32767;
            txtWatchlistTag.MouseState = MaterialSkin.MouseState.OUT;
            txtWatchlistTag.Name = "txtWatchlistTag";
            txtWatchlistTag.PasswordChar = '\0';
            txtWatchlistTag.PrefixSuffixText = null;
            txtWatchlistTag.ReadOnly = false;
            txtWatchlistTag.RightToLeft = RightToLeft.No;
            txtWatchlistTag.SelectedText = "";
            txtWatchlistTag.SelectionLength = 0;
            txtWatchlistTag.SelectionStart = 0;
            txtWatchlistTag.ShortcutsEnabled = true;
            txtWatchlistTag.Size = new Size(211, 36);
            txtWatchlistTag.TabIndex = 49;
            txtWatchlistTag.TabStop = false;
            txtWatchlistTag.TextAlign = HorizontalAlignment.Left;
            toolTip.SetToolTip(txtWatchlistTag, "The tag/name/reason to give them");
            txtWatchlistTag.TrailingIcon = null;
            txtWatchlistTag.UseSystemPasswordChar = false;
            txtWatchlistTag.UseTallSize = false;
            txtWatchlistTag.KeyDown += txtWatchlistTag_KeyDown;
            // 
            // txtWatchlistPlatformUsername
            // 
            txtWatchlistPlatformUsername.AnimateReadOnly = false;
            txtWatchlistPlatformUsername.BackgroundImageLayout = ImageLayout.None;
            txtWatchlistPlatformUsername.CharacterCasing = CharacterCasing.Normal;
            txtWatchlistPlatformUsername.Depth = 0;
            txtWatchlistPlatformUsername.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtWatchlistPlatformUsername.HideSelection = true;
            txtWatchlistPlatformUsername.Hint = "Platform Username";
            txtWatchlistPlatformUsername.LeadingIcon = null;
            txtWatchlistPlatformUsername.Location = new Point(16, 153);
            txtWatchlistPlatformUsername.MaxLength = 32767;
            txtWatchlistPlatformUsername.MouseState = MaterialSkin.MouseState.OUT;
            txtWatchlistPlatformUsername.Name = "txtWatchlistPlatformUsername";
            txtWatchlistPlatformUsername.PasswordChar = '\0';
            txtWatchlistPlatformUsername.PrefixSuffixText = null;
            txtWatchlistPlatformUsername.ReadOnly = false;
            txtWatchlistPlatformUsername.RightToLeft = RightToLeft.No;
            txtWatchlistPlatformUsername.SelectedText = "";
            txtWatchlistPlatformUsername.SelectionLength = 0;
            txtWatchlistPlatformUsername.SelectionStart = 0;
            txtWatchlistPlatformUsername.ShortcutsEnabled = true;
            txtWatchlistPlatformUsername.Size = new Size(211, 36);
            txtWatchlistPlatformUsername.TabIndex = 53;
            txtWatchlistPlatformUsername.TabStop = false;
            txtWatchlistPlatformUsername.TextAlign = HorizontalAlignment.Left;
            toolTip.SetToolTip(txtWatchlistPlatformUsername, "The twitch/youtube username (only include username, no URL)");
            txtWatchlistPlatformUsername.TrailingIcon = null;
            txtWatchlistPlatformUsername.UseSystemPasswordChar = false;
            txtWatchlistPlatformUsername.UseTallSize = false;
            txtWatchlistPlatformUsername.KeyDown += txtWatchlistPlatformUsername_KeyDown;
            // 
            // rdbYoutube
            // 
            rdbYoutube.AutoSize = true;
            rdbYoutube.Depth = 0;
            rdbYoutube.Location = new Point(346, 153);
            rdbYoutube.Margin = new Padding(0);
            rdbYoutube.MouseLocation = new Point(-1, -1);
            rdbYoutube.MouseState = MaterialSkin.MouseState.HOVER;
            rdbYoutube.Name = "rdbYoutube";
            rdbYoutube.Ripple = true;
            rdbYoutube.Size = new Size(99, 37);
            rdbYoutube.TabIndex = 52;
            rdbYoutube.TabStop = true;
            rdbYoutube.Text = "YouTube";
            toolTip.SetToolTip(rdbYoutube, "Do they stream on YouTube?");
            rdbYoutube.UseVisualStyleBackColor = true;
            rdbYoutube.CheckedChanged += rdbYoutube_CheckedChanged;
            // 
            // rdbTwitch
            // 
            rdbTwitch.AutoSize = true;
            rdbTwitch.Depth = 0;
            rdbTwitch.Location = new Point(248, 153);
            rdbTwitch.Margin = new Padding(0);
            rdbTwitch.MouseLocation = new Point(-1, -1);
            rdbTwitch.MouseState = MaterialSkin.MouseState.HOVER;
            rdbTwitch.Name = "rdbTwitch";
            rdbTwitch.Ripple = true;
            rdbTwitch.Size = new Size(83, 37);
            rdbTwitch.TabIndex = 51;
            rdbTwitch.TabStop = true;
            rdbTwitch.Text = "Twitch";
            toolTip.SetToolTip(rdbTwitch, "Do they stream on Twitch?");
            rdbTwitch.UseVisualStyleBackColor = true;
            rdbTwitch.CheckedChanged += rdbTwitch_CheckedChanged;
            // 
            // swWatchlistIsStreamer
            // 
            swWatchlistIsStreamer.AutoSize = true;
            swWatchlistIsStreamer.Depth = 0;
            swWatchlistIsStreamer.Location = new Point(249, 102);
            swWatchlistIsStreamer.Margin = new Padding(0);
            swWatchlistIsStreamer.MouseLocation = new Point(-1, -1);
            swWatchlistIsStreamer.MouseState = MaterialSkin.MouseState.HOVER;
            swWatchlistIsStreamer.Name = "swWatchlistIsStreamer";
            swWatchlistIsStreamer.Ripple = true;
            swWatchlistIsStreamer.Size = new Size(122, 37);
            swWatchlistIsStreamer.TabIndex = 50;
            swWatchlistIsStreamer.Text = "Streamer";
            toolTip.SetToolTip(swWatchlistIsStreamer, "Are they a streamer?");
            swWatchlistIsStreamer.UseVisualStyleBackColor = true;
            swWatchlistIsStreamer.CheckedChanged += swWatchlistIsStreamer_CheckedChanged;
            // 
            // btnResetPlayerlist
            // 
            btnResetPlayerlist.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnResetPlayerlist.Density = MaterialButton.MaterialButtonDensity.Default;
            btnResetPlayerlist.Depth = 0;
            btnResetPlayerlist.HighEmphasis = true;
            btnResetPlayerlist.Icon = null;
            btnResetPlayerlist.Location = new Point(94, 659);
            btnResetPlayerlist.Margin = new Padding(5, 7, 5, 7);
            btnResetPlayerlist.MouseState = MaterialSkin.MouseState.HOVER;
            btnResetPlayerlist.Name = "btnResetPlayerlist";
            btnResetPlayerlist.NoAccentTextColor = Color.Empty;
            btnResetPlayerlist.Size = new Size(64, 36);
            btnResetPlayerlist.TabIndex = 41;
            btnResetPlayerlist.Text = "重置";
            toolTip.SetToolTip(btnResetPlayerlist, "Removes the selected watchlist profile");
            btnResetPlayerlist.Type = MaterialButton.MaterialButtonType.Outlined;
            btnResetPlayerlist.UseAccentColor = true;
            btnResetPlayerlist.UseVisualStyleBackColor = true;
            btnResetPlayerlist.Click += btnResetPlayerlist_Click;
            // 
            // cboLootFilterItemsToAdd
            // 
            cboLootFilterItemsToAdd.AutoResize = false;
            cboLootFilterItemsToAdd.BackColor = Color.FromArgb(255, 255, 255);
            cboLootFilterItemsToAdd.Depth = 0;
            cboLootFilterItemsToAdd.DrawMode = DrawMode.OwnerDrawVariable;
            cboLootFilterItemsToAdd.DropDownHeight = 727;
            cboLootFilterItemsToAdd.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLootFilterItemsToAdd.DropDownWidth = 121;
            cboLootFilterItemsToAdd.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboLootFilterItemsToAdd.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboLootFilterItemsToAdd.FormattingEnabled = true;
            cboLootFilterItemsToAdd.Hint = "要添加的项目";
            cboLootFilterItemsToAdd.IntegralHeight = false;
            cboLootFilterItemsToAdd.ItemHeight = 29;
            cboLootFilterItemsToAdd.Location = new Point(17, 105);
            cboLootFilterItemsToAdd.MaxDropDownItems = 25;
            cboLootFilterItemsToAdd.MouseState = MaterialSkin.MouseState.OUT;
            cboLootFilterItemsToAdd.Name = "cboLootFilterItemsToAdd";
            cboLootFilterItemsToAdd.Size = new Size(562, 35);
            cboLootFilterItemsToAdd.StartIndex = 0;
            cboLootFilterItemsToAdd.TabIndex = 38;
            toolTip.SetToolTip(cboLootFilterItemsToAdd, "The item to add to the loot filter");
            cboLootFilterItemsToAdd.UseTallSize = false;
            // 
            // txtLootFilterItemToSearch
            // 
            txtLootFilterItemToSearch.AnimateReadOnly = false;
            txtLootFilterItemToSearch.BackgroundImageLayout = ImageLayout.None;
            txtLootFilterItemToSearch.CharacterCasing = CharacterCasing.Normal;
            txtLootFilterItemToSearch.Depth = 0;
            txtLootFilterItemToSearch.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtLootFilterItemToSearch.HideSelection = true;
            txtLootFilterItemToSearch.Hint = "要搜索的项目...";
            txtLootFilterItemToSearch.LeadingIcon = null;
            txtLootFilterItemToSearch.Location = new Point(17, 51);
            txtLootFilterItemToSearch.MaxLength = 32767;
            txtLootFilterItemToSearch.MouseState = MaterialSkin.MouseState.OUT;
            txtLootFilterItemToSearch.Name = "txtLootFilterItemToSearch";
            txtLootFilterItemToSearch.PasswordChar = '\0';
            txtLootFilterItemToSearch.PrefixSuffixText = null;
            txtLootFilterItemToSearch.ReadOnly = false;
            txtLootFilterItemToSearch.RightToLeft = RightToLeft.No;
            txtLootFilterItemToSearch.SelectedText = "";
            txtLootFilterItemToSearch.SelectionLength = 0;
            txtLootFilterItemToSearch.SelectionStart = 0;
            txtLootFilterItemToSearch.ShortcutsEnabled = true;
            txtLootFilterItemToSearch.Size = new Size(331, 36);
            txtLootFilterItemToSearch.TabIndex = 45;
            txtLootFilterItemToSearch.TabStop = false;
            txtLootFilterItemToSearch.TextAlign = HorizontalAlignment.Left;
            toolTip.SetToolTip(txtLootFilterItemToSearch, "The item to search for");
            txtLootFilterItemToSearch.TrailingIcon = null;
            txtLootFilterItemToSearch.UseSystemPasswordChar = false;
            txtLootFilterItemToSearch.UseTallSize = false;
            txtLootFilterItemToSearch.KeyDown += txtLootFilterItemToSearch_KeyDown;
            // 
            // btnAddLootFilterItem
            // 
            btnAddLootFilterItem.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAddLootFilterItem.Density = MaterialButton.MaterialButtonDensity.Default;
            btnAddLootFilterItem.Depth = 0;
            btnAddLootFilterItem.HighEmphasis = true;
            btnAddLootFilterItem.Icon = (Image)resources.GetObject("btnAddLootFilterItem.Icon");
            btnAddLootFilterItem.Location = new Point(359, 51);
            btnAddLootFilterItem.Margin = new Padding(5, 7, 5, 7);
            btnAddLootFilterItem.MouseState = MaterialSkin.MouseState.HOVER;
            btnAddLootFilterItem.Name = "btnAddLootFilterItem";
            btnAddLootFilterItem.NoAccentTextColor = Color.Empty;
            btnAddLootFilterItem.Size = new Size(81, 36);
            btnAddLootFilterItem.TabIndex = 46;
            btnAddLootFilterItem.Text = "添加";
            toolTip.SetToolTip(btnAddLootFilterItem, "Creates a new loot filter profile");
            btnAddLootFilterItem.Type = MaterialButton.MaterialButtonType.Contained;
            btnAddLootFilterItem.UseAccentColor = true;
            btnAddLootFilterItem.UseVisualStyleBackColor = true;
            btnAddLootFilterItem.Click += btnAddLootFilterItem_Click;
            // 
            // btnRemoveLootFilterItem
            // 
            btnRemoveLootFilterItem.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnRemoveLootFilterItem.Density = MaterialButton.MaterialButtonDensity.Default;
            btnRemoveLootFilterItem.Depth = 0;
            btnRemoveLootFilterItem.HighEmphasis = true;
            btnRemoveLootFilterItem.Icon = (Image)resources.GetObject("btnRemoveLootFilterItem.Icon");
            btnRemoveLootFilterItem.Location = new Point(457, 51);
            btnRemoveLootFilterItem.Margin = new Padding(5, 7, 5, 7);
            btnRemoveLootFilterItem.MouseState = MaterialSkin.MouseState.HOVER;
            btnRemoveLootFilterItem.Name = "btnRemoveLootFilterItem";
            btnRemoveLootFilterItem.NoAccentTextColor = Color.Empty;
            btnRemoveLootFilterItem.Size = new Size(81, 36);
            btnRemoveLootFilterItem.TabIndex = 47;
            btnRemoveLootFilterItem.Text = "移除";
            toolTip.SetToolTip(btnRemoveLootFilterItem, "Removes the selected loot filter profile");
            btnRemoveLootFilterItem.Type = MaterialButton.MaterialButtonType.Outlined;
            btnRemoveLootFilterItem.UseAccentColor = true;
            btnRemoveLootFilterItem.UseVisualStyleBackColor = true;
            btnRemoveLootFilterItem.Click += btnRemoveLootFilterItem_Click;
            // 
            // txtLootFilterName
            // 
            txtLootFilterName.AnimateReadOnly = false;
            txtLootFilterName.BackgroundImageLayout = ImageLayout.None;
            txtLootFilterName.CharacterCasing = CharacterCasing.Normal;
            txtLootFilterName.Depth = 0;
            txtLootFilterName.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtLootFilterName.HideSelection = true;
            txtLootFilterName.Hint = "过滤器名称";
            txtLootFilterName.LeadingIcon = null;
            txtLootFilterName.Location = new Point(384, 51);
            txtLootFilterName.MaxLength = 32767;
            txtLootFilterName.MouseState = MaterialSkin.MouseState.OUT;
            txtLootFilterName.Name = "txtLootFilterName";
            txtLootFilterName.PasswordChar = '\0';
            txtLootFilterName.PrefixSuffixText = null;
            txtLootFilterName.ReadOnly = false;
            txtLootFilterName.RightToLeft = RightToLeft.No;
            txtLootFilterName.SelectedText = "";
            txtLootFilterName.SelectionLength = 0;
            txtLootFilterName.SelectionStart = 0;
            txtLootFilterName.ShortcutsEnabled = true;
            txtLootFilterName.Size = new Size(197, 36);
            txtLootFilterName.TabIndex = 39;
            txtLootFilterName.TabStop = false;
            txtLootFilterName.TextAlign = HorizontalAlignment.Left;
            toolTip.SetToolTip(txtLootFilterName, "The name of the loot filter");
            txtLootFilterName.TrailingIcon = null;
            txtLootFilterName.UseSystemPasswordChar = false;
            txtLootFilterName.UseTallSize = false;
            txtLootFilterName.KeyDown += txtLootFilterName_KeyDown;
            // 
            // swLootFilterActive
            // 
            swLootFilterActive.Depth = 0;
            swLootFilterActive.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            swLootFilterActive.Location = new Point(439, 153);
            swLootFilterActive.Margin = new Padding(0);
            swLootFilterActive.MouseLocation = new Point(-1, -1);
            swLootFilterActive.MouseState = MaterialSkin.MouseState.HOVER;
            swLootFilterActive.Name = "swLootFilterActive";
            swLootFilterActive.Ripple = true;
            swLootFilterActive.Size = new Size(134, 31);
            swLootFilterActive.TabIndex = 45;
            swLootFilterActive.Text = "Active";
            toolTip.SetToolTip(swLootFilterActive, "Only shows items considered 'important' or ones in a filter");
            swLootFilterActive.UseVisualStyleBackColor = true;
            swLootFilterActive.Click += swLootFilterActive_CheckedChanged;
            // 
            // btnAddFilter
            // 
            btnAddFilter.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAddFilter.Density = MaterialButton.MaterialButtonDensity.Default;
            btnAddFilter.Depth = 0;
            btnAddFilter.HighEmphasis = true;
            btnAddFilter.Icon = (Image)resources.GetObject("btnAddFilter.Icon");
            btnAddFilter.Location = new Point(256, 422);
            btnAddFilter.Margin = new Padding(5, 7, 5, 7);
            btnAddFilter.MouseState = MaterialSkin.MouseState.HOVER;
            btnAddFilter.Name = "btnAddFilter";
            btnAddFilter.NoAccentTextColor = Color.Empty;
            btnAddFilter.Size = new Size(81, 36);
            btnAddFilter.TabIndex = 39;
            btnAddFilter.Text = "添加";
            toolTip.SetToolTip(btnAddFilter, "Creates a new loot filter profile");
            btnAddFilter.Type = MaterialButton.MaterialButtonType.Contained;
            btnAddFilter.UseAccentColor = true;
            btnAddFilter.UseVisualStyleBackColor = true;
            btnAddFilter.Click += btnAddFilter_Click;
            // 
            // btnRemoveFilter
            // 
            btnRemoveFilter.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnRemoveFilter.Density = MaterialButton.MaterialButtonDensity.Default;
            btnRemoveFilter.Depth = 0;
            btnRemoveFilter.HighEmphasis = true;
            btnRemoveFilter.Icon = (Image)resources.GetObject("btnRemoveFilter.Icon");
            btnRemoveFilter.Location = new Point(256, 477);
            btnRemoveFilter.Margin = new Padding(5, 7, 5, 7);
            btnRemoveFilter.MouseState = MaterialSkin.MouseState.HOVER;
            btnRemoveFilter.Name = "btnRemoveFilter";
            btnRemoveFilter.NoAccentTextColor = Color.Empty;
            btnRemoveFilter.Size = new Size(81, 36);
            btnRemoveFilter.TabIndex = 40;
            btnRemoveFilter.Text = "移除";
            toolTip.SetToolTip(btnRemoveFilter, "Removes the selected loot filter profile");
            btnRemoveFilter.Type = MaterialButton.MaterialButtonType.Outlined;
            btnRemoveFilter.UseAccentColor = true;
            btnRemoveFilter.UseVisualStyleBackColor = true;
            btnRemoveFilter.Click += btnRemoveFilter_Click;
            // 
            // swMaxEndurance
            // 
            swMaxEndurance.Depth = 0;
            swMaxEndurance.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            swMaxEndurance.Location = new Point(17, 51);
            swMaxEndurance.Margin = new Padding(0);
            swMaxEndurance.MouseLocation = new Point(-1, -1);
            swMaxEndurance.MouseState = MaterialSkin.MouseState.HOVER;
            swMaxEndurance.Name = "swMaxEndurance";
            swMaxEndurance.Ripple = true;
            swMaxEndurance.Size = new Size(157, 31);
            swMaxEndurance.TabIndex = 35;
            swMaxEndurance.Text = "REMOVE";
            toolTip.SetToolTip(swMaxEndurance, "Maximises endurance buffs");
            swMaxEndurance.UseVisualStyleBackColor = true;
            swMaxEndurance.CheckedChanged += swMaxEndurance_CheckedChanged;
            // 
            // swMaxStrength
            // 
            swMaxStrength.Depth = 0;
            swMaxStrength.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            swMaxStrength.Location = new Point(199, 51);
            swMaxStrength.Margin = new Padding(0);
            swMaxStrength.MouseLocation = new Point(-1, -1);
            swMaxStrength.MouseState = MaterialSkin.MouseState.HOVER;
            swMaxStrength.Name = "swMaxStrength";
            swMaxStrength.Ripple = true;
            swMaxStrength.Size = new Size(138, 31);
            swMaxStrength.TabIndex = 36;
            swMaxStrength.Text = "Strength";
            toolTip.SetToolTip(swMaxStrength, "Maximises strength buffs");
            swMaxStrength.UseVisualStyleBackColor = true;
            swMaxStrength.CheckedChanged += swMaxStrength_CheckedChanged;
            // 
            // swMaxVitality
            // 
            swMaxVitality.Depth = 0;
            swMaxVitality.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            swMaxVitality.Location = new Point(429, 51);
            swMaxVitality.Margin = new Padding(0);
            swMaxVitality.MouseLocation = new Point(-1, -1);
            swMaxVitality.MouseState = MaterialSkin.MouseState.HOVER;
            swMaxVitality.Name = "swMaxVitality";
            swMaxVitality.Ripple = true;
            swMaxVitality.Size = new Size(129, 31);
            swMaxVitality.TabIndex = 37;
            swMaxVitality.Text = "Vitality";
            toolTip.SetToolTip(swMaxVitality, "Maximises vitality buffs");
            swMaxVitality.UseVisualStyleBackColor = true;
            swMaxVitality.CheckedChanged += swMaxVitality_CheckedChanged;
            // 
            // swMaxHealth
            // 
            swMaxHealth.Depth = 0;
            swMaxHealth.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            swMaxHealth.Location = new Point(17, 96);
            swMaxHealth.Margin = new Padding(0);
            swMaxHealth.MouseLocation = new Point(-1, -1);
            swMaxHealth.MouseState = MaterialSkin.MouseState.HOVER;
            swMaxHealth.Name = "swMaxHealth";
            swMaxHealth.Ripple = true;
            swMaxHealth.Size = new Size(129, 31);
            swMaxHealth.TabIndex = 38;
            swMaxHealth.Text = "Health";
            toolTip.SetToolTip(swMaxHealth, "Maximises health buffs");
            swMaxHealth.UseVisualStyleBackColor = true;
            swMaxHealth.CheckedChanged += swMaxHealth_CheckedChanged;
            // 
            // swMaxStressResistance
            // 
            swMaxStressResistance.Depth = 0;
            swMaxStressResistance.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            swMaxStressResistance.Location = new Point(199, 96);
            swMaxStressResistance.Margin = new Padding(0);
            swMaxStressResistance.MouseLocation = new Point(-1, -1);
            swMaxStressResistance.MouseState = MaterialSkin.MouseState.HOVER;
            swMaxStressResistance.Name = "swMaxStressResistance";
            swMaxStressResistance.Ripple = true;
            swMaxStressResistance.Size = new Size(214, 31);
            swMaxStressResistance.TabIndex = 39;
            swMaxStressResistance.Text = "Stress Resistance";
            toolTip.SetToolTip(swMaxStressResistance, "Maximises stress resistance buffs\r\n");
            swMaxStressResistance.UseVisualStyleBackColor = true;
            swMaxStressResistance.CheckedChanged += swMaxStressResistance_CheckedChanged;
            // 
            // swMaxMetabolism
            // 
            swMaxMetabolism.Depth = 0;
            swMaxMetabolism.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            swMaxMetabolism.Location = new Point(429, 96);
            swMaxMetabolism.Margin = new Padding(0);
            swMaxMetabolism.MouseLocation = new Point(-1, -1);
            swMaxMetabolism.MouseState = MaterialSkin.MouseState.HOVER;
            swMaxMetabolism.Name = "swMaxMetabolism";
            swMaxMetabolism.Ripple = true;
            swMaxMetabolism.Size = new Size(167, 31);
            swMaxMetabolism.TabIndex = 40;
            swMaxMetabolism.Text = "Metabolism";
            toolTip.SetToolTip(swMaxMetabolism, "Maximises metabolsim buffs\r\n");
            swMaxMetabolism.UseVisualStyleBackColor = true;
            swMaxMetabolism.CheckedChanged += swMaxMetabolism_CheckedChanged;
            // 
            // swMaxImmunity
            // 
            swMaxImmunity.Depth = 0;
            swMaxImmunity.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            swMaxImmunity.Location = new Point(17, 142);
            swMaxImmunity.Margin = new Padding(0);
            swMaxImmunity.MouseLocation = new Point(-1, -1);
            swMaxImmunity.MouseState = MaterialSkin.MouseState.HOVER;
            swMaxImmunity.Name = "swMaxImmunity";
            swMaxImmunity.Ripple = true;
            swMaxImmunity.Size = new Size(149, 31);
            swMaxImmunity.TabIndex = 41;
            swMaxImmunity.Text = "Immunity";
            toolTip.SetToolTip(swMaxImmunity, "Maximises immunity buffs\r\n");
            swMaxImmunity.UseVisualStyleBackColor = true;
            swMaxImmunity.CheckedChanged += swMaxImmunity_CheckedChanged;
            // 
            // swMaxPerception
            // 
            swMaxPerception.Depth = 0;
            swMaxPerception.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            swMaxPerception.Location = new Point(199, 142);
            swMaxPerception.Margin = new Padding(0);
            swMaxPerception.MouseLocation = new Point(-1, -1);
            swMaxPerception.MouseState = MaterialSkin.MouseState.HOVER;
            swMaxPerception.Name = "swMaxPerception";
            swMaxPerception.Ripple = true;
            swMaxPerception.Size = new Size(157, 31);
            swMaxPerception.TabIndex = 42;
            swMaxPerception.Text = "Perception";
            toolTip.SetToolTip(swMaxPerception, "Maximises perception buffs\r\n");
            swMaxPerception.UseVisualStyleBackColor = true;
            swMaxPerception.CheckedChanged += swMaxPerception_CheckedChanged;
            // 
            // swMaxIntellect
            // 
            swMaxIntellect.Depth = 0;
            swMaxIntellect.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            swMaxIntellect.Location = new Point(429, 142);
            swMaxIntellect.Margin = new Padding(0);
            swMaxIntellect.MouseLocation = new Point(-1, -1);
            swMaxIntellect.MouseState = MaterialSkin.MouseState.HOVER;
            swMaxIntellect.Name = "swMaxIntellect";
            swMaxIntellect.Ripple = true;
            swMaxIntellect.Size = new Size(138, 31);
            swMaxIntellect.TabIndex = 43;
            swMaxIntellect.Text = "Intellect";
            toolTip.SetToolTip(swMaxIntellect, "Maximises intellect buffs\r\n");
            swMaxIntellect.UseVisualStyleBackColor = true;
            swMaxIntellect.CheckedChanged += swMaxIntellect_CheckedChanged;
            // 
            // swMaxThrowables
            // 
            swMaxThrowables.Depth = 0;
            swMaxThrowables.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            swMaxThrowables.Location = new Point(429, 187);
            swMaxThrowables.Margin = new Padding(0);
            swMaxThrowables.MouseLocation = new Point(-1, -1);
            swMaxThrowables.MouseState = MaterialSkin.MouseState.HOVER;
            swMaxThrowables.Name = "swMaxThrowables";
            swMaxThrowables.Ripple = true;
            swMaxThrowables.Size = new Size(169, 31);
            swMaxThrowables.TabIndex = 44;
            swMaxThrowables.Text = "Throwables";
            toolTip.SetToolTip(swMaxThrowables, "Maximises throwables buffs\r\n");
            swMaxThrowables.UseVisualStyleBackColor = true;
            swMaxThrowables.CheckedChanged += swMaxThrowables_CheckedChanged;
            // 
            // swMaxSurgery
            // 
            swMaxSurgery.Depth = 0;
            swMaxSurgery.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            swMaxSurgery.Location = new Point(17, 232);
            swMaxSurgery.Margin = new Padding(0);
            swMaxSurgery.MouseLocation = new Point(-1, -1);
            swMaxSurgery.MouseState = MaterialSkin.MouseState.HOVER;
            swMaxSurgery.Name = "swMaxSurgery";
            swMaxSurgery.Ripple = true;
            swMaxSurgery.Size = new Size(133, 31);
            swMaxSurgery.TabIndex = 45;
            swMaxSurgery.Text = "Surgery";
            toolTip.SetToolTip(swMaxSurgery, "Maximises surgery buffs\r\n");
            swMaxSurgery.UseVisualStyleBackColor = true;
            swMaxSurgery.CheckedChanged += swMaxSurgery_CheckedChanged;
            // 
            // swMaxCovertMovement
            // 
            swMaxCovertMovement.Depth = 0;
            swMaxCovertMovement.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            swMaxCovertMovement.Location = new Point(199, 187);
            swMaxCovertMovement.Margin = new Padding(0);
            swMaxCovertMovement.MouseLocation = new Point(-1, -1);
            swMaxCovertMovement.MouseState = MaterialSkin.MouseState.HOVER;
            swMaxCovertMovement.Name = "swMaxCovertMovement";
            swMaxCovertMovement.Ripple = true;
            swMaxCovertMovement.Size = new Size(214, 31);
            swMaxCovertMovement.TabIndex = 46;
            swMaxCovertMovement.Text = "Covert Movement";
            toolTip.SetToolTip(swMaxCovertMovement, "Maximises covert movement buffs\r\n");
            swMaxCovertMovement.UseVisualStyleBackColor = true;
            swMaxCovertMovement.CheckedChanged += swMaxCovertMovement_CheckedChanged;
            // 
            // swMaxSearch
            // 
            swMaxSearch.Depth = 0;
            swMaxSearch.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            swMaxSearch.Location = new Point(199, 232);
            swMaxSearch.Margin = new Padding(0);
            swMaxSearch.MouseLocation = new Point(-1, -1);
            swMaxSearch.MouseState = MaterialSkin.MouseState.HOVER;
            swMaxSearch.Name = "swMaxSearch";
            swMaxSearch.Ripple = true;
            swMaxSearch.Size = new Size(127, 31);
            swMaxSearch.TabIndex = 47;
            swMaxSearch.Text = "Search";
            toolTip.SetToolTip(swMaxSearch, "Maximises search buffs\r\n");
            swMaxSearch.UseVisualStyleBackColor = true;
            swMaxSearch.CheckedChanged += swMaxSearch_CheckedChanged;
            // 
            // swMaxMagDrills
            // 
            swMaxMagDrills.Depth = 0;
            swMaxMagDrills.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            swMaxMagDrills.Location = new Point(429, 232);
            swMaxMagDrills.Margin = new Padding(0);
            swMaxMagDrills.MouseLocation = new Point(-1, -1);
            swMaxMagDrills.MouseState = MaterialSkin.MouseState.HOVER;
            swMaxMagDrills.Name = "swMaxMagDrills";
            swMaxMagDrills.Ripple = true;
            swMaxMagDrills.Size = new Size(154, 31);
            swMaxMagDrills.TabIndex = 48;
            swMaxMagDrills.Text = "Mag Drills";
            toolTip.SetToolTip(swMaxMagDrills, "Maximises mag drills buffs\r\n");
            swMaxMagDrills.UseVisualStyleBackColor = true;
            swMaxMagDrills.CheckedChanged += swMaxMagDrills_CheckedChanged;
            // 
            // swMaxLightVests
            // 
            swMaxLightVests.Depth = 0;
            swMaxLightVests.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            swMaxLightVests.Location = new Point(17, 278);
            swMaxLightVests.Margin = new Padding(0);
            swMaxLightVests.MouseLocation = new Point(-1, -1);
            swMaxLightVests.MouseState = MaterialSkin.MouseState.HOVER;
            swMaxLightVests.Name = "swMaxLightVests";
            swMaxLightVests.Ripple = true;
            swMaxLightVests.Size = new Size(162, 31);
            swMaxLightVests.TabIndex = 49;
            swMaxLightVests.Text = "Light Vests";
            toolTip.SetToolTip(swMaxLightVests, "Maximises light vests buffs\r\n");
            swMaxLightVests.UseVisualStyleBackColor = true;
            swMaxLightVests.CheckedChanged += swMaxLightVests_CheckedChanged;
            // 
            // swMaxHeavyVests
            // 
            swMaxHeavyVests.Depth = 0;
            swMaxHeavyVests.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            swMaxHeavyVests.Location = new Point(199, 278);
            swMaxHeavyVests.Margin = new Padding(0);
            swMaxHeavyVests.MouseLocation = new Point(-1, -1);
            swMaxHeavyVests.MouseState = MaterialSkin.MouseState.HOVER;
            swMaxHeavyVests.Name = "swMaxHeavyVests";
            swMaxHeavyVests.Ripple = true;
            swMaxHeavyVests.Size = new Size(169, 31);
            swMaxHeavyVests.TabIndex = 50;
            swMaxHeavyVests.Text = "Heavy Vests";
            toolTip.SetToolTip(swMaxHeavyVests, "Maximises heavy vests buffs\r\n");
            swMaxHeavyVests.UseVisualStyleBackColor = true;
            swMaxHeavyVests.CheckedChanged += swMaxHeavyVests_CheckedChanged;
            // 
            // swMaxAttention
            // 
            swMaxAttention.Depth = 0;
            swMaxAttention.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            swMaxAttention.Location = new Point(19, 187);
            swMaxAttention.Margin = new Padding(0);
            swMaxAttention.MouseLocation = new Point(-1, -1);
            swMaxAttention.MouseState = MaterialSkin.MouseState.HOVER;
            swMaxAttention.Name = "swMaxAttention";
            swMaxAttention.Ripple = true;
            swMaxAttention.Size = new Size(146, 31);
            swMaxAttention.TabIndex = 51;
            swMaxAttention.Text = "Attention";
            toolTip.SetToolTip(swMaxAttention, "Maximises attention buffs\r\n");
            swMaxAttention.UseVisualStyleBackColor = true;
            swMaxAttention.CheckedChanged += swMaxAttention_CheckedChanged;
            // 
            // swProcessLoot
            // 
            swProcessLoot.Depth = 0;
            swProcessLoot.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            swProcessLoot.Location = new Point(17, 51);
            swProcessLoot.Margin = new Padding(0);
            swProcessLoot.MouseLocation = new Point(-1, -1);
            swProcessLoot.MouseState = MaterialSkin.MouseState.HOVER;
            swProcessLoot.Name = "swProcessLoot";
            swProcessLoot.Ripple = true;
            swProcessLoot.Size = new Size(183, 31);
            swProcessLoot.TabIndex = 40;
            swProcessLoot.Text = "物资显示";
            toolTip.SetToolTip(swProcessLoot, "Enables processing of loot items");
            swProcessLoot.UseVisualStyleBackColor = true;
            swProcessLoot.CheckedChanged += swProcessLoot_CheckedChanged;
            // 
            // swRadarStats
            // 
            swRadarStats.Depth = 0;
            swRadarStats.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            swRadarStats.Location = new Point(17, 96);
            swRadarStats.Margin = new Padding(0);
            swRadarStats.MouseLocation = new Point(-1, -1);
            swRadarStats.MouseState = MaterialSkin.MouseState.HOVER;
            swRadarStats.Name = "swRadarStats";
            swRadarStats.Ripple = true;
            swRadarStats.Size = new Size(165, 31);
            swRadarStats.TabIndex = 31;
            swRadarStats.Text = "显示统计信息";
            toolTip.SetToolTip(swRadarStats, "Shows radar stats on radar tab");
            swRadarStats.UseVisualStyleBackColor = true;
            swRadarStats.CheckedChanged += swRadarStats_CheckedChanged;
            // 
            // swRadarVsync
            // 
            swRadarVsync.Depth = 0;
            swRadarVsync.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            swRadarVsync.Location = new Point(197, 51);
            swRadarVsync.Margin = new Padding(0);
            swRadarVsync.MouseLocation = new Point(-1, -1);
            swRadarVsync.MouseState = MaterialSkin.MouseState.HOVER;
            swRadarVsync.Name = "swRadarVsync";
            swRadarVsync.Ripple = true;
            swRadarVsync.Size = new Size(135, 31);
            swRadarVsync.TabIndex = 32;
            swRadarVsync.Text = "VSync";
            toolTip.SetToolTip(swRadarVsync, "Shows radar stats on radar tab");
            swRadarVsync.UseVisualStyleBackColor = true;
            swRadarVsync.CheckedChanged += swRadarVsync_CheckedChanged;
            // 
            // swRadarEnemyCount
            // 
            swRadarEnemyCount.Depth = 0;
            swRadarEnemyCount.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            swRadarEnemyCount.Location = new Point(197, 96);
            swRadarEnemyCount.Margin = new Padding(0);
            swRadarEnemyCount.MouseLocation = new Point(-1, -1);
            swRadarEnemyCount.MouseState = MaterialSkin.MouseState.HOVER;
            swRadarEnemyCount.Name = "swRadarEnemyCount";
            swRadarEnemyCount.Ripple = true;
            swRadarEnemyCount.Size = new Size(174, 31);
            swRadarEnemyCount.TabIndex = 33;
            swRadarEnemyCount.Text = "敌人统计";
            toolTip.SetToolTip(swRadarEnemyCount, "Shows radar stats on radar tab");
            swRadarEnemyCount.UseVisualStyleBackColor = true;
            swRadarEnemyCount.CheckedChanged += swRadarEnemyCount_CheckedChanged;
            // 
            // sldrFontSize
            // 
            sldrFontSize.Depth = 0;
            sldrFontSize.ForeColor = Color.Black;
            sldrFontSize.Location = new Point(238, 241);
            sldrFontSize.MouseState = MaterialSkin.MouseState.HOVER;
            sldrFontSize.Name = "sldrFontSize";
            sldrFontSize.RangeMax = 36;
            sldrFontSize.RangeMin = 1;
            sldrFontSize.Size = new Size(275, 40);
            sldrFontSize.TabIndex = 39;
            sldrFontSize.Text = "字体大小";
            toolTip.SetToolTip(sldrFontSize, "The font size to use for the text on the radar");
            sldrFontSize.UseAccentColor = true;
            sldrFontSize.Value = 13;
            sldrFontSize.ValueMax = 36;
            sldrFontSize.ValueSuffix = "px";
            sldrFontSize.onValueChanged += sldrFontSize_onValueChanged;
            // 
            // cboFont
            // 
            cboFont.AutoResize = false;
            cboFont.BackColor = Color.FromArgb(255, 255, 255);
            cboFont.Depth = 0;
            cboFont.DrawMode = DrawMode.OwnerDrawVariable;
            cboFont.DropDownHeight = 292;
            cboFont.DropDownStyle = ComboBoxStyle.DropDownList;
            cboFont.DropDownWidth = 121;
            cboFont.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboFont.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboFont.FormattingEnabled = true;
            cboFont.Hint = "字体";
            cboFont.IntegralHeight = false;
            cboFont.ItemHeight = 29;
            cboFont.Items.AddRange(new object[] { "Microsoft YaHei", "SimSun", "SimHei", "KaiTi", "Arial" });
            cboFont.Location = new Point(19, 241);
            cboFont.MaxDropDownItems = 10;
            cboFont.MouseState = MaterialSkin.MouseState.OUT;
            cboFont.Name = "cboFont";
            cboFont.Size = new Size(195, 35);
            cboFont.StartIndex = 0;
            cboFont.TabIndex = 39;
            toolTip.SetToolTip(cboFont, "The item to add to the loot filter");
            cboFont.UseTallSize = false;
            cboFont.SelectedIndexChanged += cboFont_SelectedIndexChanged;
            // 
            // swUnknownQuestItems
            // 
            swUnknownQuestItems.Depth = 0;
            swUnknownQuestItems.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            swUnknownQuestItems.Location = new Point(374, 106);
            swUnknownQuestItems.Margin = new Padding(0);
            swUnknownQuestItems.MouseLocation = new Point(-1, -1);
            swUnknownQuestItems.MouseState = MaterialSkin.MouseState.HOVER;
            swUnknownQuestItems.Name = "swUnknownQuestItems";
            swUnknownQuestItems.Ripple = true;
            swUnknownQuestItems.Size = new Size(251, 31);
            swUnknownQuestItems.TabIndex = 40;
            swUnknownQuestItems.Text = "未知任务项目";
            toolTip.SetToolTip(swUnknownQuestItems, "Displays all active quest tasks/items on the map. Must use 'Show Loot' to display quest items.");
            swUnknownQuestItems.UseVisualStyleBackColor = true;
            swUnknownQuestItems.CheckedChanged += swUnknownQuestItems_CheckedChanged;
            // 
            // sldrThermalColorCoefficient
            // 
            sldrThermalColorCoefficient.Depth = 0;
            sldrThermalColorCoefficient.ForeColor = Color.Black;
            sldrThermalColorCoefficient.Location = new Point(222, 45);
            sldrThermalColorCoefficient.MouseState = MaterialSkin.MouseState.HOVER;
            sldrThermalColorCoefficient.Name = "sldrThermalColorCoefficient";
            sldrThermalColorCoefficient.RangeMin = 1;
            sldrThermalColorCoefficient.Size = new Size(370, 40);
            sldrThermalColorCoefficient.TabIndex = 36;
            sldrThermalColorCoefficient.Text = "颜色";
            sldrThermalColorCoefficient.UseAccentColor = true;
            sldrThermalColorCoefficient.Value = 30;
            sldrThermalColorCoefficient.ValueMax = 100;
            sldrThermalColorCoefficient.onValueChanged += sldrThermalColorCoefficient_onValueChanged;
            // 
            // sldrMinTemperature
            // 
            sldrMinTemperature.Depth = 0;
            sldrMinTemperature.ForeColor = Color.Black;
            sldrMinTemperature.Location = new Point(222, 91);
            sldrMinTemperature.MouseState = MaterialSkin.MouseState.HOVER;
            sldrMinTemperature.Name = "sldrMinTemperature";
            sldrMinTemperature.RangeMin = 1;
            sldrMinTemperature.Size = new Size(370, 40);
            sldrMinTemperature.TabIndex = 35;
            sldrMinTemperature.Text = "Min Temperature";
            sldrMinTemperature.UseAccentColor = true;
            sldrMinTemperature.Value = 30;
            sldrMinTemperature.ValueMax = 100;
            sldrMinTemperature.onValueChanged += sldrMinTemperature_onValueChanged;
            // 
            // sldrThermalRampShift
            // 
            sldrThermalRampShift.Depth = 0;
            sldrThermalRampShift.ForeColor = Color.Black;
            sldrThermalRampShift.Location = new Point(222, 136);
            sldrThermalRampShift.MouseState = MaterialSkin.MouseState.HOVER;
            sldrThermalRampShift.Name = "sldrThermalRampShift";
            sldrThermalRampShift.RangeMin = 1;
            sldrThermalRampShift.Size = new Size(370, 40);
            sldrThermalRampShift.TabIndex = 30;
            sldrThermalRampShift.Text = "Ramp Shift";
            sldrThermalRampShift.UseAccentColor = true;
            sldrThermalRampShift.Value = 30;
            sldrThermalRampShift.ValueMax = 100;
            sldrThermalRampShift.onValueChanged += sldrThermalRampShift_onValueChanged;
            // 
            // tabControlMain
            // 
            tabControlMain.Controls.Add(tabRadar);
            tabControlMain.Controls.Add(tabSettings);
            tabControlMain.Controls.Add(tabPlayerLoadouts);
            tabControlMain.Controls.Add(tabWatchlist);
            tabControlMain.Controls.Add(tabLootFilter);
            tabControlMain.Controls.Add(tabPageLootList);
            tabControlMain.Depth = 0;
            tabControlMain.Dock = DockStyle.Fill;
            tabControlMain.ImageList = iconList;
            tabControlMain.Location = new Point(0, 27);
            tabControlMain.Margin = new Padding(0);
            tabControlMain.MouseState = MaterialSkin.MouseState.HOVER;
            tabControlMain.Multiline = true;
            tabControlMain.Name = "tabControlMain";
            tabControlMain.SelectedIndex = 0;
            tabControlMain.Size = new Size(1491, 846);
            tabControlMain.TabIndex = 10;
            tabControlMain.SelectedIndexChanged += TabControl_SelectedIndexChanged;
            // 
            // tabRadar
            // 
            tabRadar.BackColor = Color.White;
            tabRadar.Controls.Add(mcRadarEnemyStats);
            tabRadar.Controls.Add(mcRadarStats);
            tabRadar.Controls.Add(mcRadarSettings);
            tabRadar.Controls.Add(mcRadarMapSetup);
            tabRadar.Controls.Add(skMapCanvas);
            tabRadar.ImageKey = "radar.png";
            tabRadar.Location = new Point(4, 39);
            tabRadar.Name = "tabRadar";
            tabRadar.Padding = new Padding(3);
            tabRadar.Size = new Size(1483, 803);
            tabRadar.TabIndex = 0;
            tabRadar.Text = "雷达";
            // 
            // mcRadarEnemyStats
            // 
            mcRadarEnemyStats.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            mcRadarEnemyStats.BackColor = Color.FromArgb(255, 255, 255);
            mcRadarEnemyStats.Controls.Add(lblRadarBossesValue);
            mcRadarEnemyStats.Controls.Add(lblRadarPlayerScavsValue);
            mcRadarEnemyStats.Controls.Add(lblRadarBosses);
            mcRadarEnemyStats.Controls.Add(lblRadarPlayerScavs);
            mcRadarEnemyStats.Controls.Add(lblRadarRoguesValue);
            mcRadarEnemyStats.Controls.Add(lblRadarAIScavsValue);
            mcRadarEnemyStats.Controls.Add(lblRadarPMCsValue);
            mcRadarEnemyStats.Controls.Add(lblRadarRogues);
            mcRadarEnemyStats.Controls.Add(lblRadarAIScavs);
            mcRadarEnemyStats.Controls.Add(lblRadarPMCs);
            mcRadarEnemyStats.Depth = 0;
            mcRadarEnemyStats.ForeColor = Color.FromArgb(222, 0, 0, 0);
            mcRadarEnemyStats.Location = new Point(1245, 705);
            mcRadarEnemyStats.Margin = new Padding(16);
            mcRadarEnemyStats.MouseState = MaterialSkin.MouseState.HOVER;
            mcRadarEnemyStats.Name = "mcRadarEnemyStats";
            mcRadarEnemyStats.Padding = new Padding(16);
            mcRadarEnemyStats.Size = new Size(112, 86);
            mcRadarEnemyStats.TabIndex = 49;
            mcRadarEnemyStats.Visible = false;
            // 
            // lblRadarBossesValue
            // 
            lblRadarBossesValue.AutoSize = true;
            lblRadarBossesValue.Depth = 0;
            lblRadarBossesValue.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblRadarBossesValue.FontType = MaterialSkin.MaterialSkinManager.fontType.Caption;
            lblRadarBossesValue.Location = new Point(91, 67);
            lblRadarBossesValue.MouseState = MaterialSkin.MouseState.HOVER;
            lblRadarBossesValue.Name = "lblRadarBossesValue";
            lblRadarBossesValue.Size = new Size(8, 14);
            lblRadarBossesValue.TabIndex = 8;
            lblRadarBossesValue.Text = "0";
            // 
            // lblRadarPlayerScavsValue
            // 
            lblRadarPlayerScavsValue.AutoSize = true;
            lblRadarPlayerScavsValue.Depth = 0;
            lblRadarPlayerScavsValue.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblRadarPlayerScavsValue.FontType = MaterialSkin.MaterialSkinManager.fontType.Caption;
            lblRadarPlayerScavsValue.Location = new Point(91, 20);
            lblRadarPlayerScavsValue.MouseState = MaterialSkin.MouseState.HOVER;
            lblRadarPlayerScavsValue.Name = "lblRadarPlayerScavsValue";
            lblRadarPlayerScavsValue.Size = new Size(8, 14);
            lblRadarPlayerScavsValue.TabIndex = 10;
            lblRadarPlayerScavsValue.Text = "0";
            // 
            // lblRadarBosses
            // 
            lblRadarBosses.AutoSize = true;
            lblRadarBosses.Depth = 0;
            lblRadarBosses.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblRadarBosses.FontType = MaterialSkin.MaterialSkinManager.fontType.Caption;
            lblRadarBosses.Location = new Point(40, 65);
            lblRadarBosses.MouseState = MaterialSkin.MouseState.HOVER;
            lblRadarBosses.Name = "lblRadarBosses";
            lblRadarBosses.Size = new Size(34, 14);
            lblRadarBosses.TabIndex = 1;
            lblRadarBosses.Text = "BOOS:";
            // 
            // lblRadarPlayerScavs
            // 
            lblRadarPlayerScavs.AutoSize = true;
            lblRadarPlayerScavs.Depth = 0;
            lblRadarPlayerScavs.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblRadarPlayerScavs.FontType = MaterialSkin.MaterialSkinManager.fontType.Caption;
            lblRadarPlayerScavs.Location = new Point(7, 20);
            lblRadarPlayerScavs.MouseState = MaterialSkin.MouseState.HOVER;
            lblRadarPlayerScavs.Name = "lblRadarPlayerScavs";
            lblRadarPlayerScavs.Size = new Size(63, 14);
            lblRadarPlayerScavs.TabIndex = 9;
            lblRadarPlayerScavs.Text = "玩家 Scavs:";
            // 
            // lblRadarRoguesValue
            // 
            lblRadarRoguesValue.AutoSize = true;
            lblRadarRoguesValue.Depth = 0;
            lblRadarRoguesValue.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblRadarRoguesValue.FontType = MaterialSkin.MaterialSkinManager.fontType.Caption;
            lblRadarRoguesValue.Location = new Point(91, 51);
            lblRadarRoguesValue.MouseState = MaterialSkin.MouseState.HOVER;
            lblRadarRoguesValue.Name = "lblRadarRoguesValue";
            lblRadarRoguesValue.Size = new Size(8, 14);
            lblRadarRoguesValue.TabIndex = 7;
            lblRadarRoguesValue.Text = "0";
            // 
            // lblRadarAIScavsValue
            // 
            lblRadarAIScavsValue.AutoSize = true;
            lblRadarAIScavsValue.Depth = 0;
            lblRadarAIScavsValue.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblRadarAIScavsValue.FontType = MaterialSkin.MaterialSkinManager.fontType.Caption;
            lblRadarAIScavsValue.Location = new Point(91, 35);
            lblRadarAIScavsValue.MouseState = MaterialSkin.MouseState.HOVER;
            lblRadarAIScavsValue.Name = "lblRadarAIScavsValue";
            lblRadarAIScavsValue.Size = new Size(8, 14);
            lblRadarAIScavsValue.TabIndex = 6;
            lblRadarAIScavsValue.Text = "0";
            // 
            // lblRadarPMCsValue
            // 
            lblRadarPMCsValue.AutoSize = true;
            lblRadarPMCsValue.Depth = 0;
            lblRadarPMCsValue.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblRadarPMCsValue.FontType = MaterialSkin.MaterialSkinManager.fontType.Caption;
            lblRadarPMCsValue.Location = new Point(91, 3);
            lblRadarPMCsValue.MouseState = MaterialSkin.MouseState.HOVER;
            lblRadarPMCsValue.Name = "lblRadarPMCsValue";
            lblRadarPMCsValue.Size = new Size(8, 14);
            lblRadarPMCsValue.TabIndex = 5;
            lblRadarPMCsValue.Text = "0";
            // 
            // lblRadarRogues
            // 
            lblRadarRogues.AutoSize = true;
            lblRadarRogues.Depth = 0;
            lblRadarRogues.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblRadarRogues.FontType = MaterialSkin.MaterialSkinManager.fontType.Caption;
            lblRadarRogues.Location = new Point(29, 51);
            lblRadarRogues.MouseState = MaterialSkin.MouseState.HOVER;
            lblRadarRogues.Name = "lblRadarRogues";
            lblRadarRogues.Size = new Size(44, 14);
            lblRadarRogues.TabIndex = 3;
            lblRadarRogues.Text = "Rogues:";
            // 
            // lblRadarAIScavs
            // 
            lblRadarAIScavs.AutoSize = true;
            lblRadarAIScavs.Depth = 0;
            lblRadarAIScavs.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblRadarAIScavs.FontType = MaterialSkin.MaterialSkinManager.fontType.Caption;
            lblRadarAIScavs.Location = new Point(7, 35);
            lblRadarAIScavs.MouseState = MaterialSkin.MouseState.HOVER;
            lblRadarAIScavs.Name = "lblRadarAIScavs";
            lblRadarAIScavs.Size = new Size(63, 14);
            lblRadarAIScavs.TabIndex = 2;
            lblRadarAIScavs.Text = "人机 Scavs:";
            // 
            // lblRadarPMCs
            // 
            lblRadarPMCs.AutoSize = true;
            lblRadarPMCs.Depth = 0;
            lblRadarPMCs.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblRadarPMCs.FontType = MaterialSkin.MaterialSkinManager.fontType.Caption;
            lblRadarPMCs.Location = new Point(47, 3);
            lblRadarPMCs.MouseState = MaterialSkin.MouseState.HOVER;
            lblRadarPMCs.Name = "lblRadarPMCs";
            lblRadarPMCs.Size = new Size(28, 14);
            lblRadarPMCs.TabIndex = 0;
            lblRadarPMCs.Text = "玩家:";
            // 
            // mcRadarStats
            // 
            mcRadarStats.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            mcRadarStats.BackColor = Color.FromArgb(255, 255, 255);
            mcRadarStats.Controls.Add(lblRadarCorpsesValue);
            mcRadarStats.Controls.Add(lblRadarCorpses);
            mcRadarStats.Controls.Add(lblRadarMemSValue);
            mcRadarStats.Controls.Add(lblRadarMemS);
            mcRadarStats.Controls.Add(lblRadarContainersValue);
            mcRadarStats.Controls.Add(lblRadarLooseLootValue);
            mcRadarStats.Controls.Add(lblRadarFPSValue);
            mcRadarStats.Controls.Add(lblRadarContainers);
            mcRadarStats.Controls.Add(lblRadarLooseLoot);
            mcRadarStats.Controls.Add(lblRadarFPS);
            mcRadarStats.Depth = 0;
            mcRadarStats.ForeColor = Color.FromArgb(222, 0, 0, 0);
            mcRadarStats.Location = new Point(1360, 705);
            mcRadarStats.Margin = new Padding(16);
            mcRadarStats.MouseState = MaterialSkin.MouseState.HOVER;
            mcRadarStats.Name = "mcRadarStats";
            mcRadarStats.Padding = new Padding(16);
            mcRadarStats.Size = new Size(117, 86);
            mcRadarStats.TabIndex = 36;
            mcRadarStats.Visible = false;
            // 
            // lblRadarCorpsesValue
            // 
            lblRadarCorpsesValue.AutoSize = true;
            lblRadarCorpsesValue.Depth = 0;
            lblRadarCorpsesValue.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblRadarCorpsesValue.FontType = MaterialSkin.MaterialSkinManager.fontType.Caption;
            lblRadarCorpsesValue.Location = new Point(82, 67);
            lblRadarCorpsesValue.MouseState = MaterialSkin.MouseState.HOVER;
            lblRadarCorpsesValue.Name = "lblRadarCorpsesValue";
            lblRadarCorpsesValue.Size = new Size(8, 14);
            lblRadarCorpsesValue.TabIndex = 8;
            lblRadarCorpsesValue.Text = "0";
            // 
            // lblRadarCorpses
            // 
            lblRadarCorpses.AutoSize = true;
            lblRadarCorpses.Depth = 0;
            lblRadarCorpses.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblRadarCorpses.FontType = MaterialSkin.MaterialSkinManager.fontType.Caption;
            lblRadarCorpses.Location = new Point(43, 67);
            lblRadarCorpses.MouseState = MaterialSkin.MouseState.HOVER;
            lblRadarCorpses.Name = "lblRadarCorpses";
            lblRadarCorpses.Size = new Size(28, 14);
            lblRadarCorpses.TabIndex = 1;
            lblRadarCorpses.Text = "尸体:";
            // 
            // lblRadarMemSValue
            // 
            lblRadarMemSValue.AutoSize = true;
            lblRadarMemSValue.Depth = 0;
            lblRadarMemSValue.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblRadarMemSValue.FontType = MaterialSkin.MaterialSkinManager.fontType.Caption;
            lblRadarMemSValue.Location = new Point(82, 20);
            lblRadarMemSValue.MouseState = MaterialSkin.MouseState.HOVER;
            lblRadarMemSValue.Name = "lblRadarMemSValue";
            lblRadarMemSValue.Size = new Size(8, 14);
            lblRadarMemSValue.TabIndex = 10;
            lblRadarMemSValue.Text = "0";
            // 
            // lblRadarMemS
            // 
            lblRadarMemS.AutoSize = true;
            lblRadarMemS.Depth = 0;
            lblRadarMemS.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblRadarMemS.FontType = MaterialSkin.MaterialSkinManager.fontType.Caption;
            lblRadarMemS.Location = new Point(27, 20);
            lblRadarMemS.MouseState = MaterialSkin.MouseState.HOVER;
            lblRadarMemS.Name = "lblRadarMemS";
            lblRadarMemS.Size = new Size(42, 14);
            lblRadarMemS.TabIndex = 9;
            lblRadarMemS.Text = "Mem/s:";
            // 
            // lblRadarContainersValue
            // 
            lblRadarContainersValue.AutoSize = true;
            lblRadarContainersValue.Depth = 0;
            lblRadarContainersValue.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblRadarContainersValue.FontType = MaterialSkin.MaterialSkinManager.fontType.Caption;
            lblRadarContainersValue.Location = new Point(82, 51);
            lblRadarContainersValue.MouseState = MaterialSkin.MouseState.HOVER;
            lblRadarContainersValue.Name = "lblRadarContainersValue";
            lblRadarContainersValue.Size = new Size(8, 14);
            lblRadarContainersValue.TabIndex = 7;
            lblRadarContainersValue.Text = "0";
            // 
            // lblRadarLooseLootValue
            // 
            lblRadarLooseLootValue.AutoSize = true;
            lblRadarLooseLootValue.Depth = 0;
            lblRadarLooseLootValue.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblRadarLooseLootValue.FontType = MaterialSkin.MaterialSkinManager.fontType.Caption;
            lblRadarLooseLootValue.Location = new Point(82, 35);
            lblRadarLooseLootValue.MouseState = MaterialSkin.MouseState.HOVER;
            lblRadarLooseLootValue.Name = "lblRadarLooseLootValue";
            lblRadarLooseLootValue.Size = new Size(8, 14);
            lblRadarLooseLootValue.TabIndex = 6;
            lblRadarLooseLootValue.Text = "0";
            // 
            // lblRadarFPSValue
            // 
            lblRadarFPSValue.AutoSize = true;
            lblRadarFPSValue.Depth = 0;
            lblRadarFPSValue.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblRadarFPSValue.FontType = MaterialSkin.MaterialSkinManager.fontType.Caption;
            lblRadarFPSValue.Location = new Point(82, 3);
            lblRadarFPSValue.MouseState = MaterialSkin.MouseState.HOVER;
            lblRadarFPSValue.Name = "lblRadarFPSValue";
            lblRadarFPSValue.Size = new Size(8, 14);
            lblRadarFPSValue.TabIndex = 5;
            lblRadarFPSValue.Text = "0";
            // 
            // lblRadarContainers
            // 
            lblRadarContainers.AutoSize = true;
            lblRadarContainers.Depth = 0;
            lblRadarContainers.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblRadarContainers.FontType = MaterialSkin.MaterialSkinManager.fontType.Caption;
            lblRadarContainers.Location = new Point(43, 51);
            lblRadarContainers.MouseState = MaterialSkin.MouseState.HOVER;
            lblRadarContainers.Name = "lblRadarContainers";
            lblRadarContainers.Size = new Size(28, 14);
            lblRadarContainers.TabIndex = 3;
            lblRadarContainers.Text = "容器:";
            // 
            // lblRadarLooseLoot
            // 
            lblRadarLooseLoot.AutoSize = true;
            lblRadarLooseLoot.Depth = 0;
            lblRadarLooseLoot.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblRadarLooseLoot.FontType = MaterialSkin.MaterialSkinManager.fontType.Caption;
            lblRadarLooseLoot.Location = new Point(16, 37);
            lblRadarLooseLoot.MouseState = MaterialSkin.MouseState.HOVER;
            lblRadarLooseLoot.Name = "lblRadarLooseLoot";
            lblRadarLooseLoot.Size = new Size(52, 14);
            lblRadarLooseLoot.TabIndex = 2;
            lblRadarLooseLoot.Text = "地上物资:";
            // 
            // lblRadarFPS
            // 
            lblRadarFPS.AutoSize = true;
            lblRadarFPS.Depth = 0;
            lblRadarFPS.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblRadarFPS.FontType = MaterialSkin.MaterialSkinManager.fontType.Caption;
            lblRadarFPS.Location = new Point(6, 3);
            lblRadarFPS.MouseState = MaterialSkin.MouseState.HOVER;
            lblRadarFPS.Name = "lblRadarFPS";
            lblRadarFPS.Size = new Size(64, 14);
            lblRadarFPS.TabIndex = 0;
            lblRadarFPS.Text = "雷达刷新率:";
            // 
            // mcRadarSettings
            // 
            mcRadarSettings.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            mcRadarSettings.BackColor = Color.FromArgb(255, 255, 255);
            mcRadarSettings.Controls.Add(btnToggleMapFree);
            mcRadarSettings.Depth = 0;
            mcRadarSettings.ForeColor = Color.FromArgb(222, 0, 0, 0);
            mcRadarSettings.Location = new Point(1341, 6);
            mcRadarSettings.Margin = new Padding(16);
            mcRadarSettings.MouseState = MaterialSkin.MouseState.HOVER;
            mcRadarSettings.Name = "mcRadarSettings";
            mcRadarSettings.Padding = new Padding(16);
            mcRadarSettings.Size = new Size(136, 52);
            mcRadarSettings.TabIndex = 48;
            // 
            // mcRadarMapSetup
            // 
            mcRadarMapSetup.BackColor = Color.FromArgb(255, 255, 255);
            mcRadarMapSetup.Controls.Add(btnMapSetupApply);
            mcRadarMapSetup.Controls.Add(txtMapSetupScale);
            mcRadarMapSetup.Controls.Add(txtMapSetupY);
            mcRadarMapSetup.Controls.Add(txtMapSetupX);
            mcRadarMapSetup.Controls.Add(lblRadarMapSetup);
            mcRadarMapSetup.Depth = 0;
            mcRadarMapSetup.ForeColor = Color.FromArgb(222, 0, 0, 0);
            mcRadarMapSetup.Location = new Point(12, 731);
            mcRadarMapSetup.Margin = new Padding(16);
            mcRadarMapSetup.MouseState = MaterialSkin.MouseState.HOVER;
            mcRadarMapSetup.Name = "mcRadarMapSetup";
            mcRadarMapSetup.Padding = new Padding(16);
            mcRadarMapSetup.Size = new Size(371, 60);
            mcRadarMapSetup.TabIndex = 18;
            mcRadarMapSetup.Visible = false;
            // 
            // lblRadarMapSetup
            // 
            lblRadarMapSetup.AutoSize = true;
            lblRadarMapSetup.Depth = 0;
            lblRadarMapSetup.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblRadarMapSetup.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1;
            lblRadarMapSetup.HighEmphasis = true;
            lblRadarMapSetup.Location = new Point(125, 0);
            lblRadarMapSetup.MouseState = MaterialSkin.MouseState.HOVER;
            lblRadarMapSetup.Name = "lblRadarMapSetup";
            lblRadarMapSetup.Size = new Size(65, 19);
            lblRadarMapSetup.TabIndex = 31;
            lblRadarMapSetup.Text = "坐标设置";
            lblRadarMapSetup.UseAccent = true;
            lblRadarMapSetup.Click += lblRadarMapSetup_Click;
            // 
            // skMapCanvas
            // 
            skMapCanvas.BackColor = Color.Brown;
            skMapCanvas.Dock = DockStyle.Fill;
            skMapCanvas.Location = new Point(3, 3);
            skMapCanvas.Margin = new Padding(5, 3, 5, 3);
            skMapCanvas.Name = "skMapCanvas";
            skMapCanvas.Size = new Size(1477, 797);
            skMapCanvas.TabIndex = 13;
            skMapCanvas.VSync = true;
            skMapCanvas.PaintSurface += skMapCanvas_PaintSurface;
            skMapCanvas.MouseDown += skMapCanvas_MouseDown;
            skMapCanvas.MouseMove += skMapCanvas_MouseMovePlayer;
            skMapCanvas.MouseUp += skMapCanvas_MouseUp;
            // 
            // tabSettings
            // 
            tabSettings.BackColor = Color.White;
            tabSettings.Controls.Add(tabSelector);
            tabSettings.Controls.Add(tabControlSettings);
            tabSettings.ImageKey = "settings.png";
            tabSettings.Location = new Point(4, 39);
            tabSettings.Margin = new Padding(0);
            tabSettings.Name = "tabSettings";
            tabSettings.Size = new Size(1483, 803);
            tabSettings.TabIndex = 1;
            tabSettings.Text = "雷达设置";
            // 
            // tabSelector
            // 
            tabSelector.BaseTabControl = tabControlSettings;
            tabSelector.CharacterCasing = MaterialTabSelector.CustomCharacterCasing.Normal;
            tabSelector.Depth = 0;
            tabSelector.Dock = DockStyle.Top;
            tabSelector.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            tabSelector.Location = new Point(0, 0);
            tabSelector.Margin = new Padding(0);
            tabSelector.MouseState = MaterialSkin.MouseState.HOVER;
            tabSelector.Name = "tabSelector";
            tabSelector.Size = new Size(1483, 41);
            tabSelector.TabIndex = 29;
            tabSelector.TabIndicatorHeight = 1;
            tabSelector.Text = "雷达设置";
            tabSelector.Click += tabSelector_Click;
            // 
            // tabControlSettings
            // 
            tabControlSettings.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            tabControlSettings.Controls.Add(tabSettingsGeneral);
            tabControlSettings.Controls.Add(tabSettingsMemoryWriting);
            tabControlSettings.Controls.Add(tabSettingsLoot);
            tabControlSettings.Controls.Add(tabSettingsAIFactions);
            tabControlSettings.Controls.Add(tabSettingsColors);
            tabControlSettings.Depth = 0;
            tabControlSettings.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tabControlSettings.Location = new Point(0, 41);
            tabControlSettings.Margin = new Padding(0);
            tabControlSettings.MouseState = MaterialSkin.MouseState.HOVER;
            tabControlSettings.Multiline = true;
            tabControlSettings.Name = "tabControlSettings";
            tabControlSettings.SelectedIndex = 0;
            tabControlSettings.Size = new Size(1473, 756);
            tabControlSettings.TabIndex = 28;
            // 
            // tabSettingsGeneral
            // 
            tabSettingsGeneral.BackColor = Color.White;
            tabSettingsGeneral.Controls.Add(mcSettingsGeneralUI);
            tabSettingsGeneral.Controls.Add(mcSettingsGeneralRadar);
            tabSettingsGeneral.ImageKey = "(none)";
            tabSettingsGeneral.Location = new Point(4, 29);
            tabSettingsGeneral.Margin = new Padding(0);
            tabSettingsGeneral.Name = "tabSettingsGeneral";
            tabSettingsGeneral.Size = new Size(1465, 723);
            tabSettingsGeneral.TabIndex = 0;
            tabSettingsGeneral.Text = "雷达设置";
            // 
            // mcSettingsGeneralUI
            // 
            mcSettingsGeneralUI.BackColor = Color.FromArgb(255, 255, 255);
            mcSettingsGeneralUI.Controls.Add(swUnknownQuestItems);
            mcSettingsGeneralUI.Controls.Add(cboFont);
            mcSettingsGeneralUI.Controls.Add(sldrFontSize);
            mcSettingsGeneralUI.Controls.Add(txtTeammateID);
            mcSettingsGeneralUI.Controls.Add(lblSettingsGeneralUI);
            mcSettingsGeneralUI.Controls.Add(sldrZoomDistance);
            mcSettingsGeneralUI.Controls.Add(sldrUIScale);
            mcSettingsGeneralUI.Controls.Add(sldrAimlineLength);
            mcSettingsGeneralUI.Controls.Add(swExfilNames);
            mcSettingsGeneralUI.Controls.Add(swQuestHelper);
            mcSettingsGeneralUI.Controls.Add(swHoverArmor);
            mcSettingsGeneralUI.Controls.Add(swNames);
            mcSettingsGeneralUI.Controls.Add(swAimview);
            mcSettingsGeneralUI.Controls.Add(swShowLoot);
            mcSettingsGeneralUI.Depth = 0;
            mcSettingsGeneralUI.ForeColor = Color.FromArgb(222, 0, 0, 0);
            mcSettingsGeneralUI.Location = new Point(17, 188);
            mcSettingsGeneralUI.Margin = new Padding(16);
            mcSettingsGeneralUI.MouseState = MaterialSkin.MouseState.HOVER;
            mcSettingsGeneralUI.Name = "mcSettingsGeneralUI";
            mcSettingsGeneralUI.Padding = new Padding(16);
            mcSettingsGeneralUI.Size = new Size(723, 306);
            mcSettingsGeneralUI.TabIndex = 31;
            // 
            // lblSettingsGeneralUI
            // 
            lblSettingsGeneralUI.AutoSize = true;
            lblSettingsGeneralUI.Depth = 0;
            lblSettingsGeneralUI.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            lblSettingsGeneralUI.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            lblSettingsGeneralUI.HighEmphasis = true;
            lblSettingsGeneralUI.Location = new Point(19, 14);
            lblSettingsGeneralUI.MouseState = MaterialSkin.MouseState.HOVER;
            lblSettingsGeneralUI.Name = "lblSettingsGeneralUI";
            lblSettingsGeneralUI.Size = new Size(81, 24);
            lblSettingsGeneralUI.TabIndex = 33;
            lblSettingsGeneralUI.Text = "用户界面";
            lblSettingsGeneralUI.UseAccent = true;
            // 
            // mcSettingsGeneralRadar
            // 
            mcSettingsGeneralRadar.BackColor = Color.FromArgb(255, 255, 255);
            mcSettingsGeneralRadar.Controls.Add(swRadarEnemyCount);
            mcSettingsGeneralRadar.Controls.Add(swRadarVsync);
            mcSettingsGeneralRadar.Controls.Add(swRadarStats);
            mcSettingsGeneralRadar.Controls.Add(lblSettingsGeneralRadar);
            mcSettingsGeneralRadar.Controls.Add(btnRestartRadar);
            mcSettingsGeneralRadar.Controls.Add(btnToggleMap);
            mcSettingsGeneralRadar.Controls.Add(swMapHelper);
            mcSettingsGeneralRadar.Depth = 0;
            mcSettingsGeneralRadar.ForeColor = Color.FromArgb(222, 0, 0, 0);
            mcSettingsGeneralRadar.Location = new Point(17, 16);
            mcSettingsGeneralRadar.Margin = new Padding(16);
            mcSettingsGeneralRadar.MouseState = MaterialSkin.MouseState.HOVER;
            mcSettingsGeneralRadar.Name = "mcSettingsGeneralRadar";
            mcSettingsGeneralRadar.Padding = new Padding(16);
            mcSettingsGeneralRadar.Size = new Size(723, 154);
            mcSettingsGeneralRadar.TabIndex = 30;
            // 
            // lblSettingsGeneralRadar
            // 
            lblSettingsGeneralRadar.AutoSize = true;
            lblSettingsGeneralRadar.Depth = 0;
            lblSettingsGeneralRadar.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            lblSettingsGeneralRadar.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            lblSettingsGeneralRadar.HighEmphasis = true;
            lblSettingsGeneralRadar.Location = new Point(19, 17);
            lblSettingsGeneralRadar.MouseState = MaterialSkin.MouseState.HOVER;
            lblSettingsGeneralRadar.Name = "lblSettingsGeneralRadar";
            lblSettingsGeneralRadar.Size = new Size(81, 24);
            lblSettingsGeneralRadar.TabIndex = 30;
            lblSettingsGeneralRadar.Text = "雷达选项";
            lblSettingsGeneralRadar.UseAccent = true;
            // 
            // tabSettingsMemoryWriting
            // 
            tabSettingsMemoryWriting.BackColor = Color.White;
            tabSettingsMemoryWriting.Controls.Add(mcSettingsMemoryWritingSkillBuffs);
            tabSettingsMemoryWriting.Controls.Add(mcSettingsMemoryWritingThermal);
            tabSettingsMemoryWriting.Controls.Add(swMasterSwitch);
            tabSettingsMemoryWriting.Controls.Add(mcSettingsMemoryWritingGlobal);
            tabSettingsMemoryWriting.Controls.Add(mcSettingsMemoryWritingGear);
            tabSettingsMemoryWriting.Location = new Point(4, 29);
            tabSettingsMemoryWriting.Name = "tabSettingsMemoryWriting";
            tabSettingsMemoryWriting.Padding = new Padding(3);
            tabSettingsMemoryWriting.Size = new Size(1465, 723);
            tabSettingsMemoryWriting.TabIndex = 1;
            tabSettingsMemoryWriting.Text = "内存功能（危险）";
            // 
            // mcSettingsMemoryWritingSkillBuffs
            // 
            mcSettingsMemoryWritingSkillBuffs.BackColor = Color.FromArgb(255, 255, 255);
            mcSettingsMemoryWritingSkillBuffs.Controls.Add(swMaxAttention);
            mcSettingsMemoryWritingSkillBuffs.Controls.Add(swMaxHeavyVests);
            mcSettingsMemoryWritingSkillBuffs.Controls.Add(swMaxLightVests);
            mcSettingsMemoryWritingSkillBuffs.Controls.Add(swMaxMagDrills);
            mcSettingsMemoryWritingSkillBuffs.Controls.Add(swMaxSearch);
            mcSettingsMemoryWritingSkillBuffs.Controls.Add(swMaxCovertMovement);
            mcSettingsMemoryWritingSkillBuffs.Controls.Add(swMaxSurgery);
            mcSettingsMemoryWritingSkillBuffs.Controls.Add(swMaxThrowables);
            mcSettingsMemoryWritingSkillBuffs.Controls.Add(swMaxIntellect);
            mcSettingsMemoryWritingSkillBuffs.Controls.Add(swMaxPerception);
            mcSettingsMemoryWritingSkillBuffs.Controls.Add(swMaxImmunity);
            mcSettingsMemoryWritingSkillBuffs.Controls.Add(swMaxMetabolism);
            mcSettingsMemoryWritingSkillBuffs.Controls.Add(swMaxStressResistance);
            mcSettingsMemoryWritingSkillBuffs.Controls.Add(swMaxHealth);
            mcSettingsMemoryWritingSkillBuffs.Controls.Add(swMaxVitality);
            mcSettingsMemoryWritingSkillBuffs.Controls.Add(swMaxStrength);
            mcSettingsMemoryWritingSkillBuffs.Controls.Add(sldrJumpStrength);
            mcSettingsMemoryWritingSkillBuffs.Controls.Add(sldrThrowStrength);
            mcSettingsMemoryWritingSkillBuffs.Controls.Add(sldrMagDrillsSpeed);
            mcSettingsMemoryWritingSkillBuffs.Controls.Add(swMaxEndurance);
            mcSettingsMemoryWritingSkillBuffs.Controls.Add(lblSettingsMemoryWritingSkills);
            mcSettingsMemoryWritingSkillBuffs.Depth = 0;
            mcSettingsMemoryWritingSkillBuffs.ForeColor = Color.FromArgb(222, 0, 0, 0);
            mcSettingsMemoryWritingSkillBuffs.Location = new Point(655, 64);
            mcSettingsMemoryWritingSkillBuffs.Margin = new Padding(16);
            mcSettingsMemoryWritingSkillBuffs.MouseState = MaterialSkin.MouseState.HOVER;
            mcSettingsMemoryWritingSkillBuffs.Name = "mcSettingsMemoryWritingSkillBuffs";
            mcSettingsMemoryWritingSkillBuffs.Padding = new Padding(16);
            mcSettingsMemoryWritingSkillBuffs.Size = new Size(606, 405);
            mcSettingsMemoryWritingSkillBuffs.TabIndex = 42;
            // 
            // lblSettingsMemoryWritingSkills
            // 
            lblSettingsMemoryWritingSkills.AutoSize = true;
            lblSettingsMemoryWritingSkills.Depth = 0;
            lblSettingsMemoryWritingSkills.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            lblSettingsMemoryWritingSkills.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            lblSettingsMemoryWritingSkills.HighEmphasis = true;
            lblSettingsMemoryWritingSkills.Location = new Point(19, 14);
            lblSettingsMemoryWritingSkills.MouseState = MaterialSkin.MouseState.HOVER;
            lblSettingsMemoryWritingSkills.Name = "lblSettingsMemoryWritingSkills";
            lblSettingsMemoryWritingSkills.Size = new Size(215, 24);
            lblSettingsMemoryWritingSkills.TabIndex = 33;
            lblSettingsMemoryWritingSkills.Text = "修改技能等级(自行翻译)";
            lblSettingsMemoryWritingSkills.UseAccent = true;
            // 
            // mcSettingsMemoryWritingThermal
            // 
            mcSettingsMemoryWritingThermal.BackColor = Color.FromArgb(255, 255, 255);
            mcSettingsMemoryWritingThermal.Controls.Add(cboThermalColorScheme);
            mcSettingsMemoryWritingThermal.Controls.Add(cboThermalType);
            mcSettingsMemoryWritingThermal.Controls.Add(sldrThermalColorCoefficient);
            mcSettingsMemoryWritingThermal.Controls.Add(sldrMinTemperature);
            mcSettingsMemoryWritingThermal.Controls.Add(lblSettingsMemoryWritingThermal);
            mcSettingsMemoryWritingThermal.Controls.Add(sldrThermalRampShift);
            mcSettingsMemoryWritingThermal.Depth = 0;
            mcSettingsMemoryWritingThermal.ForeColor = Color.FromArgb(222, 0, 0, 0);
            mcSettingsMemoryWritingThermal.Location = new Point(17, 380);
            mcSettingsMemoryWritingThermal.Margin = new Padding(16);
            mcSettingsMemoryWritingThermal.MouseState = MaterialSkin.MouseState.HOVER;
            mcSettingsMemoryWritingThermal.Name = "mcSettingsMemoryWritingThermal";
            mcSettingsMemoryWritingThermal.Padding = new Padding(16);
            mcSettingsMemoryWritingThermal.Size = new Size(611, 186);
            mcSettingsMemoryWritingThermal.TabIndex = 41;
            mcSettingsMemoryWritingThermal.Visible = false;
            // 
            // lblSettingsMemoryWritingThermal
            // 
            lblSettingsMemoryWritingThermal.AutoSize = true;
            lblSettingsMemoryWritingThermal.Depth = 0;
            lblSettingsMemoryWritingThermal.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            lblSettingsMemoryWritingThermal.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            lblSettingsMemoryWritingThermal.HighEmphasis = true;
            lblSettingsMemoryWritingThermal.Location = new Point(19, 14);
            lblSettingsMemoryWritingThermal.MouseState = MaterialSkin.MouseState.HOVER;
            lblSettingsMemoryWritingThermal.Name = "lblSettingsMemoryWritingThermal";
            lblSettingsMemoryWritingThermal.Size = new Size(61, 24);
            lblSettingsMemoryWritingThermal.TabIndex = 33;
            lblSettingsMemoryWritingThermal.Text = "热选项";
            lblSettingsMemoryWritingThermal.UseAccent = true;
            // 
            // mcSettingsMemoryWritingGlobal
            // 
            mcSettingsMemoryWritingGlobal.BackColor = Color.FromArgb(255, 255, 255);
            mcSettingsMemoryWritingGlobal.Controls.Add(swInfiniteStamina);
            mcSettingsMemoryWritingGlobal.Controls.Add(lblSettingsMemoryWritingGlobal);
            mcSettingsMemoryWritingGlobal.Controls.Add(sldrTimeOfDay);
            mcSettingsMemoryWritingGlobal.Controls.Add(swExtendedReach);
            mcSettingsMemoryWritingGlobal.Controls.Add(swFreezeTime);
            mcSettingsMemoryWritingGlobal.Controls.Add(swChams);
            mcSettingsMemoryWritingGlobal.Depth = 0;
            mcSettingsMemoryWritingGlobal.ForeColor = Color.FromArgb(222, 0, 0, 0);
            mcSettingsMemoryWritingGlobal.Location = new Point(17, 64);
            mcSettingsMemoryWritingGlobal.Margin = new Padding(16);
            mcSettingsMemoryWritingGlobal.MouseState = MaterialSkin.MouseState.HOVER;
            mcSettingsMemoryWritingGlobal.Name = "mcSettingsMemoryWritingGlobal";
            mcSettingsMemoryWritingGlobal.Padding = new Padding(16);
            mcSettingsMemoryWritingGlobal.Size = new Size(611, 142);
            mcSettingsMemoryWritingGlobal.TabIndex = 38;
            // 
            // lblSettingsMemoryWritingGlobal
            // 
            lblSettingsMemoryWritingGlobal.AutoSize = true;
            lblSettingsMemoryWritingGlobal.Depth = 0;
            lblSettingsMemoryWritingGlobal.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            lblSettingsMemoryWritingGlobal.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            lblSettingsMemoryWritingGlobal.HighEmphasis = true;
            lblSettingsMemoryWritingGlobal.Location = new Point(19, 14);
            lblSettingsMemoryWritingGlobal.MouseState = MaterialSkin.MouseState.HOVER;
            lblSettingsMemoryWritingGlobal.Name = "lblSettingsMemoryWritingGlobal";
            lblSettingsMemoryWritingGlobal.Size = new Size(81, 24);
            lblSettingsMemoryWritingGlobal.TabIndex = 33;
            lblSettingsMemoryWritingGlobal.Text = "全局选项";
            lblSettingsMemoryWritingGlobal.UseAccent = true;
            // 
            // mcSettingsMemoryWritingGear
            // 
            mcSettingsMemoryWritingGear.BackColor = Color.FromArgb(255, 255, 255);
            mcSettingsMemoryWritingGear.Controls.Add(swNightVision);
            mcSettingsMemoryWritingGear.Controls.Add(swOpticalThermal);
            mcSettingsMemoryWritingGear.Controls.Add(swThermalVision);
            mcSettingsMemoryWritingGear.Controls.Add(lblSettingsMemoryWritingGear);
            mcSettingsMemoryWritingGear.Controls.Add(swNoVisor);
            mcSettingsMemoryWritingGear.Controls.Add(swInstantADS);
            mcSettingsMemoryWritingGear.Controls.Add(swNoRecoilSway);
            mcSettingsMemoryWritingGear.Depth = 0;
            mcSettingsMemoryWritingGear.ForeColor = Color.FromArgb(222, 0, 0, 0);
            mcSettingsMemoryWritingGear.Location = new Point(17, 222);
            mcSettingsMemoryWritingGear.Margin = new Padding(16);
            mcSettingsMemoryWritingGear.MouseState = MaterialSkin.MouseState.HOVER;
            mcSettingsMemoryWritingGear.Name = "mcSettingsMemoryWritingGear";
            mcSettingsMemoryWritingGear.Padding = new Padding(16);
            mcSettingsMemoryWritingGear.Size = new Size(611, 139);
            mcSettingsMemoryWritingGear.TabIndex = 39;
            // 
            // lblSettingsMemoryWritingGear
            // 
            lblSettingsMemoryWritingGear.AutoSize = true;
            lblSettingsMemoryWritingGear.Depth = 0;
            lblSettingsMemoryWritingGear.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            lblSettingsMemoryWritingGear.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            lblSettingsMemoryWritingGear.HighEmphasis = true;
            lblSettingsMemoryWritingGear.Location = new Point(19, 14);
            lblSettingsMemoryWritingGear.MouseState = MaterialSkin.MouseState.HOVER;
            lblSettingsMemoryWritingGear.Name = "lblSettingsMemoryWritingGear";
            lblSettingsMemoryWritingGear.Size = new Size(128, 24);
            lblSettingsMemoryWritingGear.TabIndex = 33;
            lblSettingsMemoryWritingGear.Text = "Gear Features";
            lblSettingsMemoryWritingGear.UseAccent = true;
            // 
            // tabSettingsLoot
            // 
            tabSettingsLoot.BackColor = Color.White;
            tabSettingsLoot.Controls.Add(mcSettingsLootMinRubleValue);
            tabSettingsLoot.Controls.Add(mcSettingsLootGeneral);
            tabSettingsLoot.Location = new Point(4, 29);
            tabSettingsLoot.Margin = new Padding(0);
            tabSettingsLoot.Name = "tabSettingsLoot";
            tabSettingsLoot.Size = new Size(1465, 723);
            tabSettingsLoot.TabIndex = 2;
            tabSettingsLoot.Text = "物资";
            // 
            // mcSettingsLootMinRubleValue
            // 
            mcSettingsLootMinRubleValue.BackColor = Color.FromArgb(255, 255, 255);
            mcSettingsLootMinRubleValue.Controls.Add(sldrMinImportantLoot);
            mcSettingsLootMinRubleValue.Controls.Add(sldrMinSubItems);
            mcSettingsLootMinRubleValue.Controls.Add(lblSettingsLootMinRubleValues);
            mcSettingsLootMinRubleValue.Controls.Add(sldrMinCorpse);
            mcSettingsLootMinRubleValue.Controls.Add(sldrMinRegularLoot);
            mcSettingsLootMinRubleValue.Depth = 0;
            mcSettingsLootMinRubleValue.ForeColor = Color.FromArgb(222, 0, 0, 0);
            mcSettingsLootMinRubleValue.Location = new Point(17, 235);
            mcSettingsLootMinRubleValue.Margin = new Padding(16);
            mcSettingsLootMinRubleValue.MouseState = MaterialSkin.MouseState.HOVER;
            mcSettingsLootMinRubleValue.Name = "mcSettingsLootMinRubleValue";
            mcSettingsLootMinRubleValue.Padding = new Padding(16);
            mcSettingsLootMinRubleValue.Size = new Size(670, 142);
            mcSettingsLootMinRubleValue.TabIndex = 37;
            // 
            // lblSettingsLootMinRubleValues
            // 
            lblSettingsLootMinRubleValues.AutoSize = true;
            lblSettingsLootMinRubleValues.Depth = 0;
            lblSettingsLootMinRubleValues.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            lblSettingsLootMinRubleValues.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            lblSettingsLootMinRubleValues.HighEmphasis = true;
            lblSettingsLootMinRubleValues.Location = new Point(19, 14);
            lblSettingsLootMinRubleValues.MouseState = MaterialSkin.MouseState.HOVER;
            lblSettingsLootMinRubleValues.Name = "lblSettingsLootMinRubleValues";
            lblSettingsLootMinRubleValues.Size = new Size(81, 24);
            lblSettingsLootMinRubleValues.TabIndex = 33;
            lblSettingsLootMinRubleValues.Text = "价值设置";
            lblSettingsLootMinRubleValues.UseAccent = true;
            // 
            // mcSettingsLootGeneral
            // 
            mcSettingsLootGeneral.BackColor = Color.FromArgb(255, 255, 255);
            mcSettingsLootGeneral.Controls.Add(swProcessLoot);
            mcSettingsLootGeneral.Controls.Add(cboAutoRefreshMap);
            mcSettingsLootGeneral.Controls.Add(sldrAutoRefreshDelay);
            mcSettingsLootGeneral.Controls.Add(btnRefreshLoot);
            mcSettingsLootGeneral.Controls.Add(swAutoRefresh);
            mcSettingsLootGeneral.Controls.Add(swItemValue);
            mcSettingsLootGeneral.Controls.Add(swSubItems);
            mcSettingsLootGeneral.Controls.Add(swFilteredOnly);
            mcSettingsLootGeneral.Controls.Add(lblSettingsLootGeneral);
            mcSettingsLootGeneral.Controls.Add(swCorpses);
            mcSettingsLootGeneral.Depth = 0;
            mcSettingsLootGeneral.ForeColor = Color.FromArgb(222, 0, 0, 0);
            mcSettingsLootGeneral.Location = new Point(17, 16);
            mcSettingsLootGeneral.Margin = new Padding(16);
            mcSettingsLootGeneral.MouseState = MaterialSkin.MouseState.HOVER;
            mcSettingsLootGeneral.Name = "mcSettingsLootGeneral";
            mcSettingsLootGeneral.Padding = new Padding(16);
            mcSettingsLootGeneral.Size = new Size(670, 201);
            mcSettingsLootGeneral.TabIndex = 36;
            // 
            // lblSettingsLootGeneral
            // 
            lblSettingsLootGeneral.AutoSize = true;
            lblSettingsLootGeneral.Depth = 0;
            lblSettingsLootGeneral.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            lblSettingsLootGeneral.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            lblSettingsLootGeneral.HighEmphasis = true;
            lblSettingsLootGeneral.Location = new Point(19, 17);
            lblSettingsLootGeneral.MouseState = MaterialSkin.MouseState.HOVER;
            lblSettingsLootGeneral.Name = "lblSettingsLootGeneral";
            lblSettingsLootGeneral.Size = new Size(81, 24);
            lblSettingsLootGeneral.TabIndex = 30;
            lblSettingsLootGeneral.Text = "人物选项";
            lblSettingsLootGeneral.UseAccent = true;
            // 
            // tabSettingsAIFactions
            // 
            tabSettingsAIFactions.BackColor = Color.White;
            tabSettingsAIFactions.Controls.Add(lstFactionEntries);
            tabSettingsAIFactions.Controls.Add(mcSettingsAIFactionsEntryManagement);
            tabSettingsAIFactions.Controls.Add(mcSettingsAIFactionsFactions);
            tabSettingsAIFactions.Location = new Point(4, 29);
            tabSettingsAIFactions.Margin = new Padding(0);
            tabSettingsAIFactions.Name = "tabSettingsAIFactions";
            tabSettingsAIFactions.Size = new Size(1465, 723);
            tabSettingsAIFactions.TabIndex = 3;
            tabSettingsAIFactions.Text = "队伍管理";
            // 
            // lstFactionEntries
            // 
            lstFactionEntries.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lstFactionEntries.AutoSizeTable = false;
            lstFactionEntries.BackColor = Color.FromArgb(255, 255, 255);
            lstFactionEntries.BorderStyle = BorderStyle.None;
            lstFactionEntries.Columns.AddRange(new ColumnHeader[] { colFactionsAIName });
            lstFactionEntries.Depth = 0;
            lstFactionEntries.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lstFactionEntries.FullRowSelect = true;
            lstFactionEntries.Location = new Point(17, 16);
            lstFactionEntries.MaximumSize = new Size(480, 1020);
            lstFactionEntries.MinimumSize = new Size(229, 113);
            lstFactionEntries.MouseLocation = new Point(-1, -1);
            lstFactionEntries.MouseState = MaterialSkin.MouseState.OUT;
            lstFactionEntries.MultiSelect = false;
            lstFactionEntries.Name = "lstFactionEntries";
            lstFactionEntries.OwnerDraw = true;
            lstFactionEntries.Size = new Size(286, 699);
            lstFactionEntries.TabIndex = 44;
            lstFactionEntries.UseCompatibleStateImageBehavior = false;
            lstFactionEntries.View = View.Details;
            lstFactionEntries.SelectedIndexChanged += lstFactionEntries_SelectedIndexChanged;
            // 
            // colFactionsAIName
            // 
            colFactionsAIName.Text = "Name";
            colFactionsAIName.Width = 250;
            // 
            // mcSettingsAIFactionsEntryManagement
            // 
            mcSettingsAIFactionsEntryManagement.BackColor = Color.FromArgb(255, 255, 255);
            mcSettingsAIFactionsEntryManagement.Controls.Add(btnRemoveFactionEntry);
            mcSettingsAIFactionsEntryManagement.Controls.Add(txtFactionEntryName);
            mcSettingsAIFactionsEntryManagement.Controls.Add(lblSettingsAIFactionsEntryManagement);
            mcSettingsAIFactionsEntryManagement.Depth = 0;
            mcSettingsAIFactionsEntryManagement.ForeColor = Color.FromArgb(222, 0, 0, 0);
            mcSettingsAIFactionsEntryManagement.Location = new Point(320, 16);
            mcSettingsAIFactionsEntryManagement.Margin = new Padding(16);
            mcSettingsAIFactionsEntryManagement.MouseState = MaterialSkin.MouseState.HOVER;
            mcSettingsAIFactionsEntryManagement.Name = "mcSettingsAIFactionsEntryManagement";
            mcSettingsAIFactionsEntryManagement.Padding = new Padding(16);
            mcSettingsAIFactionsEntryManagement.Size = new Size(545, 122);
            mcSettingsAIFactionsEntryManagement.TabIndex = 43;
            // 
            // lblSettingsAIFactionsEntryManagement
            // 
            lblSettingsAIFactionsEntryManagement.AutoSize = true;
            lblSettingsAIFactionsEntryManagement.Depth = 0;
            lblSettingsAIFactionsEntryManagement.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            lblSettingsAIFactionsEntryManagement.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            lblSettingsAIFactionsEntryManagement.HighEmphasis = true;
            lblSettingsAIFactionsEntryManagement.Location = new Point(19, 17);
            lblSettingsAIFactionsEntryManagement.MouseState = MaterialSkin.MouseState.HOVER;
            lblSettingsAIFactionsEntryManagement.Name = "lblSettingsAIFactionsEntryManagement";
            lblSettingsAIFactionsEntryManagement.Size = new Size(81, 24);
            lblSettingsAIFactionsEntryManagement.TabIndex = 30;
            lblSettingsAIFactionsEntryManagement.Text = "玩家管理";
            lblSettingsAIFactionsEntryManagement.UseAccent = true;
            // 
            // mcSettingsAIFactionsFactions
            // 
            mcSettingsAIFactionsFactions.BackColor = Color.FromArgb(255, 255, 255);
            mcSettingsAIFactionsFactions.Controls.Add(lstFactions);
            mcSettingsAIFactionsFactions.Controls.Add(txtFactionName);
            mcSettingsAIFactionsFactions.Controls.Add(btnAddFactionEntry);
            mcSettingsAIFactionsFactions.Controls.Add(cboFactionType);
            mcSettingsAIFactionsFactions.Controls.Add(btnAddFaction);
            mcSettingsAIFactionsFactions.Controls.Add(btnRemoveFaction);
            mcSettingsAIFactionsFactions.Controls.Add(lblSettingsAIFactionsFactions);
            mcSettingsAIFactionsFactions.Depth = 0;
            mcSettingsAIFactionsFactions.ForeColor = Color.FromArgb(222, 0, 0, 0);
            mcSettingsAIFactionsFactions.Location = new Point(320, 156);
            mcSettingsAIFactionsFactions.Margin = new Padding(16);
            mcSettingsAIFactionsFactions.MouseState = MaterialSkin.MouseState.HOVER;
            mcSettingsAIFactionsFactions.Name = "mcSettingsAIFactionsFactions";
            mcSettingsAIFactionsFactions.Padding = new Padding(16);
            mcSettingsAIFactionsFactions.Size = new Size(545, 468);
            mcSettingsAIFactionsFactions.TabIndex = 42;
            // 
            // lstFactions
            // 
            lstFactions.AutoSizeTable = false;
            lstFactions.BackColor = Color.FromArgb(255, 255, 255);
            lstFactions.BorderStyle = BorderStyle.None;
            lstFactions.Columns.AddRange(new ColumnHeader[] { colFactionName });
            lstFactions.Depth = 0;
            lstFactions.FullRowSelect = true;
            lstFactions.Location = new Point(17, 51);
            lstFactions.MinimumSize = new Size(229, 113);
            lstFactions.MouseLocation = new Point(-1, -1);
            lstFactions.MouseState = MaterialSkin.MouseState.OUT;
            lstFactions.Name = "lstFactions";
            lstFactions.OwnerDraw = true;
            lstFactions.Size = new Size(229, 400);
            lstFactions.TabIndex = 44;
            lstFactions.UseCompatibleStateImageBehavior = false;
            lstFactions.View = View.Details;
            lstFactions.SelectedIndexChanged += lstFactions_SelectedIndexChanged;
            // 
            // colFactionName
            // 
            colFactionName.Text = "帐户编号";
            colFactionName.Width = 200;
            // 
            // lblSettingsAIFactionsFactions
            // 
            lblSettingsAIFactionsFactions.AutoSize = true;
            lblSettingsAIFactionsFactions.Depth = 0;
            lblSettingsAIFactionsFactions.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            lblSettingsAIFactionsFactions.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            lblSettingsAIFactionsFactions.HighEmphasis = true;
            lblSettingsAIFactionsFactions.Location = new Point(19, 14);
            lblSettingsAIFactionsFactions.MouseState = MaterialSkin.MouseState.HOVER;
            lblSettingsAIFactionsFactions.Name = "lblSettingsAIFactionsFactions";
            lblSettingsAIFactionsFactions.Size = new Size(41, 24);
            lblSettingsAIFactionsFactions.TabIndex = 33;
            lblSettingsAIFactionsFactions.Text = "队伍";
            lblSettingsAIFactionsFactions.UseAccent = true;
            // 
            // tabSettingsColors
            // 
            tabSettingsColors.BackColor = Color.White;
            tabSettingsColors.Controls.Add(mcSettingsColorsOther);
            tabSettingsColors.Controls.Add(mcSettingsColorsLootAndQuests);
            tabSettingsColors.Controls.Add(mcSettingsColorsExfiltration);
            tabSettingsColors.Controls.Add(mcSettingsColorsPlayers);
            tabSettingsColors.Controls.Add(mcSettingsColorsAI);
            tabSettingsColors.Location = new Point(4, 29);
            tabSettingsColors.Margin = new Padding(0);
            tabSettingsColors.Name = "tabSettingsColors";
            tabSettingsColors.Size = new Size(1465, 723);
            tabSettingsColors.TabIndex = 4;
            tabSettingsColors.Text = "颜色";
            // 
            // mcSettingsColorsOther
            // 
            mcSettingsColorsOther.BackColor = Color.FromArgb(255, 255, 255);
            mcSettingsColorsOther.Controls.Add(btnResetTheme);
            mcSettingsColorsOther.Controls.Add(picOtherAccent);
            mcSettingsColorsOther.Controls.Add(lblSettingsOtherAccent);
            mcSettingsColorsOther.Controls.Add(picOtherPrimaryLight);
            mcSettingsColorsOther.Controls.Add(lblSettingsOtherPrimaryLight);
            mcSettingsColorsOther.Controls.Add(picOtherPrimaryDark);
            mcSettingsColorsOther.Controls.Add(lblSettingsOtherPrimaryDark);
            mcSettingsColorsOther.Controls.Add(picOtherPrimary);
            mcSettingsColorsOther.Controls.Add(lblSettingsOtherPrimary);
            mcSettingsColorsOther.Controls.Add(picOtherChams);
            mcSettingsColorsOther.Controls.Add(lblSettingsOtherChams);
            mcSettingsColorsOther.Controls.Add(picOtherDeathMarker);
            mcSettingsColorsOther.Controls.Add(lblSettingsOtherDeathMarker);
            mcSettingsColorsOther.Controls.Add(picOtherTextOutline);
            mcSettingsColorsOther.Controls.Add(lblSettingsOtherTextOutline);
            mcSettingsColorsOther.Controls.Add(lblSettingsColorsOther);
            mcSettingsColorsOther.Depth = 0;
            mcSettingsColorsOther.ForeColor = Color.FromArgb(222, 0, 0, 0);
            mcSettingsColorsOther.Location = new Point(995, 16);
            mcSettingsColorsOther.Margin = new Padding(16);
            mcSettingsColorsOther.MouseState = MaterialSkin.MouseState.HOVER;
            mcSettingsColorsOther.Name = "mcSettingsColorsOther";
            mcSettingsColorsOther.Padding = new Padding(16);
            mcSettingsColorsOther.Size = new Size(213, 365);
            mcSettingsColorsOther.TabIndex = 43;
            // 
            // picOtherAccent
            // 
            picOtherAccent.BackColor = Color.Transparent;
            picOtherAccent.BorderStyle = BorderStyle.FixedSingle;
            picOtherAccent.Location = new Point(125, 255);
            picOtherAccent.Name = "picOtherAccent";
            picOtherAccent.Size = new Size(80, 26);
            picOtherAccent.TabIndex = 58;
            picOtherAccent.TabStop = false;
            picOtherAccent.Click += picOtherAccent_Click;
            // 
            // lblSettingsOtherAccent
            // 
            lblSettingsOtherAccent.AutoSize = true;
            lblSettingsOtherAccent.Depth = 0;
            lblSettingsOtherAccent.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblSettingsOtherAccent.FontType = MaterialSkin.MaterialSkinManager.fontType.Body2;
            lblSettingsOtherAccent.Location = new Point(56, 255);
            lblSettingsOtherAccent.MouseState = MaterialSkin.MouseState.HOVER;
            lblSettingsOtherAccent.Name = "lblSettingsOtherAccent";
            lblSettingsOtherAccent.Size = new Size(47, 17);
            lblSettingsOtherAccent.TabIndex = 57;
            lblSettingsOtherAccent.Text = "Accent:";
            // 
            // picOtherPrimaryLight
            // 
            picOtherPrimaryLight.BackColor = Color.Transparent;
            picOtherPrimaryLight.BorderStyle = BorderStyle.FixedSingle;
            picOtherPrimaryLight.Location = new Point(125, 221);
            picOtherPrimaryLight.Name = "picOtherPrimaryLight";
            picOtherPrimaryLight.Size = new Size(80, 26);
            picOtherPrimaryLight.TabIndex = 56;
            picOtherPrimaryLight.TabStop = false;
            picOtherPrimaryLight.Click += picOtherPrimaryLight_Click;
            // 
            // lblSettingsOtherPrimaryLight
            // 
            lblSettingsOtherPrimaryLight.AutoSize = true;
            lblSettingsOtherPrimaryLight.Depth = 0;
            lblSettingsOtherPrimaryLight.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblSettingsOtherPrimaryLight.FontType = MaterialSkin.MaterialSkinManager.fontType.Body2;
            lblSettingsOtherPrimaryLight.Location = new Point(73, 221);
            lblSettingsOtherPrimaryLight.MouseState = MaterialSkin.MouseState.HOVER;
            lblSettingsOtherPrimaryLight.Name = "lblSettingsOtherPrimaryLight";
            lblSettingsOtherPrimaryLight.Size = new Size(32, 17);
            lblSettingsOtherPrimaryLight.TabIndex = 55;
            lblSettingsOtherPrimaryLight.Text = "亮色:";
            // 
            // picOtherPrimaryDark
            // 
            picOtherPrimaryDark.BackColor = Color.Transparent;
            picOtherPrimaryDark.BorderStyle = BorderStyle.FixedSingle;
            picOtherPrimaryDark.Location = new Point(125, 187);
            picOtherPrimaryDark.Name = "picOtherPrimaryDark";
            picOtherPrimaryDark.Size = new Size(80, 26);
            picOtherPrimaryDark.TabIndex = 54;
            picOtherPrimaryDark.TabStop = false;
            picOtherPrimaryDark.Click += picOtherPrimaryDark_Click;
            // 
            // lblSettingsOtherPrimaryDark
            // 
            lblSettingsOtherPrimaryDark.AutoSize = true;
            lblSettingsOtherPrimaryDark.Depth = 0;
            lblSettingsOtherPrimaryDark.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblSettingsOtherPrimaryDark.FontType = MaterialSkin.MaterialSkinManager.fontType.Body2;
            lblSettingsOtherPrimaryDark.Location = new Point(73, 187);
            lblSettingsOtherPrimaryDark.MouseState = MaterialSkin.MouseState.HOVER;
            lblSettingsOtherPrimaryDark.Name = "lblSettingsOtherPrimaryDark";
            lblSettingsOtherPrimaryDark.Size = new Size(32, 17);
            lblSettingsOtherPrimaryDark.TabIndex = 53;
            lblSettingsOtherPrimaryDark.Text = "深色:";
            // 
            // picOtherPrimary
            // 
            picOtherPrimary.BackColor = Color.Transparent;
            picOtherPrimary.BorderStyle = BorderStyle.FixedSingle;
            picOtherPrimary.Location = new Point(125, 153);
            picOtherPrimary.Name = "picOtherPrimary";
            picOtherPrimary.Size = new Size(80, 26);
            picOtherPrimary.TabIndex = 52;
            picOtherPrimary.TabStop = false;
            picOtherPrimary.Click += picOtherPrimary_Click;
            // 
            // lblSettingsOtherPrimary
            // 
            lblSettingsOtherPrimary.AutoSize = true;
            lblSettingsOtherPrimary.Depth = 0;
            lblSettingsOtherPrimary.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblSettingsOtherPrimary.FontType = MaterialSkin.MaterialSkinManager.fontType.Body2;
            lblSettingsOtherPrimary.Location = new Point(57, 153);
            lblSettingsOtherPrimary.MouseState = MaterialSkin.MouseState.HOVER;
            lblSettingsOtherPrimary.Name = "lblSettingsOtherPrimary";
            lblSettingsOtherPrimary.Size = new Size(46, 17);
            lblSettingsOtherPrimary.TabIndex = 51;
            lblSettingsOtherPrimary.Text = "重要的:";
            // 
            // picOtherChams
            // 
            picOtherChams.BackColor = Color.Transparent;
            picOtherChams.BorderStyle = BorderStyle.FixedSingle;
            picOtherChams.Location = new Point(125, 119);
            picOtherChams.Name = "picOtherChams";
            picOtherChams.Size = new Size(80, 26);
            picOtherChams.TabIndex = 50;
            picOtherChams.TabStop = false;
            picOtherChams.Click += picOtherChams_Click;
            // 
            // lblSettingsOtherChams
            // 
            lblSettingsOtherChams.AutoSize = true;
            lblSettingsOtherChams.Depth = 0;
            lblSettingsOtherChams.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblSettingsOtherChams.FontType = MaterialSkin.MaterialSkinManager.fontType.Body2;
            lblSettingsOtherChams.Location = new Point(55, 119);
            lblSettingsOtherChams.MouseState = MaterialSkin.MouseState.HOVER;
            lblSettingsOtherChams.Name = "lblSettingsOtherChams";
            lblSettingsOtherChams.Size = new Size(48, 17);
            lblSettingsOtherChams.TabIndex = 49;
            lblSettingsOtherChams.Text = "Chams:";
            // 
            // picOtherDeathMarker
            // 
            picOtherDeathMarker.BackColor = Color.Transparent;
            picOtherDeathMarker.BorderStyle = BorderStyle.FixedSingle;
            picOtherDeathMarker.Location = new Point(125, 85);
            picOtherDeathMarker.Name = "picOtherDeathMarker";
            picOtherDeathMarker.Size = new Size(80, 26);
            picOtherDeathMarker.TabIndex = 48;
            picOtherDeathMarker.TabStop = false;
            picOtherDeathMarker.Click += picOtherDeathMarker_Click;
            // 
            // lblSettingsOtherDeathMarker
            // 
            lblSettingsOtherDeathMarker.AutoSize = true;
            lblSettingsOtherDeathMarker.Depth = 0;
            lblSettingsOtherDeathMarker.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblSettingsOtherDeathMarker.FontType = MaterialSkin.MaterialSkinManager.fontType.Body2;
            lblSettingsOtherDeathMarker.Location = new Point(41, 85);
            lblSettingsOtherDeathMarker.MouseState = MaterialSkin.MouseState.HOVER;
            lblSettingsOtherDeathMarker.Name = "lblSettingsOtherDeathMarker";
            lblSettingsOtherDeathMarker.Size = new Size(60, 17);
            lblSettingsOtherDeathMarker.TabIndex = 47;
            lblSettingsOtherDeathMarker.Text = "死亡标记:";
            // 
            // picOtherTextOutline
            // 
            picOtherTextOutline.BackColor = Color.Transparent;
            picOtherTextOutline.BorderStyle = BorderStyle.FixedSingle;
            picOtherTextOutline.Location = new Point(125, 51);
            picOtherTextOutline.Name = "picOtherTextOutline";
            picOtherTextOutline.Size = new Size(80, 26);
            picOtherTextOutline.TabIndex = 46;
            picOtherTextOutline.TabStop = false;
            picOtherTextOutline.Click += picOtherTextOutline_Click;
            // 
            // lblSettingsOtherTextOutline
            // 
            lblSettingsOtherTextOutline.AutoSize = true;
            lblSettingsOtherTextOutline.Depth = 0;
            lblSettingsOtherTextOutline.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblSettingsOtherTextOutline.FontType = MaterialSkin.MaterialSkinManager.fontType.Body2;
            lblSettingsOtherTextOutline.Location = new Point(73, 51);
            lblSettingsOtherTextOutline.MouseState = MaterialSkin.MouseState.HOVER;
            lblSettingsOtherTextOutline.Name = "lblSettingsOtherTextOutline";
            lblSettingsOtherTextOutline.Size = new Size(32, 17);
            lblSettingsOtherTextOutline.TabIndex = 44;
            lblSettingsOtherTextOutline.Text = "文本:";
            // 
            // lblSettingsColorsOther
            // 
            lblSettingsColorsOther.AutoSize = true;
            lblSettingsColorsOther.Depth = 0;
            lblSettingsColorsOther.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            lblSettingsColorsOther.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            lblSettingsColorsOther.HighEmphasis = true;
            lblSettingsColorsOther.Location = new Point(19, 14);
            lblSettingsColorsOther.MouseState = MaterialSkin.MouseState.HOVER;
            lblSettingsColorsOther.Name = "lblSettingsColorsOther";
            lblSettingsColorsOther.Size = new Size(41, 24);
            lblSettingsColorsOther.TabIndex = 33;
            lblSettingsColorsOther.Text = "其他";
            lblSettingsColorsOther.UseAccent = true;
            // 
            // mcSettingsColorsLootAndQuests
            // 
            mcSettingsColorsLootAndQuests.BackColor = Color.FromArgb(255, 255, 255);
            mcSettingsColorsLootAndQuests.Controls.Add(picQuestZone);
            mcSettingsColorsLootAndQuests.Controls.Add(lblSettingsQuestZones);
            mcSettingsColorsLootAndQuests.Controls.Add(picQuestItem);
            mcSettingsColorsLootAndQuests.Controls.Add(lblSettingsQuestItems);
            mcSettingsColorsLootAndQuests.Controls.Add(picLootImportant);
            mcSettingsColorsLootAndQuests.Controls.Add(lblSettingsLootImportant);
            mcSettingsColorsLootAndQuests.Controls.Add(picLootRegular);
            mcSettingsColorsLootAndQuests.Controls.Add(lblSettingsLootRegular);
            mcSettingsColorsLootAndQuests.Controls.Add(lblSettingsColorsLootQuests);
            mcSettingsColorsLootAndQuests.Depth = 0;
            mcSettingsColorsLootAndQuests.ForeColor = Color.FromArgb(222, 0, 0, 0);
            mcSettingsColorsLootAndQuests.Location = new Point(744, 16);
            mcSettingsColorsLootAndQuests.Margin = new Padding(16);
            mcSettingsColorsLootAndQuests.MouseState = MaterialSkin.MouseState.HOVER;
            mcSettingsColorsLootAndQuests.Name = "mcSettingsColorsLootAndQuests";
            mcSettingsColorsLootAndQuests.Padding = new Padding(16);
            mcSettingsColorsLootAndQuests.Size = new Size(225, 365);
            mcSettingsColorsLootAndQuests.TabIndex = 42;
            // 
            // picQuestZone
            // 
            picQuestZone.BackColor = Color.Transparent;
            picQuestZone.BorderStyle = BorderStyle.FixedSingle;
            picQuestZone.Location = new Point(137, 153);
            picQuestZone.Name = "picQuestZone";
            picQuestZone.Size = new Size(80, 26);
            picQuestZone.TabIndex = 52;
            picQuestZone.TabStop = false;
            picQuestZone.Click += picQuestZone_Click;
            // 
            // lblSettingsQuestZones
            // 
            lblSettingsQuestZones.AutoSize = true;
            lblSettingsQuestZones.Depth = 0;
            lblSettingsQuestZones.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblSettingsQuestZones.FontType = MaterialSkin.MaterialSkinManager.fontType.Body2;
            lblSettingsQuestZones.Location = new Point(40, 153);
            lblSettingsQuestZones.MouseState = MaterialSkin.MouseState.HOVER;
            lblSettingsQuestZones.Name = "lblSettingsQuestZones";
            lblSettingsQuestZones.Size = new Size(60, 17);
            lblSettingsQuestZones.TabIndex = 51;
            lblSettingsQuestZones.Text = "任务位置:";
            // 
            // picQuestItem
            // 
            picQuestItem.BackColor = Color.Transparent;
            picQuestItem.BorderStyle = BorderStyle.FixedSingle;
            picQuestItem.Location = new Point(137, 120);
            picQuestItem.Name = "picQuestItem";
            picQuestItem.Size = new Size(80, 26);
            picQuestItem.TabIndex = 50;
            picQuestItem.TabStop = false;
            picQuestItem.Click += picQuestItem_Click;
            // 
            // lblSettingsQuestItems
            // 
            lblSettingsQuestItems.AutoSize = true;
            lblSettingsQuestItems.Depth = 0;
            lblSettingsQuestItems.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblSettingsQuestItems.FontType = MaterialSkin.MaterialSkinManager.fontType.Body2;
            lblSettingsQuestItems.Location = new Point(40, 119);
            lblSettingsQuestItems.MouseState = MaterialSkin.MouseState.HOVER;
            lblSettingsQuestItems.Name = "lblSettingsQuestItems";
            lblSettingsQuestItems.Size = new Size(60, 17);
            lblSettingsQuestItems.TabIndex = 49;
            lblSettingsQuestItems.Text = "任务物品:";
            // 
            // picLootImportant
            // 
            picLootImportant.BackColor = Color.Transparent;
            picLootImportant.BorderStyle = BorderStyle.FixedSingle;
            picLootImportant.Location = new Point(137, 86);
            picLootImportant.Name = "picLootImportant";
            picLootImportant.Size = new Size(80, 26);
            picLootImportant.TabIndex = 48;
            picLootImportant.TabStop = false;
            picLootImportant.Click += picLootImportant_Click;
            // 
            // lblSettingsLootImportant
            // 
            lblSettingsLootImportant.AutoSize = true;
            lblSettingsLootImportant.Depth = 0;
            lblSettingsLootImportant.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblSettingsLootImportant.FontType = MaterialSkin.MaterialSkinManager.fontType.Body2;
            lblSettingsLootImportant.Location = new Point(40, 85);
            lblSettingsLootImportant.MouseState = MaterialSkin.MouseState.HOVER;
            lblSettingsLootImportant.Name = "lblSettingsLootImportant";
            lblSettingsLootImportant.Size = new Size(60, 17);
            lblSettingsLootImportant.TabIndex = 47;
            lblSettingsLootImportant.Text = "高级物资:";
            // 
            // picLootRegular
            // 
            picLootRegular.BackColor = Color.Transparent;
            picLootRegular.BorderStyle = BorderStyle.FixedSingle;
            picLootRegular.Location = new Point(137, 51);
            picLootRegular.Name = "picLootRegular";
            picLootRegular.Size = new Size(80, 26);
            picLootRegular.TabIndex = 46;
            picLootRegular.TabStop = false;
            picLootRegular.Click += picLootRegular_Click;
            // 
            // lblSettingsLootRegular
            // 
            lblSettingsLootRegular.AutoSize = true;
            lblSettingsLootRegular.Depth = 0;
            lblSettingsLootRegular.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblSettingsLootRegular.FontType = MaterialSkin.MaterialSkinManager.fontType.Body2;
            lblSettingsLootRegular.Location = new Point(40, 51);
            lblSettingsLootRegular.MouseState = MaterialSkin.MouseState.HOVER;
            lblSettingsLootRegular.Name = "lblSettingsLootRegular";
            lblSettingsLootRegular.Size = new Size(60, 17);
            lblSettingsLootRegular.TabIndex = 44;
            lblSettingsLootRegular.Text = "普通物资:";
            // 
            // lblSettingsColorsLootQuests
            // 
            lblSettingsColorsLootQuests.AutoSize = true;
            lblSettingsColorsLootQuests.Depth = 0;
            lblSettingsColorsLootQuests.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            lblSettingsColorsLootQuests.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            lblSettingsColorsLootQuests.HighEmphasis = true;
            lblSettingsColorsLootQuests.Location = new Point(19, 14);
            lblSettingsColorsLootQuests.MouseState = MaterialSkin.MouseState.HOVER;
            lblSettingsColorsLootQuests.Name = "lblSettingsColorsLootQuests";
            lblSettingsColorsLootQuests.Size = new Size(89, 24);
            lblSettingsColorsLootQuests.TabIndex = 33;
            lblSettingsColorsLootQuests.Text = "物资/任务";
            lblSettingsColorsLootQuests.UseAccent = true;
            // 
            // mcSettingsColorsExfiltration
            // 
            mcSettingsColorsExfiltration.BackColor = Color.FromArgb(255, 255, 255);
            mcSettingsColorsExfiltration.Controls.Add(picExfilClosedIcon);
            mcSettingsColorsExfiltration.Controls.Add(lblSettingsColorsExfilClosedIcon);
            mcSettingsColorsExfiltration.Controls.Add(picExfilClosedText);
            mcSettingsColorsExfiltration.Controls.Add(lblSettingsColorsExfilClosedText);
            mcSettingsColorsExfiltration.Controls.Add(picExfilPendingIcon);
            mcSettingsColorsExfiltration.Controls.Add(lblSettingsColorsExfilPendingIcon);
            mcSettingsColorsExfiltration.Controls.Add(picExfilPendingText);
            mcSettingsColorsExfiltration.Controls.Add(lblSettingsColorsExfilPendingText);
            mcSettingsColorsExfiltration.Controls.Add(picExfilActiveIcon);
            mcSettingsColorsExfiltration.Controls.Add(lblSettingsColorsExfilActiveIcon);
            mcSettingsColorsExfiltration.Controls.Add(picExfilActiveText);
            mcSettingsColorsExfiltration.Controls.Add(lblSettingsColorsExfilActiveText);
            mcSettingsColorsExfiltration.Controls.Add(lblSettingsColorsExfiltration);
            mcSettingsColorsExfiltration.Depth = 0;
            mcSettingsColorsExfiltration.ForeColor = Color.FromArgb(222, 0, 0, 0);
            mcSettingsColorsExfiltration.Location = new Point(509, 16);
            mcSettingsColorsExfiltration.Margin = new Padding(16);
            mcSettingsColorsExfiltration.MouseState = MaterialSkin.MouseState.HOVER;
            mcSettingsColorsExfiltration.Name = "mcSettingsColorsExfiltration";
            mcSettingsColorsExfiltration.Padding = new Padding(16);
            mcSettingsColorsExfiltration.Size = new Size(209, 365);
            mcSettingsColorsExfiltration.TabIndex = 41;
            // 
            // picExfilClosedIcon
            // 
            picExfilClosedIcon.BackColor = Color.Transparent;
            picExfilClosedIcon.BorderStyle = BorderStyle.FixedSingle;
            picExfilClosedIcon.Location = new Point(121, 221);
            picExfilClosedIcon.Name = "picExfilClosedIcon";
            picExfilClosedIcon.Size = new Size(80, 26);
            picExfilClosedIcon.TabIndex = 56;
            picExfilClosedIcon.TabStop = false;
            picExfilClosedIcon.Click += picExfilClosedIcon_Click;
            // 
            // lblSettingsColorsExfilClosedIcon
            // 
            lblSettingsColorsExfilClosedIcon.AutoSize = true;
            lblSettingsColorsExfilClosedIcon.Depth = 0;
            lblSettingsColorsExfilClosedIcon.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblSettingsColorsExfilClosedIcon.FontType = MaterialSkin.MaterialSkinManager.fontType.Body2;
            lblSettingsColorsExfilClosedIcon.Location = new Point(27, 221);
            lblSettingsColorsExfilClosedIcon.MouseState = MaterialSkin.MouseState.HOVER;
            lblSettingsColorsExfilClosedIcon.Name = "lblSettingsColorsExfilClosedIcon";
            lblSettingsColorsExfilClosedIcon.Size = new Size(76, 17);
            lblSettingsColorsExfilClosedIcon.TabIndex = 55;
            lblSettingsColorsExfilClosedIcon.Text = "Closed Icon:";
            // 
            // picExfilClosedText
            // 
            picExfilClosedText.BackColor = Color.Transparent;
            picExfilClosedText.BorderStyle = BorderStyle.FixedSingle;
            picExfilClosedText.Location = new Point(121, 187);
            picExfilClosedText.Name = "picExfilClosedText";
            picExfilClosedText.Size = new Size(80, 26);
            picExfilClosedText.TabIndex = 54;
            picExfilClosedText.TabStop = false;
            picExfilClosedText.Click += picExfilClosedText_Click;
            // 
            // lblSettingsColorsExfilClosedText
            // 
            lblSettingsColorsExfilClosedText.AutoSize = true;
            lblSettingsColorsExfilClosedText.Depth = 0;
            lblSettingsColorsExfilClosedText.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblSettingsColorsExfilClosedText.FontType = MaterialSkin.MaterialSkinManager.fontType.Body2;
            lblSettingsColorsExfilClosedText.Location = new Point(27, 187);
            lblSettingsColorsExfilClosedText.MouseState = MaterialSkin.MouseState.HOVER;
            lblSettingsColorsExfilClosedText.Name = "lblSettingsColorsExfilClosedText";
            lblSettingsColorsExfilClosedText.Size = new Size(76, 17);
            lblSettingsColorsExfilClosedText.TabIndex = 53;
            lblSettingsColorsExfilClosedText.Text = "Closed Text:";
            // 
            // picExfilPendingIcon
            // 
            picExfilPendingIcon.BackColor = Color.Transparent;
            picExfilPendingIcon.BorderStyle = BorderStyle.FixedSingle;
            picExfilPendingIcon.Location = new Point(121, 153);
            picExfilPendingIcon.Name = "picExfilPendingIcon";
            picExfilPendingIcon.Size = new Size(80, 26);
            picExfilPendingIcon.TabIndex = 52;
            picExfilPendingIcon.TabStop = false;
            picExfilPendingIcon.Click += picExfilPendingIcon_Click;
            // 
            // lblSettingsColorsExfilPendingIcon
            // 
            lblSettingsColorsExfilPendingIcon.AutoSize = true;
            lblSettingsColorsExfilPendingIcon.Depth = 0;
            lblSettingsColorsExfilPendingIcon.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblSettingsColorsExfilPendingIcon.FontType = MaterialSkin.MaterialSkinManager.fontType.Body2;
            lblSettingsColorsExfilPendingIcon.Location = new Point(17, 153);
            lblSettingsColorsExfilPendingIcon.MouseState = MaterialSkin.MouseState.HOVER;
            lblSettingsColorsExfilPendingIcon.Name = "lblSettingsColorsExfilPendingIcon";
            lblSettingsColorsExfilPendingIcon.Size = new Size(85, 17);
            lblSettingsColorsExfilPendingIcon.TabIndex = 51;
            lblSettingsColorsExfilPendingIcon.Text = "Pending Icon:";
            // 
            // picExfilPendingText
            // 
            picExfilPendingText.BackColor = Color.Transparent;
            picExfilPendingText.BorderStyle = BorderStyle.FixedSingle;
            picExfilPendingText.Location = new Point(121, 119);
            picExfilPendingText.Name = "picExfilPendingText";
            picExfilPendingText.Size = new Size(80, 26);
            picExfilPendingText.TabIndex = 50;
            picExfilPendingText.TabStop = false;
            picExfilPendingText.Click += picExfilPendingText_Click;
            // 
            // lblSettingsColorsExfilPendingText
            // 
            lblSettingsColorsExfilPendingText.AutoSize = true;
            lblSettingsColorsExfilPendingText.Depth = 0;
            lblSettingsColorsExfilPendingText.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblSettingsColorsExfilPendingText.FontType = MaterialSkin.MaterialSkinManager.fontType.Body2;
            lblSettingsColorsExfilPendingText.Location = new Point(17, 119);
            lblSettingsColorsExfilPendingText.MouseState = MaterialSkin.MouseState.HOVER;
            lblSettingsColorsExfilPendingText.Name = "lblSettingsColorsExfilPendingText";
            lblSettingsColorsExfilPendingText.Size = new Size(85, 17);
            lblSettingsColorsExfilPendingText.TabIndex = 49;
            lblSettingsColorsExfilPendingText.Text = "Pending Text:";
            // 
            // picExfilActiveIcon
            // 
            picExfilActiveIcon.BackColor = Color.Transparent;
            picExfilActiveIcon.BorderStyle = BorderStyle.FixedSingle;
            picExfilActiveIcon.Location = new Point(121, 85);
            picExfilActiveIcon.Name = "picExfilActiveIcon";
            picExfilActiveIcon.Size = new Size(80, 26);
            picExfilActiveIcon.TabIndex = 48;
            picExfilActiveIcon.TabStop = false;
            picExfilActiveIcon.Click += picExfilActiveIcon_Click;
            // 
            // lblSettingsColorsExfilActiveIcon
            // 
            lblSettingsColorsExfilActiveIcon.AutoSize = true;
            lblSettingsColorsExfilActiveIcon.Depth = 0;
            lblSettingsColorsExfilActiveIcon.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblSettingsColorsExfilActiveIcon.FontType = MaterialSkin.MaterialSkinManager.fontType.Body2;
            lblSettingsColorsExfilActiveIcon.Location = new Point(32, 85);
            lblSettingsColorsExfilActiveIcon.MouseState = MaterialSkin.MouseState.HOVER;
            lblSettingsColorsExfilActiveIcon.Name = "lblSettingsColorsExfilActiveIcon";
            lblSettingsColorsExfilActiveIcon.Size = new Size(72, 17);
            lblSettingsColorsExfilActiveIcon.TabIndex = 47;
            lblSettingsColorsExfilActiveIcon.Text = "Active Icon:";
            // 
            // picExfilActiveText
            // 
            picExfilActiveText.BackColor = Color.Transparent;
            picExfilActiveText.BorderStyle = BorderStyle.FixedSingle;
            picExfilActiveText.Location = new Point(121, 51);
            picExfilActiveText.Name = "picExfilActiveText";
            picExfilActiveText.Size = new Size(80, 26);
            picExfilActiveText.TabIndex = 46;
            picExfilActiveText.TabStop = false;
            picExfilActiveText.Click += picExfilActiveText_Click;
            // 
            // lblSettingsColorsExfilActiveText
            // 
            lblSettingsColorsExfilActiveText.AutoSize = true;
            lblSettingsColorsExfilActiveText.Depth = 0;
            lblSettingsColorsExfilActiveText.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblSettingsColorsExfilActiveText.FontType = MaterialSkin.MaterialSkinManager.fontType.Body2;
            lblSettingsColorsExfilActiveText.Location = new Point(46, 51);
            lblSettingsColorsExfilActiveText.MouseState = MaterialSkin.MouseState.HOVER;
            lblSettingsColorsExfilActiveText.Name = "lblSettingsColorsExfilActiveText";
            lblSettingsColorsExfilActiveText.Size = new Size(60, 17);
            lblSettingsColorsExfilActiveText.TabIndex = 44;
            lblSettingsColorsExfilActiveText.Text = "任务文本:";
            // 
            // lblSettingsColorsExfiltration
            // 
            lblSettingsColorsExfiltration.AutoSize = true;
            lblSettingsColorsExfiltration.Depth = 0;
            lblSettingsColorsExfiltration.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            lblSettingsColorsExfiltration.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            lblSettingsColorsExfiltration.HighEmphasis = true;
            lblSettingsColorsExfiltration.Location = new Point(19, 14);
            lblSettingsColorsExfiltration.MouseState = MaterialSkin.MouseState.HOVER;
            lblSettingsColorsExfiltration.Name = "lblSettingsColorsExfiltration";
            lblSettingsColorsExfiltration.Size = new Size(98, 24);
            lblSettingsColorsExfiltration.TabIndex = 33;
            lblSettingsColorsExfiltration.Text = "Exfiltration";
            lblSettingsColorsExfiltration.UseAccent = true;
            // 
            // mcSettingsColorsPlayers
            // 
            mcSettingsColorsPlayers.BackColor = Color.FromArgb(255, 255, 255);
            mcSettingsColorsPlayers.Controls.Add(picPlayersSpecial);
            mcSettingsColorsPlayers.Controls.Add(lblSettingsColorsPlayersSpecial);
            mcSettingsColorsPlayers.Controls.Add(picPlayersTeamHover);
            mcSettingsColorsPlayers.Controls.Add(lblSettingsColorsPlayersTeamHover);
            mcSettingsColorsPlayers.Controls.Add(picPlayersTeammate);
            mcSettingsColorsPlayers.Controls.Add(lblSettingsColorsPlayersTeammate);
            mcSettingsColorsPlayers.Controls.Add(picPlayersLocalPlayer);
            mcSettingsColorsPlayers.Controls.Add(lblSettingsColorsPlayersLocalPlayer);
            mcSettingsColorsPlayers.Controls.Add(picPlayersScav);
            mcSettingsColorsPlayers.Controls.Add(lblSettingsColorsPlayersScav);
            mcSettingsColorsPlayers.Controls.Add(picPlayersBEAR);
            mcSettingsColorsPlayers.Controls.Add(lblSettingsColorsPlayersBEAR);
            mcSettingsColorsPlayers.Controls.Add(picPlayersUSEC);
            mcSettingsColorsPlayers.Controls.Add(lblSettingsColorsPlayersUSEC);
            mcSettingsColorsPlayers.Controls.Add(lblSettingsColorsPlayers);
            mcSettingsColorsPlayers.Depth = 0;
            mcSettingsColorsPlayers.ForeColor = Color.FromArgb(222, 0, 0, 0);
            mcSettingsColorsPlayers.Location = new Point(280, 16);
            mcSettingsColorsPlayers.Margin = new Padding(16);
            mcSettingsColorsPlayers.MouseState = MaterialSkin.MouseState.HOVER;
            mcSettingsColorsPlayers.Name = "mcSettingsColorsPlayers";
            mcSettingsColorsPlayers.Padding = new Padding(16);
            mcSettingsColorsPlayers.Size = new Size(202, 365);
            mcSettingsColorsPlayers.TabIndex = 40;
            // 
            // picPlayersSpecial
            // 
            picPlayersSpecial.BackColor = Color.Transparent;
            picPlayersSpecial.BorderStyle = BorderStyle.FixedSingle;
            picPlayersSpecial.Location = new Point(114, 255);
            picPlayersSpecial.Name = "picPlayersSpecial";
            picPlayersSpecial.Size = new Size(80, 26);
            picPlayersSpecial.TabIndex = 58;
            picPlayersSpecial.TabStop = false;
            picPlayersSpecial.Click += picPlayersSpecial_Click;
            // 
            // lblSettingsColorsPlayersSpecial
            // 
            lblSettingsColorsPlayersSpecial.AutoSize = true;
            lblSettingsColorsPlayersSpecial.Depth = 0;
            lblSettingsColorsPlayersSpecial.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblSettingsColorsPlayersSpecial.FontType = MaterialSkin.MaterialSkinManager.fontType.Body2;
            lblSettingsColorsPlayersSpecial.Location = new Point(32, 255);
            lblSettingsColorsPlayersSpecial.MouseState = MaterialSkin.MouseState.HOVER;
            lblSettingsColorsPlayersSpecial.Name = "lblSettingsColorsPlayersSpecial";
            lblSettingsColorsPlayersSpecial.Size = new Size(60, 17);
            lblSettingsColorsPlayersSpecial.TabIndex = 57;
            lblSettingsColorsPlayersSpecial.Text = "特殊玩家:";
            // 
            // picPlayersTeamHover
            // 
            picPlayersTeamHover.BackColor = Color.Transparent;
            picPlayersTeamHover.BorderStyle = BorderStyle.FixedSingle;
            picPlayersTeamHover.Location = new Point(114, 221);
            picPlayersTeamHover.Name = "picPlayersTeamHover";
            picPlayersTeamHover.Size = new Size(80, 26);
            picPlayersTeamHover.TabIndex = 56;
            picPlayersTeamHover.TabStop = false;
            picPlayersTeamHover.Click += picPlayersTeamHover_Click;
            // 
            // lblSettingsColorsPlayersTeamHover
            // 
            lblSettingsColorsPlayersTeamHover.AutoSize = true;
            lblSettingsColorsPlayersTeamHover.Depth = 0;
            lblSettingsColorsPlayersTeamHover.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblSettingsColorsPlayersTeamHover.FontType = MaterialSkin.MaterialSkinManager.fontType.Body2;
            lblSettingsColorsPlayersTeamHover.Location = new Point(32, 221);
            lblSettingsColorsPlayersTeamHover.MouseState = MaterialSkin.MouseState.HOVER;
            lblSettingsColorsPlayersTeamHover.Name = "lblSettingsColorsPlayersTeamHover";
            lblSettingsColorsPlayersTeamHover.Size = new Size(60, 17);
            lblSettingsColorsPlayersTeamHover.TabIndex = 55;
            lblSettingsColorsPlayersTeamHover.Text = "团队悬停:";
            // 
            // picPlayersTeammate
            // 
            picPlayersTeammate.BackColor = Color.Transparent;
            picPlayersTeammate.BorderStyle = BorderStyle.FixedSingle;
            picPlayersTeammate.Location = new Point(114, 187);
            picPlayersTeammate.Name = "picPlayersTeammate";
            picPlayersTeammate.Size = new Size(80, 26);
            picPlayersTeammate.TabIndex = 54;
            picPlayersTeammate.TabStop = false;
            picPlayersTeammate.Click += picPlayersTeammate_Click;
            // 
            // lblSettingsColorsPlayersTeammate
            // 
            lblSettingsColorsPlayersTeammate.AutoSize = true;
            lblSettingsColorsPlayersTeammate.Depth = 0;
            lblSettingsColorsPlayersTeammate.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblSettingsColorsPlayersTeammate.FontType = MaterialSkin.MaterialSkinManager.fontType.Body2;
            lblSettingsColorsPlayersTeammate.Location = new Point(63, 187);
            lblSettingsColorsPlayersTeammate.MouseState = MaterialSkin.MouseState.HOVER;
            lblSettingsColorsPlayersTeammate.Name = "lblSettingsColorsPlayersTeammate";
            lblSettingsColorsPlayersTeammate.Size = new Size(32, 17);
            lblSettingsColorsPlayersTeammate.TabIndex = 53;
            lblSettingsColorsPlayersTeammate.Text = "队友:";
            // 
            // picPlayersLocalPlayer
            // 
            picPlayersLocalPlayer.BackColor = Color.Transparent;
            picPlayersLocalPlayer.BorderStyle = BorderStyle.FixedSingle;
            picPlayersLocalPlayer.Location = new Point(114, 153);
            picPlayersLocalPlayer.Name = "picPlayersLocalPlayer";
            picPlayersLocalPlayer.Size = new Size(80, 26);
            picPlayersLocalPlayer.TabIndex = 52;
            picPlayersLocalPlayer.TabStop = false;
            picPlayersLocalPlayer.Click += picPlayersLocalPlayer_Click;
            // 
            // lblSettingsColorsPlayersLocalPlayer
            // 
            lblSettingsColorsPlayersLocalPlayer.AutoSize = true;
            lblSettingsColorsPlayersLocalPlayer.Depth = 0;
            lblSettingsColorsPlayersLocalPlayer.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblSettingsColorsPlayersLocalPlayer.FontType = MaterialSkin.MaterialSkinManager.fontType.Body2;
            lblSettingsColorsPlayersLocalPlayer.Location = new Point(66, 153);
            lblSettingsColorsPlayersLocalPlayer.MouseState = MaterialSkin.MouseState.HOVER;
            lblSettingsColorsPlayersLocalPlayer.Name = "lblSettingsColorsPlayersLocalPlayer";
            lblSettingsColorsPlayersLocalPlayer.Size = new Size(29, 17);
            lblSettingsColorsPlayersLocalPlayer.TabIndex = 51;
            lblSettingsColorsPlayersLocalPlayer.Text = "玩家";
            // 
            // picPlayersScav
            // 
            picPlayersScav.BackColor = Color.Transparent;
            picPlayersScav.BorderStyle = BorderStyle.FixedSingle;
            picPlayersScav.Location = new Point(114, 119);
            picPlayersScav.Name = "picPlayersScav";
            picPlayersScav.Size = new Size(80, 26);
            picPlayersScav.TabIndex = 50;
            picPlayersScav.TabStop = false;
            picPlayersScav.Click += picPlayersScav_Click;
            // 
            // lblSettingsColorsPlayersScav
            // 
            lblSettingsColorsPlayersScav.AutoSize = true;
            lblSettingsColorsPlayersScav.Depth = 0;
            lblSettingsColorsPlayersScav.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblSettingsColorsPlayersScav.FontType = MaterialSkin.MaterialSkinManager.fontType.Body2;
            lblSettingsColorsPlayersScav.Location = new Point(61, 119);
            lblSettingsColorsPlayersScav.MouseState = MaterialSkin.MouseState.HOVER;
            lblSettingsColorsPlayersScav.Name = "lblSettingsColorsPlayersScav";
            lblSettingsColorsPlayersScav.Size = new Size(34, 17);
            lblSettingsColorsPlayersScav.TabIndex = 49;
            lblSettingsColorsPlayersScav.Text = "Scav:";
            // 
            // picPlayersBEAR
            // 
            picPlayersBEAR.BackColor = Color.Transparent;
            picPlayersBEAR.BorderStyle = BorderStyle.FixedSingle;
            picPlayersBEAR.Location = new Point(114, 85);
            picPlayersBEAR.Name = "picPlayersBEAR";
            picPlayersBEAR.Size = new Size(80, 26);
            picPlayersBEAR.TabIndex = 48;
            picPlayersBEAR.TabStop = false;
            picPlayersBEAR.Click += picPlayersBEAR_Click;
            // 
            // lblSettingsColorsPlayersBEAR
            // 
            lblSettingsColorsPlayersBEAR.AutoSize = true;
            lblSettingsColorsPlayersBEAR.Depth = 0;
            lblSettingsColorsPlayersBEAR.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblSettingsColorsPlayersBEAR.FontType = MaterialSkin.MaterialSkinManager.fontType.Body2;
            lblSettingsColorsPlayersBEAR.Location = new Point(63, 85);
            lblSettingsColorsPlayersBEAR.MouseState = MaterialSkin.MouseState.HOVER;
            lblSettingsColorsPlayersBEAR.Name = "lblSettingsColorsPlayersBEAR";
            lblSettingsColorsPlayersBEAR.Size = new Size(32, 17);
            lblSettingsColorsPlayersBEAR.TabIndex = 47;
            lblSettingsColorsPlayersBEAR.Text = "俄军:";
            // 
            // picPlayersUSEC
            // 
            picPlayersUSEC.BackColor = Color.Transparent;
            picPlayersUSEC.BorderStyle = BorderStyle.FixedSingle;
            picPlayersUSEC.Location = new Point(114, 51);
            picPlayersUSEC.Name = "picPlayersUSEC";
            picPlayersUSEC.Size = new Size(80, 26);
            picPlayersUSEC.TabIndex = 46;
            picPlayersUSEC.TabStop = false;
            picPlayersUSEC.Click += picPlayersUSEC_Click;
            // 
            // lblSettingsColorsPlayersUSEC
            // 
            lblSettingsColorsPlayersUSEC.AutoSize = true;
            lblSettingsColorsPlayersUSEC.Depth = 0;
            lblSettingsColorsPlayersUSEC.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblSettingsColorsPlayersUSEC.FontType = MaterialSkin.MaterialSkinManager.fontType.Body2;
            lblSettingsColorsPlayersUSEC.Location = new Point(64, 51);
            lblSettingsColorsPlayersUSEC.MouseState = MaterialSkin.MouseState.HOVER;
            lblSettingsColorsPlayersUSEC.Name = "lblSettingsColorsPlayersUSEC";
            lblSettingsColorsPlayersUSEC.Size = new Size(32, 17);
            lblSettingsColorsPlayersUSEC.TabIndex = 44;
            lblSettingsColorsPlayersUSEC.Text = "美军:";
            // 
            // lblSettingsColorsPlayers
            // 
            lblSettingsColorsPlayers.AutoSize = true;
            lblSettingsColorsPlayers.Depth = 0;
            lblSettingsColorsPlayers.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            lblSettingsColorsPlayers.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            lblSettingsColorsPlayers.HighEmphasis = true;
            lblSettingsColorsPlayers.Location = new Point(19, 14);
            lblSettingsColorsPlayers.MouseState = MaterialSkin.MouseState.HOVER;
            lblSettingsColorsPlayers.Name = "lblSettingsColorsPlayers";
            lblSettingsColorsPlayers.Size = new Size(41, 24);
            lblSettingsColorsPlayers.TabIndex = 33;
            lblSettingsColorsPlayers.Text = "玩家";
            lblSettingsColorsPlayers.UseAccent = true;
            // 
            // mcSettingsColorsAI
            // 
            mcSettingsColorsAI.BackColor = Color.FromArgb(255, 255, 255);
            mcSettingsColorsAI.Controls.Add(picAIOther);
            mcSettingsColorsAI.Controls.Add(lblSettingsColorsAIOther);
            mcSettingsColorsAI.Controls.Add(picAIScav);
            mcSettingsColorsAI.Controls.Add(lblSettingsColorsAIScav);
            mcSettingsColorsAI.Controls.Add(picAIFollowerOfMorana);
            mcSettingsColorsAI.Controls.Add(lblSettingsColorsAIMoranaFollower);
            mcSettingsColorsAI.Controls.Add(picAICultist);
            mcSettingsColorsAI.Controls.Add(lblSettingsColorsAICultists);
            mcSettingsColorsAI.Controls.Add(picAIRogue);
            mcSettingsColorsAI.Controls.Add(lblSettingsColorsAIRogues);
            mcSettingsColorsAI.Controls.Add(picAIRaider);
            mcSettingsColorsAI.Controls.Add(lblSettingsColorsAIRaiders);
            mcSettingsColorsAI.Controls.Add(picAIBossFollower);
            mcSettingsColorsAI.Controls.Add(lblSettingsColorsAIBossFollower);
            mcSettingsColorsAI.Controls.Add(picAIBossGuard);
            mcSettingsColorsAI.Controls.Add(lblSettingsColorsAIBossGuard);
            mcSettingsColorsAI.Controls.Add(picAIBoss);
            mcSettingsColorsAI.Controls.Add(lblSettingsColorsAIBoss);
            mcSettingsColorsAI.Controls.Add(lblSettingsColorsAI);
            mcSettingsColorsAI.Depth = 0;
            mcSettingsColorsAI.ForeColor = Color.FromArgb(222, 0, 0, 0);
            mcSettingsColorsAI.Location = new Point(17, 16);
            mcSettingsColorsAI.Margin = new Padding(16);
            mcSettingsColorsAI.MouseState = MaterialSkin.MouseState.HOVER;
            mcSettingsColorsAI.Name = "mcSettingsColorsAI";
            mcSettingsColorsAI.Padding = new Padding(16);
            mcSettingsColorsAI.Size = new Size(237, 365);
            mcSettingsColorsAI.TabIndex = 39;
            // 
            // picAIOther
            // 
            picAIOther.BackColor = Color.Transparent;
            picAIOther.BorderStyle = BorderStyle.FixedSingle;
            picAIOther.Location = new Point(149, 323);
            picAIOther.Name = "picAIOther";
            picAIOther.Size = new Size(80, 26);
            picAIOther.TabIndex = 62;
            picAIOther.TabStop = false;
            picAIOther.Click += picAIOther_Click;
            // 
            // lblSettingsColorsAIOther
            // 
            lblSettingsColorsAIOther.AutoSize = true;
            lblSettingsColorsAIOther.Depth = 0;
            lblSettingsColorsAIOther.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblSettingsColorsAIOther.FontType = MaterialSkin.MaterialSkinManager.fontType.Body2;
            lblSettingsColorsAIOther.Location = new Point(98, 323);
            lblSettingsColorsAIOther.MouseState = MaterialSkin.MouseState.HOVER;
            lblSettingsColorsAIOther.Name = "lblSettingsColorsAIOther";
            lblSettingsColorsAIOther.Size = new Size(32, 17);
            lblSettingsColorsAIOther.TabIndex = 61;
            lblSettingsColorsAIOther.Text = "其他:";
            // 
            // picAIScav
            // 
            picAIScav.BackColor = Color.Transparent;
            picAIScav.BorderStyle = BorderStyle.FixedSingle;
            picAIScav.Location = new Point(149, 289);
            picAIScav.Name = "picAIScav";
            picAIScav.Size = new Size(80, 26);
            picAIScav.TabIndex = 60;
            picAIScav.TabStop = false;
            picAIScav.Click += picAIScav_Click;
            // 
            // lblSettingsColorsAIScav
            // 
            lblSettingsColorsAIScav.AutoSize = true;
            lblSettingsColorsAIScav.Depth = 0;
            lblSettingsColorsAIScav.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblSettingsColorsAIScav.FontType = MaterialSkin.MaterialSkinManager.fontType.Body2;
            lblSettingsColorsAIScav.Location = new Point(95, 289);
            lblSettingsColorsAIScav.MouseState = MaterialSkin.MouseState.HOVER;
            lblSettingsColorsAIScav.Name = "lblSettingsColorsAIScav";
            lblSettingsColorsAIScav.Size = new Size(34, 17);
            lblSettingsColorsAIScav.TabIndex = 59;
            lblSettingsColorsAIScav.Text = "Scav:";
            // 
            // picAIFollowerOfMorana
            // 
            picAIFollowerOfMorana.BackColor = Color.Transparent;
            picAIFollowerOfMorana.BorderStyle = BorderStyle.FixedSingle;
            picAIFollowerOfMorana.Location = new Point(149, 255);
            picAIFollowerOfMorana.Name = "picAIFollowerOfMorana";
            picAIFollowerOfMorana.Size = new Size(80, 26);
            picAIFollowerOfMorana.TabIndex = 58;
            picAIFollowerOfMorana.TabStop = false;
            picAIFollowerOfMorana.Click += picAIFollowerOfMorana_Click;
            // 
            // lblSettingsColorsAIMoranaFollower
            // 
            lblSettingsColorsAIMoranaFollower.AutoSize = true;
            lblSettingsColorsAIMoranaFollower.Depth = 0;
            lblSettingsColorsAIMoranaFollower.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblSettingsColorsAIMoranaFollower.FontType = MaterialSkin.MaterialSkinManager.fontType.Body2;
            lblSettingsColorsAIMoranaFollower.Location = new Point(19, 255);
            lblSettingsColorsAIMoranaFollower.MouseState = MaterialSkin.MouseState.HOVER;
            lblSettingsColorsAIMoranaFollower.Name = "lblSettingsColorsAIMoranaFollower";
            lblSettingsColorsAIMoranaFollower.Size = new Size(98, 17);
            lblSettingsColorsAIMoranaFollower.TabIndex = 57;
            lblSettingsColorsAIMoranaFollower.Text = "Morana 追随者:";
            lblSettingsColorsAIMoranaFollower.Click += lblSettingsColorsAIMoranaFollower_Click;
            // 
            // picAICultist
            // 
            picAICultist.BackColor = Color.Transparent;
            picAICultist.BorderStyle = BorderStyle.FixedSingle;
            picAICultist.Location = new Point(149, 221);
            picAICultist.Name = "picAICultist";
            picAICultist.Size = new Size(80, 26);
            picAICultist.TabIndex = 56;
            picAICultist.TabStop = false;
            picAICultist.Click += picAICultist_Click;
            // 
            // lblSettingsColorsAICultists
            // 
            lblSettingsColorsAICultists.AutoSize = true;
            lblSettingsColorsAICultists.Depth = 0;
            lblSettingsColorsAICultists.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblSettingsColorsAICultists.FontType = MaterialSkin.MaterialSkinManager.fontType.Body2;
            lblSettingsColorsAICultists.Location = new Point(83, 221);
            lblSettingsColorsAICultists.MouseState = MaterialSkin.MouseState.HOVER;
            lblSettingsColorsAICultists.Name = "lblSettingsColorsAICultists";
            lblSettingsColorsAICultists.Size = new Size(46, 17);
            lblSettingsColorsAICultists.TabIndex = 55;
            lblSettingsColorsAICultists.Text = "邪教徒:";
            // 
            // picAIRogue
            // 
            picAIRogue.BackColor = Color.Transparent;
            picAIRogue.BorderStyle = BorderStyle.FixedSingle;
            picAIRogue.Location = new Point(149, 187);
            picAIRogue.Name = "picAIRogue";
            picAIRogue.Size = new Size(80, 26);
            picAIRogue.TabIndex = 54;
            picAIRogue.TabStop = false;
            picAIRogue.Click += picAIRogue_Click;
            // 
            // lblSettingsColorsAIRogues
            // 
            lblSettingsColorsAIRogues.AutoSize = true;
            lblSettingsColorsAIRogues.Depth = 0;
            lblSettingsColorsAIRogues.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblSettingsColorsAIRogues.FontType = MaterialSkin.MaterialSkinManager.fontType.Body2;
            lblSettingsColorsAIRogues.Location = new Point(83, 187);
            lblSettingsColorsAIRogues.MouseState = MaterialSkin.MouseState.HOVER;
            lblSettingsColorsAIRogues.Name = "lblSettingsColorsAIRogues";
            lblSettingsColorsAIRogues.Size = new Size(46, 17);
            lblSettingsColorsAIRogues.TabIndex = 53;
            lblSettingsColorsAIRogues.Text = "流浪者:";
            // 
            // picAIRaider
            // 
            picAIRaider.BackColor = Color.Transparent;
            picAIRaider.BorderStyle = BorderStyle.FixedSingle;
            picAIRaider.Location = new Point(149, 153);
            picAIRaider.Name = "picAIRaider";
            picAIRaider.Size = new Size(80, 26);
            picAIRaider.TabIndex = 52;
            picAIRaider.TabStop = false;
            picAIRaider.Click += picAIRaider_Click;
            // 
            // lblSettingsColorsAIRaiders
            // 
            lblSettingsColorsAIRaiders.AutoSize = true;
            lblSettingsColorsAIRaiders.Depth = 0;
            lblSettingsColorsAIRaiders.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblSettingsColorsAIRaiders.FontType = MaterialSkin.MaterialSkinManager.fontType.Body2;
            lblSettingsColorsAIRaiders.Location = new Point(83, 153);
            lblSettingsColorsAIRaiders.MouseState = MaterialSkin.MouseState.HOVER;
            lblSettingsColorsAIRaiders.Name = "lblSettingsColorsAIRaiders";
            lblSettingsColorsAIRaiders.Size = new Size(45, 17);
            lblSettingsColorsAIRaiders.TabIndex = 51;
            lblSettingsColorsAIRaiders.Text = "精英AI:";
            // 
            // picAIBossFollower
            // 
            picAIBossFollower.BackColor = Color.Transparent;
            picAIBossFollower.BorderStyle = BorderStyle.FixedSingle;
            picAIBossFollower.Location = new Point(149, 119);
            picAIBossFollower.Name = "picAIBossFollower";
            picAIBossFollower.Size = new Size(80, 26);
            picAIBossFollower.TabIndex = 50;
            picAIBossFollower.TabStop = false;
            picAIBossFollower.Click += picAIBossFollower_Click;
            // 
            // lblSettingsColorsAIBossFollower
            // 
            lblSettingsColorsAIBossFollower.AutoSize = true;
            lblSettingsColorsAIBossFollower.Depth = 0;
            lblSettingsColorsAIBossFollower.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblSettingsColorsAIBossFollower.FontType = MaterialSkin.MaterialSkinManager.fontType.Body2;
            lblSettingsColorsAIBossFollower.Location = new Point(45, 120);
            lblSettingsColorsAIBossFollower.MouseState = MaterialSkin.MouseState.HOVER;
            lblSettingsColorsAIBossFollower.Name = "lblSettingsColorsAIBossFollower";
            lblSettingsColorsAIBossFollower.Size = new Size(80, 17);
            lblSettingsColorsAIBossFollower.TabIndex = 49;
            lblSettingsColorsAIBossFollower.Text = "Boss 追随者:";
            // 
            // picAIBossGuard
            // 
            picAIBossGuard.BackColor = Color.Transparent;
            picAIBossGuard.BorderStyle = BorderStyle.FixedSingle;
            picAIBossGuard.Location = new Point(149, 85);
            picAIBossGuard.Name = "picAIBossGuard";
            picAIBossGuard.Size = new Size(80, 26);
            picAIBossGuard.TabIndex = 48;
            picAIBossGuard.TabStop = false;
            picAIBossGuard.Click += picAIBossGuard_Click;
            // 
            // lblSettingsColorsAIBossGuard
            // 
            lblSettingsColorsAIBossGuard.AutoSize = true;
            lblSettingsColorsAIBossGuard.Depth = 0;
            lblSettingsColorsAIBossGuard.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblSettingsColorsAIBossGuard.FontType = MaterialSkin.MaterialSkinManager.fontType.Body2;
            lblSettingsColorsAIBossGuard.Location = new Point(64, 86);
            lblSettingsColorsAIBossGuard.MouseState = MaterialSkin.MouseState.HOVER;
            lblSettingsColorsAIBossGuard.Name = "lblSettingsColorsAIBossGuard";
            lblSettingsColorsAIBossGuard.Size = new Size(63, 17);
            lblSettingsColorsAIBossGuard.TabIndex = 47;
            lblSettingsColorsAIBossGuard.Text = "Boss 警卫";
            // 
            // picAIBoss
            // 
            picAIBoss.BackColor = Color.Transparent;
            picAIBoss.BorderStyle = BorderStyle.FixedSingle;
            picAIBoss.Location = new Point(149, 51);
            picAIBoss.Name = "picAIBoss";
            picAIBoss.Size = new Size(80, 26);
            picAIBoss.TabIndex = 46;
            picAIBoss.TabStop = false;
            picAIBoss.Click += picAIBoss_Click;
            // 
            // lblSettingsColorsAIBoss
            // 
            lblSettingsColorsAIBoss.AutoSize = true;
            lblSettingsColorsAIBoss.Depth = 0;
            lblSettingsColorsAIBoss.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblSettingsColorsAIBoss.FontType = MaterialSkin.MaterialSkinManager.fontType.Body2;
            lblSettingsColorsAIBoss.Location = new Point(97, 51);
            lblSettingsColorsAIBoss.MouseState = MaterialSkin.MouseState.HOVER;
            lblSettingsColorsAIBoss.Name = "lblSettingsColorsAIBoss";
            lblSettingsColorsAIBoss.Size = new Size(35, 17);
            lblSettingsColorsAIBoss.TabIndex = 44;
            lblSettingsColorsAIBoss.Text = "Boss:";
            lblSettingsColorsAIBoss.Click += lblSettingsColorsAIBoss_Click;
            // 
            // lblSettingsColorsAI
            // 
            lblSettingsColorsAI.AutoSize = true;
            lblSettingsColorsAI.Depth = 0;
            lblSettingsColorsAI.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            lblSettingsColorsAI.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            lblSettingsColorsAI.HighEmphasis = true;
            lblSettingsColorsAI.Location = new Point(19, 14);
            lblSettingsColorsAI.MouseState = MaterialSkin.MouseState.HOVER;
            lblSettingsColorsAI.Name = "lblSettingsColorsAI";
            lblSettingsColorsAI.Size = new Size(60, 24);
            lblSettingsColorsAI.TabIndex = 33;
            lblSettingsColorsAI.Text = "AI选项";
            lblSettingsColorsAI.UseAccent = true;
            // 
            // tabPlayerLoadouts
            // 
            tabPlayerLoadouts.BackColor = Color.White;
            tabPlayerLoadouts.Controls.Add(mcPlayerLoadoutsAI);
            tabPlayerLoadouts.Controls.Add(mcPlayerLoadoutsPlayers);
            tabPlayerLoadouts.ImageKey = "loadouts.png";
            tabPlayerLoadouts.Location = new Point(4, 39);
            tabPlayerLoadouts.Name = "tabPlayerLoadouts";
            tabPlayerLoadouts.Size = new Size(1483, 803);
            tabPlayerLoadouts.TabIndex = 2;
            tabPlayerLoadouts.Text = "玩家";
            // 
            // mcPlayerLoadoutsAI
            // 
            mcPlayerLoadoutsAI.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            mcPlayerLoadoutsAI.BackColor = Color.FromArgb(255, 255, 255);
            mcPlayerLoadoutsAI.Controls.Add(lblPlayerLoadoutsAI);
            mcPlayerLoadoutsAI.Controls.Add(flpPlayerLoadoutsAI);
            mcPlayerLoadoutsAI.Depth = 0;
            mcPlayerLoadoutsAI.ForeColor = Color.FromArgb(222, 0, 0, 0);
            mcPlayerLoadoutsAI.Location = new Point(719, 6);
            mcPlayerLoadoutsAI.Margin = new Padding(0);
            mcPlayerLoadoutsAI.MaximumSize = new Size(686, 1020);
            mcPlayerLoadoutsAI.MouseState = MaterialSkin.MouseState.HOVER;
            mcPlayerLoadoutsAI.Name = "mcPlayerLoadoutsAI";
            mcPlayerLoadoutsAI.Padding = new Padding(16);
            mcPlayerLoadoutsAI.Size = new Size(686, 768);
            mcPlayerLoadoutsAI.TabIndex = 3;
            // 
            // lblPlayerLoadoutsAI
            // 
            lblPlayerLoadoutsAI.AutoSize = true;
            lblPlayerLoadoutsAI.Depth = 0;
            lblPlayerLoadoutsAI.Dock = DockStyle.Top;
            lblPlayerLoadoutsAI.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            lblPlayerLoadoutsAI.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            lblPlayerLoadoutsAI.HighEmphasis = true;
            lblPlayerLoadoutsAI.Location = new Point(16, 16);
            lblPlayerLoadoutsAI.MouseState = MaterialSkin.MouseState.HOVER;
            lblPlayerLoadoutsAI.Name = "lblPlayerLoadoutsAI";
            lblPlayerLoadoutsAI.Size = new Size(360, 24);
            lblPlayerLoadoutsAI.TabIndex = 31;
            lblPlayerLoadoutsAI.Text = "Bosses / Rogues / Guards / AI Scavs etc";
            lblPlayerLoadoutsAI.UseAccent = true;
            // 
            // flpPlayerLoadoutsAI
            // 
            flpPlayerLoadoutsAI.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flpPlayerLoadoutsAI.AutoScroll = true;
            flpPlayerLoadoutsAI.FlowDirection = FlowDirection.TopDown;
            flpPlayerLoadoutsAI.Location = new Point(3, 57);
            flpPlayerLoadoutsAI.Name = "flpPlayerLoadoutsAI";
            flpPlayerLoadoutsAI.Size = new Size(679, 707);
            flpPlayerLoadoutsAI.TabIndex = 0;
            flpPlayerLoadoutsAI.WrapContents = false;
            // 
            // mcPlayerLoadoutsPlayers
            // 
            mcPlayerLoadoutsPlayers.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            mcPlayerLoadoutsPlayers.BackColor = Color.FromArgb(255, 255, 255);
            mcPlayerLoadoutsPlayers.Controls.Add(lblPlayerLoadoutsPlayers);
            mcPlayerLoadoutsPlayers.Controls.Add(flpPlayerLoadoutsPlayers);
            mcPlayerLoadoutsPlayers.Depth = 0;
            mcPlayerLoadoutsPlayers.ForeColor = Color.FromArgb(222, 0, 0, 0);
            mcPlayerLoadoutsPlayers.Location = new Point(17, 6);
            mcPlayerLoadoutsPlayers.Margin = new Padding(0);
            mcPlayerLoadoutsPlayers.MaximumSize = new Size(686, 1020);
            mcPlayerLoadoutsPlayers.MouseState = MaterialSkin.MouseState.HOVER;
            mcPlayerLoadoutsPlayers.Name = "mcPlayerLoadoutsPlayers";
            mcPlayerLoadoutsPlayers.Padding = new Padding(16);
            mcPlayerLoadoutsPlayers.Size = new Size(686, 768);
            mcPlayerLoadoutsPlayers.TabIndex = 2;
            // 
            // lblPlayerLoadoutsPlayers
            // 
            lblPlayerLoadoutsPlayers.AutoSize = true;
            lblPlayerLoadoutsPlayers.Depth = 0;
            lblPlayerLoadoutsPlayers.Dock = DockStyle.Top;
            lblPlayerLoadoutsPlayers.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            lblPlayerLoadoutsPlayers.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            lblPlayerLoadoutsPlayers.HighEmphasis = true;
            lblPlayerLoadoutsPlayers.Location = new Point(16, 16);
            lblPlayerLoadoutsPlayers.MouseState = MaterialSkin.MouseState.HOVER;
            lblPlayerLoadoutsPlayers.Name = "lblPlayerLoadoutsPlayers";
            lblPlayerLoadoutsPlayers.Size = new Size(41, 24);
            lblPlayerLoadoutsPlayers.TabIndex = 31;
            lblPlayerLoadoutsPlayers.Text = "玩家";
            lblPlayerLoadoutsPlayers.UseAccent = true;
            // 
            // flpPlayerLoadoutsPlayers
            // 
            flpPlayerLoadoutsPlayers.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flpPlayerLoadoutsPlayers.AutoScroll = true;
            flpPlayerLoadoutsPlayers.FlowDirection = FlowDirection.TopDown;
            flpPlayerLoadoutsPlayers.Location = new Point(3, 57);
            flpPlayerLoadoutsPlayers.Name = "flpPlayerLoadoutsPlayers";
            flpPlayerLoadoutsPlayers.Size = new Size(679, 707);
            flpPlayerLoadoutsPlayers.TabIndex = 0;
            flpPlayerLoadoutsPlayers.WrapContents = false;
            // 
            // tabWatchlist
            // 
            tabWatchlist.BackColor = Color.White;
            tabWatchlist.Controls.Add(mcWatchlistPlayerlist);
            tabWatchlist.Controls.Add(mcWatchlistProfiles);
            tabWatchlist.Controls.Add(mcWatchlistPlayerManagement);
            tabWatchlist.Controls.Add(lstWatchlistEntries);
            tabWatchlist.ImageKey = "watchlist.png";
            tabWatchlist.Location = new Point(4, 39);
            tabWatchlist.Name = "tabWatchlist";
            tabWatchlist.Size = new Size(1483, 803);
            tabWatchlist.TabIndex = 3;
            tabWatchlist.Text = "监视列表";
            // 
            // mcWatchlistPlayerlist
            // 
            mcWatchlistPlayerlist.BackColor = Color.FromArgb(255, 255, 255);
            mcWatchlistPlayerlist.Controls.Add(lstWatchlistPlayerList);
            mcWatchlistPlayerlist.Controls.Add(btnResetPlayerlist);
            mcWatchlistPlayerlist.Controls.Add(lblWatchlistPlayerlist);
            mcWatchlistPlayerlist.Depth = 0;
            mcWatchlistPlayerlist.ForeColor = Color.FromArgb(222, 0, 0, 0);
            mcWatchlistPlayerlist.Location = new Point(1080, 6);
            mcWatchlistPlayerlist.Margin = new Padding(16);
            mcWatchlistPlayerlist.MouseState = MaterialSkin.MouseState.HOVER;
            mcWatchlistPlayerlist.Name = "mcWatchlistPlayerlist";
            mcWatchlistPlayerlist.Padding = new Padding(16);
            mcWatchlistPlayerlist.Size = new Size(264, 717);
            mcWatchlistPlayerlist.TabIndex = 48;
            // 
            // lstWatchlistPlayerList
            // 
            lstWatchlistPlayerList.AutoSizeTable = false;
            lstWatchlistPlayerList.BackColor = Color.FromArgb(255, 255, 255);
            lstWatchlistPlayerList.BorderStyle = BorderStyle.None;
            lstWatchlistPlayerList.Columns.AddRange(new ColumnHeader[] { colPlayerlistName });
            lstWatchlistPlayerList.Depth = 0;
            lstWatchlistPlayerList.FullRowSelect = true;
            lstWatchlistPlayerList.Location = new Point(19, 59);
            lstWatchlistPlayerList.MinimumSize = new Size(114, 113);
            lstWatchlistPlayerList.MouseLocation = new Point(-1, -1);
            lstWatchlistPlayerList.MouseState = MaterialSkin.MouseState.OUT;
            lstWatchlistPlayerList.Name = "lstWatchlistPlayerList";
            lstWatchlistPlayerList.OwnerDraw = true;
            lstWatchlistPlayerList.Size = new Size(225, 589);
            lstWatchlistPlayerList.TabIndex = 48;
            lstWatchlistPlayerList.UseCompatibleStateImageBehavior = false;
            lstWatchlistPlayerList.View = View.Details;
            // 
            // colPlayerlistName
            // 
            colPlayerlistName.Text = "Name";
            colPlayerlistName.Width = 197;
            // 
            // lblWatchlistPlayerlist
            // 
            lblWatchlistPlayerlist.AutoSize = true;
            lblWatchlistPlayerlist.Depth = 0;
            lblWatchlistPlayerlist.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            lblWatchlistPlayerlist.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            lblWatchlistPlayerlist.HighEmphasis = true;
            lblWatchlistPlayerlist.Location = new Point(19, 17);
            lblWatchlistPlayerlist.MouseState = MaterialSkin.MouseState.HOVER;
            lblWatchlistPlayerlist.Name = "lblWatchlistPlayerlist";
            lblWatchlistPlayerlist.Size = new Size(81, 24);
            lblWatchlistPlayerlist.TabIndex = 30;
            lblWatchlistPlayerlist.Text = "玩家列表";
            lblWatchlistPlayerlist.UseAccent = true;
            // 
            // mcWatchlistProfiles
            // 
            mcWatchlistProfiles.BackColor = Color.FromArgb(255, 255, 255);
            mcWatchlistProfiles.Controls.Add(lstWatchlistProfiles);
            mcWatchlistProfiles.Controls.Add(txtWatchlistProfileName);
            mcWatchlistProfiles.Controls.Add(lblWatchlistProfiles);
            mcWatchlistProfiles.Controls.Add(btnAddWatchlistEntry);
            mcWatchlistProfiles.Controls.Add(btnAddWatchlistProfile);
            mcWatchlistProfiles.Controls.Add(btnRemoveWatchlistProfile);
            mcWatchlistProfiles.Depth = 0;
            mcWatchlistProfiles.ForeColor = Color.FromArgb(222, 0, 0, 0);
            mcWatchlistProfiles.Location = new Point(514, 239);
            mcWatchlistProfiles.Margin = new Padding(16);
            mcWatchlistProfiles.MouseState = MaterialSkin.MouseState.HOVER;
            mcWatchlistProfiles.Name = "mcWatchlistProfiles";
            mcWatchlistProfiles.Padding = new Padding(16);
            mcWatchlistProfiles.Size = new Size(549, 483);
            mcWatchlistProfiles.TabIndex = 47;
            // 
            // lstWatchlistProfiles
            // 
            lstWatchlistProfiles.AutoSizeTable = false;
            lstWatchlistProfiles.BackColor = Color.FromArgb(255, 255, 255);
            lstWatchlistProfiles.BorderStyle = BorderStyle.None;
            lstWatchlistProfiles.Columns.AddRange(new ColumnHeader[] { colWatchlistProfileName });
            lstWatchlistProfiles.Depth = 0;
            lstWatchlistProfiles.FullRowSelect = true;
            lstWatchlistProfiles.Location = new Point(19, 54);
            lstWatchlistProfiles.MinimumSize = new Size(114, 113);
            lstWatchlistProfiles.MouseLocation = new Point(-1, -1);
            lstWatchlistProfiles.MouseState = MaterialSkin.MouseState.OUT;
            lstWatchlistProfiles.Name = "lstWatchlistProfiles";
            lstWatchlistProfiles.OwnerDraw = true;
            lstWatchlistProfiles.Size = new Size(211, 407);
            lstWatchlistProfiles.TabIndex = 49;
            lstWatchlistProfiles.UseCompatibleStateImageBehavior = false;
            lstWatchlistProfiles.View = View.Details;
            lstWatchlistProfiles.SelectedIndexChanged += lstWatchlistProfiles_SelectedIndexChanged;
            // 
            // colWatchlistProfileName
            // 
            colWatchlistProfileName.Text = "Name";
            colWatchlistProfileName.Width = 185;
            // 
            // lblWatchlistProfiles
            // 
            lblWatchlistProfiles.AutoSize = true;
            lblWatchlistProfiles.Depth = 0;
            lblWatchlistProfiles.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            lblWatchlistProfiles.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            lblWatchlistProfiles.HighEmphasis = true;
            lblWatchlistProfiles.Location = new Point(19, 16);
            lblWatchlistProfiles.MouseState = MaterialSkin.MouseState.HOVER;
            lblWatchlistProfiles.Name = "lblWatchlistProfiles";
            lblWatchlistProfiles.Size = new Size(70, 24);
            lblWatchlistProfiles.TabIndex = 33;
            lblWatchlistProfiles.Text = "Profiles";
            lblWatchlistProfiles.UseAccent = true;
            // 
            // mcWatchlistPlayerManagement
            // 
            mcWatchlistPlayerManagement.BackColor = Color.FromArgb(255, 255, 255);
            mcWatchlistPlayerManagement.Controls.Add(lblWatchlistPlayerManagement);
            mcWatchlistPlayerManagement.Controls.Add(txtWatchlistPlatformUsername);
            mcWatchlistPlayerManagement.Controls.Add(rdbYoutube);
            mcWatchlistPlayerManagement.Controls.Add(txtWatchlistAccountID);
            mcWatchlistPlayerManagement.Controls.Add(rdbTwitch);
            mcWatchlistPlayerManagement.Controls.Add(btnRemoveWatchlistEntry);
            mcWatchlistPlayerManagement.Controls.Add(swWatchlistIsStreamer);
            mcWatchlistPlayerManagement.Controls.Add(txtWatchlistTag);
            mcWatchlistPlayerManagement.Depth = 0;
            mcWatchlistPlayerManagement.ForeColor = Color.FromArgb(222, 0, 0, 0);
            mcWatchlistPlayerManagement.Location = new Point(514, 6);
            mcWatchlistPlayerManagement.Margin = new Padding(16);
            mcWatchlistPlayerManagement.MouseState = MaterialSkin.MouseState.HOVER;
            mcWatchlistPlayerManagement.Name = "mcWatchlistPlayerManagement";
            mcWatchlistPlayerManagement.Padding = new Padding(16);
            mcWatchlistPlayerManagement.Size = new Size(549, 217);
            mcWatchlistPlayerManagement.TabIndex = 46;
            // 
            // lblWatchlistPlayerManagement
            // 
            lblWatchlistPlayerManagement.AutoSize = true;
            lblWatchlistPlayerManagement.Depth = 0;
            lblWatchlistPlayerManagement.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            lblWatchlistPlayerManagement.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            lblWatchlistPlayerManagement.HighEmphasis = true;
            lblWatchlistPlayerManagement.Location = new Point(19, 17);
            lblWatchlistPlayerManagement.MouseState = MaterialSkin.MouseState.HOVER;
            lblWatchlistPlayerManagement.Name = "lblWatchlistPlayerManagement";
            lblWatchlistPlayerManagement.Size = new Size(81, 24);
            lblWatchlistPlayerManagement.TabIndex = 30;
            lblWatchlistPlayerManagement.Text = "玩家管理";
            lblWatchlistPlayerManagement.UseAccent = true;
            // 
            // lstWatchlistEntries
            // 
            lstWatchlistEntries.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lstWatchlistEntries.AutoSizeTable = false;
            lstWatchlistEntries.BackColor = Color.FromArgb(255, 255, 255);
            lstWatchlistEntries.BorderStyle = BorderStyle.None;
            lstWatchlistEntries.Columns.AddRange(new ColumnHeader[] { colWatchlistAccID, colWatchlistTag, colWatchlistUsername });
            lstWatchlistEntries.Depth = 0;
            lstWatchlistEntries.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lstWatchlistEntries.FullRowSelect = true;
            lstWatchlistEntries.Location = new Point(17, 6);
            lstWatchlistEntries.MaximumSize = new Size(480, 1020);
            lstWatchlistEntries.MinimumSize = new Size(229, 113);
            lstWatchlistEntries.MouseLocation = new Point(-1, -1);
            lstWatchlistEntries.MouseState = MaterialSkin.MouseState.OUT;
            lstWatchlistEntries.MultiSelect = false;
            lstWatchlistEntries.Name = "lstWatchlistEntries";
            lstWatchlistEntries.OwnerDraw = true;
            lstWatchlistEntries.Size = new Size(480, 781);
            lstWatchlistEntries.TabIndex = 37;
            lstWatchlistEntries.UseCompatibleStateImageBehavior = false;
            lstWatchlistEntries.View = View.Details;
            lstWatchlistEntries.SelectedIndexChanged += lstViewWatchlistEntries_SelectedIndexChanged;
            // 
            // colWatchlistAccID
            // 
            colWatchlistAccID.Text = "账户编号";
            colWatchlistAccID.Width = 97;
            // 
            // colWatchlistTag
            // 
            colWatchlistTag.Text = "名称";
            colWatchlistTag.Width = 140;
            // 
            // colWatchlistUsername
            // 
            colWatchlistUsername.Text = "用户名";
            colWatchlistUsername.Width = 166;
            // 
            // tabLootFilter
            // 
            tabLootFilter.BackColor = Color.White;
            tabLootFilter.Controls.Add(mcLootFilterFilters);
            tabLootFilter.Controls.Add(mcLootFilterItemManagement);
            tabLootFilter.Controls.Add(lstLootFilterEntries);
            tabLootFilter.ImageKey = "loot.png";
            tabLootFilter.Location = new Point(4, 39);
            tabLootFilter.Name = "tabLootFilter";
            tabLootFilter.Size = new Size(1483, 803);
            tabLootFilter.TabIndex = 4;
            tabLootFilter.Text = "物资过滤器";
            // 
            // mcLootFilterFilters
            // 
            mcLootFilterFilters.BackColor = Color.FromArgb(255, 255, 255);
            mcLootFilterFilters.Controls.Add(lstLootFilters);
            mcLootFilterFilters.Controls.Add(lblSettingsLootFilters);
            mcLootFilterFilters.Controls.Add(txtLootFilterName);
            mcLootFilterFilters.Controls.Add(btnRemoveFilter);
            mcLootFilterFilters.Controls.Add(picLootFilterColor);
            mcLootFilterFilters.Controls.Add(btnAddFilter);
            mcLootFilterFilters.Controls.Add(swLootFilterActive);
            mcLootFilterFilters.Controls.Add(btnFilterPriorityUp);
            mcLootFilterFilters.Controls.Add(lblSettingsLootFilterColor);
            mcLootFilterFilters.Controls.Add(btnFilterPriorityDown);
            mcLootFilterFilters.Depth = 0;
            mcLootFilterFilters.ForeColor = Color.FromArgb(222, 0, 0, 0);
            mcLootFilterFilters.Location = new Point(663, 184);
            mcLootFilterFilters.Margin = new Padding(16);
            mcLootFilterFilters.MouseState = MaterialSkin.MouseState.HOVER;
            mcLootFilterFilters.Name = "mcLootFilterFilters";
            mcLootFilterFilters.Padding = new Padding(16);
            mcLootFilterFilters.Size = new Size(598, 538);
            mcLootFilterFilters.TabIndex = 48;
            // 
            // lstLootFilters
            // 
            lstLootFilters.AutoSizeTable = false;
            lstLootFilters.BackColor = Color.FromArgb(255, 255, 255);
            lstLootFilters.BorderStyle = BorderStyle.None;
            lstLootFilters.Columns.AddRange(new ColumnHeader[] { colLootFilterName });
            lstLootFilters.Depth = 0;
            lstLootFilters.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lstLootFilters.FullRowSelect = true;
            lstLootFilters.Location = new Point(17, 51);
            lstLootFilters.MinimumSize = new Size(229, 113);
            lstLootFilters.MouseLocation = new Point(-1, -1);
            lstLootFilters.MouseState = MaterialSkin.MouseState.OUT;
            lstLootFilters.Name = "lstLootFilters";
            lstLootFilters.OwnerDraw = true;
            lstLootFilters.Size = new Size(229, 472);
            lstLootFilters.TabIndex = 47;
            lstLootFilters.UseCompatibleStateImageBehavior = false;
            lstLootFilters.View = View.Details;
            lstLootFilters.SelectedIndexChanged += lstLootFilters_SelectedIndexChanged;
            // 
            // colLootFilterName
            // 
            colLootFilterName.Text = "名称";
            colLootFilterName.Width = 200;
            // 
            // lblSettingsLootFilters
            // 
            lblSettingsLootFilters.AutoSize = true;
            lblSettingsLootFilters.Depth = 0;
            lblSettingsLootFilters.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            lblSettingsLootFilters.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            lblSettingsLootFilters.HighEmphasis = true;
            lblSettingsLootFilters.Location = new Point(19, 17);
            lblSettingsLootFilters.MouseState = MaterialSkin.MouseState.HOVER;
            lblSettingsLootFilters.Name = "lblSettingsLootFilters";
            lblSettingsLootFilters.Size = new Size(101, 24);
            lblSettingsLootFilters.TabIndex = 33;
            lblSettingsLootFilters.Text = "物资过滤器";
            lblSettingsLootFilters.UseAccent = true;
            // 
            // picLootFilterColor
            // 
            picLootFilterColor.BackColor = Color.Transparent;
            picLootFilterColor.BorderStyle = BorderStyle.FixedSingle;
            picLootFilterColor.Location = new Point(439, 108);
            picLootFilterColor.Name = "picLootFilterColor";
            picLootFilterColor.Size = new Size(141, 26);
            picLootFilterColor.TabIndex = 46;
            picLootFilterColor.TabStop = false;
            picLootFilterColor.Click += picLootFilterColor_Click;
            // 
            // btnFilterPriorityUp
            // 
            btnFilterPriorityUp.AutoSize = false;
            btnFilterPriorityUp.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnFilterPriorityUp.Density = MaterialButton.MaterialButtonDensity.Default;
            btnFilterPriorityUp.Depth = 0;
            btnFilterPriorityUp.HighEmphasis = true;
            btnFilterPriorityUp.Icon = (Image)resources.GetObject("btnFilterPriorityUp.Icon");
            btnFilterPriorityUp.Location = new Point(256, 45);
            btnFilterPriorityUp.Margin = new Padding(5, 7, 5, 7);
            btnFilterPriorityUp.MouseState = MaterialSkin.MouseState.HOVER;
            btnFilterPriorityUp.Name = "btnFilterPriorityUp";
            btnFilterPriorityUp.NoAccentTextColor = Color.Empty;
            btnFilterPriorityUp.Size = new Size(46, 45);
            btnFilterPriorityUp.TabIndex = 41;
            btnFilterPriorityUp.Type = MaterialButton.MaterialButtonType.Text;
            btnFilterPriorityUp.UseAccentColor = true;
            btnFilterPriorityUp.UseVisualStyleBackColor = true;
            btnFilterPriorityUp.Click += btnFilterPriorityUp_Click;
            // 
            // lblSettingsLootFilterColor
            // 
            lblSettingsLootFilterColor.AutoSize = true;
            lblSettingsLootFilterColor.Depth = 0;
            lblSettingsLootFilterColor.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblSettingsLootFilterColor.Location = new Point(353, 115);
            lblSettingsLootFilterColor.MouseState = MaterialSkin.MouseState.HOVER;
            lblSettingsLootFilterColor.Name = "lblSettingsLootFilterColor";
            lblSettingsLootFilterColor.Size = new Size(69, 19);
            lblSettingsLootFilterColor.TabIndex = 44;
            lblSettingsLootFilterColor.Text = "颜色显示:";
            // 
            // btnFilterPriorityDown
            // 
            btnFilterPriorityDown.AutoSize = false;
            btnFilterPriorityDown.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnFilterPriorityDown.Density = MaterialButton.MaterialButtonDensity.Default;
            btnFilterPriorityDown.Depth = 0;
            btnFilterPriorityDown.HighEmphasis = true;
            btnFilterPriorityDown.Icon = (Image)resources.GetObject("btnFilterPriorityDown.Icon");
            btnFilterPriorityDown.Location = new Point(256, 102);
            btnFilterPriorityDown.Margin = new Padding(5, 7, 5, 7);
            btnFilterPriorityDown.MouseState = MaterialSkin.MouseState.HOVER;
            btnFilterPriorityDown.Name = "btnFilterPriorityDown";
            btnFilterPriorityDown.NoAccentTextColor = Color.Empty;
            btnFilterPriorityDown.RightToLeft = RightToLeft.No;
            btnFilterPriorityDown.Size = new Size(46, 45);
            btnFilterPriorityDown.TabIndex = 42;
            btnFilterPriorityDown.Type = MaterialButton.MaterialButtonType.Text;
            btnFilterPriorityDown.UseAccentColor = true;
            btnFilterPriorityDown.UseVisualStyleBackColor = true;
            btnFilterPriorityDown.Click += btnFilterPriorityDown_Click;
            // 
            // mcLootFilterItemManagement
            // 
            mcLootFilterItemManagement.BackColor = Color.FromArgb(255, 255, 255);
            mcLootFilterItemManagement.Controls.Add(lblLootFilterItemManagement);
            mcLootFilterItemManagement.Controls.Add(btnAddLootFilterItem);
            mcLootFilterItemManagement.Controls.Add(btnRemoveLootFilterItem);
            mcLootFilterItemManagement.Controls.Add(txtLootFilterItemToSearch);
            mcLootFilterItemManagement.Controls.Add(cboLootFilterItemsToAdd);
            mcLootFilterItemManagement.Depth = 0;
            mcLootFilterItemManagement.ForeColor = Color.FromArgb(222, 0, 0, 0);
            mcLootFilterItemManagement.Location = new Point(663, 6);
            mcLootFilterItemManagement.Margin = new Padding(16);
            mcLootFilterItemManagement.MouseState = MaterialSkin.MouseState.HOVER;
            mcLootFilterItemManagement.Name = "mcLootFilterItemManagement";
            mcLootFilterItemManagement.Padding = new Padding(16);
            mcLootFilterItemManagement.Size = new Size(598, 161);
            mcLootFilterItemManagement.TabIndex = 47;
            // 
            // lblLootFilterItemManagement
            // 
            lblLootFilterItemManagement.AutoSize = true;
            lblLootFilterItemManagement.Depth = 0;
            lblLootFilterItemManagement.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            lblLootFilterItemManagement.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            lblLootFilterItemManagement.HighEmphasis = true;
            lblLootFilterItemManagement.Location = new Point(19, 17);
            lblLootFilterItemManagement.MouseState = MaterialSkin.MouseState.HOVER;
            lblLootFilterItemManagement.Name = "lblLootFilterItemManagement";
            lblLootFilterItemManagement.Size = new Size(166, 24);
            lblLootFilterItemManagement.TabIndex = 33;
            lblLootFilterItemManagement.Text = "Item Management";
            lblLootFilterItemManagement.UseAccent = true;
            // 
            // lstLootFilterEntries
            // 
            lstLootFilterEntries.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lstLootFilterEntries.AutoSizeTable = false;
            lstLootFilterEntries.BackColor = Color.FromArgb(255, 255, 255);
            lstLootFilterEntries.BorderStyle = BorderStyle.None;
            lstLootFilterEntries.Columns.AddRange(new ColumnHeader[] { colLootFilterItemName, colLootFilterItemValue });
            lstLootFilterEntries.Depth = 0;
            lstLootFilterEntries.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lstLootFilterEntries.FullRowSelect = true;
            lstLootFilterEntries.Location = new Point(17, 6);
            lstLootFilterEntries.MaximumSize = new Size(629, 1020);
            lstLootFilterEntries.MinimumSize = new Size(229, 113);
            lstLootFilterEntries.MouseLocation = new Point(-1, -1);
            lstLootFilterEntries.MouseState = MaterialSkin.MouseState.OUT;
            lstLootFilterEntries.MultiSelect = false;
            lstLootFilterEntries.Name = "lstLootFilterEntries";
            lstLootFilterEntries.OwnerDraw = true;
            lstLootFilterEntries.Size = new Size(629, 781);
            lstLootFilterEntries.TabIndex = 28;
            lstLootFilterEntries.UseCompatibleStateImageBehavior = false;
            lstLootFilterEntries.View = View.Details;
            // 
            // colLootFilterItemName
            // 
            colLootFilterItemName.Text = "Name";
            colLootFilterItemName.Width = 470;
            // 
            // colLootFilterItemValue
            // 
            colLootFilterItemValue.Text = "Value";
            colLootFilterItemValue.Width = 80;
            // 
            // tabPageLootList
            // 
            tabPageLootList.BackColor = Color.DimGray;
            tabPageLootList.Controls.Add(lootListListView);
            tabPageLootList.ImageKey = "list.png";
            tabPageLootList.Location = new Point(4, 39);
            tabPageLootList.Name = "tabPageLootList";
            tabPageLootList.Padding = new Padding(3);
            tabPageLootList.Size = new Size(1483, 803);
            tabPageLootList.TabIndex = 5;
            tabPageLootList.Text = "物资列表";
            // 
            // lootListListView
            // 
            lootListListView.AutoSizeTable = false;
            lootListListView.BackColor = Color.FromArgb(255, 255, 255);
            lootListListView.BorderStyle = BorderStyle.None;
            lootListListView.Columns.AddRange(new ColumnHeader[] { columnName1, columnValue1 });
            lootListListView.Depth = 0;
            lootListListView.Dock = DockStyle.Fill;
            lootListListView.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lootListListView.FullRowSelect = true;
            lootListListView.Location = new Point(3, 3);
            lootListListView.MinimumSize = new Size(229, 113);
            lootListListView.MouseLocation = new Point(-1, -1);
            lootListListView.MouseState = MaterialSkin.MouseState.OUT;
            lootListListView.Name = "lootListListView";
            lootListListView.OwnerDraw = true;
            lootListListView.Size = new Size(1477, 797);
            lootListListView.TabIndex = 0;
            lootListListView.UseCompatibleStateImageBehavior = false;
            lootListListView.View = View.Details;
            // 
            // columnName1
            // 
            columnName1.Text = "Name";
            columnName1.Width = 400;
            // 
            // columnValue1
            // 
            columnValue1.Text = "Value";
            columnValue1.Width = 100;
            // 
            // iconList
            // 
            iconList.ColorDepth = ColorDepth.Depth32Bit;
            iconList.ImageStream = (ImageListStreamer)resources.GetObject("iconList.ImageStream");
            iconList.TransparentColor = Color.Transparent;
            iconList.Images.SetKeyName(0, "radar.png");
            iconList.Images.SetKeyName(1, "settings.png");
            iconList.Images.SetKeyName(2, "loadouts.png");
            iconList.Images.SetKeyName(3, "watchlist.png");
            iconList.Images.SetKeyName(4, "loot.png");
            iconList.Images.SetKeyName(5, "list.png");
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1;
            materialLabel1.HighEmphasis = true;
            materialLabel1.Location = new Point(244, 8);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(1014, 19);
            materialLabel1.TabIndex = 50;
            materialLabel1.Text = "此文件由翻译by：Snip1编译修改 QQ:2213762483，文件开源免费，请勿盗卖,git:https://github.com/Snip1-99/EFT_DMA_Radar,请移步自行下载";
            materialLabel1.UseAccent = true;
            materialLabel1.Click += materialLabel1_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(10F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 255);
            ClientSize = new Size(1491, 873);
            Controls.Add(materialLabel1);
            Controls.Add(tabControlMain);
            DrawerShowIconsWhenHidden = true;
            DrawerTabControl = tabControlMain;
            DrawerWidth = 180;
            Font = new Font("微软雅黑", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            FormStyle = FormStyles.ActionBar_None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5, 3, 5, 3);
            Name = "frmMain";
            Padding = new Padding(0, 27, 0, 0);
            Load += frmMain_Load;
            Shown += frmMain_Shown;
            tabControlMain.ResumeLayout(false);
            tabRadar.ResumeLayout(false);
            mcRadarEnemyStats.ResumeLayout(false);
            mcRadarEnemyStats.PerformLayout();
            mcRadarStats.ResumeLayout(false);
            mcRadarStats.PerformLayout();
            mcRadarSettings.ResumeLayout(false);
            mcRadarMapSetup.ResumeLayout(false);
            mcRadarMapSetup.PerformLayout();
            tabSettings.ResumeLayout(false);
            tabControlSettings.ResumeLayout(false);
            tabSettingsGeneral.ResumeLayout(false);
            mcSettingsGeneralUI.ResumeLayout(false);
            mcSettingsGeneralUI.PerformLayout();
            mcSettingsGeneralRadar.ResumeLayout(false);
            mcSettingsGeneralRadar.PerformLayout();
            tabSettingsMemoryWriting.ResumeLayout(false);
            mcSettingsMemoryWritingSkillBuffs.ResumeLayout(false);
            mcSettingsMemoryWritingSkillBuffs.PerformLayout();
            mcSettingsMemoryWritingThermal.ResumeLayout(false);
            mcSettingsMemoryWritingThermal.PerformLayout();
            mcSettingsMemoryWritingGlobal.ResumeLayout(false);
            mcSettingsMemoryWritingGlobal.PerformLayout();
            mcSettingsMemoryWritingGear.ResumeLayout(false);
            mcSettingsMemoryWritingGear.PerformLayout();
            tabSettingsLoot.ResumeLayout(false);
            mcSettingsLootMinRubleValue.ResumeLayout(false);
            mcSettingsLootMinRubleValue.PerformLayout();
            mcSettingsLootGeneral.ResumeLayout(false);
            mcSettingsLootGeneral.PerformLayout();
            tabSettingsAIFactions.ResumeLayout(false);
            mcSettingsAIFactionsEntryManagement.ResumeLayout(false);
            mcSettingsAIFactionsEntryManagement.PerformLayout();
            mcSettingsAIFactionsFactions.ResumeLayout(false);
            mcSettingsAIFactionsFactions.PerformLayout();
            tabSettingsColors.ResumeLayout(false);
            mcSettingsColorsOther.ResumeLayout(false);
            mcSettingsColorsOther.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picOtherAccent).EndInit();
            ((System.ComponentModel.ISupportInitialize)picOtherPrimaryLight).EndInit();
            ((System.ComponentModel.ISupportInitialize)picOtherPrimaryDark).EndInit();
            ((System.ComponentModel.ISupportInitialize)picOtherPrimary).EndInit();
            ((System.ComponentModel.ISupportInitialize)picOtherChams).EndInit();
            ((System.ComponentModel.ISupportInitialize)picOtherDeathMarker).EndInit();
            ((System.ComponentModel.ISupportInitialize)picOtherTextOutline).EndInit();
            mcSettingsColorsLootAndQuests.ResumeLayout(false);
            mcSettingsColorsLootAndQuests.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picQuestZone).EndInit();
            ((System.ComponentModel.ISupportInitialize)picQuestItem).EndInit();
            ((System.ComponentModel.ISupportInitialize)picLootImportant).EndInit();
            ((System.ComponentModel.ISupportInitialize)picLootRegular).EndInit();
            mcSettingsColorsExfiltration.ResumeLayout(false);
            mcSettingsColorsExfiltration.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picExfilClosedIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)picExfilClosedText).EndInit();
            ((System.ComponentModel.ISupportInitialize)picExfilPendingIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)picExfilPendingText).EndInit();
            ((System.ComponentModel.ISupportInitialize)picExfilActiveIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)picExfilActiveText).EndInit();
            mcSettingsColorsPlayers.ResumeLayout(false);
            mcSettingsColorsPlayers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picPlayersSpecial).EndInit();
            ((System.ComponentModel.ISupportInitialize)picPlayersTeamHover).EndInit();
            ((System.ComponentModel.ISupportInitialize)picPlayersTeammate).EndInit();
            ((System.ComponentModel.ISupportInitialize)picPlayersLocalPlayer).EndInit();
            ((System.ComponentModel.ISupportInitialize)picPlayersScav).EndInit();
            ((System.ComponentModel.ISupportInitialize)picPlayersBEAR).EndInit();
            ((System.ComponentModel.ISupportInitialize)picPlayersUSEC).EndInit();
            mcSettingsColorsAI.ResumeLayout(false);
            mcSettingsColorsAI.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picAIOther).EndInit();
            ((System.ComponentModel.ISupportInitialize)picAIScav).EndInit();
            ((System.ComponentModel.ISupportInitialize)picAIFollowerOfMorana).EndInit();
            ((System.ComponentModel.ISupportInitialize)picAICultist).EndInit();
            ((System.ComponentModel.ISupportInitialize)picAIRogue).EndInit();
            ((System.ComponentModel.ISupportInitialize)picAIRaider).EndInit();
            ((System.ComponentModel.ISupportInitialize)picAIBossFollower).EndInit();
            ((System.ComponentModel.ISupportInitialize)picAIBossGuard).EndInit();
            ((System.ComponentModel.ISupportInitialize)picAIBoss).EndInit();
            tabPlayerLoadouts.ResumeLayout(false);
            mcPlayerLoadoutsAI.ResumeLayout(false);
            mcPlayerLoadoutsAI.PerformLayout();
            mcPlayerLoadoutsPlayers.ResumeLayout(false);
            mcPlayerLoadoutsPlayers.PerformLayout();
            tabWatchlist.ResumeLayout(false);
            mcWatchlistPlayerlist.ResumeLayout(false);
            mcWatchlistPlayerlist.PerformLayout();
            mcWatchlistProfiles.ResumeLayout(false);
            mcWatchlistProfiles.PerformLayout();
            mcWatchlistPlayerManagement.ResumeLayout(false);
            mcWatchlistPlayerManagement.PerformLayout();
            tabLootFilter.ResumeLayout(false);
            mcLootFilterFilters.ResumeLayout(false);
            mcLootFilterFilters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLootFilterColor).EndInit();
            mcLootFilterItemManagement.ResumeLayout(false);
            mcLootFilterItemManagement.PerformLayout();
            tabPageLootList.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ColorDialog colDialog;
        private ToolTip toolTip;
        private MaterialSkin.Controls.MaterialTabControl tabControlMain;
        private TabPage tabRadar;
        private TabPage tabSettings;
        private TabPage tabPlayerLoadouts;
        private TabPage tabWatchlist;
        private TabPage tabLootFilter;
        private MaterialSkin.Controls.MaterialTabControl tabControlSettings;
        private TabPage tabSettingsGeneral;
        private TabPage tabSettingsMemoryWriting;
        private TabPage tabSettingsLoot;
        private TabPage tabSettingsAIFactions;
        private TabPage tabSettingsColors;
        private MaterialSkin.Controls.MaterialTabSelector tabSelector;
        private ImageList iconList;
        private MaterialSkin.Controls.MaterialCard mcSettingsGeneralRadar;
        private MaterialSkin.Controls.MaterialSwitch swMapHelper;
        private MaterialSkin.Controls.MaterialButton btnRestartRadar;
        private MaterialSkin.Controls.MaterialButton btnToggleMap;
        private MaterialSkin.Controls.MaterialCard mcSettingsGeneralUI;
        private MaterialSkin.Controls.MaterialSlider sldrAimlineLength;
        private MaterialSkin.Controls.MaterialSwitch swExfilNames;
        private MaterialSkin.Controls.MaterialSwitch swQuestHelper;
        private MaterialSkin.Controls.MaterialSwitch swHoverArmor;
        private MaterialSkin.Controls.MaterialSwitch swNames;
        private MaterialSkin.Controls.MaterialSwitch swAimview;
        private MaterialSkin.Controls.MaterialSwitch swShowLoot;
        private MaterialSkin.Controls.MaterialSlider sldrZoomDistance;
        private MaterialSkin.Controls.MaterialSlider sldrUIScale;
        private MaterialSkin.Controls.MaterialLabel lblSettingsGeneralRadar;
        private MaterialSkin.Controls.MaterialLabel lblSettingsGeneralUI;
        private MaterialSkin.Controls.MaterialCard mcSettingsMemoryWritingThermal;
        private MaterialSkin.Controls.MaterialComboBox cboThermalColorScheme;
        private MaterialSkin.Controls.MaterialComboBox cboThermalType;
        private MaterialSkin.Controls.MaterialSlider sldrThermalColorCoefficient;
        private MaterialSkin.Controls.MaterialSlider sldrMinTemperature;
        private MaterialSkin.Controls.MaterialLabel lblSettingsMemoryWritingThermal;
        private MaterialSkin.Controls.MaterialSlider sldrThermalRampShift;
        private MaterialSkin.Controls.MaterialSwitch swMasterSwitch;
        private MaterialSkin.Controls.MaterialSwitch swInfiniteStamina;
        private MaterialSkin.Controls.MaterialSlider sldrJumpStrength;
        private MaterialSkin.Controls.MaterialSlider sldrThrowStrength;
        private MaterialSkin.Controls.MaterialCard mcSettingsMemoryWritingGlobal;
        private MaterialSkin.Controls.MaterialLabel lblSettingsMemoryWritingGlobal;
        private MaterialSkin.Controls.MaterialSlider sldrTimeOfDay;
        private MaterialSkin.Controls.MaterialSwitch swExtendedReach;
        private MaterialSkin.Controls.MaterialSwitch swFreezeTime;
        private MaterialSkin.Controls.MaterialSwitch swChams;
        private MaterialSkin.Controls.MaterialCard mcSettingsMemoryWritingGear;
        private MaterialSkin.Controls.MaterialSwitch swNightVision;
        private MaterialSkin.Controls.MaterialSwitch swOpticalThermal;
        private MaterialSkin.Controls.MaterialSwitch swThermalVision;
        private MaterialSkin.Controls.MaterialLabel lblSettingsMemoryWritingGear;
        private MaterialSkin.Controls.MaterialSlider sldrMagDrillsSpeed;
        private MaterialSkin.Controls.MaterialSwitch swNoVisor;
        private MaterialSkin.Controls.MaterialSwitch swInstantADS;
        private MaterialSkin.Controls.MaterialSwitch swNoRecoilSway;
        private MaterialSkin.Controls.MaterialCard mcSettingsMemoryWritingSkillBuffs;
        private MaterialSkin.Controls.MaterialLabel lblSettingsMemoryWritingSkills;
        private MaterialSkin.Controls.MaterialCard mcSettingsLootMinRubleValue;
        private MaterialSkin.Controls.MaterialLabel lblSettingsLootMinRubleValues;
        private MaterialSkin.Controls.MaterialSlider sldrMinCorpse;
        private MaterialSkin.Controls.MaterialSlider sldrMinRegularLoot;
        private MaterialSkin.Controls.MaterialCard mcSettingsLootGeneral;
        private MaterialSkin.Controls.MaterialLabel lblSettingsLootGeneral;
        private MaterialSkin.Controls.MaterialComboBox cboAutoRefreshMap;
        private MaterialSkin.Controls.MaterialSlider sldrAutoRefreshDelay;
        private MaterialSkin.Controls.MaterialButton btnRefreshLoot;
        private MaterialSkin.Controls.MaterialSwitch swAutoRefresh;
        private MaterialSkin.Controls.MaterialSwitch swItemValue;
        private MaterialSkin.Controls.MaterialSwitch swCorpses;
        private MaterialSkin.Controls.MaterialSwitch swSubItems;
        private MaterialSkin.Controls.MaterialSwitch swFilteredOnly;
        private MaterialSkin.Controls.MaterialSlider sldrMinSubItems;
        private MaterialSkin.Controls.MaterialSlider sldrMinImportantLoot;
        private MaterialSkin.Controls.MaterialCard mcSettingsAIFactionsFactions;
        private MaterialSkin.Controls.MaterialComboBox cboFactionType;
        private MaterialSkin.Controls.MaterialButton btnAddFaction;
        private MaterialSkin.Controls.MaterialButton btnRemoveFaction;
        private MaterialSkin.Controls.MaterialLabel lblSettingsAIFactionsFactions;
        private MaterialSkin.Controls.MaterialCard mcSettingsAIFactionsEntryManagement;
        private MaterialSkin.Controls.MaterialLabel lblSettingsAIFactionsEntryManagement;
        private MaterialSkin.Controls.MaterialButton btnAddFactionEntry;
        private MaterialSkin.Controls.MaterialButton btnRemoveFactionEntry;
        private MaterialSkin.Controls.MaterialCard mcSettingsColorsAI;
        private PictureBox picAIBoss;
        private MaterialSkin.Controls.MaterialLabel lblSettingsColorsAI;
        private MaterialSkin.Controls.MaterialLabel lblSettingsColorsAIBoss;
        private PictureBox picAICultist;
        private MaterialSkin.Controls.MaterialLabel lblSettingsColorsAIBossGuard;
        private PictureBox picAIRogue;
        private MaterialSkin.Controls.MaterialLabel lblSettingsColorsAIBossFollower;
        private PictureBox picAIRaider;
        private MaterialSkin.Controls.MaterialLabel lblSettingsColorsAIRaiders;
        private PictureBox picAIBossFollower;
        private MaterialSkin.Controls.MaterialLabel lblSettingsColorsAIRogues;
        private PictureBox picAIBossGuard;
        private MaterialSkin.Controls.MaterialLabel lblSettingsColorsAICultists;
        private PictureBox picAIOther;
        private MaterialSkin.Controls.MaterialLabel lblSettingsColorsAIScav;
        private PictureBox picAIScav;
        private MaterialSkin.Controls.MaterialLabel lblSettingsColorsAIOther;
        private PictureBox picAIFollowerOfMorana;
        private MaterialSkin.Controls.MaterialLabel lblSettingsColorsAIMoranaFollower;
        private MaterialSkin.Controls.MaterialCard mcSettingsColorsPlayers;
        private PictureBox picPlayersSpecial;
        private MaterialSkin.Controls.MaterialLabel lblSettingsColorsPlayersSpecial;
        private PictureBox picPlayersTeamHover;
        private MaterialSkin.Controls.MaterialLabel lblSettingsColorsPlayersTeamHover;
        private PictureBox picPlayersTeammate;
        private MaterialSkin.Controls.MaterialLabel lblSettingsColorsPlayersTeammate;
        private PictureBox picPlayersLocalPlayer;
        private MaterialSkin.Controls.MaterialLabel lblSettingsColorsPlayersLocalPlayer;
        private PictureBox picPlayersScav;
        private MaterialSkin.Controls.MaterialLabel lblSettingsColorsPlayersScav;
        private PictureBox picPlayersBEAR;
        private MaterialSkin.Controls.MaterialLabel lblSettingsColorsPlayersBEAR;
        private PictureBox picPlayersUSEC;
        private MaterialSkin.Controls.MaterialLabel lblSettingsColorsPlayersUSEC;
        private MaterialSkin.Controls.MaterialLabel lblSettingsColorsPlayers;
        private MaterialSkin.Controls.MaterialCard mcSettingsColorsOther;
        private PictureBox picOtherChams;
        private MaterialSkin.Controls.MaterialLabel lblSettingsOtherChams;
        private PictureBox picOtherDeathMarker;
        private MaterialSkin.Controls.MaterialLabel lblSettingsOtherDeathMarker;
        private PictureBox picOtherTextOutline;
        private MaterialSkin.Controls.MaterialLabel lblSettingsOtherTextOutline;
        private MaterialSkin.Controls.MaterialLabel lblSettingsColorsOther;
        private MaterialSkin.Controls.MaterialCard mcSettingsColorsLootAndQuests;
        private PictureBox picQuestZone;
        private MaterialSkin.Controls.MaterialLabel lblSettingsQuestZones;
        private PictureBox picQuestItem;
        private MaterialSkin.Controls.MaterialLabel lblSettingsQuestItems;
        private PictureBox picLootImportant;
        private MaterialSkin.Controls.MaterialLabel lblSettingsLootImportant;
        private PictureBox picLootRegular;
        private MaterialSkin.Controls.MaterialLabel lblSettingsLootRegular;
        private MaterialSkin.Controls.MaterialLabel lblSettingsColorsLootQuests;
        private MaterialSkin.Controls.MaterialCard mcSettingsColorsExfiltration;
        private PictureBox picExfilClosedIcon;
        private MaterialSkin.Controls.MaterialLabel lblSettingsColorsExfilClosedIcon;
        private PictureBox picExfilClosedText;
        private MaterialSkin.Controls.MaterialLabel lblSettingsColorsExfilClosedText;
        private PictureBox picExfilPendingIcon;
        private MaterialSkin.Controls.MaterialLabel lblSettingsColorsExfilPendingIcon;
        private PictureBox picExfilPendingText;
        private MaterialSkin.Controls.MaterialLabel lblSettingsColorsExfilPendingText;
        private PictureBox picExfilActiveIcon;
        private MaterialSkin.Controls.MaterialLabel lblSettingsColorsExfilActiveIcon;
        private PictureBox picExfilActiveText;
        private MaterialSkin.Controls.MaterialLabel lblSettingsColorsExfilActiveText;
        private MaterialSkin.Controls.MaterialLabel lblSettingsColorsExfiltration;
        private PictureBox picOtherAccent;
        private MaterialSkin.Controls.MaterialLabel lblSettingsOtherAccent;
        private PictureBox picOtherPrimaryLight;
        private MaterialSkin.Controls.MaterialLabel lblSettingsOtherPrimaryLight;
        private PictureBox picOtherPrimaryDark;
        private MaterialSkin.Controls.MaterialLabel lblSettingsOtherPrimaryDark;
        private PictureBox picOtherPrimary;
        private MaterialSkin.Controls.MaterialLabel lblSettingsOtherPrimary;
        private MaterialSkin.Controls.MaterialTextBox2 txtTeammateID;
        private MaterialSkin.Controls.MaterialTextBox2 txtFactionName;
        private MaterialSkin.Controls.MaterialTextBox2 txtFactionEntryName;
        private MaterialSkin.Controls.MaterialButton btnResetTheme;
        private SkiaSharp.Views.Desktop.SKGLControl skMapCanvas;
        private MaterialSkin.Controls.MaterialCard mcRadarMapSetup;
        private MaterialSkin.Controls.MaterialLabel lblRadarMapSetup;
        private MaterialSkin.Controls.MaterialTextBox2 txtMapSetupX;
        private MaterialSkin.Controls.MaterialButton btnMapSetupApply;
        private MaterialSkin.Controls.MaterialTextBox2 txtMapSetupScale;
        private MaterialSkin.Controls.MaterialTextBox2 txtMapSetupY;
        private MaterialSkin.Controls.MaterialButton btnToggleMapFree;
        private MaterialSkin.Controls.MaterialCard mcRadarSettings;
        private MaterialSkin.Controls.MaterialListView lstWatchlistEntries;
        private ColumnHeader colWatchlistAccID;
        private ColumnHeader colWatchlistTag;
        private ColumnHeader colWatchlistUsername;
        private MaterialSkin.Controls.MaterialCard mcWatchlistPlayerManagement;
        private MaterialSkin.Controls.MaterialCard mcWatchlistProfiles;
        private MaterialSkin.Controls.MaterialButton btnRemoveWatchlistEntry;
        private MaterialSkin.Controls.MaterialTextBox2 txtWatchlistAccountID;
        private MaterialSkin.Controls.MaterialLabel lblWatchlistPlayerManagement;
        private MaterialSkin.Controls.MaterialTextBox2 txtWatchlistProfileName;
        private MaterialSkin.Controls.MaterialButton btnAddWatchlistEntry;
        private MaterialSkin.Controls.MaterialButton btnAddWatchlistProfile;
        private MaterialSkin.Controls.MaterialButton btnRemoveWatchlistProfile;
        private MaterialSkin.Controls.MaterialLabel lblWatchlistProfiles;
        private MaterialSkin.Controls.MaterialTextBox2 txtWatchlistPlatformUsername;
        private MaterialSkin.Controls.MaterialRadioButton rdbYoutube;
        private MaterialSkin.Controls.MaterialRadioButton rdbTwitch;
        private MaterialSkin.Controls.MaterialSwitch swWatchlistIsStreamer;
        private MaterialSkin.Controls.MaterialTextBox2 txtWatchlistTag;
        private MaterialSkin.Controls.MaterialCard mcWatchlistPlayerlist;
        private MaterialSkin.Controls.MaterialLabel lblWatchlistPlayerlist;
        private MaterialSkin.Controls.MaterialButton btnResetPlayerlist;
        private MaterialSkin.Controls.MaterialListView lstWatchlistPlayerList;
        private ColumnHeader colPlayerlistName;
        private ColumnHeader colLootFilterItemName;
        private ColumnHeader colLootFilterItemValue;
        private MaterialSkin.Controls.MaterialComboBox cboLootFilterItemsToAdd;
        private MaterialSkin.Controls.MaterialLabel lblLootFilterItemManagement;
        private MaterialSkin.Controls.MaterialTextBox2 txtLootFilterItemToSearch;
        private MaterialSkin.Controls.MaterialListView lstLootFilterEntries;
        private MaterialSkin.Controls.MaterialButton btnAddLootFilterItem;
        private MaterialSkin.Controls.MaterialButton btnRemoveLootFilterItem;
        private MaterialSkin.Controls.MaterialCard mcLootFilterItemManagement;
        private MaterialSkin.Controls.MaterialTextBox2 txtLootFilterName;
        private PictureBox picLootFilterColor;
        private MaterialSkin.Controls.MaterialSwitch swLootFilterActive;
        private MaterialSkin.Controls.MaterialLabel lblSettingsLootFilterColor;
        private MaterialSkin.Controls.MaterialButton btnFilterPriorityDown;
        private MaterialSkin.Controls.MaterialButton btnFilterPriorityUp;
        private MaterialSkin.Controls.MaterialButton btnAddFilter;
        private MaterialSkin.Controls.MaterialButton btnRemoveFilter;
        private MaterialSkin.Controls.MaterialLabel lblSettingsLootFilters;
        private MaterialSkin.Controls.MaterialListView lstLootFilters;
        private ColumnHeader colLootFilterName;
        private MaterialSkin.Controls.MaterialCard mcLootFilterFilters;
        private MaterialSkin.Controls.MaterialListView lstWatchlistProfiles;
        private ColumnHeader colWatchlistProfileName;
        private MaterialSkin.Controls.MaterialListView lstFactions;
        private ColumnHeader colFactionName;
        private ColumnHeader colLootFilterItemEnabled;
        private MaterialSkin.Controls.MaterialSwitch swMaxEndurance;
        private MaterialSkin.Controls.MaterialSwitch swMaxPerception;
        private MaterialSkin.Controls.MaterialSwitch swMaxImmunity;
        private MaterialSkin.Controls.MaterialSwitch swMaxMetabolism;
        private MaterialSkin.Controls.MaterialSwitch swMaxStressResistance;
        private MaterialSkin.Controls.MaterialSwitch swMaxHealth;
        private MaterialSkin.Controls.MaterialSwitch swMaxVitality;
        private MaterialSkin.Controls.MaterialSwitch swMaxStrength;
        private MaterialSkin.Controls.MaterialSwitch swMaxThrowables;
        private MaterialSkin.Controls.MaterialSwitch swMaxIntellect;
        private MaterialSkin.Controls.MaterialSwitch swMaxSurgery;
        private MaterialSkin.Controls.MaterialSwitch swMaxHeavyVests;
        private MaterialSkin.Controls.MaterialSwitch swMaxLightVests;
        private MaterialSkin.Controls.MaterialSwitch swMaxMagDrills;
        private MaterialSkin.Controls.MaterialSwitch swMaxSearch;
        private MaterialSkin.Controls.MaterialSwitch swMaxCovertMovement;
        private MaterialSkin.Controls.MaterialSwitch swMaxAttention;
        private MaterialSkin.Controls.MaterialSwitch swProcessLoot;
        private MaterialSkin.Controls.MaterialSwitch swRadarStats;
        private MaterialSkin.Controls.MaterialCard mcRadarStats;
        private MaterialSkin.Controls.MaterialLabel lblRadarCorpses;
        private MaterialSkin.Controls.MaterialLabel lblRadarContainers;
        private MaterialSkin.Controls.MaterialLabel lblRadarLooseLoot;
        private MaterialSkin.Controls.MaterialLabel lblRadarFPS;
        private MaterialSkin.Controls.MaterialLabel lblRadarCorpsesValue;
        private MaterialSkin.Controls.MaterialLabel lblRadarContainersValue;
        private MaterialSkin.Controls.MaterialLabel lblRadarLooseLootValue;
        private MaterialSkin.Controls.MaterialLabel lblRadarFPSValue;
        private MaterialSkin.Controls.MaterialLabel lblRadarMemSValue;
        private MaterialSkin.Controls.MaterialLabel lblRadarMemS;
        private MaterialSkin.Controls.MaterialCard mcRadarEnemyStats;
        private MaterialSkin.Controls.MaterialLabel lblRadarBossesValue;
        private MaterialSkin.Controls.MaterialLabel lblRadarBosses;
        private MaterialSkin.Controls.MaterialLabel lblRadarPlayerScavsValue;
        private MaterialSkin.Controls.MaterialLabel lblRadarPlayerScavs;
        private MaterialSkin.Controls.MaterialLabel lblRadarRoguesValue;
        private MaterialSkin.Controls.MaterialLabel lblRadarAIScavsValue;
        private MaterialSkin.Controls.MaterialLabel lblRadarPMCsValue;
        private MaterialSkin.Controls.MaterialLabel lblRadarRogues;
        private MaterialSkin.Controls.MaterialLabel lblRadarAIScavs;
        private MaterialSkin.Controls.MaterialLabel lblRadarPMCs;
        private MaterialSkin.Controls.MaterialSwitch swRadarVsync;
        private MaterialSkin.Controls.MaterialSwitch swRadarEnemyCount;
        private MaterialSkin.Controls.MaterialSlider sldrFontSize;
        private MaterialSkin.Controls.MaterialComboBox cboFont;
        private MaterialSkin.Controls.MaterialCard mcPlayerLoadoutsPlayers;
        private FlowLayoutPanel flpPlayerLoadoutsPlayers;
        private MaterialSkin.Controls.MaterialLabel lblPlayerLoadoutsPlayers;
        private MaterialSkin.Controls.MaterialCard mcPlayerLoadoutsAI;
        private MaterialSkin.Controls.MaterialLabel lblPlayerLoadoutsAI;
        private FlowLayoutPanel flpPlayerLoadoutsAI;
        private MaterialSkin.Controls.MaterialListView lstFactionEntries;
        private ColumnHeader colFactionsAIName;
        private MaterialSkin.Controls.MaterialSwitch swUnknownQuestItems;
        
        private TabPage tabPageLootList;
        private MaterialSkin.Controls.MaterialListView lootListListView;
        private ColumnHeader columnName1;
        private ColumnHeader columnValue1;
        private MaterialLabel materialLabel1;
    }
}


namespace LeagueOfLegends_ClipBoard
{
    partial class FRM_Main
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Main));
            this.LBL_Clipboard = new System.Windows.Forms.Label();
            this.LBL_isActive = new System.Windows.Forms.Label();
            this.notifIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.LBL_Dev = new System.Windows.Forms.Label();
            this.LBL_Version = new System.Windows.Forms.Label();
            this.LBL_CTRLKey1 = new System.Windows.Forms.Label();
            this.LBL_ExeKey1 = new System.Windows.Forms.Label();
            this.LBL_Assoc1 = new System.Windows.Forms.Label();
            this.LBL_Legend1 = new System.Windows.Forms.Label();
            this.LBL_Assoc2 = new System.Windows.Forms.Label();
            this.LBL_ExeKey2 = new System.Windows.Forms.Label();
            this.LBL_CTRLKey2 = new System.Windows.Forms.Label();
            this.LBL_Legend3 = new System.Windows.Forms.Label();
            this.LBL_DEF1 = new System.Windows.Forms.Label();
            this.LBL_Assoc3 = new System.Windows.Forms.Label();
            this.LBL_ExeKey3 = new System.Windows.Forms.Label();
            this.LBL_CTRLKey3 = new System.Windows.Forms.Label();
            this.LBL_Legend2 = new System.Windows.Forms.Label();
            this.LBL_Legend4 = new System.Windows.Forms.Label();
            this.LBL_DEF2 = new System.Windows.Forms.Label();
            this.LBL_Assoc4 = new System.Windows.Forms.Label();
            this.LBL_ExeKey4 = new System.Windows.Forms.Label();
            this.LBL_CTRLKey4 = new System.Windows.Forms.Label();
            this.VIEW_LegendTable = new System.Windows.Forms.Panel();
            this.LBL_Modify1 = new System.Windows.Forms.Label();
            this.TBX_Custom1 = new System.Windows.Forms.TextBox();
            this.LBL_DEF5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.LBL_ExeKey7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.LBL_Legend6 = new System.Windows.Forms.Label();
            this.LBL_DEF4 = new System.Windows.Forms.Label();
            this.LBL_Assoc6 = new System.Windows.Forms.Label();
            this.LBL_ExeKey6 = new System.Windows.Forms.Label();
            this.LBL_CTRLKey6 = new System.Windows.Forms.Label();
            this.LBL_Legend5 = new System.Windows.Forms.Label();
            this.LBL_DEF3 = new System.Windows.Forms.Label();
            this.LBL_Assoc5 = new System.Windows.Forms.Label();
            this.LBL_ExeKey5 = new System.Windows.Forms.Label();
            this.LBL_CTRLKey5 = new System.Windows.Forms.Label();
            this.CBX_ToggleAll = new System.Windows.Forms.CheckBox();
            this.TTIP_Ver = new System.Windows.Forms.ToolTip(this.components);
            this.LBL_WarnCopyPaste = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.IMG_Icon = new System.Windows.Forms.PictureBox();
            this.OptionsButton = new System.Windows.Forms.Button();
            this.ReduceButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.CBX_ClientDetection = new System.Windows.Forms.CheckBox();
            this.VIEW_LegendTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IMG_Icon)).BeginInit();
            this.SuspendLayout();
            // 
            // LBL_Clipboard
            // 
            this.LBL_Clipboard.Font = new System.Drawing.Font("Garamond", 38F, System.Drawing.FontStyle.Bold);
            this.LBL_Clipboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(115)))), ((int)(((byte)(65)))));
            this.LBL_Clipboard.Location = new System.Drawing.Point(37, 127);
            this.LBL_Clipboard.Name = "LBL_Clipboard";
            this.LBL_Clipboard.Size = new System.Drawing.Size(274, 57);
            this.LBL_Clipboard.TabIndex = 85;
            this.LBL_Clipboard.Text = "Clipboard :";
            this.LBL_Clipboard.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnStayClick_MouseDown);
            // 
            // LBL_isActive
            // 
            this.LBL_isActive.AutoSize = true;
            this.LBL_isActive.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LBL_isActive.Font = new System.Drawing.Font("Garamond", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_isActive.ForeColor = System.Drawing.Color.Green;
            this.LBL_isActive.Location = new System.Drawing.Point(299, 116);
            this.LBL_isActive.Name = "LBL_isActive";
            this.LBL_isActive.Size = new System.Drawing.Size(100, 72);
            this.LBL_isActive.TabIndex = 86;
            this.LBL_isActive.Text = "✔";
            this.LBL_isActive.Click += new System.EventHandler(this.LBL_isActive_Click);
            this.LBL_isActive.MouseEnter += new System.EventHandler(this.LBL_isActive_MouseEnter);
            this.LBL_isActive.MouseLeave += new System.EventHandler(this.LBL_isActive_MouseLeave);
            // 
            // notifIcon
            // 
            this.notifIcon.BalloonTipText = "LoL Clipboard is still running in background";
            this.notifIcon.BalloonTipTitle = "Info";
            this.notifIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifIcon.Icon")));
            this.notifIcon.Text = "LoL ClipBoard Active";
            this.notifIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifIcon_MouseDoubleClick);
            // 
            // LBL_Dev
            // 
            this.LBL_Dev.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Dev.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(115)))), ((int)(((byte)(65)))));
            this.LBL_Dev.Location = new System.Drawing.Point(5, 551);
            this.LBL_Dev.Name = "LBL_Dev";
            this.LBL_Dev.Size = new System.Drawing.Size(210, 19);
            this.LBL_Dev.TabIndex = 88;
            this.LBL_Dev.Text = "Made with ❤ by Maxmistral";
            this.LBL_Dev.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnStayClick_MouseDown);
            // 
            // LBL_Version
            // 
            this.LBL_Version.Cursor = System.Windows.Forms.Cursors.Help;
            this.LBL_Version.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Version.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(115)))), ((int)(((byte)(65)))));
            this.LBL_Version.Location = new System.Drawing.Point(350, 551);
            this.LBL_Version.Name = "LBL_Version";
            this.LBL_Version.Size = new System.Drawing.Size(48, 19);
            this.LBL_Version.TabIndex = 91;
            this.LBL_Version.Text = "V2.1.1";
            this.LBL_Version.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnStayClick_MouseDown);
            this.LBL_Version.MouseHover += new System.EventHandler(this.LBL_Version_MouseHover);
            // 
            // LBL_CTRLKey1
            // 
            this.LBL_CTRLKey1.AutoSize = true;
            this.LBL_CTRLKey1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LBL_CTRLKey1.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_CTRLKey1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(115)))), ((int)(((byte)(65)))));
            this.LBL_CTRLKey1.Location = new System.Drawing.Point(5, 14);
            this.LBL_CTRLKey1.Name = "LBL_CTRLKey1";
            this.LBL_CTRLKey1.Size = new System.Drawing.Size(53, 20);
            this.LBL_CTRLKey1.TabIndex = 92;
            this.LBL_CTRLKey1.Text = "CTRL";
            this.LBL_CTRLKey1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnStayClick_MouseDown);
            // 
            // LBL_ExeKey1
            // 
            this.LBL_ExeKey1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LBL_ExeKey1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LBL_ExeKey1.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_ExeKey1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(115)))), ((int)(((byte)(65)))));
            this.LBL_ExeKey1.Location = new System.Drawing.Point(89, 14);
            this.LBL_ExeKey1.Name = "LBL_ExeKey1";
            this.LBL_ExeKey1.Size = new System.Drawing.Size(33, 20);
            this.LBL_ExeKey1.TabIndex = 93;
            this.LBL_ExeKey1.Text = "²";
            this.LBL_ExeKey1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LBL_ExeKey1.Click += new System.EventHandler(this.LBL_ExeKey1_Click);
            // 
            // LBL_Assoc1
            // 
            this.LBL_Assoc1.AutoSize = true;
            this.LBL_Assoc1.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Assoc1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(115)))), ((int)(((byte)(65)))));
            this.LBL_Assoc1.Location = new System.Drawing.Point(64, 15);
            this.LBL_Assoc1.Name = "LBL_Assoc1";
            this.LBL_Assoc1.Size = new System.Drawing.Size(19, 18);
            this.LBL_Assoc1.TabIndex = 94;
            this.LBL_Assoc1.Text = "+";
            this.LBL_Assoc1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnStayClick_MouseDown);
            // 
            // LBL_Legend1
            // 
            this.LBL_Legend1.AutoSize = true;
            this.LBL_Legend1.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Legend1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(115)))), ((int)(((byte)(65)))));
            this.LBL_Legend1.Location = new System.Drawing.Point(128, 14);
            this.LBL_Legend1.Name = "LBL_Legend1";
            this.LBL_Legend1.Size = new System.Drawing.Size(173, 18);
            this.LBL_Legend1.TabIndex = 95;
            this.LBL_Legend1.Text = "for paste text in game. *";
            this.LBL_Legend1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnStayClick_MouseDown);
            // 
            // LBL_Assoc2
            // 
            this.LBL_Assoc2.AutoSize = true;
            this.LBL_Assoc2.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Assoc2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(115)))), ((int)(((byte)(65)))));
            this.LBL_Assoc2.Location = new System.Drawing.Point(64, 49);
            this.LBL_Assoc2.Name = "LBL_Assoc2";
            this.LBL_Assoc2.Size = new System.Drawing.Size(19, 18);
            this.LBL_Assoc2.TabIndex = 98;
            this.LBL_Assoc2.Text = "+";
            this.LBL_Assoc2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnStayClick_MouseDown);
            // 
            // LBL_ExeKey2
            // 
            this.LBL_ExeKey2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LBL_ExeKey2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LBL_ExeKey2.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_ExeKey2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(115)))), ((int)(((byte)(65)))));
            this.LBL_ExeKey2.Location = new System.Drawing.Point(89, 48);
            this.LBL_ExeKey2.Name = "LBL_ExeKey2";
            this.LBL_ExeKey2.Size = new System.Drawing.Size(33, 20);
            this.LBL_ExeKey2.TabIndex = 97;
            this.LBL_ExeKey2.Text = "<";
            this.LBL_ExeKey2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LBL_ExeKey2.Click += new System.EventHandler(this.LBL_ExeKey2_Click);
            // 
            // LBL_CTRLKey2
            // 
            this.LBL_CTRLKey2.AutoSize = true;
            this.LBL_CTRLKey2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LBL_CTRLKey2.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_CTRLKey2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(115)))), ((int)(((byte)(65)))));
            this.LBL_CTRLKey2.Location = new System.Drawing.Point(5, 48);
            this.LBL_CTRLKey2.Name = "LBL_CTRLKey2";
            this.LBL_CTRLKey2.Size = new System.Drawing.Size(53, 20);
            this.LBL_CTRLKey2.TabIndex = 96;
            this.LBL_CTRLKey2.Text = "CTRL";
            this.LBL_CTRLKey2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnStayClick_MouseDown);
            // 
            // LBL_Legend3
            // 
            this.LBL_Legend3.AutoSize = true;
            this.LBL_Legend3.Font = new System.Drawing.Font("Garamond", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Legend3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(115)))), ((int)(((byte)(65)))));
            this.LBL_Legend3.Location = new System.Drawing.Point(146, 82);
            this.LBL_Legend3.Name = "LBL_Legend3";
            this.LBL_Legend3.Size = new System.Drawing.Size(83, 18);
            this.LBL_Legend3.TabIndex = 105;
            this.LBL_Legend3.Text = "GL && HF !";
            this.LBL_Legend3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnStayClick_MouseDown);
            // 
            // LBL_DEF1
            // 
            this.LBL_DEF1.AutoSize = true;
            this.LBL_DEF1.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_DEF1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(115)))), ((int)(((byte)(65)))));
            this.LBL_DEF1.Location = new System.Drawing.Point(128, 82);
            this.LBL_DEF1.Name = "LBL_DEF1";
            this.LBL_DEF1.Size = new System.Drawing.Size(12, 18);
            this.LBL_DEF1.TabIndex = 104;
            this.LBL_DEF1.Text = ":";
            this.LBL_DEF1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnStayClick_MouseDown);
            // 
            // LBL_Assoc3
            // 
            this.LBL_Assoc3.AutoSize = true;
            this.LBL_Assoc3.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Assoc3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(115)))), ((int)(((byte)(65)))));
            this.LBL_Assoc3.Location = new System.Drawing.Point(64, 83);
            this.LBL_Assoc3.Name = "LBL_Assoc3";
            this.LBL_Assoc3.Size = new System.Drawing.Size(19, 18);
            this.LBL_Assoc3.TabIndex = 103;
            this.LBL_Assoc3.Text = "+";
            this.LBL_Assoc3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnStayClick_MouseDown);
            // 
            // LBL_ExeKey3
            // 
            this.LBL_ExeKey3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LBL_ExeKey3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LBL_ExeKey3.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_ExeKey3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(115)))), ((int)(((byte)(65)))));
            this.LBL_ExeKey3.Location = new System.Drawing.Point(89, 82);
            this.LBL_ExeKey3.Name = "LBL_ExeKey3";
            this.LBL_ExeKey3.Size = new System.Drawing.Size(33, 20);
            this.LBL_ExeKey3.TabIndex = 102;
            this.LBL_ExeKey3.Text = "&&";
            this.LBL_ExeKey3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LBL_ExeKey3.Click += new System.EventHandler(this.LBL_ExeKey3_Click);
            // 
            // LBL_CTRLKey3
            // 
            this.LBL_CTRLKey3.AutoSize = true;
            this.LBL_CTRLKey3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LBL_CTRLKey3.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_CTRLKey3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(115)))), ((int)(((byte)(65)))));
            this.LBL_CTRLKey3.Location = new System.Drawing.Point(5, 82);
            this.LBL_CTRLKey3.Name = "LBL_CTRLKey3";
            this.LBL_CTRLKey3.Size = new System.Drawing.Size(53, 20);
            this.LBL_CTRLKey3.TabIndex = 101;
            this.LBL_CTRLKey3.Text = "CTRL";
            this.LBL_CTRLKey3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnStayClick_MouseDown);
            // 
            // LBL_Legend2
            // 
            this.LBL_Legend2.AutoSize = true;
            this.LBL_Legend2.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Legend2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(115)))), ((int)(((byte)(65)))));
            this.LBL_Legend2.Location = new System.Drawing.Point(128, 48);
            this.LBL_Legend2.Name = "LBL_Legend2";
            this.LBL_Legend2.Size = new System.Drawing.Size(200, 18);
            this.LBL_Legend2.TabIndex = 106;
            this.LBL_Legend2.Text = "for enable / disable all chat.";
            this.LBL_Legend2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnStayClick_MouseDown);
            // 
            // LBL_Legend4
            // 
            this.LBL_Legend4.AutoSize = true;
            this.LBL_Legend4.Font = new System.Drawing.Font("Garamond", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Legend4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(115)))), ((int)(((byte)(65)))));
            this.LBL_Legend4.Location = new System.Drawing.Point(146, 116);
            this.LBL_Legend4.Name = "LBL_Legend4";
            this.LBL_Legend4.Size = new System.Drawing.Size(138, 18);
            this.LBL_Legend4.TabIndex = 111;
            this.LBL_Legend4.Text = "I need help please.";
            this.LBL_Legend4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnStayClick_MouseDown);
            // 
            // LBL_DEF2
            // 
            this.LBL_DEF2.AutoSize = true;
            this.LBL_DEF2.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_DEF2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(115)))), ((int)(((byte)(65)))));
            this.LBL_DEF2.Location = new System.Drawing.Point(128, 116);
            this.LBL_DEF2.Name = "LBL_DEF2";
            this.LBL_DEF2.Size = new System.Drawing.Size(12, 18);
            this.LBL_DEF2.TabIndex = 110;
            this.LBL_DEF2.Text = ":";
            this.LBL_DEF2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnStayClick_MouseDown);
            // 
            // LBL_Assoc4
            // 
            this.LBL_Assoc4.AutoSize = true;
            this.LBL_Assoc4.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Assoc4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(115)))), ((int)(((byte)(65)))));
            this.LBL_Assoc4.Location = new System.Drawing.Point(64, 117);
            this.LBL_Assoc4.Name = "LBL_Assoc4";
            this.LBL_Assoc4.Size = new System.Drawing.Size(19, 18);
            this.LBL_Assoc4.TabIndex = 109;
            this.LBL_Assoc4.Text = "+";
            this.LBL_Assoc4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnStayClick_MouseDown);
            // 
            // LBL_ExeKey4
            // 
            this.LBL_ExeKey4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LBL_ExeKey4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LBL_ExeKey4.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_ExeKey4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(115)))), ((int)(((byte)(65)))));
            this.LBL_ExeKey4.Location = new System.Drawing.Point(89, 116);
            this.LBL_ExeKey4.Name = "LBL_ExeKey4";
            this.LBL_ExeKey4.Size = new System.Drawing.Size(33, 20);
            this.LBL_ExeKey4.TabIndex = 108;
            this.LBL_ExeKey4.Text = "é";
            this.LBL_ExeKey4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LBL_ExeKey4.Click += new System.EventHandler(this.LBL_ExeKey4_Click);
            // 
            // LBL_CTRLKey4
            // 
            this.LBL_CTRLKey4.AutoSize = true;
            this.LBL_CTRLKey4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LBL_CTRLKey4.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_CTRLKey4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(115)))), ((int)(((byte)(65)))));
            this.LBL_CTRLKey4.Location = new System.Drawing.Point(5, 116);
            this.LBL_CTRLKey4.Name = "LBL_CTRLKey4";
            this.LBL_CTRLKey4.Size = new System.Drawing.Size(53, 20);
            this.LBL_CTRLKey4.TabIndex = 107;
            this.LBL_CTRLKey4.Text = "CTRL";
            this.LBL_CTRLKey4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnStayClick_MouseDown);
            // 
            // VIEW_LegendTable
            // 
            this.VIEW_LegendTable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.VIEW_LegendTable.Controls.Add(this.LBL_Modify1);
            this.VIEW_LegendTable.Controls.Add(this.TBX_Custom1);
            this.VIEW_LegendTable.Controls.Add(this.LBL_DEF5);
            this.VIEW_LegendTable.Controls.Add(this.label6);
            this.VIEW_LegendTable.Controls.Add(this.LBL_ExeKey7);
            this.VIEW_LegendTable.Controls.Add(this.label8);
            this.VIEW_LegendTable.Controls.Add(this.LBL_Legend6);
            this.VIEW_LegendTable.Controls.Add(this.LBL_DEF4);
            this.VIEW_LegendTable.Controls.Add(this.LBL_Assoc6);
            this.VIEW_LegendTable.Controls.Add(this.LBL_ExeKey6);
            this.VIEW_LegendTable.Controls.Add(this.LBL_CTRLKey6);
            this.VIEW_LegendTable.Controls.Add(this.LBL_Legend5);
            this.VIEW_LegendTable.Controls.Add(this.LBL_DEF3);
            this.VIEW_LegendTable.Controls.Add(this.LBL_Assoc5);
            this.VIEW_LegendTable.Controls.Add(this.LBL_ExeKey5);
            this.VIEW_LegendTable.Controls.Add(this.LBL_CTRLKey5);
            this.VIEW_LegendTable.Controls.Add(this.LBL_Legend2);
            this.VIEW_LegendTable.Controls.Add(this.LBL_Legend4);
            this.VIEW_LegendTable.Controls.Add(this.LBL_DEF2);
            this.VIEW_LegendTable.Controls.Add(this.LBL_Assoc4);
            this.VIEW_LegendTable.Controls.Add(this.LBL_ExeKey4);
            this.VIEW_LegendTable.Controls.Add(this.LBL_CTRLKey4);
            this.VIEW_LegendTable.Controls.Add(this.LBL_Legend3);
            this.VIEW_LegendTable.Controls.Add(this.LBL_DEF1);
            this.VIEW_LegendTable.Controls.Add(this.LBL_Assoc3);
            this.VIEW_LegendTable.Controls.Add(this.LBL_ExeKey3);
            this.VIEW_LegendTable.Controls.Add(this.LBL_CTRLKey3);
            this.VIEW_LegendTable.Controls.Add(this.LBL_Assoc2);
            this.VIEW_LegendTable.Controls.Add(this.LBL_ExeKey2);
            this.VIEW_LegendTable.Controls.Add(this.LBL_CTRLKey2);
            this.VIEW_LegendTable.Controls.Add(this.LBL_Legend1);
            this.VIEW_LegendTable.Controls.Add(this.LBL_Assoc1);
            this.VIEW_LegendTable.Controls.Add(this.LBL_ExeKey1);
            this.VIEW_LegendTable.Controls.Add(this.LBL_CTRLKey1);
            this.VIEW_LegendTable.Location = new System.Drawing.Point(20, 209);
            this.VIEW_LegendTable.Name = "VIEW_LegendTable";
            this.VIEW_LegendTable.Size = new System.Drawing.Size(364, 248);
            this.VIEW_LegendTable.TabIndex = 112;
            this.VIEW_LegendTable.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnStayClick_MouseDown);
            // 
            // LBL_Modify1
            // 
            this.LBL_Modify1.AutoSize = true;
            this.LBL_Modify1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LBL_Modify1.Font = new System.Drawing.Font("Garamond", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Modify1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(115)))), ((int)(((byte)(65)))));
            this.LBL_Modify1.Location = new System.Drawing.Point(329, 210);
            this.LBL_Modify1.Name = "LBL_Modify1";
            this.LBL_Modify1.Size = new System.Drawing.Size(27, 24);
            this.LBL_Modify1.TabIndex = 127;
            this.LBL_Modify1.Text = "🖉";
            this.LBL_Modify1.Click += new System.EventHandler(this.LBL_Modify1_Click);
            this.LBL_Modify1.MouseEnter += new System.EventHandler(this.LBL_Modify1_MouseEnter);
            this.LBL_Modify1.MouseLeave += new System.EventHandler(this.LBL_Modify1_MouseLeave);
            // 
            // TBX_Custom1
            // 
            this.TBX_Custom1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(21)))), ((int)(((byte)(40)))));
            this.TBX_Custom1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBX_Custom1.Enabled = false;
            this.TBX_Custom1.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold);
            this.TBX_Custom1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(115)))), ((int)(((byte)(65)))));
            this.TBX_Custom1.Location = new System.Drawing.Point(149, 213);
            this.TBX_Custom1.Name = "TBX_Custom1";
            this.TBX_Custom1.Size = new System.Drawing.Size(173, 25);
            this.TBX_Custom1.TabIndex = 126;
            // 
            // LBL_DEF5
            // 
            this.LBL_DEF5.AutoSize = true;
            this.LBL_DEF5.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_DEF5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(115)))), ((int)(((byte)(65)))));
            this.LBL_DEF5.Location = new System.Drawing.Point(128, 216);
            this.LBL_DEF5.Name = "LBL_DEF5";
            this.LBL_DEF5.Size = new System.Drawing.Size(12, 18);
            this.LBL_DEF5.TabIndex = 125;
            this.LBL_DEF5.Text = ":";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(115)))), ((int)(((byte)(65)))));
            this.label6.Location = new System.Drawing.Point(64, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 18);
            this.label6.TabIndex = 124;
            this.label6.Text = "+";
            // 
            // LBL_ExeKey7
            // 
            this.LBL_ExeKey7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LBL_ExeKey7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LBL_ExeKey7.Font = new System.Drawing.Font("Garamond", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_ExeKey7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(115)))), ((int)(((byte)(65)))));
            this.LBL_ExeKey7.Location = new System.Drawing.Point(89, 216);
            this.LBL_ExeKey7.Name = "LBL_ExeKey7";
            this.LBL_ExeKey7.Size = new System.Drawing.Size(33, 20);
            this.LBL_ExeKey7.TabIndex = 123;
            this.LBL_ExeKey7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LBL_ExeKey7.Click += new System.EventHandler(this.LBL_ExeKey7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(115)))), ((int)(((byte)(65)))));
            this.label8.Location = new System.Drawing.Point(5, 216);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 20);
            this.label8.TabIndex = 122;
            this.label8.Text = "CTRL";
            // 
            // LBL_Legend6
            // 
            this.LBL_Legend6.AutoSize = true;
            this.LBL_Legend6.Font = new System.Drawing.Font("Garamond", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Legend6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(115)))), ((int)(((byte)(65)))));
            this.LBL_Legend6.Location = new System.Drawing.Point(146, 184);
            this.LBL_Legend6.Name = "LBL_Legend6";
            this.LBL_Legend6.Size = new System.Drawing.Size(177, 18);
            this.LBL_Legend6.TabIndex = 121;
            this.LBL_Legend6.Text = "The pleasure is all mine!";
            this.LBL_Legend6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnStayClick_MouseDown);
            // 
            // LBL_DEF4
            // 
            this.LBL_DEF4.AutoSize = true;
            this.LBL_DEF4.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_DEF4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(115)))), ((int)(((byte)(65)))));
            this.LBL_DEF4.Location = new System.Drawing.Point(128, 184);
            this.LBL_DEF4.Name = "LBL_DEF4";
            this.LBL_DEF4.Size = new System.Drawing.Size(12, 18);
            this.LBL_DEF4.TabIndex = 120;
            this.LBL_DEF4.Text = ":";
            this.LBL_DEF4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnStayClick_MouseDown);
            // 
            // LBL_Assoc6
            // 
            this.LBL_Assoc6.AutoSize = true;
            this.LBL_Assoc6.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Assoc6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(115)))), ((int)(((byte)(65)))));
            this.LBL_Assoc6.Location = new System.Drawing.Point(64, 185);
            this.LBL_Assoc6.Name = "LBL_Assoc6";
            this.LBL_Assoc6.Size = new System.Drawing.Size(19, 18);
            this.LBL_Assoc6.TabIndex = 119;
            this.LBL_Assoc6.Text = "+";
            this.LBL_Assoc6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnStayClick_MouseDown);
            // 
            // LBL_ExeKey6
            // 
            this.LBL_ExeKey6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LBL_ExeKey6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LBL_ExeKey6.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_ExeKey6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(115)))), ((int)(((byte)(65)))));
            this.LBL_ExeKey6.Location = new System.Drawing.Point(89, 184);
            this.LBL_ExeKey6.Name = "LBL_ExeKey6";
            this.LBL_ExeKey6.Size = new System.Drawing.Size(33, 20);
            this.LBL_ExeKey6.TabIndex = 118;
            this.LBL_ExeKey6.Text = "\'";
            this.LBL_ExeKey6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LBL_ExeKey6.Click += new System.EventHandler(this.LBL_ExeKey6_Click);
            // 
            // LBL_CTRLKey6
            // 
            this.LBL_CTRLKey6.AutoSize = true;
            this.LBL_CTRLKey6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LBL_CTRLKey6.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_CTRLKey6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(115)))), ((int)(((byte)(65)))));
            this.LBL_CTRLKey6.Location = new System.Drawing.Point(5, 184);
            this.LBL_CTRLKey6.Name = "LBL_CTRLKey6";
            this.LBL_CTRLKey6.Size = new System.Drawing.Size(53, 20);
            this.LBL_CTRLKey6.TabIndex = 117;
            this.LBL_CTRLKey6.Text = "CTRL";
            this.LBL_CTRLKey6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnStayClick_MouseDown);
            // 
            // LBL_Legend5
            // 
            this.LBL_Legend5.AutoSize = true;
            this.LBL_Legend5.Font = new System.Drawing.Font("Garamond", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Legend5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(115)))), ((int)(((byte)(65)))));
            this.LBL_Legend5.Location = new System.Drawing.Point(146, 150);
            this.LBL_Legend5.Name = "LBL_Legend5";
            this.LBL_Legend5.Size = new System.Drawing.Size(164, 18);
            this.LBL_Legend5.TabIndex = 116;
            this.LBL_Legend5.Text = "Thank you very much!";
            this.LBL_Legend5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnStayClick_MouseDown);
            // 
            // LBL_DEF3
            // 
            this.LBL_DEF3.AutoSize = true;
            this.LBL_DEF3.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_DEF3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(115)))), ((int)(((byte)(65)))));
            this.LBL_DEF3.Location = new System.Drawing.Point(128, 150);
            this.LBL_DEF3.Name = "LBL_DEF3";
            this.LBL_DEF3.Size = new System.Drawing.Size(12, 18);
            this.LBL_DEF3.TabIndex = 115;
            this.LBL_DEF3.Text = ":";
            this.LBL_DEF3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnStayClick_MouseDown);
            // 
            // LBL_Assoc5
            // 
            this.LBL_Assoc5.AutoSize = true;
            this.LBL_Assoc5.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Assoc5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(115)))), ((int)(((byte)(65)))));
            this.LBL_Assoc5.Location = new System.Drawing.Point(64, 151);
            this.LBL_Assoc5.Name = "LBL_Assoc5";
            this.LBL_Assoc5.Size = new System.Drawing.Size(19, 18);
            this.LBL_Assoc5.TabIndex = 114;
            this.LBL_Assoc5.Text = "+";
            this.LBL_Assoc5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnStayClick_MouseDown);
            // 
            // LBL_ExeKey5
            // 
            this.LBL_ExeKey5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LBL_ExeKey5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LBL_ExeKey5.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_ExeKey5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(115)))), ((int)(((byte)(65)))));
            this.LBL_ExeKey5.Location = new System.Drawing.Point(89, 150);
            this.LBL_ExeKey5.Name = "LBL_ExeKey5";
            this.LBL_ExeKey5.Size = new System.Drawing.Size(33, 20);
            this.LBL_ExeKey5.TabIndex = 113;
            this.LBL_ExeKey5.Text = "\"";
            this.LBL_ExeKey5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LBL_ExeKey5.Click += new System.EventHandler(this.LBL_ExeKey5_Click);
            // 
            // LBL_CTRLKey5
            // 
            this.LBL_CTRLKey5.AutoSize = true;
            this.LBL_CTRLKey5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LBL_CTRLKey5.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_CTRLKey5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(115)))), ((int)(((byte)(65)))));
            this.LBL_CTRLKey5.Location = new System.Drawing.Point(5, 150);
            this.LBL_CTRLKey5.Name = "LBL_CTRLKey5";
            this.LBL_CTRLKey5.Size = new System.Drawing.Size(53, 20);
            this.LBL_CTRLKey5.TabIndex = 112;
            this.LBL_CTRLKey5.Text = "CTRL";
            this.LBL_CTRLKey5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnStayClick_MouseDown);
            // 
            // CBX_ToggleAll
            // 
            this.CBX_ToggleAll.AutoSize = true;
            this.CBX_ToggleAll.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold);
            this.CBX_ToggleAll.Location = new System.Drawing.Point(20, 495);
            this.CBX_ToggleAll.Name = "CBX_ToggleAll";
            this.CBX_ToggleAll.Size = new System.Drawing.Size(161, 22);
            this.CBX_ToggleAll.TabIndex = 113;
            this.CBX_ToggleAll.Text = "Auto toggle all chat";
            this.CBX_ToggleAll.UseVisualStyleBackColor = true;
            // 
            // TTIP_Ver
            // 
            this.TTIP_Ver.AutoPopDelay = 5000;
            this.TTIP_Ver.InitialDelay = 250;
            this.TTIP_Ver.ReshowDelay = 100;
            // 
            // LBL_WarnCopyPaste
            // 
            this.LBL_WarnCopyPaste.AutoSize = true;
            this.LBL_WarnCopyPaste.Font = new System.Drawing.Font("Garamond", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_WarnCopyPaste.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(115)))), ((int)(((byte)(65)))));
            this.LBL_WarnCopyPaste.Location = new System.Drawing.Point(26, 463);
            this.LBL_WarnCopyPaste.Name = "LBL_WarnCopyPaste";
            this.LBL_WarnCopyPaste.Size = new System.Drawing.Size(281, 12);
            this.LBL_WarnCopyPaste.TabIndex = 114;
            this.LBL_WarnCopyPaste.Text = "* It is recommended not to use this tool for paste long text.";
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(28)))), ((int)(((byte)(52)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(21)))), ((int)(((byte)(40)))));
            this.button1.Image = global::LeagueOfLegends_ClipBoard.Properties.Resources.questionmarklow;
            this.button1.Location = new System.Drawing.Point(313, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(26, 28);
            this.button1.TabIndex = 90;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.QuestionMarkButton_Click);
            // 
            // IMG_Icon
            // 
            this.IMG_Icon.Image = global::LeagueOfLegends_ClipBoard.Properties.Resources.logo;
            this.IMG_Icon.Location = new System.Drawing.Point(156, 12);
            this.IMG_Icon.Name = "IMG_Icon";
            this.IMG_Icon.Size = new System.Drawing.Size(92, 92);
            this.IMG_Icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.IMG_Icon.TabIndex = 87;
            this.IMG_Icon.TabStop = false;
            this.IMG_Icon.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnStayClick_MouseDown);
            // 
            // OptionsButton
            // 
            this.OptionsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OptionsButton.FlatAppearance.BorderSize = 0;
            this.OptionsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(28)))), ((int)(((byte)(52)))));
            this.OptionsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OptionsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(21)))), ((int)(((byte)(40)))));
            this.OptionsButton.Image = ((System.Drawing.Image)(resources.GetObject("OptionsButton.Image")));
            this.OptionsButton.Location = new System.Drawing.Point(314, 3);
            this.OptionsButton.Name = "OptionsButton";
            this.OptionsButton.Size = new System.Drawing.Size(26, 28);
            this.OptionsButton.TabIndex = 77;
            this.OptionsButton.UseVisualStyleBackColor = true;
            this.OptionsButton.Visible = false;
            // 
            // ReduceButton
            // 
            this.ReduceButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ReduceButton.FlatAppearance.BorderSize = 0;
            this.ReduceButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(28)))), ((int)(((byte)(52)))));
            this.ReduceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReduceButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(21)))), ((int)(((byte)(40)))));
            this.ReduceButton.Image = ((System.Drawing.Image)(resources.GetObject("ReduceButton.Image")));
            this.ReduceButton.Location = new System.Drawing.Point(345, 3);
            this.ReduceButton.Name = "ReduceButton";
            this.ReduceButton.Size = new System.Drawing.Size(26, 28);
            this.ReduceButton.TabIndex = 76;
            this.ReduceButton.UseVisualStyleBackColor = true;
            this.ReduceButton.Click += new System.EventHandler(this.ReduceButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.FlatAppearance.BorderSize = 0;
            this.CloseButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(28)))), ((int)(((byte)(52)))));
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(21)))), ((int)(((byte)(40)))));
            this.CloseButton.Image = ((System.Drawing.Image)(resources.GetObject("CloseButton.Image")));
            this.CloseButton.Location = new System.Drawing.Point(375, 3);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(26, 28);
            this.CloseButton.TabIndex = 75;
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // CBX_ClientDetection
            // 
            this.CBX_ClientDetection.AutoSize = true;
            this.CBX_ClientDetection.Checked = true;
            this.CBX_ClientDetection.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CBX_ClientDetection.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold);
            this.CBX_ClientDetection.Location = new System.Drawing.Point(214, 495);
            this.CBX_ClientDetection.Name = "CBX_ClientDetection";
            this.CBX_ClientDetection.Size = new System.Drawing.Size(163, 22);
            this.CBX_ClientDetection.TabIndex = 115;
            this.CBX_ClientDetection.Text = "Active only in game";
            this.CBX_ClientDetection.UseVisualStyleBackColor = true;
            this.CBX_ClientDetection.CheckedChanged += new System.EventHandler(this.CBX_ClientDetection_CheckedChanged_1);
            // 
            // FRM_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(21)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(405, 575);
            this.Controls.Add(this.CBX_ClientDetection);
            this.Controls.Add(this.LBL_isActive);
            this.Controls.Add(this.LBL_WarnCopyPaste);
            this.Controls.Add(this.CBX_ToggleAll);
            this.Controls.Add(this.LBL_Version);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LBL_Dev);
            this.Controls.Add(this.IMG_Icon);
            this.Controls.Add(this.LBL_Clipboard);
            this.Controls.Add(this.OptionsButton);
            this.Controls.Add(this.ReduceButton);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.VIEW_LegendTable);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(115)))), ((int)(((byte)(65)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FRM_Main";
            this.Text = "League Of Legends ClipBoard";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FRM_Main_Windows_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnStayClick_MouseDown);
            this.VIEW_LegendTable.ResumeLayout(false);
            this.VIEW_LegendTable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IMG_Icon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OptionsButton;
        private System.Windows.Forms.Button ReduceButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Label LBL_Clipboard;
        private System.Windows.Forms.Label LBL_isActive;
        private System.Windows.Forms.NotifyIcon notifIcon;
        private System.Windows.Forms.PictureBox IMG_Icon;
        private System.Windows.Forms.Label LBL_Dev;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label LBL_Version;
        private System.Windows.Forms.Label LBL_CTRLKey1;
        private System.Windows.Forms.Label LBL_ExeKey1;
        private System.Windows.Forms.Label LBL_Assoc1;
        private System.Windows.Forms.Label LBL_Legend1;
        private System.Windows.Forms.Label LBL_Assoc2;
        private System.Windows.Forms.Label LBL_ExeKey2;
        private System.Windows.Forms.Label LBL_CTRLKey2;
        private System.Windows.Forms.Label LBL_Legend3;
        private System.Windows.Forms.Label LBL_DEF1;
        private System.Windows.Forms.Label LBL_Assoc3;
        private System.Windows.Forms.Label LBL_ExeKey3;
        private System.Windows.Forms.Label LBL_CTRLKey3;
        private System.Windows.Forms.Label LBL_Legend2;
        private System.Windows.Forms.Label LBL_Legend4;
        private System.Windows.Forms.Label LBL_DEF2;
        private System.Windows.Forms.Label LBL_Assoc4;
        private System.Windows.Forms.Label LBL_ExeKey4;
        private System.Windows.Forms.Label LBL_CTRLKey4;
        private System.Windows.Forms.Panel VIEW_LegendTable;
        private System.Windows.Forms.CheckBox CBX_ToggleAll;
        private System.Windows.Forms.Label LBL_Legend5;
        private System.Windows.Forms.Label LBL_DEF3;
        private System.Windows.Forms.Label LBL_Assoc5;
        private System.Windows.Forms.Label LBL_ExeKey5;
        private System.Windows.Forms.Label LBL_CTRLKey5;
        private System.Windows.Forms.ToolTip TTIP_Ver;
        private System.Windows.Forms.Label LBL_WarnCopyPaste;
        private System.Windows.Forms.Label LBL_Legend6;
        private System.Windows.Forms.Label LBL_DEF4;
        private System.Windows.Forms.Label LBL_Assoc6;
        private System.Windows.Forms.Label LBL_ExeKey6;
        private System.Windows.Forms.Label LBL_CTRLKey6;
        private System.Windows.Forms.Label LBL_DEF5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label LBL_ExeKey7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label LBL_Modify1;
        private System.Windows.Forms.TextBox TBX_Custom1;
        private System.Windows.Forms.CheckBox CBX_ClientDetection;
    }
}


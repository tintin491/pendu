namespace PremierProgramme
{
    partial class jeu
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
            if (disposing && (components != null))
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
            this.txt_nom = new System.Windows.Forms.TextBox();
            this.txt_difficulte = new System.Windows.Forms.TextBox();
            this.txt_motPendue = new System.Windows.Forms.TextBox();
            this.buttonA = new System.Windows.Forms.Button();
            this.buttonB = new System.Windows.Forms.Button();
            this.buttonC = new System.Windows.Forms.Button();
            this.buttonO = new System.Windows.Forms.Button();
            this.buttonN = new System.Windows.Forms.Button();
            this.buttonM = new System.Windows.Forms.Button();
            this.buttonL = new System.Windows.Forms.Button();
            this.buttonK = new System.Windows.Forms.Button();
            this.buttonJ = new System.Windows.Forms.Button();
            this.buttonI = new System.Windows.Forms.Button();
            this.buttonH = new System.Windows.Forms.Button();
            this.buttonG = new System.Windows.Forms.Button();
            this.buttonF = new System.Windows.Forms.Button();
            this.buttonE = new System.Windows.Forms.Button();
            this.buttonD = new System.Windows.Forms.Button();
            this.buttonT = new System.Windows.Forms.Button();
            this.buttonS = new System.Windows.Forms.Button();
            this.buttonR = new System.Windows.Forms.Button();
            this.buttonQ = new System.Windows.Forms.Button();
            this.buttonP = new System.Windows.Forms.Button();
            this.buttonW = new System.Windows.Forms.Button();
            this.buttonV = new System.Windows.Forms.Button();
            this.buttonX = new System.Windows.Forms.Button();
            this.buttonU = new System.Windows.Forms.Button();
            this.buttonY = new System.Windows.Forms.Button();
            this.buttonZ = new System.Windows.Forms.Button();
            this.txt_timer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.progress_barPendue = new System.Windows.Forms.ProgressBar();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.imagePendue = new System.Windows.Forms.PictureBox();
            this.btn_fermer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagePendue)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_nom
            // 
            this.txt_nom.Location = new System.Drawing.Point(596, 68);
            this.txt_nom.Name = "txt_nom";
            this.txt_nom.ReadOnly = true;
            this.txt_nom.Size = new System.Drawing.Size(136, 20);
            this.txt_nom.TabIndex = 2;
            // 
            // txt_difficulte
            // 
            this.txt_difficulte.Location = new System.Drawing.Point(596, 116);
            this.txt_difficulte.Name = "txt_difficulte";
            this.txt_difficulte.ReadOnly = true;
            this.txt_difficulte.Size = new System.Drawing.Size(136, 20);
            this.txt_difficulte.TabIndex = 3;
            this.txt_difficulte.TextChanged += new System.EventHandler(this.Txt_difficulte_TextChanged);
            // 
            // txt_motPendue
            // 
            this.txt_motPendue.Location = new System.Drawing.Point(113, 278);
            this.txt_motPendue.Name = "txt_motPendue";
            this.txt_motPendue.ReadOnly = true;
            this.txt_motPendue.Size = new System.Drawing.Size(363, 20);
            this.txt_motPendue.TabIndex = 4;
            this.txt_motPendue.TextChanged += new System.EventHandler(this.Txt_motPendue_TextChanged);
            // 
            // buttonA
            // 
            this.buttonA.Location = new System.Drawing.Point(113, 304);
            this.buttonA.Name = "buttonA";
            this.buttonA.Size = new System.Drawing.Size(35, 25);
            this.buttonA.TabIndex = 0;
            this.buttonA.Text = "A";
            this.buttonA.UseVisualStyleBackColor = true;
            this.buttonA.Click += new System.EventHandler(this.btn_A_click);
            // 
            // buttonB
            // 
            this.buttonB.Location = new System.Drawing.Point(154, 304);
            this.buttonB.Name = "buttonB";
            this.buttonB.Size = new System.Drawing.Size(35, 25);
            this.buttonB.TabIndex = 5;
            this.buttonB.Text = "B";
            this.buttonB.UseVisualStyleBackColor = true;
            this.buttonB.Click += new System.EventHandler(this.btn_A_click);
            // 
            // buttonC
            // 
            this.buttonC.Location = new System.Drawing.Point(195, 304);
            this.buttonC.Name = "buttonC";
            this.buttonC.Size = new System.Drawing.Size(35, 25);
            this.buttonC.TabIndex = 6;
            this.buttonC.Text = "C";
            this.buttonC.UseVisualStyleBackColor = true;
            this.buttonC.Click += new System.EventHandler(this.btn_A_click);
            // 
            // buttonO
            // 
            this.buttonO.Location = new System.Drawing.Point(318, 335);
            this.buttonO.Name = "buttonO";
            this.buttonO.Size = new System.Drawing.Size(35, 25);
            this.buttonO.TabIndex = 7;
            this.buttonO.Text = "O";
            this.buttonO.UseVisualStyleBackColor = true;
            this.buttonO.Click += new System.EventHandler(this.btn_A_click);
            // 
            // buttonN
            // 
            this.buttonN.Location = new System.Drawing.Point(277, 335);
            this.buttonN.Name = "buttonN";
            this.buttonN.Size = new System.Drawing.Size(35, 25);
            this.buttonN.TabIndex = 8;
            this.buttonN.Text = "N";
            this.buttonN.UseVisualStyleBackColor = true;
            this.buttonN.Click += new System.EventHandler(this.btn_A_click);
            // 
            // buttonM
            // 
            this.buttonM.Location = new System.Drawing.Point(236, 335);
            this.buttonM.Name = "buttonM";
            this.buttonM.Size = new System.Drawing.Size(35, 25);
            this.buttonM.TabIndex = 9;
            this.buttonM.Text = "M";
            this.buttonM.UseVisualStyleBackColor = true;
            this.buttonM.Click += new System.EventHandler(this.btn_A_click);
            // 
            // buttonL
            // 
            this.buttonL.Location = new System.Drawing.Point(195, 335);
            this.buttonL.Name = "buttonL";
            this.buttonL.Size = new System.Drawing.Size(35, 25);
            this.buttonL.TabIndex = 10;
            this.buttonL.Text = "L";
            this.buttonL.UseVisualStyleBackColor = true;
            this.buttonL.Click += new System.EventHandler(this.btn_A_click);
            // 
            // buttonK
            // 
            this.buttonK.Location = new System.Drawing.Point(154, 335);
            this.buttonK.Name = "buttonK";
            this.buttonK.Size = new System.Drawing.Size(35, 25);
            this.buttonK.TabIndex = 11;
            this.buttonK.Text = "K";
            this.buttonK.UseVisualStyleBackColor = true;
            this.buttonK.Click += new System.EventHandler(this.btn_A_click);
            // 
            // buttonJ
            // 
            this.buttonJ.Location = new System.Drawing.Point(113, 335);
            this.buttonJ.Name = "buttonJ";
            this.buttonJ.Size = new System.Drawing.Size(35, 25);
            this.buttonJ.TabIndex = 12;
            this.buttonJ.Text = "J";
            this.buttonJ.UseVisualStyleBackColor = true;
            this.buttonJ.Click += new System.EventHandler(this.btn_A_click);
            // 
            // buttonI
            // 
            this.buttonI.Location = new System.Drawing.Point(441, 304);
            this.buttonI.Name = "buttonI";
            this.buttonI.Size = new System.Drawing.Size(35, 25);
            this.buttonI.TabIndex = 13;
            this.buttonI.Text = "I";
            this.buttonI.UseVisualStyleBackColor = true;
            this.buttonI.Click += new System.EventHandler(this.btn_A_click);
            // 
            // buttonH
            // 
            this.buttonH.Location = new System.Drawing.Point(400, 304);
            this.buttonH.Name = "buttonH";
            this.buttonH.Size = new System.Drawing.Size(35, 25);
            this.buttonH.TabIndex = 14;
            this.buttonH.Text = "H";
            this.buttonH.UseVisualStyleBackColor = true;
            this.buttonH.Click += new System.EventHandler(this.btn_A_click);
            // 
            // buttonG
            // 
            this.buttonG.Location = new System.Drawing.Point(359, 305);
            this.buttonG.Name = "buttonG";
            this.buttonG.Size = new System.Drawing.Size(35, 25);
            this.buttonG.TabIndex = 15;
            this.buttonG.Text = "G";
            this.buttonG.UseVisualStyleBackColor = true;
            this.buttonG.Click += new System.EventHandler(this.btn_A_click);
            // 
            // buttonF
            // 
            this.buttonF.Location = new System.Drawing.Point(318, 304);
            this.buttonF.Name = "buttonF";
            this.buttonF.Size = new System.Drawing.Size(35, 25);
            this.buttonF.TabIndex = 16;
            this.buttonF.Text = "F";
            this.buttonF.UseVisualStyleBackColor = true;
            this.buttonF.Click += new System.EventHandler(this.btn_A_click);
            // 
            // buttonE
            // 
            this.buttonE.Location = new System.Drawing.Point(277, 304);
            this.buttonE.Name = "buttonE";
            this.buttonE.Size = new System.Drawing.Size(35, 25);
            this.buttonE.TabIndex = 17;
            this.buttonE.Text = "E";
            this.buttonE.UseVisualStyleBackColor = true;
            this.buttonE.Click += new System.EventHandler(this.btn_A_click);
            // 
            // buttonD
            // 
            this.buttonD.Location = new System.Drawing.Point(236, 304);
            this.buttonD.Name = "buttonD";
            this.buttonD.Size = new System.Drawing.Size(35, 25);
            this.buttonD.TabIndex = 18;
            this.buttonD.Text = "D";
            this.buttonD.UseVisualStyleBackColor = true;
            this.buttonD.Click += new System.EventHandler(this.btn_A_click);
            // 
            // buttonT
            // 
            this.buttonT.Location = new System.Drawing.Point(236, 366);
            this.buttonT.Name = "buttonT";
            this.buttonT.Size = new System.Drawing.Size(35, 25);
            this.buttonT.TabIndex = 19;
            this.buttonT.Text = "T";
            this.buttonT.UseVisualStyleBackColor = true;
            this.buttonT.Click += new System.EventHandler(this.btn_A_click);
            // 
            // buttonS
            // 
            this.buttonS.Location = new System.Drawing.Point(195, 366);
            this.buttonS.Name = "buttonS";
            this.buttonS.Size = new System.Drawing.Size(35, 25);
            this.buttonS.TabIndex = 20;
            this.buttonS.Text = "S";
            this.buttonS.UseVisualStyleBackColor = true;
            this.buttonS.Click += new System.EventHandler(this.btn_A_click);
            // 
            // buttonR
            // 
            this.buttonR.Location = new System.Drawing.Point(441, 336);
            this.buttonR.Name = "buttonR";
            this.buttonR.Size = new System.Drawing.Size(35, 25);
            this.buttonR.TabIndex = 21;
            this.buttonR.Text = "R";
            this.buttonR.UseVisualStyleBackColor = true;
            this.buttonR.Click += new System.EventHandler(this.btn_A_click);
            // 
            // buttonQ
            // 
            this.buttonQ.Location = new System.Drawing.Point(400, 336);
            this.buttonQ.Name = "buttonQ";
            this.buttonQ.Size = new System.Drawing.Size(35, 25);
            this.buttonQ.TabIndex = 22;
            this.buttonQ.Text = "Q";
            this.buttonQ.UseVisualStyleBackColor = true;
            this.buttonQ.Click += new System.EventHandler(this.btn_A_click);
            // 
            // buttonP
            // 
            this.buttonP.Location = new System.Drawing.Point(359, 336);
            this.buttonP.Name = "buttonP";
            this.buttonP.Size = new System.Drawing.Size(35, 25);
            this.buttonP.TabIndex = 23;
            this.buttonP.Text = "P";
            this.buttonP.UseVisualStyleBackColor = true;
            this.buttonP.Click += new System.EventHandler(this.btn_A_click);
            // 
            // buttonW
            // 
            this.buttonW.Location = new System.Drawing.Point(359, 367);
            this.buttonW.Name = "buttonW";
            this.buttonW.Size = new System.Drawing.Size(35, 25);
            this.buttonW.TabIndex = 24;
            this.buttonW.Text = "W";
            this.buttonW.UseVisualStyleBackColor = true;
            this.buttonW.Click += new System.EventHandler(this.btn_A_click);
            // 
            // buttonV
            // 
            this.buttonV.Location = new System.Drawing.Point(318, 367);
            this.buttonV.Name = "buttonV";
            this.buttonV.Size = new System.Drawing.Size(35, 25);
            this.buttonV.TabIndex = 25;
            this.buttonV.Text = "V";
            this.buttonV.UseVisualStyleBackColor = true;
            this.buttonV.ClientSizeChanged += new System.EventHandler(this.btn_A_click);
            this.buttonV.Click += new System.EventHandler(this.btn_A_click);
            // 
            // buttonX
            // 
            this.buttonX.Location = new System.Drawing.Point(236, 397);
            this.buttonX.Name = "buttonX";
            this.buttonX.Size = new System.Drawing.Size(35, 25);
            this.buttonX.TabIndex = 26;
            this.buttonX.Text = "X";
            this.buttonX.UseVisualStyleBackColor = true;
            this.buttonX.Click += new System.EventHandler(this.btn_A_click);
            // 
            // buttonU
            // 
            this.buttonU.Location = new System.Drawing.Point(277, 366);
            this.buttonU.Name = "buttonU";
            this.buttonU.Size = new System.Drawing.Size(35, 25);
            this.buttonU.TabIndex = 27;
            this.buttonU.Text = "U";
            this.buttonU.UseVisualStyleBackColor = true;
            this.buttonU.Click += new System.EventHandler(this.btn_A_click);
            // 
            // buttonY
            // 
            this.buttonY.Location = new System.Drawing.Point(277, 397);
            this.buttonY.Name = "buttonY";
            this.buttonY.Size = new System.Drawing.Size(35, 25);
            this.buttonY.TabIndex = 28;
            this.buttonY.Text = "Y";
            this.buttonY.UseVisualStyleBackColor = true;
            this.buttonY.Click += new System.EventHandler(this.btn_A_click);
            // 
            // buttonZ
            // 
            this.buttonZ.Location = new System.Drawing.Point(318, 397);
            this.buttonZ.Name = "buttonZ";
            this.buttonZ.Size = new System.Drawing.Size(35, 25);
            this.buttonZ.TabIndex = 29;
            this.buttonZ.Text = "Z";
            this.buttonZ.UseVisualStyleBackColor = true;
            this.buttonZ.Click += new System.EventHandler(this.btn_A_click);
            // 
            // txt_timer
            // 
            this.txt_timer.Location = new System.Drawing.Point(596, 278);
            this.txt_timer.Name = "txt_timer";
            this.txt_timer.Size = new System.Drawing.Size(100, 20);
            this.txt_timer.TabIndex = 30;
            this.txt_timer.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(525, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Joueur : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(525, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Difficulté :";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(593, 262);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "Timer :";
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // progress_barPendue
            // 
            this.progress_barPendue.Location = new System.Drawing.Point(154, 249);
            this.progress_barPendue.Maximum = 10;
            this.progress_barPendue.Name = "progress_barPendue";
            this.progress_barPendue.Size = new System.Drawing.Size(281, 23);
            this.progress_barPendue.TabIndex = 34;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(519, 37);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(234, 128);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // imagePendue
            // 
            this.imagePendue.Image = global::PremierProgramme.Properties.Resources.C1;
            this.imagePendue.Location = new System.Drawing.Point(154, 12);
            this.imagePendue.Name = "imagePendue";
            this.imagePendue.Size = new System.Drawing.Size(281, 217);
            this.imagePendue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagePendue.TabIndex = 0;
            this.imagePendue.TabStop = false;
            // 
            // btn_fermer
            // 
            this.btn_fermer.BackColor = System.Drawing.Color.Coral;
            this.btn_fermer.Location = new System.Drawing.Point(12, 37);
            this.btn_fermer.Name = "btn_fermer";
            this.btn_fermer.Size = new System.Drawing.Size(75, 23);
            this.btn_fermer.TabIndex = 35;
            this.btn_fermer.Text = "Fermer";
            this.btn_fermer.UseVisualStyleBackColor = false;
            this.btn_fermer.Click += new System.EventHandler(this.ButtonFermer_Click);
            // 
            // jeu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_fermer);
            this.Controls.Add(this.progress_barPendue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_timer);
            this.Controls.Add(this.buttonZ);
            this.Controls.Add(this.buttonY);
            this.Controls.Add(this.buttonU);
            this.Controls.Add(this.buttonX);
            this.Controls.Add(this.buttonV);
            this.Controls.Add(this.buttonW);
            this.Controls.Add(this.buttonP);
            this.Controls.Add(this.buttonQ);
            this.Controls.Add(this.buttonR);
            this.Controls.Add(this.buttonS);
            this.Controls.Add(this.buttonT);
            this.Controls.Add(this.buttonD);
            this.Controls.Add(this.buttonE);
            this.Controls.Add(this.buttonF);
            this.Controls.Add(this.buttonG);
            this.Controls.Add(this.buttonH);
            this.Controls.Add(this.buttonI);
            this.Controls.Add(this.buttonJ);
            this.Controls.Add(this.buttonK);
            this.Controls.Add(this.buttonL);
            this.Controls.Add(this.buttonM);
            this.Controls.Add(this.buttonN);
            this.Controls.Add(this.buttonO);
            this.Controls.Add(this.buttonC);
            this.Controls.Add(this.buttonB);
            this.Controls.Add(this.buttonA);
            this.Controls.Add(this.txt_motPendue);
            this.Controls.Add(this.txt_difficulte);
            this.Controls.Add(this.txt_nom);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.imagePendue);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "jeu";
            this.Text = "jeu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagePendue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imagePendue;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txt_nom;
        private System.Windows.Forms.TextBox txt_difficulte;
        private System.Windows.Forms.TextBox txt_motPendue;
        private System.Windows.Forms.Button buttonA;
        private System.Windows.Forms.Button buttonB;
        private System.Windows.Forms.Button buttonC;
        private System.Windows.Forms.Button buttonO;
        private System.Windows.Forms.Button buttonN;
        private System.Windows.Forms.Button buttonM;
        private System.Windows.Forms.Button buttonL;
        private System.Windows.Forms.Button buttonK;
        private System.Windows.Forms.Button buttonJ;
        private System.Windows.Forms.Button buttonI;
        private System.Windows.Forms.Button buttonH;
        private System.Windows.Forms.Button buttonG;
        private System.Windows.Forms.Button buttonF;
        private System.Windows.Forms.Button buttonE;
        private System.Windows.Forms.Button buttonD;
        private System.Windows.Forms.Button buttonT;
        private System.Windows.Forms.Button buttonS;
        private System.Windows.Forms.Button buttonR;
        private System.Windows.Forms.Button buttonQ;
        private System.Windows.Forms.Button buttonP;
        private System.Windows.Forms.Button buttonW;
        private System.Windows.Forms.Button buttonV;
        private System.Windows.Forms.Button buttonX;
        private System.Windows.Forms.Button buttonU;
        private System.Windows.Forms.Button buttonY;
        private System.Windows.Forms.Button buttonZ;
        private System.Windows.Forms.TextBox txt_timer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar progress_barPendue;
        private System.Windows.Forms.Button btn_fermer;
    }
}
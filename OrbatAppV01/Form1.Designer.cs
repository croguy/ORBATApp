namespace OrbatAppV01
{
    partial class Form1
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
            this.orbatGenerate = new System.Windows.Forms.Button();
            this.unitClassName = new System.Windows.Forms.TextBox();
            this.orbatOutputBox = new System.Windows.Forms.TextBox();
            this.orbatSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.unitID = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.unitDisplayType = new System.Windows.Forms.ComboBox();
            this.unitSide = new System.Windows.Forms.ComboBox();
            this.unitSize = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.unitCustomInsignia = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.unitCmdrName = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.unitDescription = new System.Windows.Forms.TextBox();
            this.unitCmdrRank = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.unitTextShort = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.unitType = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.unitSubordinates = new System.Windows.Forms.TextBox();
            this.orbatAppend = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.unitID)).BeginInit();
            this.SuspendLayout();
            // 
            // orbatGenerate
            // 
            this.orbatGenerate.Location = new System.Drawing.Point(374, 506);
            this.orbatGenerate.Name = "orbatGenerate";
            this.orbatGenerate.Size = new System.Drawing.Size(165, 43);
            this.orbatGenerate.TabIndex = 0;
            this.orbatGenerate.Text = "Generate ORBAT class";
            this.orbatGenerate.UseVisualStyleBackColor = true;
            this.orbatGenerate.MouseClick += new System.Windows.Forms.MouseEventHandler(this.orbatGenerate_MouseClick);
            // 
            // unitClassName
            // 
            this.unitClassName.Location = new System.Drawing.Point(195, 12);
            this.unitClassName.Name = "unitClassName";
            this.unitClassName.Size = new System.Drawing.Size(173, 20);
            this.unitClassName.TabIndex = 1;
            this.unitClassName.Text = "unit1stInfUnit";
            // 
            // orbatOutputBox
            // 
            this.orbatOutputBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orbatOutputBox.Location = new System.Drawing.Point(374, 12);
            this.orbatOutputBox.Multiline = true;
            this.orbatOutputBox.Name = "orbatOutputBox";
            this.orbatOutputBox.Size = new System.Drawing.Size(507, 488);
            this.orbatOutputBox.TabIndex = 2;
            // 
            // orbatSave
            // 
            this.orbatSave.Location = new System.Drawing.Point(716, 506);
            this.orbatSave.Name = "orbatSave";
            this.orbatSave.Size = new System.Drawing.Size(165, 43);
            this.orbatSave.TabIndex = 3;
            this.orbatSave.Text = "Generate CfgORBAT.sqf";
            this.orbatSave.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Unit class name (unique)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Unit ID (unique)";
            // 
            // unitID
            // 
            this.unitID.Location = new System.Drawing.Point(195, 38);
            this.unitID.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.unitID.Name = "unitID";
            this.unitID.Size = new System.Drawing.Size(173, 20);
            this.unitID.TabIndex = 6;
            this.unitID.UseWaitCursor = true;
            this.unitID.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ingame ID display method";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 18);
            this.label4.TabIndex = 10;
            this.label4.Text = "Ingame side";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 18);
            this.label5.TabIndex = 11;
            this.label5.Text = "Formation size";
            // 
            // unitDisplayType
            // 
            this.unitDisplayType.FormattingEnabled = true;
            this.unitDisplayType.Items.AddRange(new object[] {
            "0 - Ordinal (4th)",
            "1 - Roman (IV)",
            "2 - NATO (Delta)",
            "3 - Color (Yellow)"});
            this.unitDisplayType.Location = new System.Drawing.Point(195, 119);
            this.unitDisplayType.Name = "unitDisplayType";
            this.unitDisplayType.Size = new System.Drawing.Size(173, 21);
            this.unitDisplayType.TabIndex = 13;
            // 
            // unitSide
            // 
            this.unitSide.FormattingEnabled = true;
            this.unitSide.Items.AddRange(new object[] {
            "0 - West - BLUFOR",
            "1 - East - OPFOR",
            "2 - Resistance - INDFOR",
            "3 - Civilian - CIV",
            "4 - Unknown"});
            this.unitSide.Location = new System.Drawing.Point(195, 146);
            this.unitSide.Name = "unitSide";
            this.unitSide.Size = new System.Drawing.Size(173, 21);
            this.unitSide.TabIndex = 14;
            // 
            // unitSize
            // 
            this.unitSize.FormattingEnabled = true;
            this.unitSize.Items.AddRange(new object[] {
            "0 Fire Team (2-4)",
            "1 Squad (8-12)",
            "2 Platoon (35-45)",
            "3 Company (80-150)",
            "4 Battalion (300-800)",
            "5 Brigade (1,000 - 6,000)",
            "6 Division (10,000 - 25,000)",
            "7 Corps (30,000 - 60,000)",
            "8 Army (100,000 - 300,000)",
            "9 Army Group (600,000+)",
            "10 Unknown"});
            this.unitSize.Location = new System.Drawing.Point(195, 173);
            this.unitSize.Name = "unitSize";
            this.unitSize.Size = new System.Drawing.Size(173, 21);
            this.unitSize.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(176, 18);
            this.label6.TabIndex = 16;
            this.label6.Text = "Custom Unit Insignia path";
            // 
            // unitCustomInsignia
            // 
            this.unitCustomInsignia.Location = new System.Drawing.Point(195, 200);
            this.unitCustomInsignia.Name = "unitCustomInsignia";
            this.unitCustomInsignia.Size = new System.Drawing.Size(173, 20);
            this.unitCustomInsignia.TabIndex = 17;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(12, 228);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(143, 18);
            this.label12.TabIndex = 27;
            this.label12.Text = "Commander\'s name";
            // 
            // unitCmdrName
            // 
            this.unitCmdrName.Location = new System.Drawing.Point(195, 226);
            this.unitCmdrName.Name = "unitCmdrName";
            this.unitCmdrName.Size = new System.Drawing.Size(173, 20);
            this.unitCmdrName.TabIndex = 28;
            this.unitCmdrName.Text = "John Doe";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(12, 314);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(110, 18);
            this.label13.TabIndex = 29;
            this.label13.Text = "Unit description";
            // 
            // unitDescription
            // 
            this.unitDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unitDescription.Location = new System.Drawing.Point(15, 335);
            this.unitDescription.Multiline = true;
            this.unitDescription.Name = "unitDescription";
            this.unitDescription.Size = new System.Drawing.Size(353, 214);
            this.unitDescription.TabIndex = 30;
            this.unitDescription.Text = "Describe the unit, its assets, and specifics in this text box. No new text lines " +
    "preferably.";
            // 
            // unitCmdrRank
            // 
            this.unitCmdrRank.FormattingEnabled = true;
            this.unitCmdrRank.Items.AddRange(new object[] {
            "0 - Private",
            "1 - Corporal",
            "2 - Sergeant",
            "3 - Lieutenant",
            "4 - Captain",
            "5 - Major",
            "6 - Colonel",
            "7 - General"});
            this.unitCmdrRank.Location = new System.Drawing.Point(195, 252);
            this.unitCmdrRank.Name = "unitCmdrRank";
            this.unitCmdrRank.Size = new System.Drawing.Size(173, 21);
            this.unitCmdrRank.TabIndex = 31;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(12, 255);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(135, 18);
            this.label14.TabIndex = 32;
            this.label14.Text = "Commander\'s rank";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(12, 67);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(78, 18);
            this.label15.TabIndex = 33;
            this.label15.Text = "Unit Name";
            // 
            // unitTextShort
            // 
            this.unitTextShort.Location = new System.Drawing.Point(195, 65);
            this.unitTextShort.Name = "unitTextShort";
            this.unitTextShort.Size = new System.Drawing.Size(173, 20);
            this.unitTextShort.TabIndex = 34;
            this.unitTextShort.Text = "1st Infantry Squad (%1 %2 %3)";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(12, 95);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(70, 18);
            this.label16.TabIndex = 35;
            this.label16.Text = "Unit Type";
            // 
            // unitType
            // 
            this.unitType.FormattingEnabled = true;
            this.unitType.Items.AddRange(new object[] {
            "0 - Airborne",
            "1 - Armored",
            "2 - Artillery",
            "3 - Fighter",
            "4 - Helicopter",
            "5 - HQ",
            "6 - Infantry",
            "7 - Maintenance",
            "8 - Maritime",
            "9 - MechanizedInfantry",
            "10 - Medical",
            "11 - Mortar",
            "12 - MotorizedInfantry",
            "13 - Recon",
            "14 - Service",
            "15 - Support",
            "16 - UAV",
            "17 - Unknown"});
            this.unitType.Location = new System.Drawing.Point(195, 92);
            this.unitType.Name = "unitType";
            this.unitType.Size = new System.Drawing.Size(173, 21);
            this.unitType.TabIndex = 36;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(12, 282);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(179, 18);
            this.label17.TabIndex = 37;
            this.label17.Text = "Subordinates classnames";
            // 
            // unitSubordinates
            // 
            this.unitSubordinates.Location = new System.Drawing.Point(195, 279);
            this.unitSubordinates.Name = "unitSubordinates";
            this.unitSubordinates.Size = new System.Drawing.Size(173, 20);
            this.unitSubordinates.TabIndex = 38;
            this.unitSubordinates.Text = "unitPreviousUnit, unit2ndUnit";
            // 
            // orbatAppend
            // 
            this.orbatAppend.Location = new System.Drawing.Point(545, 506);
            this.orbatAppend.Name = "orbatAppend";
            this.orbatAppend.Size = new System.Drawing.Size(165, 43);
            this.orbatAppend.TabIndex = 39;
            this.orbatAppend.Text = "Append with new class";
            this.orbatAppend.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 561);
            this.Controls.Add(this.orbatAppend);
            this.Controls.Add(this.unitSubordinates);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.unitType);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.unitTextShort);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.unitCmdrRank);
            this.Controls.Add(this.unitDescription);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.unitCmdrName);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.unitCustomInsignia);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.unitSize);
            this.Controls.Add(this.unitSide);
            this.Controls.Add(this.unitDisplayType);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.unitID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.orbatSave);
            this.Controls.Add(this.orbatOutputBox);
            this.Controls.Add(this.unitClassName);
            this.Controls.Add(this.orbatGenerate);
            this.Name = "Form1";
            this.Text = "ORBAT Maker v01";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.unitID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button orbatGenerate;
        private System.Windows.Forms.TextBox unitClassName;
        private System.Windows.Forms.TextBox orbatOutputBox;
        private System.Windows.Forms.Button orbatSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown unitID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox unitDisplayType;
        private System.Windows.Forms.ComboBox unitSide;
        private System.Windows.Forms.ComboBox unitSize;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox unitCustomInsignia;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox unitCmdrName;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox unitDescription;
        private System.Windows.Forms.ComboBox unitCmdrRank;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox unitTextShort;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox unitType;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox unitSubordinates;
        private System.Windows.Forms.Button orbatAppend;
    }
}


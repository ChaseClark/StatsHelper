
namespace StatsHelper
{
    partial class Main
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
            this.lblAnswer = new System.Windows.Forms.Label();
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabStringParser = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblStringParserTitle = new System.Windows.Forms.Label();
            this.lblInputString = new System.Windows.Forms.Label();
            this.txtInputString = new System.Windows.Forms.TextBox();
            this.txtTargetSymbol = new System.Windows.Forms.TextBox();
            this.lblTargetSymbol = new System.Windows.Forms.Label();
            this.txtDelimiter = new System.Windows.Forms.TextBox();
            this.lblDelimiter = new System.Windows.Forms.Label();
            this.btnParseString = new System.Windows.Forms.Button();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.tabMain.SuspendLayout();
            this.tabStringParser.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAnswer
            // 
            this.lblAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswer.Location = new System.Drawing.Point(48, 605);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(744, 86);
            this.lblAnswer.TabIndex = 0;
            this.lblAnswer.Text = "answer";
            this.lblAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tabStringParser);
            this.tabMain.Controls.Add(this.tabPage2);
            this.tabMain.Location = new System.Drawing.Point(13, 13);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(933, 589);
            this.tabMain.TabIndex = 1;
            // 
            // tabStringParser
            // 
            this.tabStringParser.Controls.Add(this.btnParseString);
            this.tabStringParser.Controls.Add(this.txtDelimiter);
            this.tabStringParser.Controls.Add(this.lblDelimiter);
            this.tabStringParser.Controls.Add(this.txtTargetSymbol);
            this.tabStringParser.Controls.Add(this.lblTargetSymbol);
            this.tabStringParser.Controls.Add(this.txtInputString);
            this.tabStringParser.Controls.Add(this.lblInputString);
            this.tabStringParser.Controls.Add(this.lblStringParserTitle);
            this.tabStringParser.Location = new System.Drawing.Point(4, 22);
            this.tabStringParser.Name = "tabStringParser";
            this.tabStringParser.Padding = new System.Windows.Forms.Padding(3);
            this.tabStringParser.Size = new System.Drawing.Size(925, 563);
            this.tabStringParser.TabIndex = 0;
            this.tabStringParser.Text = "String Parser";
            this.tabStringParser.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(925, 563);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblStringParserTitle
            // 
            this.lblStringParserTitle.AutoSize = true;
            this.lblStringParserTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStringParserTitle.Location = new System.Drawing.Point(65, 96);
            this.lblStringParserTitle.Name = "lblStringParserTitle";
            this.lblStringParserTitle.Size = new System.Drawing.Size(783, 24);
            this.lblStringParserTitle.TabIndex = 0;
            this.lblStringParserTitle.Text = "This tools parses a string of inputs and calculates the number of hits of a certa" +
    "in input/symbol.";
            // 
            // lblInputString
            // 
            this.lblInputString.AutoSize = true;
            this.lblInputString.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInputString.Location = new System.Drawing.Point(151, 204);
            this.lblInputString.Name = "lblInputString";
            this.lblInputString.Size = new System.Drawing.Size(109, 24);
            this.lblInputString.TabIndex = 1;
            this.lblInputString.Text = "Input String:";
            // 
            // txtInputString
            // 
            this.txtInputString.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInputString.Location = new System.Drawing.Point(271, 202);
            this.txtInputString.Name = "txtInputString";
            this.txtInputString.Size = new System.Drawing.Size(541, 26);
            this.txtInputString.TabIndex = 2;
            // 
            // txtTargetSymbol
            // 
            this.txtTargetSymbol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTargetSymbol.Location = new System.Drawing.Point(271, 257);
            this.txtTargetSymbol.Name = "txtTargetSymbol";
            this.txtTargetSymbol.Size = new System.Drawing.Size(71, 26);
            this.txtTargetSymbol.TabIndex = 4;
            // 
            // lblTargetSymbol
            // 
            this.lblTargetSymbol.AutoSize = true;
            this.lblTargetSymbol.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTargetSymbol.Location = new System.Drawing.Point(82, 259);
            this.lblTargetSymbol.Name = "lblTargetSymbol";
            this.lblTargetSymbol.Size = new System.Drawing.Size(183, 24);
            this.lblTargetSymbol.TabIndex = 3;
            this.lblTargetSymbol.Text = "Target Symbol/Input:";
            // 
            // txtDelimiter
            // 
            this.txtDelimiter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDelimiter.Location = new System.Drawing.Point(271, 308);
            this.txtDelimiter.MaxLength = 1;
            this.txtDelimiter.Name = "txtDelimiter";
            this.txtDelimiter.Size = new System.Drawing.Size(35, 26);
            this.txtDelimiter.TabIndex = 6;
            // 
            // lblDelimiter
            // 
            this.lblDelimiter.AutoSize = true;
            this.lblDelimiter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDelimiter.Location = new System.Drawing.Point(172, 310);
            this.lblDelimiter.Name = "lblDelimiter";
            this.lblDelimiter.Size = new System.Drawing.Size(88, 24);
            this.lblDelimiter.TabIndex = 5;
            this.lblDelimiter.Text = "Delimiter:";
            // 
            // btnParseString
            // 
            this.btnParseString.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnParseString.Location = new System.Drawing.Point(176, 370);
            this.btnParseString.Name = "btnParseString";
            this.btnParseString.Size = new System.Drawing.Size(111, 33);
            this.btnParseString.TabIndex = 7;
            this.btnParseString.Text = "Calculate";
            this.btnParseString.UseVisualStyleBackColor = true;
            this.btnParseString.Click += new System.EventHandler(this.btnParseString_Click);
            // 
            // btnClearAll
            // 
            this.btnClearAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearAll.Location = new System.Drawing.Point(789, 636);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(133, 37);
            this.btnClearAll.TabIndex = 8;
            this.btnClearAll.Text = "Clear All";
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 700);
            this.Controls.Add(this.btnClearAll);
            this.Controls.Add(this.tabMain);
            this.Controls.Add(this.lblAnswer);
            this.Name = "Main";
            this.Text = "Stats Helper";
            this.tabMain.ResumeLayout(false);
            this.tabStringParser.ResumeLayout(false);
            this.tabStringParser.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabStringParser;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lblInputString;
        private System.Windows.Forms.Label lblStringParserTitle;
        private System.Windows.Forms.TextBox txtDelimiter;
        private System.Windows.Forms.Label lblDelimiter;
        private System.Windows.Forms.TextBox txtTargetSymbol;
        private System.Windows.Forms.Label lblTargetSymbol;
        private System.Windows.Forms.TextBox txtInputString;
        private System.Windows.Forms.Button btnParseString;
        private System.Windows.Forms.Button btnClearAll;
    }
}


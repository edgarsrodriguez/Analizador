namespace AnalizadorLexico
{
    partial class LexicalAnalyzer
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
            this.btnInputFile = new System.Windows.Forms.Button();
            this.textInputFile = new System.Windows.Forms.TextBox();
            this.groupInputFile = new System.Windows.Forms.GroupBox();
            this.labelInputFile = new System.Windows.Forms.Label();
            this.btnLex = new System.Windows.Forms.Button();
            this.groupControls = new System.Windows.Forms.GroupBox();
            this.btnSem = new System.Windows.Forms.Button();
            this.btnSin = new System.Windows.Forms.Button();
            this.textInputText = new System.Windows.Forms.TextBox();
            this.groupInputText = new System.Windows.Forms.GroupBox();
            this.groupOutputText = new System.Windows.Forms.GroupBox();
            this.textOutputText = new System.Windows.Forms.TextBox();
            this.groupTree = new System.Windows.Forms.GroupBox();
            this.textTree = new System.Windows.Forms.TextBox();
            this.groupTreeErrors = new System.Windows.Forms.GroupBox();
            this.textTreeErrors = new System.Windows.Forms.TextBox();
            this.groupInputFile.SuspendLayout();
            this.groupControls.SuspendLayout();
            this.groupInputText.SuspendLayout();
            this.groupOutputText.SuspendLayout();
            this.groupTree.SuspendLayout();
            this.groupTreeErrors.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnInputFile
            // 
            this.btnInputFile.Location = new System.Drawing.Point(42, 48);
            this.btnInputFile.Name = "btnInputFile";
            this.btnInputFile.Size = new System.Drawing.Size(120, 40);
            this.btnInputFile.TabIndex = 0;
            this.btnInputFile.Text = "Browse txt file";
            this.btnInputFile.UseVisualStyleBackColor = true;
            this.btnInputFile.Click += new System.EventHandler(this.btnInputFile_Click);
            // 
            // textInputFile
            // 
            this.textInputFile.Location = new System.Drawing.Point(42, 20);
            this.textInputFile.Name = "textInputFile";
            this.textInputFile.Size = new System.Drawing.Size(436, 22);
            this.textInputFile.TabIndex = 1;
            // 
            // groupInputFile
            // 
            this.groupInputFile.Controls.Add(this.labelInputFile);
            this.groupInputFile.Controls.Add(this.btnInputFile);
            this.groupInputFile.Controls.Add(this.textInputFile);
            this.groupInputFile.Location = new System.Drawing.Point(12, 12);
            this.groupInputFile.Name = "groupInputFile";
            this.groupInputFile.Size = new System.Drawing.Size(484, 100);
            this.groupInputFile.TabIndex = 2;
            this.groupInputFile.TabStop = false;
            this.groupInputFile.Text = "Browse";
            // 
            // labelInputFile
            // 
            this.labelInputFile.AutoSize = true;
            this.labelInputFile.Location = new System.Drawing.Point(6, 23);
            this.labelInputFile.Name = "labelInputFile";
            this.labelInputFile.Size = new System.Drawing.Size(30, 17);
            this.labelInputFile.TabIndex = 2;
            this.labelInputFile.Text = "File";
            // 
            // btnLex
            // 
            this.btnLex.Location = new System.Drawing.Point(6, 21);
            this.btnLex.Name = "btnLex";
            this.btnLex.Size = new System.Drawing.Size(120, 40);
            this.btnLex.TabIndex = 3;
            this.btnLex.Text = "Lexico";
            this.btnLex.UseVisualStyleBackColor = true;
            this.btnLex.Click += new System.EventHandler(this.btnLex_Click);
            // 
            // groupControls
            // 
            this.groupControls.Controls.Add(this.btnSem);
            this.groupControls.Controls.Add(this.btnSin);
            this.groupControls.Controls.Add(this.btnLex);
            this.groupControls.Location = new System.Drawing.Point(12, 118);
            this.groupControls.Name = "groupControls";
            this.groupControls.Size = new System.Drawing.Size(484, 68);
            this.groupControls.TabIndex = 4;
            this.groupControls.TabStop = false;
            this.groupControls.Text = "Options";
            // 
            // btnSem
            // 
            this.btnSem.Location = new System.Drawing.Point(258, 22);
            this.btnSem.Name = "btnSem";
            this.btnSem.Size = new System.Drawing.Size(120, 40);
            this.btnSem.TabIndex = 5;
            this.btnSem.Text = "Semantico";
            this.btnSem.UseVisualStyleBackColor = true;
            this.btnSem.Click += new System.EventHandler(this.btnSem_Click);
            // 
            // btnSin
            // 
            this.btnSin.Location = new System.Drawing.Point(132, 21);
            this.btnSin.Name = "btnSin";
            this.btnSin.Size = new System.Drawing.Size(120, 40);
            this.btnSin.TabIndex = 4;
            this.btnSin.Text = "Sintactico";
            this.btnSin.UseVisualStyleBackColor = true;
            this.btnSin.Click += new System.EventHandler(this.btnSin_Click);
            // 
            // textInputText
            // 
            this.textInputText.Location = new System.Drawing.Point(6, 18);
            this.textInputText.Multiline = true;
            this.textInputText.Name = "textInputText";
            this.textInputText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textInputText.Size = new System.Drawing.Size(607, 241);
            this.textInputText.TabIndex = 5;
            // 
            // groupInputText
            // 
            this.groupInputText.Controls.Add(this.textInputText);
            this.groupInputText.Location = new System.Drawing.Point(508, 12);
            this.groupInputText.Name = "groupInputText";
            this.groupInputText.Size = new System.Drawing.Size(619, 266);
            this.groupInputText.TabIndex = 7;
            this.groupInputText.TabStop = false;
            this.groupInputText.Text = "Input";
            // 
            // groupOutputText
            // 
            this.groupOutputText.Controls.Add(this.textOutputText);
            this.groupOutputText.Location = new System.Drawing.Point(508, 284);
            this.groupOutputText.Name = "groupOutputText";
            this.groupOutputText.Size = new System.Drawing.Size(619, 266);
            this.groupOutputText.TabIndex = 8;
            this.groupOutputText.TabStop = false;
            this.groupOutputText.Text = "Output";
            // 
            // textOutputText
            // 
            this.textOutputText.Location = new System.Drawing.Point(6, 18);
            this.textOutputText.Multiline = true;
            this.textOutputText.Name = "textOutputText";
            this.textOutputText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textOutputText.Size = new System.Drawing.Size(607, 241);
            this.textOutputText.TabIndex = 5;
            // 
            // groupTree
            // 
            this.groupTree.Controls.Add(this.textTree);
            this.groupTree.Location = new System.Drawing.Point(12, 192);
            this.groupTree.Name = "groupTree";
            this.groupTree.Size = new System.Drawing.Size(484, 117);
            this.groupTree.TabIndex = 9;
            this.groupTree.TabStop = false;
            this.groupTree.Text = "Tree";
            // 
            // textTree
            // 
            this.textTree.Location = new System.Drawing.Point(6, 21);
            this.textTree.Multiline = true;
            this.textTree.Name = "textTree";
            this.textTree.Size = new System.Drawing.Size(472, 90);
            this.textTree.TabIndex = 0;
            // 
            // groupTreeErrors
            // 
            this.groupTreeErrors.Controls.Add(this.textTreeErrors);
            this.groupTreeErrors.Location = new System.Drawing.Point(12, 315);
            this.groupTreeErrors.Name = "groupTreeErrors";
            this.groupTreeErrors.Size = new System.Drawing.Size(484, 117);
            this.groupTreeErrors.TabIndex = 10;
            this.groupTreeErrors.TabStop = false;
            this.groupTreeErrors.Text = "Tree Errors";
            // 
            // textTreeErrors
            // 
            this.textTreeErrors.Location = new System.Drawing.Point(6, 21);
            this.textTreeErrors.Multiline = true;
            this.textTreeErrors.Name = "textTreeErrors";
            this.textTreeErrors.Size = new System.Drawing.Size(472, 90);
            this.textTreeErrors.TabIndex = 0;
            // 
            // LexicalAnalyzer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 577);
            this.Controls.Add(this.groupTreeErrors);
            this.Controls.Add(this.groupTree);
            this.Controls.Add(this.groupOutputText);
            this.Controls.Add(this.groupInputText);
            this.Controls.Add(this.groupControls);
            this.Controls.Add(this.groupInputFile);
            this.Name = "LexicalAnalyzer";
            this.Text = "Lexical Analyzer";
            this.groupInputFile.ResumeLayout(false);
            this.groupInputFile.PerformLayout();
            this.groupControls.ResumeLayout(false);
            this.groupInputText.ResumeLayout(false);
            this.groupInputText.PerformLayout();
            this.groupOutputText.ResumeLayout(false);
            this.groupOutputText.PerformLayout();
            this.groupTree.ResumeLayout(false);
            this.groupTree.PerformLayout();
            this.groupTreeErrors.ResumeLayout(false);
            this.groupTreeErrors.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInputFile;
        private System.Windows.Forms.TextBox textInputFile;
        private System.Windows.Forms.GroupBox groupInputFile;
        private System.Windows.Forms.Label labelInputFile;
        private System.Windows.Forms.Button btnLex;
        private System.Windows.Forms.GroupBox groupControls;
        private System.Windows.Forms.TextBox textInputText;
        private System.Windows.Forms.GroupBox groupInputText;
        private System.Windows.Forms.GroupBox groupOutputText;
        private System.Windows.Forms.TextBox textOutputText;
        private System.Windows.Forms.Button btnSin;
        private System.Windows.Forms.GroupBox groupTree;
        private System.Windows.Forms.TextBox textTree;
        private System.Windows.Forms.GroupBox groupTreeErrors;
        private System.Windows.Forms.TextBox textTreeErrors;
        private System.Windows.Forms.Button btnSem;
    }
}


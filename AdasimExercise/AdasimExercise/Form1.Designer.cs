namespace AdasimExercise
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.BtnOpenFile = new System.Windows.Forms.Button();
            this.LblLinesCount = new System.Windows.Forms.Label();
            this.LblWordsCount = new System.Windows.Forms.Label();
            this.LblUniqueWordsCount = new System.Windows.Forms.Label();
            this.LblAvgSentenceLength = new System.Windows.Forms.Label();
            this.LblMaxSentenceLength = new System.Windows.Forms.Label();
            this.DGVColors = new System.Windows.Forms.DataGridView();
            this.LblMostPopularWord = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TbCharacters = new System.Windows.Forms.TextBox();
            this.LblMostPopularCharacter = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGVColors)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // BtnOpenFile
            // 
            this.BtnOpenFile.BackColor = System.Drawing.Color.LightSeaGreen;
            this.BtnOpenFile.FlatAppearance.BorderSize = 0;
            this.BtnOpenFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnOpenFile.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Bold);
            this.BtnOpenFile.ForeColor = System.Drawing.Color.White;
            this.BtnOpenFile.Location = new System.Drawing.Point(460, 40);
            this.BtnOpenFile.Name = "BtnOpenFile";
            this.BtnOpenFile.Size = new System.Drawing.Size(188, 70);
            this.BtnOpenFile.TabIndex = 0;
            this.BtnOpenFile.Text = "בחירת קובץ טקסט";
            this.BtnOpenFile.UseVisualStyleBackColor = false;
            this.BtnOpenFile.Click += new System.EventHandler(this.BtnOpenFile_Click);
            // 
            // LblLinesCount
            // 
            this.LblLinesCount.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.LblLinesCount.Location = new System.Drawing.Point(333, 156);
            this.LblLinesCount.Name = "LblLinesCount";
            this.LblLinesCount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LblLinesCount.Size = new System.Drawing.Size(319, 25);
            this.LblLinesCount.TabIndex = 1;
            this.LblLinesCount.Text = "כמות השורות בקובץ";
            // 
            // LblWordsCount
            // 
            this.LblWordsCount.Font = new System.Drawing.Font("Segoe UI Semilight", 12F);
            this.LblWordsCount.Location = new System.Drawing.Point(333, 210);
            this.LblWordsCount.Name = "LblWordsCount";
            this.LblWordsCount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LblWordsCount.Size = new System.Drawing.Size(319, 21);
            this.LblWordsCount.TabIndex = 2;
            this.LblWordsCount.Text = "כמות המילים בקובץ";
            // 
            // LblUniqueWordsCount
            // 
            this.LblUniqueWordsCount.Font = new System.Drawing.Font("Segoe UI Semilight", 12F);
            this.LblUniqueWordsCount.Location = new System.Drawing.Point(333, 260);
            this.LblUniqueWordsCount.Name = "LblUniqueWordsCount";
            this.LblUniqueWordsCount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LblUniqueWordsCount.Size = new System.Drawing.Size(319, 21);
            this.LblUniqueWordsCount.TabIndex = 3;
            this.LblUniqueWordsCount.Text = "כמות המילים הייחודיות בקובץ";
            // 
            // LblAvgSentenceLength
            // 
            this.LblAvgSentenceLength.Font = new System.Drawing.Font("Segoe UI Semilight", 12F);
            this.LblAvgSentenceLength.Location = new System.Drawing.Point(333, 310);
            this.LblAvgSentenceLength.Name = "LblAvgSentenceLength";
            this.LblAvgSentenceLength.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LblAvgSentenceLength.Size = new System.Drawing.Size(319, 21);
            this.LblAvgSentenceLength.TabIndex = 4;
            this.LblAvgSentenceLength.Text = "אורך משפט ממוצע";
            // 
            // LblMaxSentenceLength
            // 
            this.LblMaxSentenceLength.Font = new System.Drawing.Font("Segoe UI Semilight", 12F);
            this.LblMaxSentenceLength.Location = new System.Drawing.Point(333, 360);
            this.LblMaxSentenceLength.Name = "LblMaxSentenceLength";
            this.LblMaxSentenceLength.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LblMaxSentenceLength.Size = new System.Drawing.Size(319, 24);
            this.LblMaxSentenceLength.TabIndex = 5;
            this.LblMaxSentenceLength.Text = "אורך משפט מקסימלי";
            // 
            // DGVColors
            // 
            this.DGVColors.AllowUserToAddRows = false;
            this.DGVColors.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(65)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.DGVColors.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVColors.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVColors.BackgroundColor = System.Drawing.Color.White;
            this.DGVColors.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DGVColors.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGVColors.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(62)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVColors.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGVColors.ColumnHeadersHeight = 30;
            this.DGVColors.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(65)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVColors.DefaultCellStyle = dataGridViewCellStyle3;
            this.DGVColors.EnableHeadersVisualStyles = false;
            this.DGVColors.GridColor = System.Drawing.Color.DarkGray;
            this.DGVColors.Location = new System.Drawing.Point(35, 324);
            this.DGVColors.Name = "DGVColors";
            this.DGVColors.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DGVColors.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(65)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(65)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVColors.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DGVColors.RowHeadersVisible = false;
            this.DGVColors.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(65)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVColors.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.DGVColors.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DGVColors.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Silver;
            this.DGVColors.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.DGVColors.RowTemplate.Height = 30;
            this.DGVColors.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVColors.Size = new System.Drawing.Size(269, 114);
            this.DGVColors.TabIndex = 84;
            // 
            // LblMostPopularWord
            // 
            this.LblMostPopularWord.Font = new System.Drawing.Font("Segoe UI Semilight", 12F);
            this.LblMostPopularWord.Location = new System.Drawing.Point(333, 413);
            this.LblMostPopularWord.Name = "LblMostPopularWord";
            this.LblMostPopularWord.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LblMostPopularWord.Size = new System.Drawing.Size(319, 24);
            this.LblMostPopularWord.TabIndex = 85;
            this.LblMostPopularWord.Text = "המילה הפופולרית ביותר";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI Semilight", 12F);
            this.label1.Location = new System.Drawing.Point(219, 279);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(89, 24);
            this.label1.TabIndex = 86;
            this.label1.Text = "צבעים:";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI Semilight", 12F);
            this.label2.Location = new System.Drawing.Point(219, 53);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(89, 24);
            this.label2.TabIndex = 87;
            this.label2.Text = "דמויות:";
            // 
            // TbCharacters
            // 
            this.TbCharacters.Font = new System.Drawing.Font("Segoe UI Semilight", 12F);
            this.TbCharacters.Location = new System.Drawing.Point(35, 93);
            this.TbCharacters.Multiline = true;
            this.TbCharacters.Name = "TbCharacters";
            this.TbCharacters.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TbCharacters.Size = new System.Drawing.Size(269, 99);
            this.TbCharacters.TabIndex = 88;
            // 
            // LblMostPopularCharacter
            // 
            this.LblMostPopularCharacter.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.LblMostPopularCharacter.Location = new System.Drawing.Point(35, 210);
            this.LblMostPopularCharacter.Name = "LblMostPopularCharacter";
            this.LblMostPopularCharacter.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LblMostPopularCharacter.Size = new System.Drawing.Size(273, 25);
            this.LblMostPopularCharacter.TabIndex = 89;
            this.LblMostPopularCharacter.Text = "הדמות הנפוצה ביותר:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(683, 486);
            this.Controls.Add(this.LblMostPopularCharacter);
            this.Controls.Add(this.TbCharacters);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblMostPopularWord);
            this.Controls.Add(this.DGVColors);
            this.Controls.Add(this.LblMaxSentenceLength);
            this.Controls.Add(this.LblAvgSentenceLength);
            this.Controls.Add(this.LblUniqueWordsCount);
            this.Controls.Add(this.LblWordsCount);
            this.Controls.Add(this.LblLinesCount);
            this.Controls.Add(this.BtnOpenFile);
            this.Name = "Form1";
            this.Text = "תרגיל בית- הדסים";
            ((System.ComponentModel.ISupportInitialize)(this.DGVColors)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button BtnOpenFile;
        private System.Windows.Forms.Label LblLinesCount;
        private System.Windows.Forms.Label LblWordsCount;
        private System.Windows.Forms.Label LblUniqueWordsCount;
        private System.Windows.Forms.Label LblAvgSentenceLength;
        private System.Windows.Forms.Label LblMaxSentenceLength;
        internal System.Windows.Forms.DataGridView DGVColors;
        private System.Windows.Forms.Label LblMostPopularWord;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TbCharacters;
        private System.Windows.Forms.Label LblMostPopularCharacter;
    }
}


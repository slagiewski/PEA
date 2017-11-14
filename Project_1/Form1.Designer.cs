﻿namespace Project_1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.buttonOpenFile = new System.Windows.Forms.Button();
            this.buttonGenShow = new System.Windows.Forms.Button();
            this.textBoxNumberOfCities = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.radioSync = new System.Windows.Forms.RadioButton();
            this.radioAsync = new System.Windows.Forms.RadioButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.labelPath = new System.Windows.Forms.Label();
            this.labelWeightMax = new System.Windows.Forms.Label();
            this.labelWeightLow = new System.Windows.Forms.Label();
            this.labelWeight = new System.Windows.Forms.Label();
            this.labelTestSize = new System.Windows.Forms.Label();
            this.textBoxTestSize = new System.Windows.Forms.TextBox();
            this.textBoxWeightLow = new System.Windows.Forms.TextBox();
            this.textBoxWeightMax = new System.Windows.Forms.TextBox();
            this.textBoxTestPath = new System.Windows.Forms.TextBox();
            this.buttonStartTest = new System.Windows.Forms.Button();
            this.buttonSelectPath = new System.Windows.Forms.Button();
            this.labelNumberOfTrials = new System.Windows.Forms.Label();
            this.textBoxNumberOfTrials = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 6);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(401, 298);
            this.textBox1.TabIndex = 1;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // buttonOpenFile
            // 
            this.buttonOpenFile.Location = new System.Drawing.Point(19, 341);
            this.buttonOpenFile.Name = "buttonOpenFile";
            this.buttonOpenFile.Size = new System.Drawing.Size(75, 23);
            this.buttonOpenFile.TabIndex = 2;
            this.buttonOpenFile.Text = "Wybierz Plik";
            this.buttonOpenFile.UseVisualStyleBackColor = true;
            this.buttonOpenFile.Click += new System.EventHandler(this.buttonOpenFile_Click);
            // 
            // buttonGenShow
            // 
            this.buttonGenShow.Location = new System.Drawing.Point(195, 382);
            this.buttonGenShow.Name = "buttonGenShow";
            this.buttonGenShow.Size = new System.Drawing.Size(156, 26);
            this.buttonGenShow.TabIndex = 3;
            this.buttonGenShow.Text = "Generuj oraz wyświetl";
            this.buttonGenShow.UseVisualStyleBackColor = true;
            this.buttonGenShow.Click += new System.EventHandler(this.buttonGenShow_Click);
            // 
            // textBoxNumberOfCities
            // 
            this.textBoxNumberOfCities.Location = new System.Drawing.Point(19, 386);
            this.textBoxNumberOfCities.Name = "textBoxNumberOfCities";
            this.textBoxNumberOfCities.Size = new System.Drawing.Size(82, 20);
            this.textBoxNumberOfCities.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(28, 368);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ilość miast:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 325);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Otwórz plik:";
            // 
            // radioSync
            // 
            this.radioSync.AutoSize = true;
            this.radioSync.Checked = true;
            this.radioSync.Location = new System.Drawing.Point(135, 374);
            this.radioSync.Name = "radioSync";
            this.radioSync.Size = new System.Drawing.Size(49, 17);
            this.radioSync.TabIndex = 8;
            this.radioSync.TabStop = true;
            this.radioSync.Text = "Sync";
            this.radioSync.UseVisualStyleBackColor = true;
            // 
            // radioAsync
            // 
            this.radioAsync.AutoSize = true;
            this.radioAsync.Location = new System.Drawing.Point(135, 391);
            this.radioAsync.Name = "radioAsync";
            this.radioAsync.Size = new System.Drawing.Size(54, 17);
            this.radioAsync.TabIndex = 9;
            this.radioAsync.Text = "Async";
            this.radioAsync.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(421, 445);
            this.tabControl1.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.radioAsync);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.radioSync);
            this.tabPage1.Controls.Add(this.buttonOpenFile);
            this.tabPage1.Controls.Add(this.textBoxNumberOfCities);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.buttonGenShow);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(413, 419);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Branch And Bound";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.textBoxNumberOfTrials);
            this.tabPage2.Controls.Add(this.labelNumberOfTrials);
            this.tabPage2.Controls.Add(this.buttonSelectPath);
            this.tabPage2.Controls.Add(this.buttonStartTest);
            this.tabPage2.Controls.Add(this.textBoxTestPath);
            this.tabPage2.Controls.Add(this.textBoxWeightMax);
            this.tabPage2.Controls.Add(this.textBoxWeightLow);
            this.tabPage2.Controls.Add(this.textBoxTestSize);
            this.tabPage2.Controls.Add(this.labelPath);
            this.tabPage2.Controls.Add(this.labelWeightMax);
            this.tabPage2.Controls.Add(this.labelWeightLow);
            this.tabPage2.Controls.Add(this.labelWeight);
            this.tabPage2.Controls.Add(this.labelTestSize);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(413, 419);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Test";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // labelPath
            // 
            this.labelPath.AutoSize = true;
            this.labelPath.Location = new System.Drawing.Point(24, 183);
            this.labelPath.Name = "labelPath";
            this.labelPath.Size = new System.Drawing.Size(161, 13);
            this.labelPath.TabIndex = 4;
            this.labelPath.Text = "Podaj ścieżkę pliku wyjściowego";
            // 
            // labelWeightMax
            // 
            this.labelWeightMax.AutoSize = true;
            this.labelWeightMax.Location = new System.Drawing.Point(164, 91);
            this.labelWeightMax.Name = "labelWeightMax";
            this.labelWeightMax.Size = new System.Drawing.Size(21, 13);
            this.labelWeightMax.TabIndex = 3;
            this.labelWeightMax.Text = "Do";
            // 
            // labelWeightLow
            // 
            this.labelWeightLow.AutoSize = true;
            this.labelWeightLow.Location = new System.Drawing.Point(24, 91);
            this.labelWeightLow.Name = "labelWeightLow";
            this.labelWeightLow.Size = new System.Drawing.Size(21, 13);
            this.labelWeightLow.TabIndex = 2;
            this.labelWeightLow.Text = "Od";
            // 
            // labelWeight
            // 
            this.labelWeight.AutoSize = true;
            this.labelWeight.Location = new System.Drawing.Point(24, 67);
            this.labelWeight.Name = "labelWeight";
            this.labelWeight.Size = new System.Drawing.Size(65, 13);
            this.labelWeight.TabIndex = 1;
            this.labelWeight.Text = "Zakres wagi";
            // 
            // labelTestSize
            // 
            this.labelTestSize.AutoSize = true;
            this.labelTestSize.Location = new System.Drawing.Point(24, 21);
            this.labelTestSize.Name = "labelTestSize";
            this.labelTestSize.Size = new System.Drawing.Size(86, 13);
            this.labelTestSize.TabIndex = 0;
            this.labelTestSize.Text = "Rozmiar instancji";
            // 
            // textBoxTestSize
            // 
            this.textBoxTestSize.Location = new System.Drawing.Point(27, 37);
            this.textBoxTestSize.Name = "textBoxTestSize";
            this.textBoxTestSize.Size = new System.Drawing.Size(100, 20);
            this.textBoxTestSize.TabIndex = 5;
            // 
            // textBoxWeightLow
            // 
            this.textBoxWeightLow.Location = new System.Drawing.Point(51, 88);
            this.textBoxWeightLow.Name = "textBoxWeightLow";
            this.textBoxWeightLow.Size = new System.Drawing.Size(100, 20);
            this.textBoxWeightLow.TabIndex = 6;
            // 
            // textBoxWeightMax
            // 
            this.textBoxWeightMax.Location = new System.Drawing.Point(191, 88);
            this.textBoxWeightMax.Name = "textBoxWeightMax";
            this.textBoxWeightMax.Size = new System.Drawing.Size(100, 20);
            this.textBoxWeightMax.TabIndex = 7;
            // 
            // textBoxTestPath
            // 
            this.textBoxTestPath.Location = new System.Drawing.Point(27, 200);
            this.textBoxTestPath.Name = "textBoxTestPath";
            this.textBoxTestPath.Size = new System.Drawing.Size(264, 20);
            this.textBoxTestPath.TabIndex = 8;
            // 
            // buttonStartTest
            // 
            this.buttonStartTest.Location = new System.Drawing.Point(27, 232);
            this.buttonStartTest.Name = "buttonStartTest";
            this.buttonStartTest.Size = new System.Drawing.Size(100, 23);
            this.buttonStartTest.TabIndex = 9;
            this.buttonStartTest.Text = "Rozpocznij test";
            this.buttonStartTest.UseVisualStyleBackColor = true;
            // 
            // buttonSelectPath
            // 
            this.buttonSelectPath.Location = new System.Drawing.Point(313, 197);
            this.buttonSelectPath.Name = "buttonSelectPath";
            this.buttonSelectPath.Size = new System.Drawing.Size(75, 23);
            this.buttonSelectPath.TabIndex = 10;
            this.buttonSelectPath.Text = "Wybierz";
            this.buttonSelectPath.UseVisualStyleBackColor = true;
            // 
            // labelNumberOfTrials
            // 
            this.labelNumberOfTrials.AutoSize = true;
            this.labelNumberOfTrials.Location = new System.Drawing.Point(24, 122);
            this.labelNumberOfTrials.Name = "labelNumberOfTrials";
            this.labelNumberOfTrials.Size = new System.Drawing.Size(62, 13);
            this.labelNumberOfTrials.TabIndex = 11;
            this.labelNumberOfTrials.Text = "Liczba prób";
            // 
            // textBoxNumberOfTrials
            // 
            this.textBoxNumberOfTrials.Location = new System.Drawing.Point(27, 138);
            this.textBoxNumberOfTrials.Name = "textBoxNumberOfTrials";
            this.textBoxNumberOfTrials.Size = new System.Drawing.Size(100, 20);
            this.textBoxNumberOfTrials.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 470);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button buttonOpenFile;
        private System.Windows.Forms.Button buttonGenShow;
        private System.Windows.Forms.TextBox textBoxNumberOfCities;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioSync;
        private System.Windows.Forms.RadioButton radioAsync;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label labelWeight;
        private System.Windows.Forms.Label labelTestSize;
        private System.Windows.Forms.Label labelPath;
        private System.Windows.Forms.Label labelWeightMax;
        private System.Windows.Forms.Label labelWeightLow;
        private System.Windows.Forms.Button buttonSelectPath;
        private System.Windows.Forms.Button buttonStartTest;
        private System.Windows.Forms.TextBox textBoxTestPath;
        private System.Windows.Forms.TextBox textBoxWeightMax;
        private System.Windows.Forms.TextBox textBoxWeightLow;
        private System.Windows.Forms.TextBox textBoxTestSize;
        private System.Windows.Forms.TextBox textBoxNumberOfTrials;
        private System.Windows.Forms.Label labelNumberOfTrials;
    }
}


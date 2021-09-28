namespace SortTests
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.testButton = new System.Windows.Forms.Button();
            this.testListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.arraySizeTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.bubbleCompTxt = new System.Windows.Forms.Label();
            this.bubbleSwapsTxt = new System.Windows.Forms.Label();
            this.bubbleTimeElapsed = new System.Windows.Forms.Label();
            this.showBubbleArray = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.insertionTimeElapsedTxt = new System.Windows.Forms.Label();
            this.insertionSwapsTxt = new System.Windows.Forms.Label();
            this.insertionCompTxt = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.quickSortTimeElapsedTxt = new System.Windows.Forms.Label();
            this.quickSortSwapTxt = new System.Windows.Forms.Label();
            this.quickSortCompTxt = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.bubbleState = new System.Windows.Forms.Label();
            this.insertionState = new System.Windows.Forms.Label();
            this.quickSortState = new System.Windows.Forms.Label();
            this.progressBarBubble = new System.Windows.Forms.ProgressBar();
            this.progressBarInsertion = new System.Windows.Forms.ProgressBar();
            this.progressBarQuick = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // testButton
            // 
            this.testButton.Location = new System.Drawing.Point(12, 142);
            this.testButton.Name = "testButton";
            this.testButton.Size = new System.Drawing.Size(166, 27);
            this.testButton.TabIndex = 0;
            this.testButton.Text = "Start Sorting";
            this.testButton.UseVisualStyleBackColor = true;
            this.testButton.Click += new System.EventHandler(this.testButton_Click);
            // 
            // testListBox
            // 
            this.testListBox.FormattingEnabled = true;
            this.testListBox.Location = new System.Drawing.Point(194, 61);
            this.testListBox.Name = "testListBox";
            this.testListBox.Size = new System.Drawing.Size(187, 277);
            this.testListBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(190, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "BubbleSort";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Size of unsorted array";
            // 
            // arraySizeTextBox
            // 
            this.arraySizeTextBox.Location = new System.Drawing.Point(15, 116);
            this.arraySizeTextBox.Name = "arraySizeTextBox";
            this.arraySizeTextBox.Size = new System.Drawing.Size(100, 20);
            this.arraySizeTextBox.TabIndex = 4;
            this.arraySizeTextBox.Text = "10000";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(399, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "InsertionSort";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(403, 61);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(187, 277);
            this.listBox1.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(608, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "QuickSort";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(612, 61);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(187, 277);
            this.listBox2.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(199, 379);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Bubble:";
            // 
            // bubbleCompTxt
            // 
            this.bubbleCompTxt.AutoSize = true;
            this.bubbleCompTxt.Location = new System.Drawing.Point(199, 392);
            this.bubbleCompTxt.Name = "bubbleCompTxt";
            this.bubbleCompTxt.Size = new System.Drawing.Size(43, 13);
            this.bubbleCompTxt.TabIndex = 10;
            this.bubbleCompTxt.Text = "Bubble:";
            // 
            // bubbleSwapsTxt
            // 
            this.bubbleSwapsTxt.AutoSize = true;
            this.bubbleSwapsTxt.Location = new System.Drawing.Point(199, 405);
            this.bubbleSwapsTxt.Name = "bubbleSwapsTxt";
            this.bubbleSwapsTxt.Size = new System.Drawing.Size(43, 13);
            this.bubbleSwapsTxt.TabIndex = 11;
            this.bubbleSwapsTxt.Text = "Bubble:";
            // 
            // bubbleTimeElapsed
            // 
            this.bubbleTimeElapsed.AutoSize = true;
            this.bubbleTimeElapsed.Location = new System.Drawing.Point(199, 418);
            this.bubbleTimeElapsed.Name = "bubbleTimeElapsed";
            this.bubbleTimeElapsed.Size = new System.Drawing.Size(43, 13);
            this.bubbleTimeElapsed.TabIndex = 12;
            this.bubbleTimeElapsed.Text = "Bubble:";
            // 
            // showBubbleArray
            // 
            this.showBubbleArray.Location = new System.Drawing.Point(202, 438);
            this.showBubbleArray.Name = "showBubbleArray";
            this.showBubbleArray.Size = new System.Drawing.Size(166, 27);
            this.showBubbleArray.TabIndex = 13;
            this.showBubbleArray.Text = "Show Array";
            this.showBubbleArray.UseVisualStyleBackColor = true;
            this.showBubbleArray.Click += new System.EventHandler(this.showBubbleArray_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(414, 438);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 27);
            this.button1.TabIndex = 14;
            this.button1.Text = "Show Array";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(623, 438);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(166, 27);
            this.button2.TabIndex = 15;
            this.button2.Text = "Show Array";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // insertionTimeElapsedTxt
            // 
            this.insertionTimeElapsedTxt.AutoSize = true;
            this.insertionTimeElapsedTxt.Location = new System.Drawing.Point(412, 418);
            this.insertionTimeElapsedTxt.Name = "insertionTimeElapsedTxt";
            this.insertionTimeElapsedTxt.Size = new System.Drawing.Size(47, 13);
            this.insertionTimeElapsedTxt.TabIndex = 19;
            this.insertionTimeElapsedTxt.Text = "Insertion";
            // 
            // insertionSwapsTxt
            // 
            this.insertionSwapsTxt.AutoSize = true;
            this.insertionSwapsTxt.Location = new System.Drawing.Point(411, 405);
            this.insertionSwapsTxt.Name = "insertionSwapsTxt";
            this.insertionSwapsTxt.Size = new System.Drawing.Size(47, 13);
            this.insertionSwapsTxt.TabIndex = 18;
            this.insertionSwapsTxt.Text = "Insertion";
            // 
            // insertionCompTxt
            // 
            this.insertionCompTxt.AutoSize = true;
            this.insertionCompTxt.Location = new System.Drawing.Point(411, 392);
            this.insertionCompTxt.Name = "insertionCompTxt";
            this.insertionCompTxt.Size = new System.Drawing.Size(47, 13);
            this.insertionCompTxt.TabIndex = 17;
            this.insertionCompTxt.Text = "Insertion";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(411, 379);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Insertion";
            // 
            // quickSortTimeElapsedTxt
            // 
            this.quickSortTimeElapsedTxt.AutoSize = true;
            this.quickSortTimeElapsedTxt.Location = new System.Drawing.Point(620, 418);
            this.quickSortTimeElapsedTxt.Name = "quickSortTimeElapsedTxt";
            this.quickSortTimeElapsedTxt.Size = new System.Drawing.Size(54, 13);
            this.quickSortTimeElapsedTxt.TabIndex = 23;
            this.quickSortTimeElapsedTxt.Text = "QuickSort";
            // 
            // quickSortSwapTxt
            // 
            this.quickSortSwapTxt.AutoSize = true;
            this.quickSortSwapTxt.Location = new System.Drawing.Point(620, 405);
            this.quickSortSwapTxt.Name = "quickSortSwapTxt";
            this.quickSortSwapTxt.Size = new System.Drawing.Size(54, 13);
            this.quickSortSwapTxt.TabIndex = 22;
            this.quickSortSwapTxt.Text = "QuickSort";
            // 
            // quickSortCompTxt
            // 
            this.quickSortCompTxt.AutoSize = true;
            this.quickSortCompTxt.Location = new System.Drawing.Point(620, 392);
            this.quickSortCompTxt.Name = "quickSortCompTxt";
            this.quickSortCompTxt.Size = new System.Drawing.Size(54, 13);
            this.quickSortCompTxt.TabIndex = 21;
            this.quickSortCompTxt.Text = "QuickSort";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(620, 379);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "QuickSort";
            // 
            // bubbleState
            // 
            this.bubbleState.AutoSize = true;
            this.bubbleState.Location = new System.Drawing.Point(208, 24);
            this.bubbleState.Name = "bubbleState";
            this.bubbleState.Size = new System.Drawing.Size(32, 13);
            this.bubbleState.TabIndex = 24;
            this.bubbleState.Text = "State";
            // 
            // insertionState
            // 
            this.insertionState.AutoSize = true;
            this.insertionState.Location = new System.Drawing.Point(427, 24);
            this.insertionState.Name = "insertionState";
            this.insertionState.Size = new System.Drawing.Size(32, 13);
            this.insertionState.TabIndex = 25;
            this.insertionState.Text = "State";
            // 
            // quickSortState
            // 
            this.quickSortState.AutoSize = true;
            this.quickSortState.Location = new System.Drawing.Point(643, 24);
            this.quickSortState.Name = "quickSortState";
            this.quickSortState.Size = new System.Drawing.Size(32, 13);
            this.quickSortState.TabIndex = 26;
            this.quickSortState.Text = "State";
            // 
            // progressBarBubble
            // 
            this.progressBarBubble.Location = new System.Drawing.Point(194, 344);
            this.progressBarBubble.Name = "progressBarBubble";
            this.progressBarBubble.Size = new System.Drawing.Size(187, 23);
            this.progressBarBubble.TabIndex = 27;
            // 
            // progressBarInsertion
            // 
            this.progressBarInsertion.Location = new System.Drawing.Point(405, 344);
            this.progressBarInsertion.Name = "progressBarInsertion";
            this.progressBarInsertion.Size = new System.Drawing.Size(185, 23);
            this.progressBarInsertion.TabIndex = 28;
            // 
            // progressBarQuick
            // 
            this.progressBarQuick.Location = new System.Drawing.Point(614, 344);
            this.progressBarQuick.Name = "progressBarQuick";
            this.progressBarQuick.Size = new System.Drawing.Size(185, 23);
            this.progressBarQuick.TabIndex = 29;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 477);
            this.Controls.Add(this.progressBarQuick);
            this.Controls.Add(this.progressBarInsertion);
            this.Controls.Add(this.progressBarBubble);
            this.Controls.Add(this.quickSortState);
            this.Controls.Add(this.insertionState);
            this.Controls.Add(this.bubbleState);
            this.Controls.Add(this.quickSortTimeElapsedTxt);
            this.Controls.Add(this.quickSortSwapTxt);
            this.Controls.Add(this.quickSortCompTxt);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.insertionTimeElapsedTxt);
            this.Controls.Add(this.insertionSwapsTxt);
            this.Controls.Add(this.insertionCompTxt);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.showBubbleArray);
            this.Controls.Add(this.bubbleTimeElapsed);
            this.Controls.Add(this.bubbleSwapsTxt);
            this.Controls.Add(this.bubbleCompTxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.arraySizeTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.testListBox);
            this.Controls.Add(this.testButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button testButton;
        private System.Windows.Forms.ListBox testListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox arraySizeTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label bubbleCompTxt;
        private System.Windows.Forms.Label bubbleSwapsTxt;
        private System.Windows.Forms.Label bubbleTimeElapsed;
        private System.Windows.Forms.Button showBubbleArray;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label insertionTimeElapsedTxt;
        private System.Windows.Forms.Label insertionSwapsTxt;
        private System.Windows.Forms.Label insertionCompTxt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label quickSortTimeElapsedTxt;
        private System.Windows.Forms.Label quickSortSwapTxt;
        private System.Windows.Forms.Label quickSortCompTxt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label bubbleState;
        private System.Windows.Forms.Label insertionState;
        private System.Windows.Forms.Label quickSortState;
        private System.Windows.Forms.ProgressBar progressBarBubble;
        private System.Windows.Forms.ProgressBar progressBarInsertion;
        private System.Windows.Forms.ProgressBar progressBarQuick;
    }
}


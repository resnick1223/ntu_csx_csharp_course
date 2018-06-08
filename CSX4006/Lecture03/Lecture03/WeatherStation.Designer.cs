namespace Lecture03
{
    partial class WeatherStation
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGenerator = new System.Windows.Forms.Timer(this.components);
            this.startButton = new System.Windows.Forms.Button();
            this.temperatureLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dataGenerator
            // 
            this.dataGenerator.Interval = 300;
            this.dataGenerator.Tick += new System.EventHandler(this.dataGenerator_Tick);
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(24, 25);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(181, 83);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "接收資料";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // temperatureLabel
            // 
            this.temperatureLabel.AutoSize = true;
            this.temperatureLabel.Location = new System.Drawing.Point(33, 150);
            this.temperatureLabel.Name = "temperatureLabel";
            this.temperatureLabel.Size = new System.Drawing.Size(41, 15);
            this.temperatureLabel.TabIndex = 1;
            this.temperatureLabel.Text = "label1";
            // 
            // WeatherStation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.temperatureLabel);
            this.Controls.Add(this.startButton);
            this.Name = "WeatherStation";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer dataGenerator;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label temperatureLabel;
    }
}


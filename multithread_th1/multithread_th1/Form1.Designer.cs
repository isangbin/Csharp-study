namespace multithread_th1
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnThread = new System.Windows.Forms.Button();
            this.btnTask = new System.Windows.Forms.Button();
            this.btnAsync = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBlock = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnThread
            // 
            this.btnThread.Location = new System.Drawing.Point(0, 0);
            this.btnThread.Name = "btnThread";
            this.btnThread.Size = new System.Drawing.Size(108, 67);
            this.btnThread.TabIndex = 0;
            this.btnThread.Text = "스레드방식";
            this.btnThread.UseVisualStyleBackColor = true;
            this.btnThread.Click += new System.EventHandler(this.btnThread_Click);
            // 
            // btnTask
            // 
            this.btnTask.Location = new System.Drawing.Point(114, 0);
            this.btnTask.Name = "btnTask";
            this.btnTask.Size = new System.Drawing.Size(108, 67);
            this.btnTask.TabIndex = 1;
            this.btnTask.Text = "태스크방식";
            this.btnTask.UseVisualStyleBackColor = true;
            this.btnTask.Click += new System.EventHandler(this.btnTask_Click);
            // 
            // btnAsync
            // 
            this.btnAsync.Location = new System.Drawing.Point(228, 0);
            this.btnAsync.Name = "btnAsync";
            this.btnAsync.Size = new System.Drawing.Size(108, 67);
            this.btnAsync.TabIndex = 2;
            this.btnAsync.Text = "async/await";
            this.btnAsync.UseVisualStyleBackColor = true;
            this.btnAsync.Click += new System.EventHandler(this.btnAsync_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(304, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // btnBlock
            // 
            this.btnBlock.Location = new System.Drawing.Point(409, 6);
            this.btnBlock.Name = "btnBlock";
            this.btnBlock.Size = new System.Drawing.Size(90, 61);
            this.btnBlock.TabIndex = 4;
            this.btnBlock.Text = "UI멈춤";
            this.btnBlock.UseVisualStyleBackColor = true;
            this.btnBlock.Click += new System.EventHandler(this.btnBlock_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBlock);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAsync);
            this.Controls.Add(this.btnTask);
            this.Controls.Add(this.btnThread);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThread;
        private System.Windows.Forms.Button btnTask;
        private System.Windows.Forms.Button btnAsync;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBlock;
    }
}


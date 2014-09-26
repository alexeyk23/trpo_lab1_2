namespace trpo_lab_1_2
{
    partial class frmMain
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.txbxExpression = new System.Windows.Forms.TextBox();
            this.btnGoAutomat = new System.Windows.Forms.Button();
            this.txbxAnswer = new System.Windows.Forms.TextBox();
            this.lblExpr = new System.Windows.Forms.Label();
            this.btnClearExpr = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txbxExpression
            // 
            this.txbxExpression.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txbxExpression.Location = new System.Drawing.Point(12, 34);
            this.txbxExpression.Name = "txbxExpression";
            this.txbxExpression.Size = new System.Drawing.Size(347, 29);
            this.txbxExpression.TabIndex = 0;
            // 
            // btnGoAutomat
            // 
            this.btnGoAutomat.Location = new System.Drawing.Point(89, 69);
            this.btnGoAutomat.Name = "btnGoAutomat";
            this.btnGoAutomat.Size = new System.Drawing.Size(132, 29);
            this.btnGoAutomat.TabIndex = 1;
            this.btnGoAutomat.Text = "Запустить анализатор";
            this.btnGoAutomat.UseVisualStyleBackColor = true;
            this.btnGoAutomat.Click += new System.EventHandler(this.btnGoAutomat_Click);
            // 
            // txbxAnswer
            // 
            this.txbxAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txbxAnswer.Location = new System.Drawing.Point(12, 104);
            this.txbxAnswer.Multiline = true;
            this.txbxAnswer.Name = "txbxAnswer";
            this.txbxAnswer.ReadOnly = true;
            this.txbxAnswer.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txbxAnswer.Size = new System.Drawing.Size(347, 232);
            this.txbxAnswer.TabIndex = 2;
            // 
            // lblExpr
            // 
            this.lblExpr.AutoSize = true;
            this.lblExpr.Location = new System.Drawing.Point(13, 15);
            this.lblExpr.Name = "lblExpr";
            this.lblExpr.Size = new System.Drawing.Size(110, 13);
            this.lblExpr.TabIndex = 3;
            this.lblExpr.Text = "Введите выражение";
            // 
            // btnClearExpr
            // 
            this.btnClearExpr.Location = new System.Drawing.Point(227, 69);
            this.btnClearExpr.Name = "btnClearExpr";
            this.btnClearExpr.Size = new System.Drawing.Size(132, 29);
            this.btnClearExpr.TabIndex = 4;
            this.btnClearExpr.Text = "Очистить выражение";
            this.btnClearExpr.UseVisualStyleBackColor = true;
            this.btnClearExpr.Click += new System.EventHandler(this.btnClearExpr_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 352);
            this.Controls.Add(this.btnClearExpr);
            this.Controls.Add(this.lblExpr);
            this.Controls.Add(this.txbxAnswer);
            this.Controls.Add(this.btnGoAutomat);
            this.Controls.Add(this.txbxExpression);
            this.Name = "frmMain";
            this.Text = "Чудо-автомат";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbxExpression;
        private System.Windows.Forms.Button btnGoAutomat;
        private System.Windows.Forms.TextBox txbxAnswer;
        private System.Windows.Forms.Label lblExpr;
        private System.Windows.Forms.Button btnClearExpr;
    }
}


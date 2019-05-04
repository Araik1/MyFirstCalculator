namespace MyFirstCalculator
{
    partial class calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(calculator));
            this.button_1 = new System.Windows.Forms.Button();
            this.button_2 = new System.Windows.Forms.Button();
            this.button_3 = new System.Windows.Forms.Button();
            this.buttonPoint = new System.Windows.Forms.Button();
            this.buttonEqually = new System.Windows.Forms.Button();
            this.button_4 = new System.Windows.Forms.Button();
            this.button_5 = new System.Windows.Forms.Button();
            this.button_6 = new System.Windows.Forms.Button();
            this.buttonPlus = new System.Windows.Forms.Button();
            this.buttonMinus = new System.Windows.Forms.Button();
            this.button_9 = new System.Windows.Forms.Button();
            this.button_8 = new System.Windows.Forms.Button();
            this.button_7 = new System.Windows.Forms.Button();
            this.buttonMult = new System.Windows.Forms.Button();
            this.buttonDiv = new System.Windows.Forms.Button();
            this.buttonPlusMinus = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.labelResult = new System.Windows.Forms.Label();
            this.panel19 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonTrig = new System.Windows.Forms.Button();
            this.button_0 = new System.Windows.Forms.Button();
            this.labelFirst = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.checkBox_deg = new System.Windows.Forms.CheckBox();
            this.button8 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_1
            // 
            this.button_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button_1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_1.FlatAppearance.BorderSize = 0;
            this.button_1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.button_1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_1.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_1.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.button_1.Location = new System.Drawing.Point(2, 433);
            this.button_1.Margin = new System.Windows.Forms.Padding(1);
            this.button_1.Name = "button_1";
            this.button_1.Size = new System.Drawing.Size(60, 60);
            this.button_1.TabIndex = 0;
            this.button_1.TabStop = false;
            this.button_1.Text = "1";
            this.button_1.UseVisualStyleBackColor = false;
            this.button_1.Click += new System.EventHandler(this.digit_pressed);
            this.button_1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.calculator_KeyDown);
            // 
            // button_2
            // 
            this.button_2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button_2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_2.FlatAppearance.BorderSize = 0;
            this.button_2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.button_2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_2.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_2.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.button_2.Location = new System.Drawing.Point(64, 433);
            this.button_2.Margin = new System.Windows.Forms.Padding(1);
            this.button_2.Name = "button_2";
            this.button_2.Size = new System.Drawing.Size(60, 60);
            this.button_2.TabIndex = 1;
            this.button_2.TabStop = false;
            this.button_2.Text = "2";
            this.button_2.UseVisualStyleBackColor = false;
            this.button_2.Click += new System.EventHandler(this.digit_pressed);
            this.button_2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.calculator_KeyDown);
            // 
            // button_3
            // 
            this.button_3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button_3.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_3.FlatAppearance.BorderSize = 0;
            this.button_3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.button_3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button_3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_3.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_3.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.button_3.Location = new System.Drawing.Point(126, 433);
            this.button_3.Margin = new System.Windows.Forms.Padding(1);
            this.button_3.Name = "button_3";
            this.button_3.Size = new System.Drawing.Size(60, 60);
            this.button_3.TabIndex = 2;
            this.button_3.TabStop = false;
            this.button_3.Text = "3";
            this.button_3.UseVisualStyleBackColor = false;
            this.button_3.Click += new System.EventHandler(this.digit_pressed);
            this.button_3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.calculator_KeyDown);
            // 
            // buttonPoint
            // 
            this.buttonPoint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.buttonPoint.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonPoint.FlatAppearance.BorderSize = 0;
            this.buttonPoint.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.buttonPoint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.buttonPoint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPoint.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPoint.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.buttonPoint.Location = new System.Drawing.Point(126, 495);
            this.buttonPoint.Margin = new System.Windows.Forms.Padding(1);
            this.buttonPoint.Name = "buttonPoint";
            this.buttonPoint.Size = new System.Drawing.Size(60, 60);
            this.buttonPoint.TabIndex = 5;
            this.buttonPoint.TabStop = false;
            this.buttonPoint.Text = ",";
            this.buttonPoint.UseVisualStyleBackColor = false;
            this.buttonPoint.Click += new System.EventHandler(this.unary_operation);
            this.buttonPoint.KeyDown += new System.Windows.Forms.KeyEventHandler(this.calculator_KeyDown);
            // 
            // buttonEqually
            // 
            this.buttonEqually.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(50)))));
            this.buttonEqually.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonEqually.FlatAppearance.BorderSize = 0;
            this.buttonEqually.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(217)))), ((int)(((byte)(80)))));
            this.buttonEqually.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(50)))));
            this.buttonEqually.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEqually.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEqually.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.buttonEqually.Location = new System.Drawing.Point(188, 433);
            this.buttonEqually.Margin = new System.Windows.Forms.Padding(1);
            this.buttonEqually.Name = "buttonEqually";
            this.buttonEqually.Size = new System.Drawing.Size(60, 122);
            this.buttonEqually.TabIndex = 6;
            this.buttonEqually.TabStop = false;
            this.buttonEqually.Text = "=";
            this.buttonEqually.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonEqually.UseCompatibleTextRendering = true;
            this.buttonEqually.UseVisualStyleBackColor = false;
            this.buttonEqually.Click += new System.EventHandler(this.buttonEqually_Click);
            this.buttonEqually.KeyDown += new System.Windows.Forms.KeyEventHandler(this.calculator_KeyDown);
            // 
            // button_4
            // 
            this.button_4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button_4.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_4.FlatAppearance.BorderSize = 0;
            this.button_4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.button_4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button_4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_4.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_4.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.button_4.Location = new System.Drawing.Point(2, 371);
            this.button_4.Margin = new System.Windows.Forms.Padding(1);
            this.button_4.Name = "button_4";
            this.button_4.Size = new System.Drawing.Size(60, 60);
            this.button_4.TabIndex = 7;
            this.button_4.TabStop = false;
            this.button_4.Text = "4";
            this.button_4.UseVisualStyleBackColor = false;
            this.button_4.Click += new System.EventHandler(this.digit_pressed);
            this.button_4.KeyDown += new System.Windows.Forms.KeyEventHandler(this.calculator_KeyDown);
            // 
            // button_5
            // 
            this.button_5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button_5.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_5.FlatAppearance.BorderSize = 0;
            this.button_5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.button_5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button_5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_5.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_5.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.button_5.Location = new System.Drawing.Point(64, 371);
            this.button_5.Margin = new System.Windows.Forms.Padding(1);
            this.button_5.Name = "button_5";
            this.button_5.Size = new System.Drawing.Size(60, 60);
            this.button_5.TabIndex = 8;
            this.button_5.TabStop = false;
            this.button_5.Text = "5";
            this.button_5.UseVisualStyleBackColor = false;
            this.button_5.Click += new System.EventHandler(this.digit_pressed);
            this.button_5.KeyDown += new System.Windows.Forms.KeyEventHandler(this.calculator_KeyDown);
            // 
            // button_6
            // 
            this.button_6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button_6.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_6.FlatAppearance.BorderSize = 0;
            this.button_6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.button_6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button_6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_6.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_6.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.button_6.Location = new System.Drawing.Point(126, 371);
            this.button_6.Margin = new System.Windows.Forms.Padding(1);
            this.button_6.Name = "button_6";
            this.button_6.Size = new System.Drawing.Size(60, 60);
            this.button_6.TabIndex = 9;
            this.button_6.TabStop = false;
            this.button_6.Text = "6";
            this.button_6.UseVisualStyleBackColor = false;
            this.button_6.Click += new System.EventHandler(this.digit_pressed);
            this.button_6.KeyDown += new System.Windows.Forms.KeyEventHandler(this.calculator_KeyDown);
            // 
            // buttonPlus
            // 
            this.buttonPlus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.buttonPlus.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonPlus.FlatAppearance.BorderSize = 0;
            this.buttonPlus.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.buttonPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPlus.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPlus.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.buttonPlus.Location = new System.Drawing.Point(188, 371);
            this.buttonPlus.Margin = new System.Windows.Forms.Padding(1);
            this.buttonPlus.Name = "buttonPlus";
            this.buttonPlus.Size = new System.Drawing.Size(60, 60);
            this.buttonPlus.TabIndex = 10;
            this.buttonPlus.TabStop = false;
            this.buttonPlus.Text = "+";
            this.buttonPlus.UseVisualStyleBackColor = false;
            this.buttonPlus.Click += new System.EventHandler(this.binary_operation);
            this.buttonPlus.KeyDown += new System.Windows.Forms.KeyEventHandler(this.calculator_KeyDown);
            // 
            // buttonMinus
            // 
            this.buttonMinus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.buttonMinus.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonMinus.FlatAppearance.BorderSize = 0;
            this.buttonMinus.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.buttonMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMinus.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMinus.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.buttonMinus.Location = new System.Drawing.Point(188, 309);
            this.buttonMinus.Margin = new System.Windows.Forms.Padding(1);
            this.buttonMinus.Name = "buttonMinus";
            this.buttonMinus.Size = new System.Drawing.Size(60, 60);
            this.buttonMinus.TabIndex = 14;
            this.buttonMinus.TabStop = false;
            this.buttonMinus.Text = "-";
            this.buttonMinus.UseVisualStyleBackColor = false;
            this.buttonMinus.Click += new System.EventHandler(this.binary_operation);
            this.buttonMinus.KeyDown += new System.Windows.Forms.KeyEventHandler(this.calculator_KeyDown);
            // 
            // button_9
            // 
            this.button_9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button_9.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_9.FlatAppearance.BorderSize = 0;
            this.button_9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.button_9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button_9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_9.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_9.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.button_9.Location = new System.Drawing.Point(126, 309);
            this.button_9.Margin = new System.Windows.Forms.Padding(1);
            this.button_9.Name = "button_9";
            this.button_9.Size = new System.Drawing.Size(60, 60);
            this.button_9.TabIndex = 13;
            this.button_9.TabStop = false;
            this.button_9.Text = "9";
            this.button_9.UseVisualStyleBackColor = false;
            this.button_9.Click += new System.EventHandler(this.digit_pressed);
            this.button_9.KeyDown += new System.Windows.Forms.KeyEventHandler(this.calculator_KeyDown);
            // 
            // button_8
            // 
            this.button_8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button_8.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_8.FlatAppearance.BorderSize = 0;
            this.button_8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.button_8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button_8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_8.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_8.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.button_8.Location = new System.Drawing.Point(64, 309);
            this.button_8.Margin = new System.Windows.Forms.Padding(1);
            this.button_8.Name = "button_8";
            this.button_8.Size = new System.Drawing.Size(60, 60);
            this.button_8.TabIndex = 12;
            this.button_8.TabStop = false;
            this.button_8.Text = "8";
            this.button_8.UseVisualStyleBackColor = false;
            this.button_8.Click += new System.EventHandler(this.digit_pressed);
            this.button_8.KeyDown += new System.Windows.Forms.KeyEventHandler(this.calculator_KeyDown);
            // 
            // button_7
            // 
            this.button_7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button_7.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_7.FlatAppearance.BorderSize = 0;
            this.button_7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.button_7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button_7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_7.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_7.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.button_7.Location = new System.Drawing.Point(2, 309);
            this.button_7.Margin = new System.Windows.Forms.Padding(1);
            this.button_7.Name = "button_7";
            this.button_7.Size = new System.Drawing.Size(60, 60);
            this.button_7.TabIndex = 11;
            this.button_7.TabStop = false;
            this.button_7.Text = "7";
            this.button_7.UseVisualStyleBackColor = false;
            this.button_7.Click += new System.EventHandler(this.digit_pressed);
            this.button_7.KeyDown += new System.Windows.Forms.KeyEventHandler(this.calculator_KeyDown);
            // 
            // buttonMult
            // 
            this.buttonMult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.buttonMult.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonMult.FlatAppearance.BorderSize = 0;
            this.buttonMult.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.buttonMult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMult.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMult.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.buttonMult.Location = new System.Drawing.Point(188, 247);
            this.buttonMult.Margin = new System.Windows.Forms.Padding(1);
            this.buttonMult.Name = "buttonMult";
            this.buttonMult.Size = new System.Drawing.Size(60, 60);
            this.buttonMult.TabIndex = 18;
            this.buttonMult.TabStop = false;
            this.buttonMult.Text = "*";
            this.buttonMult.UseVisualStyleBackColor = false;
            this.buttonMult.Click += new System.EventHandler(this.binary_operation);
            this.buttonMult.KeyDown += new System.Windows.Forms.KeyEventHandler(this.calculator_KeyDown);
            // 
            // buttonDiv
            // 
            this.buttonDiv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.buttonDiv.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonDiv.FlatAppearance.BorderSize = 0;
            this.buttonDiv.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.buttonDiv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDiv.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDiv.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.buttonDiv.Location = new System.Drawing.Point(126, 247);
            this.buttonDiv.Margin = new System.Windows.Forms.Padding(1);
            this.buttonDiv.Name = "buttonDiv";
            this.buttonDiv.Size = new System.Drawing.Size(60, 60);
            this.buttonDiv.TabIndex = 17;
            this.buttonDiv.TabStop = false;
            this.buttonDiv.Text = "/";
            this.buttonDiv.UseVisualStyleBackColor = false;
            this.buttonDiv.Click += new System.EventHandler(this.binary_operation);
            this.buttonDiv.KeyDown += new System.Windows.Forms.KeyEventHandler(this.calculator_KeyDown);
            // 
            // buttonPlusMinus
            // 
            this.buttonPlusMinus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.buttonPlusMinus.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonPlusMinus.FlatAppearance.BorderSize = 0;
            this.buttonPlusMinus.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.buttonPlusMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPlusMinus.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPlusMinus.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.buttonPlusMinus.Location = new System.Drawing.Point(64, 247);
            this.buttonPlusMinus.Margin = new System.Windows.Forms.Padding(1);
            this.buttonPlusMinus.Name = "buttonPlusMinus";
            this.buttonPlusMinus.Size = new System.Drawing.Size(60, 60);
            this.buttonPlusMinus.TabIndex = 16;
            this.buttonPlusMinus.TabStop = false;
            this.buttonPlusMinus.Text = "±";
            this.buttonPlusMinus.UseVisualStyleBackColor = false;
            this.buttonPlusMinus.Click += new System.EventHandler(this.unary_operation);
            this.buttonPlusMinus.KeyDown += new System.Windows.Forms.KeyEventHandler(this.calculator_KeyDown);
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.buttonClear.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonClear.FlatAppearance.BorderSize = 0;
            this.buttonClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.buttonClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClear.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClear.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.buttonClear.Location = new System.Drawing.Point(2, 247);
            this.buttonClear.Margin = new System.Windows.Forms.Padding(1);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(60, 60);
            this.buttonClear.TabIndex = 15;
            this.buttonClear.TabStop = false;
            this.buttonClear.Text = "AC";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            this.buttonClear.KeyDown += new System.Windows.Forms.KeyEventHandler(this.calculator_KeyDown);
            // 
            // labelResult
            // 
            this.labelResult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelResult.Font = new System.Drawing.Font("Roboto", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelResult.ForeColor = System.Drawing.Color.White;
            this.labelResult.Location = new System.Drawing.Point(1, 93);
            this.labelResult.Margin = new System.Windows.Forms.Padding(0);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(246, 43);
            this.labelResult.TabIndex = 19;
            this.labelResult.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // panel19
            // 
            this.panel19.BackColor = System.Drawing.Color.White;
            this.panel19.Location = new System.Drawing.Point(1, 139);
            this.panel19.Name = "panel19";
            this.panel19.Size = new System.Drawing.Size(247, 2);
            this.panel19.TabIndex = 94;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.buttonExit);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 30);
            this.panel1.TabIndex = 93;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 21);
            this.label2.TabIndex = 8;
            this.label2.Text = "Калькулятор";
            this.label2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.label2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.label2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // buttonExit
            // 
            this.buttonExit.AutoSize = true;
            this.buttonExit.BackColor = System.Drawing.Color.DarkRed;
            this.buttonExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(124)))), ((int)(((byte)(54)))));
            this.buttonExit.FlatAppearance.BorderSize = 0;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonExit.ForeColor = System.Drawing.Color.White;
            this.buttonExit.Location = new System.Drawing.Point(218, -4);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(34, 28);
            this.buttonExit.TabIndex = 7;
            this.buttonExit.Text = "x";
            this.buttonExit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonTrig
            // 
            this.buttonTrig.BackColor = System.Drawing.Color.Black;
            this.buttonTrig.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonTrig.FlatAppearance.BorderSize = 0;
            this.buttonTrig.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.buttonTrig.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.buttonTrig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTrig.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonTrig.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonTrig.Location = new System.Drawing.Point(4, 143);
            this.buttonTrig.Margin = new System.Windows.Forms.Padding(1);
            this.buttonTrig.Name = "buttonTrig";
            this.buttonTrig.Size = new System.Drawing.Size(60, 30);
            this.buttonTrig.TabIndex = 92;
            this.buttonTrig.TabStop = false;
            this.buttonTrig.Text = "sin";
            this.buttonTrig.UseVisualStyleBackColor = false;
            this.buttonTrig.Click += new System.EventHandler(this.trig_operation);
            this.buttonTrig.KeyDown += new System.Windows.Forms.KeyEventHandler(this.calculator_KeyDown);
            // 
            // button_0
            // 
            this.button_0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button_0.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_0.FlatAppearance.BorderSize = 0;
            this.button_0.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.button_0.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button_0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_0.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_0.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.button_0.Location = new System.Drawing.Point(2, 495);
            this.button_0.Margin = new System.Windows.Forms.Padding(1);
            this.button_0.Name = "button_0";
            this.button_0.Size = new System.Drawing.Size(122, 60);
            this.button_0.TabIndex = 4;
            this.button_0.TabStop = false;
            this.button_0.Text = "0";
            this.button_0.UseVisualStyleBackColor = false;
            this.button_0.Click += new System.EventHandler(this.digit_pressed);
            this.button_0.KeyDown += new System.Windows.Forms.KeyEventHandler(this.calculator_KeyDown);
            // 
            // labelFirst
            // 
            this.labelFirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelFirst.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFirst.ForeColor = System.Drawing.Color.White;
            this.labelFirst.Location = new System.Drawing.Point(86, 57);
            this.labelFirst.Margin = new System.Windows.Forms.Padding(0);
            this.labelFirst.Name = "labelFirst";
            this.labelFirst.Size = new System.Drawing.Size(154, 25);
            this.labelFirst.TabIndex = 19;
            this.labelFirst.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(1, 242);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(247, 2);
            this.panel2.TabIndex = 95;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button1.Location = new System.Drawing.Point(190, 143);
            this.button1.Margin = new System.Windows.Forms.Padding(1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 30);
            this.button1.TabIndex = 96;
            this.button1.TabStop = false;
            this.button1.Text = "ln";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.trig_operation);
            this.button1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.calculator_KeyDown);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button2.Location = new System.Drawing.Point(65, 143);
            this.button2.Margin = new System.Windows.Forms.Padding(1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(60, 30);
            this.button2.TabIndex = 97;
            this.button2.TabStop = false;
            this.button2.Text = "cos";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.trig_operation);
            this.button2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.calculator_KeyDown);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Black;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button3.Location = new System.Drawing.Point(65, 174);
            this.button3.Margin = new System.Windows.Forms.Padding(1);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(60, 30);
            this.button3.TabIndex = 98;
            this.button3.TabStop = false;
            this.button3.Text = "^";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.binary_operation);
            this.button3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.calculator_KeyDown);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Black;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button4.Location = new System.Drawing.Point(126, 143);
            this.button4.Margin = new System.Windows.Forms.Padding(1);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(60, 30);
            this.button4.TabIndex = 99;
            this.button4.TabStop = false;
            this.button4.Text = "tan";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.trig_operation);
            this.button4.KeyDown += new System.Windows.Forms.KeyEventHandler(this.calculator_KeyDown);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Black;
            this.button6.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button6.Location = new System.Drawing.Point(4, 174);
            this.button6.Margin = new System.Windows.Forms.Padding(1);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(60, 30);
            this.button6.TabIndex = 101;
            this.button6.TabStop = false;
            this.button6.Text = "exp";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.trig_operation);
            this.button6.KeyDown += new System.Windows.Forms.KeyEventHandler(this.calculator_KeyDown);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Black;
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button5.Location = new System.Drawing.Point(124, 174);
            this.button5.Margin = new System.Windows.Forms.Padding(1);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(60, 30);
            this.button5.TabIndex = 102;
            this.button5.TabStop = false;
            this.button5.Text = "Pi";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.math_const);
            this.button5.KeyDown += new System.Windows.Forms.KeyEventHandler(this.calculator_KeyDown);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Black;
            this.button7.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button7.Location = new System.Drawing.Point(186, 174);
            this.button7.Margin = new System.Windows.Forms.Padding(1);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(60, 30);
            this.button7.TabIndex = 103;
            this.button7.TabStop = false;
            this.button7.Text = "e";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.math_const);
            this.button7.KeyDown += new System.Windows.Forms.KeyEventHandler(this.calculator_KeyDown);
            // 
            // checkBox_deg
            // 
            this.checkBox_deg.AutoSize = true;
            this.checkBox_deg.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.checkBox_deg.Location = new System.Drawing.Point(8, 40);
            this.checkBox_deg.Name = "checkBox_deg";
            this.checkBox_deg.Size = new System.Drawing.Size(141, 17);
            this.checkBox_deg.TabIndex = 104;
            this.checkBox_deg.Text = "Измерения в градусах";
            this.checkBox_deg.UseVisualStyleBackColor = true;
            this.checkBox_deg.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Black;
            this.button8.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.button8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button8.Location = new System.Drawing.Point(3, 212);
            this.button8.Margin = new System.Windows.Forms.Padding(1);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(122, 30);
            this.button8.TabIndex = 105;
            this.button8.Text = "журнал";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(250, 556);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.checkBox_deg);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel19);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.buttonTrig);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelFirst);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.button_1);
            this.Controls.Add(this.button_2);
            this.Controls.Add(this.buttonDiv);
            this.Controls.Add(this.button_3);
            this.Controls.Add(this.buttonMult);
            this.Controls.Add(this.button_4);
            this.Controls.Add(this.buttonPlusMinus);
            this.Controls.Add(this.button_5);
            this.Controls.Add(this.buttonMinus);
            this.Controls.Add(this.button_6);
            this.Controls.Add(this.buttonEqually);
            this.Controls.Add(this.buttonPlus);
            this.Controls.Add(this.buttonPoint);
            this.Controls.Add(this.button_7);
            this.Controls.Add(this.button_0);
            this.Controls.Add(this.button_8);
            this.Controls.Add(this.button_9);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "calculator";
            this.Opacity = 0.92D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.calc_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.calculator_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_1;
        private System.Windows.Forms.Button button_3;
        private System.Windows.Forms.Button buttonPoint;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonPlusMinus;
        private System.Windows.Forms.Button buttonDiv;
        private System.Windows.Forms.Button buttonMult;
        private System.Windows.Forms.Button button_7;
        private System.Windows.Forms.Button button_8;
        private System.Windows.Forms.Button button_9;
        private System.Windows.Forms.Button buttonMinus;
        private System.Windows.Forms.Button buttonPlus;
        private System.Windows.Forms.Button button_6;
        private System.Windows.Forms.Button button_5;
        private System.Windows.Forms.Button button_4;
        private System.Windows.Forms.Button buttonEqually;
        private System.Windows.Forms.Button button_2;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Panel panel19;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonTrig;
        private System.Windows.Forms.Button button_0;
        private System.Windows.Forms.Label labelFirst;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.CheckBox checkBox_deg;
        private System.Windows.Forms.Button button8;
    }
}


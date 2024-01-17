namespace WindowsFormsApp3
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
            this.components = new System.ComponentModel.Container();
            this.OpenGLControl = new Tao.Platform.Windows.SimpleOpenGlControl();
            this.button1 = new System.Windows.Forms.Button();
            this.timerForTask4 = new System.Windows.Forms.Timer(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.timerForTask2 = new System.Windows.Forms.Timer(this.components);
            this.trackBarXrot2 = new System.Windows.Forms.TrackBar();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.trackBarZvalueTask1 = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.trackBarZrot1 = new System.Windows.Forms.TrackBar();
            this.trackBarYrot1 = new System.Windows.Forms.TrackBar();
            this.trackBarXrot1 = new System.Windows.Forms.TrackBar();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonTask2RotationByTimer = new System.Windows.Forms.Button();
            this.trackBarZrot2 = new System.Windows.Forms.TrackBar();
            this.trackBarYrot2 = new System.Windows.Forms.TrackBar();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.trackBarAnimationSpeedH = new System.Windows.Forms.TrackBar();
            this.label9 = new System.Windows.Forms.Label();
            this.trackBarZvalueTask4 = new System.Windows.Forms.TrackBar();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.trackBarZrot4 = new System.Windows.Forms.TrackBar();
            this.trackBarYrot4 = new System.Windows.Forms.TrackBar();
            this.trackBarXrot4 = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarXrot2)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarZvalueTask1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarZrot1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarYrot1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarXrot1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarZrot2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarYrot2)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAnimationSpeedH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarZvalueTask4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarZrot4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarYrot4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarXrot4)).BeginInit();
            this.SuspendLayout();
            // 
            // OpenGLControl
            // 
            this.OpenGLControl.AccumBits = ((byte)(0));
            this.OpenGLControl.AutoCheckErrors = false;
            this.OpenGLControl.AutoFinish = false;
            this.OpenGLControl.AutoMakeCurrent = true;
            this.OpenGLControl.AutoSwapBuffers = true;
            this.OpenGLControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.OpenGLControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OpenGLControl.ColorBits = ((byte)(32));
            this.OpenGLControl.DepthBits = ((byte)(16));
            this.OpenGLControl.Location = new System.Drawing.Point(9, 9);
            this.OpenGLControl.Name = "OpenGLControl";
            this.OpenGLControl.Size = new System.Drawing.Size(626, 536);
            this.OpenGLControl.StencilBits = ((byte)(0));
            this.OpenGLControl.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(5, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(221, 32);
            this.button1.TabIndex = 1;
            this.button1.Text = "Отобразить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timerForTask4
            // 
            this.timerForTask4.Interval = 2;
            this.timerForTask4.Tick += new System.EventHandler(this.timerForTask4_Tick);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button2.FlatAppearance.BorderSize = 2;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(5, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(221, 32);
            this.button2.TabIndex = 2;
            this.button2.Text = "Отобразить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button3.FlatAppearance.BorderSize = 2;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(5, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(221, 32);
            this.button3.TabIndex = 3;
            this.button3.Text = "Отобразить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // timerForTask2
            // 
            this.timerForTask2.Tick += new System.EventHandler(this.timerForTask2_Tick);
            // 
            // trackBarXrot2
            // 
            this.trackBarXrot2.AutoSize = false;
            this.trackBarXrot2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.trackBarXrot2.Location = new System.Drawing.Point(5, 77);
            this.trackBarXrot2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.trackBarXrot2.Maximum = 360;
            this.trackBarXrot2.Name = "trackBarXrot2";
            this.trackBarXrot2.Size = new System.Drawing.Size(221, 31);
            this.trackBarXrot2.TabIndex = 4;
            this.trackBarXrot2.ValueChanged += new System.EventHandler(this.trackBarXrot2_ValueChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl1.Location = new System.Drawing.Point(640, 11);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(264, 536);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.trackBarZvalueTask1);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.trackBarZrot1);
            this.tabPage1.Controls.Add(this.trackBarYrot1);
            this.tabPage1.Controls.Add(this.trackBarXrot1);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Size = new System.Drawing.Size(256, 507);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Задание 1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(5, 274);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(153, 17);
            this.label8.TabIndex = 18;
            this.label8.Text = "Отдалить/приблизить";
            // 
            // trackBarZvalueTask1
            // 
            this.trackBarZvalueTask1.AutoSize = false;
            this.trackBarZvalueTask1.BackColor = System.Drawing.Color.Gold;
            this.trackBarZvalueTask1.Location = new System.Drawing.Point(5, 292);
            this.trackBarZvalueTask1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.trackBarZvalueTask1.Maximum = -2;
            this.trackBarZvalueTask1.Minimum = -20;
            this.trackBarZvalueTask1.Name = "trackBarZvalueTask1";
            this.trackBarZvalueTask1.Size = new System.Drawing.Size(221, 31);
            this.trackBarZvalueTask1.TabIndex = 17;
            this.trackBarZvalueTask1.Value = -10;
            this.trackBarZvalueTask1.ValueChanged += new System.EventHandler(this.trackBarZvalueTask1_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(5, 201);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "Поворот по оси Z";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(4, 129);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Поворот по оси Y";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(4, 59);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Поворот по оси X";
            // 
            // trackBarZrot1
            // 
            this.trackBarZrot1.AutoSize = false;
            this.trackBarZrot1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.trackBarZrot1.Location = new System.Drawing.Point(5, 219);
            this.trackBarZrot1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.trackBarZrot1.Maximum = 360;
            this.trackBarZrot1.Name = "trackBarZrot1";
            this.trackBarZrot1.Size = new System.Drawing.Size(221, 31);
            this.trackBarZrot1.TabIndex = 13;
            this.trackBarZrot1.ValueChanged += new System.EventHandler(this.trackBarZrot1_ValueChanged);
            // 
            // trackBarYrot1
            // 
            this.trackBarYrot1.AutoSize = false;
            this.trackBarYrot1.BackColor = System.Drawing.Color.LimeGreen;
            this.trackBarYrot1.Location = new System.Drawing.Point(5, 148);
            this.trackBarYrot1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.trackBarYrot1.Maximum = 360;
            this.trackBarYrot1.Name = "trackBarYrot1";
            this.trackBarYrot1.Size = new System.Drawing.Size(221, 31);
            this.trackBarYrot1.TabIndex = 12;
            this.trackBarYrot1.Value = 60;
            this.trackBarYrot1.ValueChanged += new System.EventHandler(this.trackBarYrot1_ValueChanged);
            // 
            // trackBarXrot1
            // 
            this.trackBarXrot1.AutoSize = false;
            this.trackBarXrot1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.trackBarXrot1.Location = new System.Drawing.Point(5, 77);
            this.trackBarXrot1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.trackBarXrot1.Maximum = 360;
            this.trackBarXrot1.Name = "trackBarXrot1";
            this.trackBarXrot1.Size = new System.Drawing.Size(221, 31);
            this.trackBarXrot1.TabIndex = 11;
            this.trackBarXrot1.Value = 20;
            this.trackBarXrot1.ValueChanged += new System.EventHandler(this.trackBarXrot1_ValueChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.buttonTask2RotationByTimer);
            this.tabPage2.Controls.Add(this.trackBarZrot2);
            this.tabPage2.Controls.Add(this.trackBarYrot2);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.trackBarXrot2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Size = new System.Drawing.Size(227, 507);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Задание 2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(5, 201);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Поворот по оси Z";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(4, 129);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Поворот по оси Y";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(4, 59);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Поворот по оси X";
            // 
            // buttonTask2RotationByTimer
            // 
            this.buttonTask2RotationByTimer.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonTask2RotationByTimer.FlatAppearance.BorderSize = 2;
            this.buttonTask2RotationByTimer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.buttonTask2RotationByTimer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonTask2RotationByTimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTask2RotationByTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonTask2RotationByTimer.Location = new System.Drawing.Point(5, 270);
            this.buttonTask2RotationByTimer.Name = "buttonTask2RotationByTimer";
            this.buttonTask2RotationByTimer.Size = new System.Drawing.Size(221, 32);
            this.buttonTask2RotationByTimer.TabIndex = 7;
            this.buttonTask2RotationByTimer.Text = "Включить вращение";
            this.buttonTask2RotationByTimer.UseVisualStyleBackColor = true;
            this.buttonTask2RotationByTimer.Click += new System.EventHandler(this.buttonTask2RotationByTimer_Click);
            // 
            // trackBarZrot2
            // 
            this.trackBarZrot2.AutoSize = false;
            this.trackBarZrot2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.trackBarZrot2.Location = new System.Drawing.Point(5, 219);
            this.trackBarZrot2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.trackBarZrot2.Maximum = 360;
            this.trackBarZrot2.Name = "trackBarZrot2";
            this.trackBarZrot2.Size = new System.Drawing.Size(221, 31);
            this.trackBarZrot2.TabIndex = 6;
            this.trackBarZrot2.ValueChanged += new System.EventHandler(this.trackBarZrot2_ValueChanged);
            // 
            // trackBarYrot2
            // 
            this.trackBarYrot2.AutoSize = false;
            this.trackBarYrot2.BackColor = System.Drawing.Color.LimeGreen;
            this.trackBarYrot2.Location = new System.Drawing.Point(5, 148);
            this.trackBarYrot2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.trackBarYrot2.Maximum = 360;
            this.trackBarYrot2.Name = "trackBarYrot2";
            this.trackBarYrot2.Size = new System.Drawing.Size(221, 31);
            this.trackBarYrot2.TabIndex = 5;
            this.trackBarYrot2.ValueChanged += new System.EventHandler(this.trackBarYrot2_ValueChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label15);
            this.tabPage3.Controls.Add(this.label14);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Controls.Add(this.trackBarAnimationSpeedH);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.trackBarZvalueTask4);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.trackBarZrot4);
            this.tabPage3.Controls.Add(this.trackBarYrot4);
            this.tabPage3.Controls.Add(this.trackBarXrot4);
            this.tabPage3.Controls.Add(this.button3);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(227, 507);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Задание 3 и 4";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(4, 398);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(83, 17);
            this.label15.TabIndex = 31;
            this.label15.Text = "Медленнее";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(163, 398);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(65, 17);
            this.label14.TabIndex = 30;
            this.label14.Text = "Быстрее";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(5, 347);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(138, 17);
            this.label13.TabIndex = 29;
            this.label13.Text = "Скорость анимации";
            // 
            // trackBarAnimationSpeedH
            // 
            this.trackBarAnimationSpeedH.AutoSize = false;
            this.trackBarAnimationSpeedH.BackColor = System.Drawing.Color.Orchid;
            this.trackBarAnimationSpeedH.Location = new System.Drawing.Point(5, 365);
            this.trackBarAnimationSpeedH.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.trackBarAnimationSpeedH.Maximum = 155;
            this.trackBarAnimationSpeedH.Minimum = 5;
            this.trackBarAnimationSpeedH.Name = "trackBarAnimationSpeedH";
            this.trackBarAnimationSpeedH.Size = new System.Drawing.Size(221, 31);
            this.trackBarAnimationSpeedH.TabIndex = 28;
            this.trackBarAnimationSpeedH.Value = 80;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(5, 274);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(153, 17);
            this.label9.TabIndex = 26;
            this.label9.Text = "Отдалить/приблизить";
            // 
            // trackBarZvalueTask4
            // 
            this.trackBarZvalueTask4.AutoSize = false;
            this.trackBarZvalueTask4.BackColor = System.Drawing.Color.Gold;
            this.trackBarZvalueTask4.Location = new System.Drawing.Point(5, 292);
            this.trackBarZvalueTask4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.trackBarZvalueTask4.Maximum = -2;
            this.trackBarZvalueTask4.Minimum = -20;
            this.trackBarZvalueTask4.Name = "trackBarZvalueTask4";
            this.trackBarZvalueTask4.Size = new System.Drawing.Size(221, 31);
            this.trackBarZvalueTask4.TabIndex = 25;
            this.trackBarZvalueTask4.Value = -10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(5, 201);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(124, 17);
            this.label10.TabIndex = 24;
            this.label10.Text = "Поворот по оси Z";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(4, 129);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(124, 17);
            this.label11.TabIndex = 23;
            this.label11.Text = "Поворот по оси Y";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(4, 59);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(124, 17);
            this.label12.TabIndex = 22;
            this.label12.Text = "Поворот по оси X";
            // 
            // trackBarZrot4
            // 
            this.trackBarZrot4.AutoSize = false;
            this.trackBarZrot4.BackColor = System.Drawing.Color.CornflowerBlue;
            this.trackBarZrot4.Location = new System.Drawing.Point(5, 219);
            this.trackBarZrot4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.trackBarZrot4.Maximum = 360;
            this.trackBarZrot4.Name = "trackBarZrot4";
            this.trackBarZrot4.Size = new System.Drawing.Size(221, 31);
            this.trackBarZrot4.TabIndex = 21;
            // 
            // trackBarYrot4
            // 
            this.trackBarYrot4.AutoSize = false;
            this.trackBarYrot4.BackColor = System.Drawing.Color.LimeGreen;
            this.trackBarYrot4.Location = new System.Drawing.Point(5, 148);
            this.trackBarYrot4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.trackBarYrot4.Maximum = 360;
            this.trackBarYrot4.Name = "trackBarYrot4";
            this.trackBarYrot4.Size = new System.Drawing.Size(221, 31);
            this.trackBarYrot4.TabIndex = 20;
            this.trackBarYrot4.Value = 60;
            // 
            // trackBarXrot4
            // 
            this.trackBarXrot4.AutoSize = false;
            this.trackBarXrot4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.trackBarXrot4.Location = new System.Drawing.Point(5, 77);
            this.trackBarXrot4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.trackBarXrot4.Maximum = 360;
            this.trackBarXrot4.Name = "trackBarXrot4";
            this.trackBarXrot4.Size = new System.Drawing.Size(221, 31);
            this.trackBarXrot4.TabIndex = 19;
            this.trackBarXrot4.Value = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(915, 484);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.OpenGLControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarXrot2)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarZvalueTask1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarZrot1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarYrot1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarXrot1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarZrot2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarYrot2)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAnimationSpeedH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarZvalueTask4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarZrot4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarYrot4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarXrot4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Tao.Platform.Windows.SimpleOpenGlControl OpenGLControl;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timerForTask4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Timer timerForTask2;
        private System.Windows.Forms.TrackBar trackBarXrot2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button buttonTask2RotationByTimer;
        private System.Windows.Forms.TrackBar trackBarZrot2;
        private System.Windows.Forms.TrackBar trackBarYrot2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TrackBar trackBarZrot1;
        private System.Windows.Forms.TrackBar trackBarYrot1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TrackBar trackBarXrot1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TrackBar trackBarZvalueTask1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TrackBar trackBarZvalueTask4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TrackBar trackBarZrot4;
        private System.Windows.Forms.TrackBar trackBarYrot4;
        private System.Windows.Forms.TrackBar trackBarXrot4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TrackBar trackBarAnimationSpeedH;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
    }
}


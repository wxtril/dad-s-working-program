namespace dad_s_working_program
{
    partial class loginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textsingin = new Label();
            personlogin = new TextBox();
            pictureBox1 = new PictureBox();
            personpassword = new TextBox();
            pictureBox2 = new PictureBox();
            singinbutton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // textsingin
            // 
            textsingin.Anchor = AnchorStyles.Top;
            textsingin.AutoSize = true;
            textsingin.Font = new Font("Times New Roman", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            textsingin.Location = new Point(147, 70);
            textsingin.Name = "textsingin";
            textsingin.Size = new Size(119, 40);
            textsingin.TabIndex = 0;
            textsingin.Text = "Sing in";
            textsingin.Click += label1_Click;
            // 
            // personlogin
            // 
            personlogin.Anchor = AnchorStyles.Top;
            personlogin.Location = new Point(110, 151);
            personlogin.Multiline = true;
            personlogin.Name = "personlogin";
            personlogin.RightToLeft = RightToLeft.Yes;
            personlogin.Size = new Size(211, 19);
            personlogin.TabIndex = 1;
            personlogin.TextAlign = HorizontalAlignment.Right;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top;
            pictureBox1.Image = Properties.Resources._2203549_admin_avatar_human_login_user_icon;
            pictureBox1.Location = new Point(78, 151);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(26, 19);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // personpassword
            // 
            personpassword.Anchor = AnchorStyles.Top;
            personpassword.Location = new Point(110, 176);
            personpassword.Multiline = true;
            personpassword.Name = "personpassword";
            personpassword.PasswordChar = '*';
            personpassword.Size = new Size(211, 19);
            personpassword.TabIndex = 3;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top;
            pictureBox2.Image = Properties.Resources._309058_key_login_private_protect_protection_icon;
            pictureBox2.Location = new Point(78, 176);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(26, 19);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // singinbutton
            // 
            singinbutton.Anchor = AnchorStyles.Top;
            singinbutton.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            singinbutton.FlatAppearance.MouseOverBackColor = Color.Gray;
            singinbutton.FlatStyle = FlatStyle.Flat;
            singinbutton.Location = new Point(147, 210);
            singinbutton.Name = "singinbutton";
            singinbutton.Size = new Size(119, 31);
            singinbutton.TabIndex = 5;
            singinbutton.Text = "Sing in";
            singinbutton.UseVisualStyleBackColor = true;
            // 
            // loginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(434, 361);
            Controls.Add(singinbutton);
            Controls.Add(pictureBox2);
            Controls.Add(personpassword);
            Controls.Add(pictureBox1);
            Controls.Add(personlogin);
            Controls.Add(textsingin);
            Name = "loginForm";
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label textsingin;
        private TextBox personlogin;
        private PictureBox pictureBox1;
        private TextBox personpassword;
        private PictureBox pictureBox2;
        private Button singinbutton;
    }
}
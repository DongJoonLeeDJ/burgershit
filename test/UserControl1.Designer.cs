namespace test
{
    partial class UserControl1
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

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl1));
            this.gunaLinePanel1_velid = new Guna.UI.WinForms.GunaLinePanel();
            this.gunaGradientButton_valid = new Guna.UI.WinForms.GunaGradientButton();
            this.gunaLinePanel1_velid.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaLinePanel1_velid
            // 
            this.gunaLinePanel1_velid.BackColor = System.Drawing.Color.Transparent;
            this.gunaLinePanel1_velid.Controls.Add(this.gunaGradientButton_valid);
            this.gunaLinePanel1_velid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaLinePanel1_velid.LineBottom = 4;
            this.gunaLinePanel1_velid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(134)))), ((int)(((byte)(53)))));
            this.gunaLinePanel1_velid.LineLeft = 4;
            this.gunaLinePanel1_velid.LineRight = 4;
            this.gunaLinePanel1_velid.LineStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaLinePanel1_velid.LineTop = 4;
            this.gunaLinePanel1_velid.Location = new System.Drawing.Point(0, 0);
            this.gunaLinePanel1_velid.Margin = new System.Windows.Forms.Padding(0);
            this.gunaLinePanel1_velid.Name = "gunaLinePanel1_velid";
            this.gunaLinePanel1_velid.Size = new System.Drawing.Size(180, 180);
            this.gunaLinePanel1_velid.TabIndex = 2;
            this.gunaLinePanel1_velid.Visible = false;
            this.gunaLinePanel1_velid.Click += new System.EventHandler(this.gunaLinePanel1_velid_Click);
            this.gunaLinePanel1_velid.Paint += new System.Windows.Forms.PaintEventHandler(this.gunaLinePanel1_velid_Paint);
            // 
            // gunaGradientButton_valid
            // 
            this.gunaGradientButton_valid.AnimationHoverSpeed = 0.07F;
            this.gunaGradientButton_valid.AnimationSpeed = 0.03F;
            this.gunaGradientButton_valid.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(134)))), ((int)(((byte)(53)))));
            this.gunaGradientButton_valid.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(134)))), ((int)(((byte)(53)))));
            this.gunaGradientButton_valid.BorderColor = System.Drawing.Color.Black;
            this.gunaGradientButton_valid.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaGradientButton_valid.FocusedColor = System.Drawing.Color.Empty;
            this.gunaGradientButton_valid.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaGradientButton_valid.ForeColor = System.Drawing.Color.White;
            this.gunaGradientButton_valid.Image = ((System.Drawing.Image)(resources.GetObject("gunaGradientButton_valid.Image")));
            this.gunaGradientButton_valid.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaGradientButton_valid.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaGradientButton_valid.Location = new System.Drawing.Point(142, 142);
            this.gunaGradientButton_valid.Name = "gunaGradientButton_valid";
            this.gunaGradientButton_valid.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(134)))), ((int)(((byte)(53)))));
            this.gunaGradientButton_valid.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(134)))), ((int)(((byte)(53)))));
            this.gunaGradientButton_valid.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaGradientButton_valid.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaGradientButton_valid.OnHoverImage = null;
            this.gunaGradientButton_valid.OnPressedColor = System.Drawing.Color.Black;
            this.gunaGradientButton_valid.Size = new System.Drawing.Size(35, 35);
            this.gunaGradientButton_valid.TabIndex = 3;
            this.gunaGradientButton_valid.Visible = false;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.gunaLinePanel1_velid);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(180, 180);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            this.Click += new System.EventHandler(this.UserControl1_Click);
            this.gunaLinePanel1_velid.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI.WinForms.GunaLinePanel gunaLinePanel1_velid;
        private Guna.UI.WinForms.GunaGradientButton gunaGradientButton_valid;
    }
}

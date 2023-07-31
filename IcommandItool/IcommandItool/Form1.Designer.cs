namespace IcommandItool
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.axMapControl1 = new ESRI.ArcGIS.Controls.AxMapControl();
            this.打开地图 = new System.Windows.Forms.Button();
            this.按比例放大 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.axMapControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // axMapControl1
            // 
            this.axMapControl1.Location = new System.Drawing.Point(1004, 161);
            this.axMapControl1.Name = "axMapControl1";
            this.axMapControl1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axMapControl1.OcxState")));
            this.axMapControl1.Size = new System.Drawing.Size(530, 255);
            this.axMapControl1.TabIndex = 0;
            this.axMapControl1.OnMouseDown += new ESRI.ArcGIS.Controls.IMapControlEvents2_Ax_OnMouseDownEventHandler(this.axMapControl1_OnMouseDown);
            // 
            // 打开地图
            // 
            this.打开地图.Location = new System.Drawing.Point(62, 57);
            this.打开地图.Name = "打开地图";
            this.打开地图.Size = new System.Drawing.Size(89, 74);
            this.打开地图.TabIndex = 1;
            this.打开地图.Text = "打开地图";
            this.打开地图.UseVisualStyleBackColor = true;
            this.打开地图.Click += new System.EventHandler(this.打开地图_Click);
            // 
            // 按比例放大
            // 
            this.按比例放大.AllowDrop = true;
            this.按比例放大.Location = new System.Drawing.Point(233, 57);
            this.按比例放大.Name = "按比例放大";
            this.按比例放大.Size = new System.Drawing.Size(183, 74);
            this.按比例放大.TabIndex = 2;
            this.按比例放大.Text = "按比例放大";
            this.按比例放大.UseVisualStyleBackColor = true;
            this.按比例放大.Click += new System.EventHandler(this.按比例放大_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1555, 470);
            this.Controls.Add(this.按比例放大);
            this.Controls.Add(this.打开地图);
            this.Controls.Add(this.axMapControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.axMapControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ESRI.ArcGIS.Controls.AxMapControl axMapControl1;
        private System.Windows.Forms.Button 打开地图;
        private System.Windows.Forms.Button 按比例放大;
    }
}


﻿namespace LiveClientDesktop.WinFormControl
{
    partial class MsPlayerControl
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MsPlayerControl));
            this.PowerMsPlayer = new AxMSPLAYERLib.AxMSPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.PowerMsPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // PowerMsPlayer
            // 
            this.PowerMsPlayer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PowerMsPlayer.Enabled = true;
            this.PowerMsPlayer.Location = new System.Drawing.Point(0, 0);
            this.PowerMsPlayer.Name = "PowerMsPlayer";
            this.PowerMsPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("PowerMsPlayer.OcxState")));
            this.PowerMsPlayer.Size = new System.Drawing.Size(150, 150);
            this.PowerMsPlayer.TabIndex = 0;
            // 
            // MsPlayerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PowerMsPlayer);
            this.Name = "MsPlayerControl";
            ((System.ComponentModel.ISupportInitialize)(this.PowerMsPlayer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxMSPLAYERLib.AxMSPlayer PowerMsPlayer;
    }
}

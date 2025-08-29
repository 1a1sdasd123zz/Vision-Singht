using System;
using System.Windows.Forms;
using Cognex.VisionPro;
using HardWareNet.Base;
using HardWareNet.Enum;
using VisionCore.ShowFrm;

namespace HardWareNet.Frm;

public partial class Frm_Camera2D : Form
{
  private ShowDisplayFrm user_ShowDisplay;
  private Camera2DBase Camera2D;
  public Frm_Camera2D()
  {
    InitializeComponent();
    user_ShowDisplay = new ShowDisplayFrm();
    user_ShowDisplay.Dock = DockStyle.Fill;
    split_Display.Panel2.Controls.Add(user_ShowDisplay);
    Update();
  }

  private void Frm_Camera2D_Load(object sender, EventArgs e)
  {
    foreach (var item in HardCamera.Instance.Cameras)
    {
      cmb_SnList.Properties.Items.Add(item.Key);
    }
    cmb_SnList.SelectedIndex = 0;

  }

  private void SetControlState(bool flag = false)
  {
    chk_Hard.Checked = Camera2D.TriggerMode == EumnTriggerMode2D.Hardware;
    chk_Hard_CheckedChanged(null, null);
    if (flag)
    {
      txt_Exposure.Enabled = true;
      txt_Gain.Enabled = true;
      chk_Hard.Enabled = true;

      btn_Connect.Enabled = false;
      btn_TriggerOnce.Enabled = true;
      btn_Close.Enabled = true;
      btn_Continuous.Enabled = true;
    }
    else
    {
      txt_Exposure.Enabled = false;
      txt_Gain.Enabled = false;
      chk_Hard.Enabled = false;

      btn_Connect.Enabled = true;
      btn_TriggerOnce.Enabled = false;
      btn_Close.Enabled = false;
      btn_Continuous.Enabled = false;
    }
  }
  private void SetControlText()
  {
    try
    {
      txt_Exposure.Text = Camera2D.Exposure.ToString();
      txt_Gain.Text = Camera2D.Gain.ToString();
      txt_MaxExposure.Text = Camera2D.MaxExposure.ToString("F3");
      txt_MaxGain.Text = Camera2D.MaxGain.ToString("F5");
      txt_UserDefinedName.Text = Camera2D.UserDefinedName;
      txt_ModelName.Text = Camera2D.ModelName;
      txt_ManufacturerName.Text = Camera2D.ManufacturerName;
      btn_Connect.Enabled = !Camera2D.bConnect;
      cmb_HardSource.Properties.Items.AddRange(Camera2D.TriggerSource);
    }
    catch (Exception e)
    {

    }
  }

  private void cmb_SnList_SelectedIndexChanged(object sender, EventArgs e)
  {
    try
    {
      Camera2D = HardCamera.Instance.Cameras[(string)cmb_SnList.EditValue];
      Camera2D.UpdateImage = UpdateUIImage;

      SetControlText();
      SetControlState(Camera2D.bConnect);
    }
    catch (Exception exception)
    {
      // ignored
    }
  }

  private void UpdateUIImage(ICogImage imageData)
  {
    if (user_ShowDisplay.InvokeRequired)
    {
      user_ShowDisplay.BeginInvoke(new Action<ICogImage>(UpdateUIImage), imageData);
    }
    else
    {
      user_ShowDisplay.ContinuousShowImage = imageData;
    }
  }

  private void txt_Exposure_EditValueChanged(object sender, EventArgs e)
  {
    try
    {
      double val = double.Parse(txt_Exposure.Text);
      if (val > Camera2D.MaxExposure)
      {
        val = Camera2D.MaxExposure;
        txt_Exposure.Text = val.ToString();
      }
      Camera2D.Exposure = double.Parse(txt_Exposure.Text);
    }
    catch (Exception exception)
    {
      MessageBox.Show("曝光设置失败" + exception, "", MessageBoxButtons.OK);
    }
  }

  private void txt_Gain_EditValueChanged(object sender, EventArgs e)
  {
    try
    {
      double val = double.Parse(txt_Gain.Text);
      if (val > Camera2D.MaxGain)
      {
        val = Camera2D.MaxGain;
        txt_Gain.Text = val.ToString();
      }
      Camera2D.Gain = val;
    }
    catch (Exception exception)
    {
      MessageBox.Show("增益设置失败" + exception, "", MessageBoxButtons.OK);
    }
  }

  private void chk_Hard_CheckedChanged(object sender, EventArgs e)
  {
    cmb_HardSource.SelectedIndex = 0;
    cmb_HardSource.Visible = chk_Hard.Checked;
  }
  private void cmb_HardSource_SelectedIndexChanged(object sender, EventArgs e)
  {
    SetHardTrigger();
  }
  private void SetHardTrigger()
  {
    Camera2D.SetHardwareTrigger(cmb_HardSource.Text);
  }
  private void btn_Connect_Click(object sender, EventArgs e)
  {
    int errCode = 0;
    try
    {
      errCode = Camera2D.OpenCamera();
      SetControlState(Camera2D.bConnect);
    }
    catch (Exception exception)
    {
      MessageBox.Show($"关闭相机失败,错误码{errCode}," + exception, "", MessageBoxButtons.OK);
    }
  }
  private void btn_Close_Click(object sender, EventArgs e)
  {
    try
    {
      Camera2D.Close();
      SetControlState(Camera2D.bConnect);
    }
    catch (Exception exception)
    {
      MessageBox.Show($"关闭相机失败," + exception, "", MessageBoxButtons.OK);
    }
  }
  private void btn_TriggerOnce_Click(object sender, EventArgs e)
  {
    chk_Soft.Checked = true;
    Camera2D.SoftwareTriggerOnce();
  }

  private void btn_Continue_Click(object sender, EventArgs e)
  {
    if (btn_Continuous.Text == "连续采集")
    {
      Camera2D.ContinuousGrab();
      btn_Continuous.Text = "停止采集";
      btn_Close.Enabled = false;
    }
    else
    {
      Camera2D.SetSoftwareTrigger();
      btn_Continuous.Text = "连续采集";
      btn_Close.Enabled = true;
    }
  }
}


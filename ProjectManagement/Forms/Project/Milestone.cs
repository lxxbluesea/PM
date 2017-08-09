﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using DomainDLL;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using BussinessDLL;
using ProjectManagement.Common;
using CommonDLL;
using DevComponents.Editors;

namespace ProjectManagement.Forms.Project
{
    /// <summary>
    ///  画面名：里程碑管理
    ///  Created：20170327(ChengMengjia)
    /// </summary>
    public partial class FormMilestone : Common.BaseForm
    {
        #region 业务类初期化
        MilestoneBLL bll = new MilestoneBLL();
        Milestones entity = null;
        #endregion

        #region 事件

        public FormMilestone()
        {
            InitializeComponent();
            DataHelper.LoadDictItems(cbLStatus, DictCategory.Milestones_FinshStatus);
            //dtLCREATED.Value = DateTime.Now;
            LoadLCB();
            InitControls();
            //dtLFinish.Value = DateTime.Now;
            //entity = new Milestones();
        }

        /// <summary>
        /// 里程碑-清空
        /// Created：20170327(ChengMengjia)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLClear_Click(object sender, EventArgs e)
        {
            InitControls();
        }

        /// <summary>
        /// 初始化所有控件
        /// </summary>
        void InitControls()
        {
            entity = new Milestones();
            txtLName.Clear();
            txtLName.Focus();
            //txtLName.Tag = "";
            txtLRemark.Clear();
            txtLCondition.Clear();
            //dtLCREATED.Value = DateTime.Now;
            dtLFinish.Value = DateTime.Now;
            if (cbLStatus.Items.Count > 0)
                cbLStatus.SelectedIndex = 1;
            else
                cbLStatus.SelectedIndex = 0;
            gridLCB.GetSelectedRows().Select(false);//取消选择
        }


        /// <summary>
        /// 里程碑-保存
        /// Created：20170327(ChengMengjia)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            //Milestones entity = new Milestones();
            //entity.ID = txtLName.Tag == null ? "" : txtLName.Tag.ToString().Trim();
            entity.PID = ProjectId;
            entity.Name = txtLName.Text.Trim();
            entity.Remark = txtLRemark.Text.Trim();
            entity.Condition = txtLCondition.Text.Trim();

            ComboItem item = (ComboItem)cbLStatus.SelectedItem;
            if (item != null)
                entity.FinishStatus = int.Parse(item.Value.ToString());
            entity.FinishDate = dtLFinish.Value;

            #region 判断是否填写完整
            if (string.IsNullOrEmpty(entity.Name))
            {
                MessageHelper.ShowMsg(MessageID.W000000001, MessageType.Alert, "里程碑名称");
                return;
            }
            if (entity.FinishDate == null || entity.FinishDate == DateTime.Parse("0001/1/1 0:00:00"))
            {
                MessageHelper.ShowMsg(MessageID.W000000001, MessageType.Alert, "完成日期");
                return;
            }
            if (entity.FinishStatus == null)
            {
                MessageHelper.ShowMsg(MessageID.W000000001, MessageType.Alert, "完成情况");
                return;
            }
            if (string.IsNullOrEmpty(entity.Condition))
            {
                MessageHelper.ShowMsg(MessageID.W000000001, MessageType.Alert, "完成依据");
                return;
            }
            #endregion

            JsonResult result = bll.SaveLCB(entity);
            MessageHelper.ShowRstMsg(result.result);
            if (result.result)
            {
                btnLClear_Click(sender, e);
                LoadLCB();
            }

        }
        /// <summary>
        /// 里程碑-修改 数据行单击事件
        ///  Created：20170327(ChengMengjia)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gridLCB_RowClick(object sender, DevComponents.DotNetBar.SuperGrid.GridRowClickEventArgs e)
        {
            //DevComponents.DotNetBar.SuperGrid.GridElement list = gridLCB.GetSelectedRows()[0];
            
            //string s = list.ToString();
            //s = s.Replace("{", ",");
            //s = s.Replace("}", ",");
            //string[] listS = s.Split(',');
            //txtLName.Tag = listS[2].Trim();
            //txtLName.Text = listS[3].Trim();
            //dtLFinish.Value = DateTime.Parse(listS[4].Trim());
            //DataHelper.SetComboBoxSelectItemByValue(cbLStatus, listS[9].Trim());
            //txtLCondition.Text = listS[6].Trim();
            //txtLRemark.Text = listS[7].Trim();
            ////dtLCREATED.Value = DateTime.Parse(listS[8].Trim());

            //liuxuexian
            DevComponents.DotNetBar.SuperGrid.GridRow row = gridLCB.GetSelectedRows()[0] as DevComponents.DotNetBar.SuperGrid.GridRow;
            entity.ID = row.GetCell("ID").Value.ToString();
            entity.Name = row.GetCell("Name").Value.ToString();
            entity.FinishDate = DateTime.Parse(row.GetCell("FinishDate").Value.ToString());
            entity.CREATED = DateTime.Parse(row.GetCell("CREATED").Value.ToString());
            if (row.GetCell("UPDATED").Value.ToString() != "")
                entity.UPDATED = DateTime.Parse(row.GetCell("UPDATED").Value.ToString());
            entity.Condition = row.GetCell("Condition").Value.ToString();
            entity.Remark = row.GetCell("Remark").Value.ToString();
            //entity.Status = int.Parse(row.GetCell("Status").Value.ToString());
            entity.PID = ProjectId;
            entity.FinishStatus = int.Parse(row.GetCell("FinishStatus").Value.ToString());

            txtLName.Text = entity.Name;
            txtLRemark.Text = entity.Remark;
            txtLCondition.Text = entity.Condition;
            dtLFinish.Value = (DateTime)entity.FinishDate;
            DataHelper.SetComboBoxSelectItemByValue(cbLStatus, entity.FinishStatus.ToString());

        }


        #endregion

        #region 方法
        /// <summary>
        /// 里程碑-加载
        /// Created：20170327(ChengMengjia)
        /// </summary>
        private void LoadLCB()
        {

            GridData gridData = bll.GetLCBList(0,0,ProjectId);
            gridLCB.PrimaryGrid.DataSource = gridData.data;

        }


        #endregion




    }
}

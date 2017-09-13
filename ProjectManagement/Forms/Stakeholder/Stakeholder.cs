using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using BussinessDLL;
using ProjectManagement.Common;
using DevComponents.DotNetBar.SuperGrid;
using CommonDLL;
using DomainDLL;
using DevComponents.Editors;
using DevComponents.DotNetBar.SuperGrid.Style;

namespace ProjectManagement.Forms.Stakeholder
{

    /// <summary>
    /// author:zhuguanjun
    /// at:2017/03/27
    /// </summary>
    public partial class Stakeholder : BaseForm
    {
        #region 业务逻辑类
        private StakeholdersBLL bll = new StakeholdersBLL();
        #endregion

        #region 变量
        private string ID = null;
        private DateTime CREATED = DateTime.Now;
        Stakeholders stakeholders;
        
        #endregion

        #region 事件
        public Stakeholder()
        {
            InitializeComponent();

            DataBind(null,null);
            dtiCreated.Value = DateTime.Now;
            LoadDropList();
            DataHelper.LoadDictItems(cmbType, DictCategory.StakehoderType); //加载干系人类型
            pagerControl1.OnPageChanged += new EventHandler(DataBind);

            InitControls();
        }

        /// <summary>
        /// 数据绑定
        /// </summary>
        private void DataBind(object sender, EventArgs e)
        {
            GridData list = bll.GetGridData(pagerControl1.PageSize, pagerControl1.PageIndex, ProjectId);
            superGridControl1.PrimaryGrid.DataSource = list.data;
            pagerControl1.DrawControl(list.count);
        }

        /// <summary>
        /// 清空
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            InitControls();
        }

        /// <summary>
        /// 初始化控件
        /// </summary>
        void InitControls()
        {
            stakeholders = new Stakeholders();
            txtDuty.Clear();
            txtEmail.Clear();
            txtName.Clear();
            txtPosition.Clear();
            txtQQ.Clear();
            txtTel.Clear();
            txtWechat.Clear();
            dtiCreated.Value = DateTime.Now;
            cbIspublic.CheckValue = false;
            if (cmbSendType.Items.Count > 2)
                cmbSendType.SelectedIndex = 1;
            else
                cmbSendType.SelectedIndex = -1;
            ID = null;
        }

        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            #region 检查
            if (string.IsNullOrEmpty(txtCompanyName.Text.ToString()))
            {
                MessageHelper.ShowMsg(MessageID.W000000001, MessageType.Alert, "公司名称");
                return;
            }
            if (string.IsNullOrEmpty(txtName.Text.ToString()))
            {
                MessageHelper.ShowMsg(MessageID.W000000001, MessageType.Alert, "姓名");
                return;
            }
            if (string.IsNullOrEmpty(txtEmail.Text.ToString()))
            {
                MessageHelper.ShowMsg(MessageID.W000000001, MessageType.Alert, "电子信箱");
                return;
            }
            int flag = 0;//没有选项目经理
            string flagid = string.Empty;//项目经理id
            if (superGridControl1.PrimaryGrid.Rows.Count != 0)
            {
                foreach (GridRow item in superGridControl1.PrimaryGrid.Rows)
                {
                    if(item.Cells["IsPublic"].Value.ToString()=="1")
                    {
                        flag = 1;
                        flagid = item.Cells["ID"].Value.ToString();
                    }
                    //string s = item.ToString();
                    //s = s.Replace("{", ",");
                    //s = s.Replace("}", ",");
                    //string[] listS = s.Split(',');
                    //if (int.Parse(listS[13].Trim()) != 0) {
                    //    flag = 1;
                    //    flagid = listS[18].Trim();
                    //}
                }
            }
            if (flag != 0 && cbIspublic.Checked && flagid !=stakeholders.ID)
            {
                MessageBox.Show("不能存在多个项目经理");
                return;
            }
            #endregion

            //stakeholders = new Stakeholders();
            stakeholders.PID = ProjectId;
            stakeholders.CompanyName = txtCompanyName.Text.ToString();
            stakeholders.Duty = txtDuty.Text.ToString();
            stakeholders.Email = txtEmail.Text.ToString();
            stakeholders.Position = txtPosition.Text.ToString();
            stakeholders.QQ = txtQQ.Text.ToString();
            stakeholders.Tel = txtTel.Text.ToString();
            stakeholders.Wechat = txtWechat.Text.ToString();
            //分类
            ComboItem cbi = (ComboItem)cmbType.SelectedItem;
            if (cbi != null)
                stakeholders.Type = Convert.ToInt32(cbi.Value);
            stakeholders.Name = txtName.Text.ToString();
            //项目经理
            stakeholders.IsPublic = cbIspublic.Checked ? 1 : 0;
            stakeholders.IsManage = cb_IsManage.Checked ? 1 : 0;
            //发送方式
            ComboItem cbisend = (ComboItem)cmbSendType.SelectedItem;
            if (cbisend != null)
                stakeholders.SendType = Convert.ToInt32(cbisend.Value);
            stakeholders.Name = txtName.Text.ToString();
            //stakeholders.CREATED = CREATED;
            //stakeholders.ID = ID;
            //stakeholders.PID = ProjectId;

            string _id ="";
            JsonResult json = bll.SaveStakehoders(stakeholders,out _id);
            //失败提示
            if (!json.result)
                MessageHelper.ShowRstMsg(json.result);
            btnClear_Click(null, null);
            DataBind(null,null);
        }

        /// <summary>
        /// 选中一行
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void superGridControl1_RowClick(object sender, GridRowClickEventArgs e)
        {
            var rows = superGridControl1.PrimaryGrid.GetSelectedRows();
            if (rows.Count != 1)
            {
                MessageBox.Show("请选择一行");
                superGridControl1.PrimaryGrid.ClearSelectedColumns();
                return;
            }
            GridRow row = (GridRow)rows[0];
            stakeholders = new Stakeholders();
            stakeholders.ID = row.Cells["ID"].Value.ToString();
            stakeholders.PID = row.Cells["PID"].Value.ToString();
            stakeholders.Type = int.Parse(row.Cells["Type"].Value.ToString());
            stakeholders.CompanyName = row.Cells["CompanyName"].Value.ToString();
            stakeholders.Name = row.Cells["Name"].Value.ToString();
            stakeholders.Duty = row.Cells["Duty"].Value.ToString();
            stakeholders.Email = row.Cells["Email"].Value.ToString();
            stakeholders.Position = row.Cells["Position"].Value.ToString();
            stakeholders.QQ = row.Cells["QQ"].Value.ToString();
            stakeholders.Tel = row.Cells["Tel"].Value.ToString();
            stakeholders.Wechat = row.Cells["Wechat"].Value.ToString();
            if (row.Cells["IsPublic"].Value.ToString() != "")
                stakeholders.IsPublic = int.Parse(row.Cells["IsPublic"].Value.ToString());
            if (row.Cells["IsManage"].Value.ToString() != "")
                stakeholders.IsManage = int.Parse(row.Cells["IsManage"].Value.ToString());
            if (row.Cells["SendType"].Value.ToString()!="")
                stakeholders.SendType = int.Parse(row.Cells["SendType"].Value.ToString());
            stakeholders.Status = int.Parse(row.Cells["Status"].Value.ToString());
            stakeholders.CREATED = DateTime.Parse(row.Cells["CREATED"].Value.ToString());
            if (row.GetCell("UPDATED").Value.ToString() != "")
                stakeholders.UPDATED = DateTime.Parse(row.Cells["UPDATED"].Value.ToString());



            txtName.Text = stakeholders.Name;
            txtCompanyName.Text = stakeholders.CompanyName;
            txtDuty.Text = stakeholders.Duty;
            txtEmail.Text = stakeholders.Email;
            txtPosition.Text = stakeholders.Position;
            txtQQ.Text = stakeholders.QQ;
            txtTel.Text = stakeholders.Tel;
            txtWechat.Text = stakeholders.Wechat;

            cmbSendType.SelectedIndex = -1;
            cmbType.SelectedIndex = -1;
            //string select = string.IsNullOrEmpty(row.Cells["Type"].Value.ToString()) ? "0" : row.Cells["Type"].Value.ToString();
            //string select1 = string.IsNullOrEmpty(row.Cells["SendType"].Value.ToString()) ? "0" : row.Cells["SendType"].Value.ToString();
            DataHelper.SetComboBoxSelectItemByValue(cmbType, stakeholders.Type.ToString());
            DataHelper.SetComboBoxSelectItemByValue(cmbSendType, stakeholders.SendType.ToString());
            cbIspublic.CheckValue = stakeholders.IsPublic;
            cb_IsManage.CheckValue = stakeholders.IsManage;
            dtiCreated.Value = stakeholders.CREATED;
            //cbIspublic.CheckValue = Convert.ToInt32(string.IsNullOrEmpty(row.Cells["IsPublic"].Value.ToString()) ? "0" : row.Cells["IsPublic"].Value.ToString());
            //ID = row.Cells["ID"].Value.ToString();
            //dtiCreated.Value = string.IsNullOrEmpty(ID) ? DateTime.Now : Convert.ToDateTime(row.Cells["CREATED"].Value.ToString());
            //CREATED = Convert.ToDateTime(row.Cells["CREATED"].Value.ToString());

            if (ProjectId == stakeholders.PID)
                groupPanel2.Enabled = true;
            else
                groupPanel2.Enabled = false;

        }
        #endregion

        #region 方法
        /// <summary>
        /// 加载下拉框
        /// </summary>
        private void LoadDropList()
        {
            //updated2017/05/25 because of the 'projectteam' is cost need
            //类型下拉框
            //DataHelper.LoadDictItems(cmbType, DictCategory.StakehoderType);
            //cmbType.SelectedIndex = 0;

            //发送类型下拉框
            DataHelper.LoadDictItems(cmbSendType, DictCategory.SendType);
            cmbType.SelectedIndex = -1;
        }
        #endregion

        /// <summary>
        /// 数据绑定完成设置项目经理背景色
        /// 2017/06/12(zhuguanjun)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void superGridControl1_DataBindingComplete(object sender, GridDataBindingCompleteEventArgs e)
        {
            List<GridElement> listRow = superGridControl1.PrimaryGrid.Rows.ToList();
            int type = 0;
            foreach (GridElement obj in listRow)
            {
                GridRow row = (GridRow)obj;
                type = int.Parse(row.GetCell("IsPublic").Value.ToString());
                if (type != 0)
                {
                    CellVisualStyles style = new CellVisualStyles();
                    style.Default.Background.Color1 = Color.CornflowerBlue;
                    row.CellStyles = style;
                }
            }
        }

    }
}

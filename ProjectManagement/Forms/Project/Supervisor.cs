using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DomainDLL;
using BussinessDLL;
using CommonDLL;

namespace ProjectManagement.Forms.Project
{
    /// <summary>
    ///  画面名：监理信息
    /// Created：20170328(ChengMengjia)
    /// </summary>
    public partial class FormSupervisor : Common.BaseForm
    {
        #region 业务类初期化
        SupervisorBLL bll = new SupervisorBLL();
        #endregion

        #region 画面变量
        Supervisor _supervisor;
        SupervisorJudge _supervisorJudge;
        #endregion

        #region 事件
        public FormSupervisor()
        {
            InitializeComponent();
            gridPager.OnPageChanged += new EventHandler(PageChanged);
            DataHelper.LoadDictItems(cbJWay, DictCategory.Supervisor_Way);
            LoadJLXX();
            LoadJLPJ();
            ClearJLPJ();
        }

        /// <summary>
        /// 分页控件变化触发事件
        /// Created：20170331(ChengMengjia)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PageChanged(object sender, EventArgs e)
        {
            LoadJLPJ();
        }

        /// <summary>
        /// 监理信息-清空
        /// Created：20170328(ChengMengjia)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnJClear_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(_supervisor.ID))
                LoadJLXX();
            else
                ClearJLXX();
        }

        /// <summary>
        /// 监理信息-保存
        /// Created：20170328(ChengMengjia)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnJSave_Click(object sender, EventArgs e)
        {
            //Supervisor entity = new Supervisor();
            //entity.ID = _supervisor.ID;
            _supervisor.PID = ProjectId;
            _supervisor.CompanyName = txtJCName.Text;
            _supervisor.ManagerA = txtJManagerA.Text;
            _supervisor.ManagerB = txtJManagerB.Text;
            _supervisor.A_Email = txtJA_Email.Text;
            _supervisor.A_QQ = txtJA_QQ.Text;
            _supervisor.A_Tel = txtJA_Tel.Text;
            _supervisor.A_Wechat = txtJA_Wechat.Text;
            _supervisor.B_Email = txtJB_Email.Text;
            _supervisor.B_QQ = txtJB_QQ.Text;
            _supervisor.B_Tel = txtJB_Tel.Text;
            _supervisor.B_Wechat = txtJB_Wechat.Text;
            _supervisor.Cost = txtJCost.Text;
            _supervisor.Way = cbJWay.Text;

            #region 判断空值
            if (string.IsNullOrEmpty(_supervisor.CompanyName))
            {
                MessageHelper.ShowMsg(MessageID.W000000001, MessageType.Alert, "监理公司名称");
                txtJCName.Focus();
                return;
            }
            if (string.IsNullOrEmpty(_supervisor.ManagerA))
            {
                MessageHelper.ShowMsg(MessageID.W000000001, MessageType.Alert, "监理姓名");
                txtJManagerA.Focus();
                return;
            }
            if (string.IsNullOrEmpty(_supervisor.A_Tel))
            {
                MessageHelper.ShowMsg(MessageID.W000000001, MessageType.Alert, "监理手机号码");
                txtJA_Tel.Focus();
                return;
            }
            //if (string.IsNullOrEmpty(entity.Cost))
            //{
            //    MessageHelper.ShowMsg(MessageID.W000000001, MessageType.Alert, "监理费用");
            //    return;
            //}
            //if (string.IsNullOrEmpty(entity.Way))
            //{
            //    MessageHelper.ShowMsg(MessageID.W000000001, MessageType.Alert, "监理方式");
            //    return;
            //}
            #endregion
            JsonResult result = bll.SaveJLXX(_supervisor);
            MessageHelper.ShowRstMsg(result.result);
            if (result.result)
            {
                //_supervisor = entity;
                txtJName.Text = _supervisor.ManagerA;
            }
        }

        /// <summary>
        /// 监理评价内容-清空
        /// Created：20170328(ChengMengjia)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnJPClear_Click(object sender, EventArgs e)
        {
            ClearJLPJ();
        }

        /// <summary>
        /// 监理评价单击修改事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gridJLPJ_RowClick(object sender, DevComponents.DotNetBar.SuperGrid.GridRowClickEventArgs e)
        {
            dtJDate.IsInputReadOnly = false;
            //DevComponents.DotNetBar.SuperGrid.GridElement list = gridJLPJ.GetSelectedRows()[0];
            //string s = list.ToString();
            //s = s.Replace("{", ",");
            //s = s.Replace("}", ",");
            //string[] listS = s.Split(',');
            //txtJName.Tag = listS[5].Trim();
            //txtJName.Text = listS[2].Trim();
            //txtJContent.Text = listS[3].Trim();
            //dtJDate.Value = DateTime.Parse(listS[4].Trim());
            DevComponents.DotNetBar.SuperGrid.GridRow row = gridJLPJ.GetSelectedRows()[0] as DevComponents.DotNetBar.SuperGrid.GridRow;
            _supervisorJudge.ID = row.GetCell("ID").Value.ToString();
            _supervisorJudge.PID = ProjectId;
            _supervisorJudge.Name = row.GetCell("Name").Value.ToString();
            _supervisorJudge.JudgeDate = DateTime.Parse(row.GetCell("JudgeDate").Value.ToString());
            _supervisorJudge.CREATED = DateTime.Parse(row.GetCell("CREATED").Value.ToString());
            _supervisorJudge.Content = row.GetCell("Content").Value.ToString();

            txtJName.Text = _supervisorJudge.Name;
            txtJContent.Text = _supervisorJudge.Content;
            dtJDate.Value = _supervisorJudge.JudgeDate;
        }


        /// <summary>
        /// 监理评价内容-保存
        /// Created：20170328(ChengMengjia)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnJPSave_Click(object sender, EventArgs e)
        {
            if (_supervisor == null)
            {
                MessageBox.Show("请先完善左侧监理信息！");
                return;
            }

            
            //_supervisorJudge.ID = txtJName.Tag == null ? "" : txtJName.Tag.ToString();
            _supervisorJudge.PID = ProjectId;
            _supervisorJudge.Name = txtJName.Text;
            _supervisorJudge.Content = txtJContent.Text;
            _supervisorJudge.JudgeDate = dtJDate.Value;
            #region 判断空值
            if (string.IsNullOrEmpty(_supervisorJudge.Name))
            {
                MessageHelper.ShowMsg(MessageID.W000000001, MessageType.Alert, "姓名");
                return;
            }
            if (string.IsNullOrEmpty(_supervisorJudge.Content))
            {
                MessageHelper.ShowMsg(MessageID.W000000001, MessageType.Alert, "评价内容");
                return;
            }
            if (_supervisorJudge.JudgeDate == null || _supervisorJudge.JudgeDate == DateTime.Parse("0001/1/1 0:00:00"))
            {
                MessageHelper.ShowMsg(MessageID.W000000001, MessageType.Alert, "评价日期");
                return;
            }
            #endregion

            JsonResult result = bll.SaveJLPJ(_supervisorJudge);
            MessageHelper.ShowRstMsg(result.result);
            if (result.result)
            {
                ClearJLPJ();
                LoadJLPJ();
            }
        }
        #endregion

        #region 方法
        /// <summary>
        /// 监理信息-加载
        /// Created：20170328(ChengMengjia)
        /// </summary>
        private void LoadJLXX()
        {
            _supervisor = bll.GetJLXX(ProjectId);
            txtJCName.Text = _supervisor.CompanyName;
            txtJManagerA.Text = _supervisor.ManagerA;
            txtJManagerB.Text = _supervisor.ManagerB;
            txtJA_Email.Text = _supervisor.A_Email;
            txtJA_QQ.Text = _supervisor.A_QQ;
            txtJA_Tel.Text = _supervisor.A_Tel;
            txtJA_Wechat.Text = _supervisor.A_Wechat;
            txtJB_QQ.Text = _supervisor.B_QQ;
            txtJB_Tel.Text = _supervisor.B_Tel;
            txtJB_Email.Text = _supervisor.B_Email;
            txtJB_Wechat.Text = _supervisor.B_Wechat;
            txtJCost.Text = _supervisor.Cost;
            DataHelper.SetComboBoxSelectItemByText(cbJWay, _supervisor.Way);
            if (cbJWay.Items.Count > 1)
                cbJWay.SelectedIndex = 1;
            else
                cbJWay.SelectedIndex = 0;

        }

        /// <summary>
        ///  监理信息-清空
        /// Created：201700606(ChengMengjia)
        /// </summary>
        private void ClearJLXX()
        {
            _supervisor = new Supervisor();
            txtJCName.Clear();
            txtJManagerA.Clear();
            txtJManagerB.Clear();
            txtJA_Email.Clear();
            txtJA_QQ.Clear();
            txtJA_Tel.Clear();
            txtJA_Wechat.Clear();
            txtJB_QQ.Clear();
            txtJB_Tel.Clear();
            txtJB_Email.Clear();
            txtJB_Wechat.Clear();
            txtJCost.Clear();
            if (cbJWay.Items.Count > 1)
                cbJWay.SelectedIndex = 1;
            else
                cbJWay.SelectedIndex = 0;
        }

        /// <summary>
        ///  监理评价-清空
        /// Created：201700606(ChengMengjia)
        /// </summary>
        private void ClearJLPJ()
        {
            _supervisorJudge = new SupervisorJudge();
            txtJName.Clear();
            txtJName.Tag = "";
            txtJContent.Clear();
            dtJDate.Value = DateTime.Now;
            gridJLPJ.GetSelectedRows().Select(false);//取消选择
            dtJDate.IsInputReadOnly = true;
            txtJName.Text = _supervisor.ManagerA;
        }
        /// <summary>
        /// 监理评价内容-加载
        /// Created：20170327(ChengMengjia)
        /// </summary>
        private void LoadJLPJ()
        {
            GridData gridData = bll.GetJLPJList(gridPager.PageIndex, gridPager.PageSize, ProjectId);
            gridJLPJ.PrimaryGrid.DataSource = gridData.data;
            gridPager.DrawControl(gridData.count);
        }


        #endregion

    }
}

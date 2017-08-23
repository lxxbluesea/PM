using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using ProjectManagement.Common;
using BussinessDLL;
using CommonDLL;
using DomainDLL;
using DevComponents.DotNetBar.SuperGrid;

namespace ProjectManagement.Forms.Others
{
    public partial class Change : BaseForm
    {
        #region 业务初始化
        ChangeBLL bll = new ChangeBLL();
        #endregion

        #region 变量
        private string CHANGEDATEID = null;//版本ID
        private string _changedateid = null;//实际id

        private string CHANGENEEDID = null;//版本ID
        private string _changeneedid = null;//实际id

        private string CHANGERANGEID = null;//版本ID
        private string _changerangeid = null;//实际id

        private string _filedateid = null;//日期变更附件实际id
        private string _fileneedid = null;//需求变更附件实际id
        private string _filerangeid = null;//范围变更附件实际id

        DomainDLL.Change change1, change2, change3;
        DomainDLL.ChangeFiles changefile1, changefile2, changefile3;

        #endregion

        #region 构造
        public Change()
        {
            InitializeComponent();
            BindData((int)ChangeType.Date);
            BindData((int)ChangeType.Need);
            BindData((int)ChangeType.Range);
        }
        #endregion

        #region 绑定变更
        /// <summary>
        /// 绑定数据
        /// 2017/04/17(zhuguanjun)
        /// </summary>
        private void BindData(int Type)
        {
            var dt = bll.GetChangeList(Type, ProjectId);
            switch (Type)
            {
                case (int)ChangeType.Date:
                    superDate.PrimaryGrid.DataSource = dt;
                    break;
                case (int)ChangeType.Need:
                    superNeed.PrimaryGrid.DataSource = dt;
                    break;
                case (int)ChangeType.Range:
                    superRange.PrimaryGrid.DataSource = dt;
                    break;
                default:
                    break;
            } 
        }
        #endregion

        #region 绑定附件
        /// <summary>
        /// 绑定附件
        /// 2017/04/18(zhuguanjun)
        /// </summary>
        /// <param name="Type"></param>
        private void BindFile(int Type)
        {
            DataTable dt = new DataTable();
            switch (Type)
            {
                case (int)ChangeType.Date:
                    dt = bll.GetChangeFilesList(Type, CHANGEDATEID);
                    superGridControl1.PrimaryGrid.DataSource = dt;
                    break;
                case (int)ChangeType.Need:
                    dt = bll.GetChangeFilesList(Type, CHANGENEEDID);
                    superGridControl2.PrimaryGrid.DataSource = dt;
                    break;
                case (int)ChangeType.Range:
                    dt = bll.GetChangeFilesList(Type, CHANGERANGEID);
                    superGridControl3.PrimaryGrid.DataSource = dt;
                    break;
                default:
                    break;
            }
        }
        #endregion

        #region 时间变更

        #region 时间保存
        /// <summary>
        /// 时间变更保存事件
        /// 2017/04/17(zhuguanjun)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSaveChange_Click(object sender, EventArgs e)
        {
            //DomainDLL.Change entity = new DomainDLL.Change();
            //entity.ID = _changedateid;
            change1.Type = (int)ChangeType.Date;
            change1.Name = txtName.Text;
            change1.Payment = txtPayment.Text;
            change1.PID = ProjectId;
            change1.Reason = txtReason.Text;
            change1.AfterInfo = dtiAfter1.Value.ToShortDateString() + "-" + dtiAfter2.Value.ToShortDateString();
            change1.BeforeInfo = dtiBefore1.Value.ToShortDateString() + "-" + dtiBefore2.Value.ToShortDateString();
            change1.Cost = txtCost.Text;
            change1.FinishDate = DateTime.Now;
            var result = bll.Save(change1);
            MessageHelper.ShowRstMsg(result.result);
            if (result.result)
            {
                BindData((int)ChangeType.Date);
                _changedateid = result.data.ToString();//实际id
                CHANGEDATEID = _changedateid.Substring(0, 36) + "-1";//原始版本id
            }
            ClearDate(false);//只清除文本框
        }
        #endregion

        #region 时间清空 
        /// <summary>
        /// 时间变更清空事件
        /// 2017/04/17(zhuguanjun)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClearChange_Click(object sender, EventArgs e)
        {
            ClearDate(true);//清空文本框和内存中的时间变更id
            superGridControl1.PrimaryGrid.DataSource = null;
            ClearDateFile();//清除附件文本框
        }
        #endregion

        #region 时间清空方法
        /// <summary>
        /// 清空时间
        /// </summary>
        private void ClearDate(bool IsFlag)
        {
            change1 = new DomainDLL.Change();
            txtCost.Clear();
            txtPayment.Clear();
            txtName.Clear();
            dtiAfter1.Value = DateTime.MinValue;
            dtiAfter2.Value = DateTime.MinValue;
            dtiBefore1.Value = DateTime.MinValue;
            dtiBefore2.Value = DateTime.MinValue;
            txtReason.Clear();
            superDate.PrimaryGrid.ClearSelectedRows();
            if (IsFlag)
            {
                _changedateid = string.Empty;
                CHANGEDATEID = string.Empty;
            }
        }

        /// <summary>
        /// 清空时间附件
        /// </summary>
        private void ClearDateFile()
        {
            changefile1 = new ChangeFiles();
            superGridControl1.PrimaryGrid.ClearSelectedRows();
            //superGridControl1.PrimaryGrid.DataSource = null;
            txtDateFileDesc.Clear();
            txtDateFileName.Clear();
            txtDateFilePath.Clear();
            _filedateid = null;
        }
        #endregion

        #region 时间附件保存
        /// <summary>
        /// 时间变更附件保存
        /// 2017/04/18(zhuguanjun)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSaveFile_Click(object sender, EventArgs e)
        {
            #region 检查
            if (string.IsNullOrEmpty(CHANGEDATEID))
            {
                MessageHelper.ShowMsg(MessageID.W000000002, MessageType.Alert, "变更信息");
                return;
            }
            #endregion

            //changefile1 = new DomainDLL.ChangeFiles();
            changefile1.ChangeID = change1.ID ;
            //changefile1.ID = _filedateid;
            changefile1.Desc = txtDateFileDesc.Text;
            changefile1.Name = txtDateFileName.Text;
            changefile1.Path = txtDateFilePath.Text;
            var result = bll.SaveFile(changefile1);
            MessageHelper.ShowRstMsg(result.result);
            if (result.result)
                BindFile((int)ChangeType.Date);
            ClearDateFile();
            //btnClearFile_Click(null, null);
        }
        #endregion

        #region 时间附件上传
        /// <summary>
        /// 时间附件上传
        /// 2017/04/18(zhuguanjun)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDateFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Multiselect = false;
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    string[] temp = dialog.SafeFileName.Split('.');
                    txtDateFileName.Text = temp[0];
                    string path = string.Empty;
                    if (!string.IsNullOrEmpty(dialog.FileName))
                        path = FileHelper.UploadFile(dialog.FileName, UploadType.Change, ProjectId, null);
                    if (!string.IsNullOrEmpty(path))
                        txtDateFilePath.Text = path;
                }
            }
        }
        #endregion

        #region 时间附件清空
        /// <summary>
        /// 时间变更附件清空事件
        /// 2017/04/19(zhuguanjun)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClearFile_Click(object sender, EventArgs e)
        {
            ClearDateFile();
            //_filedateid = null;
            //txtDateFileDesc.Clear();
            //txtDateFileName.Clear();
            //txtDateFilePath.Clear();
            //superGridControl1.PrimaryGrid.ClearSelectedRows();
        }
        #endregion

        #region 时间列表点击
        /// <summary>
        /// 时间变更列表行点击事件
        /// 2017/04/18(zhuguanjun)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void superDate_RowClick(object sender, DevComponents.DotNetBar.SuperGrid.GridRowClickEventArgs e)
        {
            var rows = superDate.PrimaryGrid.GetSelectedRows();
            if (rows.Count != 1)
            {
                MessageBox.Show("请选择一行");
                superDate.PrimaryGrid.ClearSelectedColumns();
                return;
            }
            ClearDateFile();

            GridRow row = (GridRow)rows[0];
            change1 = new DomainDLL.Change();
            DataTable files = new DataTable();
            bll.GetChangeInfo(row.Cells["ID"].Value.ToString(), out change1, out files);
            CHANGEDATEID = row.Cells["ID"].Value.ToString();

            change1.ID = row.Cells["ID"].Value.ToString();
            change1.PID = row.Cells["PID"].Value.ToString();
            change1.Type = int.Parse(row.Cells["Type"].Value.ToString());
            change1.Name = row.Cells["Name"].Value.ToString();
            change1.BeforeInfo = row.Cells["BeforeInfo"].Value.ToString();
            change1.AfterInfo = row.Cells["AfterInfo"].Value.ToString();
            change1.Reason = row.Cells["Reason"].Value.ToString();
            change1.Cost = row.Cells["Cost"].Value.ToString();
            change1.Payment = row.Cells["Payment"].Value.ToString();
            change1.Status = int.Parse(row.Cells["Status"].Value.ToString());
            change1.CREATED = DateTime.Parse(row.Cells["CREATED"].Value.ToString());
            if (!String.IsNullOrEmpty(row.Cells["UPDATED"].Value.ToString()))
            {
                change1.UPDATED = DateTime.Parse(row.Cells["UPDATED"].Value.ToString());
            }
            if (!String.IsNullOrEmpty(row.Cells["FinishDate"].Value.ToString()))
            {
                change1.FinishDate = DateTime.Parse(row.Cells["FinishDate"].Value.ToString());
            }


            txtCost.Text = change1.Cost;
            txtName.Text = change1.Name;
            txtPayment.Text = change1.Payment;
            txtReason.Text = change1.Reason;
            string[] temp = change1.AfterInfo.Split('-');
            if (temp != null && temp.Count() == 2)
            {
                dtiAfter1.Value = Convert.ToDateTime(temp[0]);
                dtiAfter2.Value = Convert.ToDateTime(temp[1]);
            }
            string[] tempb = change1.BeforeInfo.Split('-');
            if (tempb != null && tempb.Count() == 2)
            {
                dtiBefore1.Value = Convert.ToDateTime(tempb[0]);
                dtiBefore2.Value = Convert.ToDateTime(tempb[1]);
            }
            _changedateid = change1.ID;//实际id

            superGridControl1.PrimaryGrid.DataSource = files;
        }
        #endregion

        #region 时间附件行点击
        /// <summary>
        /// 时间变更附件行点击
        /// 2017/04/18(zhuguanjun)
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
            changefile1 = new ChangeFiles();
            if(change1==null)
            {
                MessageBox.Show("请选择一个变更");
                superGridControl1.PrimaryGrid.ClearSelectedColumns();
                return;
            }
            changefile1.ID = row.Cells["ID"].Value.ToString();
            changefile1.ChangeID = change1.ID;
            changefile1.Name = row.Cells["Name"].Value.ToString();
            changefile1.Path = row.Cells["Path"].Value.ToString();
            changefile1.Desc = row.Cells["Desc"].Value.ToString();
            changefile1.Status = int.Parse(row.Cells["Status"].Value.ToString());
            changefile1.CREATED = DateTime.Parse(row.Cells["CREATED"].Value.ToString());
            if (!String.IsNullOrEmpty(row.Cells["UPDATED"].Value.ToString()))
                changefile1.UPDATED = DateTime.Parse(row.Cells["UPDATED"].Value.ToString());


            txtDateFileDesc.Text = row.Cells["Desc"].Value.ToString();
            txtDateFileName.Text = row.Cells["Name"].Value.ToString();
            txtDateFilePath.Text = row.Cells["Path"].Value.ToString();
            _filedateid = row.Cells["ID"].Value.ToString();
        }
        #endregion

        #region 时间附件下载
        /// <summary>
        /// 时间变更附件下载点击
        /// 2017/04/18(zhuguanjun)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void superGridControl1_CellClick(object sender, GridCellClickEventArgs e)
        {
            if (e.GridCell.GridColumn.Name == "Down")
            {
                if (e.GridCell.GridRow.GetCell("Path").Value == null)
                {
                    MessageBox.Show("没有文件！");
                    return;
                }
                string fileName = e.GridCell.GridRow.GetCell("Path").Value.ToString();
                if (string.IsNullOrEmpty(fileName))
                {
                    MessageHelper.ShowMsg(MessageID.W000000005, MessageType.Alert);
                    return;
                }

                //文件下载
                FileHelper.DownLoadFile(UploadType.Change, ProjectId, null, fileName);
            }
        }
        #endregion

        #endregion

        #region 需求变更

        #region 需求保存
        /// <summary>
        /// 需求变更保存事件
        /// 2017/04/19(zhugaunjun)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSaveNeed_Click(object sender, EventArgs e)
        {
            //change2 = new DomainDLL.Change();
            //entity.ID = _changeneedid;
            change2.Type = (int)ChangeType.Need;
            change2.Name = txtNeedName.Text;
            change2.Payment = txtNeedPayment.Text;
            change2.PID = ProjectId;
            change2.Reason = txtNeedReason.Text;
            change2.AfterInfo = txtNeedAfter.Text;
            change2.BeforeInfo = txtNeedBefore.Text;
            change2.Cost = txtNeedCost.Text;
            change2.FinishDate = dtiNeedFinishDate.Value;
            var result = bll.Save(change2);
            MessageHelper.ShowRstMsg(result.result);
            if (result.result)
            {
                _changeneedid = result.data.ToString();//实际id
                CHANGENEEDID = _changeneedid.Substring(0, 36) + "-1";//原始版本id
                BindData((int)ChangeType.Need);
            }
            ClearNeed(false);//不会干涉附件信息
        }
        #endregion

        #region 需求清空
        /// <summary>
        /// 需求变更清空事件
        /// 2017/04/19(zhuguanjun)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClearNeed_Click(object sender, EventArgs e)
        {
            ClearNeed(true);
            superGridControl2.PrimaryGrid.DataSource = null;
            ClearNeedFile();
        }
        #endregion

        #region 需求清空方法
        /// <summary>
        /// 清空需求
        /// </summary>
        private void ClearNeed(bool IsFlag)
        {
            change2 = new DomainDLL.Change();
            txtNeedCost.Clear();
            txtNeedPayment.Clear();
            txtNeedName.Clear();
            txtNeedAfter.Clear();
            txtNeedBefore.Clear();
            txtNeedReason.Clear();
            dtiNeedFinishDate.Value = DateTime.Now;
            superNeed.PrimaryGrid.ClearSelectedRows();
            if (IsFlag)
            {
                _changeneedid = string.Empty;
                CHANGENEEDID = string.Empty;
            }
        }

        /// <summary>
        /// 清空需求附件
        /// </summary>
        private void ClearNeedFile()
        {
            changefile2 = new ChangeFiles();
            superGridControl2.PrimaryGrid.ClearSelectedRows();
            txtNeedFileDesc.Clear();
            txtNEEDFileName.Clear();
            txtNEEDFilePath.Clear();
            _fileneedid = null;
        }
        #endregion

        #region 需求附件保存
        /// <summary>
        /// 需求变更附件保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSaveNeedFile_Click(object sender, EventArgs e)
        {
            #region 检查
            if (string.IsNullOrEmpty(CHANGENEEDID))
            {
                MessageHelper.ShowMsg(MessageID.W000000002, MessageType.Alert, "变更信息");
                return;
            }
            #endregion

            //DomainDLL.ChangeFiles entity = new DomainDLL.ChangeFiles();
            changefile2.ChangeID = change2.ID;//变更版本id
            //changefile2.ID = _fileneedid;//附件id
            changefile2.Desc = txtNeedFileDesc.Text;
            changefile2.Name = txtNEEDFileName.Text;
            changefile2.Path = txtNEEDFilePath.Text;
            var result = bll.SaveFile(changefile2);
            MessageHelper.ShowRstMsg(result.result);
            if (result.result)
                BindFile((int)ChangeType.Need);
            ClearDateFile();
            //btnClearNeedFile_Click(null, null);
        }
        #endregion

        #region 需求附件上传
        /// <summary>
        /// 需求附件上传
        /// 2017/04/19（zhuguanjun0
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNeedFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Multiselect = false;
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    string[] temp = dialog.SafeFileName.Split('.');
                    txtNEEDFileName.Text = temp[0];
                    string path = string.Empty;
                    if (!string.IsNullOrEmpty(dialog.FileName))
                        path = FileHelper.UploadFile(dialog.FileName, UploadType.Change, ProjectId, null);
                    if (!string.IsNullOrEmpty(path))
                        txtNEEDFilePath.Text = path;
                }
            }
        }
        #endregion

        #region 需求附件清空
        /// <summary>
        /// 需求附件清空
        /// 2017/04/17(zhugaunjun)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClearNeedFile_Click(object sender, EventArgs e)
        {
            ClearNeedFile();
            //txtNEEDFilePath.Clear();
            //txtNEEDFileName.Clear();
            //txtNeedFileDesc.Clear();
            //_fileneedid = null;
            //superGridControl2.PrimaryGrid.ClearSelectedRows(); ;
        }
        #endregion

        #region 需求列表点击
        /// <summary>
        /// 需求列表点击
        /// 2017/04/19(zhuagunjun)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void superNeed_RowClick(object sender, GridRowClickEventArgs e)
        {
            var rows = superNeed.PrimaryGrid.GetSelectedRows();
            if (rows.Count != 1)
            {
                MessageBox.Show("请选择一行");
                superNeed.PrimaryGrid.ClearSelectedColumns();
                return;
            }
            //btnClearNeedFile_Click(null, null);
            ClearNeedFile();
            GridRow row = (GridRow)rows[0];
            change2 = new DomainDLL.Change();
            DataTable files = new DataTable();
            bll.GetChangeInfo(row.Cells["ID"].Value.ToString(), out change2, out files);
            CHANGENEEDID = row.Cells["ID"].Value.ToString();



            change2.ID = row.Cells["ID"].Value.ToString();
            change2.PID = row.Cells["PID"].Value.ToString();
            change2.Type = int.Parse(row.Cells["Type"].Value.ToString());
            change2.Name = row.Cells["Name"].Value.ToString();
            change2.BeforeInfo = row.Cells["BeforeInfo"].Value.ToString();
            change2.AfterInfo = row.Cells["AfterInfo"].Value.ToString();
            change2.Reason = row.Cells["Reason"].Value.ToString();
            change2.Cost = row.Cells["Cost"].Value.ToString();
            change2.Payment = row.Cells["Payment"].Value.ToString();
            change2.Status = int.Parse(row.Cells["Status"].Value.ToString());
            change2.CREATED = DateTime.Parse(row.Cells["CREATED"].Value.ToString());
            if (!String.IsNullOrEmpty(row.Cells["UPDATED"].Value.ToString()))
            {
                change2.UPDATED = DateTime.Parse(row.Cells["UPDATED"].Value.ToString());
            }
            change2.FinishDate = DateTime.Parse(row.Cells["FinishDate"].Value.ToString());




            txtNeedCost.Text = change2.Cost;
            txtNeedName.Text = change2.Name;
            txtNeedPayment.Text = change2.Payment;
            txtNeedReason.Text = change2.Reason;
            txtNeedAfter.Text = change2.AfterInfo;
            txtNeedBefore.Text = change2.BeforeInfo;
            _changeneedid = change2.ID;//实际id
            dtiNeedFinishDate.Value = change2.FinishDate;
            superGridControl2.PrimaryGrid.DataSource = files;
        }
        #endregion

        #region 需求附件列表点击
        /// <summary>
        /// 需求附件列表行点击
        /// 2017/04/19(zhugaunjun)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void superGridControl2_RowClick(object sender, GridRowClickEventArgs e)
        {
            var rows = superGridControl2.PrimaryGrid.GetSelectedRows();
            if (rows.Count != 1)
            {
                MessageBox.Show("请选择一行");
                superGridControl2.PrimaryGrid.ClearSelectedColumns();
                return;
            }
            GridRow row = (GridRow)rows[0];
            changefile2 = new ChangeFiles();
            changefile2.ID = row.Cells["ID"].Value.ToString();
            changefile2.ChangeID = change2.ID;
            changefile2.Name = row.Cells["Name"].Value.ToString();
            changefile2.Path = row.Cells["Path"].Value.ToString();
            changefile2.Desc = row.Cells["Desc"].Value.ToString();
            changefile2.Status = int.Parse(row.Cells["Status"].Value.ToString());
            changefile2.CREATED = DateTime.Parse(row.Cells["CREATED"].Value.ToString());
            if (!String.IsNullOrEmpty(row.Cells["UPDATED"].Value.ToString()))
                changefile2.UPDATED = DateTime.Parse(row.Cells["UPDATED"].Value.ToString());

            txtNeedFileDesc.Text = row.Cells["Desc"].Value.ToString();
            txtNEEDFileName.Text = row.Cells["Name"].Value.ToString();
            txtNEEDFilePath.Text = row.Cells["Path"].Value.ToString();
            _fileneedid = row.Cells["ID"].Value.ToString();
        }
        #endregion

        #region 需求附件下载
        /// <summary>
        /// 需求附件列表单元格点击
        /// 2017/04/19(zhuguanjun)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void superGridControl2_CellClick(object sender, GridCellClickEventArgs e)
        {
            if (e.GridCell.GridColumn.Name == "Down")
            {
                if (e.GridCell.GridRow.GetCell("Path").Value == null)
                {
                    MessageBox.Show("没有文件！");
                    return;
                }
                string fileName = e.GridCell.GridRow.GetCell("Path").Value.ToString();
                if (string.IsNullOrEmpty(fileName))
                {
                    MessageHelper.ShowMsg(MessageID.W000000005, MessageType.Alert);
                    return;
                }

                //文件下载
                FileHelper.DownLoadFile(UploadType.Change, ProjectId, null, fileName);
            }
        }
        #endregion

        #endregion

        #region 范围变更
        #region 需求列表点击
        /// <summary>
        /// 范围行点击
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void superRange_RowClick(object sender, GridRowClickEventArgs e)
        {
            var rows = superRange.PrimaryGrid.GetSelectedRows();
            if (rows.Count != 1)
            {
                MessageBox.Show("请选择一行");
                superRange.PrimaryGrid.ClearSelectedColumns();
                return;
            }
            ClearRangeFile();
            GridRow row = (GridRow)rows[0];
            change3 = new DomainDLL.Change();
            DataTable files = new DataTable();
            bll.GetChangeInfo(row.Cells["ID"].Value.ToString(), out change3, out files);
            CHANGERANGEID = row.Cells["ID"].Value.ToString();



            change3.ID = row.Cells["ID"].Value.ToString();
            change3.PID = row.Cells["PID"].Value.ToString();
            change3.Type = int.Parse(row.Cells["Type"].Value.ToString());
            change3.Name = row.Cells["Name"].Value.ToString();
            change3.BeforeInfo = row.Cells["BeforeInfo"].Value.ToString();
            change3.AfterInfo = row.Cells["AfterInfo"].Value.ToString();
            change3.Reason = row.Cells["Reason"].Value.ToString();
            change3.Cost = row.Cells["Cost"].Value.ToString();
            change3.Payment = row.Cells["Payment"].Value.ToString();
            change3.Status = int.Parse(row.Cells["Status"].Value.ToString());
            change3.CREATED = DateTime.Parse(row.Cells["CREATED"].Value.ToString());
            if (!String.IsNullOrEmpty(row.Cells["UPDATED"].Value.ToString()))
            {
                change3.UPDATED = DateTime.Parse(row.Cells["UPDATED"].Value.ToString());
            }

            change3.FinishDate = DateTime.Parse(row.Cells["FinishDate"].Value.ToString());


            txtRangeCost.Text = change3.Cost;
            txtRangeName.Text = change3.Name;
            txtRangePayment.Text = change3.Payment;
            txtRangeReason.Text = change3.Reason;
            txtRangeAfter.Text = change3.AfterInfo;
            txtRangeBefore.Text = change3.BeforeInfo;
            dtiRangeFinishDate.Value = change3.FinishDate;
            _changerangeid = change3.ID;//实际id

            superGridControl3.PrimaryGrid.DataSource = files;
        }
        #endregion

        #region 范围保存
        /// <summary>
        /// 范围保存
        /// 2017/04/20(zhuguanjun)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSaveRange_Click(object sender, EventArgs e)
        {
            //DomainDLL.Change entity = new DomainDLL.Change();
            //entity.ID = _changerangeid;
            change3.Type = (int)ChangeType.Range;
            change3.Name = txtRangeName.Text;
            change3.Payment = txtRangePayment.Text;
            change3.PID = ProjectId;
            change3.Reason = txtRangeReason.Text;
            change3.AfterInfo = txtRangeAfter.Text;
            change3.BeforeInfo = txtRangeBefore.Text;
            change3.Cost = txtRangeCost.Text;
            change3.FinishDate = dtiRangeFinishDate.Value;
            var result = bll.Save(change3);
            MessageHelper.ShowRstMsg(result.result);
            if (result.result)
            {
                _changerangeid = result.data.ToString();//实际id
                CHANGERANGEID = _changerangeid.Substring(0, 36) + "-1";//原始版本id
                BindData((int)ChangeType.Range);
            }
            ClearRange(false);//不会干涉附件信息
        }
        #endregion

        #region 范围清空方法
        /// <summary>
        /// 清空范围
        /// </summary>
        private void ClearRange(bool IsFlag)
        {
            change3 = new DomainDLL.Change();
            txtRangeCost.Clear();
            txtRangePayment.Clear();
            txtRangeName.Clear();
            txtRangeAfter.Clear();
            txtRangeBefore.Clear();
            txtRangeReason.Clear();
            dtiRangeFinishDate.Value = DateTime.Now;
            superRange.PrimaryGrid.ClearSelectedRows();
            if (IsFlag)
            {
                _changerangeid = string.Empty;
                CHANGERANGEID = string.Empty;
            }
        }

        /// <summary>
        /// 清空范围附件
        /// </summary>
        private void ClearRangeFile()
        {
            changefile3 = new ChangeFiles();
            superGridControl3.PrimaryGrid.ClearSelectedRows();
            txtRangeFileDesc.Clear();
            txtRangeFileName.Clear();
            txtRangeFilePath.Clear();
            _filerangeid = null;
        }
        #endregion

        #region 范围清空
        /// <summary>
        /// 范围清空
        /// 2017/04/20(zhuguanjun)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClearRange_Click(object sender, EventArgs e)
        {
            ClearRange(true);
            superGridControl3.PrimaryGrid.DataSource = null;
            ClearRangeFile();
        }
        #endregion

        #region 范围附件上传
        /// <summary>
        /// 范围文件上传
        /// 2017/04/20(zhuguanjun)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRangeFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Multiselect = false;
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    string[] temp = dialog.SafeFileName.Split('.');
                    txtRangeFileName.Text = temp[0];
                    string path = string.Empty;
                    if (!string.IsNullOrEmpty(dialog.FileName))
                        path = FileHelper.UploadFile(dialog.FileName, UploadType.Change, ProjectId, null);
                    if (!string.IsNullOrEmpty(path))
                        txtRangeFilePath.Text = path;
                }
            }
        }
        #endregion

        #region 范围附件保存
        /// <summary>
        /// 范围附件保存
        /// 2017/04/20(zhuguanjuns)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSaveRangeFile_Click(object sender, EventArgs e)
        {
            #region 检查
            if (string.IsNullOrEmpty(CHANGERANGEID))
            {
                MessageHelper.ShowMsg(MessageID.W000000002, MessageType.Alert, "变更信息");
                return;
            }
            #endregion

            //DomainDLL.ChangeFiles entity = new DomainDLL.ChangeFiles();
            changefile3.ChangeID = change3.ID;
            //changefile3.ID = _filerangeid;
            changefile3.Desc = txtRangeFileDesc.Text;
            changefile3.Name = txtRangeFileName.Text;
            changefile3.Path = txtRangeFilePath.Text;
            var result = bll.SaveFile(changefile3);
            MessageHelper.ShowRstMsg(result.result);
            if (result.result)
                BindFile((int)ChangeType.Range);
            ClearRangeFile();
            //btnClearRangeFile_Click(null, null);
        }
        #endregion

        #region 清空范围附件
        /// <summary>
        /// 清空范围附件
        /// 2017/04/20(zhuguanjun)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClearRangeFile_Click(object sender, EventArgs e)
        {
            ClearRangeFile();
            //changefile3 = new ChangeFiles();
            //_filerangeid = null;
            //txtRangeFileDesc.Clear();
            //txtRangeFileName.Clear();
            //txtRangeFilePath.Clear();
            //superGridControl3.PrimaryGrid.ClearSelectedRows();
        }
        #endregion

        #region 下载范围附件
        /// <summary>
        /// 下载范围
        /// 2017/04/20(zhuguanjun)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void superGridControl3_CellClick(object sender, GridCellClickEventArgs e)
        {
            if (e.GridCell.GridColumn.Name == "Down")
            {
                if (e.GridCell.GridRow.GetCell("Path").Value == null)
                {
                    MessageBox.Show("没有文件！");
                    return;
                }
                string fileName = e.GridCell.GridRow.GetCell("Path").Value.ToString();
                if (string.IsNullOrEmpty(fileName))
                {
                    MessageHelper.ShowMsg(MessageID.W000000005, MessageType.Alert);
                    return;
                }

                //文件下载
                FileHelper.DownLoadFile(UploadType.Change, ProjectId, null, fileName);
            }
        }
        #endregion

        #region 范围附件行点击
        /// <summary>
        /// 范围附件行点击
        /// 2017/04/20(zhuguanjun)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void superGridControl3_RowClick(object sender, GridRowClickEventArgs e)
        {
            var rows = superGridControl3.PrimaryGrid.GetSelectedRows();
            if (rows.Count != 1)
            {
                MessageBox.Show("请选择一行");
                superGridControl3.PrimaryGrid.ClearSelectedColumns();
                return;
            }
            GridRow row = (GridRow)rows[0];

            changefile3 = new ChangeFiles();
            changefile3.ID = row.Cells["ID"].Value.ToString();
            changefile3.ChangeID = change3.ID;
            changefile3.Name = row.Cells["Name"].Value.ToString();
            changefile3.Path = row.Cells["Path"].Value.ToString();
            changefile3.Desc = row.Cells["Desc"].Value.ToString();
            changefile3.Status = int.Parse(row.Cells["Status"].Value.ToString());
            changefile3.CREATED = DateTime.Parse(row.Cells["CREATED"].Value.ToString());
            if (!String.IsNullOrEmpty(row.Cells["UPDATED"].Value.ToString()))
                changefile3.UPDATED = DateTime.Parse(row.Cells["UPDATED"].Value.ToString());


            txtRangeFileDesc.Text = row.Cells["Desc"].Value.ToString();
            txtRangeFileName.Text = row.Cells["Name"].Value.ToString();
            txtRangeFilePath.Text = row.Cells["Path"].Value.ToString();
            _filerangeid = row.Cells["ID"].Value.ToString();
        }
        #endregion

        #endregion

    }
}

﻿using System;
using DomainDLL;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccessDLL;
using CommonDLL;
using System.Data;

namespace BussinessDLL
{
    public partial class WBSBLL
    {
        //NormalOperationDAO dao = new NormalOperationDAO();
        /// <summary>
        /// 获得WBS节点
        /// Created:2017.3.29(ChengMengjia)
        /// </summary>
        /// <returns></returns>
        public PNode GetNode(string NodeID)
        {
            PNode entity = new PNode();
            if (!string.IsNullOrEmpty(NodeID))
            {
                //NodeID = NodeID;
                if (!string.IsNullOrEmpty(NodeID))
                {
                    List<QueryField> qf = new List<QueryField>();
                    qf.Add(new QueryField() { Name = "ID", Comparison = QueryFieldComparison.eq, Type = QueryFieldType.String, Value = NodeID });
                    qf.Add(new QueryField() { Name = "Status", Type = QueryFieldType.Numeric, Value = 1 });
                    SortField sf = new SortField() { Name = "CREATED", Direction = SortDirection.Desc };
                    List<PNode> list = new Repository<PNode>().GetList(qf, sf) as List<PNode>;
                    if (list.Count > 0)
                        entity = list[0];
                }
            }
            return entity;
        }

        /// <summary>
        /// 交付物基本信息-获得
        /// </summary>
        /// <returns></returns>
        public DeliverablesJBXX GetJBXX(string NodeID)
        {
            DeliverablesJBXX entity = null;
            //NodeID = NodeID;
            if (!string.IsNullOrEmpty(NodeID))
            {
                List<QueryField> qf = new List<QueryField>();
                qf.Add(new QueryField() { Name = "NodeID", Comparison = QueryFieldComparison.eq, Type = QueryFieldType.String, Value = NodeID });
                qf.Add(new QueryField() { Name = "Status", Type = QueryFieldType.Numeric, Value = 1 });
                SortField sf = new SortField() { Name = "CREATED", Direction = SortDirection.Desc };
                List<DeliverablesJBXX> list = new Repository<DeliverablesJBXX>().GetList(qf, sf) as List<DeliverablesJBXX>;
                if (list.Count > 0)
                    entity = list[0];
            }
            return entity;
        }


        /// <summary>
        /// 获取节点进度
        /// Created:20170330(ChengMengjia)
        /// </summary>
        /// <param name="NodeID"></param>
        /// <returns></returns>
        public NodeProgress GetProgress(string NodeID)
        {
            NodeProgress entity = new NodeProgress();
            //if (NodeID.Length > 36)
            //    NodeID = NodeID;
            if (!string.IsNullOrEmpty(NodeID))
            {
                List<QueryField> qf = new List<QueryField>();
                qf.Add(new QueryField() { Name = "NodeID", Comparison = QueryFieldComparison.like, Type = QueryFieldType.String, Value = NodeID });
                qf.Add(new QueryField() { Name = "Status", Type = QueryFieldType.Numeric, Value = 1 });
                SortField sf = new SortField() { Name = "CREATED", Direction = SortDirection.Desc };
                List<NodeProgress> list = new Repository<NodeProgress>().GetList(qf, sf) as List<NodeProgress>;
                if (list.Count > 0)
                    entity = list[0];
            }
            return entity;
        }

        /// <summary>
        /// 文件保存
        ///  Created:20170329(ChengMengjia)
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public JsonResult SaveFile(DeliverablesFiles entity, bool ReUpload)
        {
            JsonResult jsonreslut = new JsonResult();
            try
            {
                string _id;
                //entity.NodeID = entity.NodeID;
                if (string.IsNullOrEmpty(entity.ID))
                    new Repository<DeliverablesFiles>().Insert(entity, true, out _id);
                else
                {
                    DeliverablesFiles old = new Repository<DeliverablesFiles>().Get(entity.ID);
                    old.Name = entity.Name;
                    old.Desc = entity.Desc;
                    old.Path = ReUpload ? entity.Path : old.Path;
                    new Repository<DeliverablesFiles>().Update(old, true, out _id);
                }
                jsonreslut.data = _id;
                jsonreslut.result = true;
                jsonreslut.msg = "保存成功！";
            }
            catch (Exception ex)
            {
                LogHelper.WriteException(ex, LogType.BussinessDLL);
                jsonreslut.result = false;
                jsonreslut.msg = ex.Message;
            }
            return jsonreslut;
        }

        /// <summary>
        /// 文件获取
        ///  Created:20170329(ChengMengjia)
        /// </summary>
        /// <param name="NodeID"></param>
        /// <returns></returns>
        public List<DeliverablesFiles> GetFiles(string NodeID)
        {
            List<QueryField> qf = new List<QueryField>();
            //if (NodeID.Length > 36)
            //    NodeID = NodeID;
            qf.Add(new QueryField() { Name = "NodeID", Type = QueryFieldType.String, Comparison = QueryFieldComparison.like, Value = NodeID });
            qf.Add(new QueryField() { Name = "Status", Comparison = QueryFieldComparison.eq, Type = QueryFieldType.Numeric, Value = 1 });
            SortField sf = new SortField() { Name = "CREATED", Direction = SortDirection.Desc };
            List<DeliverablesFiles> list = new Repository<DeliverablesFiles>().GetList(qf, sf) as List<DeliverablesFiles>;
            return list;
        }

        /// <summary>
        /// 文件获取
        ///  Created:20170913(liuxx)
        /// </summary>
        /// <param name="NodeID"></param>
        /// <returns></returns>
        public List<NodeTrace> GetNodeTrace(string NodeID)
        {
            List<QueryField> qf = new List<QueryField>();
            //if (NodeID.Length > 36)
            //    NodeID = NodeID;
            qf.Add(new QueryField() { Name = "NodeID", Type = QueryFieldType.String, Comparison = QueryFieldComparison.eq, Value = NodeID });
            qf.Add(new QueryField() { Name = "Status", Comparison = QueryFieldComparison.eq, Type = QueryFieldType.Numeric, Value = 1 });
            SortField sf = new SortField() { Name = "CREATED", Direction = SortDirection.Desc };
            List<NodeTrace> list = new Repository<NodeTrace>().GetList(qf, sf) as List<NodeTrace>;
            return list;
        }

        public List<string> GetNodeAndTrace(string nodeid)
        {
            List<string> list = new List<string>();
            DataTable dt = dao.GetNodeAndTrace(nodeid);
            if (dt != null && dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    string str = "";
                    if (i == 0)
                    {
                        str += nodeid + "*【工作名称：" + dt.Rows[i]["name"].ToString() + "】\r\n\t【时间要求】：\r\n\t\t" + dt.Rows[i]["startdate"].ToString() + "至" + dt.Rows[i]["enddate"].ToString() + "\r\n\t【内容描述】：\r\n\t\t" + dt.Rows[i]["desc"].ToString().Replace("\r\n", "") + "\r\n";
                        list.Add(str);
                        str = "";
                        str += nodeid + "*\t【跟进情况】：\r\n\t\t" + dt.Rows[i]["tracedate"].ToString() + "," + dt.Rows[i]["content"].ToString().Replace("\r\n","") + "\r\n";
                    }
                    else
                        str += nodeid + "*\t\t" + dt.Rows[i]["tracedate"].ToString() + "," + dt.Rows[i]["content"].ToString().Replace("\r\n", "") + "\r\n";

                    list.Add(str);
                }
            }
            return list;
        }

        /// <summary>
        /// 交付物进度更新
        ///  Created:20170330(ChengMengjia)
        /// </summary>
        /// <param name="Entity"></param>
        /// <returns></returns>
        public JsonResult SaveProgress(NodeProgress entity)
        {
            JsonResult jsonreslut = new JsonResult();
            try
            {
                string _id;
                //entity.NodeID = entity.NodeID;
                if (string.IsNullOrEmpty(entity.ID))
                    new Repository<NodeProgress>().Insert(entity, true, out _id);
                else
                    new Repository<NodeProgress>().Update(entity, true, out _id);
                jsonreslut.data = _id;
                jsonreslut.result = true;
                jsonreslut.msg = "保存成功！";
            }
            catch (Exception ex)
            {
                LogHelper.WriteException(ex, LogType.BussinessDLL);
                jsonreslut.result = false;
                jsonreslut.msg = ex.Message;
            }
            return jsonreslut;
        }

        /// <summary>
        /// 获取交付物信息列表
        ///  Created:2017.04.21(ChengMengJia)
        /// </summary>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <param name="PID"></param>
        /// <returns></returns>
        public DataTable GetJFWList(string startDate, string endDate, string PID)
        {
            return dao.GetJFWList( startDate,  endDate, PID);
        }
        /// <summary>
        /// 交付物跟进情况保存
        ///  Created:20170913(liuxx)
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public JsonResult SaveNodeTrace(NodeTrace entity)
        {
            JsonResult jsonreslut = new JsonResult();
            try
            {
                string _id;
                if (string.IsNullOrEmpty(entity.ID))
                    new Repository<NodeTrace>().Insert(entity, true, out _id);
                else
                    new Repository<NodeTrace>().Update(entity, true, out _id);
                jsonreslut.data = _id;
                jsonreslut.result = true;
                jsonreslut.msg = "保存成功！";
            }
            catch (Exception ex)
            {
                LogHelper.WriteException(ex, LogType.BussinessDLL);
                jsonreslut.result = false;
                jsonreslut.msg = ex.Message;
            }
            return jsonreslut;
        }
    }
}

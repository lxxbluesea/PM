﻿using CommonDLL;
using DataAccessDLL;
using DomainDLL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace BussinessDLL
{
    /// <summary>
    /// 类名：日常工作业务类
    /// Created：2017.03.30(Xuxb)
    /// updated:2017/06/06(zhuguanjun) mark:日常工作添加责任人列表
    /// </summary>
    public class RoutineBLL
    {
        private RoutineDAO dao = new RoutineDAO();

        /// <summary>
        /// 日常工作保存
        /// Created:20170601(zhuguanjun)
        /// Updated:20170605(ChengMengjia) 添加作为节点插入
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="listWork"></param>
        /// <returns></returns>
        public JsonResult SaveRoutine(string ProjectID, Routine entity, List<RoutineWork> listWork)
        {
            JsonResult jsonreslut = new JsonResult();
            try
            {
                //如果是新增
                if (string.IsNullOrEmpty(entity.ID))
                {
                    #region 新增WBS节点
                    PNode node = null;
                    if (!string.IsNullOrEmpty(entity.ParentNodeID))
                    {
                        node = new PNode();
                        node.ID = Guid.NewGuid().ToString();
                        node.Name = entity.Name;
                        node.ParentID = entity.ParentNodeID;//;
                        node.PID = ProjectID;
                        node.PType = 2;
                        node.Status = 1;
                        node.CREATED = DateTime.Now;
                    }
                    #endregion
                    #region 新插入实体
                    //entity.NodeID = node == null ? null : node.ID;
                    entity.ID = Guid.NewGuid().ToString();// +"-1";
                    entity.CREATED = DateTime.Now;
                    entity.Status = 1;
                    entity.PnodeID = node.ID;
                    entity.Weight = 1;
                    #endregion
                    try
                    {
                        dao.AddRoutine(entity, node, listWork);
                        jsonreslut.data = entity.ID;
                    }
                    catch (Exception ex)
                    {
                        entity.ID = null;
                        throw ex;
                    }
                }
                //编辑
                else
                {
                    PNode node = new WBSBLL().GetNode(entity.PnodeID);
                    if (node != null)
                    {
                        node.Name = entity.Name;
                        node.ParentID = entity.ParentNodeID;
                        //node.PID = ProjectID;
                        //node.PType = 2;
                        //node.Status = 1;
                        node.UPDATED = DateTime.Now;
                    }
                    entity.UPDATED = DateTime.Now;
                    //entity.PnodeID = node.ID;
                    dao.UpdateRoutine(entity, node, listWork);
                    //dao.UpdateRoutine(entity, oldEntity, newNode, oldNode, listWork);
                    jsonreslut.data = entity.ID;

                    //#region 更新实体
                    //Routine oldEntity = new Repository<Routine>().Get(entity.ID);
                    //oldEntity.Status = 0;
                    //oldEntity.UPDATED = DateTime.Now;
                    //#endregion
                    //#region 修改WBS节点
                    //PNode oldNode = null;
                    //if (!string.IsNullOrEmpty(oldEntity.NodeID))
                    //{
                    //oldNode = new WBSBLL().GetNode(oldEntity.NodeID);
                    //    oldNode.Status = 0;
                    //    oldNode.UPDATED = DateTime.Now;
                    //}
                    //#endregion
                    //#region 新增WBS节点
                    //PNode newNode = null;
                    //if (!string.IsNullOrEmpty(entity.NodeID))
                    //{
                    //    newNode = new PNode();
                    //    if (oldNode == null)
                    //        newNode.ID = Guid.NewGuid().ToString() + "-1";
                    //    else
                    //        newNode.ID = oldNode.ID.Substring(0, 36) + "-" + (int.Parse(oldNode.ID.Substring(37)) + 1).ToString();
                    //    newNode.Name = entity.Name;
                    //    newNode.ParentID = entity.NodeID;
                    //    newNode.PID = ProjectID;
                    //    newNode.PType = 2;
                    //    newNode.Status = 1;
                    //    newNode.CREATED = DateTime.Now;
                    //}
                    //#endregion
                    //#region 新插入实体
                    //string hisNo = oldEntity.ID.Substring(37);
                    //entity.ID = oldEntity.ID.Substring(0, 36) + "-" + (int.Parse(hisNo) + 1).ToString();
                    //entity.NodeID = newNode == null ? null : newNode.ID;
                    //entity.Status = 1;
                    //entity.CREATED = DateTime.Now;
                    //#endregion
                    //dao.UpdateRoutine(entity, oldEntity, newNode, oldNode, listWork);
                    //jsonreslut.data = entity.ID;
                }
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
        /// 日常工作保存
        ///  Created:20170330(Xuxb)
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public JsonResult SaveRoutine(Routine entity)
        {
            JsonResult jsonreslut = new JsonResult();
            try
            {
                string _id;
                if (string.IsNullOrEmpty(entity.ID))
                    new Repository<Routine>().Insert(entity, true, out _id);
                else
                    new Repository<Routine>().Update(entity, true, out _id);
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
        /// 日常工作文件保存
        ///  Created:20170330(Xuxb)
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public JsonResult SaveRoutineFile(RoutineFiles entity)
        {
            JsonResult jsonreslut = new JsonResult();
            try
            {
                string _id;
                if (string.IsNullOrEmpty(entity.ID))
                    new Repository<RoutineFiles>().Insert(entity, true, out _id);
                else
                    new Repository<RoutineFiles>().Update(entity, true, out _id);
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
        /// 日常工作跟进情况保存
        ///  Created:20170330(Xuxb)
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public JsonResult SaveRoutineTrace(RoutineTrace entity)
        {
            JsonResult jsonreslut = new JsonResult();
            try
            {
                string _id;
                if (string.IsNullOrEmpty(entity.ID))
                    new Repository<RoutineTrace>().Insert(entity, true, out _id);
                else
                    new Repository<RoutineTrace>().Update(entity, true, out _id);
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
        /// 通过NodeID获取日常工作实体
        /// Created:201700606(ChengMengjia)
        /// </summary>
        /// <param name="nodeID"></param>
        /// <returns></returns>
        public Routine GetRoutineByNodeID(string nodeID)
        {
            Routine entity = null;
            if (!string.IsNullOrEmpty(nodeID))
            {
                List<QueryField> qf = new List<QueryField>();
                qf.Add(new QueryField() { Name = "PnodeID", Type = QueryFieldType.String, Value = nodeID, Comparison = QueryFieldComparison.eq });
                qf.Add(new QueryField() { Name = "Status", Type = QueryFieldType.Numeric, Value = 1 });
                entity = new Repository<Routine>().FindSingle(qf) as Routine;
            }
            return entity == null ? new Routine() : entity;
        }


        /// <summary>
        /// 根据ID获取-日常工作基本信息
        /// Created:20170330(Xuxb)
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public Routine GetRoutineObject(string ID, string NodeID)
        {
            Routine entity = null;
            if (!string.IsNullOrEmpty(ID) || !string.IsNullOrEmpty(NodeID))
            {
                List<QueryField> qf = new List<QueryField>();
                if (!string.IsNullOrEmpty(ID))
                    qf.Add(new QueryField() { Name = "ID", Type = QueryFieldType.String, Value = ID, Comparison = QueryFieldComparison.eq });
                else if (!string.IsNullOrEmpty(NodeID))
                    qf.Add(new QueryField() { Name = "PnodeID", Type = QueryFieldType.String, Value = NodeID, Comparison = QueryFieldComparison.eq });
                qf.Add(new QueryField() { Name = "Status", Type = QueryFieldType.Numeric, Value = 1 });
                entity = new Repository<Routine>().FindSingle(qf) as Routine;
            }
            return entity == null ? new Routine() : entity;
        }

        /// <summary>
        /// 根据查询条件获取-日常工作列表
        /// Created:20170330(Xuxb)
        /// </summary>
        /// <param name="PID"></param>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public DataTable GetRoutinList(string PID, string startDate, string endDate, string key)
        {
            return dao.GetRoutinList(PID, startDate, endDate, key);
        }

        /// <summary>
        /// 根据RountineID获取-日常工作文件
        /// Created:20170330(Xuxb)
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public List<RoutineFiles> GetRoutineFiles(string RountineID)
        {
            List<RoutineFiles> list = new List<RoutineFiles>();
            if (!string.IsNullOrEmpty(RountineID))
            {
                List<QueryField> qf = new List<QueryField>();
                qf.Add(new QueryField() { Name = "RoutineID", Type = QueryFieldType.String, Value = RountineID.Substring(0, 36) });
                qf.Add(new QueryField() { Name = "Status", Type = QueryFieldType.Numeric, Value = 1 });
                SortField sf = new SortField() { Name = "CREATED", Direction = SortDirection.Desc };
                list = new Repository<RoutineFiles>().GetList(qf, sf) as List<RoutineFiles>;
            }
            return list;
        }


        ///// <summary>
        ///// 根据RountineID获取-日常工作文件
        ///// Created:20170330(Xuxb)
        ///// </summary>
        ///// <param name="ID"></param>
        ///// <returns></returns>
        //public List<RoutineTrace> GetRoutineTrace(string RountineID)
        //{
        //    List<RoutineTrace> list = new List<RoutineTrace>();
        //    if (!string.IsNullOrEmpty(RountineID))
        //    {
        //        List<QueryField> qf = new List<QueryField>();
        //        qf.Add(new QueryField() { Name = "RoutineID", Type = QueryFieldType.String, Value = RountineID.Substring(0, 36) });
        //        qf.Add(new QueryField() { Name = "Status", Type = QueryFieldType.Numeric, Value = 1 });
        //        SortField sf = new SortField() { Name = "CREATED", Direction = SortDirection.Asc };
        //        list = new Repository<RoutineTrace>().GetList(qf, sf) as List<RoutineTrace>;
        //    }
        //    return list;
        //}



        /// <summary>
        /// 根据NodeID获取-日常工作文件
        /// Created:20170612(ChengMengjia)
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public List<RoutineFiles> GetFilesByNodeID(string NodeID)
        {
            return dao.GetFilesByNodeID(NodeID);
        }

        public List<string> GetRoutineAndTrace(string nodeid)
        {
            List<string> list = new List<string>();
            DataTable dt = dao.GetRoutineAndTrace(nodeid);
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
                        str += nodeid + "*\t【跟进情况】：\r\n\t\t" + dt.Rows[i]["tracedate"].ToString() + "," + dt.Rows[i]["content"].ToString().Replace("\r\n", "") + "\r\n";
                    }
                    else
                        str += nodeid + "*\t\t" + dt.Rows[i]["tracedate"].ToString() + "," + dt.Rows[i]["content"].ToString().Replace("\r\n", "") + "\r\n";

                    list.Add(str);
                }
            }

            return list;
        }

        /// <summary>
        /// 获取日常工作负责人列表
        /// 2017/06/01(zhuguanjun)
        /// </summary>
        /// <param name="RoutineID"></param>
        /// <returns></returns>
        public DataTable GetRoutinWorkList(string RoutineID)
        {
            return new RoutineDAO().GetRoutinWorkList(RoutineID.Substring(0, 36));
        }

        public DataTable GetRoutineTrace(string routineID)
        {
            return new RoutineDAO().GetRoutineTrace(routineID);
        }
    }
}

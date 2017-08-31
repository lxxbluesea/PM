using CommonDLL;
using DomainDLL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace DataAccessDLL
{
    /// <summary>
    /// 项目计划报表Dao
    /// 2017/04/20(zhuguanjun)
    /// </summary>
    public class ReportPlanDao
    {
        /// <summary>
        /// 获取交付物信息(节点树形式)
        /// 2017/04/20(zhuguanjun)
        /// </summary>
        /// <param name="qlist"></param>
        /// <returns></returns>
        public DataTable GetPlan(DateTime StartDate, DateTime EndDate, int PType, string Manager,string PID)
        {
            List<QueryField> qlist = new List<QueryField>();
            qlist.Add(new QueryField { Name = "Status", Type = QueryFieldType.Numeric, Value = 1 });
            qlist.Add(new QueryField { Name = "PID", Type = QueryFieldType.String, Value = PID });
            qlist.Add(new QueryField() { Name = "Manager", Type = QueryFieldType.String, Value = Manager });
            qlist.Add(new QueryField() { Name = "StartDate", Type = QueryFieldType.DateTime, Value = StartDate });
            qlist.Add(new QueryField() { Name = "EndDate", Type = QueryFieldType.DateTime, Value = EndDate });
            qlist.Add(new QueryField() { Name = "PType", Type = QueryFieldType.Numeric, Value = PType });
            #region 2017/05/10 verson
            //StringBuilder sql = new StringBuilder();
            //sql.Append(" select d.ID,d.Name,(cast(d.Workload as varchar) || '(天)') as Workload,date(d.StartDate) as StartDate,date(d.EndDate) as EndDate,d.Manager");
            //sql.Append(" ,d1.Name as Progress,p.WBSNo,1,length(p.WBSNo)-1) as WBSNo from DeliverablesJBXX d");
            //sql.Append(" left join NodeProgress n on n.Status=@Status and d.NodeID=n.NodeID");
            //sql.Append(" left join DictItem d1 on n.PType = d1.No and d1.DictNo=" + (int)DictCategory.PlanFinishStatus);
            //sql.Append(" left join PNode p on p.ID, 1, 36) = d.NodeID and p.Status=@Status");
            //sql.Append(" where d.Status=@Status");

            //if (StartDate != DateTime.MinValue)
            //{
            //    qlist.Add(new QueryField() { Name = "StartDate", Type = QueryFieldType.DateTime, Value = StartDate });
            //    sql.Append(" and date(d.StartDate)>=date(@StartDate)");
            //}

            //if (EndDate != DateTime.MinValue)
            //{
            //    qlist.Add(new QueryField() { Name = "EndDate", Type = QueryFieldType.DateTime, Value = EndDate });
            //    sql.Append(" and date(d.EndDate)<=date(@EndDate)");
            //}
            //if (PType > 0)
            //{
            //    qlist.Add(new QueryField() { Name = "PType", Type = QueryFieldType.Numeric, Value = PType });
            //    sql.Append(" and n.PType=@PType");
            //}
            //if (!string.IsNullOrEmpty(Manager))
            //{
            //    qlist.Add(new QueryField() { Name = "Manager", Type = QueryFieldType.String, Value = Manager });
            //    sql.Append(" and d.Manager=@Manager");
            //}
            //sql.Append(" order by d.CREATED");

            //StringBuilder sql = new StringBuilder();
            #endregion

            #region 2017/05/27 verson(nodes have no minstartdate and maxenddate)
            //StringBuilder sql = new StringBuilder();
            ////最外层
            //sql.Append(" select * from (");
            ////查询交付物
            //sql.Append(" select p.ID as KeyFieldName,p.ParentID as ParentFieldName,p.PID,d.Name,(cast(d.Workload as varchar) || '(天)') as Workload,date(d.StartDate) as StartDate,date(d.EndDate) as EndDate,d.Manager");
            //sql.Append(" ,d1.Name as Progress,p.WBSNo,1,length(p.WBSNo)-1) as WBSNo, p.CREATED from DeliverablesJBXX d");
            //sql.Append(" left join NodeProgress n on n.Status=@Status and d.NodeID=n.NodeID");
            //sql.Append(" left join DictItem d1 on n.PType = d1.No and d1.DictNo=" + (int)DictCategory.PlanFinishStatus);
            //sql.Append(" left join PNode p on p.ID, 1, 36) = d.NodeID");
            //sql.Append(" where d.Status=@Status and p.Status=@Status and p.PType=1");

            //if (StartDate != DateTime.MinValue)
            //{
            //    qlist.Add(new QueryField() { Name = "StartDate", Type = QueryFieldType.DateTime, Value = StartDate });
            //    sql.Append(" and date(d.StartDate)>=date(@StartDate)");
            //}

            //if (EndDate != DateTime.MinValue)
            //{
            //    qlist.Add(new QueryField() { Name = "EndDate", Type = QueryFieldType.DateTime, Value = EndDate });
            //    sql.Append(" and date(d.EndDate)<=date(@EndDate)");
            //}
            //if (PType > 0)
            //{
            //    qlist.Add(new QueryField() { Name = "PType", Type = QueryFieldType.Numeric, Value = PType });
            //    sql.Append(" and n.PType=@PType");
            //}
            //if (!string.IsNullOrEmpty(Manager))
            //{
            //    qlist.Add(new QueryField() { Name = "Manager", Type = QueryFieldType.String, Value = Manager });
            //    sql.Append(" and d.Manager=@Manager");
            //}
            ////sql.Append(" order by d.CREATED");
            ////交合
            //sql.Append(" union");
            ////查询节点
            //sql.Append(@" select distinct p1.ID as KeyFieldName,p1.ParentID as ParentFieldName,p1.PID,p1.Name,null as Workload,null as StartDate,null as EndDate,null as Manager,null as Progress, WBSNo,1,length(WBSNo)-1) as WBSNo,p1.CREATED from PNode p1 
            //              left join DeliverablesJBXX d1 on d1.NodeID = P1.ID
            //              where  p1.Status = 1 and (p1.PType<>1 or p1.PType is null)");
            ////最外层
            //sql.Append(" )");

            //sql.Append(" where PID=@PID"); //如果显示所有项目则注释掉此行
            //sql.Append(" order by PID,CREATED");
            //DataTable dt = NHHelper.ExecuteDataTable(sql.ToString(), qlist);
            //return dt;
            #endregion

            StringBuilder sql = new StringBuilder();
            //定义CTE(用于递归)
            sql.Append(@" With CT
                        AS
                        (
                            select M.*, N.StartDate, N.EndDate, N.name As N_name  from pnode M  left join deliverablesjbxx N on M.id, 1, 36) = N.nodeid ");
            if (PType > 0)
            {
                sql.Append(" inner join nodeprogress ng on ng.nodeid = m.id and ng.ptype=@PType");
            }
            if (!string.IsNullOrEmpty(Manager))
            {
                sql.Append(" inner join deliverableswork dw on dw.jbxxid = N.id and dw.manager=@Manager");
            }
            sql.Append("  where m.status = @Status and n.status = @Status ");
            if (StartDate != DateTime.MinValue)
            {
                sql.Append(" and date(N.StartDate)>=date(@StartDate)");
            }

            if (EndDate != DateTime.MinValue)
            {
                sql.Append(" and date(N.EndDate)<=date(@EndDate)");
            }
            sql.Append(@" union all
                            select M1.*, CT.StartDate, ct.enddate, CT.N_name from CT inner join pnode M1
                                on CT.parentid = M1.id, 1, 36)
                            where m1.status = @Status");
            
            sql.Append(")");
            //最外层
            sql.Append(" select * from (");
            //查询交付物
            sql.Append(" select p.ID as KeyFieldName,p.ParentID as ParentFieldName,p.PID,d.Name,(cast(d.Workload as varchar) || '(天)') as Workload,date(d.StartDate) as StartDate,date(d.EndDate) as EndDate,null as Manager");
            sql.Append(" ,d1.Name as Progress,p.WBSNo, p.CREATED from DeliverablesJBXX d");
            sql.Append(" left join NodeProgress n on n.Status=@Status and d.NodeID=n.NodeID");
            sql.Append(" left join DictItem d1 on n.PType = d1.No and d1.DictNo=" + (int)DictCategory.PlanFinishStatus);
            sql.Append(" left join PNode p on p.ID, 1, 36) = d.NodeID");

            if (!string.IsNullOrEmpty(Manager))
            {                
                sql.Append(" inner join deliverableswork dw on dw.jbxxid = d.id and dw.manager=@Manager");
            }

            sql.Append(" where d.Status=@Status and p.Status=@Status and p.PType=1");

            if (StartDate != DateTime.MinValue)
            {
                sql.Append(" and date(d.StartDate)>=date(@StartDate)");
            }

            if (EndDate != DateTime.MinValue)
            {
                sql.Append(" and date(d.EndDate)<=date(@EndDate)");
            }
            if (PType > 0)
            {
                sql.Append(" and n.PType=@PType");
            }
            //sql.Append(" order by d.CREATED");
            //交合
            sql.Append(" union");
            //查询节点
            sql.Append(@" select  p1.ID as KeyFieldName,p1.ParentID as ParentFieldName,p1.PID,p1.Name,null as Workload,date(min(StartDate)) As StartDate,date(max(enddate)) as enddate ,null as Manager,null as Progress, WBSNo,p1.CREATED from ct p1
                          where  p1.Status = @Status and (p1.PType=0 or p1.PType is null)
                          group by id");
            //最外层
            sql.Append(" )");

            sql.Append(" where PID=@PID"); //如果显示所有项目则注释掉此行
            sql.Append(" order by WBSNo,PID,CREATED");
            DataTable dt = NHHelper.ExecuteDataTable(sql.ToString(), qlist);
            return dt;
        }
    }
}

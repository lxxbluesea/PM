﻿using System;
using System.Collections;

namespace DomainDLL
{

    /// <summary>
    /// 问题管理
    /// </summary>
    public class Trouble : PersistenceEntity
    {
        /// <summary>
        /// 项目ID
        /// </summary>
        public virtual string PID
        {
            get;
            set;
        }
        /// <summary>
        /// 父节点ID
        /// </summary>
        public virtual string ParentNodeID
        {
            get;
            set;
        }
        /// <summary>
        /// Pnode节点ID
        /// </summary>
        public virtual string PnodeID
        {
            get;
            set;
        }
        /// <summary>
        /// 名称
        /// </summary>
        public virtual string Name
        {
            get;
            set;
        }
        /// <summary>
        /// 问题描述
        /// </summary>
        public virtual string Desc
        {
            get;
            set;
        }
        /// <summary>
        /// 开始日期
        /// </summary>
        public virtual DateTime? StartDate
        {
            get;
            set;
        }
        /// <summary>
        /// 结束日期
        /// </summary>
        public virtual DateTime? EndDate
        {
            get;
            set;
        }
        /// <summary>
        /// 问题级别
        /// </summary>
        public virtual int Level
        {
            get;
            set;
        }
        /// <summary>
        /// 工作量
        /// </summary>
        public virtual int? Workload
        {
            get;
            set;
        }
        /// <summary>
        /// 处理情况
        /// </summary>
        public virtual int HandleStatus
        {
            get;
            set;
        }

        /// <summary>
        /// 处理结果
        /// </summary>
        public virtual string HandleResult
        {
            get;
            set;
        }
    }
}
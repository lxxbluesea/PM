﻿using System;
using System.Collections;

namespace DomainDLL
{
    /// <summary>
    /// 日常工作
    /// </summary>
    public class Routine : PersistenceEntity
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
        /// 内容描述
        /// </summary>
        public virtual string Desc
        {
            get;
            set;
        }
        /// <summary>
        /// 处理结果
        /// </summary>
        public virtual string DealResult
        {
            get;
            set;
        }

        /// <summary>
        /// 工作量（天）
        /// </summary>
        public virtual decimal? Workload
        {
            get;
            set;
        }
        /// <summary>
        /// 权值
        /// </summary>
        public virtual int? Weight
        {
            get;

            set;
        }

        public virtual DateTime? StartDate
        {
            get;
            set;
        }
        public virtual DateTime? EndDate
        {
            get;
            set;
        }
        /// <summary>
        /// 完成情况
        /// 1 未开始 
        /// 2 进行中
        /// 3 已完成
        /// </summary>
        public virtual int? FinishStatus
        {
            get;
            set;
        }
    }
}

using System;
using System.Collections;

namespace DomainDLL
{
    /// <summary>
    /// 交付物跟进
    /// </summary>
    public class NodeTrace : PersistenceEntity
    {
        /// <summary>
        /// Node的ID
        /// </summary>
        public virtual string NodeID
        {
            get;
            set;
        }
        /// <summary>
        /// 跟进内容
        /// </summary>
        public virtual string Content
        {
            get;
            set;
        }
        /// <summary>
        /// 跟进日期
        /// 
        /// </summary>
        public virtual DateTime TraceDate
        {
            get;
            set;
        }

    }
}

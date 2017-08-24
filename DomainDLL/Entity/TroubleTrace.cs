using System;
using System.Collections;

namespace DomainDLL
{
    /// <summary>
    /// 日常工作附件
    /// </summary>
    public class TroubleTrace : PersistenceEntity
    {
        /// <summary>
        /// 日常工作DailyWork的ID
        /// </summary>
        public virtual string TroubleID
        {
            get;
            set;
        }
        /// <summary>
        /// 附件名称
        /// </summary>
        public virtual string Content
        {
            get;
            set;
        }
        /// <summary>
        /// 存放路径
        /// </summary>
        public virtual DateTime TraceDate
        {
            get;
            set;
        }

    }
}

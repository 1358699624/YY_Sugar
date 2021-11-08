using SqlSugar;
using System;
using System.Collections.Generic;
using System.Text;

namespace YY_Model
{
  public  class NewsTable
    {

        [SugarColumn(IsIdentity = true, IsPrimaryKey = true)]
        public int Id { get; set; }

        public string Types { get; set; }//类型

        [SugarColumn(ColumnDataType = "Nvarchar(255)")]//自定格式的情况 length不要设置
        public string Text { get; set; }

        [SugarColumn(IsNullable = true)]
        public DateTime CreateTime { get; set; }

    }
}

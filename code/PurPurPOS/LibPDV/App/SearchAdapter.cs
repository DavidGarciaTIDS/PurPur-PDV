using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibBD;

namespace LibPDV.App
{
    public class SearchAdapter 
    {
        public string Name { get; set; }
        public CriteriaOperator Operator { get; set; }
        public object Value { get; set; }
        public bool IsVarchar { get; set; }
        public LogicOperator LogicOp { get; set; }

        public SearchAdapter(SearchCollection search) 
        {
            this.Name = search.Name;
            this.Operator = search.Operator;
            this.Value = search.Value;
            this.IsVarchar = search.IsVarchar;
            this.LogicOp = search.LogicOp;
        }

        public SearchCollection adaptToCollect() 
        {
            SearchCollection temp = new SearchCollection(this.Name,this.Operator,this.Value,this.IsVarchar,this.LogicOp);

            return temp ;
        }


        public string ParseOperator(CriteriaOperator op)
        {
            string res = "";
            /* 
        EQUALS
        NOT_EQUALS,
        GREATER_THAN,
        LESS_THAN,
        GREATER_THAN_EQUALS,
        LESS_THAN_EQUALS,
        LIKE
            */
            switch (op)
            {
                case CriteriaOperator.EQUALS:
                    res = "=";
                    break;
                case CriteriaOperator.GREATER_THAN:
                    res = ">";
                    break;
                case CriteriaOperator.GREATER_THAN_EQUALS:
                    res = ">=";
                    break;
                case CriteriaOperator.LESS_THAN:
                    res = "<";
                    break;
                case CriteriaOperator.LESS_THAN_EQUALS:
                    res = "<=";
                    break;
                case CriteriaOperator.LIKE:
                    res = "LIKE";
                    break;
                case CriteriaOperator.NOT_EQUALS:
                    res = "!=";
                    break;


                default:
                    res = "LIKE";
                    break;
            }
            return res;
        }

        public string ParseLogicOperator(LogicOperator op)
        {
            string res = "";
            /* 
        AND,
        OR,
        NOTHING
            */
            switch (op)
            {
                case LogicOperator.OR:
                    res = "OR";
                    break;
                case LogicOperator.AND:
                    res = "AND";
                    break;
                case LogicOperator.NOTHING:
                    res = "";
                    break;

                default:
                    res = "";
                    break;
            }
            return res;
        }
    }
}

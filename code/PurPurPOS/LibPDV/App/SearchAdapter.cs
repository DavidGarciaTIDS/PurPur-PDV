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

        public SearchAdapter(string name, CriteriaOperator Operat, object value, bool isString, LogicOperator LogicOper = LogicOperator.NOTHING)
        {
            this.Name = name;
            this.Operator = Operat;
            this.Value = value;
            this.IsVarchar = isString;
            this.LogicOp = LogicOper;
        }


        public SearchAdapter()
        {
            this.Name = "";
            this.Value = 1;
            this.Operator = CriteriaOperator.NULL;
            this.IsVarchar = false;
            this.LogicOp = LogicOperator.NOTHING;
        }

        public SearchCollection adaptToCollect()
        {
            SearchCollection temp = new SearchCollection(this.Name, this.Operator, this.Value, this.IsVarchar, this.LogicOp);

            return temp;
        }

        public List<SearchCollection> ListAdapCollect(List<SearchAdapter> SA)
        {
            List<SearchCollection> SC = new List<SearchCollection>();
            foreach (SearchAdapter item in SA)
            {
                SC.Add(new SearchCollection(item.Name, item.Operator, item.Value, item.IsVarchar, item.LogicOp));
            }
            return SC;
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

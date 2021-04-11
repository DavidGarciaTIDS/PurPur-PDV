using LibBD;
using LibPDV.App;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibPDV.Users
{
    public class Users : CRUD
    {
        public Users() : base("users", new List<string>() { "name","lastname","mothers_lastname","email","password","types","street","house_No","residential","PO","region_state","CURP","RFC"})
        {
        }

        public string Name { get; set; }
        public string Lastname { get; set; }
        public string Motherslastname { get; set; }
        public string Email { get; set; }
        public string PWD { get; set; }
        public UserLevels UsLv { get; set; }
        public string Street { get; set; }
        public string HouseNo { get; set; }
        public string Residential { get; set; }
        public string PO { get; set; }
        public string RegionState { get; set; }
        public string CURP { get; set; }
        public string RFC { get; set; }

        public bool UserLogin(string email, string pw) 
        {
            List<SearchCollection> temp = new List<SearchCollection>();
            SearchCollection UsPw = new SearchCollection("email",CriteriaOperator.EQUALS, (object)email, true,LogicOperator.AND);
            temp.Add(UsPw);
            UsPw = new SearchCollection("password",CriteriaOperator.EQUALS,(object)pw,true, LogicOperator.NOTHING);
            temp.Add(UsPw);
            
            List<List<DataCollection>> res = base.Read(new List<string>() { "email" }, temp);

            if (res.Count == 0 || res.Count>1)
                return false;
            else 
                return true;
            
        }
        
        
        public bool Create(string name, string lastname, string mothers_lastname, string email, string password, UserLevels UserLv,string street, string house_No, string residential, string PO, string region_state, string CURP, string RFC)
        {
            List<DataCollection> data = new List<DataCollection>();
            data.Add(new DataCollection("name", Types.VARCHAR, name));
            data.Add(new DataCollection("lastname", Types.VARCHAR, lastname));
            data.Add(new DataCollection("mothers_lastname", Types.VARCHAR, mothers_lastname));
            data.Add(new DataCollection("email", Types.VARCHAR, email));
            data.Add(new DataCollection("password", Types.VARCHAR, password));
            data.Add(new DataCollection("type", Types.VARCHAR, UserLv));
            data.Add(new DataCollection("street", Types.VARCHAR, street));
            data.Add(new DataCollection("house_number", Types.VARCHAR, house_No));
            data.Add(new DataCollection("residential", Types.VARCHAR, residential));
            data.Add(new DataCollection("PO", Types.VARCHAR, PO));
            data.Add(new DataCollection("region_state", Types.VARCHAR, region_state));
            data.Add(new DataCollection("CURP", Types.VARCHAR, CURP));
            data.Add(new DataCollection("RFC", Types.VARCHAR, RFC));

            bool res = base.Create(data);

            if (!res)
            {
                this.ERROR = BD.ERROR;
            }
            return res;

        }

        public List<List<DataCollection>> Read(List<string> fields, SearchCollection searching)
        {
            List<SearchCollection> search = new List<SearchCollection>();
            search.Add(searching);

            List<List<DataCollection>> res = base.Read(fields, search);

            if (res.Count == 0)
            {
                this.ERROR = BD.ERROR;
                List<List<DataCollection>> err = new List<List<DataCollection>>();
                return err;
            }

            foreach (List<DataCollection> lista in res)
            {
                Console.WriteLine("-----------------");
                foreach (DataCollection objeto in lista)
                {
                    Console.WriteLine(objeto.ToString());
                    Console.WriteLine("*****************");
                }
            }
            return res;
        }
    }
}




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
        public Users() : base("users", new List<string>() { "id", "name", "lastname", "mothers_lastname", "email", "password", "types", "street", "house_No", "residential", "PO", "region_state", "CURP", "RFC" })
        {
        }
        private Users(List<DataCollection> data) : base("users", new List<string>() { "name", "lastname", "mothers_lastname", "email", "password", "types", "street", "house_No", "residential", "PO", "region_state", "CURP", "RFC" })
        {

            this.id = data[0].Value.ToString();
            this.Name = data[1].Value.ToString();
            this.Lastname = data[2].Value.ToString();
            this.Motherslastname = data[3].Value.ToString();
            this.Email = data[4].Value.ToString();
            this.PWD = "";
            this.UsLv = (UserLevels)Enum.Parse(typeof(UserLevels), data[6].Value.ToString());
            this.Street = data[7].Value.ToString();
            this.HouseNo = data[8].Value.ToString();
            this.Residential = data[9].Value.ToString();
            this.PO = data[10].Value.ToString();
            this.RegionState = data[11].Value.ToString();
            this.CURP = data[12].Value.ToString();
            this.RFC = data[13].Value.ToString();

        }

        public string id { get; set; }
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



        public Users UserLogin(string email, string pw)
        {
            List<SearchCollection> temp = new List<SearchCollection>();
            temp.Add(new SearchCollection("email", CriteriaOperator.EQUALS, (object)email, true, LogicOperator.AND));
            temp.Add(new SearchCollection("password", CriteriaOperator.EQUALS, (object)pw, true, LogicOperator.NOTHING));
            List<List<DataCollection>> res = base.Read(new List<string>() { "*" }, temp);
            Users LogUser;
            if (res.Count > 0)
            {
                List<DataCollection> DBuser = res[0];
                LogUser = new Users()
                {

                    id = DBuser[0].Value.ToString(),
                    Name = DBuser[1].Value.ToString(),
                    Lastname = DBuser[2].Value.ToString(),
                    Motherslastname = DBuser[3].Value.ToString(),
                    Email = DBuser[4].Value.ToString(),
                    PWD = "",
                    UsLv = StringToUsLv(DBuser[6].Value.ToString()),
                    Street = DBuser[7].Value.ToString(),
                    HouseNo = DBuser[8].Value.ToString(),
                    Residential = DBuser[9].Value.ToString(),
                    PO = DBuser[10].Value.ToString(),
                    RegionState = DBuser[11].Value.ToString(),
                    CURP = DBuser[12].Value.ToString(),
                    RFC = DBuser[13].Value.ToString()

                };
            }
            else 
            {
                LogUser = null;
            }

            return LogUser;
        }


        public bool Create(string name, string lastname, string mothers_lastname, string email, string password, UserLevels UserLv, string street, string house_No, string residential, string PO, string region_state, string CURP, string RFC)
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
                res = new List<List<DataCollection>>();

            }

            return res;
        }
        public string fullName()
        {
            return this.Name + " " + this.Lastname + " " + this.Motherslastname;
        }
        private UserLevels StringToUsLv(string UsLv) 
        {
            UsLv = UsLv.Replace("'","");
            switch (UsLv)
            {
                case "ADMIN":
                    return UserLevels.ADMIN;
                    break;
                case "CASHIER":
                    return UserLevels.CASHIER;
                    break;

                case "SUPERUSER":
                    return UserLevels.SUPERUSER;
                    break;

                default:
                    return UserLevels.UNKWOWN;
                    break;
            }

        }
    }
}




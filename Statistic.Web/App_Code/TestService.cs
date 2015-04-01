using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Text;

[ServiceContract(Namespace = "")]
[AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
public class TestService
{
    private string connStr = ConfigurationManager.ConnectionStrings["trg.pro"].ConnectionString;
    private string connStrTest = ConfigurationManager.ConnectionStrings["somee.com"].ConnectionString;
    [DataContract]
    public class dbItemss
    {
        private string m_id;
        private string m_datetime;
        private string m_flight;
        private string m_name;

        [DataMember]
        public string Id
        {
            get { return m_id; }
            set { m_id = value; }
        }
        [DataMember]
        public string Datetime
        {
            get { return m_datetime; }
            set { m_datetime = value; }
        }
        [DataMember]
        public string Flight
        {
            get { return m_flight; }
            set { m_flight = value; }
        }
        [DataMember]
        public string Name
        {
            get { return m_name; }
            set { m_name = value; }
        }

    }



	[OperationContract]
	public string GetServerTIme()
	{
		// Add your operation implementation here
        return DateTime.Now.ToString() ;
	}

    [OperationContract]
    public List<dbItemss> sqlTest()
    {
        List<dbItemss> returnList = new List<dbItemss>();
        

        using (SqlConnection con = new SqlConnection(connStr))
        {
            con.Open();

            using (SqlCommand command = new SqlCommand("SELECT * FROM CHGLOG", con))
            {
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string id = reader.GetInt32(0).ToString(); 
                    string dateTime = reader.GetString(1);
                    string flight = reader.GetString(2);
                    string originUser = reader.GetString(3);
                    returnList.Add(new dbItemss() { Id = id, Datetime = dateTime, Flight = flight, Name = originUser });
                }
            }
            con.Close();
        }
        return returnList;
    }
    [OperationContract]
    public void addCHG(string message)
    {
        string [] MESSAGES = message.Split(' ');
        using (SqlConnection con = new SqlConnection(connStr))
        {
            
            StringBuilder sb = new StringBuilder();
            sb.Append("INSERT INTO CHGLOG (DateTime,Flight,OriginUser) VALUES ('");
            sb.Append(MESSAGES[0]);
            sb.Append(" ");
            sb.Append(MESSAGES[1]);
            sb.Append("','");
            sb.Append(MESSAGES[2]);
            sb.Append("','");
            sb.Append(MESSAGES[3]);
            sb.Append("')");
            //INSERT INTO CHGLOG (DateTime,Flight,OriginUser) VALUES ('121212','SDM2299','ROMAN')
            using (SqlCommand command = new SqlCommand(sb.ToString(), con))
            {
                command.Connection.Open();
                command.ExecuteNonQuery();
                command.Connection.Close();
            }
            
        }
    
    }
	// Add more operations here and mark them with [OperationContract]
}
